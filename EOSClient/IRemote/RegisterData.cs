using System;

namespace IRemote
{
    // Token: 0x02000004 RID: 4
    [Serializable]
    public class RegisterData
    {
        // Token: 0x17000001 RID: 1
        // (get) Token: 0x06000003 RID: 3 RVA: 0x0000205C File Offset: 0x0000025C
        // (set) Token: 0x06000004 RID: 4 RVA: 0x00002074 File Offset: 0x00000274
        public string Login
        {
            get
            {
                return this._login;
            }
            set
            {
                this._login = value;
            }
        }

        // Token: 0x17000002 RID: 2
        // (get) Token: 0x06000005 RID: 5 RVA: 0x00002080 File Offset: 0x00000280
        // (set) Token: 0x06000006 RID: 6 RVA: 0x00002098 File Offset: 0x00000298
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }

        // Token: 0x17000003 RID: 3
        // (get) Token: 0x06000007 RID: 7 RVA: 0x000020A4 File Offset: 0x000002A4
        // (set) Token: 0x06000008 RID: 8 RVA: 0x000020BC File Offset: 0x000002BC
        public DateTime StartDate
        {
            get
            {
                return this._startTime;
            }
            set
            {
                this._startTime = value;
            }
        }

        // Token: 0x17000004 RID: 4
        // (get) Token: 0x06000009 RID: 9 RVA: 0x000020C8 File Offset: 0x000002C8
        // (set) Token: 0x0600000A RID: 10 RVA: 0x000020E0 File Offset: 0x000002E0
        public string Machine
        {
            get
            {
                return this._machine;
            }
            set
            {
                this._machine = value;
            }
        }

        // Token: 0x17000005 RID: 5
        // (get) Token: 0x0600000B RID: 11 RVA: 0x000020EC File Offset: 0x000002EC
        // (set) Token: 0x0600000C RID: 12 RVA: 0x00002104 File Offset: 0x00000304
        public string ExamCode
        {
            get
            {
                return this._examCode;
            }
            set
            {
                this._examCode = value;
            }
        }

        // Token: 0x04000008 RID: 8
        private string _login;

        // Token: 0x04000009 RID: 9
        private string _password;

        // Token: 0x0400000A RID: 10
        private DateTime _startTime;

        // Token: 0x0400000B RID: 11
        private string _machine;

        // Token: 0x0400000C RID: 12
        private string _examCode;
    }
}
