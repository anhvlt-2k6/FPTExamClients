using System;

namespace IRemote
{
    // Token: 0x02000004 RID: 4
    [Serializable]
    public class SubmitHistory : IComparable<SubmitHistory>
    {
        // Token: 0x17000001 RID: 1
        // (get) Token: 0x06000003 RID: 3 RVA: 0x00002069 File Offset: 0x00000269
        // (set) Token: 0x06000004 RID: 4 RVA: 0x00002071 File Offset: 0x00000271
        public int PaperNo { get; set; }

        // Token: 0x17000002 RID: 2
        // (get) Token: 0x06000005 RID: 5 RVA: 0x0000207A File Offset: 0x0000027A
        // (set) Token: 0x06000006 RID: 6 RVA: 0x00002082 File Offset: 0x00000282
        public byte QuestionNo { get; set; }

        // Token: 0x17000003 RID: 3
        // (get) Token: 0x06000007 RID: 7 RVA: 0x0000208B File Offset: 0x0000028B
        // (set) Token: 0x06000008 RID: 8 RVA: 0x00002093 File Offset: 0x00000293
        public string Path { get; set; }

        // Token: 0x17000004 RID: 4
        // (get) Token: 0x06000009 RID: 9 RVA: 0x0000209C File Offset: 0x0000029C
        // (set) Token: 0x0600000A RID: 10 RVA: 0x000020A4 File Offset: 0x000002A4
        public DateTime Time { get; set; }

        // Token: 0x0600000B RID: 11 RVA: 0x000020AD File Offset: 0x000002AD
        public SubmitHistory()
        {
        }

        // Token: 0x0600000C RID: 12 RVA: 0x000020B7 File Offset: 0x000002B7
        public SubmitHistory(int paperNo, byte questionNo, string path, DateTime time)
        {
            this.PaperNo = paperNo;
            this.QuestionNo = questionNo;
            this.Path = path;
            this.Time = time;
        }

        // Token: 0x0600000D RID: 13 RVA: 0x000020E4 File Offset: 0x000002E4
        public int CompareTo(SubmitHistory sh)
        {
            bool flag = sh == null;
            int result;
            if (flag)
            {
                result = 1;
            }
            else
            {
                result = sh.Time.CompareTo(this.Time);
            }
            return result;
        }
    }
}
