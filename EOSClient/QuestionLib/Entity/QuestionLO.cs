namespace QuestionLib.Entity
{
    // Token: 0x02000019 RID: 25
    public class QuestionLO
    {
        // Token: 0x1700007E RID: 126
        // (get) Token: 0x0600013C RID: 316 RVA: 0x00004354 File Offset: 0x00003354
        // (set) Token: 0x0600013D RID: 317 RVA: 0x0000436C File Offset: 0x0000336C
        public int QuestionLOID
        {
            get
            {
                return this._QuestionLOID;
            }
            set
            {
                this._QuestionLOID = value;
            }
        }

        // Token: 0x1700007F RID: 127
        // (get) Token: 0x0600013E RID: 318 RVA: 0x00004378 File Offset: 0x00003378
        // (set) Token: 0x0600013F RID: 319 RVA: 0x00004390 File Offset: 0x00003390
        public QuestionType QType
        {
            get
            {
                return this._QType;
            }
            set
            {
                this._QType = value;
            }
        }

        // Token: 0x17000080 RID: 128
        // (get) Token: 0x06000140 RID: 320 RVA: 0x0000439C File Offset: 0x0000339C
        // (set) Token: 0x06000141 RID: 321 RVA: 0x000043B4 File Offset: 0x000033B4
        public int QID
        {
            get
            {
                return this._QID;
            }
            set
            {
                this._QID = value;
            }
        }

        // Token: 0x17000081 RID: 129
        // (get) Token: 0x06000142 RID: 322 RVA: 0x000043C0 File Offset: 0x000033C0
        // (set) Token: 0x06000143 RID: 323 RVA: 0x000043D8 File Offset: 0x000033D8
        public int LOID
        {
            get
            {
                return this._LOID;
            }
            set
            {
                this._LOID = value;
            }
        }

        // Token: 0x0400009F RID: 159
        private int _QuestionLOID;

        // Token: 0x040000A0 RID: 160
        private QuestionType _QType;

        // Token: 0x040000A1 RID: 161
        private int _QID;

        // Token: 0x040000A2 RID: 162
        private int _LOID;
    }
}
