using System;

namespace QuestionLib
{
    // Token: 0x0200000D RID: 13
    [Serializable]
    public class SubmitPaper
    {
        // Token: 0x0600008E RID: 142 RVA: 0x00003624 File Offset: 0x00002624
        public override bool Equals(object obj)
        {
            SubmitPaper s = (SubmitPaper)obj;
            return this.ID.Equals(s.ID) && this.SPaper.ExamCode.Equals(s.SPaper.ExamCode);
        }

        // Token: 0x04000041 RID: 65
        public string LoginId;

        // Token: 0x04000042 RID: 66
        public int TimeLeft;

        // Token: 0x04000043 RID: 67
        public int IndexFill;

        // Token: 0x04000044 RID: 68
        public int IndexReading;

        // Token: 0x04000045 RID: 69
        public int IndexG;

        // Token: 0x04000046 RID: 70
        public int IndexIndiM;

        // Token: 0x04000047 RID: 71
        public int IndexMatch;

        // Token: 0x04000048 RID: 72
        public bool Finish;

        // Token: 0x04000049 RID: 73
        public Paper SPaper;

        // Token: 0x0400004A RID: 74
        public int TabIndex;

        // Token: 0x0400004B RID: 75
        public DateTime SubmitTime;

        // Token: 0x0400004C RID: 76
        public string ID;
    }
}
