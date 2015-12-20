// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
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


        public async Task<AlbumEntity> album___ (string param1)
        {
            // /album/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}", param1);

            return await RetrieveEntityAsync<AlbumEntity>(requestUri); 
        }

        public async Task<AlbumImageShareUrisEntity> album___image____shareuris (string param1, string param2)
        {
            // /album/(*)/image/(*)!shareuris 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}/image/{1}!shareuris", param1,param2);

            return await RetrieveEntityAsync<AlbumImageShareUrisEntity>(requestUri); 
        }

        public async Task<ColorImageEntity> image____color (string param1)
        {
            // /image/(*)!color 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!color", param1);

            return await RetrieveEntityAsync<ColorImageEntity>(requestUri); 
        }

        public async Task<CommentEntity[]> image____comments (string param1)
        {
            // /image/(*)!comments 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!comments", param1);

            return await RetrieveEntityArrayAsync<CommentEntity>(requestUri); 
        }

        public async Task image____crop (string param1)
        {
            // /image/(*)!crop 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!crop", param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task<ImageDownloadEntity> image____download (string param1)
        {
            // /image/(*)!download 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!download", param1);

            return await RetrieveEntityAsync<ImageDownloadEntity>(requestUri); 
        }

        public async Task<ImageMetadataEntity> image____metadata (string param1)
        {
            // /image/(*)!metadata 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!metadata", param1);

            return await RetrieveEntityAsync<ImageMetadataEntity>(requestUri); 
        }

        public async Task<CatalogSkuPriceEntity[]> image____prices (string param1)
        {
            // /image/(*)!prices 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!prices", param1);

            return await RetrieveEntityArrayAsync<CatalogSkuPriceEntity>(requestUri); 
        }

        public async Task image____rotate (string param1)
        {
            // /image/(*)!rotate 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!rotate", param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task image____watermark (string param1)
        {
            // /image/(*)!watermark 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!watermark", param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task<ImageEntity> image___ (string param1)
        {
            // /image/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}", param1);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        public async Task<LargestImageEntity> image____largestimage (string param1)
        {
            // /image/(*)!largestimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!largestimage", param1);

            return await RetrieveEntityAsync<LargestImageEntity>(requestUri); 
        }

        public async Task<ImageSizeDetailsEntity> image____sizedetails (string param1)
        {
            // /image/(*)!sizedetails 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizedetails", param1);

            return await RetrieveEntityAsync<ImageSizeDetailsEntity>(requestUri); 
        }

        public async Task<ImageSizesEntity> image____sizes (string param1)
        {
            // /image/(*)!sizes 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizes", param1);

            return await RetrieveEntityAsync<ImageSizesEntity>(requestUri); 
        }

        public async Task<LargestVideoEntity> image____largestvideo (string param1)
        {
            // /image/(*)!largestvideo 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!largestvideo", param1);

            return await RetrieveEntityAsync<LargestVideoEntity>(requestUri); 
        }

        public async Task<UserEntity> user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}", param1);

            return await RetrieveEntityAsync<UserEntity>(requestUri); 
        }

        public async Task<CSMILVideoEntity> video____csmil (string param1)
        {
            // /video/(*)!csmil 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!csmil", param1);

            return await RetrieveEntityAsync<CSMILVideoEntity>(requestUri); 
        }

        public async Task<EmbedVideoEntity> video____embed (string param1)
        {
            // /video/(*)!embed 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!embed", param1);

            return await RetrieveEntityAsync<EmbedVideoEntity>(requestUri); 
        }
    }
}
