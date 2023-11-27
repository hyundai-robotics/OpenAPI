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
	public partial class FormTask : FormClient
	{
		public FormTask()
		{
			InitializeComponent();
		}


		private void FormTask_Load(object sender, EventArgs e)
		{
			UpdateControls();
		}


		private void UpdateControls()
		{
			lbVarName.Visible = tbVarName.Visible = btAssign.Visible = rbAssign.Checked;
			lbValue.Visible = tbValue.Visible = btSolve.Visible = rbSolve.Checked;
			tbExpression.Text = "";
		}


		private void rbAssign_CheckedChanged(object sender, EventArgs e)
		{
			UpdateControls();
		}


		private void rbSolve_CheckedChanged(object sender, EventArgs e)
		{
			UpdateControls();
		}


		private void btAssign_Click(object sender, EventArgs e)
		{
			string path = "project/context/tasks[0]/assign_var_expr";

			var joBody = new JObject();
			joBody.Add("name", tbVarName.Text);

			if (rbGlobal.Checked)
			{
				joBody.Add("scope", "global");
			}
			else if (rbGlobal.Checked)
			{
				joBody.Add("scope", "local");
			}
			// else don't care

			joBody.Add("expr", tbExpression.Text);

			var body = new Body(joBody);
			cli.ProcPost(path, ref body);
		}


		private void btSolve_Click(object sender, EventArgs e)
		{
			tbValue.Text = "";

			string path = "project/context/tasks[0]/solve_expr";

			var joBody = new JObject();

			if (rbGlobal.Checked)
			{
				joBody.Add("scope", "global");
			}
			else if (rbGlobal.Checked)
			{
				joBody.Add("scope", "local");
			}
			// else don't care

			joBody.Add("expr", tbExpression.Text);

			var body = new Body(joBody);
			var iret = cli.ProcPost(path, ref body);
			if (iret != 200) return;
			 
			tbValue.Text = body.strBuf;
		}
	}
}
