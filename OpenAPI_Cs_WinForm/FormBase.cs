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
			bool on = chkUpdateOn.Checked;
			tbIpAddrRemote.Enabled = !on;

			if(on) {
				UpdateUCrdNos();
			}
		}


		///////////////////////////////////////////////////////////////////////
		// state
		///////////////////////////////////////////////////////////////////////
		protected int UpdateState()
		{
			string respBody = "";
			var iret = GetData("project/rgen", ref respBody);
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
				UpdateState();
				UpdateCurPose(CRD_AXES);
				UpdateCurPose(CRD_BASE);
				UpdateCurPose(CRD_USER);
				UpdateIo();
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
				else {
					query += string.Format("&ucrd_no={0}", ucrd_no);
				}
			}
			string respBody = "";
			var iret = GetData("project/robot/po_cur", query, ref respBody);
			if (iret < 0) return -1;

			var jo = JObject.Parse(respBody);

			return DisplayCurPose(crd, jo);
		}


		protected int UpdateUCrdNos()
		{
			cbUCrdNos.Items.Clear();
			cbUCrdNos.Items.Add(0);

			string respBody = "";
			var iret = GetData("project/control/ucss/ucs_nos", ref respBody);
			if (iret < 0) return -1;

			var jaNo = JArray.Parse(respBody);
			foreach(var no in jaNo) {
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


		///////////////////////////////////////////////////////////////////////
		// IO
		///////////////////////////////////////////////////////////////////////
		protected int UpdateIo()
		{
			string relayName = SelectedRelayName();
			if (relayName == "") return -1;
			string path = string.Format("project/plc/{0}/val_s32", relayName);
			string query = "?st=0&len=30";	// 30 * 4byte = 120byte
			string respBody = "";

			var iret = GetData(path, query, ref respBody);
			if (iret < 0) return -1;

			var jaLong = JArray.Parse(respBody);

			var dataType = SelectedDataType();
			if (dataType == DataType.Invalid) return -1;

			int idx = 0;
			int.TryParse(tbIndex.Text, out idx);
			var val = GetValueFromJaLong(jaLong, dataType, idx);
			tbCurValue.Text = val.ToString();

			return 0;
		}


		protected string SelectedRelayName()
		{
			var item = cbRelayType.SelectedItem;
			if (item == null) return "";
			var name = item.ToString();
			if (HasObjType(name))
			{
				item = cbObjType.SelectedItem;
				if (item == null) return "";
				var objType = item.ToString();
				var prefix = objType + tbObjIdx.Text + "_";
				name = prefix + name;
			}
			return name;
		}


		protected DataType SelectedDataType()
		{
			var item = cbDataType.SelectedItem;
			if (item == null) return DataType.Invalid;
			var str = cbDataType.SelectedItem.ToString();
			if (str == "Bit") return DataType.Bit;
			else if (str == "Char") return DataType.Char;
			else if (str == "Short") return DataType.Short;
			else if (str == "Long") return DataType.Long;
			else return DataType.Invalid;
		}


		protected bool HasObjType(string relayType)
		{
			var str = relayType;
			bool b = (str == "di" || str == "do" || str == "x" || str == "y");
			return b;
		}


		private void cbRelayType_SelectedIndexChanged(object sender, EventArgs e)
		{
			var item = cbRelayType.SelectedItem;
			if (item == null) return;
			var on = HasObjType(item.ToString());
			lbObjType.Visible = on;
			cbObjType.Visible = on;
			lbObjIdx.Visible = on;
			tbObjIdx.Visible = on;
		}


		protected int GetValueFromJaLong(JArray jaLong, DataType dataType, int idx)
		{
			switch(dataType)
			{
				case DataType.Bit:
					return GetBitFromJaLong(jaLong, idx);

				case DataType.Char:
					return GetCharFromJaLong(jaLong, idx);

				case DataType.Short:
					return GetShortFromJaLong(jaLong, idx);

				case DataType.Long:
					return GetLongFromJaLong(jaLong, idx);
			}

			return 0;
		}


		protected int GetBitFromJaLong(JArray jaLong, int idx)
		{
			int i = idx / 32;
			var s32 = jaLong[i].Value<int>();
			var nBitToShift = idx % 32;
			s32 >>= nBitToShift;
			return s32 & 0x1;
		}


		protected int GetCharFromJaLong(JArray jaLong, int idx)
		{
			int i = idx / 4;
			var s32 = jaLong[i].Value<int>();
			var nBitToShift = (idx % 4) * 8;
			s32 >>= nBitToShift;
			return s32 & 0xFF;
		}


		protected int GetShortFromJaLong(JArray jaLong, int idx)
		{
			int i = idx / 2;
			var s32 = jaLong[i].Value<int>();
			if ((idx % 2) == 1)
			{
				s32 >>= 16;
			}
			return s32 & 0xFFFF;
		}


		protected int GetLongFromJaLong(JArray jaLong, int idx)
		{
			return jaLong[idx].Value<int>();
		}


		public string StrDomain()
		{
			var str_ip = tbIpAddrRemote.Text;
			var str = "http://" + str_ip + ":8888/";
			return str;
		}


		protected int GetData(string path, ref string respBody)
		{
			return GetData(path, "", ref respBody);
		}


		protected int GetData(string path, string query, ref string respBody)
		{
			try
			{
				var url = StrDomain() + path + query;
				var request = (HttpWebRequest)WebRequest.Create(url);
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
			}
			catch(WebException e)
			{
				using (var resp = (HttpWebResponse)e.Response)
				{
					//Console.WriteLine("Error code: {0}", resp.StatusCode);
				}
				return -1;
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
			try
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
			}
			catch (WebException e)
			{
				using (var resp = (HttpWebResponse)e.Response)
				{
					//Console.WriteLine("Error code: {0}", resp.StatusCode);
				}
				return -1;
			}

			return 0;
		}
	}
}
