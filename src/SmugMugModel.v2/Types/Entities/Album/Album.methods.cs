// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class AlbumEntity : SmugMugEntity
    {
        public AlbumEntity()
        {
            //Empty constructor to enable deserialization
        }

        public AlbumEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public async Task<ApplyAlbumTemplateEntity> album____applyalbumtemplate (string param1)
        {
            // /album/(*)!applyalbumtemplate 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!applyalbumtemplate", param1);

            return await RetrieveEntityAsync<ApplyAlbumTemplateEntity>(requestUri); 
        }

        public async Task album____collectimages (string param1)
        {
            // /album/(*)!collectimages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!collectimages", param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task<CommentEntity[]> album____comments (string param1)
        {
            // /album/(*)!comments 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!comments", param1);

            return await RetrieveEntityArrayAsync<CommentEntity>(requestUri); 
        }

        public async Task album____deleteimages (string param1)
        {
            // /album/(*)!deleteimages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!deleteimages", param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task<DownloadEntity[]> album____download (string param1)
        {
            // /album/(*)!download 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!download", param1);

            return await RetrieveEntityArrayAsync<DownloadEntity>(requestUri); 
        }

        public async Task<AlbumImageEntity[]> album____geomedia (string param1)
        {
            // /album/(*)!geomedia 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!geomedia", param1);

            return await RetrieveEntityArrayAsync<AlbumImageEntity>(requestUri); 
        }

        public async Task<GrantEntity[]> album____grants (string param1)
        {
            // /album/(*)!grants 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!grants", param1);

            return await RetrieveEntityArrayAsync<GrantEntity>(requestUri); 
        }

        public async Task<AlbumImageEntity> album____highlightimage (string param1)
        {
            // /album/(*)!highlightimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!highlightimage", param1);

            return await RetrieveEntityAsync<AlbumImageEntity>(requestUri); 
        }

        public async Task<AlbumImageEntity[]> album____images (string param1)
        {
            // /album/(*)!images 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!images", param1);

            return await RetrieveEntityArrayAsync<AlbumImageEntity>(requestUri); 
        }

        public async Task album____moveimages (string param1)
        {
            // /album/(*)!moveimages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!moveimages", param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task<AlbumImageEntity[]> album____popularmedia (string param1)
        {
            // /album/(*)!popularmedia 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!popularmedia", param1);

            return await RetrieveEntityArrayAsync<AlbumImageEntity>(requestUri); 
        }

        public async Task<CatalogSkuPriceEntity[]> album____prices (string param1)
        {
            // /album/(*)!prices 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!prices", param1);

            return await RetrieveEntityArrayAsync<CatalogSkuPriceEntity>(requestUri); 
        }

        public async Task<AlbumShareUrisEntity> album____shareuris (string param1)
        {
            // /album/(*)!shareuris 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!shareuris", param1);

            return await RetrieveEntityAsync<AlbumShareUrisEntity>(requestUri); 
        }

        public async Task album____uploadfromuri (string param1)
        {
            // /album/(*)!uploadfromuri 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!uploadfromuri", param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task<FolderEntity> folderuser______ (string param1, string param2)
        {
            // /folder/user/(*)/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}", param1,param2);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser_______parents (string param1, string param2)
        {
            // /folder/user/(*)/(*)!parents 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!parents", param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<FolderEntity> folderuser___albumName___ (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}", param1,param2);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser___albumName____parents (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!parents 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!parents", param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<FolderEntity> folderuser___Family___ (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}", param1,param2);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser___Family____parents (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!parents 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!parents", param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<FolderEntity> folderuser___SmugMug___ (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}", param1,param2);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser___SmugMug____parents (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!parents 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!parents", param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<ImageEntity> highlightnode___ (string param1)
        {
            // /highlight/node/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/highlight/node/{0}", param1);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        public async Task<NodeEntity> node___ (string param1)
        {
            // /node/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/node/{0}", param1);

            return await RetrieveEntityAsync<NodeEntity>(requestUri); 
        }

        public async Task<UserEntity> user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}", param1);

            return await RetrieveEntityAsync<UserEntity>(requestUri); 
        }

        public async Task<WatermarkEntity> watermark___ (string param1)
        {
            // /watermark/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/watermark/{0}", param1);

            return await RetrieveEntityAsync<WatermarkEntity>(requestUri); 
        }
    }
}
