using System;
using System.Collections.Generic;

namespace GradeLib
{
    // Token: 0x0200000D RID: 13
    [Serializable]
    public class Question
    {
        // Token: 0x1700001F RID: 31
        // (get) Token: 0x06000051 RID: 81 RVA: 0x00002779 File Offset: 0x00000979
        // (set) Token: 0x06000052 RID: 82 RVA: 0x00002781 File Offset: 0x00000981
        public int QuestionCode { get; set; }

        // Token: 0x17000020 RID: 32
        // (get) Token: 0x06000053 RID: 83 RVA: 0x0000278A File Offset: 0x0000098A
        // (set) Token: 0x06000054 RID: 84 RVA: 0x00002792 File Offset: 0x00000992
        public int TopicCode { get; set; }

        // Token: 0x17000021 RID: 33
        // (get) Token: 0x06000055 RID: 85 RVA: 0x0000279B File Offset: 0x0000099B
        // (set) Token: 0x06000056 RID: 86 RVA: 0x000027A3 File Offset: 0x000009A3
        public byte[] QuestionFile { get; set; }

        // Token: 0x17000022 RID: 34
        // (get) Token: 0x06000057 RID: 87 RVA: 0x000027AC File Offset: 0x000009AC
        // (set) Token: 0x06000058 RID: 88 RVA: 0x000027B4 File Offset: 0x000009B4
        public string FileType { get; set; }

        // Token: 0x17000023 RID: 35
        // (get) Token: 0x06000059 RID: 89 RVA: 0x000027BD File Offset: 0x000009BD
        // (set) Token: 0x0600005A RID: 90 RVA: 0x000027C5 File Offset: 0x000009C5
        public List<TestCase> TestCases { get; set; }

        // Token: 0x17000024 RID: 36
        // (get) Token: 0x0600005B RID: 91 RVA: 0x000027CE File Offset: 0x000009CE
        // (set) Token: 0x0600005C RID: 92 RVA: 0x000027D6 File Offset: 0x000009D6
        public float Mark { get; set; }

        // Token: 0x17000025 RID: 37
        // (get) Token: 0x0600005D RID: 93 RVA: 0x000027DF File Offset: 0x000009DF
        // (set) Token: 0x0600005E RID: 94 RVA: 0x000027E7 File Offset: 0x000009E7
        public string Author { get; set; }

        // Token: 0x17000026 RID: 38
        // (get) Token: 0x0600005F RID: 95 RVA: 0x000027F0 File Offset: 0x000009F0
        // (set) Token: 0x06000060 RID: 96 RVA: 0x000027F8 File Offset: 0x000009F8
        public byte[] Given { get; set; }
    }
}
