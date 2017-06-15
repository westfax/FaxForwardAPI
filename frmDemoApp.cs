using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Web;
using System.Net;
using System.Xml;

namespace Polka.Api.DemoApp
{
	public partial class frmDemoApp : Form
	{
		private string _SoapUrl = "https://api.westfax.com/Polka.Api/SOAP";
		private string _RpcUrl = "https://api.westfax.com/Polka.Api/RPC";

		public frmDemoApp()
		{
			InitializeComponent();
		}

		#region Events
		private void btnGetFaxStatus_Click(object sender, EventArgs e)
		{
			this.GetFaxStatus();
		}

		private void btnSendFax_Click(object sender, EventArgs e)
		{
			if (radSOAP.Checked == true)
				this.SendViaSoap();
			else
				this.SendViaXmlRpc();
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			ofdBrowse.ShowDialog();

			txtFile.Text = ofdBrowse.FileName;
		}

		private void frmDemoApp_Load(object sender, EventArgs e)
		{
			dtpStartDateTime.Value = DateTime.UtcNow;
		}
		#endregion

		#region SendFax Methods
		private void SendViaSoap()
		{
			Cursor.Current = Cursors.WaitCursor;

			PolkaApi.FaxQuality faxQuality = (PolkaApi.FaxQuality)(Enum.Parse(typeof(PolkaApi.FaxQuality), cmbFaxQuality.SelectedItem.ToString()));

			//
			// Create the object for the fax document
			//
			PolkaApi.FileContainer fileContainer = new Polka.Api.DemoApp.PolkaApi.FileContainer();

			fileContainer.Filename = Path.GetFileName(txtFile.Text);
			fileContainer.FileContents = File.ReadAllBytes(txtFile.Text);
			fileContainer.ContentLength = fileContainer.FileContents.Length;

			//
			// Initialize the web servce
			//
			PolkaApi.SoapWebService webService = new Polka.Api.DemoApp.PolkaApi.SoapWebService();

			webService.Url = this._SoapUrl;

			try
			{
				//
				// Submit the fax to the API
				//
				PolkaApi.ApiResultOfString result = webService.SendFax(txtUsername.Text, txtPassword.Text, new Guid(txtProductId.Text),
					txtJobName.Text, txtBillingCode.Text, txtHeader.Text, new string[] { txtPhoneNumber.Text },
					new PolkaApi.FileContainer[] { fileContainer }, txtCSID.Text, faxQuality, dtpStartDateTime.Value, txtFeedbackEmail.Text);

				if (result.Success == true)
				{
					MessageBox.Show("Job Submitted Successfully!\r\n" + result.Result, "Job Submission", MessageBoxButtons.OK, MessageBoxIcon.Information);

					lstJobIds.Items.Add(result.Result);
				}
				else
					MessageBox.Show("Job Submission Failed.\r\n" + result.ErrorString, "Job Submission", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Job Submission Failed.\r\n" + ex.Message, "Job Submission", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			Cursor.Current = Cursors.Default;
		}

		private void SendViaXmlRpc()
		{
			Cursor.Current = Cursors.WaitCursor;

			//
			// Load the file contents
			//
			byte[] file = File.ReadAllBytes(txtFile.Text);

			//
			// Build the XML Document
			//
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
			sb.AppendLine("<ApiRequest xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">");
			sb.AppendLine("<Method>SendFax</Method>");
			sb.AppendLine("<Username>" + txtUsername.Text + "</Username>");
			sb.AppendLine("<Password>" + txtPassword.Text + "</Password>");
			sb.AppendLine("<ProductId>" + txtProductId.Text + "</ProductId>");
			sb.AppendLine("<JobName>" + txtJobName.Text + "</JobName>");
			sb.AppendLine("<BillingCode>" + txtBillingCode.Text + "</BillingCode>");
			sb.AppendLine("<Header>" + txtHeader.Text + "</Header>");
			sb.AppendLine("<Numbers><string>" + txtPhoneNumber.Text + "</string></Numbers>");
			sb.AppendLine("<Files><FileContainer>");
			sb.AppendLine("<FileName>" + Path.GetFileName(txtFile.Text) + "</FileName>");
			sb.AppendLine("<FileContents>" + Convert.ToBase64String(file) + "</FileContents>");
			sb.AppendLine("<ContentLength>" + file.Length + "</ContentLength>");
			sb.AppendLine("<ContentEncoding>base64</ContentEncoding>");
			sb.AppendLine("</FileContainer></Files>");
			sb.AppendLine("<CSID>" + txtCSID.Text + "</CSID>");
			sb.AppendLine("<FaxQuality>" + cmbFaxQuality.SelectedItem.ToString() + "</FaxQuality>");
			sb.AppendLine("<StartDate>" + XmlConvert.ToString(dtpStartDateTime.Value, XmlDateTimeSerializationMode.Utc) + "</StartDate>");
			sb.AppendLine("<FeedbackEmail>" + txtFeedbackEmail.Text + "</FeedbackEmail>");
			sb.AppendLine("</ApiRequest>");

			//
			// Create the Web Request and submit the XML document to the API
			//
			WebRequest webRequest = WebRequest.Create(this._RpcUrl);

			webRequest.Method = "POST";
			webRequest.Credentials = CredentialCache.DefaultCredentials;
			webRequest.ContentType = "text/xml";

			byte[] bytes = Encoding.UTF8.GetBytes(sb.ToString());
			webRequest.ContentLength = bytes.Length;

			System.IO.Stream stream = webRequest.GetRequestStream();

			stream.Write(bytes, 0, bytes.Length);

			//
			// Read the response from the API
			//
			WebResponse webResponse = webRequest.GetResponse();

			System.IO.StreamReader sr = new System.IO.StreamReader(webResponse.GetResponseStream());
			string response = sr.ReadToEnd();

			webResponse = null;
			webRequest = null;

			MessageBox.Show("Response:\r\n" + response, "Web Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

			///
			// Parse the response to obtain the Job ID
			//
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(response);

			XmlNodeList nodeList = xmlDoc.GetElementsByTagName("Result");

			if (nodeList.Count == 0)
				return;

			Guid guid = new Guid(nodeList[0].InnerText);

			lstJobIds.Items.Add(guid);

			Cursor.Current = Cursors.Default;
		}
		#endregion

		#region GetFaxStatus
		private void GetFaxStatus()
		{
			if (lstJobIds.SelectedItem == null)
				return;

			Cursor.Current = Cursors.WaitCursor;

			Guid jobId = new Guid(lstJobIds.SelectedItem.ToString());

			//
			// Initialize the web service
			//
			PolkaApi.SoapWebService webService = new Polka.Api.DemoApp.PolkaApi.SoapWebService();

			webService.Url = this._SoapUrl;

			try
			{
				//
				// Call the Get Fax Status method
				//
				PolkaApi.ApiResultOfListOfJobStatusContainer result = webService.GetFaxStatus(txtUsername.Text, txtPassword.Text, new Guid(txtProductId.Text), new Guid[] { jobId });

				//
				// Parse the results of the call
				//
				if ((result.Success == true) && (result.Result.Length > 0))
				{
					StringBuilder sb = new StringBuilder();

					PolkaApi.JobStatusContainer jobStatus = result.Result[0];

					sb.AppendLine("Job");
					sb.AppendLine("--Job Id: " + jobStatus.JobId.ToString());
					sb.AppendLine("--Job State: " + jobStatus.JobState);
					sb.AppendLine("--Job Cost: " + jobStatus.JobEstimate.ToString());

					sb.AppendLine("Call");
					sb.AppendLine("--Phone Number: " + jobStatus.Calls[0].PhoneNumber);
					sb.AppendLine("--Call Result: " + jobStatus.Calls[0].CallResult);
					sb.AppendLine("--Job Pages: " + jobStatus.Calls[0].JobPages);
					sb.AppendLine("--Pages Sent: " + jobStatus.Calls[0].PagesSent);

					MessageBox.Show(sb.ToString(), "Job Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					throw new Exception(result.ErrorString);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			Cursor.Current = Cursors.Default;
		}
		#endregion
	}
}