// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    [Obsolete]
    public partial class ImageEntity : SmugMugEntity
    {
        public ImageEntity()
        {
            //Empty constructor to enable deserialization
        }

        public ImageEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


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

        public CommentEntity[] image____comments (string param1)
        {
            // /image/(*)!comments 
            return default(CommentEntity[]); 
        }

        public void image____rotate (string param1)
        {
            // /image/(*)!rotate 
             
        }

        public ColorImageEntity image____color (string param1)
        {
            // /image/(*)!color 
            return default(ColorImageEntity); 
        }

        public void image____crop (string param1)
        {
            // /image/(*)!crop 
             
        }

        public void image____watermark (string param1)
        {
            // /image/(*)!watermark 
             
        }

        public ImageMetadataEntity image____metadata (string param1)
        {
            // /image/(*)!metadata 
            return default(ImageMetadataEntity); 
        }

        public CatalogSkuPriceEntity[] image____prices (string param1)
        {
            // /image/(*)!prices 
            return default(CatalogSkuPriceEntity[]); 
        }

        public LargestVideoEntity image____largestvideo (string param1)
        {
            // /image/(*)!largestvideo 
            return default(LargestVideoEntity); 
        }

        public EmbedVideoEntity video____embed (string param1)
        {
            // /video/(*)!embed 
            return default(EmbedVideoEntity); 
        }

        public CSMILVideoEntity video____csmil (string param1)
        {
            // /video/(*)!csmil 
            return default(CSMILVideoEntity); 
        }
    }
}
