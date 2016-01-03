// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.v2.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmugMug.v2.Types
{
    public partial class AlbumEntity : SmugMugEntity
    {
        public override string EntityId
        {
            get { return AlbumKey; }
        }

        //TODO: Implement search:
        // https://api.smugmug.com/api/v2/album!search?Scope=&SortDirection=Descending&SortMethod=Rank&Text=

        public async Task ApplyAlbumTemplateAsync(AlbumTemplateEntity template)
        {
            var postProperties = new List<KeyValuePair<string, object>>();
            postProperties.Add(new KeyValuePair<string, object>("AlbumTemplateUri", template.Uri));

            var payload = JsonHelpers.GetPayloadAsJson(postProperties);

            // /album/(*)!applyalbumtemplate 
            string requestUri = string.Format("{0}{1}!applyalbumtemplate", SmugMug.v2.Constants.Addresses.SmugMug, Uri);

            await PostRequestAsync(requestUri, payload);
        }

        public async Task CollectImagesAsync(IEnumerable<ImageEntity> images)
        {
            // /album/(*)!collectimages 
            string requestUri = string.Format("{0}{1}!collectimages", SmugMug.v2.Constants.Addresses.SmugMug, Uri);

            // Create the list of ImageUris to use.
            string imageUris = string.Join(",", images.Select(img => img.Uri));

            var postProperties = new List<KeyValuePair<string, object>>();
            postProperties.Add(new KeyValuePair<string, object>("CollectUris", imageUris));

            var payload = JsonHelpers.GetPayloadAsJson(postProperties);

            await PostRequestAsync(requestUri, payload);
        }

        public async Task<CommentEntity[]> GetCommentsAsync()
        {
            // /album/(*)!comments 
            return await album____comments(AlbumKey);
        }

        /// <summary>
        /// Convenience method for calling DeleteImagesAsync non-async
        /// </summary>
        public async Task DeleteImagesAsync(params ImageEntity[] images)
        {
            await DeleteImagesAsync(new List<ImageEntity>(images), false);
        }

        public async Task DeleteImagesAsync(IEnumerable<ImageEntity> images, bool deleteAsync)
        {
            // /album/(*)!deleteimages 
            string requestUri = string.Format("{0}{1}!deleteimages", SmugMug.v2.Constants.Addresses.SmugMug, Uri);

            // Create the list of ImageUris to use.
            string imageUris = string.Join(",", images.Select(img => img.Uri));

            var postProperties = new List<KeyValuePair<string, object>>();
            postProperties.Add(new KeyValuePair<string, object>("DeleteUris", imageUris));
            postProperties.Add(new KeyValuePair<string, object>("Async", deleteAsync));

            var payload = JsonHelpers.GetPayloadAsJson(postProperties);

            await PostRequestAsync(requestUri, payload);
        }

        public async Task<DownloadEntity[]> GetDownloadAsync()
        {
            // /album/(*)!download 
            return await album____download(AlbumKey);
        }

        public async Task<ImageEntity[]> GetGeoMediaAsync()
        {
            // /album/(*)!geomedia 
            return await album____geomedia(AlbumKey);
        }

        public async Task<GrantEntity[]> GetGrantsAsync()
        {
            // /album/(*)!grants 
            return await album____grants(AlbumKey);
        }

        public async Task<ImageEntity[]> GetImagesAsync()
        {
            // /album/(*)!images 
            return await album____images(AlbumKey);
        }

        public async Task MoveImagesAsync(IEnumerable<ImageEntity> images, bool moveAsync)
        {
            // Create the list of ImageUris to use.
            string imageUris = string.Join(",", images.Select(img => img.Uri));

            var postProperties = new List<KeyValuePair<string, object>>();
            postProperties.Add(new KeyValuePair<string, object>("MoveUris", imageUris));
            postProperties.Add(new KeyValuePair<string, object>("Async", moveAsync));

            var payload = JsonHelpers.GetPayloadAsJson(postProperties);

            // /album/(*)!moveimages 
            string requestUri = string.Format("{0}{1}!moveimages", SmugMug.v2.Constants.Addresses.SmugMug, Uri);
            await PostRequestAsync(requestUri, payload);
        }

        public async Task<ImageEntity[]> GetPopularMediaAsync()
        {
            // /album/(*)!popularmedia 
            return await album____popularmedia(AlbumKey);
        }

        public async Task<CatalogSkuPriceEntity[]> GetPricesAsync()
        {
            // /album/(*)!prices 
            return await album____prices(AlbumKey);
        }

        public async Task<AlbumShareUrisEntity> GetShareUrisAsync()
        {
            // /album/(*)!shareuris 
            return await album____shareuris(AlbumKey);
        }

        /// <summary>
        /// </summary>
        /// <param name="sourceUri">Uri The source URI (supported schemes: https and http)</param>
        /// <param name="allowInsecure">Allow the source to be an insecure http URI</param>
        /// <param name="byteCount">The size of the media file in bytes, for improved error-detection</param>
        /// <param name="caption">The caption to attach to the uploaded media</param>
        /// <param name="cookie">A string to send as the value of a Cookie header when fetching the source URI</param>
        /// <param name="fileName">The filename to attach to the uploaded media, overriding the filename guessed from the URI</param>
        /// <param name="hidden">Should the uploaded media be set as hidden?</param>
        /// <param name="keywords">Keywords to attach to the uploaded media</param>
        /// <param name="MD5Sum">The MD5 hash of the media file as a hexadecimal string, for improved error-detection</param>
        /// <param name="title">The title to attach to the uploaded media</param>
        /// <returns></returns>
        public async Task UploadFromUriAsync(Uri sourceUri, bool allowInsecure = false, long byteCount = 0, string caption = "",
            string cookie = "_", string fileName = "", bool hidden = false, string[] keywords = null, string MD5Sum = "", string title = "")
        {
            if (sourceUri.Scheme != System.Uri.UriSchemeHttp && sourceUri.Scheme != System.Uri.UriSchemeHttps)
                throw new ArgumentException("Supported URI schemes are HTTP and HTTPS", "sourceUri");

            var postProperties = new List<KeyValuePair<string, object>>();
            if (byteCount > 0)
                postProperties.Add(new KeyValuePair<string, object>("ByteCount", byteCount));
            if (!string.IsNullOrEmpty(caption))
                postProperties.Add(new KeyValuePair<string, object>("Caption", caption));
            postProperties.Add(new KeyValuePair<string, object>("Hidden", hidden));

            if (keywords != null)
                postProperties.Add(new KeyValuePair<string, object>("Keywords", keywords));

            if (!string.IsNullOrEmpty(MD5Sum))
                postProperties.Add(new KeyValuePair<string, object>("MD5Sum", MD5Sum));

            if (!string.IsNullOrEmpty(title))
                postProperties.Add(new KeyValuePair<string, object>("Title", title));

            if (!string.IsNullOrEmpty(cookie))
                postProperties.Add(new KeyValuePair<string, object>("Cookie", cookie));

            if (!string.IsNullOrEmpty(fileName))
                postProperties.Add(new KeyValuePair<string, object>("FileName", fileName));

            postProperties.Add(new KeyValuePair<string, object>("AllowInsecure", allowInsecure));
            postProperties.Add(new KeyValuePair<string, object>("Uri", sourceUri));

            var payload = JsonHelpers.GetPayloadAsJson(postProperties);

            // /album/(*)!uploadfromuri 
            string requestUri = string.Format("{0}{1}!uploadfromuri", SmugMug.v2.Constants.Addresses.SmugMug, Uri);

            await PostRequestAsync(requestUri, payload);
        }

        public async Task<FolderEntity> GetFolderAsync()
        {
            // /folder/user/(*)/(*) 
            return await folderuser______(ParentEntity.EntityId, AlbumKey);
        }

        public async Task<ImageEntity> GetHighlightImageAsync()
        {
            // /highlight/node/(*) 
            return await highlightnode___(NodeID);
        }

        public async Task<NodeEntity> GetNodeAsync()
        {
            // /node/(*) 
            return await node___(NodeID);
        }

        public async Task<UserEntity> GetUserAsync()
        {
            // /user/(*) 
            return await user___(ParentEntity.EntityId);
        }

        public async Task<WatermarkEntity> GetWatermarkAsync()
        {
            // /watermark/(*) 
            string requestUri = string.Format("{0}{1}", SmugMug.v2.Constants.Addresses.SmugMug, WatermarkUri);

            return await RetrieveEntityAsync<WatermarkEntity>(requestUri);
        }
    }
}
