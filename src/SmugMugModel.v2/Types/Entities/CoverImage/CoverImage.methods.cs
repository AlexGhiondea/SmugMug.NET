// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CoverImageEntity : SmugMugEntity
    {
        public CoverImageEntity()
        {
            //Empty constructor to enable deserialization
        }

        public CoverImageEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public AlbumEntity album___ (string param1)
        {
            // /album/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}", param1);

            return RetrieveEntityAsync<AlbumEntity>(requestUri).Result; 
        }

        public CommentEntity[] image____comments (string param1)
        {
            // /image/(*)!comments 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!comments{1}", param1);

            return RetrieveEntityArrayAsync<CommentEntity>(requestUri).Result; 
        }

        public ImageDownloadEntity image____download (string param1)
        {
            // /image/(*)!download 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!download{1}", param1);

            return RetrieveEntityAsync<ImageDownloadEntity>(requestUri).Result; 
        }

        public ImageMetadataEntity image____metadata (string param1)
        {
            // /image/(*)!metadata 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!metadata{1}", param1);

            return RetrieveEntityAsync<ImageMetadataEntity>(requestUri).Result; 
        }

        public CatalogSkuPriceEntity[] image____prices (string param1)
        {
            // /image/(*)!prices 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!prices{1}", param1);

            return RetrieveEntityArrayAsync<CatalogSkuPriceEntity>(requestUri).Result; 
        }

        public ImageEntity image___ (string param1)
        {
            // /image/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}", param1);

            return RetrieveEntityAsync<ImageEntity>(requestUri).Result; 
        }

        public LargestImageEntity image____largestimage (string param1)
        {
            // /image/(*)!largestimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!largestimage{1}", param1);

            return RetrieveEntityAsync<LargestImageEntity>(requestUri).Result; 
        }

        public ImageSizeDetailsEntity image____sizedetails (string param1)
        {
            // /image/(*)!sizedetails 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizedetails{1}", param1);

            return RetrieveEntityAsync<ImageSizeDetailsEntity>(requestUri).Result; 
        }

        public ImageSizesEntity image____sizes (string param1)
        {
            // /image/(*)!sizes 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizes{1}", param1);

            return RetrieveEntityAsync<ImageSizesEntity>(requestUri).Result; 
        }

        public UserEntity user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}", param1);

            return RetrieveEntityAsync<UserEntity>(requestUri).Result; 
        }
    }
}
