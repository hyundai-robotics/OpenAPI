namespace OpenAPI_Cs_WinForm
{
	partial class FormTask
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbSolve = new System.Windows.Forms.RadioButton();
			this.rbAssign = new System.Windows.Forms.RadioButton();
			this.btSolve = new System.Windows.Forms.Button();
			this.btAssign = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbValue = new System.Windows.Forms.Label();
			this.lbVarName = new System.Windows.Forms.Label();
			this.lbExpression = new System.Windows.Forms.Label();
			this.tbValue = new System.Windows.Forms.TextBox();
			this.tbVarName = new System.Windows.Forms.TextBox();
			this.tbExpression = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rbGlobal = new System.Windows.Forms.RadioButton();
			this.rbDontCare = new System.Windows.Forms.RadioButton();
			this.rbLocal = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbSolve);
			this.panel1.Controls.Add(this.rbAssign);
			this.panel1.Location = new System.Drawing.Point(12, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(481, 48);
			this.panel1.TabIndex = 6;
			// 
			// rbSolve
			// 
			this.rbSolve.AutoSize = true;
			this.rbSolve.Location = new System.Drawing.Point(255, 18);
			this.rbSolve.Name = "rbSolve";
			this.rbSolve.Size = new System.Drawing.Size(120, 16);
			this.rbSolve.TabIndex = 3;
			this.rbSolve.Text = "solve expression";
			this.rbSolve.UseVisualStyleBackColor = true;
			this.rbSolve.CheckedChanged += new System.EventHandler(this.rbSolve_CheckedChanged);
			// 
			// rbAssign
			// 
			this.rbAssign.AutoSize = true;
			this.rbAssign.Checked = true;
			this.rbAssign.Location = new System.Drawing.Point(21, 18);
			this.rbAssign.Name = "rbAssign";
			this.rbAssign.Size = new System.Drawing.Size(178, 16);
			this.rbAssign.TabIndex = 3;
			this.rbAssign.TabStop = true;
			this.rbAssign.Text = "assign variable=expression";
			this.rbAssign.UseVisualStyleBackColor = true;
			this.rbAssign.CheckedChanged += new System.EventHandler(this.rbAssign_CheckedChanged);
			// 
			// btSolve
			// 
			this.btSolve.Location = new System.Drawing.Point(267, 336);
			this.btSolve.Name = "btSolve";
			this.btSolve.Size = new System.Drawing.Size(102, 30);
			this.btSolve.TabIndex = 5;
			this.btSolve.Text = "Solve";
			this.btSolve.UseVisualStyleBackColor = true;
			this.btSolve.Click += new System.EventHandler(this.btSolve_Click);
			// 
			// btAssign
			// 
			this.btAssign.Location = new System.Drawing.Point(132, 336);
			this.btAssign.Name = "btAssign";
			this.btAssign.Size = new System.Drawing.Size(102, 30);
			this.btAssign.TabIndex = 5;
			this.btAssign.Text = "Assign";
			this.btAssign.UseVisualStyleBackColor = true;
			this.btAssign.Click += new System.EventHandler(this.btAssign_Click);
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(33, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(436, 2);
			this.label4.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "Scope";
			// 
			// lbValue
			// 
			this.lbValue.AutoSize = true;
			this.lbValue.Location = new System.Drawing.Point(31, 253);
			this.lbValue.Name = "lbValue";
			this.lbValue.Size = new System.Drawing.Size(37, 12);
			this.lbValue.TabIndex = 1;
			this.lbValue.Text = "Value";
			// 
			// lbVarName
			// 
			this.lbVarName.AutoSize = true;
			this.lbVarName.Location = new System.Drawing.Point(31, 138);
			this.lbVarName.Name = "lbVarName";
			this.lbVarName.Size = new System.Drawing.Size(87, 12);
			this.lbVarName.TabIndex = 1;
			this.lbVarName.Text = "Variable name";
			// 
			// lbExpression
			// 
			this.lbExpression.AutoSize = true;
			this.lbExpression.Location = new System.Drawing.Point(31, 180);
			this.lbExpression.Name = "lbExpression";
			this.lbExpression.Size = new System.Drawing.Size(69, 12);
			this.lbExpression.TabIndex = 1;
			this.lbExpression.Text = "Expression";
			// 
			// tbValue
			// 
			this.tbValue.Location = new System.Drawing.Point(132, 250);
			this.tbValue.Multiline = true;
			this.tbValue.Name = "tbValue";
			this.tbValue.ReadOnly = true;
			this.tbValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbValue.Size = new System.Drawing.Size(337, 71);
			this.tbValue.TabIndex = 0;
			// 
			// tbVarName
			// 
			this.tbVarName.Location = new System.Drawing.Point(132, 133);
			this.tbVarName.Name = "tbVarName";
			this.tbVarName.Size = new System.Drawing.Size(337, 21);
			this.tbVarName.TabIndex = 0;
			// 
			// tbExpression
			// 
			this.tbExpression.Location = new System.Drawing.Point(132, 166);
			this.tbExpression.Multiline = true;
			this.tbExpression.Name = "tbExpression";
			this.tbExpression.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbExpression.Size = new System.Drawing.Size(337, 71);
			this.tbExpression.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rbGlobal);
			this.panel2.Controls.Add(this.rbDontCare);
			this.panel2.Controls.Add(this.rbLocal);
			this.panel2.Location = new System.Drawing.Point(118, 79);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(351, 43);
			this.panel2.TabIndex = 6;
			// 
			// rbGlobal
			// 
			this.rbGlobal.AutoSize = true;
			this.rbGlobal.Checked = true;
			this.rbGlobal.Location = new System.Drawing.Point(14, 14);
			this.rbGlobal.Name = "rbGlobal";
			this.rbGlobal.Size = new System.Drawing.Size(57, 16);
			this.rbGlobal.TabIndex = 2;
			this.rbGlobal.TabStop = true;
			this.rbGlobal.Text = "global";
			this.rbGlobal.UseVisualStyleBackColor = true;
			// 
			// rbDontCare
			// 
			this.rbDontCare.AutoSize = true;
			this.rbDontCare.Location = new System.Drawing.Point(201, 14);
			this.rbDontCare.Name = "rbDontCare";
			this.rbDontCare.Size = new System.Drawing.Size(80, 16);
			this.rbDontCare.TabIndex = 2;
			this.rbDontCare.Text = "don\'t care";
			this.rbDontCare.UseVisualStyleBackColor = true;
			// 
			// rbLocal
			// 
			this.rbLocal.AutoSize = true;
			this.rbLocal.Location = new System.Drawing.Point(109, 14);
			this.rbLocal.Name = "rbLocal";
			this.rbLocal.Size = new System.Drawing.Size(50, 16);
			this.rbLocal.TabIndex = 2;
			this.rbLocal.Text = "local";
			this.rbLocal.UseVisualStyleBackColor = true;
			// 
			// FormTask
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 380);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btSolve);
			this.Controls.Add(this.btAssign);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbValue);
			this.Controls.Add(this.lbVarName);
			this.Controls.Add(this.lbExpression);
			this.Controls.Add(this.tbValue);
			this.Controls.Add(this.tbVarName);
			this.Controls.Add(this.tbExpression);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormTask";
			this.Text = "FormTask";
			this.Load += new System.EventHandler(this.FormTask_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbExpression;
		private System.Windows.Forms.Label lbExpression;
		private System.Windows.Forms.RadioButton rbGlobal;
		private System.Windows.Forms.RadioButton rbLocal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbValue;
		private System.Windows.Forms.TextBox tbValue;
		private System.Windows.Forms.RadioButton rbAssign;
		private System.Windows.Forms.RadioButton rbSolve;
		private System.Windows.Forms.Label lbVarName;
		private System.Windows.Forms.TextBox tbVarName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btAssign;
		private System.Windows.Forms.Button btSolve;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rbDontCare;
	}
}