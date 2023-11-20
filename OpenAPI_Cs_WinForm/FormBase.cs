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
	public partial class FormBase : Form
	{
		HttpCli cli = new HttpCli();
		FormGeneral formGeneral;
		FormPoCur formPoCur;
		FormIoRelay formIoRelay;
		FormLog formLog;

		public FormBase()
		{
			InitializeComponent();
		}


		protected override void OnLoad(EventArgs e)
		{
			cli.IpAddr = tbIpAddrRemote.Text;

			AddClientPage(0, formGeneral = new FormGeneral());
			AddClientPage(1, formPoCur = new FormPoCur());
			AddClientPage(2, formIoRelay = new FormIoRelay());
			tabCtrl.SelectedIndex = 0;

			CreateLogPanel();

			timerUpdate.Enabled = true;
		}


		protected void AddClientPage(int idx, FormClient form)
		{
			form.SetHttpCli(cli);
			form.TopLevel = false;
			tabCtrl.TabPages[idx].Controls.Add(form);
			tabCtrl.SelectedIndex = idx;
			form.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			form.Show();
		}


		protected void CreateLogPanel()
		{
			formLog = new FormLog();
			formLog.SetHttpCli(cli);
			formLog.TopLevel = false;
			panelLog.Controls.Add(formLog);
			formLog.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			formLog.Show();
		}


		private void chkUpdateOn_CheckedChanged(object sender, EventArgs e)
		{
			bool on = chkUpdateOn.Checked;
			tbIpAddrRemote.Enabled = !on;

			if (on)
			{
				formPoCur.UpdateUCrdNos();
			}
		}


		private void timerUpdate_Tick(object sender, EventArgs e)
		{
			if (chkUpdateOn.Checked)
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
