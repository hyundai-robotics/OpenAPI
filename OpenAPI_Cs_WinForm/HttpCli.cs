using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace OpenAPI_Cs_WinForm
{
	public class HttpCli
	{
		public string IpAddr { get; set; }

		public string StrDomain()
		{
			var str = "http://" + IpAddr + ":8888/";
			return str;
		}


		public bool Ready {
			get { return (IpAddr != "") && (IpAddr != null); }
		}


		// --------------------------------------------------------
		public int ProcGet(string path, out Body body)
		{
			return ProcGet(path, "", out body);
		}


		// --------------------------------------------------------
		/// @param[in]	path	HTTP path (e.g. "project/plc/mw/val_s32")
		/// @param[in]	query	HTTP query (e.g. "?st=0&len=30")
		/// @param[out]	body	response body
		/// @return
		///			-	>0		HTTP status code (e.g. 200=OK)
		///			-	-1		unready
		///			-	-2		request fault
		// --------------------------------------------------------
		public int ProcGet(string path, string query, out Body body)
		{
			int iresult = 0;
			body = new Body();

			if (Ready == false) return -1;

			try
			{
				var url = StrDomain() + path + query;
				var request = (HttpWebRequest)WebRequest.Create(url);
				request.Method = "GET";
				request.Timeout = 30 * 1000; // 30 sec

				using (var resp = (HttpWebResponse)request.GetResponse())
				{
					iresult = body.setResp(resp);
				}
			}
			catch (WebException e)
			{
				using (var resp = (HttpWebResponse)e.Response)
				{
					//Console.WriteLine("Error code: {0}", resp.StatusCode);
				}
				return -2;
			}

			return iresult;
		}


		// --------------------------------------------------------
		public int ProcPost(string path)
		{
			var body = new Body();
			return ProcPost(path, ref body);
		}


		// --------------------------------------------------------
		/// @param[in]		path	HTTP path (e.g. "project/plc/set_relay_value")
		/// @param[in,out]	body	request & response body
		/// @return
		///			-	>0		HTTP status code (e.g. 200=OK)
		///			-	-1		unready
		///			-	-2		request fault
		// --------------------------------------------------------
		public int ProcPost(string path, ref Body body)
		{
			int iresult = 0;
			if (Ready == false) return -1;
			try
			{
				var request = (HttpWebRequest)WebRequest.Create(StrDomain() + path);
				request.Method = "POST";
				request.ContentType = body.contentType;
				request.Timeout = 5 * 1000;

				// POST할 데이타를 Request Stream에 쓴다
				byte[] bytes = body.ToBytes();
				request.ContentLength = bytes.Length; // 바이트수 지정

				using (var reqStream = request.GetRequestStream())
				{
					reqStream.Write(bytes, 0, bytes.Length);
				}

				// Response 처리
				using (var resp = (HttpWebResponse)request.GetResponse())
				{
					iresult = body.setResp(resp);
				}
			}
			catch (WebException e)
			{
				using (var resp = (HttpWebResponse)e.Response)
				{
					//Console.WriteLine("Error code: {0}", resp.StatusCode);
				}
				return -2;
			}

			return iresult;
		}


		// --------------------------------------------------------
		/// @param[in]		path	HTTP path (e.g. "file_manager/files/project/jobs/9991.job")
		/// @return
		///			-	>0		HTTP status code (e.g. 200=OK)
		///			-	-1		unready
		///			-	-2		request fault
		// --------------------------------------------------------
		public int ProcDel(string path)
		{
			int iresult = 0;
			if (Ready == false) return -1;
			try
			{
				var request = (HttpWebRequest)WebRequest.Create(StrDomain() + path);
				request.Method = "DELETE";
				request.Timeout = 5 * 1000;

				// Response 처리
				using (var resp = (HttpWebResponse)request.GetResponse())
				{
					iresult = (int)(resp.StatusCode);
				}
			}
			catch (WebException e)
			{
				using (var resp = (HttpWebResponse)e.Response)
				{
					//Console.WriteLine("Error code: {0}", resp.StatusCode);
				}
				return -2;
			}

			return iresult;
		}
	}
}
