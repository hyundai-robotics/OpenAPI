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
	public partial class FormIoRelay : FormClient
	{
		protected enum DataType
		{
			Invalid = -1,
			Bit,
			Char,
			Short,
			Long
		}

		
		protected enum RelayNotation
		{
			Url,
			Variable
		}


		public FormIoRelay()
		{
			InitializeComponent();

			cbObjType.SelectedIndex = 0;
			cbRelayType.SelectedIndex = 0;
			cbDataType.SelectedIndex = 0;
		}


		public int DoUpdate()
		{
			if (Visible==false) return 0;

			string relayName = SelectedRelayName(RelayNotation.Url);
			if (relayName == "") return -1;
			string path = string.Format("project/plc/{0}/val_s32", relayName);
			string query = "?st=0&len=30";	// 30 * 4byte = 120byte
			string respBody = "";

			var iret = cli.GetData(path, query, ref respBody);
			if (iret < 0) return -1;

			var jaLong = JArray.Parse(respBody);

			var dataType = SelectedDataType();
			if (dataType == DataType.Invalid) return -1;

			int idx = 0;
			int.TryParse(tbIndex.Text, out idx);
			var val = GetValueFromJaLong(jaLong, dataType, idx);
			tbCurValue.Text = val.ToString();

			return 0;
		}


		protected string SelectedRelayName(RelayNotation notation)
		{
			char separator = (notation == RelayNotation.Url) ? '_' : '.';

			var item = cbRelayType.SelectedItem;
			if (item == null) return "";
			var name = item.ToString();
			if (HasObjType(name))
			{
				item = cbObjType.SelectedItem;
				if (item == null) return "";
				var objType = item.ToString();
				var prefix = objType + tbObjIdx.Text + separator;
				name = prefix + name;
			}
			else if (notation == RelayNotation.Variable)
			{
				name = '_' + name;		// _m, _s ..
			}

			if (notation == RelayNotation.Variable)
			{
				name += SelectedDataTypeSuffix();
			}
			return name;
		}


		protected DataType SelectedDataType()
		{
			var item = cbDataType.SelectedItem;
			if (item == null) return DataType.Invalid;
			var str = cbDataType.SelectedItem.ToString();
			if (str == "Bit") return DataType.Bit;
			else if (str == "Char") return DataType.Char;
			else if (str == "Short") return DataType.Short;
			else if (str == "Long") return DataType.Long;
			else return DataType.Invalid;
		}


		protected string SelectedDataTypeSuffix()
		{
			var item = cbDataType.SelectedItem;
			if (item == null) return "";
			var str = cbDataType.SelectedItem.ToString();
			if (str == "Bit") return "";
			else if (str == "Char") return "b";
			else if (str == "Short") return "w";
			else if (str == "Long") return "l";
			else return "";
		}


		protected bool HasObjType(string relayType)
		{
			var str = relayType;
			bool b = (str == "di" || str == "do" || str == "x" || str == "y");
			return b;
		}


		private void cbRelayType_SelectedIndexChanged(object sender, EventArgs e)
		{
			var item = cbRelayType.SelectedItem;
			if (item == null) return;
			var on = HasObjType(item.ToString());
			lbObjType.Visible = on;
			cbObjType.Visible = on;
			lbObjIdx.Visible = on;
			tbObjIdx.Visible = on;
		}


		protected int GetValueFromJaLong(JArray jaLong, DataType dataType, int idx)
		{
			switch (dataType)
			{
				case DataType.Bit:
					return GetBitFromJaLong(jaLong, idx);

				case DataType.Char:
					return GetCharFromJaLong(jaLong, idx);

				case DataType.Short:
					return GetShortFromJaLong(jaLong, idx);

				case DataType.Long:
					return GetLongFromJaLong(jaLong, idx);
			}

			return 0;
		}


		protected int GetBitFromJaLong(JArray jaLong, int idx)
		{
			int i = idx / 32;
			var s32 = jaLong[i].Value<int>();
			var nBitToShift = idx % 32;
			s32 >>= nBitToShift;
			return s32 & 0x1;
		}


		protected int GetCharFromJaLong(JArray jaLong, int idx)
		{
			int i = idx / 4;
			var s32 = jaLong[i].Value<int>();
			var nBitToShift = (idx % 4) * 8;
			s32 >>= nBitToShift;
			return s32 & 0xFF;
		}


		protected int GetShortFromJaLong(JArray jaLong, int idx)
		{
			int i = idx / 2;
			var s32 = jaLong[i].Value<int>();
			if ((idx % 2) == 1)
			{
				s32 >>= 16;
			}
			return s32 & 0xFFFF;
		}


		protected int GetLongFromJaLong(JArray jaLong, int idx)
		{
			return jaLong[idx].Value<int>();
		}


		private void btSet_Click(object sender, EventArgs e)
		{
			string path = "project/plc/set_relay_value";

			var name = SelectedRelayName(RelayNotation.Variable);
			name += tbIndex.Text;
			var strValue = tbNewValue.Text;

			var joReqBody = new JObject();
			joReqBody.Add("name", name);
			joReqBody.Add("value", strValue);

			cli.PostData(path, joReqBody.ToString());
		}
	}
}
