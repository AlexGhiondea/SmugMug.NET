// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class CoverImageEntity : SmugMugEntity
    {

        public LargestImageEntity image____largestimage (string param1)
        {
            // /image/(*)!largestimage 
            return default(LargestImageEntity); 
        }

        public ImageSizesEntity image____sizes (string param1)
        {
            // /image/(*)!sizes 
            return default(ImageSizesEntity); 
        }

        public ImageSizeDetailsEntity image____sizedetails (string param1)
        {
            // /image/(*)!sizedetails 
            return default(ImageSizeDetailsEntity); 
        }

        public AlbumEntity album___ (string param1)
        {
            // /album/(*) 
            return default(AlbumEntity); 
        }

        public ImageDownloadEntity image____download (string param1)
        {
            // /image/(*)!download 
            return default(ImageDownloadEntity); 
        }

        public UserEntity user___ (string param1)
        {
            // /user/(*) 
            return default(UserEntity); 
        }

        public CommentEntity image____comments (string param1)
        {
            // /image/(*)!comments 
            return default(CommentEntity); 
        }

        public ImageMetadataEntity image____metadata (string param1)
        {
            // /image/(*)!metadata 
            return default(ImageMetadataEntity); 
        }

        public CatalogSkuPriceEntity image____prices (string param1)
        {
            // /image/(*)!prices 
            return default(CatalogSkuPriceEntity); 
        }

        public ImageEntity image___ (string param1)
        {
            // /image/(*) 
            return default(ImageEntity); 
        }

    }
}
