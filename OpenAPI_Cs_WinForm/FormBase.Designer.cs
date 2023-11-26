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
			this.tabCtrl = new System.Windows.Forms.TabControl();
			this.pageGeneral = new System.Windows.Forms.TabPage();
			this.pagePoCur = new System.Windows.Forms.TabPage();
			this.pageIoRelay = new System.Windows.Forms.TabPage();
			this.pageFileMng = new System.Windows.Forms.TabPage();
			this.panelLog = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
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
			// tabCtrl
			// 
			this.tabCtrl.Controls.Add(this.pageGeneral);
			this.tabCtrl.Controls.Add(this.pagePoCur);
			this.tabCtrl.Controls.Add(this.pageIoRelay);
			this.tabCtrl.Controls.Add(this.pageFileMng);
			this.tabCtrl.Location = new System.Drawing.Point(30, 76);
			this.tabCtrl.Name = "tabCtrl";
			this.tabCtrl.SelectedIndex = 0;
			this.tabCtrl.Size = new System.Drawing.Size(725, 367);
			this.tabCtrl.TabIndex = 9;
			// 
			// pageGeneral
			// 
			this.pageGeneral.Location = new System.Drawing.Point(4, 22);
			this.pageGeneral.Name = "pageGeneral";
			this.pageGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.pageGeneral.Size = new System.Drawing.Size(717, 341);
			this.pageGeneral.TabIndex = 0;
			this.pageGeneral.Text = "General";
			this.pageGeneral.UseVisualStyleBackColor = true;
			// 
			// pagePoCur
			// 
			this.pagePoCur.Location = new System.Drawing.Point(4, 22);
			this.pagePoCur.Name = "pagePoCur";
			this.pagePoCur.Size = new System.Drawing.Size(493, 252);
			this.pagePoCur.TabIndex = 2;
			this.pagePoCur.Text = "PoCur";
			this.pagePoCur.UseVisualStyleBackColor = true;
			// 
			// pageIoRelay
			// 
			this.pageIoRelay.Location = new System.Drawing.Point(4, 22);
			this.pageIoRelay.Name = "pageIoRelay";
			this.pageIoRelay.Padding = new System.Windows.Forms.Padding(3);
			this.pageIoRelay.Size = new System.Drawing.Size(493, 252);
			this.pageIoRelay.TabIndex = 1;
			this.pageIoRelay.Text = "IoRelay";
			this.pageIoRelay.UseVisualStyleBackColor = true;
			// 
			// pageFileMng
			// 
			this.pageFileMng.Location = new System.Drawing.Point(4, 22);
			this.pageFileMng.Name = "pageFileMng";
			this.pageFileMng.Size = new System.Drawing.Size(493, 252);
			this.pageFileMng.TabIndex = 3;
			this.pageFileMng.Text = "FileMng";
			this.pageFileMng.UseVisualStyleBackColor = true;
			// 
			// panelLog
			// 
			this.panelLog.Location = new System.Drawing.Point(34, 487);
			this.panelLog.Name = "panelLog";
			this.panelLog.Size = new System.Drawing.Size(717, 128);
			this.panelLog.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 465);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "Events log";
			// 
			// FormBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 641);
			this.Controls.Add(this.panelLog);
			this.Controls.Add(this.tabCtrl);
			this.Controls.Add(this.chkUpdateOn);
			this.Controls.Add(this.tbIpAddrRemote);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
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
		private System.Windows.Forms.TabControl tabCtrl;
		private System.Windows.Forms.TabPage pageIoRelay;
		private System.Windows.Forms.TabPage pageGeneral;
		private System.Windows.Forms.TabPage pagePoCur;
		private System.Windows.Forms.Panel panelLog;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage pageFileMng;
	}
}

