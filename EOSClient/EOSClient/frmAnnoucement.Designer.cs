namespace EOSClient
{
	// Token: 0x02000003 RID: 3
	public partial class frmAnnoucement : global::System.Windows.Forms.Form
	{
		// Token: 0x06000012 RID: 18 RVA: 0x000031B8 File Offset: 0x000013B8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000031F0 File Offset: 0x000013F0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::EOSClient.frmAnnoucement));
			this.txtNoiQuy = new global::System.Windows.Forms.TextBox();
			this.chbRead = new global::System.Windows.Forms.CheckBox();
			this.btnNext = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.txtNoiQuy.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtNoiQuy.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.txtNoiQuy.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtNoiQuy.Location = new global::System.Drawing.Point(12, 12);
			this.txtNoiQuy.Multiline = true;
			this.txtNoiQuy.Name = "txtNoiQuy";
			this.txtNoiQuy.ReadOnly = true;
			this.txtNoiQuy.Size = new global::System.Drawing.Size(1006, 389);
			this.txtNoiQuy.TabIndex = 2;
			this.txtNoiQuy.Text = resources.GetString("txtNoiQuy.Text");
			this.txtNoiQuy.TextChanged += new global::System.EventHandler(this.txtNoiQuy_TextChanged);
			this.chbRead.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.chbRead.AutoSize = true;
			this.chbRead.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chbRead.ForeColor = global::System.Drawing.Color.Blue;
			this.chbRead.Location = new global::System.Drawing.Point(688, 409);
			this.chbRead.Name = "chbRead";
			this.chbRead.Size = new global::System.Drawing.Size(249, 19);
			this.chbRead.TabIndex = 1;
			this.chbRead.Text = "Tôi đã đọc và hiểu rõ Nội quy kỳ thi";
			this.chbRead.UseVisualStyleBackColor = true;
			this.chbRead.CheckedChanged += new global::System.EventHandler(this.chbRead_CheckedChanged);
			this.btnNext.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnNext.Enabled = false;
			this.btnNext.Location = new global::System.Drawing.Point(943, 407);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new global::System.Drawing.Size(75, 23);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new global::System.EventHandler(this.btnNext_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1028, 438);
			base.Controls.Add(this.btnNext);
			base.Controls.Add(this.chbRead);
			base.Controls.Add(this.txtNoiQuy);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.MaximizeBox = false;
			base.Name = "frmAnnoucement";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nội quy kỳ thi";
			base.Load += new global::System.EventHandler(this.frmAnnoucement_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000014 RID: 20
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.TextBox txtNoiQuy;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.CheckBox chbRead;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button btnNext;
	}
}
