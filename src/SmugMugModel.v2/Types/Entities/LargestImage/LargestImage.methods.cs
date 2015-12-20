// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class LargestImageEntity : SmugMugEntity
    {
        public LargestImageEntity()
        {
            //Empty constructor to enable deserialization
        }

        public LargestImageEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public ImageSizeX3LargeEntity image____sizex3large (string param1)
        {
            // /image/(*)!sizex3large 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizex3large{1}", param1);

            return RetrieveEntityAsync<ImageSizeX3LargeEntity>(requestUri).Result; 
        }

        public ImageSizeOriginalEntity image____sizeoriginal (string param1)
        {
            // /image/(*)!sizeoriginal 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizeoriginal{1}", param1);

            return RetrieveEntityAsync<ImageSizeOriginalEntity>(requestUri).Result; 
        }

        public ImageSizeXLargeEntity image____sizexlarge (string param1)
        {
            // /image/(*)!sizexlarge 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/image/{0}!sizexlarge{1}", param1);

            return RetrieveEntityAsync<ImageSizeXLargeEntity>(requestUri).Result; 
        }
    }
}
