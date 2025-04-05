using Ionic.Zip;
using System.IO;

namespace GradeLib
{
    // Token: 0x02000007 RID: 7
    public class SolutionZip
    {
        // Token: 0x06000021 RID: 33 RVA: 0x0000228C File Offset: 0x0000048C
        public static byte[] CreateZip(string solutionPath, string zipFileName)
        {
            bool flag = Directory.Exists(solutionPath);
            byte[] result;
            if (flag)
            {
                string[] files = Directory.GetFiles(solutionPath, "*", SearchOption.AllDirectories);
                long num = 0L;
                foreach (string fileName in files)
                {
                    FileInfo fileInfo = new FileInfo(fileName);
                    num += fileInfo.Length;
                }
                bool flag2 = num > 20971520L || num == 0L;
                if (flag2)
                {
                    result = null;
                }
                else
                {
                    using (ZipFile zipFile = new ZipFile())
                    {
                        zipFile.AddDirectory(solutionPath);
                        zipFile.Comment = "comment";
                        zipFile.Save(zipFileName);
                    }
                    byte[] array2 = File.ReadAllBytes(zipFileName);
                    result = array2;
                }
            }
            else
            {
                result = null;
            }
            return result;
        }
    }
}
