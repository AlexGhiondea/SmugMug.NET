// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ImageDownloadEntity : SmugMugEntity
    {
        public ImageDownloadEntity()
        {
            //Empty constructor to enable deserialization
        }

        public ImageDownloadEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public async Task<ImageEntity> image___ (string param1)
        {
            // /image/(*) 
            string requestUri = string.Format("{0}/image/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }
    }
}
