// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
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


        public List<string> GetPatchParameters()
        {
            return new List<string>(){ "Title","Caption","Keywords","KeywordArray","Watermark","Latitude","Longitude","Altitude","Hidden" };
        }


        public async Task<AlbumEntity> album___ (string param1)
        {
            // /album/(*) 
            string requestUri = string.Format("{0}/album/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<AlbumEntity>(requestUri); 
        }

        public async Task<ColorImageEntity> image____color (string param1)
        {
            // /image/(*)!color 
            string requestUri = string.Format("{0}/image/{1}!color", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ColorImageEntity>(requestUri); 
        }

        public async Task<CommentEntity[]> image____comments (string param1)
        {
            // /image/(*)!comments 
            string requestUri = string.Format("{0}/image/{1}!comments", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<CommentEntity>(requestUri); 
        }

        public async Task image____crop (string param1)
        {
            // /image/(*)!crop 
            string requestUri = string.Format("{0}/image/{1}!crop", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task<ImageDownloadEntity> image____download (string param1)
        {
            // /image/(*)!download 
            string requestUri = string.Format("{0}/image/{1}!download", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageDownloadEntity>(requestUri); 
        }

        public async Task<ImageMetadataEntity> image____metadata (string param1)
        {
            // /image/(*)!metadata 
            string requestUri = string.Format("{0}/image/{1}!metadata", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageMetadataEntity>(requestUri); 
        }

        public async Task<CatalogSkuPriceEntity[]> image____prices (string param1)
        {
            // /image/(*)!prices 
            string requestUri = string.Format("{0}/image/{1}!prices", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<CatalogSkuPriceEntity>(requestUri); 
        }

        public async Task image____rotate (string param1)
        {
            // /image/(*)!rotate 
            string requestUri = string.Format("{0}/image/{1}!rotate", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task image____watermark (string param1)
        {
            // /image/(*)!watermark 
            string requestUri = string.Format("{0}/image/{1}!watermark", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task<LargestImageEntity> image____largestimage (string param1)
        {
            // /image/(*)!largestimage 
            string requestUri = string.Format("{0}/image/{1}!largestimage", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<LargestImageEntity>(requestUri); 
        }

        public async Task<ImageSizeDetailsEntity> image____sizedetails (string param1)
        {
            // /image/(*)!sizedetails 
            string requestUri = string.Format("{0}/image/{1}!sizedetails", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeDetailsEntity>(requestUri); 
        }

        public async Task<ImageSizesEntity> image____sizes (string param1)
        {
            // /image/(*)!sizes 
            string requestUri = string.Format("{0}/image/{1}!sizes", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizesEntity>(requestUri); 
        }

        public async Task<LargestVideoEntity> image____largestvideo (string param1)
        {
            // /image/(*)!largestvideo 
            string requestUri = string.Format("{0}/image/{1}!largestvideo", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<LargestVideoEntity>(requestUri); 
        }

        public async Task<UserEntity> user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("{0}/user/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<UserEntity>(requestUri); 
        }

        public async Task<CSMILVideoEntity> video____csmil (string param1)
        {
            // /video/(*)!csmil 
            string requestUri = string.Format("{0}/video/{1}!csmil", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<CSMILVideoEntity>(requestUri); 
        }

        public async Task<EmbedVideoEntity> video____embed (string param1)
        {
            // /video/(*)!embed 
            string requestUri = string.Format("{0}/video/{1}!embed", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<EmbedVideoEntity>(requestUri); 
        }
    }
}
