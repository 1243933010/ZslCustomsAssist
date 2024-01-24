﻿using Newtonsoft.Json;
using sun.security.util;
using System.Diagnostics;
using ZslCustomsAssist.Runtime;
using ZslCustomsAssist.Server.Enum;
using ZslCustomsAssist.Service;
using ZslCustomsAssist.Service.Rest;
using ZslCustomsAssist.Utils;
using ZslCustomsAssist.Utils.Log;
namespace ZslCustomsAssist.Jobs
{
    internal class SendReportRequestJobJD
    {
        public void OnDoJob()
        {
           // if (ServerCore.clientConfig.JDReportSendDir != "" && !Directory.Exists(ServerCore.clientConfig.JDReportSendDir))
           // {
            //    Directory.CreateDirectory(ServerCore.clientConfig.JDReportSendDir);
          //  }

            while (true)
            {
                if (!ServerCore.IsExitThread)
                {
                    try
                    {
                        this.RequestReport();
                    }
                    catch (Exception ex)
                    {
                        AbstractLog.logger.Error((object)"请求报文异常", ex);
                    }
                    Thread.Sleep(5000);
                }
                else
                    break;
            }
        }

        public void RequestReport()
        {
            Stopwatch stopwatch = new Stopwatch();
            long wholeMilliseconds = 0;
            stopwatch.Start();

            ApiService apiService = new();
            List<ReportMessage> reports = null;
            try
            {
                reports = apiService.RequestReportJD(out string msg);

            }
            catch (Exception ex)
            {
                string str = "获取订单报文发生异常！（耗时：" + (object)DateHelper.GetStopWatchTime(ref wholeMilliseconds, stopwatch, true) + "ms）";
                AbstractLog.logger.Error((object)str, ex);
            }
            //MessageBox.Show(reports.Count.ToString());
            if (reports != null && reports.Count > 0)
            {

                List<string> strArr = new List<string>();
                foreach (ReportMessage report in reports)
                {

                    string fileName = report.FileName + ".report";

                    string fullPath = Path.Combine(ServerCore.clientConfig.ReportSendDir, fileName);
                    FileInfo fileInfo = new(fullPath);
                    if (File.Exists(fullPath))
                    {
                        string str = "重名文件" + fileName + "(创建时间：" + fileInfo.CreationTime.ToString("yyyy-MM-dd hh:mm:ss") + ")在待处理目录已存在，请勿重复发送！";
                        AbstractLog.logger.Error((object)str);
                        ServerCore.AddMainLog(str, EnumLogLevel.Error);
                        ServerCore.AddReportSendFailSum();
                        continue;
                    }
                    try
                    {


                        new Thread((ThreadStart)(() =>
                        {
                            // var str = Encrypter.DefaultEncodeAES(JsonConvert.SerializeObject((object)report));
                            // strArr.Add(str);
                            File.WriteAllText(fullPath, Encrypter.DefaultEncodeAES(JsonConvert.SerializeObject((object)report)));
                            SendReportStatus(report.ID, report.Type, 3, "处理中...");
                        })).Start();
                        Thread.Sleep(2);
                    }
                    catch (Exception ex)
                    {
                        string err = "写入文件" + fileName + "失败";
                        AbstractLog.logger.Error((object)(err + "（耗时：" + (object)DateHelper.GetStopWatchTime(ref wholeMilliseconds, stopwatch, true) + "ms）"), ex);
                       // SendReportStatus(report.ID, report.Type, -1, err);
                    }
                }
                // var responsestr = string.Join("=================", strArr);
                //  MessageBox.Show(responsestr);
                //Console.WriteLine(responsestr);
            }

            stopwatch.Stop();
            //AbstractLog.logger.Debug((object)("获取订单报文，本次请求耗时：" + (object)wholeMilliseconds + "ms"));
        }


        private void SendReportStatus(string id, int type, int status, string message)
        {
            List<ReportStatus> list = new() {
                new ReportStatus { ID = id, Type = type, Status= status, Message = message }
            };
            try
            {
                new ApiService().UpdateReportStatus(list, out string msg);
            }
            catch (Exception ex) { }
        }
    }
}
