namespace CotizaYA_00
{
    partial class FrmEmail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.Setting = new System.Windows.Forms.GroupBox();
            this.txtSmtp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.checkSSL = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblFile = new System.Windows.Forms.Label();
            this.Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asunto:";
            // 
            // txtMessage
            // 
            this.txtMessage.AutoSize = true;
            this.txtMessage.Location = new System.Drawing.Point(51, 109);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(50, 13);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.Text = "Mensaje:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(110, 76);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(358, 20);
            this.txtSubject.TabIndex = 5;
            this.txtSubject.Text = "Hello";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(110, 24);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(358, 20);
            this.txtTo.TabIndex = 6;
            this.txtTo.Text = "emanuel.baldizon@gmail.com";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(110, 49);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(358, 20);
            this.txtCC.TabIndex = 7;
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.Location = new System.Drawing.Point(110, 109);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(358, 193);
            this.rtxtMessage.TabIndex = 8;
            this.rtxtMessage.Text = "Mensaje de prueba";
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.txtSmtp);
            this.Setting.Controls.Add(this.label8);
            this.Setting.Controls.Add(this.btnSend);
            this.Setting.Controls.Add(this.checkSSL);
            this.Setting.Controls.Add(this.txtPort);
            this.Setting.Controls.Add(this.label7);
            this.Setting.Controls.Add(this.txtUser);
            this.Setting.Controls.Add(this.txtPassword);
            this.Setting.Controls.Add(this.label6);
            this.Setting.Controls.Add(this.label5);
            this.Setting.Location = new System.Drawing.Point(110, 320);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(358, 108);
            this.Setting.TabIndex = 9;
            this.Setting.TabStop = false;
            this.Setting.Text = "User";
            // 
            // txtSmtp
            // 
            this.txtSmtp.Location = new System.Drawing.Point(196, 69);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(144, 20);
            this.txtSmtp.TabIndex = 9;
            this.txtSmtp.Text = "smtp.gmail.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Smtp:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(226, 39);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // checkSSL
            // 
            this.checkSSL.AutoSize = true;
            this.checkSSL.Location = new System.Drawing.Point(226, 17);
            this.checkSSL.Name = "checkSSL";
            this.checkSSL.Size = new System.Drawing.Size(46, 17);
            this.checkSSL.TabIndex = 6;
            this.checkSSL.Text = "SSL";
            this.checkSSL.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(77, 70);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(77, 20);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "587";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Puerto:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(77, 17);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(120, 20);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "amnetdeluxe@gmail.com";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(77, 43);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(120, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Usuario:";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(110, 434);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(90, 23);
            this.btnFile.TabIndex = 10;
            this.btnFile.Text = "Adjuntar";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(110, 464);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(0, 13);
            this.lblFile.TabIndex = 11;
            // 
            // FrmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 519);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.rtxtMessage);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmail";
            this.Text = "FrmEmail";
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private System.Windows.Forms.GroupBox Setting;
        private System.Windows.Forms.TextBox txtSmtp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox checkSSL;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblFile;
    }
}