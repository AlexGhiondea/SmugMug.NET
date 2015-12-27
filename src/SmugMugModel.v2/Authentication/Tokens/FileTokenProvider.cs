// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace SmugMug.v2.Authentication.Tokens
{
    public class FileTokenProvider : ITokenProvider
    {
        #region ITokenProvider
        public bool TryGetCredentials(out OAuthToken oauthToken)
        {
            try
            {
                string content = DecryptTextFromFile(FileName);

                XDocument settings = XDocument.Parse(content);

                var root = settings.Element("SmugMug");
                string apiKey = root.Element("apiKey").Value;
                string secret = root.Element("secret").Value;
                string token = root.Element("token").Value;
                string tokenSecret = root.Element("tokenSecret").Value;
                oauthToken = new OAuthToken(apiKey, secret, token, tokenSecret);
            }
            catch
            {
                oauthToken = OAuthToken.Invalid;
                return false;
            }
            return true;
        }

        public bool SaveCredentials(OAuthToken oauthToken)
        {
            XDocument doc = new XDocument(
               new XElement("SmugMug",
                   new XElement("apiKey", oauthToken.ApiKey),
                   new XElement("secret", oauthToken.Secret),
                   new XElement("token", oauthToken.Token),
                   new XElement("tokenSecret", oauthToken.TokenSecret)));

            return EncryptTextToFile(doc.ToString(), FileName);
        }
        #endregion

        private const int MinKeySizeInChars = 8;

        private byte[] _salt;
        private byte[] _key;
        private string _fileName = Path.Combine(Path.GetTempPath(), "smugmug.dat");

        public string FileName { get { return _fileName; } set { _fileName = value; } }


        public FileTokenProvider()
            : this(null, null)
        {

        }

        public FileTokenProvider(string key, string salt)
        {
            _salt = GetSalt(salt);
            _key = GetKey(key);
        }

        private static byte[] GetSalt(string salt = "")
        {
            if (string.IsNullOrEmpty(salt))
                salt = Environment.MachineName;

            return GetStringWithMinSize(salt);
        }

        private static byte[] GetKey(string key = "")
        {
            if (string.IsNullOrEmpty(key))
                key = "12345678";

            return GetStringWithMinSize(key);
        }

        private bool EncryptTextToFile(String Data, String FileName)
        {
            try
            {
                // Create or open the specified file.
                using (FileStream fStream = File.Open(FileName, FileMode.OpenOrCreate))
                using (RijndaelManaged rijndael = new RijndaelManaged()) // Create a new Rijndael object.
                {
                    rijndael.BlockSize = 256;
                    Rfc2898DeriveBytes pwdGen = new Rfc2898DeriveBytes(_key, _salt, 10000);

                    byte[] key = pwdGen.GetBytes(rijndael.KeySize / 8);   //This will generate a 256 bits key
                    byte[] iv = pwdGen.GetBytes(rijndael.BlockSize / 8);  //This will generate a 256 bits IV

                    using (CryptoStream cStream = new CryptoStream(fStream, rijndael.CreateEncryptor(key, iv), CryptoStreamMode.Write))                 // Create a CryptoStream using the FileStream and the passed key and initialization vector (IV).
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
            }
            catch (CryptographicException e)
            {
                Debug.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return false;
            }
            catch (UnauthorizedAccessException e)
            {
                Debug.WriteLine("A file error occurred: {0}", e.Message);
                return false;
            }
            return true;
        }

        private string DecryptTextFromFile(String FileName)
        {
            try
            {
                // Create or open the specified file. 
                using (FileStream fStream = File.Open(FileName, FileMode.OpenOrCreate))
                using (RijndaelManaged rijndael = new RijndaelManaged()) // Create a new Rijndael object.
                {
                    rijndael.BlockSize = 256;
                    Rfc2898DeriveBytes pwdGen = new Rfc2898DeriveBytes(_key, _salt, 10000);

                    byte[] key = pwdGen.GetBytes(rijndael.KeySize / 8);   //This will generate a 256 bits key
                    byte[] iv = pwdGen.GetBytes(rijndael.BlockSize / 8);  //This will generate a 256 bits IV

                    using (CryptoStream cStream = new CryptoStream(fStream, rijndael.CreateDecryptor(key, iv), CryptoStreamMode.Read))                 // Create a CryptoStream using the FileStream and the passed key and initialization vector (IV).
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

        private static byte[] GetStringWithMinSize(string value, int minVal = MinKeySizeInChars)
        {
            StringBuilder sb = new StringBuilder();
            do
            {
                sb.Append(value);
            } while (sb.Length < minVal);
            return Encoding.UTF8.GetBytes(sb.ToString());
        }
    }
}
