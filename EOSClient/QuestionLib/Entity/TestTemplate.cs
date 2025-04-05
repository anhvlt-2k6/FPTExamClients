using System;

namespace QuestionLib.Entity
{
    // Token: 0x0200001B RID: 27
    public class TestTemplate
    {
        // Token: 0x17000088 RID: 136
        // (get) Token: 0x06000152 RID: 338 RVA: 0x000044BA File Offset: 0x000034BA
        // (set) Token: 0x06000153 RID: 339 RVA: 0x000044C2 File Offset: 0x000034C2
        public int TestTemplateID { get; set; }

        // Token: 0x17000089 RID: 137
        // (get) Token: 0x06000154 RID: 340 RVA: 0x000044CB File Offset: 0x000034CB
        // (set) Token: 0x06000155 RID: 341 RVA: 0x000044D3 File Offset: 0x000034D3
        public string CID { get; set; }

        // Token: 0x1700008A RID: 138
        // (get) Token: 0x06000156 RID: 342 RVA: 0x000044DC File Offset: 0x000034DC
        // (set) Token: 0x06000157 RID: 343 RVA: 0x000044E4 File Offset: 0x000034E4
        public string TestTemplateName { get; set; }

        // Token: 0x1700008B RID: 139
        // (get) Token: 0x06000158 RID: 344 RVA: 0x000044ED File Offset: 0x000034ED
        // (set) Token: 0x06000159 RID: 345 RVA: 0x000044F5 File Offset: 0x000034F5
        public string CreatedBy { get; set; }

        // Token: 0x1700008C RID: 140
        // (get) Token: 0x0600015A RID: 346 RVA: 0x000044FE File Offset: 0x000034FE
        // (set) Token: 0x0600015B RID: 347 RVA: 0x00004506 File Offset: 0x00003506
        public DateTime CreatedDate { get; set; }

        // Token: 0x1700008D RID: 141
        // (get) Token: 0x0600015C RID: 348 RVA: 0x0000450F File Offset: 0x0000350F
        // (set) Token: 0x0600015D RID: 349 RVA: 0x00004517 File Offset: 0x00003517
        public int DistinctWithLastTest { get; set; }

        // Token: 0x1700008E RID: 142
        // (get) Token: 0x0600015E RID: 350 RVA: 0x00004520 File Offset: 0x00003520
        // (set) Token: 0x0600015F RID: 351 RVA: 0x00004528 File Offset: 0x00003528
        public int Duration { get; set; }

        // Token: 0x1700008F RID: 143
        // (get) Token: 0x06000160 RID: 352 RVA: 0x00004531 File Offset: 0x00003531
        // (set) Token: 0x06000161 RID: 353 RVA: 0x00004539 File Offset: 0x00003539
        public string Note { get; set; }
    }
}
