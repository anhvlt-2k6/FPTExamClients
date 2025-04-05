using QuestionLib.Entity;
using System;
using System.Collections;
using System.Collections.Generic;

namespace QuestionLib
{
    // Token: 0x02000006 RID: 6
    [Serializable]
    public class Paper
    {
        // Token: 0x17000006 RID: 6
        // (get) Token: 0x06000014 RID: 20 RVA: 0x000021FC File Offset: 0x000011FC
        // (set) Token: 0x06000015 RID: 21 RVA: 0x00002214 File Offset: 0x00001214
        public bool IsShuffleReading
        {
            get
            {
                return this._isShuffleReading;
            }
            set
            {
                this._isShuffleReading = value;
            }
        }

        // Token: 0x17000007 RID: 7
        // (get) Token: 0x06000016 RID: 22 RVA: 0x00002220 File Offset: 0x00001220
        // (set) Token: 0x06000017 RID: 23 RVA: 0x00002238 File Offset: 0x00001238
        public bool IsShuffleGrammer
        {
            get
            {
                return this._isShuffleGrammer;
            }
            set
            {
                this._isShuffleGrammer = value;
            }
        }

        // Token: 0x17000008 RID: 8
        // (get) Token: 0x06000018 RID: 24 RVA: 0x00002244 File Offset: 0x00001244
        // (set) Token: 0x06000019 RID: 25 RVA: 0x0000225C File Offset: 0x0000125C
        public bool IsShuffleMatch
        {
            get
            {
                return this._isShuffleMatch;
            }
            set
            {
                this._isShuffleMatch = value;
            }
        }

        // Token: 0x17000009 RID: 9
        // (get) Token: 0x0600001A RID: 26 RVA: 0x00002266 File Offset: 0x00001266
        // (set) Token: 0x0600001B RID: 27 RVA: 0x0000226E File Offset: 0x0000126E
        public QuestionDistribution QD { get; set; }

        // Token: 0x1700000A RID: 10
        // (get) Token: 0x0600001C RID: 28 RVA: 0x00002278 File Offset: 0x00001278
        // (set) Token: 0x0600001D RID: 29 RVA: 0x00002290 File Offset: 0x00001290
        public bool IsShuffleIndicateMistake
        {
            get
            {
                return this._isShuffleIndicateMistake;
            }
            set
            {
                this._isShuffleIndicateMistake = value;
            }
        }

        // Token: 0x1700000B RID: 11
        // (get) Token: 0x0600001E RID: 30 RVA: 0x0000229C File Offset: 0x0000129C
        // (set) Token: 0x0600001F RID: 31 RVA: 0x000022B4 File Offset: 0x000012B4
        public bool IsShuffleFillBlank
        {
            get
            {
                return this._isShuffleFillBlank;
            }
            set
            {
                this._isShuffleFillBlank = value;
            }
        }

        // Token: 0x06000020 RID: 32 RVA: 0x000022C0 File Offset: 0x000012C0
        public Paper()
        {
            this._reading = new ArrayList();
            this._grammar = new ArrayList();
            this._match = new ArrayList();
            this._indicateMistake = new ArrayList();
            this._fillBlank = new ArrayList();
            this.TestType = TestTypeEnum.NOT_WRITING;
        }

        // Token: 0x1700000C RID: 12
        // (get) Token: 0x06000021 RID: 33 RVA: 0x00002314 File Offset: 0x00001314
        // (set) Token: 0x06000022 RID: 34 RVA: 0x0000232C File Offset: 0x0000132C
        public int Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }

        // Token: 0x1700000D RID: 13
        // (get) Token: 0x06000023 RID: 35 RVA: 0x00002338 File Offset: 0x00001338
        // (set) Token: 0x06000024 RID: 36 RVA: 0x00002350 File Offset: 0x00001350
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

        // Token: 0x1700000E RID: 14
        // (get) Token: 0x06000025 RID: 37 RVA: 0x0000235C File Offset: 0x0000135C
        // (set) Token: 0x06000026 RID: 38 RVA: 0x00002374 File Offset: 0x00001374
        public float Mark
        {
            get
            {
                return this._mark;
            }
            set
            {
                this._mark = value;
            }
        }

        // Token: 0x1700000F RID: 15
        // (get) Token: 0x06000027 RID: 39 RVA: 0x00002380 File Offset: 0x00001380
        // (set) Token: 0x06000028 RID: 40 RVA: 0x00002398 File Offset: 0x00001398
        public int NoOfQuestion
        {
            get
            {
                return this._noOfQuestion;
            }
            set
            {
                this._noOfQuestion = value;
            }
        }

        // Token: 0x17000010 RID: 16
        // (get) Token: 0x06000029 RID: 41 RVA: 0x000023A4 File Offset: 0x000013A4
        // (set) Token: 0x0600002A RID: 42 RVA: 0x000023BC File Offset: 0x000013BC
        public ArrayList ReadingQuestions
        {
            get
            {
                return this._reading;
            }
            set
            {
                this._reading = value;
            }
        }

        // Token: 0x17000011 RID: 17
        // (get) Token: 0x0600002B RID: 43 RVA: 0x000023C8 File Offset: 0x000013C8
        // (set) Token: 0x0600002C RID: 44 RVA: 0x000023E0 File Offset: 0x000013E0
        public ArrayList GrammarQuestions
        {
            get
            {
                return this._grammar;
            }
            set
            {
                this._grammar = value;
            }
        }

        // Token: 0x17000012 RID: 18
        // (get) Token: 0x0600002D RID: 45 RVA: 0x000023EC File Offset: 0x000013EC
        // (set) Token: 0x0600002E RID: 46 RVA: 0x00002404 File Offset: 0x00001404
        public ArrayList MatchQuestions
        {
            get
            {
                return this._match;
            }
            set
            {
                this._match = value;
            }
        }

        // Token: 0x17000013 RID: 19
        // (get) Token: 0x0600002F RID: 47 RVA: 0x00002410 File Offset: 0x00001410
        // (set) Token: 0x06000030 RID: 48 RVA: 0x00002428 File Offset: 0x00001428
        public ArrayList IndicateMQuestions
        {
            get
            {
                return this._indicateMistake;
            }
            set
            {
                this._indicateMistake = value;
            }
        }

        // Token: 0x17000014 RID: 20
        // (get) Token: 0x06000031 RID: 49 RVA: 0x00002434 File Offset: 0x00001434
        // (set) Token: 0x06000032 RID: 50 RVA: 0x0000244C File Offset: 0x0000144C
        public ArrayList FillBlankQuestions
        {
            get
            {
                return this._fillBlank;
            }
            set
            {
                this._fillBlank = value;
            }
        }

        // Token: 0x17000015 RID: 21
        // (get) Token: 0x06000033 RID: 51 RVA: 0x00002458 File Offset: 0x00001458
        // (set) Token: 0x06000034 RID: 52 RVA: 0x00002470 File Offset: 0x00001470
        public EssayQuestion EssayQuestion
        {
            get
            {
                return this._essay;
            }
            set
            {
                this._essay = value;
            }
        }

        // Token: 0x17000016 RID: 22
        // (get) Token: 0x06000035 RID: 53 RVA: 0x0000247C File Offset: 0x0000147C
        // (set) Token: 0x06000036 RID: 54 RVA: 0x00002494 File Offset: 0x00001494
        public string StudentGuide
        {
            get
            {
                return this._studentGuide;
            }
            set
            {
                this._studentGuide = value;
            }
        }

        // Token: 0x17000017 RID: 23
        // (get) Token: 0x06000037 RID: 55 RVA: 0x000024A0 File Offset: 0x000014A0
        // (set) Token: 0x06000038 RID: 56 RVA: 0x000024B8 File Offset: 0x000014B8
        public string ListenCode
        {
            get
            {
                return this._listenCode;
            }
            set
            {
                this._listenCode = value;
            }
        }

        // Token: 0x17000018 RID: 24
        // (get) Token: 0x06000039 RID: 57 RVA: 0x000024C4 File Offset: 0x000014C4
        // (set) Token: 0x0600003A RID: 58 RVA: 0x000024DC File Offset: 0x000014DC
        public string Password
        {
            get
            {
                return this._pwd;
            }
            set
            {
                this._pwd = value;
            }
        }

        // Token: 0x17000019 RID: 25
        // (get) Token: 0x0600003B RID: 59 RVA: 0x000024E8 File Offset: 0x000014E8
        // (set) Token: 0x0600003C RID: 60 RVA: 0x00002500 File Offset: 0x00001500
        public TestTypeEnum TestType
        {
            get
            {
                return this._testType;
            }
            set
            {
                this._testType = value;
            }
        }

        // Token: 0x1700001A RID: 26
        // (get) Token: 0x0600003D RID: 61 RVA: 0x0000250C File Offset: 0x0000150C
        // (set) Token: 0x0600003E RID: 62 RVA: 0x00002524 File Offset: 0x00001524
        public ImageRef ImgRef
        {
            get
            {
                return this._imageRef;
            }
            set
            {
                this._imageRef = value;
            }
        }

        // Token: 0x1700001B RID: 27
        // (get) Token: 0x0600003F RID: 63 RVA: 0x00002530 File Offset: 0x00001530
        // (set) Token: 0x06000040 RID: 64 RVA: 0x00002548 File Offset: 0x00001548
        public ImagePaper ImgPaper
        {
            get
            {
                return this._imagePaper;
            }
            set
            {
                this._imagePaper = value;
            }
        }

        // Token: 0x1700001C RID: 28
        // (get) Token: 0x06000041 RID: 65 RVA: 0x00002554 File Offset: 0x00001554
        // (set) Token: 0x06000042 RID: 66 RVA: 0x0000256C File Offset: 0x0000156C
        public List<AudioInPaper> ListAudio
        {
            get
            {
                return this._listAudio;
            }
            set
            {
                this._listAudio = value;
            }
        }

        // Token: 0x1700001D RID: 29
        // (get) Token: 0x06000043 RID: 67 RVA: 0x00002578 File Offset: 0x00001578
        // (set) Token: 0x06000044 RID: 68 RVA: 0x00002590 File Offset: 0x00001590
        public byte[] OneSecSilence
        {
            get
            {
                return this._oneSecSilence;
            }
            set
            {
                this._oneSecSilence = value;
            }
        }

        // Token: 0x1700001E RID: 30
        // (get) Token: 0x06000045 RID: 69 RVA: 0x0000259C File Offset: 0x0000159C
        // (set) Token: 0x06000046 RID: 70 RVA: 0x000025B4 File Offset: 0x000015B4
        public int AudioHeadPadding
        {
            get
            {
                return this._audioHeadPadding;
            }
            set
            {
                this._audioHeadPadding = value;
            }
        }

        // Token: 0x0400000E RID: 14
        private TestTypeEnum _testType;

        // Token: 0x0400000F RID: 15
        private string _examCode;

        // Token: 0x04000010 RID: 16
        private int _duration;

        // Token: 0x04000011 RID: 17
        private float _mark;

        // Token: 0x04000012 RID: 18
        private int _noOfQuestion;

        // Token: 0x04000013 RID: 19
        private ArrayList _reading;

        // Token: 0x04000014 RID: 20
        private ArrayList _grammar;

        // Token: 0x04000015 RID: 21
        private ArrayList _match;

        // Token: 0x04000016 RID: 22
        private ArrayList _indicateMistake;

        // Token: 0x04000017 RID: 23
        private ArrayList _fillBlank;

        // Token: 0x04000018 RID: 24
        private EssayQuestion _essay;

        // Token: 0x04000019 RID: 25
        private bool _isShuffleReading;

        // Token: 0x0400001A RID: 26
        private bool _isShuffleGrammer;

        // Token: 0x0400001B RID: 27
        private bool _isShuffleMatch;

        // Token: 0x0400001C RID: 28
        private bool _isShuffleIndicateMistake;

        // Token: 0x0400001D RID: 29
        private bool _isShuffleFillBlank;

        // Token: 0x0400001E RID: 30
        private string _studentGuide;

        // Token: 0x0400001F RID: 31
        private string _listenCode;

        // Token: 0x04000020 RID: 32
        private string _pwd;

        // Token: 0x04000021 RID: 33
        private List<AudioInPaper> _listAudio;

        // Token: 0x04000022 RID: 34
        private byte[] _oneSecSilence;

        // Token: 0x04000023 RID: 35
        private int _audioHeadPadding;

        // Token: 0x04000024 RID: 36
        private ImageRef _imageRef;

        // Token: 0x04000025 RID: 37
        private ImagePaper _imagePaper;
    }
}
