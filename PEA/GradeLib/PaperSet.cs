using System;
using System.Collections.Generic;

namespace GradeLib
{
    // Token: 0x02000006 RID: 6
    [Serializable]
    public class PaperSet
    {
        // Token: 0x17000008 RID: 8
        // (get) Token: 0x06000016 RID: 22 RVA: 0x00002202 File Offset: 0x00000402
        // (set) Token: 0x06000017 RID: 23 RVA: 0x0000220A File Offset: 0x0000040A
        public string TestName { get; set; }

        // Token: 0x17000009 RID: 9
        // (get) Token: 0x06000018 RID: 24 RVA: 0x00002213 File Offset: 0x00000413
        // (set) Token: 0x06000019 RID: 25 RVA: 0x0000221B File Offset: 0x0000041B
        public string Language { get; set; }

        // Token: 0x1700000A RID: 10
        // (get) Token: 0x0600001A RID: 26 RVA: 0x00002224 File Offset: 0x00000424
        // (set) Token: 0x0600001B RID: 27 RVA: 0x0000222C File Offset: 0x0000042C
        public List<TopicQuestion> listTopicQuestion { get; set; }

        // Token: 0x1700000B RID: 11
        // (get) Token: 0x0600001C RID: 28 RVA: 0x00002235 File Offset: 0x00000435
        // (set) Token: 0x0600001D RID: 29 RVA: 0x0000223D File Offset: 0x0000043D
        public List<Paper> listPaper { get; set; }

        // Token: 0x1700000C RID: 12
        // (get) Token: 0x0600001E RID: 30 RVA: 0x00002246 File Offset: 0x00000446
        // (set) Token: 0x0600001F RID: 31 RVA: 0x0000224E File Offset: 0x0000044E
        public List<PaperJPG> listPaperImage { get; set; }

        // Token: 0x06000020 RID: 32 RVA: 0x00002257 File Offset: 0x00000457
        public PaperSet()
        {
            this.listTopicQuestion = new List<TopicQuestion>();
            this.listPaper = new List<Paper>();
            this.listPaperImage = new List<PaperJPG>();
        }

        // Token: 0x0400000D RID: 13
        public bool LockClient;

        // Token: 0x0400000E RID: 14
        public int TimeAllow = 0;
    }
}
