using System;
using System.Collections.Generic;

namespace QuestionLib
{
    // Token: 0x02000008 RID: 8
    [Serializable]
    public class PaperSection
    {
        // Token: 0x17000022 RID: 34
        // (get) Token: 0x0600004E RID: 78 RVA: 0x000025F1 File Offset: 0x000015F1
        // (set) Token: 0x0600004F RID: 79 RVA: 0x000025F9 File Offset: 0x000015F9
        public int SectionNo { get; set; }

        // Token: 0x17000023 RID: 35
        // (get) Token: 0x06000050 RID: 80 RVA: 0x00002602 File Offset: 0x00001602
        // (set) Token: 0x06000051 RID: 81 RVA: 0x0000260A File Offset: 0x0000160A
        public int QFrom { get; set; }

        // Token: 0x17000024 RID: 36
        // (get) Token: 0x06000052 RID: 82 RVA: 0x00002613 File Offset: 0x00001613
        // (set) Token: 0x06000053 RID: 83 RVA: 0x0000261B File Offset: 0x0000161B
        public int QTo { get; set; }

        // Token: 0x17000025 RID: 37
        // (get) Token: 0x06000054 RID: 84 RVA: 0x00002624 File Offset: 0x00001624
        // (set) Token: 0x06000055 RID: 85 RVA: 0x0000262C File Offset: 0x0000162C
        public string InAnyOrderGroup { get; set; }

        // Token: 0x17000026 RID: 38
        // (get) Token: 0x06000056 RID: 86 RVA: 0x00002635 File Offset: 0x00001635
        // (set) Token: 0x06000057 RID: 87 RVA: 0x0000263D File Offset: 0x0000163D
        public List<ImagePaperAnswer> Answers { get; set; }

        // Token: 0x06000058 RID: 88 RVA: 0x00002648 File Offset: 0x00001648
        public int GetAnswerCount()
        {
            return this.QTo - this.QFrom + 1;
        }

        // Token: 0x06000059 RID: 89 RVA: 0x00002669 File Offset: 0x00001669
        public PaperSection()
        {
            this.Answers = new List<ImagePaperAnswer>();
        }
    }
}
