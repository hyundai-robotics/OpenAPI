using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace OpenAPI_Cs_WinForm
{
	public struct EidLast
	{
		public Int64 err;
		public Int64 warn;
		public Int64 notice;
		public Int64 history;

		public void SetFrom(JObject joRGen)
		{
			err = joRGen.Value<Int64>("eid_last_err");
			warn = joRGen.Value<Int64>("eid_last_warn");
			notice = joRGen.Value<Int64>("eid_last_noti");
			history = joRGen.Value<Int64>("eid_last_history");
		}
	}
}
