using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace EOSClient
{
    // Token: 0x02000004 RID: 4
    public partial class frmCheckFont : Form
    {
        // Token: 0x06000014 RID: 20 RVA: 0x00003545 File Offset: 0x00001745
        public frmCheckFont()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000015 RID: 21 RVA: 0x00003560 File Offset: 0x00001760
        private bool checkFont(string fontName)
        {
            bool result;
            using (Font f = new Font(fontName, 12f, FontStyle.Regular))
            {
                bool flag = f.Name.Equals(fontName);
                if (flag)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        // Token: 0x06000016 RID: 22 RVA: 0x000035B0 File Offset: 0x000017B0
        private void frmCheckFont_Load(object sender, EventArgs e)
        {
            bool isKaiTiExists = false;
            bool isMinchoExists = false;
            bool isHGSeiExists = false;
            bool isNtMotoyaExists = false;
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = installedFontCollection.Families;
            foreach (FontFamily ff in fontFamilies)
            {
                string fname = ff.GetName(0).Trim().ToUpper();
                bool flag = fname.StartsWith("KaiTi".ToUpper());
                if (flag)
                {
                    isKaiTiExists = true;
                }
                bool flag2 = fname.StartsWith("Ms Mincho".ToUpper());
                if (flag2)
                {
                    isMinchoExists = true;
                }
                bool flag3 = fname.StartsWith("HGSeikai".ToUpper());
                if (flag3)
                {
                    isHGSeiExists = true;
                }
                bool flag4 = fname.StartsWith("NtMotoya".ToUpper());
                if (flag4)
                {
                    isNtMotoyaExists = true;
                }
            }
            string str = "CHECK FONT RESULT:\r\n\r\n";
            string cn_font = "KaiTi";
            bool flag5 = isKaiTiExists;
            if (flag5)
            {
                str = str + "Chinese font ('" + cn_font + "') : OK.\r\n\r\n";
            }
            else
            {
                str = str + "Chinese font ('" + cn_font + "') : NOT FOUND.\r\n\r\n";
            }
            string jp_font = "MS Mincho";
            bool flag6 = isMinchoExists;
            if (flag6)
            {
                str = str + "Japanese font 1 ('" + jp_font + "') : OK.\r\n\r\n";
            }
            else
            {
                str = str + "Japanese font 1 ('" + jp_font + "') :  NOT FOUND.\r\n\r\n";
            }
            jp_font = "HGSeikaishotaiPRO";
            bool flag7 = isHGSeiExists;
            if (flag7)
            {
                str = str + "Japanese font 2 ('" + jp_font + "') : OK.\r\n\r\n";
            }
            else
            {
                str = str + "Japanese font 2 ('" + jp_font + "') :  NOT FOUND.\r\n\r\n";
            }
            jp_font = "NtMotoya Kyotai";
            bool flag8 = isNtMotoyaExists;
            if (flag8)
            {
                str = str + "Japanese font 3 ('" + jp_font + "') : OK.\r\n\r\n";
            }
            else
            {
                str = str + "Japanese font 3 ('" + jp_font + "') :  NOT FOUND.\r\n\r\n";
            }
            bool flag9 = !isMinchoExists || !isKaiTiExists || !isHGSeiExists || !isNtMotoyaExists;
            if (flag9)
            {
                str += "\r\n\r\nINSTALLING FONTS ON Windows:\r\n\r\nThere are several ways to install fonts on Windows.\r\nKeep in mind that you must be an Administrator on the target machine to install fonts.\r\n\r\n - Download the font.\r\n - Double-click on a font file to open the font preview and select 'Install'.\r\n\r\nOR\r\n\r\n - Right-click on a font file, and then select 'Install'.";
            }
            this.txtFontGuide.Text = str;
        }

        // Token: 0x06000017 RID: 23 RVA: 0x00003796 File Offset: 0x00001996
        private void btnClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}
