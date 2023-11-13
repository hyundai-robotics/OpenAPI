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

		protected void UpdateState()
		{
			var respText = string.Empty;

			var uri = "http://192.168.1.150/project/rgen";

			var request = (HttpWebRequest)WebRequest.Create(uri);
			request.Method = "GET";
			request.Timeout = 30 * 1000; // 30초

			using (var resp = (HttpWebResponse)request.GetResponse())
			{
				var status = resp.StatusCode;
				Console.WriteLine(status);  // 정상이면 "OK"

				var respStream = resp.GetResponseStream();
				using (var sr = new StreamReader(respStream))
				{
					respText = sr.ReadToEnd();
				}
			}

			var jo = JObject.Parse(respText);
            var pno = jo["cur_prog_no"];
            var sno = jo["cur_step_no"];
            var fno = jo["cur_func_no"];
            var str = string.Format("P{0}/S{1}/F{2}", pno, sno, fno);
			//tbState.Text = jobj["title"].ToString();
			//tbProgCnt.Text = jobj["id"].ToString();
		}


		private void timerUpdate_Tick(object sender, EventArgs e)
		{
			UpdateState();
		}

		protected void PostData(string url, string reqBody)
		{
			var request = (HttpWebRequest)WebRequest.Create(url);
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

		private void btSelectJob_Click(object sender, EventArgs e)
		{
			string url = "https://httpbin.org/post";
			string reqBody = "{ \"id\": \"101\", \"name\" : \"Alex\" }";

			PostData(url, reqBody);
		}
	}
}
