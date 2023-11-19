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
			this.timerUpdate = new System.Windows.Forms.Timer(this.components);
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
			this.tabCtrl = new System.Windows.Forms.TabControl();
			this.pageIoRelay = new System.Windows.Forms.TabPage();
			this.pageGeneral = new System.Windows.Forms.TabPage();
			this.tabCtrl.SuspendLayout();
			this.SuspendLayout();
			// 
			// timerUpdate
			// 
			this.timerUpdate.Interval = 200;
			this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
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
			// tabCtrl
			// 
			this.tabCtrl.Controls.Add(this.pageGeneral);
			this.tabCtrl.Controls.Add(this.pageIoRelay);
			this.tabCtrl.Location = new System.Drawing.Point(58, 212);
			this.tabCtrl.Name = "tabCtrl";
			this.tabCtrl.SelectedIndex = 0;
			this.tabCtrl.Size = new System.Drawing.Size(501, 278);
			this.tabCtrl.TabIndex = 9;
			// 
			// pageGeneral
			// 
			this.pageGeneral.Location = new System.Drawing.Point(4, 22);
			this.pageGeneral.Name = "pageGeneral";
			this.pageGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.pageGeneral.Size = new System.Drawing.Size(493, 252);
			this.pageGeneral.TabIndex = 0;
			this.pageGeneral.Text = "General";
			this.pageGeneral.UseVisualStyleBackColor = true;
			// 
			// pageIoRelay
			// 
			this.pageIoRelay.Location = new System.Drawing.Point(4, 22);
			this.pageIoRelay.Name = "pageIoRelay";
			this.pageIoRelay.Padding = new System.Windows.Forms.Padding(3);
			this.pageIoRelay.Size = new System.Drawing.Size(333, 172);
			this.pageIoRelay.TabIndex = 1;
			this.pageIoRelay.Text = "IoRelay";
			this.pageIoRelay.UseVisualStyleBackColor = true;
			// 
			// FormBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 543);
			this.Controls.Add(this.tabCtrl);
			this.Controls.Add(this.cbUCrdNos);
			this.Controls.Add(this.chkUpdateOn);
			this.Controls.Add(this.tbIpAddrRemote);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbCurPoseUser);
			this.Controls.Add(this.tbCurPoseBase);
			this.Controls.Add(this.tbCurPoseAxes);
			this.Name = "FormBase";
			this.Text = "Base";
			this.tabCtrl.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timerUpdate;
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
		private System.Windows.Forms.TabControl tabCtrl;
		private System.Windows.Forms.TabPage pageIoRelay;
		private System.Windows.Forms.TabPage pageGeneral;
	}
}

