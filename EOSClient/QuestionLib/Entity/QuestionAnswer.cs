using System;

namespace QuestionLib.Entity
{
    // Token: 0x02000018 RID: 24
    [Serializable]
    public class QuestionAnswer
    {
        // Token: 0x17000077 RID: 119
        // (get) Token: 0x0600012C RID: 300 RVA: 0x00004240 File Offset: 0x00003240
        // (set) Token: 0x0600012D RID: 301 RVA: 0x00004258 File Offset: 0x00003258
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

        // Token: 0x0600012E RID: 302 RVA: 0x000037C2 File Offset: 0x000027C2
        public QuestionAnswer()
        {
        }

        // Token: 0x0600012F RID: 303 RVA: 0x00004262 File Offset: 0x00003262
        public QuestionAnswer(string text, bool chosen)
        {
            this._text = text;
            this._chosen = chosen;
        }

        // Token: 0x17000078 RID: 120
        // (get) Token: 0x06000130 RID: 304 RVA: 0x0000427C File Offset: 0x0000327C
        // (set) Token: 0x06000131 RID: 305 RVA: 0x00004294 File Offset: 0x00003294
        public int QAID
        {
            get
            {
                return this._qaid;
            }
            set
            {
                this._qaid = value;
            }
        }

        // Token: 0x17000079 RID: 121
        // (get) Token: 0x06000132 RID: 306 RVA: 0x000042A0 File Offset: 0x000032A0
        // (set) Token: 0x06000133 RID: 307 RVA: 0x000042B8 File Offset: 0x000032B8
        public int QID
        {
            get
            {
                return this._qid;
            }
            set
            {
                this._qid = value;
            }
        }

        // Token: 0x1700007A RID: 122
        // (get) Token: 0x06000134 RID: 308 RVA: 0x000042C4 File Offset: 0x000032C4
        // (set) Token: 0x06000135 RID: 309 RVA: 0x000042DC File Offset: 0x000032DC
        public string Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }

        // Token: 0x1700007B RID: 123
        // (get) Token: 0x06000136 RID: 310 RVA: 0x000042E8 File Offset: 0x000032E8
        // (set) Token: 0x06000137 RID: 311 RVA: 0x00004300 File Offset: 0x00003300
        public bool Chosen
        {
            get
            {
                return this._chosen;
            }
            set
            {
                this._chosen = value;
            }
        }

        // Token: 0x1700007C RID: 124
        // (get) Token: 0x06000138 RID: 312 RVA: 0x0000430C File Offset: 0x0000330C
        // (set) Token: 0x06000139 RID: 313 RVA: 0x00004324 File Offset: 0x00003324
        public bool Selected
        {
            get
            {
                return this._selected;
            }
            set
            {
                this._selected = value;
            }
        }

        // Token: 0x1700007D RID: 125
        // (get) Token: 0x0600013A RID: 314 RVA: 0x00004330 File Offset: 0x00003330
        // (set) Token: 0x0600013B RID: 315 RVA: 0x00004348 File Offset: 0x00003348
        public bool Done
        {
            get
            {
                return this._done;
            }
            set
            {
                this._done = value;
            }
        }

        // Token: 0x04000098 RID: 152
        private int _qaid;

        // Token: 0x04000099 RID: 153
        private int _qid;

        // Token: 0x0400009A RID: 154
        private string _text;

        // Token: 0x0400009B RID: 155
        private bool _chosen;

        // Token: 0x0400009C RID: 156
        private bool _selected;

        // Token: 0x0400009D RID: 157
        private bool _done;

        // Token: 0x0400009E RID: 158
        private int _QBID;
    }
}
