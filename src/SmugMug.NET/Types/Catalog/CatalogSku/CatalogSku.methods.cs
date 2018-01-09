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


        private async Task<CatalogProductEntity> catalogproduct___ (string param1)
        {
            // /catalog/product/(*) 
            string requestUri = string.Format("{0}/catalog/product/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<CatalogProductEntity>(requestUri); 
        }

        private async Task catalogsku____buy (string param1)
        {
            // /catalog/sku/(*)!buy 
            string requestUri = string.Format("{0}/catalog/sku/{1}!buy", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        private async Task<CatalogSkuPriceEntity> catalogsku____price (string param1)
        {
            // /catalog/sku/(*)!price 
            string requestUri = string.Format("{0}/catalog/sku/{1}!price", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<CatalogSkuPriceEntity>(requestUri); 
        }

        private async Task<CatalogSkuTypeEntity> catalogskutypeoptionfinish___ (string param1)
        {
            // /catalog/skutype/option/finish/(*) 
            string requestUri = string.Format("{0}/catalog/skutype/option/finish/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<CatalogSkuTypeEntity>(requestUri); 
        }
    }
}
