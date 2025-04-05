namespace QuestionLib.Entity
{
    // Token: 0x02000013 RID: 19
    public class LO
    {
        // Token: 0x17000055 RID: 85
        // (get) Token: 0x060000DB RID: 219 RVA: 0x00003B14 File Offset: 0x00002B14
        // (set) Token: 0x060000DC RID: 220 RVA: 0x00003B2C File Offset: 0x00002B2C
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

        // Token: 0x17000056 RID: 86
        // (get) Token: 0x060000DD RID: 221 RVA: 0x00003B38 File Offset: 0x00002B38
        // (set) Token: 0x060000DE RID: 222 RVA: 0x00003B50 File Offset: 0x00002B50
        public string CID
        {
            get
            {
                return this._CID;
            }
            set
            {
                this._CID = value;
            }
        }

        // Token: 0x17000057 RID: 87
        // (get) Token: 0x060000DF RID: 223 RVA: 0x00003B5C File Offset: 0x00002B5C
        // (set) Token: 0x060000E0 RID: 224 RVA: 0x00003B74 File Offset: 0x00002B74
        public string LO_Name
        {
            get
            {
                return this._LO_Name;
            }
            set
            {
                this._LO_Name = value;
            }
        }

        // Token: 0x17000058 RID: 88
        // (get) Token: 0x060000E1 RID: 225 RVA: 0x00003B80 File Offset: 0x00002B80
        // (set) Token: 0x060000E2 RID: 226 RVA: 0x00003B98 File Offset: 0x00002B98
        public string LO_Desc
        {
            get
            {
                return this._LO_Desc;
            }
            set
            {
                this._LO_Desc = value;
            }
        }

        // Token: 0x17000059 RID: 89
        // (get) Token: 0x060000E3 RID: 227 RVA: 0x00003BA4 File Offset: 0x00002BA4
        // (set) Token: 0x060000E4 RID: 228 RVA: 0x00003BBC File Offset: 0x00002BBC
        public string Dec_No
        {
            get
            {
                return this._Dec_No;
            }
            set
            {
                this._Dec_No = value;
            }
        }

        // Token: 0x060000E5 RID: 229 RVA: 0x00003BC8 File Offset: 0x00002BC8
        public override string ToString()
        {
            return this.LO_Name + " - " + this.LO_Desc;
        }

        // Token: 0x0400006E RID: 110
        private int _LOID;

        // Token: 0x0400006F RID: 111
        private string _CID;

        // Token: 0x04000070 RID: 112
        private string _LO_Name;

        // Token: 0x04000071 RID: 113
        private string _LO_Desc;

        // Token: 0x04000072 RID: 114
        private string _Dec_No;
    }
}
