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

        public async Task<ImageSizeLargeEntity> image____sizelarge (string param1)
        {
            // /image/(*)!sizelarge 
            string requestUri = string.Format("{0}/image/{1}!sizelarge", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeLargeEntity>(requestUri); 
        }

        public async Task<ImageSizeMediumEntity> image____sizemedium (string param1)
        {
            // /image/(*)!sizemedium 
            string requestUri = string.Format("{0}/image/{1}!sizemedium", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeMediumEntity>(requestUri); 
        }

        public async Task<ImageSizeSmallEntity> image____sizesmall (string param1)
        {
            // /image/(*)!sizesmall 
            string requestUri = string.Format("{0}/image/{1}!sizesmall", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeSmallEntity>(requestUri); 
        }

        public async Task<ImageSizeThumbEntity> image____sizethumb (string param1)
        {
            // /image/(*)!sizethumb 
            string requestUri = string.Format("{0}/image/{1}!sizethumb", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeThumbEntity>(requestUri); 
        }

        public async Task<ImageSizeTinyEntity> image____sizetiny (string param1)
        {
            // /image/(*)!sizetiny 
            string requestUri = string.Format("{0}/image/{1}!sizetiny", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeTinyEntity>(requestUri); 
        }

        public async Task<ImageSizeX2LargeEntity> image____sizex2large (string param1)
        {
            // /image/(*)!sizex2large 
            string requestUri = string.Format("{0}/image/{1}!sizex2large", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeX2LargeEntity>(requestUri); 
        }

        public async Task<ImageSizeX3LargeEntity> image____sizex3large (string param1)
        {
            // /image/(*)!sizex3large 
            string requestUri = string.Format("{0}/image/{1}!sizex3large", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeX3LargeEntity>(requestUri); 
        }

        public async Task<ImageSizeXLargeEntity> image____sizexlarge (string param1)
        {
            // /image/(*)!sizexlarge 
            string requestUri = string.Format("{0}/image/{1}!sizexlarge", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeXLargeEntity>(requestUri); 
        }

        public async Task<ImageSizeOriginalEntity> image____sizeoriginal (string param1)
        {
            // /image/(*)!sizeoriginal 
            string requestUri = string.Format("{0}/image/{1}!sizeoriginal", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeOriginalEntity>(requestUri); 
        }

        public async Task<VideoSize110Entity> video____size110 (string param1)
        {
            // /video/(*)!size110 
            string requestUri = string.Format("{0}/video/{1}!size110", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<VideoSize110Entity>(requestUri); 
        }

        public async Task<VideoSize1280Entity> video____size1280 (string param1)
        {
            // /video/(*)!size1280 
            string requestUri = string.Format("{0}/video/{1}!size1280", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<VideoSize1280Entity>(requestUri); 
        }

        public async Task<VideoSize1920Entity> video____size1920 (string param1)
        {
            // /video/(*)!size1920 
            string requestUri = string.Format("{0}/video/{1}!size1920", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<VideoSize1920Entity>(requestUri); 
        }

        public async Task<VideoSize200Entity> video____size200 (string param1)
        {
            // /video/(*)!size200 
            string requestUri = string.Format("{0}/video/{1}!size200", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<VideoSize200Entity>(requestUri); 
        }

        public async Task<VideoSize320Entity> video____size320 (string param1)
        {
            // /video/(*)!size320 
            string requestUri = string.Format("{0}/video/{1}!size320", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<VideoSize320Entity>(requestUri); 
        }

        public async Task<VideoSize640Entity> video____size640 (string param1)
        {
            // /video/(*)!size640 
            string requestUri = string.Format("{0}/video/{1}!size640", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<VideoSize640Entity>(requestUri); 
        }

        public async Task<VideoSize960Entity> video____size960 (string param1)
        {
            // /video/(*)!size960 
            string requestUri = string.Format("{0}/video/{1}!size960", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<VideoSize960Entity>(requestUri); 
        }

        public async Task<VideoSMILEntity> video____smil (string param1)
        {
            // /video/(*)!smil 
            string requestUri = string.Format("{0}/video/{1}!smil", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<VideoSMILEntity>(requestUri); 
        }
    }
}
