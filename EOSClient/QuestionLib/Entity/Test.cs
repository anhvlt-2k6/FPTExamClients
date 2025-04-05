namespace QuestionLib.Entity
{
    // Token: 0x0200001A RID: 26
    public class Test
    {
        // Token: 0x17000082 RID: 130
        // (get) Token: 0x06000146 RID: 326 RVA: 0x000043E4 File Offset: 0x000033E4
        // (set) Token: 0x06000147 RID: 327 RVA: 0x000043FC File Offset: 0x000033FC
        public string TestId
        {
            get
            {
                return this._testId;
            }
            set
            {
                this._testId = value;
            }
        }

        // Token: 0x17000083 RID: 131
        // (get) Token: 0x06000148 RID: 328 RVA: 0x00004408 File Offset: 0x00003408
        // (set) Token: 0x06000149 RID: 329 RVA: 0x00004420 File Offset: 0x00003420
        public string CourseId
        {
            get
            {
                return this._courseId;
            }
            set
            {
                this._courseId = value;
            }
        }

        // Token: 0x17000084 RID: 132
        // (get) Token: 0x0600014A RID: 330 RVA: 0x0000442C File Offset: 0x0000342C
        // (set) Token: 0x0600014B RID: 331 RVA: 0x00004444 File Offset: 0x00003444
        public string Questions
        {
            get
            {
                return this._questions;
            }
            set
            {
                this._questions = value;
            }
        }

        // Token: 0x17000085 RID: 133
        // (get) Token: 0x0600014C RID: 332 RVA: 0x00004450 File Offset: 0x00003450
        // (set) Token: 0x0600014D RID: 333 RVA: 0x00004468 File Offset: 0x00003468
        public int NumOfQuestion
        {
            get
            {
                return this._numOfQuestion;
            }
            set
            {
                this._numOfQuestion = value;
            }
        }

        // Token: 0x17000086 RID: 134
        // (get) Token: 0x0600014E RID: 334 RVA: 0x00004474 File Offset: 0x00003474
        // (set) Token: 0x0600014F RID: 335 RVA: 0x0000448C File Offset: 0x0000348C
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

        // Token: 0x17000087 RID: 135
        // (get) Token: 0x06000150 RID: 336 RVA: 0x00004498 File Offset: 0x00003498
        // (set) Token: 0x06000151 RID: 337 RVA: 0x000044B0 File Offset: 0x000034B0
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

        // Token: 0x040000A3 RID: 163
        private string _testId;

        // Token: 0x040000A4 RID: 164
        private string _courseId;

        // Token: 0x040000A5 RID: 165
        private string _questions;

        // Token: 0x040000A6 RID: 166
        private int _numOfQuestion;

        // Token: 0x040000A7 RID: 167
        private float _mark;

        // Token: 0x040000A8 RID: 168
        private string _studentGuide;
    }
}
