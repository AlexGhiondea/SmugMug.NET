// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
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


        public async Task<AlbumEntity> album___ (string param1)
        {
            // /album/(*) 
            string requestUri = string.Format("{0}/album/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<AlbumEntity>(requestUri); 
        }

        public async Task<CommentEntity[]> image____comments (string param1)
        {
            // /image/(*)!comments 
            string requestUri = string.Format("{0}/image/{1}!comments", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<CommentEntity>(requestUri); 
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

        public async Task<ImageEntity> image___ (string param1)
        {
            // /image/(*) 
            string requestUri = string.Format("{0}/image/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
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

        public async Task<UserEntity> user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("{0}/user/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<UserEntity>(requestUri); 
        }
    }
}
