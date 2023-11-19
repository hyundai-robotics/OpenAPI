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
	public enum DataType
	{
		Invalid = -1,
		Bit,
		Char,
		Short,
		Long
	}

	public partial class FormBase : Form
	{
		const int CRD_BASE = 0;
		const int CRD_ROBOT = 1;
		const int CRD_AXES = 2;
		const int CRD_USER = 4;

		HttpCli cli = new HttpCli();
		FormGeneral formGeneral;
		FormIoRelay formIoRelay;

		public FormBase()
		{
			InitializeComponent();
		}


		protected override void OnLoad(EventArgs e)
		{
			cli.IpAddr = tbIpAddrRemote.Text;
			
			AddClientPage(0, formGeneral = new FormGeneral());
			AddClientPage(1, formIoRelay = new FormIoRelay());
			tabCtrl.SelectedIndex = 0;

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


		private void chkUpdateOn_CheckedChanged(object sender, EventArgs e)
		{
			bool on = chkUpdateOn.Checked;
			tbIpAddrRemote.Enabled = !on;

			if (on)
			{
				UpdateUCrdNos();
			}
		}


		///////////////////////////////////////////////////////////////////////
		// state
		///////////////////////////////////////////////////////////////////////
		

		private void timerUpdate_Tick(object sender, EventArgs e)
		{
			if (chkUpdateOn.Checked)
			{
				formGeneral.DoUpdate();
				UpdateCurPose(CRD_AXES);
				UpdateCurPose(CRD_BASE);
				UpdateCurPose(CRD_USER);
				formIoRelay.DoUpdate();
			}
		}



		///////////////////////////////////////////////////////////////////////
		// cur.pose
		///////////////////////////////////////////////////////////////////////
		protected int UpdateCurPose(int crd)
		{
			var query = string.Format("?crd={0}&mechinfo=-1", crd);
			if (crd == CRD_USER)
			{
				var item = cbUCrdNos.SelectedItem;
				if (item == null) return -1;
				var ucrd_no = item.ToString();
				if (ucrd_no == "")
				{
					return DisplayCurPose(crd, null);
				}
				else
				{
					query += string.Format("&ucrd_no={0}", ucrd_no);
				}
			}
			string respBody = "";
			var iret = cli.GetData("project/robot/po_cur", query, ref respBody);
			if (iret < 0) return -1;

			var jo = JObject.Parse(respBody);

			return DisplayCurPose(crd, jo);
		}


		protected int UpdateUCrdNos()
		{
			cbUCrdNos.Items.Clear();
			cbUCrdNos.Items.Add(0);

			string respBody = "";
			var iret = cli.GetData("project/control/ucss/ucs_nos", ref respBody);
			if (iret < 0) return -1;

			var jaNo = JArray.Parse(respBody);
			foreach (var no in jaNo)
			{
				cbUCrdNos.Items.Add(no);
			}
			cbUCrdNos.SelectedIndex = 0;

			return 0;
		}


		protected int DisplayCurPose(int crd, JObject jo)
		{
			if (crd == CRD_BASE || crd == CRD_ROBOT)
			{
				DisplayCurPoseBase(jo);
			}
			else if (crd == CRD_AXES)
			{
				DisplayCurPoseAxes(jo);
			}
			else if (crd == CRD_USER)
			{
				DisplayCurPoseUser(jo);
			}

			return 0;
		}


		protected int DisplayCurPoseAxes(JObject jo)
		{
			var j1 = jo["j1"];
			var j2 = jo["j2"];
			var j3 = jo["j3"];
			var j4 = jo["j4"];
			var j5 = jo["j5"];
			var j6 = jo["j6"];
			tbCurPoseAxes.Text = string.Format("({0}, {1}, {2}, {3}, {4}, {5})", j1, j2, j3, j4, j5, j6);
			return 0;
		}


		protected int DisplayCurPoseBase(JObject jo)
		{
			var x = jo["x"];
			var y = jo["y"];
			var z = jo["z"];
			var rx = jo["rx"];
			var ry = jo["ry"];
			var rz = jo["rz"];
			tbCurPoseBase.Text = string.Format("({0}, {1}, {2}, {3}, {4}, {5})", x, y, z, rx, ry, rz);
			return 0;
		}


		protected int DisplayCurPoseUser(JObject jo)
		{
			if (jo == null)
			{
				tbCurPoseUser.Text = "";
				return 0;
			}
			var x = jo["x"];
			var y = jo["y"];
			var z = jo["z"];
			var rx = jo["rx"];
			var ry = jo["ry"];
			var rz = jo["rz"];
			tbCurPoseUser.Text = string.Format("({0}, {1}, {2}, {3}, {4}, {5})", x, y, z, rx, ry, rz);
			return 0;
		}
	}
}
