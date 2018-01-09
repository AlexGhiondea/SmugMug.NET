// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class LargestImageEntity : SmugMugEntity
    {

        public async Task<ImageSizeEntity> GetImageSizeX3LargeAsync()
        {
            // /image/(*)!sizex3large 
            // return await image____sizex3large();

            // /image/(*)!sizex3large 
            string requestUri = string.Format("{0}/image/{1}!sizex3large", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetImageSizeOriginalAsync()
        {
            // /image/(*)!sizeoriginal 
            //return await image____sizeoriginal();

            // /image/(*)!sizeoriginal 
            string requestUri = string.Format("{0}/image/{1}!sizeoriginal", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetImageSizeXLargeAsync()
        {
            // /image/(*)!sizexlarge 
            //return await image____sizexlarge(Parent.EntityId + "-0");

            // /image/(*)!sizexlarge 
            string requestUri = string.Format("{0}/image/{1}!sizexlarge", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }
    }
}
