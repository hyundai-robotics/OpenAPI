namespace OpenAPI_Cs_WinForm
{
	partial class FormIoRelay
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
			this.cbDataType = new System.Windows.Forms.ComboBox();
			this.cbObjType = new System.Windows.Forms.ComboBox();
			this.cbRelayType = new System.Windows.Forms.ComboBox();
			this.tbIndex = new System.Windows.Forms.TextBox();
			this.tbCurValue = new System.Windows.Forms.TextBox();
			this.tbObjIdx = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.lbObjType = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lbObjIdx = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbNewValue = new System.Windows.Forms.TextBox();
			this.btSet = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbDataType
			// 
			this.cbDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDataType.FormattingEnabled = true;
			this.cbDataType.Items.AddRange(new object[] {
            "Bit",
            "Char",
            "Short",
            "Long"});
			this.cbDataType.Location = new System.Drawing.Point(29, 118);
			this.cbDataType.Name = "cbDataType";
			this.cbDataType.Size = new System.Drawing.Size(61, 20);
			this.cbDataType.TabIndex = 18;
			// 
			// cbObjType
			// 
			this.cbObjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbObjType.FormattingEnabled = true;
			this.cbObjType.Items.AddRange(new object[] {
            "fb",
            "fn"});
			this.cbObjType.Location = new System.Drawing.Point(29, 60);
			this.cbObjType.Name = "cbObjType";
			this.cbObjType.Size = new System.Drawing.Size(61, 20);
			this.cbObjType.TabIndex = 19;
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
			this.cbRelayType.Location = new System.Drawing.Point(186, 60);
			this.cbRelayType.Name = "cbRelayType";
			this.cbRelayType.Size = new System.Drawing.Size(61, 20);
			this.cbRelayType.TabIndex = 20;
			this.cbRelayType.SelectedIndexChanged += new System.EventHandler(this.cbRelayType_SelectedIndexChanged);
			// 
			// tbIndex
			// 
			this.tbIndex.Location = new System.Drawing.Point(109, 118);
			this.tbIndex.Name = "tbIndex";
			this.tbIndex.Size = new System.Drawing.Size(61, 21);
			this.tbIndex.TabIndex = 15;
			this.tbIndex.Text = "0";
			this.tbIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbCurValue
			// 
			this.tbCurValue.Location = new System.Drawing.Point(186, 118);
			this.tbCurValue.Name = "tbCurValue";
			this.tbCurValue.Size = new System.Drawing.Size(61, 21);
			this.tbCurValue.TabIndex = 16;
			this.tbCurValue.Text = "0";
			this.tbCurValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbObjIdx
			// 
			this.tbObjIdx.Location = new System.Drawing.Point(109, 60);
			this.tbObjIdx.Name = "tbObjIdx";
			this.tbObjIdx.Size = new System.Drawing.Size(61, 21);
			this.tbObjIdx.TabIndex = 17;
			this.tbObjIdx.Text = "0";
			this.tbObjIdx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(29, 95);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(59, 12);
			this.label13.TabIndex = 9;
			this.label13.Text = "data_type";
			// 
			// lbObjType
			// 
			this.lbObjType.AutoSize = true;
			this.lbObjType.Location = new System.Drawing.Point(29, 37);
			this.lbObjType.Name = "lbObjType";
			this.lbObjType.Size = new System.Drawing.Size(52, 12);
			this.lbObjType.TabIndex = 10;
			this.lbObjType.Text = "obj_type";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(109, 95);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(36, 12);
			this.label14.TabIndex = 11;
			this.label14.Text = "index";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(186, 95);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(57, 12);
			this.label12.TabIndex = 12;
			this.label12.Text = "cur.value";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(186, 37);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(63, 12);
			this.label10.TabIndex = 13;
			this.label10.Text = "relay_type";
			// 
			// lbObjIdx
			// 
			this.lbObjIdx.AutoSize = true;
			this.lbObjIdx.Location = new System.Drawing.Point(109, 37);
			this.lbObjIdx.Name = "lbObjIdx";
			this.lbObjIdx.Size = new System.Drawing.Size(45, 12);
			this.lbObjIdx.TabIndex = 14;
			this.lbObjIdx.Text = "obj_idx";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(259, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 12);
			this.label1.TabIndex = 12;
			this.label1.Text = "new.value";
			// 
			// tbNewValue
			// 
			this.tbNewValue.Location = new System.Drawing.Point(261, 118);
			this.tbNewValue.Name = "tbNewValue";
			this.tbNewValue.Size = new System.Drawing.Size(61, 21);
			this.tbNewValue.TabIndex = 16;
			this.tbNewValue.Text = "0";
			this.tbNewValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btSet
			// 
			this.btSet.Location = new System.Drawing.Point(337, 118);
			this.btSet.Name = "btSet";
			this.btSet.Size = new System.Drawing.Size(60, 23);
			this.btSet.TabIndex = 21;
			this.btSet.Text = "set";
			this.btSet.UseVisualStyleBackColor = true;
			this.btSet.Click += new System.EventHandler(this.btSet_Click);
			// 
			// FormIoRelay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 204);
			this.Controls.Add(this.cbRelayType);
			this.Controls.Add(this.tbCurValue);
			this.Controls.Add(this.btSet);
			this.Controls.Add(this.cbDataType);
			this.Controls.Add(this.cbObjType);
			this.Controls.Add(this.tbIndex);
			this.Controls.Add(this.tbNewValue);
			this.Controls.Add(this.tbObjIdx);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.lbObjType);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.lbObjIdx);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormIoRelay";
			this.Text = "FormIoRelay";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbDataType;
		private System.Windows.Forms.ComboBox cbObjType;
		private System.Windows.Forms.ComboBox cbRelayType;
		private System.Windows.Forms.TextBox tbIndex;
		private System.Windows.Forms.TextBox tbCurValue;
		private System.Windows.Forms.TextBox tbObjIdx;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lbObjType;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lbObjIdx;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbNewValue;
		private System.Windows.Forms.Button btSet;
	}
}