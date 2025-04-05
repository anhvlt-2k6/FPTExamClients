using System;

namespace QuestionLib
{
    // Token: 0x02000007 RID: 7
    [Serializable]
    public class ImagePaperAnswer
    {
        // Token: 0x1700001F RID: 31
        // (get) Token: 0x06000047 RID: 71 RVA: 0x000025BE File Offset: 0x000015BE
        // (set) Token: 0x06000048 RID: 72 RVA: 0x000025C6 File Offset: 0x000015C6
        public string Answer { get; set; }

        // Token: 0x17000020 RID: 32
        // (get) Token: 0x06000049 RID: 73 RVA: 0x000025CF File Offset: 0x000015CF
        // (set) Token: 0x0600004A RID: 74 RVA: 0x000025D7 File Offset: 0x000015D7
        public int PartCount { get; set; }

        // Token: 0x17000021 RID: 33
        // (get) Token: 0x0600004B RID: 75 RVA: 0x000025E0 File Offset: 0x000015E0
        // (set) Token: 0x0600004C RID: 76 RVA: 0x000025E8 File Offset: 0x000015E8
        public bool IsLongAnswer { get; set; }
    }
}
