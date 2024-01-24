﻿namespace ZslCustomsAssist
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripMenuItem_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.richTBLog = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labReceiptSuccess = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labReceipting = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labReceiptTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labSendFail = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labSendSuccess = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labSending = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labSendTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.Lable3 = new System.Windows.Forms.Label();
            this.abstractNum = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(879, 293);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(74, 36);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "测试(&T)";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(879, 347);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(74, 36);
            this.btnSign.TabIndex = 3;
            this.btnSign.Text = "加签(&S)";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "中商旅报关辅助客户端(v1.0)";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItem_Show,
            this.StripMenuItem_Exit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(117, 48);
            this.contextMenuStrip.Text = "中商旅跨境购";
            // 
            // StripMenuItem_Show
            // 
            this.StripMenuItem_Show.Name = "StripMenuItem_Show";
            this.StripMenuItem_Show.Size = new System.Drawing.Size(116, 22);
            this.StripMenuItem_Show.Text = "显示(&V)";
            this.StripMenuItem_Show.Click += new System.EventHandler(this.StripMenuItem_Show_Click);
            // 
            // StripMenuItem_Exit
            // 
            this.StripMenuItem_Exit.Name = "StripMenuItem_Exit";
            this.StripMenuItem_Exit.Size = new System.Drawing.Size(116, 22);
            this.StripMenuItem_Exit.Text = "退出(&E)";
            this.StripMenuItem_Exit.Click += new System.EventHandler(this.StripMenuItem_Exit_Click);
            // 
            // richTBLog
            // 
            this.richTBLog.BackColor = System.Drawing.Color.White;
            this.richTBLog.Location = new System.Drawing.Point(12, 104);
            this.richTBLog.Name = "richTBLog";
            this.richTBLog.ReadOnly = true;
            this.richTBLog.Size = new System.Drawing.Size(852, 384);
            this.richTBLog.TabIndex = 4;
            this.richTBLog.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.abstractNum);
            this.panel1.Controls.Add(this.Lable3);
            this.panel1.Controls.Add(this.labReceiptSuccess);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labReceipting);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labReceiptTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 45);
            this.panel1.TabIndex = 8;
            // 
            // labReceiptSuccess
            // 
            this.labReceiptSuccess.AutoSize = true;
            this.labReceiptSuccess.Location = new System.Drawing.Point(442, 14);
            this.labReceiptSuccess.Name = "labReceiptSuccess";
            this.labReceiptSuccess.Size = new System.Drawing.Size(15, 17);
            this.labReceiptSuccess.TabIndex = 13;
            this.labReceiptSuccess.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "已推送：";
            // 
            // labReceipting
            // 
            this.labReceipting.AutoSize = true;
            this.labReceipting.Location = new System.Drawing.Point(264, 14);
            this.labReceipting.Name = "labReceipting";
            this.labReceipting.Size = new System.Drawing.Size(15, 17);
            this.labReceipting.TabIndex = 11;
            this.labReceipting.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "接收中：";
            // 
            // labReceiptTotal
            // 
            this.labReceiptTotal.AutoSize = true;
            this.labReceiptTotal.Location = new System.Drawing.Point(85, 14);
            this.labReceiptTotal.Name = "labReceiptTotal";
            this.labReceiptTotal.Size = new System.Drawing.Size(15, 17);
            this.labReceiptTotal.TabIndex = 9;
            this.labReceiptTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "回执接收：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labSendFail);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.labSendSuccess);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.labSending);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.labSendTotal);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(12, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 45);
            this.panel2.TabIndex = 9;
            // 
            // labSendFail
            // 
            this.labSendFail.AutoSize = true;
            this.labSendFail.Location = new System.Drawing.Point(632, 14);
            this.labSendFail.Name = "labSendFail";
            this.labSendFail.Size = new System.Drawing.Size(15, 17);
            this.labSendFail.TabIndex = 15;
            this.labSendFail.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(568, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "发送失败：";
            // 
            // labSendSuccess
            // 
            this.labSendSuccess.AutoSize = true;
            this.labSendSuccess.Location = new System.Drawing.Point(442, 14);
            this.labSendSuccess.Name = "labSendSuccess";
            this.labSendSuccess.Size = new System.Drawing.Size(15, 17);
            this.labSendSuccess.TabIndex = 13;
            this.labSendSuccess.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "发送成功：";
            // 
            // labSending
            // 
            this.labSending.AutoSize = true;
            this.labSending.Location = new System.Drawing.Point(264, 14);
            this.labSending.Name = "labSending";
            this.labSending.Size = new System.Drawing.Size(15, 17);
            this.labSending.TabIndex = 11;
            this.labSending.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "发送中：";
            // 
            // labSendTotal
            // 
            this.labSendTotal.AutoSize = true;
            this.labSendTotal.Location = new System.Drawing.Point(85, 14);
            this.labSendTotal.Name = "labSendTotal";
            this.labSendTotal.Size = new System.Drawing.Size(15, 17);
            this.labSendTotal.TabIndex = 9;
            this.labSendTotal.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "请求报文：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labMsg);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-1, 494);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 38);
            this.panel3.TabIndex = 10;
            // 
            // labMsg
            // 
            this.labMsg.AutoSize = true;
            this.labMsg.ForeColor = System.Drawing.Color.OrangeRed;
            this.labMsg.Location = new System.Drawing.Point(697, 11);
            this.labMsg.Name = "labMsg";
            this.labMsg.Size = new System.Drawing.Size(44, 17);
            this.labMsg.TabIndex = 1;
            this.labMsg.Text = "运行中";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前状态：";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(788, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "退出(&E)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Lable3
            // 
            this.Lable3.AutoSize = true;
            this.Lable3.Location = new System.Drawing.Point(574, 11);
            this.Lable3.Name = "Lable3";
            this.Lable3.Size = new System.Drawing.Size(68, 17);
            this.Lable3.TabIndex = 14;
            this.Lable3.Text = "摘要加密：";
            // 
            // AbstractNum
            // 
            this.abstractNum.AutoSize = true;
            this.abstractNum.Location = new System.Drawing.Point(634, 11);
            this.abstractNum.Name = "abstractNum";
            this.abstractNum.Size = new System.Drawing.Size(15, 17);
            this.abstractNum.TabIndex = 15;
            this.abstractNum.Text = "0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 532);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTBLog);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "中商旅报关辅助客户端(v1.0)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSend;
        private Button btnSign;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem StripMenuItem_Show;
        private ToolStripMenuItem StripMenuItem_Exit;
        public RichTextBox richTBLog;
        private Panel panel1;
        public Label labReceiptSuccess;
        private Label label6;
        public Label labReceipting;
        private Label label4;
        public Label labReceiptTotal;
        private Label label2;
        private Panel panel2;
        public Label labSendFail;
        private Label label13;
        public Label labSendSuccess;
        private Label label8;
        public Label labSending;
        private Label label10;
        public Label labSendTotal;
        private Label label12;
        private Panel panel3;
        public Label labMsg;
        private Label label1;
        private Button btnExit;
        public Label abstractNum;
        private Label Lable3;
    }
}