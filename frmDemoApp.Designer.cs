namespace Polka.Api.DemoApp
{
	partial class frmDemoApp
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
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblProductId = new System.Windows.Forms.Label();
			this.lblJobName = new System.Windows.Forms.Label();
			this.lblBillingCode = new System.Windows.Forms.Label();
			this.lblHeader = new System.Windows.Forms.Label();
			this.lblPhoneNumber = new System.Windows.Forms.Label();
			this.lblFile = new System.Windows.Forms.Label();
			this.lblCSID = new System.Windows.Forms.Label();
			this.lblFaxQuality = new System.Windows.Forms.Label();
			this.lblStartDateTime = new System.Windows.Forms.Label();
			this.dtpStartDateTime = new System.Windows.Forms.DateTimePicker();
			this.cmbFaxQuality = new System.Windows.Forms.ComboBox();
			this.txtCSID = new System.Windows.Forms.TextBox();
			this.txtFile = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.txtHeader = new System.Windows.Forms.TextBox();
			this.txtBillingCode = new System.Windows.Forms.TextBox();
			this.txtJobName = new System.Windows.Forms.TextBox();
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.btnSendFax = new System.Windows.Forms.Button();
			this.lstJobIds = new System.Windows.Forms.ListBox();
			this.lblJobIds = new System.Windows.Forms.Label();
			this.btnGetFaxStatus = new System.Windows.Forms.Button();
			this.grpSendFax = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFeedbackEmail = new System.Windows.Forms.TextBox();
			this.radSOAP = new System.Windows.Forms.RadioButton();
			this.radXMLRPC = new System.Windows.Forms.RadioButton();
			this.grpGetFaxStatus = new System.Windows.Forms.GroupBox();
			this.ofdBrowse = new System.Windows.Forms.OpenFileDialog();
			this.grpSendFax.SuspendLayout();
			this.grpGetFaxStatus.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(21, 26);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(58, 13);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "Username:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(21, 52);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(56, 13);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Password:";
			// 
			// lblProductId
			// 
			this.lblProductId.AutoSize = true;
			this.lblProductId.Location = new System.Drawing.Point(21, 78);
			this.lblProductId.Name = "lblProductId";
			this.lblProductId.Size = new System.Drawing.Size(61, 13);
			this.lblProductId.TabIndex = 2;
			this.lblProductId.Text = "Product ID:";
			// 
			// lblJobName
			// 
			this.lblJobName.AutoSize = true;
			this.lblJobName.Location = new System.Drawing.Point(21, 104);
			this.lblJobName.Name = "lblJobName";
			this.lblJobName.Size = new System.Drawing.Size(58, 13);
			this.lblJobName.TabIndex = 3;
			this.lblJobName.Text = "Job Name:";
			// 
			// lblBillingCode
			// 
			this.lblBillingCode.AutoSize = true;
			this.lblBillingCode.Location = new System.Drawing.Point(21, 130);
			this.lblBillingCode.Name = "lblBillingCode";
			this.lblBillingCode.Size = new System.Drawing.Size(65, 13);
			this.lblBillingCode.TabIndex = 4;
			this.lblBillingCode.Text = "Billing Code:";
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Location = new System.Drawing.Point(21, 156);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(45, 13);
			this.lblHeader.TabIndex = 5;
			this.lblHeader.Text = "Header:";
			// 
			// lblPhoneNumber
			// 
			this.lblPhoneNumber.AutoSize = true;
			this.lblPhoneNumber.Location = new System.Drawing.Point(21, 182);
			this.lblPhoneNumber.Name = "lblPhoneNumber";
			this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
			this.lblPhoneNumber.TabIndex = 6;
			this.lblPhoneNumber.Text = "Phone Number:";
			// 
			// lblFile
			// 
			this.lblFile.AutoSize = true;
			this.lblFile.Location = new System.Drawing.Point(21, 208);
			this.lblFile.Name = "lblFile";
			this.lblFile.Size = new System.Drawing.Size(26, 13);
			this.lblFile.TabIndex = 7;
			this.lblFile.Text = "File:";
			// 
			// lblCSID
			// 
			this.lblCSID.AutoSize = true;
			this.lblCSID.Location = new System.Drawing.Point(21, 234);
			this.lblCSID.Name = "lblCSID";
			this.lblCSID.Size = new System.Drawing.Size(35, 13);
			this.lblCSID.TabIndex = 8;
			this.lblCSID.Text = "CSID:";
			// 
			// lblFaxQuality
			// 
			this.lblFaxQuality.AutoSize = true;
			this.lblFaxQuality.Location = new System.Drawing.Point(21, 260);
			this.lblFaxQuality.Name = "lblFaxQuality";
			this.lblFaxQuality.Size = new System.Drawing.Size(62, 13);
			this.lblFaxQuality.TabIndex = 9;
			this.lblFaxQuality.Text = "Fax Quality:";
			// 
			// lblStartDateTime
			// 
			this.lblStartDateTime.AutoSize = true;
			this.lblStartDateTime.Location = new System.Drawing.Point(21, 288);
			this.lblStartDateTime.Name = "lblStartDateTime";
			this.lblStartDateTime.Size = new System.Drawing.Size(92, 13);
			this.lblStartDateTime.TabIndex = 10;
			this.lblStartDateTime.Text = "Start Date / Time:";
			// 
			// dtpStartDateTime
			// 
			this.dtpStartDateTime.CustomFormat = "dddd, MMMM d, yyy hh:mm:ss tt";
			this.dtpStartDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStartDateTime.Location = new System.Drawing.Point(126, 284);
			this.dtpStartDateTime.Name = "dtpStartDateTime";
			this.dtpStartDateTime.Size = new System.Drawing.Size(265, 20);
			this.dtpStartDateTime.TabIndex = 11;
			// 
			// cmbFaxQuality
			// 
			this.cmbFaxQuality.FormattingEnabled = true;
			this.cmbFaxQuality.ItemHeight = 13;
			this.cmbFaxQuality.Items.AddRange(new object[] {
            "High",
            "Normal"});
			this.cmbFaxQuality.Location = new System.Drawing.Point(126, 257);
			this.cmbFaxQuality.Name = "cmbFaxQuality";
			this.cmbFaxQuality.Size = new System.Drawing.Size(135, 21);
			this.cmbFaxQuality.TabIndex = 12;
			// 
			// txtCSID
			// 
			this.txtCSID.Location = new System.Drawing.Point(126, 231);
			this.txtCSID.Name = "txtCSID";
			this.txtCSID.Size = new System.Drawing.Size(135, 20);
			this.txtCSID.TabIndex = 9;
			// 
			// txtFile
			// 
			this.txtFile.Location = new System.Drawing.Point(126, 205);
			this.txtFile.Name = "txtFile";
			this.txtFile.Size = new System.Drawing.Size(265, 20);
			this.txtFile.TabIndex = 7;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(397, 203);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 8;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(126, 179);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(135, 20);
			this.txtPhoneNumber.TabIndex = 6;
			// 
			// txtHeader
			// 
			this.txtHeader.Location = new System.Drawing.Point(126, 153);
			this.txtHeader.MaxLength = 50;
			this.txtHeader.Name = "txtHeader";
			this.txtHeader.Size = new System.Drawing.Size(154, 20);
			this.txtHeader.TabIndex = 5;
			this.txtHeader.Text = "Test Header";
			// 
			// txtBillingCode
			// 
			this.txtBillingCode.Location = new System.Drawing.Point(126, 127);
			this.txtBillingCode.Name = "txtBillingCode";
			this.txtBillingCode.Size = new System.Drawing.Size(154, 20);
			this.txtBillingCode.TabIndex = 4;
			this.txtBillingCode.Text = "Test Billing Code";
			// 
			// txtJobName
			// 
			this.txtJobName.Location = new System.Drawing.Point(126, 101);
			this.txtJobName.Name = "txtJobName";
			this.txtJobName.Size = new System.Drawing.Size(154, 20);
			this.txtJobName.TabIndex = 3;
			this.txtJobName.Text = "Test Job";
			// 
			// txtProductId
			// 
			this.txtProductId.Location = new System.Drawing.Point(126, 75);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(265, 20);
			this.txtProductId.TabIndex = 2;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(126, 49);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(154, 20);
			this.txtPassword.TabIndex = 1;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(126, 23);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(154, 20);
			this.txtUsername.TabIndex = 0;
			// 
			// btnSendFax
			// 
			this.btnSendFax.Location = new System.Drawing.Point(397, 338);
			this.btnSendFax.Name = "btnSendFax";
			this.btnSendFax.Size = new System.Drawing.Size(75, 23);
			this.btnSendFax.TabIndex = 12;
			this.btnSendFax.Text = "Send Fax";
			this.btnSendFax.UseVisualStyleBackColor = true;
			this.btnSendFax.Click += new System.EventHandler(this.btnSendFax_Click);
			// 
			// lstJobIds
			// 
			this.lstJobIds.FormattingEnabled = true;
			this.lstJobIds.Location = new System.Drawing.Point(73, 28);
			this.lstJobIds.Name = "lstJobIds";
			this.lstJobIds.Size = new System.Drawing.Size(399, 95);
			this.lstJobIds.TabIndex = 13;
			// 
			// lblJobIds
			// 
			this.lblJobIds.AutoSize = true;
			this.lblJobIds.Location = new System.Drawing.Point(21, 28);
			this.lblJobIds.Name = "lblJobIds";
			this.lblJobIds.Size = new System.Drawing.Size(46, 13);
			this.lblJobIds.TabIndex = 25;
			this.lblJobIds.Text = "Job IDs:";
			// 
			// btnGetFaxStatus
			// 
			this.btnGetFaxStatus.Location = new System.Drawing.Point(374, 128);
			this.btnGetFaxStatus.Name = "btnGetFaxStatus";
			this.btnGetFaxStatus.Size = new System.Drawing.Size(98, 23);
			this.btnGetFaxStatus.TabIndex = 14;
			this.btnGetFaxStatus.Text = "Get Fax Status";
			this.btnGetFaxStatus.UseVisualStyleBackColor = true;
			this.btnGetFaxStatus.Click += new System.EventHandler(this.btnGetFaxStatus_Click);
			// 
			// grpSendFax
			// 
			this.grpSendFax.Controls.Add(this.label1);
			this.grpSendFax.Controls.Add(this.txtFeedbackEmail);
			this.grpSendFax.Controls.Add(this.radSOAP);
			this.grpSendFax.Controls.Add(this.radXMLRPC);
			this.grpSendFax.Controls.Add(this.lblUsername);
			this.grpSendFax.Controls.Add(this.lblPassword);
			this.grpSendFax.Controls.Add(this.lblProductId);
			this.grpSendFax.Controls.Add(this.lblJobName);
			this.grpSendFax.Controls.Add(this.btnSendFax);
			this.grpSendFax.Controls.Add(this.lblBillingCode);
			this.grpSendFax.Controls.Add(this.txtUsername);
			this.grpSendFax.Controls.Add(this.lblHeader);
			this.grpSendFax.Controls.Add(this.txtPassword);
			this.grpSendFax.Controls.Add(this.lblPhoneNumber);
			this.grpSendFax.Controls.Add(this.txtProductId);
			this.grpSendFax.Controls.Add(this.lblFile);
			this.grpSendFax.Controls.Add(this.txtJobName);
			this.grpSendFax.Controls.Add(this.lblCSID);
			this.grpSendFax.Controls.Add(this.txtBillingCode);
			this.grpSendFax.Controls.Add(this.lblFaxQuality);
			this.grpSendFax.Controls.Add(this.txtHeader);
			this.grpSendFax.Controls.Add(this.lblStartDateTime);
			this.grpSendFax.Controls.Add(this.txtPhoneNumber);
			this.grpSendFax.Controls.Add(this.dtpStartDateTime);
			this.grpSendFax.Controls.Add(this.btnBrowse);
			this.grpSendFax.Controls.Add(this.cmbFaxQuality);
			this.grpSendFax.Controls.Add(this.txtFile);
			this.grpSendFax.Controls.Add(this.txtCSID);
			this.grpSendFax.Location = new System.Drawing.Point(12, 12);
			this.grpSendFax.Name = "grpSendFax";
			this.grpSendFax.Size = new System.Drawing.Size(493, 373);
			this.grpSendFax.TabIndex = 27;
			this.grpSendFax.TabStop = false;
			this.grpSendFax.Text = "Send Fax";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 313);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Feedback Email:";
			// 
			// txtFeedbackEmail
			// 
			this.txtFeedbackEmail.Location = new System.Drawing.Point(126, 310);
			this.txtFeedbackEmail.Name = "txtFeedbackEmail";
			this.txtFeedbackEmail.Size = new System.Drawing.Size(135, 20);
			this.txtFeedbackEmail.TabIndex = 16;
			// 
			// radSOAP
			// 
			this.radSOAP.AutoSize = true;
			this.radSOAP.Checked = true;
			this.radSOAP.Location = new System.Drawing.Point(169, 341);
			this.radSOAP.Name = "radSOAP";
			this.radSOAP.Size = new System.Drawing.Size(99, 17);
			this.radSOAP.TabIndex = 14;
			this.radSOAP.TabStop = true;
			this.radSOAP.Text = "Send via SOAP";
			this.radSOAP.UseVisualStyleBackColor = true;
			// 
			// radXMLRPC
			// 
			this.radXMLRPC.AutoSize = true;
			this.radXMLRPC.Location = new System.Drawing.Point(274, 341);
			this.radXMLRPC.Name = "radXMLRPC";
			this.radXMLRPC.Size = new System.Drawing.Size(117, 17);
			this.radXMLRPC.TabIndex = 13;
			this.radXMLRPC.Text = "Send via XML RPC";
			this.radXMLRPC.UseVisualStyleBackColor = true;
			// 
			// grpGetFaxStatus
			// 
			this.grpGetFaxStatus.Controls.Add(this.lblJobIds);
			this.grpGetFaxStatus.Controls.Add(this.btnGetFaxStatus);
			this.grpGetFaxStatus.Controls.Add(this.lstJobIds);
			this.grpGetFaxStatus.Location = new System.Drawing.Point(12, 391);
			this.grpGetFaxStatus.Name = "grpGetFaxStatus";
			this.grpGetFaxStatus.Size = new System.Drawing.Size(493, 162);
			this.grpGetFaxStatus.TabIndex = 28;
			this.grpGetFaxStatus.TabStop = false;
			this.grpGetFaxStatus.Text = "Fax Status";
			// 
			// ofdBrowse
			// 
			this.ofdBrowse.FileName = "openFileDialog1";
			// 
			// frmDemoApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 570);
			this.Controls.Add(this.grpGetFaxStatus);
			this.Controls.Add(this.grpSendFax);
			this.Name = "frmDemoApp";
			this.Text = "Polka.Api Demo App";
			this.Load += new System.EventHandler(this.frmDemoApp_Load);
			this.grpSendFax.ResumeLayout(false);
			this.grpSendFax.PerformLayout();
			this.grpGetFaxStatus.ResumeLayout(false);
			this.grpGetFaxStatus.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblProductId;
		private System.Windows.Forms.Label lblJobName;
		private System.Windows.Forms.Label lblBillingCode;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.Label lblPhoneNumber;
		private System.Windows.Forms.Label lblFile;
		private System.Windows.Forms.Label lblCSID;
		private System.Windows.Forms.Label lblFaxQuality;
		private System.Windows.Forms.Label lblStartDateTime;
		private System.Windows.Forms.DateTimePicker dtpStartDateTime;
		private System.Windows.Forms.ComboBox cmbFaxQuality;
		private System.Windows.Forms.TextBox txtCSID;
		private System.Windows.Forms.TextBox txtFile;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.TextBox txtHeader;
		private System.Windows.Forms.TextBox txtBillingCode;
		private System.Windows.Forms.TextBox txtJobName;
		private System.Windows.Forms.TextBox txtProductId;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Button btnSendFax;
		private System.Windows.Forms.ListBox lstJobIds;
		private System.Windows.Forms.Label lblJobIds;
		private System.Windows.Forms.Button btnGetFaxStatus;
		private System.Windows.Forms.GroupBox grpSendFax;
		private System.Windows.Forms.GroupBox grpGetFaxStatus;
		private System.Windows.Forms.OpenFileDialog ofdBrowse;
		private System.Windows.Forms.RadioButton radSOAP;
		private System.Windows.Forms.RadioButton radXMLRPC;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFeedbackEmail;
	}
}

