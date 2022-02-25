using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CourseSheduleManagement.Library.Utilities
{
    public class Utilities
    {
        public static string XorDecrypt(string TheText)
        {

            string functionReturnValue = null;
            int PeriodPos = 0;
            long tmp = 0;
            string theXordNum = null;
            const long key1 = 14;
            const long key2 = 78;

            do
            {
                PeriodPos = TheText.IndexOf(".");
                if (!(PeriodPos == -1))
                {
                    theXordNum = Mid(TheText, 0, PeriodPos);
                    tmp = Convert.ToByte(theXordNum) ^ key2;
                    tmp = tmp ^ key1;
                    functionReturnValue = functionReturnValue + Chr(Convert.ToByte(tmp));
                    TheText = TheText.Remove(0, theXordNum.Length + 1);
                }
                else
                {
                    break; // TODO: might not be correct. Was : Exit Do 
                }
            }
            while (true);

            return functionReturnValue;
        }

        private static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }

        private static char Chr(byte src)
        {
            return (System.Text.Encoding.GetEncoding("iso-8859-1").GetChars(new byte[] { src })[0]);
        }

        public static string Encryptpassword(string password)
        {
            int i;

            const long key1 = 14;
            const long key2 = 78;
            long val;

            string pass = "";
            for (i = 0; i < password.Length; i++)
            {
                val = ((int)password[i]) ^ key1;
                val = val ^ key2;
                pass += val + ".";
            }
            return pass;
        }
        private static string _encKey = "E546C8DF278CD5931069B522E695D4F2";
        public static string EncryptString(string text)
        {
            var key = Encoding.UTF8.GetBytes(_encKey);

            using (var aesAlg = Aes.Create())
            {
                using (var encryptor = aesAlg.CreateEncryptor(key, aesAlg.IV))
                {
                    using (var msEncrypt = new MemoryStream())
                    {
                        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(text);
                        }

                        var iv = aesAlg.IV;

                        var decryptedContent = msEncrypt.ToArray();

                        var result = new byte[iv.Length + decryptedContent.Length];

                        Buffer.BlockCopy(iv, 0, result, 0, iv.Length);
                        Buffer.BlockCopy(decryptedContent, 0, result, iv.Length, decryptedContent.Length);

                        return Convert.ToBase64String(result);
                    }
                }
            }
        }

        public static string DecryptString(string cipherText)
        {
            var fullCipher = Convert.FromBase64String(cipherText);

            var iv = new byte[16];
            var cipher = new byte[16];

            Buffer.BlockCopy(fullCipher, 0, iv, 0, iv.Length);
            Buffer.BlockCopy(fullCipher, iv.Length, cipher, 0, iv.Length);
            var key = Encoding.UTF8.GetBytes(_encKey);

            using (var aesAlg = Aes.Create())
            {
                using (var decryptor = aesAlg.CreateDecryptor(key, iv))
                {
                    string result;
                    using (var msDecrypt = new MemoryStream(cipher))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var srDecrypt = new StreamReader(csDecrypt))
                            {
                                result = srDecrypt.ReadToEnd();
                            }
                        }
                    }

                    return result;
                }
            }
        }
    }
}
