// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class VideoSize200Entity : SmugMugEntity
    {
        public VideoSize200Entity()
        {
            //Empty constructor to enable deserialization
        }

        public VideoSize200Entity(OAuthToken oauthToken)
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
    }
}
