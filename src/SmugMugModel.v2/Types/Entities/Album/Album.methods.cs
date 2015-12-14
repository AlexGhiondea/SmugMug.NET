// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class AlbumEntity : SmugMugEntity
    {

        public AlbumShareUrisEntity album____shareuris (string param1)
        {
            // /album/(*)!shareuris 
            return default(AlbumShareUrisEntity); 
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

        public ImageEntity highlightnode___ (string param1)
        {
            // /highlight/node/(*) 
            return default(ImageEntity); 
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

        public AlbumImageEntity[] album____popularmedia (string param1)
        {
            // /album/(*)!popularmedia 
            return default(AlbumImageEntity[]); 
        }

        public AlbumImageEntity[] album____geomedia (string param1)
        {
            // /album/(*)!geomedia 
            return default(AlbumImageEntity[]); 
        }

        public CommentEntity[] album____comments (string param1)
        {
            // /album/(*)!comments 
            return default(CommentEntity[]); 
        }

        public CatalogSkuPriceEntity[] album____prices (string param1)
        {
            // /album/(*)!prices 
            return default(CatalogSkuPriceEntity[]); 
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

        public DownloadEntity[] album____download (string param1)
        {
            // /album/(*)!download 
            return default(DownloadEntity[]); 
        }

    }
}
