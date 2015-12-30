// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ImageSizesEntity : SmugMugEntity
    {
        public override string EntityId
        {
            get
            {
                //TODO: This is not necessarily the best way to do this.
                return this.ParentEntity.EntityId;
            }
        }
        public ImageSizesEntity()
        {
            //Empty constructor to enable deserialization
        }

        public ImageSizesEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public async Task<LargestImageEntity> image____largestimage (string param1)
        {
            // /image/(*)!largestimage 
            string requestUri = string.Format("{0}/image/{1}!largestimage", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<LargestImageEntity>(requestUri); 
        }

        public async Task<LargestVideoEntity> image____largestvideo (string param1)
        {
            // /image/(*)!largestvideo 
            string requestUri = string.Format("{0}/image/{1}!largestvideo", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<LargestVideoEntity>(requestUri); 
        }

        public async Task<ImageSizeCustomEntity> image____sizecustom (string param1)
        {
            // /image/(*)!sizecustom 
            string requestUri = string.Format("{0}/image/{1}!sizecustom", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeCustomEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> image____sizelarge (string param1)
        {
            // /image/(*)!sizelarge 
            string requestUri = string.Format("{0}/image/{1}!sizelarge", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> image____sizemedium (string param1)
        {
            // /image/(*)!sizemedium 
            string requestUri = string.Format("{0}/image/{1}!sizemedium", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> image____sizesmall (string param1)
        {
            // /image/(*)!sizesmall 
            string requestUri = string.Format("{0}/image/{1}!sizesmall", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> image____sizethumb (string param1)
        {
            // /image/(*)!sizethumb 
            string requestUri = string.Format("{0}/image/{1}!sizethumb", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> image____sizetiny (string param1)
        {
            // /image/(*)!sizetiny 
            string requestUri = string.Format("{0}/image/{1}!sizetiny", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> image____sizex2large (string param1)
        {
            // /image/(*)!sizex2large 
            string requestUri = string.Format("{0}/image/{1}!sizex2large", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> image____sizex3large (string param1)
        {
            // /image/(*)!sizex3large 
            string requestUri = string.Format("{0}/image/{1}!sizex3large", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> image____sizexlarge (string param1)
        {
            // /image/(*)!sizexlarge 
            string requestUri = string.Format("{0}/image/{1}!sizexlarge", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> image____sizeoriginal (string param1)
        {
            // /image/(*)!sizeoriginal 
            string requestUri = string.Format("{0}/image/{1}!sizeoriginal", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> video____size110 (string param1)
        {
            // /video/(*)!size110 
            string requestUri = string.Format("{0}/video/{1}!size110", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> video____size1280 (string param1)
        {
            // /video/(*)!size1280 
            string requestUri = string.Format("{0}/video/{1}!size1280", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> video____size1920 (string param1)
        {
            // /video/(*)!size1920 
            string requestUri = string.Format("{0}/video/{1}!size1920", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> video____size200 (string param1)
        {
            // /video/(*)!size200 
            string requestUri = string.Format("{0}/video/{1}!size200", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> video____size320 (string param1)
        {
            // /video/(*)!size320 
            string requestUri = string.Format("{0}/video/{1}!size320", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> video____size640 (string param1)
        {
            // /video/(*)!size640 
            string requestUri = string.Format("{0}/video/{1}!size640", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> video____size960 (string param1)
        {
            // /video/(*)!size960 
            string requestUri = string.Format("{0}/video/{1}!size960", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }

        public async Task<ImageSizeEntity> video____smil (string param1)
        {
            // /video/(*)!smil 
            string requestUri = string.Format("{0}/video/{1}!smil", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri); 
        }
    }
}
