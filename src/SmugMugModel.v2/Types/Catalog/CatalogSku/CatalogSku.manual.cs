// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogSkuEntity : SmugMugEntity
    {

        public async Task<CatalogProductEntity> Fixup_catalogproduct___()
        {
            // /catalog/product/(*) 
            return await catalogproduct___(Parent.Uri);
        }

        public async Task RequiresPost_Fixup_catalogsku____buy()
        {
            // /catalog/sku/(*)!buy 
            await catalogsku____buy(string.Empty);
        }

        public async Task<CatalogSkuPriceEntity> RequiresPost_Fixup_catalogsku____price()
        {
            // /catalog/sku/(*)!price 
            return await catalogsku____price(string.Empty);
        }

        public async Task<CatalogSkuTypeEntity> GetCatalogSkuType(string type)
        {
            // /catalog/skutype/option/(*) 
            string requestUri = string.Format("{0}/catalog/skutype/option/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, type);

            return await RetrieveEntityAsync<CatalogSkuTypeEntity>(requestUri);
        }
    }
}
