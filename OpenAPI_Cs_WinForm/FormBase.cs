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
		public FormBase()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			timerUpdate.Enabled =  true;
		}


		private void chkUpdateOn_CheckedChanged(object sender, EventArgs e)
		{
			tbIpAddrRemote.Enabled = !(chkUpdateOn.Checked);
		}


		protected int UpdateStateFromRemote()
		{
			string respBody = "";
			GetData("project/rgen", ref respBody);

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
			if (mot == 0) {
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
				UpdateStateFromRemote();
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

			PostData(path, joReqBody.ToString());
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

			PostData(path, joReqBody.ToString());
		}


		private void btStart_Click(object sender, EventArgs e)
		{
			string path = "project/robot/start";
			PostData(path);
		}


		private void btStop_Click(object sender, EventArgs e)
		{
			string path = "project/robot/stop";
			PostData(path);
		}

		
		private void btReset_Click(object sender, EventArgs e)
		{
			string path = "project/context/tasks/reset";
			PostData(path);
		}


		public string StrDomain()
		{
			var str_ip = tbIpAddrRemote.Text;
			var str = "http://" + str_ip + ":8888/";
			return str;
		}


		protected int GetData(string path, ref string respBody)
		{
			var request = (HttpWebRequest)WebRequest.Create(StrDomain() + path);
			request.Method = "GET";
			request.Timeout = 30 * 1000; // 30초

			using (var resp = (HttpWebResponse)request.GetResponse())
			{
				var status = resp.StatusCode;
				Console.WriteLine(status);  // 정상이면 "OK"

				var respStream = resp.GetResponseStream();
				using (var sr = new StreamReader(respStream))
				{
					respBody = sr.ReadToEnd();
				}
			}

			return 0;
		}


		protected int PostData(string path)
		{
			var joReqBody = new JObject();
			return PostData(path, joReqBody.ToString());
		}


		protected int PostData(string path, string reqBody)
		{
			var request = (HttpWebRequest)WebRequest.Create(StrDomain() + path);
			request.Method = "POST";
			request.ContentType = "application/json";
			request.Timeout = 5 * 1000;

			// POST할 데이타를 Request Stream에 쓴다
			byte[] bytes = Encoding.ASCII.GetBytes(reqBody);
			request.ContentLength = bytes.Length; // 바이트수 지정

			using (var reqStream = request.GetRequestStream())
			{
				reqStream.Write(bytes, 0, bytes.Length);
			}

			// Response 처리
			string responseText = string.Empty;
			using (var resp = request.GetResponse())
			{
				Stream respStream = resp.GetResponseStream();
				using (StreamReader sr = new StreamReader(respStream))
				{
					responseText = sr.ReadToEnd();
				}
			}

			return 0;
		}
	}
}
