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

        protected override IEnumerable<string> GetPatchPropertiesName()
        {
            return PatchParameters;
        }

        private static readonly List<string> PatchParameters = new List<string>(){ "Title","Caption","Keywords","KeywordArray","Watermark","Latitude","Longitude","Altitude","Hidden" };

        private async Task<ColorImageEntity> image____color (string param1)
        {
            // /image/(*)!color 
            string requestUri = string.Format("{0}/image/{1}!color", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ColorImageEntity>(requestUri); 
        }

        private async Task image____crop (string param1)
        {
            // /image/(*)!crop 
            string requestUri = string.Format("{0}/image/{1}!crop", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        private async Task image____rotate (string param1)
        {
            // /image/(*)!rotate 
            string requestUri = string.Format("{0}/image/{1}!rotate", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        private async Task image____watermark(string param1)
        {
            // /image/(*)!watermark 
            string requestUri = string.Format("{0}/image/{1}!watermark", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri);
        }
    }
}
