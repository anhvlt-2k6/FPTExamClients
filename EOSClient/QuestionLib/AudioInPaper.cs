using System;

namespace QuestionLib
{
    // Token: 0x0200000B RID: 11
    [Serializable]
    public class AudioInPaper : IComparable<AudioInPaper>
    {
        // Token: 0x1700002E RID: 46
        // (get) Token: 0x0600006E RID: 110 RVA: 0x00002750 File Offset: 0x00001750
        // (set) Token: 0x0600006F RID: 111 RVA: 0x00002768 File Offset: 0x00001768
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

        // Token: 0x1700002F RID: 47
        // (get) Token: 0x06000070 RID: 112 RVA: 0x00002774 File Offset: 0x00001774
        // (set) Token: 0x06000071 RID: 113 RVA: 0x0000278C File Offset: 0x0000178C
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

        // Token: 0x17000030 RID: 48
        // (get) Token: 0x06000072 RID: 114 RVA: 0x00002798 File Offset: 0x00001798
        // (set) Token: 0x06000073 RID: 115 RVA: 0x000027B0 File Offset: 0x000017B0
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

        // Token: 0x17000031 RID: 49
        // (get) Token: 0x06000074 RID: 116 RVA: 0x000027BC File Offset: 0x000017BC
        // (set) Token: 0x06000075 RID: 117 RVA: 0x000027D4 File Offset: 0x000017D4
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

        // Token: 0x17000032 RID: 50
        // (get) Token: 0x06000076 RID: 118 RVA: 0x000027E0 File Offset: 0x000017E0
        // (set) Token: 0x06000077 RID: 119 RVA: 0x000027F8 File Offset: 0x000017F8
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

        // Token: 0x17000033 RID: 51
        // (get) Token: 0x06000078 RID: 120 RVA: 0x00002804 File Offset: 0x00001804
        // (set) Token: 0x06000079 RID: 121 RVA: 0x0000281C File Offset: 0x0000181C
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

        // Token: 0x0600007A RID: 122 RVA: 0x00002828 File Offset: 0x00001828
        public int CompareTo(AudioInPaper aip)
        {
            return this.PlayOrder.CompareTo(aip.PlayOrder);
        }

        // Token: 0x04000036 RID: 54
        private int _audioSize;

        // Token: 0x04000037 RID: 55
        private byte[] _audioData;

        // Token: 0x04000038 RID: 56
        private int _audioLength;

        // Token: 0x04000039 RID: 57
        private byte _repeatTime;

        // Token: 0x0400003A RID: 58
        private int _paddingTime;

        // Token: 0x0400003B RID: 59
        private byte _playOrder;
    }
}
