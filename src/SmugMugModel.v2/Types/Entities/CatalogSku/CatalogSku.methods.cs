// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogSkuEntity : SmugMugEntity
    {
        public CatalogSkuEntity()
        {
            //Empty constructor to enable deserialization
        }

        public CatalogSkuEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public async Task<CatalogProductEntity> catalogproduct___ (string param1)
        {
            // /catalog/product/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/catalog/product/{0}", param1);

            return await RetrieveEntityAsync<CatalogProductEntity>(requestUri); 
        }

        public async Task catalogsku____buy (string param1)
        {
            // /catalog/sku/(*)!buy 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/catalog/sku/{0}!buy", param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task<CatalogSkuPriceEntity> catalogsku____price (string param1)
        {
            // /catalog/sku/(*)!price 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/catalog/sku/{0}!price", param1);

            return await RetrieveEntityAsync<CatalogSkuPriceEntity>(requestUri); 
        }

        public async Task<CatalogSkuTypeEntity> catalogskutypeoptionfinish___ (string param1)
        {
            // /catalog/skutype/option/finish/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/catalog/skutype/option/finish/{0}", param1);

            return await RetrieveEntityAsync<CatalogSkuTypeEntity>(requestUri); 
        }
    }
}
