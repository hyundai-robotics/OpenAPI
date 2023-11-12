namespace OpenAPI_Cs_WinForm
{
	partial class FormBase
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
			this.components = new System.ComponentModel.Container();
			this.tbState = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbProgCnt = new System.Windows.Forms.TextBox();
			this.timerUpdate = new System.Windows.Forms.Timer(this.components);
			this.btSelectJob = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbState
			// 
			this.tbState.Location = new System.Drawing.Point(27, 21);
			this.tbState.Name = "tbState";
			this.tbState.ReadOnly = true;
			this.tbState.Size = new System.Drawing.Size(100, 21);
			this.tbState.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "Program Counter";
			// 
			// tbProgCnt
			// 
			this.tbProgCnt.Location = new System.Drawing.Point(29, 65);
			this.tbProgCnt.Name = "tbProgCnt";
			this.tbProgCnt.ReadOnly = true;
			this.tbProgCnt.Size = new System.Drawing.Size(100, 21);
			this.tbProgCnt.TabIndex = 3;
			// 
			// timerUpdate
			// 
			this.timerUpdate.Interval = 1000;
			this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
			// 
			// btSelectJob
			// 
			this.btSelectJob.Location = new System.Drawing.Point(29, 107);
			this.btSelectJob.Name = "btSelectJob";
			this.btSelectJob.Size = new System.Drawing.Size(89, 31);
			this.btSelectJob.TabIndex = 4;
			this.btSelectJob.Text = "Select JOB";
			this.btSelectJob.UseVisualStyleBackColor = true;
			this.btSelectJob.Click += new System.EventHandler(this.btSelectJob_Click);
			// 
			// FormBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 354);
			this.Controls.Add(this.btSelectJob);
			this.Controls.Add(this.tbProgCnt);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbState);
			this.Name = "FormBase";
			this.Text = "Base";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbState;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbProgCnt;
		private System.Windows.Forms.Timer timerUpdate;
		private System.Windows.Forms.Button btSelectJob;
	}
}

