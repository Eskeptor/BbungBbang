using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace BbungBbangCrypt
{
    public class Crypto
    {
        private static string SEED = "BbungBbang";

        static void Main()
        {
            //string origin = "안농하세요";
            //string encrypt = Encrypt(origin);
            //string decrypt = Decrypt(encrypt);

            //Console.WriteLine(origin);
            //Console.WriteLine(encrypt);
            //Console.WriteLine(decrypt);
        }

        public static string Encrypt(string str)
        {
            string strEncrypt = string.Empty;
            MemoryStream memoryStream = null;
            CryptoStream cryptoStream = null;

            try
            {
                RijndaelManaged rijndael = new RijndaelManaged();
                byte[] bArrOriginText = System.Text.Encoding.Unicode.GetBytes(str);
                byte[] bArrSaltText = System.Text.Encoding.ASCII.GetBytes(SEED.Length.ToString());
                PasswordDeriveBytes key = new PasswordDeriveBytes(SEED, bArrSaltText);
                ICryptoTransform encryptor = rijndael.CreateEncryptor(key.GetBytes(32), key.GetBytes(16));
                memoryStream = new MemoryStream();
                cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);

                cryptoStream.Write(bArrOriginText, 0, bArrOriginText.Length);
                cryptoStream.FlushFinalBlock();

                byte[] bArrCipher = memoryStream.ToArray();

                cryptoStream.Close();
                memoryStream.Close();

                strEncrypt = Convert.ToBase64String(bArrCipher);
            }
            catch (InvalidOperationException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            catch (ArgumentException ae)
            {
                cryptoStream.Close();
                memoryStream.Close();
                MessageBox.Show(ae.Message);
            }

            return strEncrypt;
        }

        public static string Decrypt(string str)
        {
            string strDecrypt = string.Empty;
            MemoryStream memoryStream = null;
            CryptoStream cryptoStream = null;

            try
            {
                RijndaelManaged rijndael = new RijndaelManaged();
                byte[] bArrEncryptText = Convert.FromBase64String(str);
                byte[] bSaltText = System.Text.Encoding.ASCII.GetBytes(SEED.Length.ToString());
                PasswordDeriveBytes key = new PasswordDeriveBytes(SEED, bSaltText);
                ICryptoTransform decryptor = rijndael.CreateDecryptor(key.GetBytes(32), key.GetBytes(16));
                memoryStream = new MemoryStream(bArrEncryptText);
                cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] bArrOriginText = new byte[bArrEncryptText.Length];
                int nDecryptedCount = cryptoStream.Read(bArrOriginText, 0, bArrOriginText.Length);

                cryptoStream.Close();
                memoryStream.Close();

                strDecrypt = System.Text.Encoding.Unicode.GetString(bArrOriginText, 0, nDecryptedCount);
            }
            catch (InvalidOperationException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            catch (ArgumentException ae)
            {
                cryptoStream.Close();
                memoryStream.Close();
                MessageBox.Show(ae.Message);
            }

            return strDecrypt;
        }
    }
}
