using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace OpenAPI_Cs_WinForm
{
	public partial class FormGeneral : FormClient
	{
		public FormGeneral()
		{
			InitializeComponent();
		}


		public int DoUpdate()
		{
			if (Visible == false) return 0;

			string respBody = "";
			var iret = cli.GetData("project/rgen", ref respBody);
			if (iret < 0) return -1;

			var jo = JObject.Parse(respBody);
			DisplayState(jo);
			UpdateEidLast(jo);

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


		private EidLast _eidLast;
		public EidLast EidLast
		{
			get { return _eidLast; }
		}
		
		protected void UpdateEidLast(JObject jo)
		{
			_eidLast.err = jo.Value<Int64>("eid_last_err");
			_eidLast.warn = jo.Value<Int64>("eid_last_warn");
			_eidLast.notice = jo.Value<Int64>("eid_last_noti");
			_eidLast.history = jo.Value<Int64>("eid_last_history");
		}
	}
}
