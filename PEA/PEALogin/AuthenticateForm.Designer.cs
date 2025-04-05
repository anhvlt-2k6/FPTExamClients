namespace PEALogin
{
	// Token: 0x02000002 RID: 2
	public partial class AuthenticateForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002084 File Offset: 0x00000284
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				bool flag = this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020BC File Offset: 0x000002BC
		private void InitializeComponent()
		{
			this.btnLogin = new global::System.Windows.Forms.Button();
			this.txtUser = new global::System.Windows.Forms.TextBox();
			this.txtPassword = new global::System.Windows.Forms.TextBox();
			this.txtDomain = new global::System.Windows.Forms.TextBox();
			this.lblUser = new global::System.Windows.Forms.Label();
			this.lblPass = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.lblDomain = new global::System.Windows.Forms.Label();
			this.lblExamCode = new global::System.Windows.Forms.Label();
			this.txtTestName = new global::System.Windows.Forms.TextBox();
			this.lblMessage = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.btnLogin.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.btnLogin.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnLogin.Location = new global::System.Drawing.Point(96, 157);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new global::System.Drawing.Size(86, 30);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Login";
			this.btnLogin.Click += new global::System.EventHandler(this.btnLogin_Click);
			this.txtUser.Location = new global::System.Drawing.Point(96, 54);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new global::System.Drawing.Size(180, 20);
			this.txtUser.TabIndex = 1;
			this.txtPassword.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtPassword.Location = new global::System.Drawing.Point(96, 89);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new global::System.Drawing.Size(180, 22);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.Tag = "";
			this.txtDomain.Enabled = false;
			this.txtDomain.Location = new global::System.Drawing.Point(96, 126);
			this.txtDomain.Name = "txtDomain";
			this.txtDomain.Size = new global::System.Drawing.Size(180, 20);
			this.txtDomain.TabIndex = 9;
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblUser.Location = new global::System.Drawing.Point(16, 55);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new global::System.Drawing.Size(77, 16);
			this.lblUser.TabIndex = 6;
			this.lblUser.Text = "User name:";
			this.lblPass.AutoSize = true;
			this.lblPass.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblPass.Location = new global::System.Drawing.Point(22, 92);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new global::System.Drawing.Size(71, 16);
			this.lblPass.TabIndex = 7;
			this.lblPass.Text = "Password:";
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.Location = new global::System.Drawing.Point(282, 157);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(86, 30);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Exit";
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.lblDomain.AutoSize = true;
			this.lblDomain.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblDomain.Location = new global::System.Drawing.Point(35, 127);
			this.lblDomain.Name = "lblDomain";
			this.lblDomain.Size = new global::System.Drawing.Size(58, 16);
			this.lblDomain.TabIndex = 5;
			this.lblDomain.Text = "Domain:";
			this.lblExamCode.AutoSize = true;
			this.lblExamCode.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblExamCode.Location = new global::System.Drawing.Point(18, 20);
			this.lblExamCode.Name = "lblExamCode";
			this.lblExamCode.Size = new global::System.Drawing.Size(75, 16);
			this.lblExamCode.TabIndex = 10;
			this.lblExamCode.Text = "Test name:";
			this.txtTestName.Location = new global::System.Drawing.Point(96, 19);
			this.txtTestName.Name = "txtTestName";
			this.txtTestName.Size = new global::System.Drawing.Size(272, 20);
			this.txtTestName.TabIndex = 0;
			this.lblMessage.AutoSize = true;
			this.lblMessage.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblMessage.ForeColor = global::System.Drawing.Color.Red;
			this.lblMessage.Location = new global::System.Drawing.Point(9, 191);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new global::System.Drawing.Size(391, 16);
			this.lblMessage.TabIndex = 11;
			this.lblMessage.Text = "Register the exam may take some minutes! Please wait!";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(9, 215);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(157, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "Ver 2.1 (build 11.12.20.20)";
			base.AcceptButton = this.btnLogin;
			this.AutoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			base.ClientSize = new global::System.Drawing.Size(409, 240);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.lblMessage);
			base.Controls.Add(this.lblExamCode);
			base.Controls.Add(this.txtTestName);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.lblPass);
			base.Controls.Add(this.lblUser);
			base.Controls.Add(this.txtDomain);
			base.Controls.Add(this.txtPassword);
			base.Controls.Add(this.txtUser);
			base.Controls.Add(this.lblDomain);
			base.Controls.Add(this.btnLogin);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AuthenticateForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PEA Login";
			base.Load += new global::System.EventHandler(this.AuthenticateForm_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.Windows.Forms.Button btnLogin;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.TextBox txtUser;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.TextBox txtPassword;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.TextBox txtDomain;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label lblUser;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label lblPass;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label lblDomain;

		// Token: 0x04000009 RID: 9
		private global::System.ComponentModel.Container components = null;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label lblExamCode;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Label lblMessage;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.TextBox txtTestName;
	}
}
