using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace EOSClient
{
    // Token: 0x02000003 RID: 3
    public partial class frmAnnoucement : Form
    {
        // Token: 0x0600000C RID: 12 RVA: 0x000030F4 File Offset: 0x000012F4
        public frmAnnoucement()
        {
            this.InitializeComponent();
        }

        // Token: 0x0600000D RID: 13 RVA: 0x0000310C File Offset: 0x0000130C
        private void btnNext_Click(object sender, EventArgs e)
        {
            AuthenticateForm f = new AuthenticateForm();
            f.Show();
            base.Hide();
        }

        // Token: 0x0600000E RID: 14 RVA: 0x0000312E File Offset: 0x0000132E
        private void chbRead_CheckedChanged(object sender, EventArgs e)
        {
            this.btnNext.Enabled = this.chbRead.Checked;
        }

        // Token: 0x0600000F RID: 15 RVA: 0x00003148 File Offset: 0x00001348
        private bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principle = new WindowsPrincipal(identity);
            return principle.IsInRole(WindowsBuiltInRole.Administrator);
        }

        // Token: 0x06000010 RID: 16 RVA: 0x0000317C File Offset: 0x0000137C
        private void frmAnnoucement_Load(object sender, EventArgs e)
        {
            bool flag = !this.IsAdministrator();
            if (flag)
            {
                MessageBox.Show("You must login Windows as System Administrator or Run [EOS Client] as Administrator.", "Run as Administrator!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Application.Exit();
            }
        }

        // Token: 0x06000011 RID: 17 RVA: 0x000031B2 File Offset: 0x000013B2
        private void txtNoiQuy_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
