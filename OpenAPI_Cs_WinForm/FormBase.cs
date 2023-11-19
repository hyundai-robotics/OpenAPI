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
		FormIoRelay formIoRelay;

		public FormBase()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			cli.IpAddr = tbIpAddrRemote.Text;
			timerUpdate.Enabled = true;

			formIoRelay = new FormIoRelay();
			formIoRelay.SetHttpCli(cli);
			formIoRelay.TopLevel = false;
			tabCtrl.TabPages[0].Controls.Add(formIoRelay);
			formIoRelay.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			formIoRelay.Show();
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
		protected int UpdateState()
		{
			string respBody = "";
			var iret = cli.GetData("project/rgen", ref respBody);
			if (iret < 0) return -1;

			var jo = JObject.Parse(respBody);
			DisplayState(jo);

			return 0;
		}


		protected int DisplayState(JObject jo)
		{
			DisplayState_Mode(jo);
			DisplayState_Motor(jo);
			DisplayState_ProgCnt(jo);
			DisplayState_Playback(jo);

			return 0;
		}


		protected int DisplayState_Mode(JObject jo)
		{
			int cur_mode = Convert.ToInt32(jo["cur_mode"]);
			tbMode.Text = (cur_mode <= 1) ? "MANUAL" : "AUTO";
			return 0;
		}


		protected int DisplayState_Motor(JObject jo)
		{
			String str;
			int enable_state = Convert.ToInt32(jo["enable_state"]);
			var mot = enable_state & 0xFF;
			if (mot == 0)
			{
				str = "ON";
			}
			else if (mot == 1)
			{
				str = "OFF";
			}
			else
			{
				str = "-";
			}

			tbMotor.Text = str;
			return 0;
		}


		protected int DisplayState_ProgCnt(JObject jo)
		{
			var pno = jo["cur_prog_no"];
			var sno = jo["cur_step_no"];
			var fno = jo["cur_func_no"];
			tbProgCnt.Text = string.Format("P{0}/S{1}/F{2}", pno, sno, fno);
			return 0;
		}


		protected int DisplayState_Playback(JObject jo)
		{
			int is_playback = Convert.ToInt32(jo["is_playback"]);
			tbPlayback.Text = (is_playback > 0) ? "RUN" : "STOP";
			return 0;
		}


		private void timerUpdate_Tick(object sender, EventArgs e)
		{
			if (chkUpdateOn.Checked)
			{
				UpdateState();
				UpdateCurPose(CRD_AXES);
				UpdateCurPose(CRD_BASE);
				UpdateCurPose(CRD_USER);
				formIoRelay.Update();
			}
		}


		private void btSelectJob_Click(object sender, EventArgs e)
		{
			var pno = Convert.ToInt32(tbJobNo.Text);

			string path = "project/context/tasks[0]/cur_prog_cnt";
			var joReqBody = new JObject();
			joReqBody.Add("pno", pno);
			joReqBody.Add("sno", 0);
			joReqBody.Add("fno", 0);
			joReqBody.Add("ext_sel", 0);

			cli.PostData(path, joReqBody.ToString());
		}


		private void btSelectStepFunc_Click(object sender, EventArgs e)
		{
			var sno = Convert.ToInt32(tbStep.Text);
			var fno = Convert.ToInt32(tbFunc.Text);

			string path = "project/context/tasks[0]/cur_prog_cnt";
			var joReqBody = new JObject();
			joReqBody.Add("pno", -1);
			joReqBody.Add("sno", sno);
			joReqBody.Add("fno", fno);
			joReqBody.Add("ext_sel", 0);

			cli.PostData(path, joReqBody.ToString());
		}


		private void btStart_Click(object sender, EventArgs e)
		{
			string path = "project/robot/start";
			cli.PostData(path);
		}


		private void btStop_Click(object sender, EventArgs e)
		{
			string path = "project/robot/stop";
			cli.PostData(path);
		}


		private void btReset_Click(object sender, EventArgs e)
		{
			string path = "project/context/tasks/reset";
			cli.PostData(path);
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
