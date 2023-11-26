using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OpenAPI_Cs_WinForm
{
	public class FileCli : HttpCli
	{
		public int GetList(string path, bool incl_dir, bool incl_file, out JArray jaFileInfos)
		{
			string url_path = "file_manager/file_list";
			string str_incl_dir = incl_dir ? "true" : "false";
			string str_incl_file = incl_file ? "true" : "false";
			string query = string.Format("?path={0}&incl_dir={1}&incl_file={2}"
				, path, str_incl_dir, str_incl_file);
			string respBody = "";

			var iret = GetData(url_path, query, ref respBody);
			if (iret < 0)
			{
				jaFileInfos = new JArray();
				return iret;
			}

			jaFileInfos = JArray.Parse(respBody);
			
			return 0;
		}
	}
}
