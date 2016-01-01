// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.v2.Utility;
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

        public async Task RequirePost_Fixup_album____collectimages()
        {
            // /album/(*)!collectimages 
            await album____collectimages(string.Empty);
        }

        public async Task<CommentEntity[]> GetCommentsAsync()
        {
            // /album/(*)!comments 
            return await album____comments(AlbumKey);
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

        public async Task RequiresPost_Fixup_album____moveimages()
        {
            // /album/(*)!   
            await album____moveimages(string.Empty);
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

        public async Task RequiresPost_Fixup_album____uploadfromuri()
        {
            // /album/(*)!uploadfromuri 
            await album____uploadfromuri(string.Empty);
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
