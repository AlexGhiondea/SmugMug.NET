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


        private async Task<CatalogSkuEntity> catalogsku___ (string param1)
        {
            // /catalog/sku/(*) 
            string requestUri = string.Format("{0}/catalog/sku/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<CatalogSkuEntity>(requestUri); 
        }

        private async Task catalogsku____buy (string param1)
        {
            // /catalog/sku/(*)!buy 
            string requestUri = string.Format("{0}/catalog/sku/{1}!buy", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }
    }
}
