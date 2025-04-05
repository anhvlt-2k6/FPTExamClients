using System;

namespace QuestionLib.Entity
{
    // Token: 0x0200000E RID: 14
    [Serializable]
    public class Audio
    {
        // Token: 0x06000090 RID: 144 RVA: 0x0000366E File Offset: 0x0000266E
        public Audio()
        {
            this._audioData = null;
        }

        // Token: 0x17000034 RID: 52
        // (get) Token: 0x06000091 RID: 145 RVA: 0x00003680 File Offset: 0x00002680
        // (set) Token: 0x06000092 RID: 146 RVA: 0x00003698 File Offset: 0x00002698
        public int AuID
        {
            get
            {
                return this._auID;
            }
            set
            {
                this._auID = value;
            }
        }

        // Token: 0x17000035 RID: 53
        // (get) Token: 0x06000093 RID: 147 RVA: 0x000036A4 File Offset: 0x000026A4
        // (set) Token: 0x06000094 RID: 148 RVA: 0x000036BC File Offset: 0x000026BC
        public int ChID
        {
            get
            {
                return this._chID;
            }
            set
            {
                this._chID = value;
            }
        }

        // Token: 0x17000036 RID: 54
        // (get) Token: 0x06000095 RID: 149 RVA: 0x000036C8 File Offset: 0x000026C8
        // (set) Token: 0x06000096 RID: 150 RVA: 0x000036E0 File Offset: 0x000026E0
        public string AudioFile
        {
            get
            {
                return this._audioFile;
            }
            set
            {
                this._audioFile = value;
            }
        }

        // Token: 0x17000037 RID: 55
        // (get) Token: 0x06000097 RID: 151 RVA: 0x000036EC File Offset: 0x000026EC
        // (set) Token: 0x06000098 RID: 152 RVA: 0x00003704 File Offset: 0x00002704
        public int AudioSize
        {
            get
            {
                return this._audioSize;
            }
            set
            {
                this._audioSize = value;
            }
        }

        // Token: 0x17000038 RID: 56
        // (get) Token: 0x06000099 RID: 153 RVA: 0x00003710 File Offset: 0x00002710
        // (set) Token: 0x0600009A RID: 154 RVA: 0x00003728 File Offset: 0x00002728
        public byte[] AudioData
        {
            get
            {
                return this._audioData;
            }
            set
            {
                this._audioData = value;
            }
        }

        // Token: 0x17000039 RID: 57
        // (get) Token: 0x0600009B RID: 155 RVA: 0x00003734 File Offset: 0x00002734
        // (set) Token: 0x0600009C RID: 156 RVA: 0x0000374C File Offset: 0x0000274C
        public int AudioLength
        {
            get
            {
                return this._audioLength;
            }
            set
            {
                this._audioLength = value;
            }
        }

        // Token: 0x1700003A RID: 58
        // (get) Token: 0x0600009D RID: 157 RVA: 0x00003758 File Offset: 0x00002758
        // (set) Token: 0x0600009E RID: 158 RVA: 0x00003770 File Offset: 0x00002770
        public byte RepeatTime
        {
            get
            {
                return this._repeatTime;
            }
            set
            {
                this._repeatTime = value;
            }
        }

        // Token: 0x1700003B RID: 59
        // (get) Token: 0x0600009F RID: 159 RVA: 0x0000377C File Offset: 0x0000277C
        // (set) Token: 0x060000A0 RID: 160 RVA: 0x00003794 File Offset: 0x00002794
        public int PaddingTime
        {
            get
            {
                return this._paddingTime;
            }
            set
            {
                this._paddingTime = value;
            }
        }

        // Token: 0x1700003C RID: 60
        // (get) Token: 0x060000A1 RID: 161 RVA: 0x000037A0 File Offset: 0x000027A0
        // (set) Token: 0x060000A2 RID: 162 RVA: 0x000037B8 File Offset: 0x000027B8
        public byte PlayOrder
        {
            get
            {
                return this._playOrder;
            }
            set
            {
                this._playOrder = value;
            }
        }

        // Token: 0x0400004D RID: 77
        private int _auID;

        // Token: 0x0400004E RID: 78
        private int _chID;

        // Token: 0x0400004F RID: 79
        private string _audioFile;

        // Token: 0x04000050 RID: 80
        private int _audioSize;

        // Token: 0x04000051 RID: 81
        private byte[] _audioData;

        // Token: 0x04000052 RID: 82
        private int _audioLength;

        // Token: 0x04000053 RID: 83
        private byte _repeatTime;

        // Token: 0x04000054 RID: 84
        private int _paddingTime;

        // Token: 0x04000055 RID: 85
        private byte _playOrder;
    }
}
