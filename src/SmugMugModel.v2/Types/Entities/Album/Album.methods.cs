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
            return default(ApplyAlbumTemplateEntity); 
        }

        public void album____collectimages (string param1)
        {
            // /album/(*)!collectimages 
             
        }

        public CommentEntity[] album____comments (string param1)
        {
            // /album/(*)!comments 
            return default(CommentEntity[]); 
        }

        public void album____deleteimages (string param1)
        {
            // /album/(*)!deleteimages 
             
        }

        public DownloadEntity[] album____download (string param1)
        {
            // /album/(*)!download 
            return default(DownloadEntity[]); 
        }

        public AlbumImageEntity[] album____geomedia (string param1)
        {
            // /album/(*)!geomedia 
            return default(AlbumImageEntity[]); 
        }

        public GrantEntity[] album____grants (string param1)
        {
            // /album/(*)!grants 
            return default(GrantEntity[]); 
        }

        public AlbumImageEntity album____highlightimage (string param1)
        {
            // /album/(*)!highlightimage 
            return default(AlbumImageEntity); 
        }

        public AlbumImageEntity[] album____images (string param1)
        {
            // /album/(*)!images 
            return default(AlbumImageEntity[]); 
        }

        public void album____moveimages (string param1)
        {
            // /album/(*)!moveimages 
             
        }

        public AlbumImageEntity[] album____popularmedia (string param1)
        {
            // /album/(*)!popularmedia 
            return default(AlbumImageEntity[]); 
        }

        public CatalogSkuPriceEntity[] album____prices (string param1)
        {
            // /album/(*)!prices 
            return default(CatalogSkuPriceEntity[]); 
        }

        public AlbumShareUrisEntity album____shareuris (string param1)
        {
            // /album/(*)!shareuris 
            return default(AlbumShareUrisEntity); 
        }

        public void album____uploadfromuri (string param1)
        {
            // /album/(*)!uploadfromuri 
             
        }

        public FolderEntity folderusersmugmuguser___ (string param1)
        {
            // /folder/user/smugmuguser/(*) 
            return default(FolderEntity); 
        }

        public FolderEntity[] folderusersmugmuguser____parents (string param1)
        {
            // /folder/user/smugmuguser/(*)!parents 
            return default(FolderEntity[]); 
        }

        public FolderEntity folderuser___albumName___ (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*) 
            return default(FolderEntity); 
        }

        public FolderEntity[] folderuser___albumName____parents (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!parents 
            return default(FolderEntity[]); 
        }

        public FolderEntity folderuser___Family___ (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*) 
            return default(FolderEntity); 
        }

        public FolderEntity[] folderuser___Family____parents (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!parents 
            return default(FolderEntity[]); 
        }

        public FolderEntity folderuser___SmugMug___ (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*) 
            return default(FolderEntity); 
        }

        public FolderEntity[] folderuser___SmugMug____parents (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!parents 
            return default(FolderEntity[]); 
        }

        public ImageEntity highlightnode___ (string param1)
        {
            // /highlight/node/(*) 
            return default(ImageEntity); 
        }

        public NodeEntity node___ (string param1)
        {
            // /node/(*) 
            return default(NodeEntity); 
        }

        public UserEntity user___ (string param1)
        {
            // /user/(*) 
            return default(UserEntity); 
        }

        public WatermarkEntity watermark___ (string param1)
        {
            // /watermark/(*) 
            return default(WatermarkEntity); 
        }
    }
}
