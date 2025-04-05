using QuestionLib.Entity;
using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;

namespace QuestionLib
{
    // Token: 0x0200000C RID: 12
    public class QuestionHelper
    {
        // Token: 0x0600007C RID: 124 RVA: 0x00002850 File Offset: 0x00001850
        public static void SaveSubmitPaper(string folder, SubmitPaper submitPaper)
        {
            submitPaper.SubmitTime = DateTime.Now;
            string fname = folder + submitPaper.LoginId + ".dat";
            FileStream fs = new FileStream(fname, FileMode.Create, FileAccess.Write);
            BinaryFormatter sf = new BinaryFormatter();
            sf.Serialize(fs, submitPaper);
            fs.Flush();
            fs.Close();
        }

        // Token: 0x0600007D RID: 125 RVA: 0x000028A4 File Offset: 0x000018A4
        public static SubmitPaper LoadSubmitPaper(string savedFile)
        {
            SubmitPaper result;
            try
            {
                FileStream fs = new FileStream(savedFile, FileMode.Open, FileAccess.Read);
                BinaryFormatter sf = new BinaryFormatter();
                SubmitPaper submitPaper = (SubmitPaper)sf.Deserialize(fs);
                fs.Close();
                result = submitPaper;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = null;
            }
            return result;
        }

        // Token: 0x0600007E RID: 126 RVA: 0x00002900 File Offset: 0x00001900
        private static Passage GetPassage(Paper oPaper, int pid)
        {
            foreach (object obj in oPaper.ReadingQuestions)
            {
                Passage p = (Passage)obj;
                bool flag = p.PID == pid;
                if (flag)
                {
                    return p;
                }
            }
            return null;
        }

        // Token: 0x0600007F RID: 127 RVA: 0x00002974 File Offset: 0x00001974
        private static bool ReConstructQuestion(Question sq, Question oq)
        {
            bool flag = sq.QID == oq.QID;
            bool result;
            if (flag)
            {
                sq.QBID = oq.QBID;
                sq.CourseId = oq.CourseId;
                sq.Text = oq.Text;
                sq.Mark = oq.Mark;
                sq.ImageData = oq.ImageData;
                sq.ImageSize = oq.ImageSize;
                bool isFillBlank = false;
                bool flag2 = sq.QType == QuestionType.FILL_BLANK_ALL;
                if (flag2)
                {
                    isFillBlank = true;
                }
                bool flag3 = sq.QType == QuestionType.FILL_BLANK_GROUP;
                if (flag3)
                {
                    isFillBlank = true;
                }
                bool flag4 = sq.QType == QuestionType.FILL_BLANK_EMPTY;
                if (flag4)
                {
                    isFillBlank = true;
                }
                foreach (object obj in sq.QuestionAnswers)
                {
                    QuestionAnswer sqa = (QuestionAnswer)obj;
                    foreach (object obj2 in oq.QuestionAnswers)
                    {
                        QuestionAnswer oqa = (QuestionAnswer)obj2;
                        bool flag5 = sqa.QAID == oqa.QAID;
                        if (flag5)
                        {
                            bool flag6 = isFillBlank;
                            if (flag6)
                            {
                                string s = QuestionHelper.RemoveSpaces(sqa.Text).Trim().ToLower();
                                string s2 = QuestionHelper.RemoveSpaces(oqa.Text).Trim().ToLower();
                                bool flag7 = s.Equals(s2);
                                if (flag7)
                                {
                                    sqa.Chosen = true;
                                    sqa.Selected = true;
                                }
                            }
                            else
                            {
                                sqa.Text = oqa.Text;
                                sqa.Chosen = oqa.Chosen;
                            }
                            break;
                        }
                    }
                }
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        // Token: 0x06000080 RID: 128 RVA: 0x00002B80 File Offset: 0x00001B80
        private static void ReConstructEssay(EssayQuestion sEssay, EssayQuestion oEssay)
        {
            bool flag = sEssay.EQID == oEssay.EQID;
            if (flag)
            {
                sEssay.QBID = oEssay.QBID;
                sEssay.CourseId = oEssay.CourseId;
                sEssay.Question = oEssay.Question;
            }
        }

        // Token: 0x06000081 RID: 129 RVA: 0x00002BC9 File Offset: 0x00001BC9
        private static void ReConstructImagePaper(ImagePaper sIP, ImagePaper oIP)
        {
            sIP.Image = oIP.Image;
        }

        // Token: 0x06000082 RID: 130 RVA: 0x00002BDC File Offset: 0x00001BDC
        public static Paper Re_ConstructPaper(Paper oPaper, SubmitPaper submitPaper)
        {
            Paper sPaper = submitPaper.SPaper;
            foreach (object obj in sPaper.ReadingQuestions)
            {
                Passage sp = (Passage)obj;
                Passage op = QuestionHelper.GetPassage(oPaper, sp.PID);
                sp.QBID = op.QBID;
                sp.Text = op.Text;
                sp.CourseId = op.CourseId;
                foreach (object obj2 in sp.PassageQuestions)
                {
                    Question sq = (Question)obj2;
                    foreach (object obj3 in op.PassageQuestions)
                    {
                        Question oq = (Question)obj3;
                        bool flag = QuestionHelper.ReConstructQuestion(sq, oq);
                        if (flag)
                        {
                            break;
                        }
                    }
                }
            }
            foreach (object obj4 in sPaper.MatchQuestions)
            {
                MatchQuestion sm = (MatchQuestion)obj4;
                foreach (object obj5 in oPaper.MatchQuestions)
                {
                    MatchQuestion om = (MatchQuestion)obj5;
                    bool flag2 = sm.MID == om.MID;
                    if (flag2)
                    {
                        sm.QBID = om.QBID;
                        sm.CourseId = om.CourseId;
                        sm.ColumnA = om.ColumnA;
                        sm.ColumnB = om.ColumnB;
                        sm.Solution = om.Solution;
                        sm.Mark = om.Mark;
                        break;
                    }
                }
            }
            foreach (object obj6 in sPaper.GrammarQuestions)
            {
                Question sq2 = (Question)obj6;
                foreach (object obj7 in oPaper.GrammarQuestions)
                {
                    Question oq2 = (Question)obj7;
                    bool flag3 = QuestionHelper.ReConstructQuestion(sq2, oq2);
                    if (flag3)
                    {
                        break;
                    }
                }
            }
            foreach (object obj8 in sPaper.IndicateMQuestions)
            {
                Question sq3 = (Question)obj8;
                foreach (object obj9 in oPaper.IndicateMQuestions)
                {
                    Question oq3 = (Question)obj9;
                    bool flag4 = QuestionHelper.ReConstructQuestion(sq3, oq3);
                    if (flag4)
                    {
                        break;
                    }
                }
            }
            foreach (object obj10 in sPaper.FillBlankQuestions)
            {
                Question sq4 = (Question)obj10;
                foreach (object obj11 in oPaper.FillBlankQuestions)
                {
                    Question oq4 = (Question)obj11;
                    bool flag5 = QuestionHelper.ReConstructQuestion(sq4, oq4);
                    if (flag5)
                    {
                        break;
                    }
                }
            }
            bool flag6 = oPaper.EssayQuestion != null;
            if (flag6)
            {
                QuestionHelper.ReConstructEssay(sPaper.EssayQuestion, oPaper.EssayQuestion);
            }
            bool flag7 = oPaper.ImgPaper != null;
            if (flag7)
            {
                QuestionHelper.ReConstructImagePaper(sPaper.ImgPaper, oPaper.ImgPaper);
            }
            sPaper.OneSecSilence = oPaper.OneSecSilence;
            sPaper.ListAudio = oPaper.ListAudio;
            return sPaper;
        }

        // Token: 0x06000083 RID: 131 RVA: 0x000030A4 File Offset: 0x000020A4
        public static string RemoveSpaces(string s)
        {
            s = s.Trim();
            string temp;
            do
            {
                temp = s;
                s = s.Replace("  ", " ");
            }
            while (s.Length != temp.Length);
            return s;
        }

        // Token: 0x06000084 RID: 132 RVA: 0x000030EC File Offset: 0x000020EC
        public static string RemoveAllSpaces(string s)
        {
            s = s.Trim();
            string temp;
            do
            {
                temp = s;
                s = s.Replace(" ", "");
            }
            while (s.Length != temp.Length);
            return s;
        }

        // Token: 0x06000085 RID: 133 RVA: 0x00003134 File Offset: 0x00002134
        public static bool IsFillBlank(QuestionType qt)
        {
            bool flag = qt == QuestionType.FILL_BLANK_ALL;
            bool result;
            if (flag)
            {
                result = true;
            }
            else
            {
                bool flag2 = qt == QuestionType.FILL_BLANK_GROUP;
                if (flag2)
                {
                    result = true;
                }
                else
                {
                    bool flag3 = qt == QuestionType.FILL_BLANK_EMPTY;
                    result = flag3;
                }
            }
            return result;
        }

        // Token: 0x06000086 RID: 134 RVA: 0x0000316C File Offset: 0x0000216C
        private static string RemoveNewLine(string s)
        {
            s = s.Replace(Environment.NewLine, "");
            s = QuestionHelper.RemoveSpaces(s);
            return s;
        }

        // Token: 0x06000087 RID: 135 RVA: 0x0000319C File Offset: 0x0000219C
        public static string WordWrap(string str, int width)
        {
            string pattern = QuestionHelper.fillBlank_Pattern;
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            MatchCollection mc = r.Matches(str);
            str = r.Replace(str, "(###)");
            string[] lines = QuestionHelper.SplitLines(str);
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                bool flag = i < lines.Length - 1;
                if (flag)
                {
                    line = lines[i] + Environment.NewLine;
                }
                ArrayList words = QuestionHelper.Explode(line, QuestionHelper.splitChars);
                int curLineLength = 0;
                for (int j = 0; j < words.Count; j++)
                {
                    string word = (string)words[j];
                    bool flag2 = curLineLength + word.Length > width;
                    if (flag2)
                    {
                        bool flag3 = curLineLength > 0;
                        if (flag3)
                        {
                            bool flag4 = !strBuilder.ToString().EndsWith(Environment.NewLine);
                            if (flag4)
                            {
                                strBuilder.Append(Environment.NewLine);
                            }
                            curLineLength = 0;
                        }
                        while (word.Length > width)
                        {
                            strBuilder.Append(word.Substring(0, width - 1) + "-");
                            word = word.Substring(width - 1);
                            bool flag5 = !strBuilder.ToString().EndsWith(Environment.NewLine);
                            if (flag5)
                            {
                                strBuilder.Append(Environment.NewLine);
                            }
                            strBuilder.Append(Environment.NewLine);
                        }
                        word = word.TrimStart(new char[0]);
                    }
                    strBuilder.Append(word);
                    curLineLength += word.Length;
                }
            }
            str = strBuilder.ToString();
            pattern = "\\(###\\)";
            r = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            for (int k = 0; k < mc.Count; k++)
            {
                string ans = QuestionHelper.RemoveNewLine(mc[k].Value);
                str = r.Replace(str, ans, 1);
            }
            return str;
        }

        // Token: 0x06000088 RID: 136 RVA: 0x000033AC File Offset: 0x000023AC
        private static ArrayList Explode(string str, char[] splitChars)
        {
            ArrayList parts = new ArrayList();
            int startIndex = 0;
            for (; ; )
            {
                int index = str.IndexOfAny(splitChars, startIndex);
                bool flag = index == -1;
                if (flag)
                {
                    break;
                }
                string word = str.Substring(startIndex, index - startIndex);
                char nextChar = str.Substring(index, 1)[0];
                bool flag2 = char.IsWhiteSpace(nextChar);
                if (flag2)
                {
                    parts.Add(word);
                    parts.Add(nextChar.ToString());
                }
                else
                {
                    parts.Add(word + nextChar.ToString());
                }
                startIndex = index + 1;
            }
            parts.Add(str.Substring(startIndex));
            return parts;
        }

        // Token: 0x06000089 RID: 137 RVA: 0x00003458 File Offset: 0x00002458
        private static string[] SplitLines(string str)
        {
            string pattern = Environment.NewLine;
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
            return r.Split(str);
        }

        // Token: 0x0600008A RID: 138 RVA: 0x00003480 File Offset: 0x00002480
        public static string[] GetFillBlankWord(string text)
        {
            string pattern = QuestionHelper.fillBlank_Pattern;
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            MatchCollection mc = r.Matches(text);
            string[] temp = new string[mc.Count];
            for (int i = 0; i < mc.Count; i++)
            {
                string val = mc[i].Value.Remove(0, 1);
                val = val.Remove(val.Length - 1, 1);
                temp[i] = val;
            }
            return temp;
        }

        // Token: 0x0600008B RID: 139 RVA: 0x00003504 File Offset: 0x00002504
        public static string Sec2TimeString(int sec)
        {
            int h = sec / 3600;
            int i = sec % 3600 / 60;
            int s = sec % 60;
            string hS = "0" + h;
            hS = hS.Substring(hS.Length - 2, 2);
            string mS = "0" + i;
            mS = mS.Substring(mS.Length - 2, 2);
            string sS = "0" + s;
            sS = sS.Substring(sS.Length - 2, 2);
            return string.Concat(new string[]
            {
                hS,
                ":",
                mS,
                ":",
                sS
            });
        }

        // Token: 0x0400003C RID: 60
        public static char[] lo_deli = new char[]
        {
            ';'
        };

        // Token: 0x0400003D RID: 61
        public static string[] MultipleChoiceQuestionType = new string[]
        {
            "Grammar",
            "Indicate Mistake"
        };

        // Token: 0x0400003E RID: 62
        public static string fillBlank_Pattern = "\\([0-9a-zA-Z;:=?<>/`,'’ .+_~!@#$%^&*\\r\\n-]+\\)";

        // Token: 0x0400003F RID: 63
        private static char[] splitChars = new char[]
        {
            ' ',
            '-',
            '\t'
        };

        // Token: 0x04000040 RID: 64
        public static int LineWidth = 100;
    }
}
