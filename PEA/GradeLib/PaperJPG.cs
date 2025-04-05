using System;

namespace GradeLib
{
    // Token: 0x02000005 RID: 5
    [Serializable]
    public class PaperJPG
    {
        // Token: 0x17000003 RID: 3
        // (get) Token: 0x0600000B RID: 11 RVA: 0x000021AD File Offset: 0x000003AD
        // (set) Token: 0x0600000C RID: 12 RVA: 0x000021B5 File Offset: 0x000003B5
        public int PaperCode { get; set; }

        // Token: 0x17000004 RID: 4
        // (get) Token: 0x0600000D RID: 13 RVA: 0x000021BE File Offset: 0x000003BE
        // (set) Token: 0x0600000E RID: 14 RVA: 0x000021C6 File Offset: 0x000003C6
        public byte[] PaperFile { get; set; }

        // Token: 0x17000005 RID: 5
        // (get) Token: 0x0600000F RID: 15 RVA: 0x000021CF File Offset: 0x000003CF
        // (set) Token: 0x06000010 RID: 16 RVA: 0x000021D7 File Offset: 0x000003D7
        public byte[] Given { get; set; }

        // Token: 0x17000006 RID: 6
        // (get) Token: 0x06000011 RID: 17 RVA: 0x000021E0 File Offset: 0x000003E0
        // (set) Token: 0x06000012 RID: 18 RVA: 0x000021E8 File Offset: 0x000003E8
        public byte[] GradingGuide { get; set; }

        // Token: 0x17000007 RID: 7
        // (get) Token: 0x06000013 RID: 19 RVA: 0x000021F1 File Offset: 0x000003F1
        // (set) Token: 0x06000014 RID: 20 RVA: 0x000021F9 File Offset: 0x000003F9
        public int NumberOfPage { get; set; }
    }
}
