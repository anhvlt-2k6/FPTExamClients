namespace QuestionLib.Entity
{
    // Token: 0x02000010 RID: 16
    public class Course
    {
        // Token: 0x060000AC RID: 172 RVA: 0x000037C2 File Offset: 0x000027C2
        public Course()
        {
        }

        // Token: 0x060000AD RID: 173 RVA: 0x00003870 File Offset: 0x00002870
        public Course(string _cid, string _name, byte[] _imagedata, string _imagename, int _imagesize, int _numberofpage)
        {
            this._cid = _cid;
            this._name = _name;
            this._imagedata = _imagedata;
            this._imagename = _imagename;
            this._imagesize = _imagesize;
            this._numberofpage = _numberofpage;
        }

        // Token: 0x17000040 RID: 64
        // (get) Token: 0x060000AE RID: 174 RVA: 0x000038A8 File Offset: 0x000028A8
        // (set) Token: 0x060000AF RID: 175 RVA: 0x000038C0 File Offset: 0x000028C0
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

        // Token: 0x17000041 RID: 65
        // (get) Token: 0x060000B0 RID: 176 RVA: 0x000038CC File Offset: 0x000028CC
        // (set) Token: 0x060000B1 RID: 177 RVA: 0x000038E4 File Offset: 0x000028E4
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

        // Token: 0x17000042 RID: 66
        // (get) Token: 0x060000B2 RID: 178 RVA: 0x000038F0 File Offset: 0x000028F0
        // (set) Token: 0x060000B3 RID: 179 RVA: 0x00003908 File Offset: 0x00002908
        public byte[] ImageData
        {
            get
            {
                return this._imagedata;
            }
            set
            {
                this._imagedata = value;
            }
        }

        // Token: 0x17000043 RID: 67
        // (get) Token: 0x060000B4 RID: 180 RVA: 0x00003914 File Offset: 0x00002914
        // (set) Token: 0x060000B5 RID: 181 RVA: 0x0000392C File Offset: 0x0000292C
        public string ImageName
        {
            get
            {
                return this._imagename;
            }
            set
            {
                this._imagename = value;
            }
        }

        // Token: 0x17000044 RID: 68
        // (get) Token: 0x060000B6 RID: 182 RVA: 0x00003938 File Offset: 0x00002938
        // (set) Token: 0x060000B7 RID: 183 RVA: 0x00003950 File Offset: 0x00002950
        public int ImageSize
        {
            get
            {
                return this._imagesize;
            }
            set
            {
                this._imagesize = value;
            }
        }

        // Token: 0x17000045 RID: 69
        // (get) Token: 0x060000B8 RID: 184 RVA: 0x0000395C File Offset: 0x0000295C
        // (set) Token: 0x060000B9 RID: 185 RVA: 0x00003974 File Offset: 0x00002974
        public int NumberOfPage
        {
            get
            {
                return this._numberofpage;
            }
            set
            {
                this._numberofpage = value;
            }
        }

        // Token: 0x04000059 RID: 89
        private string _cid;

        // Token: 0x0400005A RID: 90
        private string _name;

        // Token: 0x0400005B RID: 91
        private byte[] _imagedata;

        // Token: 0x0400005C RID: 92
        private string _imagename;

        // Token: 0x0400005D RID: 93
        private int _imagesize;

        // Token: 0x0400005E RID: 94
        private int _numberofpage;
    }
}
