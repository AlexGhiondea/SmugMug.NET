// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogSkuPriceEntity : SmugMugEntity
    {
        public CatalogSkuPriceEntity()
        {
            //Empty constructor to enable deserialization
        }

        public CatalogSkuPriceEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public async Task<CatalogSkuEntity> catalogsku___ (string param1)
        {
            // /catalog/sku/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/catalog/sku/{0}", param1);

            return await RetrieveEntityAsync<CatalogSkuEntity>(requestUri); 
        }

        public async Task catalogsku____buy (string param1)
        {
            // /catalog/sku/(*)!buy 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/catalog/sku/{0}!buy", param1);

            await GetRequestAsync(requestUri); 
        }
    }
}
