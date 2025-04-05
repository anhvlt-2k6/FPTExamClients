using System;
using System.Collections.Generic;

namespace GradeLib
{
    // Token: 0x02000004 RID: 4
    [Serializable]
    public class Paper
    {
        // Token: 0x17000001 RID: 1
        // (get) Token: 0x06000006 RID: 6 RVA: 0x00002175 File Offset: 0x00000375
        // (set) Token: 0x06000007 RID: 7 RVA: 0x0000217D File Offset: 0x0000037D
        public string PaperCode { get; set; }

        // Token: 0x17000002 RID: 2
        // (get) Token: 0x06000008 RID: 8 RVA: 0x00002186 File Offset: 0x00000386
        // (set) Token: 0x06000009 RID: 9 RVA: 0x0000218E File Offset: 0x0000038E
        public List<int> listQuestionCode { get; set; }

        // Token: 0x0600000A RID: 10 RVA: 0x00002197 File Offset: 0x00000397
        public Paper()
        {
            this.listQuestionCode = new List<int>();
        }
    }
}
