using System;
using System.Collections.Generic;
using System.IO;

namespace GradeLib
{
    // Token: 0x0200000A RID: 10
    [Serializable]
    public class TestCase
    {
        // Token: 0x17000012 RID: 18
        // (get) Token: 0x06000030 RID: 48 RVA: 0x000023E8 File Offset: 0x000005E8
        // (set) Token: 0x06000031 RID: 49 RVA: 0x000023F0 File Offset: 0x000005F0
        public string TestCaseCode { get; set; }

        // Token: 0x17000013 RID: 19
        // (get) Token: 0x06000032 RID: 50 RVA: 0x000023F9 File Offset: 0x000005F9
        // (set) Token: 0x06000033 RID: 51 RVA: 0x00002401 File Offset: 0x00000601
        public List<string> Input { get; set; }

        // Token: 0x17000014 RID: 20
        // (get) Token: 0x06000034 RID: 52 RVA: 0x0000240A File Offset: 0x0000060A
        // (set) Token: 0x06000035 RID: 53 RVA: 0x00002412 File Offset: 0x00000612
        public string Output { get; set; }

        // Token: 0x17000015 RID: 21
        // (get) Token: 0x06000036 RID: 54 RVA: 0x0000241B File Offset: 0x0000061B
        // (set) Token: 0x06000037 RID: 55 RVA: 0x00002423 File Offset: 0x00000623
        public float Mark { get; set; }

        // Token: 0x17000016 RID: 22
        // (get) Token: 0x06000038 RID: 56 RVA: 0x0000242C File Offset: 0x0000062C
        // (set) Token: 0x06000039 RID: 57 RVA: 0x00002434 File Offset: 0x00000634
        public bool IsCaseSensitive { get; set; }

        // Token: 0x17000017 RID: 23
        // (get) Token: 0x0600003A RID: 58 RVA: 0x0000243D File Offset: 0x0000063D
        // (set) Token: 0x0600003B RID: 59 RVA: 0x00002445 File Offset: 0x00000645
        public bool RemoveSpaces { get; set; }

        // Token: 0x0600003C RID: 60 RVA: 0x0000244E File Offset: 0x0000064E
        public TestCase()
        {
            this.Input = new List<string>();
            this.Output = "";
        }

        // Token: 0x0600003D RID: 61 RVA: 0x00002470 File Offset: 0x00000670
        public bool Validate()
        {
            return this.Input.Count > 0 && this.Mark > 0f;
        }

        // Token: 0x0600003E RID: 62 RVA: 0x000024A0 File Offset: 0x000006A0
        private static TestCase File2TestCase(string filePath)
        {
            TestCase testCase = new TestCase();
            StreamReader streamReader = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read));
            string text = "";
            string text2;
            while ((text2 = streamReader.ReadLine()) != null)
            {
                text2 = text2.Trim();
                bool flag = text2.ToUpper().StartsWith("INPUT:");
                if (flag)
                {
                    text = "INPUT:";
                }
                else
                {
                    bool flag2 = text2.ToUpper().StartsWith("OUTPUT:");
                    if (flag2)
                    {
                        text = "OUTPUT:";
                    }
                    else
                    {
                        bool flag3 = text2.ToUpper().StartsWith("REMOVE_SPACES:");
                        if (flag3)
                        {
                            text = "REMOVE_SPACES:";
                        }
                        else
                        {
                            bool flag4 = text2.ToUpper().StartsWith("CASE_SENSITIVE:");
                            if (flag4)
                            {
                                text = "CASE_SENSITIVE:";
                            }
                            else
                            {
                                bool flag5 = text2.ToUpper().StartsWith("MARK:");
                                if (flag5)
                                {
                                    text = "MARK:";
                                }
                                else
                                {
                                    bool flag6 = text.Equals("INPUT:");
                                    if (flag6)
                                    {
                                        testCase.Input.Add(text2);
                                    }
                                    bool flag7 = text.Equals("OUTPUT:");
                                    if (flag7)
                                    {
                                        TestCase testCase2 = testCase;
                                        testCase2.Output = testCase2.Output + text2 + "\n";
                                    }
                                    bool flag8 = text.Equals("REMOVE_SPACES:");
                                    if (flag8)
                                    {
                                        testCase.RemoveSpaces = text2.ToUpper().Equals("YES");
                                    }
                                    bool flag9 = text.Equals("CASE_SENSITIVE:");
                                    if (flag9)
                                    {
                                        testCase.IsCaseSensitive = text2.ToUpper().Equals("YES");
                                    }
                                    bool flag10 = text.Equals("MARK:");
                                    if (flag10)
                                    {
                                        testCase.Mark = Convert.ToSingle(text2);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            streamReader.Close();
            testCase.Output = testCase.Output.Trim();
            testCase.TestCaseCode = Path.GetFileName(filePath);
            return testCase;
        }

        // Token: 0x0600003F RID: 63 RVA: 0x0000267C File Offset: 0x0000087C
        public static List<TestCase> LoadTestCase(string tcFolder)
        {
            List<TestCase> list = new List<TestCase>();
            string[] files = Directory.GetFiles(tcFolder);
            foreach (string filePath in files)
            {
                TestCase item = TestCase.File2TestCase(filePath);
                list.Add(item);
            }
            return list;
        }
    }
}
