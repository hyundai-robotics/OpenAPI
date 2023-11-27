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
	public class Body
	{
		public Body()
		{
			contentType = "application/json";
			strBuf = "";
		}


		public Body(JObject jo)
		{
			contentType = "application/json";
			strBuf = jo.ToString();
		}


		public int setResp(HttpWebResponse resp)
		{
			contentType = resp.ContentType;
			var stream = resp.GetResponseStream();
			if (IsStr())
			{
				using (var sr = new StreamReader(stream))
				{
					strBuf = sr.ReadToEnd();
				}
			}
			else
			{
				var nbyte = resp.ContentLength;
				binBuf = new byte[nbyte];

				stream.Read(binBuf, 0, (int)nbyte);
			}

			return (int)(resp.StatusCode);
		}


		public bool IsStr()
		{
			return !IsBin();
		}


		public bool IsBin()
		{
			return contentType.Contains("/octet-stream");
		}


		public JArray ToJArray()
		{
			if (IsBin()) return null;
			var ja = JArray.Parse(strBuf);
			return ja;
		}


		public JObject ToJObject()
		{
			if (IsBin()) return null;
			var jo = JObject.Parse(strBuf);
			return jo;
		}


		public byte[] ToBytes()
		{
			byte[] bytes = IsStr() ? Encoding.ASCII.GetBytes(strBuf) : binBuf;
			return bytes;
		}


		public string contentType;
		public string strBuf;
		public byte[] binBuf;
	}
}
