namespace OpenAPI_Cs_WinForm
{
	partial class FormPoCur
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
			this.cbUCrdNos = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbCurPoseUser = new System.Windows.Forms.TextBox();
			this.tbCurPoseBase = new System.Windows.Forms.TextBox();
			this.tbCurPoseAxes = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cbUCrdNos
			// 
			this.cbUCrdNos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUCrdNos.FormattingEnabled = true;
			this.cbUCrdNos.Location = new System.Drawing.Point(86, 93);
			this.cbUCrdNos.Name = "cbUCrdNos";
			this.cbUCrdNos.Size = new System.Drawing.Size(61, 20);
			this.cbUCrdNos.Sorted = true;
			this.cbUCrdNos.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(24, 97);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 12);
			this.label8.TabIndex = 4;
			this.label8.Text = "USER";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(24, 67);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 12);
			this.label7.TabIndex = 2;
			this.label7.Text = "BASE";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(24, 37);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 12);
			this.label6.TabIndex = 0;
			this.label6.Text = "AXES";
			// 
			// tbCurPoseUser
			// 
			this.tbCurPoseUser.Location = new System.Drawing.Point(153, 93);
			this.tbCurPoseUser.Name = "tbCurPoseUser";
			this.tbCurPoseUser.ReadOnly = true;
			this.tbCurPoseUser.Size = new System.Drawing.Size(285, 21);
			this.tbCurPoseUser.TabIndex = 6;
			// 
			// tbCurPoseBase
			// 
			this.tbCurPoseBase.Location = new System.Drawing.Point(86, 63);
			this.tbCurPoseBase.Name = "tbCurPoseBase";
			this.tbCurPoseBase.ReadOnly = true;
			this.tbCurPoseBase.Size = new System.Drawing.Size(352, 21);
			this.tbCurPoseBase.TabIndex = 3;
			// 
			// tbCurPoseAxes
			// 
			this.tbCurPoseAxes.Location = new System.Drawing.Point(86, 32);
			this.tbCurPoseAxes.Name = "tbCurPoseAxes";
			this.tbCurPoseAxes.ReadOnly = true;
			this.tbCurPoseAxes.Size = new System.Drawing.Size(352, 21);
			this.tbCurPoseAxes.TabIndex = 1;
			// 
			// FormPoCur
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 234);
			this.Controls.Add(this.cbUCrdNos);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbCurPoseUser);
			this.Controls.Add(this.tbCurPoseBase);
			this.Controls.Add(this.tbCurPoseAxes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormPoCur";
			this.Text = "FormPoCur";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbUCrdNos;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbCurPoseUser;
		private System.Windows.Forms.TextBox tbCurPoseBase;
		private System.Windows.Forms.TextBox tbCurPoseAxes;
	}
}