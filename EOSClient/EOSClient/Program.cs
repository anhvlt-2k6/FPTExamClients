using System;
using System.Windows.Forms;

namespace EOSClient
{
    // Token: 0x02000005 RID: 5
    internal static class Program
    {
        // Token: 0x0600001A RID: 26 RVA: 0x00003A8D File Offset: 0x00001C8D
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAnnoucement());
        }
    }
}
