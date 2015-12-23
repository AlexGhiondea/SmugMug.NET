using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SmugMugModel.oAuth;
using Newtonsoft.Json;

namespace SmugMugModel
{
    public class UploadEventArgs : EventArgs
    {
        public float PercentComplete { get; internal set; }
        /// <summary>
        /// The filename of the image (or video).
        /// This header overrides whatever is set as the filename in the PUT endpoint.
        /// </summary>
        public string FileName { get; set; }
    }

    public class ImageUpload
    {
        #region Properties

        /// <summary>
        /// Set this to control if the buffering on the stream is turned on or off.
        /// </summary>
        private bool myAllowWriteStreamBuffering = true;
        public bool AllowWriteStreamBuffering
        {
            get { return myAllowWriteStreamBuffering; }
            set { myAllowWriteStreamBuffering = value; }
        }

        public SmugMugBase authentication { get; set; }

        private Album Album;
        /// <summary>
        /// The altitude at which the image (or video) was taken.
        /// </summary>
        public int? Altitude { get; set; }
        /// <summary>
        /// The caption for the image (or video).
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// The id of the image to replace.
        /// </summary>
        public int? ImageID { get; set; }
        /// <summary>
        /// Hide the image (or video). Default: false
        /// </summary>
        public bool Hidden { get; set; }
        /// <summary>
        /// The keyword string for the image (or video).
        /// </summary>
        public string Keywords { get; set; }
        /// <summary>
        /// The latitude at which the image (or video) was taken.
        /// </summary>
        public float? Latitude { get; set; }
        /// <summary>
        /// The longitude at which the image (or video) was taken.
        /// </summary>
        public float? Longitude { get; set; }
        /// <summary>
        /// Return a more human friendly response. Default: false
        /// </summary>
        public bool Pretty { get; set; }
        /// <summary>
        /// The response type. Values: JSON, PHP, REST (default), XML-RPC
        /// </summary>
        private string ResponseType = "JSON";
        /// <summary>
        /// The API version [required]
        /// </summary>
        private string Version = "1.3.0";

        private int chunkSize = 1024 * 32; //the default chunksize for reading from the file
        #endregion

        public event EventHandler<UploadEventArgs> UploadCompleted;
        public event EventHandler<UploadEventArgs> UploadStarted;
        public event EventHandler<UploadEventArgs> UploadProgress;

        /// <summary>
        /// Converts the MD5 sum from a byte array to a string
        /// </summary>
        /// <param name="arr">The byte array</param>
        /// <returns></returns>
        private static string GetStringFromHash(byte[] arr)
        {
            StringBuilder s = new StringBuilder();
            foreach (byte item in arr)
            {
                var first = item >> 4;
                var second = (item & 0x0F);

                s.AppendFormat("{0:X}{1:X}", first, second);
            }

            return s.ToString().ToLower();
        }

        /// <summary>
        /// This is the constructor for the ImageUpload object. It is private so you have to use the CreateUploader method
        /// </summary>
        /// <param name="SessionID">The session ID</param>
        /// <param name="AlbumID">The album ID</param>
        internal ImageUpload(SmugMugBase basic, Album Album)
        {
            this.authentication = basic;
            this.Album = Album;
        }

        /// <summary>
        /// Uploads a file
        /// </summary>
        /// <param name="fileName">The filename we want to upload</param>
        /// <returns>An Image object that describes the image we uploaded</returns>
        public Image UploadImage(string fileName)
        {
            var byteArr = File.ReadAllBytes(fileName);
            var MD5Sum = GetStringFromHash(System.Security.Cryptography.MD5.Create().ComputeHash(byteArr));

            return UploadImage(fileName, MD5Sum);
        }

        public Image UploadImage(string filename, string MD5Checksum)
        {
            return UploadImageAsync(filename, MD5Checksum, CancellationToken.None).Result;
        }

        /// <summary>
        /// Uploads a file
        /// </summary>
        /// <param name="filename">The filename we want to upload</param>
        /// <param name="MD5Checksum">The MD5 checksum of a file</param>
        /// <returns>An Image object that describes the image we uploaded</returns>
        public async Task<Image> UploadImageAsync(string fileName, CancellationToken token)
        {
            var byteArr = File.ReadAllBytes(fileName);
            var MD5Sum = GetStringFromHash(System.Security.Cryptography.MD5.Create().ComputeHash(byteArr));

            return await UploadImageAsync(fileName, MD5Sum, token);
        }

        /// <summary>
        /// Uploads a file
        /// </summary>
        /// <param name="filename">The filename we want to upload</param>
        /// <param name="MD5Checksum">The MD5 checksum of a file</param>
        /// <returns>An Image object that describes the image we uploaded</returns>
        public async Task<Image> UploadImageAsync(string filename, string MD5Checksum, CancellationToken token)
        {
            string uploadURL = string.Format("http://upload.smugmug.com/{0}", filename);
            var myFileInfo = new FileInfo(filename);
            var myWebRequest = (HttpWebRequest)WebRequest.Create(uploadURL);
            myWebRequest.UserAgent = "YASMAPI v1.0";
            myWebRequest.ContentType = "binary/octet-stream";
            myWebRequest.ContentLength = myFileInfo.Length;
            myWebRequest.Method = WebRequestMethods.Http.Put;

            myWebRequest.Headers.Add("X-Smug-Version", Version);
            myWebRequest.Headers.Add("X-Smug-ResponseType", ResponseType);
            myWebRequest.Headers.Add("X-Smug-AlbumID", Album.id.ToString());
            myWebRequest.Headers.Add("Content-MD5", MD5Checksum);
            myWebRequest.Headers.Add("X-Smug-FileName", myFileInfo.Name);

            if (Altitude != null)
                myWebRequest.Headers.Add("X-Smug-Altitude", Altitude.ToString());
            if (Caption != null)
                myWebRequest.Headers.Add("X-Smug-Caption", Caption);
            if (Hidden == true)
                myWebRequest.Headers.Add("X-Smug-Hidden", "true");
            if (ImageID != null)
                myWebRequest.Headers.Add("X-Smug-ImageID", ImageID.ToString());
            if (Keywords != null)
                myWebRequest.Headers.Add("X-Smug-Keywords", Keywords);
            if (Latitude != null)
                myWebRequest.Headers.Add("X-Smug-Latitude", Latitude.ToString());
            if (Longitude != null)
                myWebRequest.Headers.Add("X-Smug-Longitude", Longitude.ToString());
            if (Pretty == true)
                myWebRequest.Headers.Add("X-Smug-Pretty", "true");


            // Add the authorization header
            myWebRequest.Headers.Add("Authorization", oAuthUtility.GetAuthorizationHeader(authentication.AccessToken, uploadURL));

            //we start reading from the file...

            //we have some elements to set
            //- request time out (compute this for 10 kb/sec speed)
            //- the chunk size to use when uploading (how much data to report after)
            if (UploadStarted != null)
                UploadStarted(this, new UploadEventArgs() { FileName = myFileInfo.FullName, PercentComplete = 0 });

            int timeOut = ((int)myFileInfo.Length / 1024) * 1000;
            myWebRequest.Timeout = timeOut;
            myWebRequest.ReadWriteTimeout = timeOut;
            myWebRequest.AllowWriteStreamBuffering = AllowWriteStreamBuffering;

            long howMuchRead = 0;
            byte[] buffer = new byte[chunkSize];
            int readSoFar = 0;

            try
            {
                using (FileStream sr = new FileStream(myFileInfo.FullName, FileMode.Open, FileAccess.Read))
                {
                    using (var stream = await myWebRequest.GetRequestStreamAsync())
                    {
                        while (howMuchRead < myFileInfo.Length)
                        {
                            //we try to read a chunk from the file
                            readSoFar = sr.Read(buffer, 0, chunkSize);
                            howMuchRead += readSoFar;

                            //we now write those files to the web.
                            await stream.WriteAsync(buffer, 0, readSoFar, token);

                            if (UploadProgress != null)
                                UploadProgress(this, new UploadEventArgs() { FileName = myFileInfo.FullName, PercentComplete = (float)howMuchRead / (float)myFileInfo.Length });
                        }
                    }
                }
            }
            catch (Exception)
            {
                //an error has occured...
                throw;
            }

            var resp = await myWebRequest.GetResponseAsync();
            string rez = string.Empty;
            using (StreamReader ns = new StreamReader(resp.GetResponseStream()))
            {
                rez = await ns.ReadToEndAsync();
            }

            if (UploadCompleted != null)
                UploadCompleted(this, new UploadEventArgs() { FileName = myFileInfo.FullName, PercentComplete = (float)howMuchRead / (float)myFileInfo.Length });

            //we deserialize the image
            var response = JsonConvert.DeserializeObject<ImageResponse>(System.Uri.UnescapeDataString(rez));

            if (response.stat == "ok")
            {
                Image img = response.Image;
                img.basic = authentication;
                img.Album = Album;

                return img;
            }
            else
                throw new SmugMugException(response.code, response.message, response.method);
        }
    }
}
