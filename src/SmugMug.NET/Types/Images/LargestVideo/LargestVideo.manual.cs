// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class LargestVideoEntity : SmugMugEntity
    {

        public async Task<ImageSizeCustomEntity> Fixup_image____sizecustom ()
        {
            // /image/(*)!sizecustom 
            //return await image____sizecustom(string.Empty);

            // /image/(*)!sizecustom 
            string requestUri = string.Format("{0}/image/{1}!sizecustom", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeCustomEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> Fixup_video____size1920 ()
        {
            // /video/(*)!size1920 
            //return await video____size1920(string.Empty);

            // /video/(*)!size1920 
            string requestUri = string.Format("{0}/video/{1}!size1920", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }
    }
}
