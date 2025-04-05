using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace EncryptData
{
    // Token: 0x02000002 RID: 2
    public class EncryptSupport
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
        public static byte[] ObjectToByteArray(object obj)
        {
            bool flag = obj == null;
            byte[] result;
            if (flag)
            {
                result = null;
            }
            else
            {
                BinaryFormatter bf = new BinaryFormatter();
                MemoryStream ms = new MemoryStream();
                bf.Serialize(ms, obj);
                result = ms.ToArray();
            }
            return result;
        }

        // Token: 0x06000002 RID: 2 RVA: 0x0000208C File Offset: 0x0000108C
        public static object ByteArrayToObject(byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0L, SeekOrigin.Begin);
            return binForm.Deserialize(memStream);
        }

        // Token: 0x06000003 RID: 3 RVA: 0x000020CC File Offset: 0x000010CC
        public static bool EncryptQuestions_SaveToFile(string fname, byte[] data, string key)
        {
            bool result;
            try
            {
                FileStream stream = new FileStream(fname, FileMode.Create, FileAccess.Write);
                CryptoStream crStream = new CryptoStream(stream, new DESCryptoServiceProvider
                {
                    Key = Encoding.ASCII.GetBytes(key),
                    IV = Encoding.ASCII.GetBytes(key)
                }.CreateEncryptor(), CryptoStreamMode.Write);
                crStream.Write(data, 0, data.Length);
                crStream.Close();
                stream.Close();
                result = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }

        // Token: 0x06000004 RID: 4 RVA: 0x00002154 File Offset: 0x00001154
        public static byte[] DecryptQuestions_FromFile(string fname, string key)
        {
            byte[] result;
            try
            {
                FileStream stream = new FileStream(fname, FileMode.Open, FileAccess.Read);
                CryptoStream crStream = new CryptoStream(stream, new DESCryptoServiceProvider
                {
                    Key = Encoding.ASCII.GetBytes(key),
                    IV = Encoding.ASCII.GetBytes(key)
                }.CreateDecryptor(), CryptoStreamMode.Read);
                byte[] buf = new byte[stream.Length];
                int len = crStream.Read(buf, 0, (int)stream.Length);
                crStream.Close();
                stream.Close();
                result = buf;
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }

        // Token: 0x06000005 RID: 5 RVA: 0x000021F0 File Offset: 0x000011F0
        public static string Encryption(byte[] data, string key)
        {
            DES des = new DESCryptoServiceProvider();
            des.Key = Encoding.ASCII.GetBytes(key);
            des.IV = des.Key;
            des.Padding = PaddingMode.PKCS7;
            MemoryStream ms = new MemoryStream();
            ICryptoTransform desencrypt = des.CreateEncryptor();
            CryptoStream stream = new CryptoStream(ms, desencrypt, CryptoStreamMode.Write);
            stream.Write(data, 0, data.Length);
            stream.FlushFinalBlock();
            ms.Position = 0L;
            string encrypted = string.Empty;
            encrypted = Convert.ToBase64String(ms.ToArray());
            stream.Close();
            return encrypted;
        }

        // Token: 0x06000006 RID: 6 RVA: 0x00002280 File Offset: 0x00001280
        public static string Decryption(byte[] data, string key)
        {
            DES des = new DESCryptoServiceProvider();
            des.Key = Encoding.ASCII.GetBytes(key);
            des.IV = des.Key;
            des.Padding = PaddingMode.PKCS7;
            MemoryStream ms = new MemoryStream(data);
            CryptoStream stream = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Read);
            byte[] fromEncrypt = new byte[data.Length];
            stream.Read(fromEncrypt, 0, fromEncrypt.Length);
            stream.Close();
            return Encoding.Unicode.GetString(fromEncrypt);
        }

        // Token: 0x06000007 RID: 7 RVA: 0x00002300 File Offset: 0x00001300
        public static string GetMD5(string msg)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(Encoding.Unicode.GetBytes(msg));
            return Encoding.Unicode.GetString(result);
        }

        // Token: 0x06000008 RID: 8 RVA: 0x00002338 File Offset: 0x00001338
        public static string Encrypt(string plainText, string key)
        {
            string result;
            using (RijndaelManaged rijndael = new RijndaelManaged())
            {
                rijndael.Key = Encoding.UTF8.GetBytes(key);
                rijndael.Mode = CipherMode.ECB;
                rijndael.Padding = PaddingMode.PKCS7;
                ICryptoTransform encryptor = rijndael.CreateEncryptor();
                byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                byte[] encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                result = Convert.ToBase64String(encryptedBytes);
            }
            return result;
        }

        // Token: 0x06000009 RID: 9 RVA: 0x000023B8 File Offset: 0x000013B8
        public static string Decrypt(string encryptedText, string key)
        {
            string @string;
            using (RijndaelManaged rijndael = new RijndaelManaged())
            {
                rijndael.Key = Encoding.UTF8.GetBytes(key);
                rijndael.Mode = CipherMode.ECB;
                rijndael.Padding = PaddingMode.PKCS7;
                ICryptoTransform decryptor = rijndael.CreateDecryptor();
                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                @string = Encoding.UTF8.GetString(decryptedBytes);
            }
            return @string;
        }
    }
}
