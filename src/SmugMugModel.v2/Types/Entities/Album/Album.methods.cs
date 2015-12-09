// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class AlbumEntity : SmugMugEntity
    {

        public AlbumShareUrisEntity album____shareuris ()
        {
            // /album/(*)!shareuris 
            return default(AlbumShareUrisEntity); 
        }

        public NodeEntity node___ ()
        {
            // /node/(*) 
            return default(NodeEntity); 
        }

        public UserEntity user___ ()
        {
            // /user/(*) 
            return default(UserEntity); 
        }

        public FolderEntity folderuser___Family___ ()
        {
            // /folder/user/(*)/Family/(*) 
            return default(FolderEntity); 
        }

        public FolderEntity folderuser___Family____parents ()
        {
            // /folder/user/(*)/Family/(*)!parents 
            return default(FolderEntity); 
        }

        public ImageEntity highlightnode___ ()
        {
            // /highlight/node/(*) 
            return default(ImageEntity); 
        }

        public AlbumImageEntity album____highlightimage ()
        {
            // /album/(*)!highlightimage 
            return default(AlbumImageEntity); 
        }

        public AlbumImageEntity album____images ()
        {
            // /album/(*)!images 
            return default(AlbumImageEntity); 
        }

        public AlbumImageEntity album____popularmedia ()
        {
            // /album/(*)!popularmedia 
            return default(AlbumImageEntity); 
        }

        public AlbumImageEntity album____geomedia ()
        {
            // /album/(*)!geomedia 
            return default(AlbumImageEntity); 
        }

        public CommentEntity album____comments ()
        {
            // /album/(*)!comments 
            return default(CommentEntity); 
        }

        public CatalogSkuPriceEntity album____prices ()
        {
            // /album/(*)!prices 
            return default(CatalogSkuPriceEntity); 
        }

        public FolderEntity folderuser___SmugMug___ ()
        {
            // /folder/user/(*)/SmugMug/(*) 
            return default(FolderEntity); 
        }

        public FolderEntity folderuser___SmugMug____parents ()
        {
            // /folder/user/(*)/SmugMug/(*)!parents 
            return default(FolderEntity); 
        }

        public DownloadEntity album____download ()
        {
            // /album/(*)!download 
            return default(DownloadEntity); 
        }

    }
}
