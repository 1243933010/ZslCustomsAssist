﻿namespace ZslCustomsAssist
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtUkeyPasswd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.labCardNo = new System.Windows.Forms.Label();
            this.labUkeyPasswd = new System.Windows.Forms.Label();
            this.labAppSecret = new System.Windows.Forms.Label();
            this.labAppId = new System.Windows.Forms.Label();
            this.txtAppId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAppSecret = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUkeyPasswd
            // 
            this.txtUkeyPasswd.Location = new System.Drawing.Point(131, 71);
            this.txtUkeyPasswd.MaxLength = 8;
            this.txtUkeyPasswd.Name = "txtUkeyPasswd";
            this.txtUkeyPasswd.PasswordChar = '*';
            this.txtUkeyPasswd.Size = new System.Drawing.Size(249, 23);
            this.txtUkeyPasswd.TabIndex = 0;
            this.txtUkeyPasswd.UseSystemPasswordChar = true;
            this.txtUkeyPasswd.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "UKey密码：";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(132, 224);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录(&L)";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(231, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labMsg
            // 
            this.labMsg.AutoSize = true;
            this.labMsg.ForeColor = System.Drawing.Color.Red;
            this.labMsg.Location = new System.Drawing.Point(132, 264);
            this.labMsg.Name = "labMsg";
            this.labMsg.Size = new System.Drawing.Size(0, 17);
            this.labMsg.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "当前卡号：";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(131, 24);
            this.txtCardNo.MaxLength = 0;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.ReadOnly = true;
            this.txtCardNo.Size = new System.Drawing.Size(249, 23);
            this.txtCardNo.TabIndex = 7;
            // 
            // labCardNo
            // 
            this.labCardNo.AutoSize = true;
            this.labCardNo.ForeColor = System.Drawing.Color.Red;
            this.labCardNo.Location = new System.Drawing.Point(133, 50);
            this.labCardNo.Name = "labCardNo";
            this.labCardNo.Size = new System.Drawing.Size(0, 17);
            this.labCardNo.TabIndex = 8;
            // 
            // labUkeyPasswd
            // 
            this.labUkeyPasswd.AutoSize = true;
            this.labUkeyPasswd.ForeColor = System.Drawing.Color.Red;
            this.labUkeyPasswd.Location = new System.Drawing.Point(133, 97);
            this.labUkeyPasswd.Name = "labUkeyPasswd";
            this.labUkeyPasswd.Size = new System.Drawing.Size(117, 17);
            this.labUkeyPasswd.TabIndex = 9;
            this.labUkeyPasswd.Text = "请输入8位UKey密码";
            // 
            // labAppSecret
            // 
            this.labAppSecret.AutoSize = true;
            this.labAppSecret.ForeColor = System.Drawing.Color.Red;
            this.labAppSecret.Location = new System.Drawing.Point(133, 190);
            this.labAppSecret.Name = "labAppSecret";
            this.labAppSecret.Size = new System.Drawing.Size(140, 17);
            this.labAppSecret.TabIndex = 15;
            this.labAppSecret.Text = "请输入中商旅AppSecret";
            // 
            // labAppId
            // 
            this.labAppId.AutoSize = true;
            this.labAppId.ForeColor = System.Drawing.Color.Red;
            this.labAppId.Location = new System.Drawing.Point(133, 143);
            this.labAppId.Name = "labAppId";
            this.labAppId.Size = new System.Drawing.Size(116, 17);
            this.labAppId.TabIndex = 14;
            this.labAppId.Text = "请输入中商旅AppId";
            // 
            // txtAppId
            // 
            this.txtAppId.Location = new System.Drawing.Point(131, 117);
            this.txtAppId.MaxLength = 0;
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.Size = new System.Drawing.Size(249, 23);
            this.txtAppId.TabIndex = 1;
            this.txtAppId.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "应用ID：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "应用密钥：";
            // 
            // txtAppSecret
            // 
            this.txtAppSecret.Location = new System.Drawing.Point(131, 164);
            this.txtAppSecret.MaxLength = 0;
            this.txtAppSecret.Name = "txtAppSecret";
            this.txtAppSecret.PasswordChar = '*';
            this.txtAppSecret.Size = new System.Drawing.Size(249, 23);
            this.txtAppSecret.TabIndex = 2;
            this.txtAppSecret.UseSystemPasswordChar = true;
            this.txtAppSecret.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 295);
            this.ControlBox = false;
            this.Controls.Add(this.labAppSecret);
            this.Controls.Add(this.labAppId);
            this.Controls.Add(this.txtAppId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAppSecret);
            this.Controls.Add(this.labUkeyPasswd);
            this.Controls.Add(this.labCardNo);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labMsg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUkeyPasswd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录中商旅报关辅助程序";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUkeyPasswd;
        private Label label1;
        private Button btnLogin;
        private Button btnCancel;
        private Label labMsg;
        private Label label2;
        private TextBox txtCardNo;
        private Label labCardNo;
        private Label labUkeyPasswd;
        private Label labAppSecret;
        private Label labAppId;
        private TextBox txtAppId;
        private Label label5;
        private Label label6;
        private TextBox txtAppSecret;
    }
}