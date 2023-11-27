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

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// FormClient
			// 
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormClient";
			this.ResumeLayout(false);

		}
	}
}
