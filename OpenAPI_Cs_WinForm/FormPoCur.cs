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
	public enum CrdType
	{
		Base = 0,
		Robot = 1,
		Axes = 2,
		User = 4
	}


	public partial class FormPoCur : FormClient
	{
		public FormPoCur()
		{
			InitializeComponent();
		}

		
		public int DoUpdate()
		{
			if (Visible == false) return 0;

			UpdateCurPose(CrdType.Axes);
			UpdateCurPose(CrdType.Base);
			UpdateCurPose(CrdType.User);
			return 0;
		}


		protected int UpdateCurPose(CrdType crdType)
		{
			var crd = (int)(crdType);
			var query = string.Format("?crd={0}&mechinfo=-1", crd);
			if (crdType == CrdType.User)
			{
				var item = cbUCrdNos.SelectedItem;
				if (item == null) return -1;
				var ucrd_no = item.ToString();
				if (ucrd_no == "")
				{
					return DisplayCurPose(crdType, null);
				}
				else
				{
					query += string.Format("&ucrd_no={0}", ucrd_no);
				}
			}
			Body body;
			var iret = cli.GetData("project/robot/po_cur", query, out body);
			if (iret < 0) return -1;

			var jo = body.ToJObject();

			return DisplayCurPose(crdType, jo);
		}


		public int UpdateUCrdNos()
		{
			cbUCrdNos.Items.Clear();
			cbUCrdNos.Items.Add("");
			cbUCrdNos.Items.Add(0);

			Body body;
			var iret = cli.GetData("project/control/ucss/ucs_nos", out body);
			if (iret < 0) return -1;

			var jaNo = body.ToJArray();
			foreach (var no in jaNo)
			{
				cbUCrdNos.Items.Add(no);
			}
			cbUCrdNos.SelectedIndex = 0;

			return 0;
		}


		protected int DisplayCurPose(CrdType crdType, JObject jo)
		{
			if (crdType == CrdType.Base || crdType == CrdType.Robot)
			{
				DisplayCurPoseBase(jo);
			}
			else if (crdType == CrdType.Axes)
			{
				DisplayCurPoseAxes(jo);
			}
			else if (crdType == CrdType.User)
			{
				DisplayCurPoseUser(jo);
			}

			return 0;
		}


		protected int DisplayCurPoseAxes(JObject jo)
		{
			var j1 = jo["j1"];
			var j2 = jo["j2"];
			var j3 = jo["j3"];
			var j4 = jo["j4"];
			var j5 = jo["j5"];
			var j6 = jo["j6"];
			tbCurPoseAxes.Text = string.Format("({0}, {1}, {2}, {3}, {4}, {5})", j1, j2, j3, j4, j5, j6);
			return 0;
		}


		protected int DisplayCurPoseBase(JObject jo)
		{
			var x = jo["x"];
			var y = jo["y"];
			var z = jo["z"];
			var rx = jo["rx"];
			var ry = jo["ry"];
			var rz = jo["rz"];
			tbCurPoseBase.Text = string.Format("({0}, {1}, {2}, {3}, {4}, {5})", x, y, z, rx, ry, rz);
			return 0;
		}


		protected int DisplayCurPoseUser(JObject jo)
		{
			if (jo == null)
			{
				tbCurPoseUser.Text = "";
				return 0;
			}
			var x = jo["x"];
			var y = jo["y"];
			var z = jo["z"];
			var rx = jo["rx"];
			var ry = jo["ry"];
			var rz = jo["rz"];
			tbCurPoseUser.Text = string.Format("({0}, {1}, {2}, {3}, {4}, {5})", x, y, z, rx, ry, rz);
			return 0;
		}
	}
}
