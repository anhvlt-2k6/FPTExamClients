using System;

namespace QuestionLib.Entity
{
    // Token: 0x02000011 RID: 17
    [Serializable]
    public class EssayQuestion
    {
        // Token: 0x17000046 RID: 70
        // (get) Token: 0x060000BA RID: 186 RVA: 0x0000397E File Offset: 0x0000297E
        // (set) Token: 0x060000BB RID: 187 RVA: 0x00003986 File Offset: 0x00002986
        public int EQID { get; set; }

        // Token: 0x17000047 RID: 71
        // (get) Token: 0x060000BC RID: 188 RVA: 0x0000398F File Offset: 0x0000298F
        // (set) Token: 0x060000BD RID: 189 RVA: 0x00003997 File Offset: 0x00002997
        public string CourseId { get; set; }

        // Token: 0x17000048 RID: 72
        // (get) Token: 0x060000BE RID: 190 RVA: 0x000039A0 File Offset: 0x000029A0
        // (set) Token: 0x060000BF RID: 191 RVA: 0x000039A8 File Offset: 0x000029A8
        public int ChapterId { get; set; }

        // Token: 0x17000049 RID: 73
        // (get) Token: 0x060000C0 RID: 192 RVA: 0x000039B1 File Offset: 0x000029B1
        // (set) Token: 0x060000C1 RID: 193 RVA: 0x000039B9 File Offset: 0x000029B9
        public byte[] Question { get; set; }

        // Token: 0x1700004A RID: 74
        // (get) Token: 0x060000C2 RID: 194 RVA: 0x000039C2 File Offset: 0x000029C2
        // (set) Token: 0x060000C3 RID: 195 RVA: 0x000039CA File Offset: 0x000029CA
        public int QuestionFileSize { get; set; }

        // Token: 0x1700004B RID: 75
        // (get) Token: 0x060000C4 RID: 196 RVA: 0x000039D3 File Offset: 0x000029D3
        // (set) Token: 0x060000C5 RID: 197 RVA: 0x000039DB File Offset: 0x000029DB
        public string Name { get; set; }

        // Token: 0x1700004C RID: 76
        // (get) Token: 0x060000C6 RID: 198 RVA: 0x000039E4 File Offset: 0x000029E4
        // (set) Token: 0x060000C7 RID: 199 RVA: 0x000039EC File Offset: 0x000029EC
        public byte[] Guide2Mark { get; set; }

        // Token: 0x1700004D RID: 77
        // (get) Token: 0x060000C8 RID: 200 RVA: 0x000039F5 File Offset: 0x000029F5
        // (set) Token: 0x060000C9 RID: 201 RVA: 0x000039FD File Offset: 0x000029FD
        public int Guide2MarkFileSize { get; set; }

        // Token: 0x1700004E RID: 78
        // (get) Token: 0x060000CA RID: 202 RVA: 0x00003A06 File Offset: 0x00002A06
        // (set) Token: 0x060000CB RID: 203 RVA: 0x00003A0E File Offset: 0x00002A0E
        public string Development { get; set; }

        // Token: 0x1700004F RID: 79
        // (get) Token: 0x060000CC RID: 204 RVA: 0x00003A18 File Offset: 0x00002A18
        // (set) Token: 0x060000CD RID: 205 RVA: 0x00003A30 File Offset: 0x00002A30
        public int QBID
        {
            get
            {
                return this._QBID;
            }
            set
            {
                this._QBID = value;
            }
        }

        // Token: 0x060000CE RID: 206 RVA: 0x00003A3A File Offset: 0x00002A3A
        public void Preapare2Submit()
        {
            this.CourseId = null;
            this.Question = null;
            this.Name = null;
            this.Guide2Mark = null;
        }

        // Token: 0x04000068 RID: 104
        private int _QBID;
    }
}
