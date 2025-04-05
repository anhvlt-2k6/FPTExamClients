using System;

namespace QuestionLib.Entity
{
    // Token: 0x02000012 RID: 18
    public class EOSLog
    {
        // Token: 0x17000050 RID: 80
        // (get) Token: 0x060000D0 RID: 208 RVA: 0x00003A60 File Offset: 0x00002A60
        // (set) Token: 0x060000D1 RID: 209 RVA: 0x00003A78 File Offset: 0x00002A78
        public int LogID
        {
            get
            {
                return this._LogID;
            }
            set
            {
                this._LogID = value;
            }
        }

        // Token: 0x17000051 RID: 81
        // (get) Token: 0x060000D2 RID: 210 RVA: 0x00003A84 File Offset: 0x00002A84
        // (set) Token: 0x060000D3 RID: 211 RVA: 0x00003A9C File Offset: 0x00002A9C
        public string Log_Name
        {
            get
            {
                return this._Log_Name;
            }
            set
            {
                this._Log_Name = value;
            }
        }

        // Token: 0x17000052 RID: 82
        // (get) Token: 0x060000D4 RID: 212 RVA: 0x00003AA8 File Offset: 0x00002AA8
        // (set) Token: 0x060000D5 RID: 213 RVA: 0x00003AC0 File Offset: 0x00002AC0
        public string Log_Account
        {
            get
            {
                return this._Log_Account;
            }
            set
            {
                this._Log_Account = value;
            }
        }

        // Token: 0x17000053 RID: 83
        // (get) Token: 0x060000D6 RID: 214 RVA: 0x00003ACC File Offset: 0x00002ACC
        // (set) Token: 0x060000D7 RID: 215 RVA: 0x00003AE4 File Offset: 0x00002AE4
        public string Log_MACAddress
        {
            get
            {
                return this._Log_MACAddress;
            }
            set
            {
                this._Log_MACAddress = value;
            }
        }

        // Token: 0x17000054 RID: 84
        // (get) Token: 0x060000D8 RID: 216 RVA: 0x00003AF0 File Offset: 0x00002AF0
        // (set) Token: 0x060000D9 RID: 217 RVA: 0x00003B08 File Offset: 0x00002B08
        public DateTime CreatedDate
        {
            get
            {
                return this._CreatedDate;
            }
            set
            {
                this._CreatedDate = value;
            }
        }

        // Token: 0x04000069 RID: 105
        private int _LogID;

        // Token: 0x0400006A RID: 106
        private string _Log_Name;

        // Token: 0x0400006B RID: 107
        private string _Log_Account;

        // Token: 0x0400006C RID: 108
        private string _Log_MACAddress;

        // Token: 0x0400006D RID: 109
        private DateTime _CreatedDate;
    }
}
