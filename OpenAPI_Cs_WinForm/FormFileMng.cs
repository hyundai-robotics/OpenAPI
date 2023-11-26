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
		enum Column : int
		{
			FName = 0,
			Size,
			DateTime
		}

		private const string dirMark = "<dir>";

		protected FileCli fcli;

		public FormFileMng()
		{
			InitializeComponent();
			Init();
		}

		private void Init()
		{
			
		}


		// ====================================================================
		// REMOTE
		// ====================================================================
		public void SetFileCli(FileCli fileCli)
		{
			fcli = fileCli;
		}


		private void btUpdateRemote_Click(object sender, EventArgs e)
		{
			var path = tbPathRemote.Text;
			UpdateRemoteFileList(path);
		}


		private void UpdateRemoteFileList(string path)
		{
			lvRemote.Items.Clear();

			JArray jaFileInfos;
			var iret = fcli.GetList(path, true, true, out jaFileInfos);
			if (iret < 0) return;

			// dirs
			if (path != "")
			{
				AddParentDirToLvRemote();
			}
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


		private void AddParentDirToLvRemote()
		{
			var strs = new String[] { "..", dirMark, "" };
			var item = new ListViewItem(strs);
			lvRemote.Items.Add(item);
		}


		private void AddFileInfoToLvRemote(JObject jo)
		{
			var fname = jo["fname"].ToString();
			var is_dir = IsFileInfoDir(jo);
			var size = is_dir ? dirMark : jo["size"].ToString();
			var dt = DateTimeFrom(jo);
			var datetime = dt.ToString("yyyy/MM/dd hh:mm");

			var strs = new String[] { fname, size, datetime };
			var item = new ListViewItem(strs);
			lvRemote.Items.Add(item);
		}


		private System.DateTime DateTimeFrom(JObject jo)
		{
			var year = jo["year"].Value<int>();
			var month = jo["month"].Value<int>();
			var mday = jo["mday"].Value<int>();
			var hour = jo["hour"].Value<int>();
			var min = jo["min"].Value<int>();

			var dt = new System.DateTime(year, month, mday, hour, min, 0);
			return dt;
		}


		private void lvRemote_MouseClick(object sender, MouseEventArgs e)
		{
			var items = lvRemote.SelectedItems;
			if (items.Count != 1) return;
			var item = items[(int)Column.FName];
			var fname = item.Text;
			var size = item.SubItems[(int)Column.Size].Text;
			tbFNameRemote.Text = (size == dirMark) ? "" : fname;
		}


		private void lvRemote_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			var items = lvRemote.SelectedItems;
			if (items.Count != 1) return;
			var item = items[(int)Column.FName];
			var fname = item.Text;
			var size = item.SubItems[(int)Column.Size].Text;
			if (size != dirMark) return;

			if (fname == "..")
			{
				SetToUpperDirRemote();
			}
			else if (tbPathRemote.Text == "") {
				tbPathRemote.Text = fname;
			}
			else {
				tbPathRemote.Text += "/" + fname;
			}
			tbFNameRemote.Text = "";

			var path = tbPathRemote.Text;
			UpdateRemoteFileList(path);
		}


		private void SetToUpperDirRemote()
		{
			var path = tbPathRemote.Text;
			tbPathRemote.Text = UpperPath(path);
		}


		private void btGet_Click(object sender, EventArgs e)
		{
			string pathnameLocal = "";
			string pathnameRemote = tbPathRemote.Text + "/" + tbFNameRemote.Text;
			fcli.GetFile(pathnameLocal, pathnameRemote);
		}


		// ====================================================================
		// LOCAL
		// ====================================================================
		private void btUpdateLocal_Click(object sender, EventArgs e)
		{
			UpdateLocalFileList(tbPathLocal.Text);
		}


		private void UpdateLocalFileList(string path)
		{
			lvLocal.Items.Clear();
			string _path = path.Replace('\\', '/');

			try
			{
				var di = new System.IO.DirectoryInfo(_path);
				
				// dirs
				if (_path.Length > 3)	// e.g. "D:/"
				{
					AddParentDirToLvLocal();
				}
				foreach (var di_sub in di.GetDirectories())
				{
					AddFileInfoToLvLocal(di_sub);
				}
				// files
				foreach (var fi in di.GetFiles())
				{
					AddFileInfoToLvLocal(fi);
				}
			}
			catch(Exception)
			{
			}
		}


		private void AddParentDirToLvLocal()
		{
			var strs = new String[] { "..", dirMark, "" };
			var item = new ListViewItem(strs);
			lvLocal.Items.Add(item);
		}

		
		private void AddFileInfoToLvLocal(System.IO.FileSystemInfo fsi)
		{
			var fname = fsi.Name;
			string size;
			if (fsi is System.IO.FileInfo)
			{
				var fi = (System.IO.FileInfo)fsi;
				size = fi.Length.ToString();
			}
			else
			{
				size = dirMark;
			}
			var datetime = fsi.LastWriteTime.ToString("yyyy/MM/dd hh:mm");
			var strs = new String[] { fname, size, datetime };
			var item = new ListViewItem(strs);
			lvLocal.Items.Add(item);
		}


		private void lvLocal_MouseClick(object sender, MouseEventArgs e)
		{
			var items = lvLocal.SelectedItems;
			if (items.Count != 1) return;
			var item = items[(int)Column.FName];
			var fname = item.Text;
			var size = item.SubItems[(int)Column.Size].Text;
			tbFNameLocal.Text = (size == dirMark) ? "" : fname;
		}


		private void lvLocal_MouseDoubleClick(object sender, MouseEventArgs e)
		{		
			var items = lvLocal.SelectedItems;
			if (items.Count != 1) return;
			var item = items[(int)Column.FName];
			var fname = item.Text;
			var size = item.SubItems[(int)Column.Size].Text;
			if (size != dirMark) return;

			if (fname == "..")
			{
				SetToUpperDirLocal();
			}
			else if (tbPathLocal.Text.EndsWith("/"))
			{
				tbPathLocal.Text += fname;
			}
			else
			{
				tbPathLocal.Text += "/" + fname;
			}
			tbFNameLocal.Text = "";

			var path = tbPathLocal.Text;
			UpdateLocalFileList(path);
		}


		private void SetToUpperDirLocal()
		{
			var path = tbPathLocal.Text;
			tbPathLocal.Text = UpperPath(path);
		}


		// ====================================================================
		// COMMON
		// ====================================================================
		private string UpperPath(string path)
		{
			string _path = path.Replace('\\', '/');
			if (_path == "") return "";
			var idx = _path.LastIndexOf('/');
			_path = (idx < 0) ? "" : _path.Substring(0, idx);
			if (_path.EndsWith(":")) _path += '/';	// e.g. "D:/" <- "D:"
			return _path;
		}
	}
}
