using Ionic.Zip;
using System;

namespace GradeLib
{
    // Token: 0x02000002 RID: 2
    public class GivenExtract
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        public static bool Extract(string _pathZipFile, string _pathUnpack, ref string log)
        {
            bool result;
            try
            {
                using (ZipFile zipFile = ZipFile.Read(_pathZipFile))
                {
                    foreach (ZipEntry zipEntry in zipFile)
                    {
                        zipEntry.Extract(_pathUnpack, ExtractExistingFileAction.OverwriteSilently);
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {
                log = ex.Message;
                result = false;
            }
            return result;
        }
    }
}
