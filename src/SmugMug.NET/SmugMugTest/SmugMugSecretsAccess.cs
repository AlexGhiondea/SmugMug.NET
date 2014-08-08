using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Security.Cryptography;

namespace SmugMugTest
{
    public class SmugMugSecretsAccess
    {
        static void EncryptTextToFile(String Data, String FileName, byte[] Key, byte[] IV)
        {
            try
            {
                // Create or open the specified file.
                using (FileStream fStream = File.Open(FileName, FileMode.OpenOrCreate))
                using (DES DESalg = DES.Create()) // Create a new DES object.
                using (CryptoStream cStream = new CryptoStream(fStream, DESalg.CreateEncryptor(Key, IV), CryptoStreamMode.Write))                 // Create a CryptoStream using the FileStream and the passed key and initialization vector (IV).
                using (StreamWriter sWriter = new StreamWriter(cStream))// Create a StreamWriter using the CryptoStream.
                {
                    // Write the data to the stream 
                    // to encrypt it.
                    sWriter.WriteLine(Data);

                    // Close the streams and
                    // close the file.
                    sWriter.Close();
                    cStream.Close();
                    fStream.Close();
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("A file error occurred: {0}", e.Message);
            }

        }

        static string DecryptTextFromFile(String FileName, byte[] Key, byte[] IV)
        {
            try
            {
                // Create or open the specified file. 
                using (FileStream fStream = File.Open(FileName, FileMode.OpenOrCreate))

                // Create a new DES object.
                using (DES DESalg = DES.Create())

                // Create a CryptoStream using the FileStream 
                // and the passed key and initialization vector (IV).
                using (CryptoStream cStream = new CryptoStream(fStream,
                    DESalg.CreateDecryptor(Key, IV),
                    CryptoStreamMode.Read))

                // Create a StreamReader using the CryptoStream.
                using (StreamReader sReader = new StreamReader(cStream))
                {

                    // Read the data from the stream 
                    // to decrypt it.
                    string val = sReader.ReadToEnd();

                    // Close the streams and
                    // close the file.
                    sReader.Close();
                    cStream.Close();
                    fStream.Close();

                    // Return the string. 
                    return val;
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("A file error occurred: {0}", e.Message);
                return null;
            }
        }

        public static void SaveSecretsToFile(string apiKey, string secret, string token, string tokenSecret)
        {
            XDocument doc = new XDocument(
                new XElement("SmugMug",
                    new XElement("apiKey", apiKey),
                    new XElement("secret", secret),
                    new XElement("token", token),
                    new XElement("tokenSecret", tokenSecret)));

            EncryptTextToFile(doc.ToString(), FileName, encryptKey, encryptIV);
        }

        public static void ReadSecretsFromFile(out string apiKey, out string secret, out string token, out string tokenSecret)
        {
            try
            {
                string content = DecryptTextFromFile(FileName, encryptKey, encryptIV);

                XDocument settings = XDocument.Parse(content);

                var root = settings.Element("SmugMug");
                apiKey = root.Element("apiKey").Value;
                secret = root.Element("secret").Value;
                token = root.Element("token").Value;
                tokenSecret = root.Element("tokenSecret").Value;
            }
            catch
            {
                apiKey = null;
                secret = null;
                token = null;
                tokenSecret = null;
            }
        }

        private static string myFileName = Path.Combine(Path.GetTempPath(), "smugmug.dat");
        public static string FileName { get { return myFileName; } set { myFileName = value; } }

        static byte[] encryptKey = Encoding.UTF8.GetBytes("12345678");
        static byte[] encryptIV = Encoding.UTF8.GetBytes("12345678");

        public static void ChangeEncryptionKey(string key, string iv)
        {
            if (string.IsNullOrEmpty(key) || key.Length != 8)
            {
                throw new ArgumentException("key must have exactly 8 characters", "key");
            }

            if (string.IsNullOrEmpty(iv) || iv.Length != 8)
            {
                throw new ArgumentException("iv must have exactly 8 characters", "iv");
            }


            encryptKey = Encoding.UTF8.GetBytes(key);
            encryptIV = Encoding.UTF8.GetBytes(iv);

        }
    }
}
