using System;

namespace GradeLib
{
    // Token: 0x02000008 RID: 8
    [Serializable]
    public class Student
    {
        // Token: 0x1700000D RID: 13
        // (get) Token: 0x06000023 RID: 35 RVA: 0x00002364 File Offset: 0x00000564
        // (set) Token: 0x06000024 RID: 36 RVA: 0x0000236C File Offset: 0x0000056C
        public string Login { get; set; }

        // Token: 0x1700000E RID: 14
        // (get) Token: 0x06000025 RID: 37 RVA: 0x00002375 File Offset: 0x00000575
        // (set) Token: 0x06000026 RID: 38 RVA: 0x0000237D File Offset: 0x0000057D
        public int PaperNo { get; set; }

        // Token: 0x06000027 RID: 39 RVA: 0x00002388 File Offset: 0x00000588
        public override string ToString()
        {
            return this.Login + " - " + this.PaperNo;
        }
    }
}
