// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ImageSizesEntity : SmugMugEntity
    {
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
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!largestimage", param1);

            return await RetrieveEntityAsync<LargestImageEntity>(requestUri); 
        }

        public async Task<LargestVideoEntity> image____largestvideo (string param1)
        {
            // /image/(*)!largestvideo 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!largestvideo", param1);

            return await RetrieveEntityAsync<LargestVideoEntity>(requestUri); 
        }

        public async Task<ImageSizeCustomEntity> image____sizecustom (string param1)
        {
            // /image/(*)!sizecustom 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizecustom", param1);

            return await RetrieveEntityAsync<ImageSizeCustomEntity>(requestUri); 
        }

        public async Task<ImageSizeLargeEntity> image____sizelarge (string param1)
        {
            // /image/(*)!sizelarge 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizelarge", param1);

            return await RetrieveEntityAsync<ImageSizeLargeEntity>(requestUri); 
        }

        public async Task<ImageSizeMediumEntity> image____sizemedium (string param1)
        {
            // /image/(*)!sizemedium 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizemedium", param1);

            return await RetrieveEntityAsync<ImageSizeMediumEntity>(requestUri); 
        }

        public async Task<ImageSizeSmallEntity> image____sizesmall (string param1)
        {
            // /image/(*)!sizesmall 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizesmall", param1);

            return await RetrieveEntityAsync<ImageSizeSmallEntity>(requestUri); 
        }

        public async Task<ImageSizeThumbEntity> image____sizethumb (string param1)
        {
            // /image/(*)!sizethumb 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizethumb", param1);

            return await RetrieveEntityAsync<ImageSizeThumbEntity>(requestUri); 
        }

        public async Task<ImageSizeTinyEntity> image____sizetiny (string param1)
        {
            // /image/(*)!sizetiny 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizetiny", param1);

            return await RetrieveEntityAsync<ImageSizeTinyEntity>(requestUri); 
        }

        public async Task<ImageSizeX2LargeEntity> image____sizex2large (string param1)
        {
            // /image/(*)!sizex2large 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizex2large", param1);

            return await RetrieveEntityAsync<ImageSizeX2LargeEntity>(requestUri); 
        }

        public async Task<ImageSizeX3LargeEntity> image____sizex3large (string param1)
        {
            // /image/(*)!sizex3large 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizex3large", param1);

            return await RetrieveEntityAsync<ImageSizeX3LargeEntity>(requestUri); 
        }

        public async Task<ImageSizeXLargeEntity> image____sizexlarge (string param1)
        {
            // /image/(*)!sizexlarge 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizexlarge", param1);

            return await RetrieveEntityAsync<ImageSizeXLargeEntity>(requestUri); 
        }

        public async Task<ImageSizeOriginalEntity> image____sizeoriginal (string param1)
        {
            // /image/(*)!sizeoriginal 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizeoriginal", param1);

            return await RetrieveEntityAsync<ImageSizeOriginalEntity>(requestUri); 
        }

        public async Task<VideoSize110Entity> video____size110 (string param1)
        {
            // /video/(*)!size110 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!size110", param1);

            return await RetrieveEntityAsync<VideoSize110Entity>(requestUri); 
        }

        public async Task<VideoSize1280Entity> video____size1280 (string param1)
        {
            // /video/(*)!size1280 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!size1280", param1);

            return await RetrieveEntityAsync<VideoSize1280Entity>(requestUri); 
        }

        public async Task<VideoSize1920Entity> video____size1920 (string param1)
        {
            // /video/(*)!size1920 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!size1920", param1);

            return await RetrieveEntityAsync<VideoSize1920Entity>(requestUri); 
        }

        public async Task<VideoSize200Entity> video____size200 (string param1)
        {
            // /video/(*)!size200 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!size200", param1);

            return await RetrieveEntityAsync<VideoSize200Entity>(requestUri); 
        }

        public async Task<VideoSize320Entity> video____size320 (string param1)
        {
            // /video/(*)!size320 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!size320", param1);

            return await RetrieveEntityAsync<VideoSize320Entity>(requestUri); 
        }

        public async Task<VideoSize640Entity> video____size640 (string param1)
        {
            // /video/(*)!size640 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!size640", param1);

            return await RetrieveEntityAsync<VideoSize640Entity>(requestUri); 
        }

        public async Task<VideoSize960Entity> video____size960 (string param1)
        {
            // /video/(*)!size960 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!size960", param1);

            return await RetrieveEntityAsync<VideoSize960Entity>(requestUri); 
        }

        public async Task<VideoSMILEntity> video____smil (string param1)
        {
            // /video/(*)!smil 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!smil", param1);

            return await RetrieveEntityAsync<VideoSMILEntity>(requestUri); 
        }
    }
}
