using System;

namespace IRemote
{
    // Token: 0x02000009 RID: 9
    [Serializable]
    public class ServerInfo
    {
        // Token: 0x06000015 RID: 21 RVA: 0x0000210E File Offset: 0x0000030E
        public ServerInfo()
        {
        }

        // Token: 0x06000016 RID: 22 RVA: 0x00002118 File Offset: 0x00000318
        public ServerInfo(string ip, int port, string serverAlias, string version, string ip_range_wlan)
        {
            this._ip = ip;
            this._port = port;
            this._serverAlias = serverAlias;
            this._version = version;
            this._ip_range_wlan = ip_range_wlan;
        }

        // Token: 0x17000006 RID: 6
        // (get) Token: 0x06000017 RID: 23 RVA: 0x00002148 File Offset: 0x00000348
        // (set) Token: 0x06000018 RID: 24 RVA: 0x00002160 File Offset: 0x00000360
        public string IP
        {
            get
            {
                return this._ip;
            }
            set
            {
                this._ip = value;
            }
        }

        // Token: 0x17000007 RID: 7
        // (get) Token: 0x06000019 RID: 25 RVA: 0x0000216C File Offset: 0x0000036C
        // (set) Token: 0x0600001A RID: 26 RVA: 0x00002184 File Offset: 0x00000384
        public int Port
        {
            get
            {
                return this._port;
            }
            set
            {
                this._port = value;
            }
        }

        // Token: 0x17000008 RID: 8
        // (get) Token: 0x0600001B RID: 27 RVA: 0x00002190 File Offset: 0x00000390
        // (set) Token: 0x0600001C RID: 28 RVA: 0x000021A8 File Offset: 0x000003A8
        public string ServerAlias
        {
            get
            {
                return this._serverAlias;
            }
            set
            {
                this._serverAlias = value;
            }
        }

        // Token: 0x17000009 RID: 9
        // (get) Token: 0x0600001D RID: 29 RVA: 0x000021B4 File Offset: 0x000003B4
        // (set) Token: 0x0600001E RID: 30 RVA: 0x000021CC File Offset: 0x000003CC
        public string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }

        // Token: 0x1700000A RID: 10
        // (get) Token: 0x0600001F RID: 31 RVA: 0x000021D8 File Offset: 0x000003D8
        // (set) Token: 0x06000020 RID: 32 RVA: 0x000021F0 File Offset: 0x000003F0
        public string MonitorServer_IP
        {
            get
            {
                return this._monitor_IP;
            }
            set
            {
                this._monitor_IP = value;
            }
        }

        // Token: 0x1700000B RID: 11
        // (get) Token: 0x06000021 RID: 33 RVA: 0x000021FC File Offset: 0x000003FC
        // (set) Token: 0x06000022 RID: 34 RVA: 0x00002214 File Offset: 0x00000414
        public int MonitorServer_Port
        {
            get
            {
                return this._monitor_port;
            }
            set
            {
                this._monitor_port = value;
            }
        }

        // Token: 0x1700000C RID: 12
        // (get) Token: 0x06000023 RID: 35 RVA: 0x00002220 File Offset: 0x00000420
        // (set) Token: 0x06000024 RID: 36 RVA: 0x00002238 File Offset: 0x00000438
        public string IP_Range_WLAN
        {
            get
            {
                return this._ip_range_wlan;
            }
            set
            {
                this._ip_range_wlan = value;
            }
        }

        // Token: 0x1700000D RID: 13
        // (get) Token: 0x06000025 RID: 37 RVA: 0x00002244 File Offset: 0x00000444
        // (set) Token: 0x06000026 RID: 38 RVA: 0x0000225C File Offset: 0x0000045C
        public string Public_IP
        {
            get
            {
                return this._public_ip;
            }
            set
            {
                this._public_ip = value;
            }
        }

        // Token: 0x0400001B RID: 27
        private string _ip;

        // Token: 0x0400001C RID: 28
        private int _port;

        // Token: 0x0400001D RID: 29
        private string _serverAlias;

        // Token: 0x0400001E RID: 30
        private string _version;

        // Token: 0x0400001F RID: 31
        private string _monitor_IP;

        // Token: 0x04000020 RID: 32
        private int _monitor_port;

        // Token: 0x04000021 RID: 33
        private string _ip_range_wlan;

        // Token: 0x04000022 RID: 34
        private string _public_ip;
    }
}
