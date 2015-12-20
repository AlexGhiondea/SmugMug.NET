// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class LargestVideoEntity : SmugMugEntity
    {
        public LargestVideoEntity()
        {
            //Empty constructor to enable deserialization
        }

        public LargestVideoEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public async Task<ImageSizeCustomEntity> image____sizecustom (string param1)
        {
            // /image/(*)!sizecustom 
            string requestUri = string.Format("{0}/image/{1}!sizecustom", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageSizeCustomEntity>(requestUri); 
        }

        public async Task<VideoSize1920Entity> video____size1920 (string param1)
        {
            // /video/(*)!size1920 
            string requestUri = string.Format("{0}/video/{1}!size1920", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<VideoSize1920Entity>(requestUri); 
        }
    }
}
