using System;
using System.Collections;

namespace QuestionLib.Entity
{
    // Token: 0x02000014 RID: 20
    [Serializable]
    public class MatchQuestion
    {
        // Token: 0x1700005A RID: 90
        // (get) Token: 0x060000E7 RID: 231 RVA: 0x00003BF0 File Offset: 0x00002BF0
        // (set) Token: 0x060000E8 RID: 232 RVA: 0x00003C08 File Offset: 0x00002C08
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

        // Token: 0x060000E9 RID: 233 RVA: 0x00003C12 File Offset: 0x00002C12
        public MatchQuestion()
        {
            this._questionLOs = new ArrayList();
        }

        // Token: 0x1700005B RID: 91
        // (get) Token: 0x060000EA RID: 234 RVA: 0x00003C28 File Offset: 0x00002C28
        // (set) Token: 0x060000EB RID: 235 RVA: 0x00003C40 File Offset: 0x00002C40
        public int MID
        {
            get
            {
                return this._mid;
            }
            set
            {
                this._mid = value;
            }
        }

        // Token: 0x1700005C RID: 92
        // (get) Token: 0x060000EC RID: 236 RVA: 0x00003C4C File Offset: 0x00002C4C
        // (set) Token: 0x060000ED RID: 237 RVA: 0x00003C64 File Offset: 0x00002C64
        public string CourseId
        {
            get
            {
                return this._courseId;
            }
            set
            {
                this._courseId = value;
            }
        }

        // Token: 0x1700005D RID: 93
        // (get) Token: 0x060000EE RID: 238 RVA: 0x00003C70 File Offset: 0x00002C70
        // (set) Token: 0x060000EF RID: 239 RVA: 0x00003C88 File Offset: 0x00002C88
        public int ChapterId
        {
            get
            {
                return this._chapterId;
            }
            set
            {
                this._chapterId = value;
            }
        }

        // Token: 0x1700005E RID: 94
        // (get) Token: 0x060000F0 RID: 240 RVA: 0x00003C94 File Offset: 0x00002C94
        // (set) Token: 0x060000F1 RID: 241 RVA: 0x00003CAC File Offset: 0x00002CAC
        public string ColumnA
        {
            get
            {
                return this._columnA;
            }
            set
            {
                this._columnA = value;
            }
        }

        // Token: 0x1700005F RID: 95
        // (get) Token: 0x060000F2 RID: 242 RVA: 0x00003CB8 File Offset: 0x00002CB8
        // (set) Token: 0x060000F3 RID: 243 RVA: 0x00003CD0 File Offset: 0x00002CD0
        public string ColumnB
        {
            get
            {
                return this._columnB;
            }
            set
            {
                this._columnB = value;
            }
        }

        // Token: 0x17000060 RID: 96
        // (get) Token: 0x060000F4 RID: 244 RVA: 0x00003CDC File Offset: 0x00002CDC
        // (set) Token: 0x060000F5 RID: 245 RVA: 0x00003CF4 File Offset: 0x00002CF4
        public string Solution
        {
            get
            {
                return this._solution;
            }
            set
            {
                this._solution = value;
            }
        }

        // Token: 0x17000061 RID: 97
        // (get) Token: 0x060000F6 RID: 246 RVA: 0x00003D00 File Offset: 0x00002D00
        // (set) Token: 0x060000F7 RID: 247 RVA: 0x00003D18 File Offset: 0x00002D18
        public float Mark
        {
            get
            {
                return this._mark;
            }
            set
            {
                this._mark = value;
            }
        }

        // Token: 0x17000062 RID: 98
        // (get) Token: 0x060000F8 RID: 248 RVA: 0x00003D24 File Offset: 0x00002D24
        // (set) Token: 0x060000F9 RID: 249 RVA: 0x00003D3C File Offset: 0x00002D3C
        public string SudentAnswer
        {
            get
            {
                return this._studentAnswer;
            }
            set
            {
                this._studentAnswer = value;
            }
        }

        // Token: 0x17000063 RID: 99
        // (get) Token: 0x060000FA RID: 250 RVA: 0x00003D48 File Offset: 0x00002D48
        // (set) Token: 0x060000FB RID: 251 RVA: 0x00003D60 File Offset: 0x00002D60
        public ArrayList QuestionLOs
        {
            get
            {
                return this._questionLOs;
            }
            set
            {
                this._questionLOs = value;
            }
        }

        // Token: 0x060000FC RID: 252 RVA: 0x00003D6C File Offset: 0x00002D6C
        public override string ToString()
        {
            return this._mid.ToString();
        }

        // Token: 0x060000FD RID: 253 RVA: 0x00003D89 File Offset: 0x00002D89
        public void Preapare2Submit()
        {
            this.Solution = null;
            this.ColumnA = null;
            this.ColumnB = null;
            this.CourseId = null;
        }

        // Token: 0x04000073 RID: 115
        private int _mid;

        // Token: 0x04000074 RID: 116
        private string _courseId;

        // Token: 0x04000075 RID: 117
        private int _chapterId;

        // Token: 0x04000076 RID: 118
        private string _columnA;

        // Token: 0x04000077 RID: 119
        private string _columnB;

        // Token: 0x04000078 RID: 120
        private string _solution;

        // Token: 0x04000079 RID: 121
        private float _mark;

        // Token: 0x0400007A RID: 122
        private string _studentAnswer;

        // Token: 0x0400007B RID: 123
        private ArrayList _questionLOs;

        // Token: 0x0400007C RID: 124
        private int _QBID;
    }
}
