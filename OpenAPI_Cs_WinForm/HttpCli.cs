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
	class HttpCli
	{
		public string IpAddr;

		public string StrDomain()
		{
			var str = "http://" + IpAddr + ":8888/";
			return str;
		}


		public int GetData(string path, ref string respBody)
		{
			return GetData(path, "", ref respBody);
		}


		public int GetData(string path, string query, ref string respBody)
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


		public int PostData(string path)
		{
			var joReqBody = new JObject();
			return PostData(path, joReqBody.ToString());
		}


		public int PostData(string path, string reqBody)
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
