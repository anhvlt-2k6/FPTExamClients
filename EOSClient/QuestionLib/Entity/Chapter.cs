namespace QuestionLib.Entity
{
    // Token: 0x0200000F RID: 15
    public class Chapter
    {
        // Token: 0x060000A3 RID: 163 RVA: 0x000037C2 File Offset: 0x000027C2
        public Chapter()
        {
        }

        // Token: 0x060000A4 RID: 164 RVA: 0x000037CC File Offset: 0x000027CC
        public Chapter(int _chid, string _cid, string _name)
        {
            this._chid = _chid;
            this._cid = _cid;
            this._name = _name;
        }

        // Token: 0x1700003D RID: 61
        // (get) Token: 0x060000A5 RID: 165 RVA: 0x000037EC File Offset: 0x000027EC
        // (set) Token: 0x060000A6 RID: 166 RVA: 0x00003804 File Offset: 0x00002804
        public int ChID
        {
            get
            {
                return this._chid;
            }
            set
            {
                this._chid = value;
            }
        }

        // Token: 0x1700003E RID: 62
        // (get) Token: 0x060000A7 RID: 167 RVA: 0x00003810 File Offset: 0x00002810
        // (set) Token: 0x060000A8 RID: 168 RVA: 0x00003828 File Offset: 0x00002828
        public string CID
        {
            get
            {
                return this._cid;
            }
            set
            {
                this._cid = value;
            }
        }

        // Token: 0x1700003F RID: 63
        // (get) Token: 0x060000A9 RID: 169 RVA: 0x00003834 File Offset: 0x00002834
        // (set) Token: 0x060000AA RID: 170 RVA: 0x0000384C File Offset: 0x0000284C
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        // Token: 0x060000AB RID: 171 RVA: 0x00003858 File Offset: 0x00002858
        public override string ToString()
        {
            return this._name;
        }

        // Token: 0x04000056 RID: 86
        private int _chid;

        // Token: 0x04000057 RID: 87
        private string _cid;

        // Token: 0x04000058 RID: 88
        private string _name;
    }
}
