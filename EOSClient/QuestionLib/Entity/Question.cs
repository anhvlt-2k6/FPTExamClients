using NHibernate;
using QuestionLib.Business;
using System;
using System.Collections;

namespace QuestionLib.Entity
{
    // Token: 0x02000017 RID: 23
    [Serializable]
    public class Question
    {
        // Token: 0x1700006A RID: 106
        // (get) Token: 0x0600010E RID: 270 RVA: 0x00003F54 File Offset: 0x00002F54
        // (set) Token: 0x0600010F RID: 271 RVA: 0x00003F6C File Offset: 0x00002F6C
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

        // Token: 0x06000110 RID: 272 RVA: 0x00003F76 File Offset: 0x00002F76
        public Question()
        {
            this._questionAnswers = new ArrayList();
            this._questionLOs = new ArrayList();
        }

        // Token: 0x1700006B RID: 107
        // (get) Token: 0x06000111 RID: 273 RVA: 0x00003F98 File Offset: 0x00002F98
        // (set) Token: 0x06000112 RID: 274 RVA: 0x00003FB0 File Offset: 0x00002FB0
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

        // Token: 0x1700006C RID: 108
        // (get) Token: 0x06000113 RID: 275 RVA: 0x00003FBC File Offset: 0x00002FBC
        // (set) Token: 0x06000114 RID: 276 RVA: 0x00003FD4 File Offset: 0x00002FD4
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

        // Token: 0x1700006D RID: 109
        // (get) Token: 0x06000115 RID: 277 RVA: 0x00003FE0 File Offset: 0x00002FE0
        // (set) Token: 0x06000116 RID: 278 RVA: 0x00003FF8 File Offset: 0x00002FF8
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

        // Token: 0x1700006E RID: 110
        // (get) Token: 0x06000117 RID: 279 RVA: 0x00004004 File Offset: 0x00003004
        // (set) Token: 0x06000118 RID: 280 RVA: 0x0000401C File Offset: 0x0000301C
        public int PID
        {
            get
            {
                return this._pid;
            }
            set
            {
                this._pid = value;
            }
        }

        // Token: 0x1700006F RID: 111
        // (get) Token: 0x06000119 RID: 281 RVA: 0x00004028 File Offset: 0x00003028
        // (set) Token: 0x0600011A RID: 282 RVA: 0x00004040 File Offset: 0x00003040
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

        // Token: 0x17000070 RID: 112
        // (get) Token: 0x0600011B RID: 283 RVA: 0x0000404C File Offset: 0x0000304C
        // (set) Token: 0x0600011C RID: 284 RVA: 0x00004064 File Offset: 0x00003064
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

        // Token: 0x17000071 RID: 113
        // (get) Token: 0x0600011D RID: 285 RVA: 0x00004070 File Offset: 0x00003070
        // (set) Token: 0x0600011E RID: 286 RVA: 0x00004088 File Offset: 0x00003088
        public ArrayList QuestionAnswers
        {
            get
            {
                return this._questionAnswers;
            }
            set
            {
                this._questionAnswers = value;
            }
        }

        // Token: 0x17000072 RID: 114
        // (get) Token: 0x0600011F RID: 287 RVA: 0x00004094 File Offset: 0x00003094
        // (set) Token: 0x06000120 RID: 288 RVA: 0x000040AC File Offset: 0x000030AC
        public QuestionType QType
        {
            get
            {
                return this._qType;
            }
            set
            {
                this._qType = value;
            }
        }

        // Token: 0x17000073 RID: 115
        // (get) Token: 0x06000121 RID: 289 RVA: 0x000040B8 File Offset: 0x000030B8
        // (set) Token: 0x06000122 RID: 290 RVA: 0x000040D0 File Offset: 0x000030D0
        public bool Lock
        {
            get
            {
                return this._lock;
            }
            set
            {
                this._lock = value;
            }
        }

        // Token: 0x17000074 RID: 116
        // (get) Token: 0x06000123 RID: 291 RVA: 0x000040DC File Offset: 0x000030DC
        // (set) Token: 0x06000124 RID: 292 RVA: 0x000040F4 File Offset: 0x000030F4
        public byte[] ImageData
        {
            get
            {
                return this._imageData;
            }
            set
            {
                this._imageData = value;
            }
        }

        // Token: 0x17000075 RID: 117
        // (get) Token: 0x06000125 RID: 293 RVA: 0x00004100 File Offset: 0x00003100
        // (set) Token: 0x06000126 RID: 294 RVA: 0x00004118 File Offset: 0x00003118
        public int ImageSize
        {
            get
            {
                return this._imageSize;
            }
            set
            {
                this._imageSize = value;
            }
        }

        // Token: 0x17000076 RID: 118
        // (get) Token: 0x06000127 RID: 295 RVA: 0x00004124 File Offset: 0x00003124
        // (set) Token: 0x06000128 RID: 296 RVA: 0x0000413C File Offset: 0x0000313C
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

        // Token: 0x06000129 RID: 297 RVA: 0x00004148 File Offset: 0x00003148
        public override string ToString()
        {
            return this._text;
        }

        // Token: 0x0600012A RID: 298 RVA: 0x00004160 File Offset: 0x00003160
        public void LoadAnswers(ISessionFactory sessionFactory)
        {
            BOQuestionAnswer boqa = new BOQuestionAnswer(sessionFactory);
            this._questionAnswers = (ArrayList)boqa.LoadAnswer(this._qid);
        }

        // Token: 0x0600012B RID: 299 RVA: 0x0000418C File Offset: 0x0000318C
        public void Preapare2Submit()
        {
            this.Text = null;
            this.CourseId = null;
            this.ImageData = null;
            this.ImageSize = 0;
            bool flag = this.QType == QuestionType.FILL_BLANK_ALL;
            if (!flag)
            {
                bool flag2 = this.QType == QuestionType.FILL_BLANK_GROUP;
                if (!flag2)
                {
                    bool flag3 = this.QType == QuestionType.FILL_BLANK_EMPTY;
                    if (!flag3)
                    {
                        foreach (object obj in this.QuestionAnswers)
                        {
                            QuestionAnswer qa = (QuestionAnswer)obj;
                            qa.Text = null;
                        }
                    }
                }
            }
        }

        // Token: 0x0400008B RID: 139
        private int _qid;

        // Token: 0x0400008C RID: 140
        private string _courseId;

        // Token: 0x0400008D RID: 141
        private int _chapterId;

        // Token: 0x0400008E RID: 142
        private int _pid;

        // Token: 0x0400008F RID: 143
        private string _text;

        // Token: 0x04000090 RID: 144
        private float _mark;

        // Token: 0x04000091 RID: 145
        private ArrayList _questionAnswers;

        // Token: 0x04000092 RID: 146
        private QuestionType _qType;

        // Token: 0x04000093 RID: 147
        private bool _lock;

        // Token: 0x04000094 RID: 148
        private byte[] _imageData;

        // Token: 0x04000095 RID: 149
        private int _imageSize;

        // Token: 0x04000096 RID: 150
        private ArrayList _questionLOs;

        // Token: 0x04000097 RID: 151
        private int _QBID;
    }
}
