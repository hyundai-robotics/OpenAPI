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


		// You can receive various state information using rgen (remote general) service.
		public int DoUpdate()
		{
			if (Visible == false) return 0;

			Body body;
			var iret = cli.GetData("project/rgen", out body);
			if (iret < 0) return -1;

			var joRGen = body.ToJObject();
			DisplayState(joRGen);
			_eidLast.SetFrom(joRGen);

			return 0;
		}


		private int DisplayState(JObject jo)
		{
			DisplayState_Mode(jo);
			DisplayState_JobState(jo);
			DisplayState_JobSubState(jo);
			DisplayState_Motor(jo);
			DisplayState_ProgCnt(jo);
			DisplayState_Playback(jo);

			return 0;
		}


		private int DisplayState_Mode(JObject jo)
		{
			int cur_mode = Convert.ToInt32(jo["cur_mode"]);
			tbMode.Text = (cur_mode <= 1) ? "MANUAL" : "AUTO";
			return 0;
		}


		private int DisplayState_JobState(JObject jo)
		{
			var dic = new Dictionary<int, string>();
			dic.Add(0, "STOP");
			dic.Add(1, "PLAYBACK");
			dic.Add(2, "STEP.FWD");
			dic.Add(3, "STEP.BWD");

			int state = Convert.ToInt32(jo["job_state"]);
			tbJobState.Text = dic.ContainsKey(state) ? dic[state] : "-";

			return 0;
		}


		private int DisplayState_JobSubState(JObject jo)
		{
			var dic = new Dictionary<int, string>();
			dic.Add(20, "UNTIL mon.");
			dic.Add(23, "WAITing");

			int state = Convert.ToInt32(jo["job_sub_state"]);
			tbJobSubState.Text = dic.ContainsKey(state) ? dic[state] : "-";
			return 0;
		}


		private int DisplayState_Motor(JObject jo)
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


		private void btMotorOn_Click(object sender, EventArgs e)
		{
			string path = "project/robot/motor_on";
			cli.PostData(path);
		}


		private void btMotorOff_Click(object sender, EventArgs e)
		{
			string path = "project/robot/motor_off";
			cli.PostData(path);
		}


		private int DisplayState_ProgCnt(JObject jo)
		{
			var pno = jo["cur_prog_no"];
			var sno = jo["cur_step_no"];
			var fno = jo["cur_func_no"];
			tbProgCnt.Text = string.Format("P{0}/S{1}/F{2}", pno, sno, fno);
			return 0;
		}


		private int DisplayState_Playback(JObject jo)
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

			var body = new Body(joReqBody);
			cli.PostData(path, ref body);
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

			var body = new Body(joReqBody);
			cli.PostData(path, ref body);
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


		private void btRelWait_Click(object sender, EventArgs e)
		{
			string path = "project/context/tasks[0]/release_wait";
			cli.PostData(path);
		}


		// extract last event ids from rgen object and provide it externally with EidLast property
		private EidLast _eidLast;
		public EidLast EidLast
		{
			get { return _eidLast; }
		}
	}
}
