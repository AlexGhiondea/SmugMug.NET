// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

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

        public async Task<ApplyAlbumTemplateEntity> RequiresPost_Fixup_album____applyalbumtemplate()
        {
            // /album/(*)!applyalbumtemplate 
            return await album____applyalbumtemplate(string.Empty);
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

        public async Task RequiresPost_Fixup_album____deleteimages()
        {
            // /album/(*)!deleteimages 
            await album____deleteimages(string.Empty);
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
