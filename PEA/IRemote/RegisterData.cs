using System;

namespace IRemote
{
    // Token: 0x02000005 RID: 5
    [Serializable]
    public class RegisterData
    {
        // Token: 0x17000005 RID: 5
        // (get) Token: 0x0600000E RID: 14 RVA: 0x00002116 File Offset: 0x00000316
        // (set) Token: 0x0600000F RID: 15 RVA: 0x0000211E File Offset: 0x0000031E
        public string Login { get; set; }

        // Token: 0x17000006 RID: 6
        // (get) Token: 0x06000010 RID: 16 RVA: 0x00002127 File Offset: 0x00000327
        // (set) Token: 0x06000011 RID: 17 RVA: 0x0000212F File Offset: 0x0000032F
        public string Password { get; set; }

        // Token: 0x17000007 RID: 7
        // (get) Token: 0x06000012 RID: 18 RVA: 0x00002138 File Offset: 0x00000338
        // (set) Token: 0x06000013 RID: 19 RVA: 0x00002140 File Offset: 0x00000340
        public DateTime StartTime { get; set; }

        // Token: 0x17000008 RID: 8
        // (get) Token: 0x06000014 RID: 20 RVA: 0x00002149 File Offset: 0x00000349
        // (set) Token: 0x06000015 RID: 21 RVA: 0x00002151 File Offset: 0x00000351
        public string Machine { get; set; }

        // Token: 0x17000009 RID: 9
        // (get) Token: 0x06000016 RID: 22 RVA: 0x0000215A File Offset: 0x0000035A
        // (set) Token: 0x06000017 RID: 23 RVA: 0x00002162 File Offset: 0x00000362
        public string TestName { get; set; }

        // Token: 0x1700000A RID: 10
        // (get) Token: 0x06000018 RID: 24 RVA: 0x0000216B File Offset: 0x0000036B
        // (set) Token: 0x06000019 RID: 25 RVA: 0x00002173 File Offset: 0x00000373
        public int PaperNo { get; set; }
    }
}
