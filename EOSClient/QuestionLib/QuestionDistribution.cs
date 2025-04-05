using System;

namespace QuestionLib
{
    // Token: 0x02000004 RID: 4
    [Serializable]
    public class QuestionDistribution
    {
        // Token: 0x17000001 RID: 1
        // (get) Token: 0x06000009 RID: 9 RVA: 0x000021A5 File Offset: 0x000011A5
        // (set) Token: 0x0600000A RID: 10 RVA: 0x000021AD File Offset: 0x000011AD
        public int MultipleChoices { get; set; }

        // Token: 0x17000002 RID: 2
        // (get) Token: 0x0600000B RID: 11 RVA: 0x000021B6 File Offset: 0x000011B6
        // (set) Token: 0x0600000C RID: 12 RVA: 0x000021BE File Offset: 0x000011BE
        public int Reading { get; set; }

        // Token: 0x17000003 RID: 3
        // (get) Token: 0x0600000D RID: 13 RVA: 0x000021C7 File Offset: 0x000011C7
        // (set) Token: 0x0600000E RID: 14 RVA: 0x000021CF File Offset: 0x000011CF
        public int FillBlank { get; set; }

        // Token: 0x17000004 RID: 4
        // (get) Token: 0x0600000F RID: 15 RVA: 0x000021D8 File Offset: 0x000011D8
        // (set) Token: 0x06000010 RID: 16 RVA: 0x000021E0 File Offset: 0x000011E0
        public int Matching { get; set; }

        // Token: 0x17000005 RID: 5
        // (get) Token: 0x06000011 RID: 17 RVA: 0x000021E9 File Offset: 0x000011E9
        // (set) Token: 0x06000012 RID: 18 RVA: 0x000021F1 File Offset: 0x000011F1
        public int IndicateMistake { get; set; }
    }
}
