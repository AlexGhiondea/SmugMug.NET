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


        public AlbumEntity album___ (string param1)
        {
            // /album/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}", param1);

            return RetrieveEntityAsync<AlbumEntity>(requestUri).Result; 
        }

        public AlbumImageShareUrisEntity album___image____shareuris (string param1, string param2)
        {
            // /album/(*)/image/(*)!shareuris 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}/image/{1}!shareuris", param1,param2);

            return RetrieveEntityAsync<AlbumImageShareUrisEntity>(requestUri).Result; 
        }

        public ColorImageEntity image____color (string param1)
        {
            // /image/(*)!color 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!color", param1);

            return RetrieveEntityAsync<ColorImageEntity>(requestUri).Result; 
        }

        public CommentEntity[] image____comments (string param1)
        {
            // /image/(*)!comments 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!comments", param1);

            return RetrieveEntityArrayAsync<CommentEntity>(requestUri).Result; 
        }

        public void image____crop (string param1)
        {
            // /image/(*)!crop 
            return; 
        }

        public ImageDownloadEntity image____download (string param1)
        {
            // /image/(*)!download 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!download", param1);

            return RetrieveEntityAsync<ImageDownloadEntity>(requestUri).Result; 
        }

        public ImageMetadataEntity image____metadata (string param1)
        {
            // /image/(*)!metadata 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!metadata", param1);

            return RetrieveEntityAsync<ImageMetadataEntity>(requestUri).Result; 
        }

        public CatalogSkuPriceEntity[] image____prices (string param1)
        {
            // /image/(*)!prices 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!prices", param1);

            return RetrieveEntityArrayAsync<CatalogSkuPriceEntity>(requestUri).Result; 
        }

        public void image____rotate (string param1)
        {
            // /image/(*)!rotate 
            return; 
        }

        public void image____watermark (string param1)
        {
            // /image/(*)!watermark 
            return; 
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
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!largestimage", param1);

            return RetrieveEntityAsync<LargestImageEntity>(requestUri).Result; 
        }

        public ImageSizeDetailsEntity image____sizedetails (string param1)
        {
            // /image/(*)!sizedetails 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizedetails", param1);

            return RetrieveEntityAsync<ImageSizeDetailsEntity>(requestUri).Result; 
        }

        public ImageSizesEntity image____sizes (string param1)
        {
            // /image/(*)!sizes 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizes", param1);

            return RetrieveEntityAsync<ImageSizesEntity>(requestUri).Result; 
        }

        public LargestVideoEntity image____largestvideo (string param1)
        {
            // /image/(*)!largestvideo 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!largestvideo", param1);

            return RetrieveEntityAsync<LargestVideoEntity>(requestUri).Result; 
        }

        public UserEntity user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}", param1);

            return RetrieveEntityAsync<UserEntity>(requestUri).Result; 
        }

        public CSMILVideoEntity video____csmil (string param1)
        {
            // /video/(*)!csmil 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!csmil", param1);

            return RetrieveEntityAsync<CSMILVideoEntity>(requestUri).Result; 
        }

        public EmbedVideoEntity video____embed (string param1)
        {
            // /video/(*)!embed 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!embed", param1);

            return RetrieveEntityAsync<EmbedVideoEntity>(requestUri).Result; 
        }
    }
}
