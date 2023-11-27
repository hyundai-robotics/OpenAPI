namespace OpenAPI_Cs_WinForm
{
	partial class FormFileMng
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
			this.lvRemote = new System.Windows.Forms.ListView();
			this.hdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.hdSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.hdDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btUpdateRemote = new System.Windows.Forms.Button();
			this.tbPathRemote = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbFNameRemote = new System.Windows.Forms.TextBox();
			this.btGet = new System.Windows.Forms.Button();
			this.lvLocal = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tbPathLocal = new System.Windows.Forms.TextBox();
			this.tbFNameLocal = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.btPut = new System.Windows.Forms.Button();
			this.btDelRemote = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lvRemote
			// 
			this.lvRemote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdName,
            this.hdSize,
            this.hdDateTime});
			this.lvRemote.FullRowSelect = true;
			this.lvRemote.GridLines = true;
			this.lvRemote.Location = new System.Drawing.Point(12, 40);
			this.lvRemote.MultiSelect = false;
			this.lvRemote.Name = "lvRemote";
			this.lvRemote.Size = new System.Drawing.Size(335, 230);
			this.lvRemote.TabIndex = 0;
			this.lvRemote.UseCompatibleStateImageBehavior = false;
			this.lvRemote.View = System.Windows.Forms.View.Details;
			this.lvRemote.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvRemote_MouseClick);
			this.lvRemote.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvRemote_MouseDoubleClick);
			// 
			// hdName
			// 
			this.hdName.Text = "Name";
			this.hdName.Width = 120;
			// 
			// hdSize
			// 
			this.hdSize.Text = "Size";
			// 
			// hdDateTime
			// 
			this.hdDateTime.Text = "Modified Time";
			this.hdDateTime.Width = 120;
			// 
			// btUpdateRemote
			// 
			this.btUpdateRemote.Location = new System.Drawing.Point(71, 348);
			this.btUpdateRemote.Name = "btUpdateRemote";
			this.btUpdateRemote.Size = new System.Drawing.Size(115, 24);
			this.btUpdateRemote.TabIndex = 1;
			this.btUpdateRemote.Text = "Update Remote";
			this.btUpdateRemote.UseVisualStyleBackColor = true;
			this.btUpdateRemote.Click += new System.EventHandler(this.btUpdateRemote_Click);
			// 
			// tbPathRemote
			// 
			this.tbPathRemote.Location = new System.Drawing.Point(71, 286);
			this.tbPathRemote.Name = "tbPathRemote";
			this.tbPathRemote.Size = new System.Drawing.Size(276, 21);
			this.tbPathRemote.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 291);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "Path";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 324);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "FName";
			// 
			// tbFNameRemote
			// 
			this.tbFNameRemote.Location = new System.Drawing.Point(71, 318);
			this.tbFNameRemote.Name = "tbFNameRemote";
			this.tbFNameRemote.Size = new System.Drawing.Size(276, 21);
			this.tbFNameRemote.TabIndex = 2;
			// 
			// btGet
			// 
			this.btGet.Location = new System.Drawing.Point(353, 80);
			this.btGet.Name = "btGet";
			this.btGet.Size = new System.Drawing.Size(61, 62);
			this.btGet.TabIndex = 4;
			this.btGet.Text = "Get\r\n\r\n->";
			this.btGet.UseVisualStyleBackColor = true;
			this.btGet.Click += new System.EventHandler(this.btGet_Click);
			// 
			// lvLocal
			// 
			this.lvLocal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lvLocal.FullRowSelect = true;
			this.lvLocal.GridLines = true;
			this.lvLocal.Location = new System.Drawing.Point(420, 40);
			this.lvLocal.MultiSelect = false;
			this.lvLocal.Name = "lvLocal";
			this.lvLocal.Size = new System.Drawing.Size(335, 230);
			this.lvLocal.TabIndex = 0;
			this.lvLocal.UseCompatibleStateImageBehavior = false;
			this.lvLocal.View = System.Windows.Forms.View.Details;
			this.lvLocal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvLocal_MouseClick);
			this.lvLocal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvLocal_MouseDoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 120;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Size";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Modified Time";
			this.columnHeader3.Width = 120;
			// 
			// tbPathLocal
			// 
			this.tbPathLocal.Location = new System.Drawing.Point(479, 286);
			this.tbPathLocal.Name = "tbPathLocal";
			this.tbPathLocal.Size = new System.Drawing.Size(276, 21);
			this.tbPathLocal.TabIndex = 2;
			// 
			// tbFNameLocal
			// 
			this.tbFNameLocal.Location = new System.Drawing.Point(479, 318);
			this.tbFNameLocal.Name = "tbFNameLocal";
			this.tbFNameLocal.Size = new System.Drawing.Size(276, 21);
			this.tbFNameLocal.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(420, 291);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 12);
			this.label3.TabIndex = 3;
			this.label3.Text = "Path";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(420, 324);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "FName";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(152, 12);
			this.label5.TabIndex = 3;
			this.label5.Text = "Remote (Robot Controller)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(418, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 12);
			this.label6.TabIndex = 3;
			this.label6.Text = "Local (PC)";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(479, 348);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 24);
			this.button1.TabIndex = 1;
			this.button1.Text = "Update Local";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btUpdateLocal_Click);
			// 
			// btPut
			// 
			this.btPut.Location = new System.Drawing.Point(353, 161);
			this.btPut.Name = "btPut";
			this.btPut.Size = new System.Drawing.Size(61, 62);
			this.btPut.TabIndex = 5;
			this.btPut.Text = "Put\r\n\r\n<-";
			this.btPut.UseVisualStyleBackColor = true;
			this.btPut.Click += new System.EventHandler(this.btPut_Click);
			// 
			// btDelRemote
			// 
			this.btDelRemote.Location = new System.Drawing.Point(278, 348);
			this.btDelRemote.Name = "btDelRemote";
			this.btDelRemote.Size = new System.Drawing.Size(69, 24);
			this.btDelRemote.TabIndex = 1;
			this.btDelRemote.Text = "Delete";
			this.btDelRemote.UseVisualStyleBackColor = true;
			this.btDelRemote.Click += new System.EventHandler(this.btDelRemote_Click);
			// 
			// FormFileMng
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 389);
			this.Controls.Add(this.btPut);
			this.Controls.Add(this.btGet);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbFNameLocal);
			this.Controls.Add(this.tbFNameRemote);
			this.Controls.Add(this.tbPathLocal);
			this.Controls.Add(this.tbPathRemote);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btDelRemote);
			this.Controls.Add(this.btUpdateRemote);
			this.Controls.Add(this.lvLocal);
			this.Controls.Add(this.lvRemote);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormFileMng";
			this.Text = "FormFileMng";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvRemote;
		private System.Windows.Forms.ColumnHeader hdName;
		private System.Windows.Forms.ColumnHeader hdSize;
		private System.Windows.Forms.Button btUpdateRemote;
		private System.Windows.Forms.ColumnHeader hdDateTime;
		private System.Windows.Forms.TextBox tbPathRemote;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbFNameRemote;
		private System.Windows.Forms.Button btGet;
		private System.Windows.Forms.ListView lvLocal;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.TextBox tbPathLocal;
		private System.Windows.Forms.TextBox tbFNameLocal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btPut;
		private System.Windows.Forms.Button btDelRemote;
	}
}