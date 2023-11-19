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
			this.tbMode = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbProgCnt = new System.Windows.Forms.TextBox();
			this.timerUpdate = new System.Windows.Forms.Timer(this.components);
			this.btSelectJob = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tbMotor = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbPlayback = new System.Windows.Forms.TextBox();
			this.tbJobNo = new System.Windows.Forms.TextBox();
			this.btSelStepFunc = new System.Windows.Forms.Button();
			this.tbStep = new System.Windows.Forms.TextBox();
			this.tbFunc = new System.Windows.Forms.TextBox();
			this.btReset = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btStart = new System.Windows.Forms.Button();
			this.tbIpAddrRemote = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.chkUpdateOn = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbCurPoseAxes = new System.Windows.Forms.TextBox();
			this.tbCurPoseBase = new System.Windows.Forms.TextBox();
			this.tbCurPoseUser = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cbUCrdNos = new System.Windows.Forms.ComboBox();
			this.lbObjIdx = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cbRelayType = new System.Windows.Forms.ComboBox();
			this.tbObjIdx = new System.Windows.Forms.TextBox();
			this.lbObjType = new System.Windows.Forms.Label();
			this.cbObjType = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tbCurValue = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.cbDataType = new System.Windows.Forms.ComboBox();
			this.tbIndex = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tbMode
			// 
			this.tbMode.Location = new System.Drawing.Point(30, 97);
			this.tbMode.Name = "tbMode";
			this.tbMode.ReadOnly = true;
			this.tbMode.Size = new System.Drawing.Size(108, 21);
			this.tbMode.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "Program Counter";
			// 
			// tbProgCnt
			// 
			this.tbProgCnt.Location = new System.Drawing.Point(30, 147);
			this.tbProgCnt.Name = "tbProgCnt";
			this.tbProgCnt.ReadOnly = true;
			this.tbProgCnt.Size = new System.Drawing.Size(108, 21);
			this.tbProgCnt.TabIndex = 3;
			// 
			// timerUpdate
			// 
			this.timerUpdate.Interval = 200;
			this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
			// 
			// btSelectJob
			// 
			this.btSelectJob.Location = new System.Drawing.Point(30, 183);
			this.btSelectJob.Name = "btSelectJob";
			this.btSelectJob.Size = new System.Drawing.Size(108, 21);
			this.btSelectJob.TabIndex = 4;
			this.btSelectJob.Text = "Select JOB";
			this.btSelectJob.UseVisualStyleBackColor = true;
			this.btSelectJob.Click += new System.EventHandler(this.btSelectJob_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(148, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "Motor";
			// 
			// tbMotor
			// 
			this.tbMotor.Location = new System.Drawing.Point(150, 97);
			this.tbMotor.Name = "tbMotor";
			this.tbMotor.ReadOnly = true;
			this.tbMotor.Size = new System.Drawing.Size(62, 21);
			this.tbMotor.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mode";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(148, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 12);
			this.label4.TabIndex = 2;
			this.label4.Text = "Playback";
			// 
			// tbPlayback
			// 
			this.tbPlayback.Location = new System.Drawing.Point(150, 147);
			this.tbPlayback.Name = "tbPlayback";
			this.tbPlayback.ReadOnly = true;
			this.tbPlayback.Size = new System.Drawing.Size(62, 21);
			this.tbPlayback.TabIndex = 3;
			// 
			// tbJobNo
			// 
			this.tbJobNo.Location = new System.Drawing.Point(150, 183);
			this.tbJobNo.Name = "tbJobNo";
			this.tbJobNo.Size = new System.Drawing.Size(62, 21);
			this.tbJobNo.TabIndex = 3;
			this.tbJobNo.Text = "1";
			this.tbJobNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btSelStepFunc
			// 
			this.btSelStepFunc.Location = new System.Drawing.Point(30, 221);
			this.btSelStepFunc.Name = "btSelStepFunc";
			this.btSelStepFunc.Size = new System.Drawing.Size(86, 21);
			this.btSelStepFunc.TabIndex = 4;
			this.btSelStepFunc.Text = "Select S/F";
			this.btSelStepFunc.UseVisualStyleBackColor = true;
			this.btSelStepFunc.Click += new System.EventHandler(this.btSelectStepFunc_Click);
			// 
			// tbStep
			// 
			this.tbStep.Location = new System.Drawing.Point(127, 221);
			this.tbStep.Name = "tbStep";
			this.tbStep.Size = new System.Drawing.Size(38, 21);
			this.tbStep.TabIndex = 3;
			this.tbStep.Text = "0";
			this.tbStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbFunc
			// 
			this.tbFunc.Location = new System.Drawing.Point(174, 221);
			this.tbFunc.Name = "tbFunc";
			this.tbFunc.Size = new System.Drawing.Size(38, 21);
			this.tbFunc.TabIndex = 3;
			this.tbFunc.Text = "0";
			this.tbFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btReset
			// 
			this.btReset.Location = new System.Drawing.Point(155, 259);
			this.btReset.Name = "btReset";
			this.btReset.Size = new System.Drawing.Size(57, 40);
			this.btReset.TabIndex = 5;
			this.btReset.Text = "RESET";
			this.btReset.UseVisualStyleBackColor = true;
			this.btReset.Click += new System.EventHandler(this.btReset_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(92, 259);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(57, 40);
			this.button1.TabIndex = 5;
			this.button1.Text = "STOP";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btStop_Click);
			// 
			// btStart
			// 
			this.btStart.Location = new System.Drawing.Point(30, 259);
			this.btStart.Name = "btStart";
			this.btStart.Size = new System.Drawing.Size(57, 40);
			this.btStart.TabIndex = 5;
			this.btStart.Text = "START";
			this.btStart.UseVisualStyleBackColor = true;
			this.btStart.Click += new System.EventHandler(this.btStart_Click);
			// 
			// tbIpAddrRemote
			// 
			this.tbIpAddrRemote.Location = new System.Drawing.Point(150, 34);
			this.tbIpAddrRemote.Name = "tbIpAddrRemote";
			this.tbIpAddrRemote.Size = new System.Drawing.Size(114, 21);
			this.tbIpAddrRemote.TabIndex = 6;
			this.tbIpAddrRemote.Text = "192.168.1.172";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(28, 37);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 12);
			this.label5.TabIndex = 2;
			this.label5.Text = "IP addr. (Remote)";
			// 
			// chkUpdateOn
			// 
			this.chkUpdateOn.Appearance = System.Windows.Forms.Appearance.Button;
			this.chkUpdateOn.AutoSize = true;
			this.chkUpdateOn.Location = new System.Drawing.Point(270, 34);
			this.chkUpdateOn.Name = "chkUpdateOn";
			this.chkUpdateOn.Size = new System.Drawing.Size(76, 22);
			this.chkUpdateOn.TabIndex = 7;
			this.chkUpdateOn.Text = "Update ON";
			this.chkUpdateOn.UseVisualStyleBackColor = true;
			this.chkUpdateOn.CheckedChanged += new System.EventHandler(this.chkUpdateOn_CheckedChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(436, 102);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 12);
			this.label6.TabIndex = 2;
			this.label6.Text = "AXES";
			// 
			// tbCurPoseAxes
			// 
			this.tbCurPoseAxes.Location = new System.Drawing.Point(498, 97);
			this.tbCurPoseAxes.Name = "tbCurPoseAxes";
			this.tbCurPoseAxes.ReadOnly = true;
			this.tbCurPoseAxes.Size = new System.Drawing.Size(281, 21);
			this.tbCurPoseAxes.TabIndex = 1;
			// 
			// tbCurPoseBase
			// 
			this.tbCurPoseBase.Location = new System.Drawing.Point(498, 128);
			this.tbCurPoseBase.Name = "tbCurPoseBase";
			this.tbCurPoseBase.ReadOnly = true;
			this.tbCurPoseBase.Size = new System.Drawing.Size(281, 21);
			this.tbCurPoseBase.TabIndex = 1;
			// 
			// tbCurPoseUser
			// 
			this.tbCurPoseUser.Location = new System.Drawing.Point(565, 158);
			this.tbCurPoseUser.Name = "tbCurPoseUser";
			this.tbCurPoseUser.ReadOnly = true;
			this.tbCurPoseUser.Size = new System.Drawing.Size(214, 21);
			this.tbCurPoseUser.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(436, 132);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 12);
			this.label7.TabIndex = 2;
			this.label7.Text = "BASE";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(436, 162);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 12);
			this.label8.TabIndex = 2;
			this.label8.Text = "USER";
			// 
			// cbUCrdNos
			// 
			this.cbUCrdNos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUCrdNos.FormattingEnabled = true;
			this.cbUCrdNos.Location = new System.Drawing.Point(498, 158);
			this.cbUCrdNos.Name = "cbUCrdNos";
			this.cbUCrdNos.Size = new System.Drawing.Size(61, 20);
			this.cbUCrdNos.Sorted = true;
			this.cbUCrdNos.TabIndex = 8;
			// 
			// lbObjIdx
			// 
			this.lbObjIdx.AutoSize = true;
			this.lbObjIdx.Location = new System.Drawing.Point(108, 358);
			this.lbObjIdx.Name = "lbObjIdx";
			this.lbObjIdx.Size = new System.Drawing.Size(45, 12);
			this.lbObjIdx.TabIndex = 2;
			this.lbObjIdx.Text = "obj_idx";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(171, 357);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(63, 12);
			this.label10.TabIndex = 2;
			this.label10.Text = "relay_type";
			// 
			// cbRelayType
			// 
			this.cbRelayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRelayType.FormattingEnabled = true;
			this.cbRelayType.Items.AddRange(new object[] {
            "di",
            "do",
            "x",
            "y",
            "m",
            "s",
            "r",
            "k"});
			this.cbRelayType.Location = new System.Drawing.Point(174, 381);
			this.cbRelayType.Name = "cbRelayType";
			this.cbRelayType.Size = new System.Drawing.Size(61, 20);
			this.cbRelayType.TabIndex = 8;
			this.cbRelayType.SelectedIndexChanged += new System.EventHandler(this.cbRelayType_SelectedIndexChanged);
			// 
			// tbObjIdx
			// 
			this.tbObjIdx.Location = new System.Drawing.Point(110, 381);
			this.tbObjIdx.Name = "tbObjIdx";
			this.tbObjIdx.Size = new System.Drawing.Size(38, 21);
			this.tbObjIdx.TabIndex = 3;
			this.tbObjIdx.Text = "0";
			this.tbObjIdx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbObjType
			// 
			this.lbObjType.AutoSize = true;
			this.lbObjType.Location = new System.Drawing.Point(35, 358);
			this.lbObjType.Name = "lbObjType";
			this.lbObjType.Size = new System.Drawing.Size(52, 12);
			this.lbObjType.TabIndex = 2;
			this.lbObjType.Text = "obj_type";
			// 
			// cbObjType
			// 
			this.cbObjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbObjType.FormattingEnabled = true;
			this.cbObjType.Items.AddRange(new object[] {
            "fb",
            "fn"});
			this.cbObjType.Location = new System.Drawing.Point(32, 381);
			this.cbObjType.Name = "cbObjType";
			this.cbObjType.Size = new System.Drawing.Size(61, 20);
			this.cbObjType.TabIndex = 8;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(178, 416);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(57, 12);
			this.label12.TabIndex = 2;
			this.label12.Text = "cur.value";
			// 
			// tbCurValue
			// 
			this.tbCurValue.Location = new System.Drawing.Point(181, 439);
			this.tbCurValue.Name = "tbCurValue";
			this.tbCurValue.Size = new System.Drawing.Size(55, 21);
			this.tbCurValue.TabIndex = 3;
			this.tbCurValue.Text = "0";
			this.tbCurValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(33, 416);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(59, 12);
			this.label13.TabIndex = 2;
			this.label13.Text = "data_type";
			// 
			// cbDataType
			// 
			this.cbDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDataType.FormattingEnabled = true;
			this.cbDataType.Items.AddRange(new object[] {
            "Bit",
            "Char",
            "Long",
            "Short"});
			this.cbDataType.Location = new System.Drawing.Point(30, 439);
			this.cbDataType.Name = "cbDataType";
			this.cbDataType.Size = new System.Drawing.Size(61, 20);
			this.cbDataType.TabIndex = 8;
			// 
			// tbIndex
			// 
			this.tbIndex.Location = new System.Drawing.Point(110, 438);
			this.tbIndex.Name = "tbIndex";
			this.tbIndex.Size = new System.Drawing.Size(55, 21);
			this.tbIndex.TabIndex = 3;
			this.tbIndex.Text = "0";
			this.tbIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(108, 416);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(36, 12);
			this.label14.TabIndex = 2;
			this.label14.Text = "index";
			// 
			// FormBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 543);
			this.Controls.Add(this.cbDataType);
			this.Controls.Add(this.cbObjType);
			this.Controls.Add(this.cbRelayType);
			this.Controls.Add(this.cbUCrdNos);
			this.Controls.Add(this.chkUpdateOn);
			this.Controls.Add(this.tbIpAddrRemote);
			this.Controls.Add(this.btStart);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btReset);
			this.Controls.Add(this.btSelStepFunc);
			this.Controls.Add(this.btSelectJob);
			this.Controls.Add(this.tbFunc);
			this.Controls.Add(this.tbIndex);
			this.Controls.Add(this.tbCurValue);
			this.Controls.Add(this.tbObjIdx);
			this.Controls.Add(this.tbStep);
			this.Controls.Add(this.tbJobNo);
			this.Controls.Add(this.tbPlayback);
			this.Controls.Add(this.tbMotor);
			this.Controls.Add(this.tbProgCnt);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lbObjType);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.lbObjIdx);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbCurPoseUser);
			this.Controls.Add(this.tbCurPoseBase);
			this.Controls.Add(this.tbCurPoseAxes);
			this.Controls.Add(this.tbMode);
			this.Name = "FormBase";
			this.Text = "Base";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbMode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbProgCnt;
		private System.Windows.Forms.Timer timerUpdate;
		private System.Windows.Forms.Button btSelectJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMotor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbPlayback;
		private System.Windows.Forms.TextBox tbJobNo;
		private System.Windows.Forms.Button btSelStepFunc;
		private System.Windows.Forms.TextBox tbStep;
		private System.Windows.Forms.TextBox tbFunc;
		private System.Windows.Forms.Button btReset;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btStart;
		private System.Windows.Forms.TextBox tbIpAddrRemote;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chkUpdateOn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbCurPoseAxes;
		private System.Windows.Forms.TextBox tbCurPoseBase;
		private System.Windows.Forms.TextBox tbCurPoseUser;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbUCrdNos;
		private System.Windows.Forms.Label lbObjIdx;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cbRelayType;
		private System.Windows.Forms.TextBox tbObjIdx;
		private System.Windows.Forms.Label lbObjType;
		private System.Windows.Forms.ComboBox cbObjType;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox tbCurValue;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cbDataType;
		private System.Windows.Forms.TextBox tbIndex;
		private System.Windows.Forms.Label label14;
	}
}

