using System;

namespace IRemote
{
    // Token: 0x02000009 RID: 9
    [Serializable]
    public class SubmitSolution
    {
        // Token: 0x1700000B RID: 11
        // (get) Token: 0x0600001E RID: 30 RVA: 0x0000217C File Offset: 0x0000037C
        // (set) Token: 0x0600001F RID: 31 RVA: 0x00002184 File Offset: 0x00000384
        public string SessionID { get; set; }

        // Token: 0x1700000C RID: 12
        // (get) Token: 0x06000020 RID: 32 RVA: 0x0000218D File Offset: 0x0000038D
        // (set) Token: 0x06000021 RID: 33 RVA: 0x00002195 File Offset: 0x00000395
        public string Login { get; set; }

        // Token: 0x1700000D RID: 13
        // (get) Token: 0x06000022 RID: 34 RVA: 0x0000219E File Offset: 0x0000039E
        // (set) Token: 0x06000023 RID: 35 RVA: 0x000021A6 File Offset: 0x000003A6
        public string TestName { get; set; }

        // Token: 0x1700000E RID: 14
        // (get) Token: 0x06000024 RID: 36 RVA: 0x000021AF File Offset: 0x000003AF
        // (set) Token: 0x06000025 RID: 37 RVA: 0x000021B7 File Offset: 0x000003B7
        public int PaperNo { get; set; }

        // Token: 0x1700000F RID: 15
        // (get) Token: 0x06000026 RID: 38 RVA: 0x000021C0 File Offset: 0x000003C0
        // (set) Token: 0x06000027 RID: 39 RVA: 0x000021C8 File Offset: 0x000003C8
        public byte QuestionNo { get; set; }

        // Token: 0x17000010 RID: 16
        // (get) Token: 0x06000028 RID: 40 RVA: 0x000021D1 File Offset: 0x000003D1
        // (set) Token: 0x06000029 RID: 41 RVA: 0x000021D9 File Offset: 0x000003D9
        public byte[] SolutionBuf { get; set; }

        // Token: 0x17000011 RID: 17
        // (get) Token: 0x0600002A RID: 42 RVA: 0x000021E2 File Offset: 0x000003E2
        // (set) Token: 0x0600002B RID: 43 RVA: 0x000021EA File Offset: 0x000003EA
        public string CompressType { get; set; }

        // Token: 0x17000012 RID: 18
        // (get) Token: 0x0600002C RID: 44 RVA: 0x000021F3 File Offset: 0x000003F3
        // (set) Token: 0x0600002D RID: 45 RVA: 0x000021FB File Offset: 0x000003FB
        public string Path { get; set; }

        // Token: 0x17000013 RID: 19
        // (get) Token: 0x0600002E RID: 46 RVA: 0x00002204 File Offset: 0x00000404
        // (set) Token: 0x0600002F RID: 47 RVA: 0x0000220C File Offset: 0x0000040C
        public int FileSize { get; set; }
    }
}
