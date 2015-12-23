// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.v2.Authentication;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace SmugMug.v2.Authentication.Tokens
{
    public class FileTokenProvider : ITokenProvider
    {
        /// <summary>
        /// If the secrets are in a file, get them from there. Otherwise, request them (apikey, secret) from the user
        /// </summary>
        public static OAuthToken GetSmugMugSecrets()
        {
            OAuthToken oauthToken = default(OAuthToken);
            if (!TryReadSecretsFromFile(out oauthToken))
            {
                // Do we have the secret/apikey?
                Console.WriteLine("Please enter your API Key and press [Enter]:");
                string apiKey = Console.ReadLine();
                Console.WriteLine("Please enter your Application Secret and press [Enter]:");
                string secret = Console.ReadLine();

                oauthToken = SmugMugAuthorize.AuthorizeSmugMug(apiKey, secret, AuthenticationOptions.FullAccess);
                SaveSecretsToFile(oauthToken);
            }

#if DEBUG
            Console.WriteLine("Using APIKey={0}", oauthToken.ApiKey);
            Console.WriteLine("Using AppSecret={0}", oauthToken.Secret);
            Console.WriteLine("Using token={0}", oauthToken.Token);
            Console.WriteLine("Using tokenSecret={0}", oauthToken.TokenSecret);
#endif

            return oauthToken;
        }

        public OAuthToken GetCredentials()
        {
            throw new NotImplementedException();
        }

        static void EncryptTextToFile(String Data, String FileName, byte[] Key, byte[] IV)
        {
            try
            {
                // Create or open the specified file.
                using (FileStream fStream = File.Open(FileName, FileMode.OpenOrCreate))
                using (RijndaelManaged rijndael = new RijndaelManaged()) // Create a new Rijndael object.
                {
                    rijndael.BlockSize = 256;
                    Rfc2898DeriveBytes pwdGen = new Rfc2898DeriveBytes(Encoding.UTF8.GetBytes("12345678"), Encoding.UTF8.GetBytes("1234567" + Environment.MachineName), 10000);

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
                using (RijndaelManaged rijndael = new RijndaelManaged()) // Create a new Rijndael object.
                {
                    rijndael.BlockSize = 256;
                    Rfc2898DeriveBytes pwdGen = new Rfc2898DeriveBytes(Encoding.UTF8.GetBytes("12345678"), Encoding.UTF8.GetBytes("1234567" + Environment.MachineName), 10000);

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

        public static void SaveSecretsToFile(OAuthToken oauthToken)
        {
            XDocument doc = new XDocument(
                new XElement("SmugMug",
                    new XElement("apiKey", oauthToken.ApiKey),
                    new XElement("secret", oauthToken.Secret),
                    new XElement("token", oauthToken.Token),
                    new XElement("tokenSecret", oauthToken.TokenSecret)));

            EncryptTextToFile(doc.ToString(), FileName, encryptKey, encryptIV);
        }

        public static bool TryReadSecretsFromFile(out OAuthToken oauthToken)
        {
            try
            {
                string content = DecryptTextFromFile(FileName, encryptKey, encryptIV);

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

        private static string myFileName = Path.Combine(Path.GetTempPath(), "smugmug.dat");
        public static string FileName { get { return myFileName; } set { myFileName = value; } }

        static byte[] encryptKey = Encoding.UTF8.GetBytes("12345678" + Environment.MachineName);
        static byte[] encryptIV = Encoding.UTF8.GetBytes("12345678" + Environment.MachineName);

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
