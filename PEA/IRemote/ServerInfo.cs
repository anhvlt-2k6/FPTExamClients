using System;

namespace IRemote
{
    // Token: 0x0200000B RID: 11
    [Serializable]
    public class ServerInfo
    {
        // Token: 0x06000033 RID: 51 RVA: 0x000020AD File Offset: 0x000002AD
        public ServerInfo()
        {
        }

        // Token: 0x06000034 RID: 52 RVA: 0x00002215 File Offset: 0x00000415
        public ServerInfo(string ip, int port, string domain, string serverAlias, string version)
        {
            this.IP = ip;
            this.Port = port;
            this.Domain = domain;
            this.ServerAlias = serverAlias;
            this.Version = version;
        }

        // Token: 0x17000014 RID: 20
        // (get) Token: 0x06000035 RID: 53 RVA: 0x00002249 File Offset: 0x00000449
        // (set) Token: 0x06000036 RID: 54 RVA: 0x00002251 File Offset: 0x00000451
        public string IP { get; set; }

        // Token: 0x17000015 RID: 21
        // (get) Token: 0x06000037 RID: 55 RVA: 0x0000225A File Offset: 0x0000045A
        // (set) Token: 0x06000038 RID: 56 RVA: 0x00002262 File Offset: 0x00000462
        public string Domain { get; set; }

        // Token: 0x17000016 RID: 22
        // (get) Token: 0x06000039 RID: 57 RVA: 0x0000226B File Offset: 0x0000046B
        // (set) Token: 0x0600003A RID: 58 RVA: 0x00002273 File Offset: 0x00000473
        public int Port { get; set; }

        // Token: 0x17000017 RID: 23
        // (get) Token: 0x0600003B RID: 59 RVA: 0x0000227C File Offset: 0x0000047C
        // (set) Token: 0x0600003C RID: 60 RVA: 0x00002284 File Offset: 0x00000484
        public string ServerAlias { get; set; }

        // Token: 0x17000018 RID: 24
        // (get) Token: 0x0600003D RID: 61 RVA: 0x0000228D File Offset: 0x0000048D
        // (set) Token: 0x0600003E RID: 62 RVA: 0x00002295 File Offset: 0x00000495
        public string Version { get; set; }
    }
}
