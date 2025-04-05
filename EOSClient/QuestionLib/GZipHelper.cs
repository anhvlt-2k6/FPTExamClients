using System.IO;
using System.IO.Compression;

namespace QuestionLib
{
    // Token: 0x02000002 RID: 2
    public class GZipHelper
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
        public static byte[] Compress(byte[] bytData)
        {
            byte[] result;
            try
            {
                MemoryStream ms = new MemoryStream();
                Stream s = new GZipStream(ms, CompressionMode.Compress);
                s.Write(bytData, 0, bytData.Length);
                s.Close();
                byte[] compressedData = ms.ToArray();
                result = compressedData;
            }
            catch
            {
                result = null;
            }
            return result;
        }

        // Token: 0x06000002 RID: 2 RVA: 0x000020A4 File Offset: 0x000010A4
        public static byte[] DeCompress(byte[] bytInput, int originSize)
        {
            Stream s = new GZipStream(new MemoryStream(bytInput), CompressionMode.Decompress);
            byte[] buf = new byte[originSize];
            s.Read(buf, 0, originSize);
            return buf;
        }
    }
}
