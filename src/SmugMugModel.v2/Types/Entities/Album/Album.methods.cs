// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
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


        public ApplyAlbumTemplateEntity album____applyalbumtemplate (string param1)
        {
            // /album/(*)!applyalbumtemplate 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!applyalbumtemplate{1}", param1);

            return RetrieveEntityAsync<ApplyAlbumTemplateEntity>(requestUri).Result; 
        }

        public void album____collectimages (string param1)
        {
            // /album/(*)!collectimages 
            return; 
        }

        public CommentEntity[] album____comments (string param1)
        {
            // /album/(*)!comments 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!comments{1}", param1);

            return RetrieveEntityArrayAsync<CommentEntity>(requestUri).Result; 
        }

        public void album____deleteimages (string param1)
        {
            // /album/(*)!deleteimages 
            return; 
        }

        public DownloadEntity[] album____download (string param1)
        {
            // /album/(*)!download 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!download{1}", param1);

            return RetrieveEntityArrayAsync<DownloadEntity>(requestUri).Result; 
        }

        public AlbumImageEntity[] album____geomedia (string param1)
        {
            // /album/(*)!geomedia 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!geomedia{1}", param1);

            return RetrieveEntityArrayAsync<AlbumImageEntity>(requestUri).Result; 
        }

        public GrantEntity[] album____grants (string param1)
        {
            // /album/(*)!grants 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!grants{1}", param1);

            return RetrieveEntityArrayAsync<GrantEntity>(requestUri).Result; 
        }

        public AlbumImageEntity album____highlightimage (string param1)
        {
            // /album/(*)!highlightimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!highlightimage{1}", param1);

            return RetrieveEntityAsync<AlbumImageEntity>(requestUri).Result; 
        }

        public AlbumImageEntity[] album____images (string param1)
        {
            // /album/(*)!images 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!images{1}", param1);

            return RetrieveEntityArrayAsync<AlbumImageEntity>(requestUri).Result; 
        }

        public void album____moveimages (string param1)
        {
            // /album/(*)!moveimages 
            return; 
        }

        public AlbumImageEntity[] album____popularmedia (string param1)
        {
            // /album/(*)!popularmedia 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!popularmedia{1}", param1);

            return RetrieveEntityArrayAsync<AlbumImageEntity>(requestUri).Result; 
        }

        public CatalogSkuPriceEntity[] album____prices (string param1)
        {
            // /album/(*)!prices 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!prices{1}", param1);

            return RetrieveEntityArrayAsync<CatalogSkuPriceEntity>(requestUri).Result; 
        }

        public AlbumShareUrisEntity album____shareuris (string param1)
        {
            // /album/(*)!shareuris 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}!shareuris{1}", param1);

            return RetrieveEntityAsync<AlbumShareUrisEntity>(requestUri).Result; 
        }

        public void album____uploadfromuri (string param1)
        {
            // /album/(*)!uploadfromuri 
            return; 
        }

        public FolderEntity folderuser______ (string param1, string param2)
        {
            // /folder/user/(*)/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}", param1,param2);

            return RetrieveEntityAsync<FolderEntity>(requestUri).Result; 
        }

        public FolderEntity[] folderuser_______parents (string param1, string param2)
        {
            // /folder/user/(*)/(*)!parents 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!parents{2}", param1,param2);

            return RetrieveEntityArrayAsync<FolderEntity>(requestUri).Result; 
        }

        public FolderEntity folderuser___albumName___ (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}", param1,param2);

            return RetrieveEntityAsync<FolderEntity>(requestUri).Result; 
        }

        public FolderEntity[] folderuser___albumName____parents (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!parents 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!parents{2}", param1,param2);

            return RetrieveEntityArrayAsync<FolderEntity>(requestUri).Result; 
        }

        public FolderEntity folderuser___Family___ (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}", param1,param2);

            return RetrieveEntityAsync<FolderEntity>(requestUri).Result; 
        }

        public FolderEntity[] folderuser___Family____parents (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!parents 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!parents{2}", param1,param2);

            return RetrieveEntityArrayAsync<FolderEntity>(requestUri).Result; 
        }

        public FolderEntity folderuser___SmugMug___ (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}", param1,param2);

            return RetrieveEntityAsync<FolderEntity>(requestUri).Result; 
        }

        public FolderEntity[] folderuser___SmugMug____parents (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!parents 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!parents{2}", param1,param2);

            return RetrieveEntityArrayAsync<FolderEntity>(requestUri).Result; 
        }

        public ImageEntity highlightnode___ (string param1)
        {
            // /highlight/node/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/highlight/node/{0}", param1);

            return RetrieveEntityAsync<ImageEntity>(requestUri).Result; 
        }

        public NodeEntity node___ (string param1)
        {
            // /node/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/node/{0}", param1);

            return RetrieveEntityAsync<NodeEntity>(requestUri).Result; 
        }

        public UserEntity user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}", param1);

            return RetrieveEntityAsync<UserEntity>(requestUri).Result; 
        }

        public WatermarkEntity watermark___ (string param1)
        {
            // /watermark/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/watermark/{0}", param1);

            return RetrieveEntityAsync<WatermarkEntity>(requestUri).Result; 
        }
    }
}
