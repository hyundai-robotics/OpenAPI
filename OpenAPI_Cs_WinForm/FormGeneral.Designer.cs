namespace OpenAPI_Cs_WinForm
{
	partial class FormGeneral
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
			this.btStart = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btReset = new System.Windows.Forms.Button();
			this.btSelStepFunc = new System.Windows.Forms.Button();
			this.btSelectJob = new System.Windows.Forms.Button();
			this.tbFunc = new System.Windows.Forms.TextBox();
			this.tbStep = new System.Windows.Forms.TextBox();
			this.tbJobNo = new System.Windows.Forms.TextBox();
			this.tbPlayback = new System.Windows.Forms.TextBox();
			this.tbMotor = new System.Windows.Forms.TextBox();
			this.tbProgCnt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbMode = new System.Windows.Forms.TextBox();
			this.btMotorOn = new System.Windows.Forms.Button();
			this.btMotorOff = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btStart
			// 
			this.btStart.Location = new System.Drawing.Point(28, 253);
			this.btStart.Name = "btStart";
			this.btStart.Size = new System.Drawing.Size(73, 40);
			this.btStart.TabIndex = 13;
			this.btStart.Text = "START";
			this.btStart.UseVisualStyleBackColor = true;
			this.btStart.Click += new System.EventHandler(this.btStart_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(107, 253);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(73, 40);
			this.button1.TabIndex = 14;
			this.button1.Text = "STOP";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btStop_Click);
			// 
			// btReset
			// 
			this.btReset.Location = new System.Drawing.Point(185, 253);
			this.btReset.Name = "btReset";
			this.btReset.Size = new System.Drawing.Size(73, 40);
			this.btReset.TabIndex = 15;
			this.btReset.Text = "RESET";
			this.btReset.UseVisualStyleBackColor = true;
			this.btReset.Click += new System.EventHandler(this.btReset_Click);
			// 
			// btSelStepFunc
			// 
			this.btSelStepFunc.Location = new System.Drawing.Point(28, 215);
			this.btSelStepFunc.Name = "btSelStepFunc";
			this.btSelStepFunc.Size = new System.Drawing.Size(132, 21);
			this.btSelStepFunc.TabIndex = 10;
			this.btSelStepFunc.Text = "Select Step/Func";
			this.btSelStepFunc.UseVisualStyleBackColor = true;
			this.btSelStepFunc.Click += new System.EventHandler(this.btSelectStepFunc_Click);
			// 
			// btSelectJob
			// 
			this.btSelectJob.Location = new System.Drawing.Point(28, 177);
			this.btSelectJob.Name = "btSelectJob";
			this.btSelectJob.Size = new System.Drawing.Size(132, 21);
			this.btSelectJob.TabIndex = 8;
			this.btSelectJob.Text = "Select JOB";
			this.btSelectJob.UseVisualStyleBackColor = true;
			this.btSelectJob.Click += new System.EventHandler(this.btSelectJob_Click);
			// 
			// tbFunc
			// 
			this.tbFunc.Location = new System.Drawing.Point(216, 215);
			this.tbFunc.Name = "tbFunc";
			this.tbFunc.Size = new System.Drawing.Size(42, 21);
			this.tbFunc.TabIndex = 12;
			this.tbFunc.Text = "0";
			this.tbFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbStep
			// 
			this.tbStep.Location = new System.Drawing.Point(166, 215);
			this.tbStep.Name = "tbStep";
			this.tbStep.Size = new System.Drawing.Size(44, 21);
			this.tbStep.TabIndex = 11;
			this.tbStep.Text = "0";
			this.tbStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbJobNo
			// 
			this.tbJobNo.Location = new System.Drawing.Point(166, 177);
			this.tbJobNo.Name = "tbJobNo";
			this.tbJobNo.Size = new System.Drawing.Size(92, 21);
			this.tbJobNo.TabIndex = 9;
			this.tbJobNo.Text = "1";
			this.tbJobNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbPlayback
			// 
			this.tbPlayback.Location = new System.Drawing.Point(166, 141);
			this.tbPlayback.Name = "tbPlayback";
			this.tbPlayback.ReadOnly = true;
			this.tbPlayback.Size = new System.Drawing.Size(92, 21);
			this.tbPlayback.TabIndex = 7;
			// 
			// tbMotor
			// 
			this.tbMotor.Location = new System.Drawing.Point(28, 89);
			this.tbMotor.Name = "tbMotor";
			this.tbMotor.ReadOnly = true;
			this.tbMotor.Size = new System.Drawing.Size(73, 21);
			this.tbMotor.TabIndex = 3;
			// 
			// tbProgCnt
			// 
			this.tbProgCnt.Location = new System.Drawing.Point(28, 141);
			this.tbProgCnt.Name = "tbProgCnt";
			this.tbProgCnt.ReadOnly = true;
			this.tbProgCnt.Size = new System.Drawing.Size(132, 21);
			this.tbProgCnt.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mode";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(164, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 12);
			this.label4.TabIndex = 6;
			this.label4.Text = "Playback";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "Motor";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 125);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "Program Counter";
			// 
			// tbMode
			// 
			this.tbMode.Location = new System.Drawing.Point(28, 41);
			this.tbMode.Name = "tbMode";
			this.tbMode.ReadOnly = true;
			this.tbMode.Size = new System.Drawing.Size(108, 21);
			this.tbMode.TabIndex = 1;
			// 
			// btMotorOn
			// 
			this.btMotorOn.Location = new System.Drawing.Point(107, 89);
			this.btMotorOn.Name = "btMotorOn";
			this.btMotorOn.Size = new System.Drawing.Size(73, 21);
			this.btMotorOn.TabIndex = 16;
			this.btMotorOn.Text = "Mot.ON";
			this.btMotorOn.UseVisualStyleBackColor = true;
			this.btMotorOn.Click += new System.EventHandler(this.btMotorOn_Click);
			// 
			// btMotorOff
			// 
			this.btMotorOff.Location = new System.Drawing.Point(185, 89);
			this.btMotorOff.Name = "btMotorOff";
			this.btMotorOff.Size = new System.Drawing.Size(73, 21);
			this.btMotorOff.TabIndex = 16;
			this.btMotorOff.Text = "Mot.OFF";
			this.btMotorOff.UseVisualStyleBackColor = true;
			this.btMotorOff.Click += new System.EventHandler(this.btMotorOff_Click);
			// 
			// FormGeneral
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 332);
			this.Controls.Add(this.btMotorOff);
			this.Controls.Add(this.btMotorOn);
			this.Controls.Add(this.btStart);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btReset);
			this.Controls.Add(this.btSelStepFunc);
			this.Controls.Add(this.btSelectJob);
			this.Controls.Add(this.tbFunc);
			this.Controls.Add(this.tbStep);
			this.Controls.Add(this.tbJobNo);
			this.Controls.Add(this.tbPlayback);
			this.Controls.Add(this.tbMotor);
			this.Controls.Add(this.tbProgCnt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbMode);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormGeneral";
			this.Text = "FormGeneral";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btStart;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btReset;
		private System.Windows.Forms.Button btSelStepFunc;
		private System.Windows.Forms.Button btSelectJob;
		private System.Windows.Forms.TextBox tbFunc;
		private System.Windows.Forms.TextBox tbStep;
		private System.Windows.Forms.TextBox tbJobNo;
		private System.Windows.Forms.TextBox tbPlayback;
		private System.Windows.Forms.TextBox tbMotor;
		private System.Windows.Forms.TextBox tbProgCnt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbMode;
		private System.Windows.Forms.Button btMotorOn;
		private System.Windows.Forms.Button btMotorOff;
	}
}