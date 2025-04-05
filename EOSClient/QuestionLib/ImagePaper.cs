using System;
using System.Collections.Generic;

namespace QuestionLib
{
    // Token: 0x0200000A RID: 10
    [Serializable]
    public class ImagePaper
    {
        // Token: 0x1700002A RID: 42
        // (get) Token: 0x06000064 RID: 100 RVA: 0x00002700 File Offset: 0x00001700
        // (set) Token: 0x06000065 RID: 101 RVA: 0x00002708 File Offset: 0x00001708
        public List<PaperSection> Sections { get; set; }

        // Token: 0x1700002B RID: 43
        // (get) Token: 0x06000066 RID: 102 RVA: 0x00002711 File Offset: 0x00001711
        // (set) Token: 0x06000067 RID: 103 RVA: 0x00002719 File Offset: 0x00001719
        public byte[] Image { get; set; }

        // Token: 0x1700002C RID: 44
        // (get) Token: 0x06000068 RID: 104 RVA: 0x00002722 File Offset: 0x00001722
        // (set) Token: 0x06000069 RID: 105 RVA: 0x0000272A File Offset: 0x0000172A
        public int NumberOfPage { get; set; }

        // Token: 0x1700002D RID: 45
        // (get) Token: 0x0600006A RID: 106 RVA: 0x00002733 File Offset: 0x00001733
        // (set) Token: 0x0600006B RID: 107 RVA: 0x0000273B File Offset: 0x0000173B
        public string LongAnswerGuide { get; set; }

        // Token: 0x0600006C RID: 108 RVA: 0x00002744 File Offset: 0x00001744
        public void Preapare2Submit()
        {
            this.Image = null;
        }
    }
}
