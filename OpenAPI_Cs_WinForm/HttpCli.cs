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
		public string IpAddr;

		public string StrDomain()
		{
			var str = "http://" + IpAddr + ":8888/";
			return str;
		}


		public int GetData(string path, out Body respBody)
		{
			return GetData(path, "", out respBody);
		}


		public int GetData(string path, string query, out Body respBody)
		{
			int iresult = 0;
			respBody = new Body();
			try
			{
				var url = StrDomain() + path + query;
				var request = (HttpWebRequest)WebRequest.Create(url);
				request.Method = "GET";
				request.Timeout = 30 * 1000; // 30초

				using (var resp = (HttpWebResponse)request.GetResponse())
				{
					var status = resp.StatusCode;
					//Console.WriteLine(status);  // 정상이면 "OK"

					iresult = respBody.setResp(resp);
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

			return iresult;
		}

	
		public int PostData(string path)
		{
			var body = new Body();
			return PostData(path, ref body);
		}


		public int PostData(string path, ref Body body)
		{
			int iresult = 0;
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
				return -1;
			}

			return 0;
		}


		public int DelData(string path)
		{
			int iresult = 0;
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
				return -1;
			}

			return iresult;
		}
	}
}
