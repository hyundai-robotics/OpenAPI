using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OpenAPI_Cs_WinForm
{
	public class FormClient : Form
	{
		protected HttpCli cli;

		public void SetHttpCli(HttpCli httpCli)
		{
			cli = httpCli;
		}
	}
}
