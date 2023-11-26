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
	public partial class FormFileMng : FormClient
	{
		protected FileCli fcli;

		public FormFileMng()
		{
			InitializeComponent();
			Init();
		}

		private void Init()
		{
			
		}


		public void SetFileCli(FileCli fileCli)
		{
			fcli = fileCli;
		}


		private void btUpdateRemote_Click(object sender, EventArgs e)
		{
			lvRemote.Items.Clear();

			JArray jaFileInfos;
			var iret = fcli.GetList("", true, true, out jaFileInfos);
			if (iret < 0) return;

			// dirs
			foreach (var fi in jaFileInfos)
			{
				var jo = fi.ToObject<JObject>();
				if(IsFileInfoDir(jo)==false) continue;
				AddFileInfoToLvRemote(jo);
			}

			// files
			foreach (var fi in jaFileInfos)
			{
				var jo = fi.ToObject<JObject>();
				if (IsFileInfoDir(jo)) continue;
				AddFileInfoToLvRemote(jo);
			}
		}


		private bool IsFileInfoDir(JObject jo)
		{
			return jo["is_dir"].Value<bool>();
		}


		private void AddFileInfoToLvRemote(JObject jo)
		{
			var fname = jo["fname"].ToString();
			var is_dir = IsFileInfoDir(jo);
			var size = is_dir ? "<dir>" : jo["size"].ToString();
			var datetime = StrDateTime(jo);

			var strs = new String[] { fname, size, datetime };
			var item = new ListViewItem(strs);
			lvRemote.Items.Add(item);
		}


		private string StrDateTime(JObject jo)
		{
			var year = PropVal(jo, "year", "D4");
			var month = PropVal(jo, "month", "D2");
			var mday = PropVal(jo, "mday", "D2");
			var hour = PropVal(jo, "hour", "D2");
			var min = PropVal(jo, "min", "D2");
			string str = String.Format(
				"{0}/{1}/{2} {3}:{4}"
				, year, month, mday, hour, min);
			return str;
		}


		private string PropVal(JObject jo, string key, string fmt)
		{
			return jo[key].Value<int>().ToString(fmt);
		}
	}
}
