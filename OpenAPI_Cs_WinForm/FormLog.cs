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
		// last received event id.
		// Use this for setting id_min query-parameter. You don't have to receive events that you already received.
		private Int64 _eidLastReceived = -1;


		private JArray _jaNewEvents = new JArray();	// buffer to keep newly generated events

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

			Body body;
			var iret = cli.GetData("logManager/search", query, out body);

			_jaNewEvents.Clear();
			ParseAddEvents(body.strBuf);
			DisplayLog();
			return 0;
		}


		private string MakeUpdateQuery()
		{
			var query = string.Format("?n_item={0}&cat_p={1}&id_min={2}", 5, "E,W,N,H", _eidLastReceived+1);
			return query;
		}


		private void ParseAddEvents(string strEvents)
		{
			string[] strsEvent = strEvents.Split('\n');

			foreach(var str in strsEvent)
			{
				ParseAddEvent(str);
			}
		}


		private int ParseAddEvent(string str)
		{
			try
			{
				if (String.IsNullOrWhiteSpace(str)) return -1;

				var jo = JObject.Parse(str);
				_jaNewEvents.Add(jo);
				UpdateEidLastReceived(jo);
			}
			catch (JsonReaderException)
			{
				return -1;
			}

			return 0;
		}


		private int UpdateEidLastReceived(JObject joEvent)
		{
			JToken tk;
			bool b = joEvent.TryGetValue("id", out tk);
			if (b == false) return -1;
			var eid = tk.Value<int>();
			if (_eidLastReceived < eid)
			{
				_eidLastReceived = eid;
			}
			return 0;
		}


		private int DisplayLog()
		{
			var n = _jaNewEvents.Count();
			for (int i = (n - 1); i >= 0; i--)
			{
				var tkEvent = _jaNewEvents[i];
				var jo = tkEvent.Value<JObject>();
				var str = MakeLogString(jo);
				tbLog.AppendText(str);
				tbLog.AppendText("\r\n");
			}

			return 0;
		}


		private string MakeLogString(JObject jo)
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
