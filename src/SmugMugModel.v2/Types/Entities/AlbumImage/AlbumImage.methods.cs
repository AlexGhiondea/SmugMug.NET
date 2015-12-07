// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class AlbumImageEntity : SmugMugEntity
    {

        public LargestImageEntity image____largestimage ()
        {
            // /image/(*)!largestimage 
            return default(LargestImageEntity); 
        }

        public LargestVideoEntity image____largestvideo ()
        {
            // /image/(*)!largestvideo 
            return default(LargestVideoEntity); 
        }

        public ImageSizesEntity image____sizes ()
        {
            // /image/(*)!sizes 
            return default(ImageSizesEntity); 
        }

        public ImageSizeDetailsEntity image____sizedetails ()
        {
            // /image/(*)!sizedetails 
            return default(ImageSizeDetailsEntity); 
        }

        public AlbumEntity album___ ()
        {
            // /album/(*) 
            return default(AlbumEntity); 
        }

        public UserEntity user___ ()
        {
            // /user/(*) 
            return default(UserEntity); 
        }

        public CommentEntity image____comments ()
        {
            // /image/(*)!comments 
            return default(CommentEntity); 
        }

        public EmbedVideoEntity video____embed ()
        {
            // /video/(*)!embed 
            return default(EmbedVideoEntity); 
        }

        public CSMILVideoEntity video____csmil ()
        {
            // /video/(*)!csmil 
            return default(CSMILVideoEntity); 
        }

        public ImageMetadataEntity image____metadata ()
        {
            // /image/(*)!metadata 
            return default(ImageMetadataEntity); 
        }

        public CatalogSkuPriceEntity image____prices ()
        {
            // /image/(*)!prices 
            return default(CatalogSkuPriceEntity); 
        }

        public ImageEntity image___ ()
        {
            // /image/(*) 
            return default(ImageEntity); 
        }

        public AlbumImageShareUrisEntity ___ZDQXVN____shareuris ()
        {
            // /(*)/ZDQXVN/(*)!shareuris 
            return default(AlbumImageShareUrisEntity); 
        }

    }
}
