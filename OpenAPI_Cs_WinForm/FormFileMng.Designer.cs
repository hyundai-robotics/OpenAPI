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
			this.btUpdateRemote = new System.Windows.Forms.Button();
			this.hdDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// lvRemote
			// 
			this.lvRemote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdName,
            this.hdSize,
            this.hdDateTime});
			this.lvRemote.GridLines = true;
			this.lvRemote.Location = new System.Drawing.Point(12, 12);
			this.lvRemote.Name = "lvRemote";
			this.lvRemote.Size = new System.Drawing.Size(335, 230);
			this.lvRemote.TabIndex = 0;
			this.lvRemote.UseCompatibleStateImageBehavior = false;
			this.lvRemote.View = System.Windows.Forms.View.Details;
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
			// btUpdateRemote
			// 
			this.btUpdateRemote.Location = new System.Drawing.Point(12, 248);
			this.btUpdateRemote.Name = "btUpdateRemote";
			this.btUpdateRemote.Size = new System.Drawing.Size(73, 56);
			this.btUpdateRemote.TabIndex = 1;
			this.btUpdateRemote.Text = "Update Remote";
			this.btUpdateRemote.UseVisualStyleBackColor = true;
			this.btUpdateRemote.Click += new System.EventHandler(this.btUpdateRemote_Click);
			// 
			// hdDateTime
			// 
			this.hdDateTime.Text = "Modified Time";
			this.hdDateTime.Width = 120;
			// 
			// FormFileMng
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 337);
			this.Controls.Add(this.btUpdateRemote);
			this.Controls.Add(this.lvRemote);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormFileMng";
			this.Text = "FormFileMng";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvRemote;
		private System.Windows.Forms.ColumnHeader hdName;
		private System.Windows.Forms.ColumnHeader hdSize;
		private System.Windows.Forms.Button btUpdateRemote;
		private System.Windows.Forms.ColumnHeader hdDateTime;
	}
}