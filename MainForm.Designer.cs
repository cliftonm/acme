namespace acme
{
	partial class MainForm
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
			this.lblAboutAcme = new System.Windows.Forms.LinkLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbLocalIP = new System.Windows.Forms.TextBox();
			this.tbRouterIP = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbDomainName = new System.Windows.Forms.TextBox();
			this.tbCertPassword = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnCreateAndRegisterCertificate = new System.Windows.Forms.Button();
			this.tbLog = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lblLetsEncrypt = new System.Windows.Forms.LinkLabel();
			this.tbProduction = new System.Windows.Forms.RadioButton();
			this.rbStaging = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbNeither = new System.Windows.Forms.RadioButton();
			this.rbNetsh = new System.Windows.Forms.RadioButton();
			this.rbIIS = new System.Windows.Forms.RadioButton();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tbExpirationDates = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(271, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ACME: Automated Certificate Management Environment";
			// 
			// lblAboutAcme
			// 
			this.lblAboutAcme.AutoSize = true;
			this.lblAboutAcme.Location = new System.Drawing.Point(16, 30);
			this.lblAboutAcme.Name = "lblAboutAcme";
			this.lblAboutAcme.Size = new System.Drawing.Size(385, 13);
			this.lblAboutAcme.TabIndex = 1;
			this.lblAboutAcme.TabStop = true;
			this.lblAboutAcme.Text = "https://en.wikipedia.org/wiki/Automated_Certificate_Management_Environment";
			this.lblAboutAcme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAboutAcme_LinkClicked);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Your local IP:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Your public IP:";
			// 
			// tbLocalIP
			// 
			this.tbLocalIP.Location = new System.Drawing.Point(111, 79);
			this.tbLocalIP.Name = "tbLocalIP";
			this.tbLocalIP.ReadOnly = true;
			this.tbLocalIP.Size = new System.Drawing.Size(125, 20);
			this.tbLocalIP.TabIndex = 4;
			// 
			// tbRouterIP
			// 
			this.tbRouterIP.Location = new System.Drawing.Point(111, 105);
			this.tbRouterIP.Name = "tbRouterIP";
			this.tbRouterIP.ReadOnly = true;
			this.tbRouterIP.Size = new System.Drawing.Size(125, 20);
			this.tbRouterIP.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 270);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Domain Name:";
			// 
			// tbDomainName
			// 
			this.tbDomainName.Location = new System.Drawing.Point(111, 267);
			this.tbDomainName.Name = "tbDomainName";
			this.tbDomainName.Size = new System.Drawing.Size(197, 20);
			this.tbDomainName.TabIndex = 7;
			// 
			// tbCertPassword
			// 
			this.tbCertPassword.Location = new System.Drawing.Point(111, 293);
			this.tbCertPassword.Name = "tbCertPassword";
			this.tbCertPassword.Size = new System.Drawing.Size(197, 20);
			this.tbCertPassword.TabIndex = 9;
			this.tbCertPassword.UseSystemPasswordChar = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 296);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Cert. Password:";
			// 
			// btnCreateAndRegisterCertificate
			// 
			this.btnCreateAndRegisterCertificate.Location = new System.Drawing.Point(341, 291);
			this.btnCreateAndRegisterCertificate.Name = "btnCreateAndRegisterCertificate";
			this.btnCreateAndRegisterCertificate.Size = new System.Drawing.Size(159, 23);
			this.btnCreateAndRegisterCertificate.TabIndex = 10;
			this.btnCreateAndRegisterCertificate.Text = "Create and Register Certificate";
			this.btnCreateAndRegisterCertificate.UseVisualStyleBackColor = true;
			this.btnCreateAndRegisterCertificate.Click += new System.EventHandler(this.btnCreateAndRegisterCertificate_Click);
			// 
			// tbLog
			// 
			this.tbLog.AcceptsReturn = true;
			this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbLog.Location = new System.Drawing.Point(3, 3);
			this.tbLog.Multiline = true;
			this.tbLog.Name = "tbLog";
			this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbLog.Size = new System.Drawing.Size(464, 253);
			this.tbLog.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(16, 50);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "LetsEncrpyt:";
			// 
			// lblLetsEncrypt
			// 
			this.lblLetsEncrypt.AutoSize = true;
			this.lblLetsEncrypt.Location = new System.Drawing.Point(88, 50);
			this.lblLetsEncrypt.Name = "lblLetsEncrypt";
			this.lblLetsEncrypt.Size = new System.Drawing.Size(112, 13);
			this.lblLetsEncrypt.TabIndex = 14;
			this.lblLetsEncrypt.TabStop = true;
			this.lblLetsEncrypt.Text = "https://letsencrypt.org";
			this.lblLetsEncrypt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLetsEncrypt_LinkClicked);
			// 
			// tbProduction
			// 
			this.tbProduction.AutoSize = true;
			this.tbProduction.Location = new System.Drawing.Point(12, 19);
			this.tbProduction.Name = "tbProduction";
			this.tbProduction.Size = new System.Drawing.Size(76, 17);
			this.tbProduction.TabIndex = 15;
			this.tbProduction.Text = "Production";
			this.tbProduction.UseVisualStyleBackColor = true;
			// 
			// rbStaging
			// 
			this.rbStaging.AutoSize = true;
			this.rbStaging.Checked = true;
			this.rbStaging.Location = new System.Drawing.Point(94, 19);
			this.rbStaging.Name = "rbStaging";
			this.rbStaging.Size = new System.Drawing.Size(61, 17);
			this.rbStaging.TabIndex = 16;
			this.rbStaging.TabStop = true;
			this.rbStaging.Text = "Staging";
			this.rbStaging.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbStaging);
			this.groupBox1.Controls.Add(this.tbProduction);
			this.groupBox1.Location = new System.Drawing.Point(111, 137);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(273, 52);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lets Encrpyt";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbNeither);
			this.groupBox2.Controls.Add(this.rbNetsh);
			this.groupBox2.Controls.Add(this.rbIIS);
			this.groupBox2.Location = new System.Drawing.Point(111, 199);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(273, 52);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Certificate Binding";
			// 
			// rbNeither
			// 
			this.rbNeither.AutoSize = true;
			this.rbNeither.Checked = true;
			this.rbNeither.Location = new System.Drawing.Point(201, 19);
			this.rbNeither.Name = "rbNeither";
			this.rbNeither.Size = new System.Drawing.Size(59, 17);
			this.rbNeither.TabIndex = 17;
			this.rbNeither.TabStop = true;
			this.rbNeither.Text = "Neither";
			this.rbNeither.UseVisualStyleBackColor = true;
			// 
			// rbNetsh
			// 
			this.rbNetsh.AutoSize = true;
			this.rbNetsh.Location = new System.Drawing.Point(94, 19);
			this.rbNetsh.Name = "rbNetsh";
			this.rbNetsh.Size = new System.Drawing.Size(51, 17);
			this.rbNetsh.TabIndex = 16;
			this.rbNetsh.Text = "netsh";
			this.rbNetsh.UseVisualStyleBackColor = true;
			// 
			// rbIIS
			// 
			this.rbIIS.AutoSize = true;
			this.rbIIS.Location = new System.Drawing.Point(12, 19);
			this.rbIIS.Name = "rbIIS";
			this.rbIIS.Size = new System.Drawing.Size(38, 17);
			this.rbIIS.TabIndex = 15;
			this.rbIIS.Text = "IIS";
			this.rbIIS.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(22, 332);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(478, 285);
			this.tabControl1.TabIndex = 19;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tbLog);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(470, 259);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Log";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tbExpirationDates);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(470, 259);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Expiration Dates";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tbExpirationDates
			// 
			this.tbExpirationDates.AcceptsReturn = true;
			this.tbExpirationDates.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbExpirationDates.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbExpirationDates.Location = new System.Drawing.Point(3, 3);
			this.tbExpirationDates.Multiline = true;
			this.tbExpirationDates.Name = "tbExpirationDates";
			this.tbExpirationDates.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbExpirationDates.Size = new System.Drawing.Size(464, 253);
			this.tbExpirationDates.TabIndex = 12;
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnCreateAndRegisterCertificate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 629);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.lblLetsEncrypt);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnCreateAndRegisterCertificate);
			this.Controls.Add(this.tbCertPassword);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbDomainName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbRouterIP);
			this.Controls.Add(this.tbLocalIP);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblAboutAcme);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "ACME";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel lblAboutAcme;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbLocalIP;
		private System.Windows.Forms.TextBox tbRouterIP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbDomainName;
		private System.Windows.Forms.TextBox tbCertPassword;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnCreateAndRegisterCertificate;
		private System.Windows.Forms.TextBox tbLog;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.LinkLabel lblLetsEncrypt;
		private System.Windows.Forms.RadioButton tbProduction;
		private System.Windows.Forms.RadioButton rbStaging;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbNetsh;
		private System.Windows.Forms.RadioButton rbIIS;
		private System.Windows.Forms.RadioButton rbNeither;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox tbExpirationDates;
	}
}

