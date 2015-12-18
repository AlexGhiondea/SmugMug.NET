// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class AlbumImageEntity : SmugMugEntity
    {
        public AlbumImageEntity()
        {
            //Empty constructor to enable deserialization
        }

        public AlbumImageEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public LargestImageEntity image____largestimage (string param1)
        {
            // /image/(*)!largestimage 
            return default(LargestImageEntity); 
        }

        public LargestVideoEntity image____largestvideo (string param1)
        {
            // /image/(*)!largestvideo 
            return default(LargestVideoEntity); 
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

        public ImageEntity image___ (string param1)
        {
            // /image/(*) 
            return default(ImageEntity); 
        }

        public AlbumImageShareUrisEntity ___ZDQXVN____shareuris (string param1, string param2)
        {
            // /(*)/ZDQXVN/(*)!shareuris 
            return default(AlbumImageShareUrisEntity); 
        }
    }
}
