using System.IO;
using System.IO.Compression;

namespace GradeLib
{
    // Token: 0x02000003 RID: 3
    public class GZipHelper
    {
        // Token: 0x06000003 RID: 3 RVA: 0x000020F0 File Offset: 0x000002F0
        public static byte[] Compress(byte[] bytData)
        {
            byte[] result;
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                Stream stream = new GZipStream(memoryStream, CompressionMode.Compress);
                stream.Write(bytData, 0, bytData.Length);
                stream.Close();
                byte[] array = memoryStream.ToArray();
                result = array;
            }
            catch
            {
                result = null;
            }
            return result;
        }

        // Token: 0x06000004 RID: 4 RVA: 0x00002144 File Offset: 0x00000344
        public static byte[] DeCompress(byte[] bytInput, int originSize)
        {
            Stream stream = new GZipStream(new MemoryStream(bytInput), CompressionMode.Decompress);
            byte[] array = new byte[originSize];
            stream.Read(array, 0, originSize);
            return array;
        }
    }
}
