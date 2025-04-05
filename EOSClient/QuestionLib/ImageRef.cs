using System;

namespace QuestionLib
{
    // Token: 0x02000009 RID: 9
    [Serializable]
    public class ImageRef
    {
        // Token: 0x17000027 RID: 39
        // (get) Token: 0x0600005A RID: 90 RVA: 0x0000267F File Offset: 0x0000167F
        // (set) Token: 0x0600005B RID: 91 RVA: 0x00002687 File Offset: 0x00001687
        public byte[] ImgData { get; set; }

        // Token: 0x0600005C RID: 92 RVA: 0x00002690 File Offset: 0x00001690
        public byte[] Get_ImgData()
        {
            return this.ImgData;
        }

        // Token: 0x17000028 RID: 40
        // (get) Token: 0x0600005D RID: 93 RVA: 0x000026A8 File Offset: 0x000016A8
        // (set) Token: 0x0600005E RID: 94 RVA: 0x000026B0 File Offset: 0x000016B0
        public int ImgSize { get; set; }

        // Token: 0x0600005F RID: 95 RVA: 0x000026BC File Offset: 0x000016BC
        public int Get_ImgSize()
        {
            return this.ImgSize;
        }

        // Token: 0x17000029 RID: 41
        // (get) Token: 0x06000060 RID: 96 RVA: 0x000026D4 File Offset: 0x000016D4
        // (set) Token: 0x06000061 RID: 97 RVA: 0x000026DC File Offset: 0x000016DC
        public int NumberOfPage { get; set; }

        // Token: 0x06000062 RID: 98 RVA: 0x000026E8 File Offset: 0x000016E8
        public int Get_NumberOfPage()
        {
            return this.NumberOfPage;
        }
    }
}
