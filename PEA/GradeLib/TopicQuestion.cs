using System;
using System.Collections.Generic;

namespace GradeLib
{
    // Token: 0x0200000F RID: 15
    [Serializable]
    public class TopicQuestion
    {
        // Token: 0x17000027 RID: 39
        // (get) Token: 0x06000062 RID: 98 RVA: 0x00002801 File Offset: 0x00000A01
        // (set) Token: 0x06000063 RID: 99 RVA: 0x00002809 File Offset: 0x00000A09
        public int TopicCode { get; set; }

        // Token: 0x17000028 RID: 40
        // (get) Token: 0x06000064 RID: 100 RVA: 0x00002812 File Offset: 0x00000A12
        // (set) Token: 0x06000065 RID: 101 RVA: 0x0000281A File Offset: 0x00000A1A
        public List<Question> listQuestion { get; set; }

        // Token: 0x06000066 RID: 102 RVA: 0x00002823 File Offset: 0x00000A23
        public TopicQuestion()
        {
            this.listQuestion = new List<Question>();
        }
    }
}
