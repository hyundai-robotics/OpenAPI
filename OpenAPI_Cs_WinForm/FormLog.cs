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
	public partial class FormLog :  FormClient
	{
		private Int64 _eidLatest = 0;
		private JArray _jaEvents = new JArray();

		public FormLog()
		{
			InitializeComponent();
		}


		public int DoUpdate()
		{
			// update only when new events is generated;
			if (_eidLastOld.Equals(_eidLast)) return 0;
			_eidLastOld = _eidLast;

			var query = MakeUpdateQuery();

			Body respBody;
			var iret = cli.GetData("logManager/search", query, out respBody);

			_jaEvents.Clear();
			ParseAddEvents(respBody.strBuf);
			DisplayLog();
			return 0;
		}


		protected string MakeUpdateQuery()
		{
			var query = string.Format("?n_item={0}&cat_p={1}&id_min={2}", 5, "E,W,N,H", _eidLatest+1);
			return query;
		}


		protected void ParseAddEvents(string strEvents)
		{
			string[] strsEvent = strEvents.Split('\n');

			foreach(var str in strsEvent)
			{
				ParseAddEvent(str);
			}
		}


		protected int ParseAddEvent(string str)
		{
			try
			{
				if (String.IsNullOrWhiteSpace(str)) return -1;

				var jo = JObject.Parse(str);
				_jaEvents.Add(jo);
				UpdateEidLatest(jo);
			}
			catch (JsonReaderException)
			{
				return -1;
			}

			return 0;
		}


		protected int UpdateEidLatest(JObject joEvent)
		{
			JToken tk;
			bool b = joEvent.TryGetValue("id", out tk);
			if (b == false) return -1;
			var eid = tk.Value<int>();
			if (_eidLatest < eid)
			{
				_eidLatest = eid;
			}
			return 0;
		}


		protected int DisplayLog()
		{
			var n = _jaEvents.Count();
			for (int i = (n - 1); i >= 0; i--)
			{
				var tkEvent = _jaEvents[i];
				var jo = tkEvent.Value<JObject>();
				var str = MakeLogString(jo);
				tbLog.AppendText(str);
				tbLog.AppendText("\r\n");
			}

			return 0;
		}


		protected string MakeLogString(JObject jo)
		{
			try {
				var timeStamp = jo["ts"].ToString();
				var cat = jo["cat"].ToString();
				var code = jo["code"].ToString();
				var aux = jo["aux"].ToString();

				var str = string.Format("[{0}] {1},{2},{3}", timeStamp, cat, code, aux);
				return str;
			}
			catch(NullReferenceException)
			{
				return "";
			}
		}


		private EidLast _eidLastOld;
		private EidLast _eidLast;
		public EidLast EidLast
		{
			set { _eidLast = value; }
		}
	}
}
