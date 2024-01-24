﻿using log4net.Config;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ZslCustomsAssist.Runtime;
using ZslCustomsAssist.Service.Rest;

namespace ZslCustomsAssist.Utils.Log
{
    public class LogHelper
    {
        private static ILog log;
        private static LogHelper logHelper = (LogHelper)null;

        private static ILog GetInstance()
        {
            LogHelper.logHelper = new LogHelper((string)null);
            return LogHelper.log;
        }

        private static ILog GetInstance(string configPath)
        {
            LogHelper.logHelper = new LogHelper(configPath);
            return LogHelper.log;
        }

        public static void Debug(object log, string invNo = "", int indentValue = 0)
        {
            string str1 = "";
            string str2 = LogHelper.GetIndentStr(indentValue) + str1;
            if (invNo != "")
                str2 = str2 + "【" + invNo + "】";
            string str3 = str2 + log.ToString();
            string message = LogHelper.GetIndentStr(indentValue) + str3;
            LogHelper.GetInstance().Debug((object)message);
        }

        public static void Info(object log, string invNo = "", int indentValue = 0)
        {
            string str1 = "";
            string str2 = LogHelper.GetIndentStr(indentValue) + str1;
            if (invNo != "")
                str2 = str2 + "【" + invNo + "】";
            string message = str2 + log.ToString();
            LogHelper.GetInstance().Info((object)message);
        }

        public static void Error(Exception ex, string invNo = "", int indentValue = 0)
        {
            string str1 = "";
            string str2 = LogHelper.GetIndentStr(indentValue) + str1;
            if (invNo != "")
                str2 = str2 + "【" + invNo + "】";
            string message = str2 + ex.Message + "堆栈信息:" + ex.StackTrace;
            LogHelper.GetInstance().Error((object)message);
        }

        public static void Fatal(Exception ex, string invNo = "", int indentValue = 0)
        {
            string str1 = "";
            string str2 = LogHelper.GetIndentStr(indentValue) + str1;
            if (invNo != "")
                str2 = str2 + "【" + invNo + "】";
            string str3 = str2 + ex.Message + "堆栈信息:" + ex.StackTrace;
            string message = LogHelper.GetIndentStr(indentValue) + str3;
            LogHelper.GetInstance().Fatal((object)message);
        }

        private LogHelper(string configPath)
        {
            if (!string.IsNullOrWhiteSpace(configPath))
            {
                LogHelper.log = LogManager.GetLogger("Log4NetTest.LogTest");
                XmlConfigurator.Configure(new FileInfo(configPath));
            }
            else
                LogHelper.log = LogManager.GetLogger("Log4NetTest.LogTest");
        }

        public static string GetIndentStr(int indentValue)
        {
            string indentStr = "";
            for (; indentValue > 0; --indentValue)
                indentStr += "\t";
            return indentStr;
        }

        public static void SaveInvNoLog(string invNo, string log)
        {
        }

        public static void SaveReportSignLog(
            LogType logType,
            LogLevel level,
            string fileName,
            string log)
        {
        }

        public static void SaveLog(string log, LogLevel level)
        {
            string message = log;
            switch (level)
            {
                case LogLevel.Debug:
                    LogHelper.GetInstance().Fatal((object)message);
                    break;
                case LogLevel.Info:
                    LogHelper.GetInstance().Info((object)message);
                    break;
                case LogLevel.Error:
                    LogHelper.GetInstance().Error((object)message);
                    break;
                case LogLevel.Fatal:
                    LogHelper.GetInstance().Fatal((object)message);
                    break;
            }
        }

        public static string GetAttributesNValueFromObject(object obj, string objName)
        {
            if (obj == null)
                return objName + "为null!";
            string nvalueFromObject = "【" + obj.GetType().Name + "】对象键值对信息如下：";
            foreach (PropertyInfo property in obj.GetType().GetProperties())
            {
                string name1 = property.Name;
                string name2 = property.PropertyType.Name;
                string str;
                try
                {
                    str = property.GetValue(obj, (object[])null) != null ? LogHelper.CutLongValue(property.GetValue(obj, (object[])null).ToString()) : "null";
                }
                catch (Exception ex)
                {
                    str = "**取值异常**";
                    LogHelper.Error(ex, name1 + "取值异常！");
                }
                nvalueFromObject = nvalueFromObject + "\n【" + property.Name + "】" + name2 + "：" + str;
            }
            return nvalueFromObject;
        }

        public static string GetVarName<T>(Expression<Func<T, T>> exp) => ((MemberExpression)exp.Body).Member.Name;

        public static bool ContentInUsedTypes(string typeName) => new List<string>()
        {
            "Int16",
            "UInt16",
            "Int32",
            "UInt32",
            "UInt64",
            "String",
            "Byte",
            "SByte",
            "Double",
            "Single",
            "Decimal",
            "Char",
            "Boolean"
        }.Contains(typeName);

        public static string CutLongValue(string value)
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Length > 3000)
                value = "【" + value.Substring(0, 3000) + "】略...";
            return value;
        }

        public static string HidingSensitiveValue(string value) => ServerCore.IsDebugModel && !string.IsNullOrWhiteSpace(value) ? value : new StringBuilder("").ToString();

        internal static void SaveLog(string v, ApiResult<List<ReportMessage>>? apiResult)
        {
            throw new NotImplementedException();
        }
    }
}
