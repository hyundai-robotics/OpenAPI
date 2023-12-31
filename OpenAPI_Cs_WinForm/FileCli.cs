﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OpenAPI_Cs_WinForm
{
	public class FileCli : HttpCli
	{
		// --------------------------------------------------------
		/// @param[in]		path
		/// @param[in]		incl_dir		whether to include directories
		/// @param[in]		incl_file		whether to include files
		/// @param[out]		jaFileInfos		file info array
		/// @return
		///			-	>0		HTTP status code (e.g. 200=OK)
		///			-	-1		unready
		///			-	-2		request fault
		// --------------------------------------------------------
		public int GetList(string path, bool incl_dir, bool incl_file, out JArray jaFileInfos)
		{
			string urlPath = "file_manager/file_list";
			string str_incl_dir = incl_dir ? "true" : "false";
			string str_incl_file = incl_file ? "true" : "false";
			string query = string.Format("?path={0}&incl_dir={1}&incl_file={2}"
				, path, str_incl_dir, str_incl_file);
			Body body;

			var iret = ProcGet(urlPath, query, out body);
			if (iret < 0)
			{
				jaFileInfos = new JArray();
				return iret;
			}

			jaFileInfos = body.ToJArray();
			
			return 0;
		}


		// --------------------------------------------------------
		/// @param[in]		pathnameLocal	target absolute pathname
		/// @param[in]		pathnameRemote	source relative pathname
		///									(e.g. "project/jobs/9991.job")
		/// @return
		///			-	>0		HTTP status code (e.g. 200=OK)
		///			-	-1		unready
		///			-	-2		request fault
		// --------------------------------------------------------
		public int GetFile(string pathnameLocal, string pathnameRemote)
		{
			string urlPath = "file_manager/files";
			string query = "?pathname=" + pathnameRemote;
			Body body;

			var iret = ProcGet(urlPath, query, out body);
			if (iret < 0) return iret;

			var fs = new FileStream(pathnameLocal, FileMode.CreateNew, FileAccess.Write);
			var bw = new BinaryWriter(fs);	// (transmit always with binary)
			bw.Write(body.binBuf);

			fs.Close();

			return 0;
		}


		// --------------------------------------------------------
		/// @param[in]		pathnameLocal	source absolute pathname
		/// @param[in]		pathnameRemote	target relative pathname
		///									(e.g. "project/jobs/9991.job")
		/// @return
		///			-	>0		HTTP status code (e.g. 200=OK)
		///			-	-1		unready
		///			-	-2		request fault
		// --------------------------------------------------------
		public int PutFile(string pathnameLocal, string pathnameRemote)
		{
			string urlPath = "file_manager/files/";
			urlPath += pathnameRemote;
			var body = new Body();
			body.contentType = "application/octet-stream";	// (transmit always with binary)

			var fs = new FileStream(pathnameLocal, FileMode.Open, FileAccess.Read);
			var br = new BinaryReader(fs);
			var nbyte = new FileInfo(pathnameLocal).Length;

			body.binBuf = new byte[nbyte];
			br.Read(body.binBuf, 0, (int)nbyte);
			fs.Close();

			return ProcPost(urlPath, ref body);
		}


		// --------------------------------------------------------
		/// @param[in]		pathnameRemote	relative pathname to delete
		///									(e.g. "project/jobs/9991.job")
		/// @return
		///			-	>0		HTTP status code (e.g. 200=OK)
		///			-	-1		unready
		///			-	-2		request fault
		// --------------------------------------------------------
		public int DelFile(string pathnameRemote)
		{
			string urlPath = "file_manager/files/";
			urlPath += pathnameRemote;

			return ProcDel(urlPath);
		}
	}
}
