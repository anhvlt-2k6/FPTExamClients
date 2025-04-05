namespace GradeLib
{
    // Token: 0x0200000C RID: 12
    public class Exam
    {
        // Token: 0x1700001B RID: 27
        // (get) Token: 0x06000047 RID: 71 RVA: 0x00002700 File Offset: 0x00000900
        // (set) Token: 0x06000048 RID: 72 RVA: 0x00002708 File Offset: 0x00000908
        public string ExamCode { get; set; }

        // Token: 0x1700001C RID: 28
        // (get) Token: 0x06000049 RID: 73 RVA: 0x00002711 File Offset: 0x00000911
        // (set) Token: 0x0600004A RID: 74 RVA: 0x00002719 File Offset: 0x00000919
        public string ExamName { get; set; }

        // Token: 0x1700001D RID: 29
        // (get) Token: 0x0600004B RID: 75 RVA: 0x00002722 File Offset: 0x00000922
        // (set) Token: 0x0600004C RID: 76 RVA: 0x0000272A File Offset: 0x0000092A
        public string Language { get; set; }

        // Token: 0x1700001E RID: 30
        // (get) Token: 0x0600004D RID: 77 RVA: 0x00002733 File Offset: 0x00000933
        // (set) Token: 0x0600004E RID: 78 RVA: 0x0000273B File Offset: 0x0000093B
        public string Description { get; set; }

        // Token: 0x0600004F RID: 79 RVA: 0x00002744 File Offset: 0x00000944
        public Exam()
        {
        }

        // Token: 0x06000050 RID: 80 RVA: 0x0000274E File Offset: 0x0000094E
        public Exam(string code, string name, string language, string desc)
        {
            this.ExamCode = code;
            this.ExamName = name;
            this.Language = language;
            this.Description = desc;
        }
    }
}
