using System;
using System.Collections.Generic;

namespace IRemote
{
    // Token: 0x02000002 RID: 2
    [Serializable]
    public class PEAData
    {
        // Token: 0x04000001 RID: 1
        public string SessionID;

        // Token: 0x04000002 RID: 2
        public RegisterStatus Status;

        // Token: 0x04000003 RID: 3
        public byte[] GUI;

        // Token: 0x04000004 RID: 4
        public int OriginSize;

        // Token: 0x04000005 RID: 5
        public ServerInfo ServerInfomation;

        // Token: 0x04000006 RID: 6
        public RegisterData RegData;

        // Token: 0x04000007 RID: 7
        public List<SubmitHistory> SubmitHistory;

        // Token: 0x04000008 RID: 8
        public byte PaperCount;

        // Token: 0x04000009 RID: 9
        public byte QuestionCount;

        // Token: 0x0400000A RID: 10
        public List<GivenMaterials> GivenMaterials;

        // Token: 0x0400000B RID: 11
        public byte[] PaperImage;

        // Token: 0x0400000C RID: 12
        public int NumberOfPage;

        // Token: 0x0400000D RID: 13
        public string Language;

        // Token: 0x0400000E RID: 14
        public bool LockClient;

        // Token: 0x0400000F RID: 15
        public int TimeAllow = 0;
    }
}
