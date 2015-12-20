// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
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


        public LargestImageEntity image____largestimage (string param1)
        {
            // /image/(*)!largestimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!largestimage{1}", param1);

            return RetrieveEntityAsync<LargestImageEntity>(requestUri).Result; 
        }

        public LargestVideoEntity image____largestvideo (string param1)
        {
            // /image/(*)!largestvideo 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!largestvideo{1}", param1);

            return RetrieveEntityAsync<LargestVideoEntity>(requestUri).Result; 
        }

        public ImageSizeCustomEntity image____sizecustom (string param1)
        {
            // /image/(*)!sizecustom 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizecustom{1}", param1);

            return RetrieveEntityAsync<ImageSizeCustomEntity>(requestUri).Result; 
        }

        public ImageSizeLargeEntity image____sizelarge (string param1)
        {
            // /image/(*)!sizelarge 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizelarge{1}", param1);

            return RetrieveEntityAsync<ImageSizeLargeEntity>(requestUri).Result; 
        }

        public ImageSizeMediumEntity image____sizemedium (string param1)
        {
            // /image/(*)!sizemedium 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizemedium{1}", param1);

            return RetrieveEntityAsync<ImageSizeMediumEntity>(requestUri).Result; 
        }

        public ImageSizeSmallEntity image____sizesmall (string param1)
        {
            // /image/(*)!sizesmall 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizesmall{1}", param1);

            return RetrieveEntityAsync<ImageSizeSmallEntity>(requestUri).Result; 
        }

        public ImageSizeThumbEntity image____sizethumb (string param1)
        {
            // /image/(*)!sizethumb 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizethumb{1}", param1);

            return RetrieveEntityAsync<ImageSizeThumbEntity>(requestUri).Result; 
        }

        public ImageSizeTinyEntity image____sizetiny (string param1)
        {
            // /image/(*)!sizetiny 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizetiny{1}", param1);

            return RetrieveEntityAsync<ImageSizeTinyEntity>(requestUri).Result; 
        }

        public ImageSizeX2LargeEntity image____sizex2large (string param1)
        {
            // /image/(*)!sizex2large 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizex2large{1}", param1);

            return RetrieveEntityAsync<ImageSizeX2LargeEntity>(requestUri).Result; 
        }

        public ImageSizeX3LargeEntity image____sizex3large (string param1)
        {
            // /image/(*)!sizex3large 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizex3large{1}", param1);

            return RetrieveEntityAsync<ImageSizeX3LargeEntity>(requestUri).Result; 
        }

        public ImageSizeXLargeEntity image____sizexlarge (string param1)
        {
            // /image/(*)!sizexlarge 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizexlarge{1}", param1);

            return RetrieveEntityAsync<ImageSizeXLargeEntity>(requestUri).Result; 
        }

        public ImageSizeOriginalEntity image____sizeoriginal (string param1)
        {
            // /image/(*)!sizeoriginal 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizeoriginal{1}", param1);

            return RetrieveEntityAsync<ImageSizeOriginalEntity>(requestUri).Result; 
        }

        public VideoSize110Entity video____size110 (string param1)
        {
            // /video/(*)!size110 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!size110{1}", param1);

            return RetrieveEntityAsync<VideoSize110Entity>(requestUri).Result; 
        }

        public VideoSize1280Entity video____size1280 (string param1)
        {
            // /video/(*)!size1280 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!size1280{1}", param1);

            return RetrieveEntityAsync<VideoSize1280Entity>(requestUri).Result; 
        }

        public VideoSize1920Entity video____size1920 (string param1)
        {
            // /video/(*)!size1920 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!size1920{1}", param1);

            return RetrieveEntityAsync<VideoSize1920Entity>(requestUri).Result; 
        }

        public VideoSize200Entity video____size200 (string param1)
        {
            // /video/(*)!size200 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!size200{1}", param1);

            return RetrieveEntityAsync<VideoSize200Entity>(requestUri).Result; 
        }

        public VideoSize320Entity video____size320 (string param1)
        {
            // /video/(*)!size320 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!size320{1}", param1);

            return RetrieveEntityAsync<VideoSize320Entity>(requestUri).Result; 
        }

        public VideoSize640Entity video____size640 (string param1)
        {
            // /video/(*)!size640 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!size640{1}", param1);

            return RetrieveEntityAsync<VideoSize640Entity>(requestUri).Result; 
        }

        public VideoSize960Entity video____size960 (string param1)
        {
            // /video/(*)!size960 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!size960{1}", param1);

            return RetrieveEntityAsync<VideoSize960Entity>(requestUri).Result; 
        }

        public VideoSMILEntity video____smil (string param1)
        {
            // /video/(*)!smil 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/video/{0}!smil{1}", param1);

            return RetrieveEntityAsync<VideoSMILEntity>(requestUri).Result; 
        }
    }
}
