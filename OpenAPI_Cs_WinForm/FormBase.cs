using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace OpenAPI_Cs_WinForm
{
	// main form containing all sub-forms
	public partial class FormBase : Form
	{
		HttpCli hcli = new HttpCli();
		FileCli fcli = new FileCli();
		FormGeneral formGeneral;
		FormPoCur formPoCur;
		FormIoRelay formIoRelay;
		FormFileMng formFileMng;
		FormLog formLog;


		public FormBase()
		{
			InitializeComponent();
		}


		protected override void OnLoad(EventArgs e)
		{
			AddClientPage(0, formGeneral = new FormGeneral());
			AddClientPage(1, formPoCur = new FormPoCur());
			AddClientPage(2, formIoRelay = new FormIoRelay());
			AddClientPage(3, formFileMng = new FormFileMng());
			formFileMng.SetFileCli(fcli);
			tabCtrl.SelectedIndex = 0;

			CreateLogPanel();

			timerUpdate.Enabled = true;
		}


		private void AddClientPage(int idx, FormClient form)
		{
			form.SetHttpCli(hcli);
			form.TopLevel = false;
			tabCtrl.TabPages[idx].Controls.Add(form);
			tabCtrl.SelectedIndex = idx;
			form.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			form.Show();
		}


		private void CreateLogPanel()
		{
			formLog = new FormLog();
			formLog.SetHttpCli(hcli);
			formLog.TopLevel = false;
			panelLog.Controls.Add(formLog);
			formLog.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			formLog.Show();
		}


		private void chkConnectOn_CheckedChanged(object sender, EventArgs e)
		{
			bool on = chkConnectOn.Checked;
			tbIpAddrRemote.Enabled = !on;

			if (on)
			{
				hcli.IpAddr = tbIpAddrRemote.Text;
				fcli.IpAddr = tbIpAddrRemote.Text;
				formPoCur.UpdateUCrdNos();
			}
			else
			{
				hcli.IpAddr = "";
				fcli.IpAddr = "";
			}
		}


		private void timerConnect_Tick(object sender, EventArgs e)
		{
			if (chkConnectOn.Checked)
			{
				formGeneral.DoUpdate();
				formPoCur.DoUpdate();
				formIoRelay.DoUpdate();

				formLog.EidLast = formGeneral.EidLast;
				formLog.DoUpdate();
			}
		}
	}
}
