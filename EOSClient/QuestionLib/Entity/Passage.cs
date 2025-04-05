using NHibernate;
using QuestionLib.Business;
using System;
using System.Collections;

namespace QuestionLib.Entity
{
    // Token: 0x02000015 RID: 21
    [Serializable]
    public class Passage
    {
        // Token: 0x17000064 RID: 100
        // (get) Token: 0x060000FE RID: 254 RVA: 0x00003DAC File Offset: 0x00002DAC
        // (set) Token: 0x060000FF RID: 255 RVA: 0x00003DC4 File Offset: 0x00002DC4
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

        // Token: 0x06000100 RID: 256 RVA: 0x00003DCE File Offset: 0x00002DCE
        public Passage()
        {
            this._passageQuestions = new ArrayList();
        }

        // Token: 0x17000065 RID: 101
        // (get) Token: 0x06000101 RID: 257 RVA: 0x00003DE4 File Offset: 0x00002DE4
        // (set) Token: 0x06000102 RID: 258 RVA: 0x00003DFC File Offset: 0x00002DFC
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

        // Token: 0x17000066 RID: 102
        // (get) Token: 0x06000103 RID: 259 RVA: 0x00003E08 File Offset: 0x00002E08
        // (set) Token: 0x06000104 RID: 260 RVA: 0x00003E20 File Offset: 0x00002E20
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

        // Token: 0x17000067 RID: 103
        // (get) Token: 0x06000105 RID: 261 RVA: 0x00003E2C File Offset: 0x00002E2C
        // (set) Token: 0x06000106 RID: 262 RVA: 0x00003E44 File Offset: 0x00002E44
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

        // Token: 0x17000068 RID: 104
        // (get) Token: 0x06000107 RID: 263 RVA: 0x00003E50 File Offset: 0x00002E50
        // (set) Token: 0x06000108 RID: 264 RVA: 0x00003E68 File Offset: 0x00002E68
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

        // Token: 0x17000069 RID: 105
        // (get) Token: 0x06000109 RID: 265 RVA: 0x00003E74 File Offset: 0x00002E74
        // (set) Token: 0x0600010A RID: 266 RVA: 0x00003E8C File Offset: 0x00002E8C
        public ArrayList PassageQuestions
        {
            get
            {
                return this._passageQuestions;
            }
            set
            {
                this._passageQuestions = value;
            }
        }

        // Token: 0x0600010B RID: 267 RVA: 0x00003E98 File Offset: 0x00002E98
        public override string ToString()
        {
            return this._pid.ToString();
        }

        // Token: 0x0600010C RID: 268 RVA: 0x00003EB8 File Offset: 0x00002EB8
        public void LoadQuestions(ISessionFactory sessionFactory)
        {
            BOQuestion boq = new BOQuestion(sessionFactory);
            this._passageQuestions = (ArrayList)boq.LoadPassageQuestion(this._pid);
        }

        // Token: 0x0600010D RID: 269 RVA: 0x00003EE4 File Offset: 0x00002EE4
        public void Preapare2Submit()
        {
            this.Text = null;
            this.CourseId = null;
            foreach (object obj in this.PassageQuestions)
            {
                Question q = (Question)obj;
                q.Preapare2Submit();
            }
        }

        // Token: 0x0400007D RID: 125
        private int _pid;

        // Token: 0x0400007E RID: 126
        private string _courseId;

        // Token: 0x0400007F RID: 127
        private int _chapterId;

        // Token: 0x04000080 RID: 128
        private string _text;

        // Token: 0x04000081 RID: 129
        private ArrayList _passageQuestions;

        // Token: 0x04000082 RID: 130
        private int _QBID;
    }
}
