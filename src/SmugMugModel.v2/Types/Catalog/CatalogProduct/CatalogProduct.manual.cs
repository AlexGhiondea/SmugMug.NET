// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogProductEntity : SmugMugEntity
    {

        public async Task<CatalogCategoryEntity> GetPrintsCategoryAsync()
        {
            // /catalog/category/prints
            string requestUri = string.Format("{0}/catalog/category/prints", SmugMug.v2.Constants.Addresses.SmugMugApi);

            return await RetrieveEntityAsync<CatalogCategoryEntity>(requestUri);
        }

        public async Task<CatalogSubCategoryEntity> GetOtherPrintsCategoryAsync()
        {
            // /catalog/category/prints/other 
            string requestUri = string.Format("{0}/catalog/category/prints/other", SmugMug.v2.Constants.Addresses.SmugMugApi);

            return await RetrieveEntityAsync<CatalogSubCategoryEntity>(requestUri);
        }

        public async Task<CatalogSkuEntity[]> GetCatalogOptionsAsync()
        {
            // /catalog/product/(*)!options 
            string requestUri = string.Format("{0}{1}!options", SmugMug.v2.Constants.Addresses.SmugMug, Uri);

            return await RetrieveEntityArrayAsync<CatalogSkuEntity>(requestUri);
        }

        public async Task<CatalogVendorEntity> Fixup_catalogvendor___()
        {
            // /catalog/vendor/(*) 
            string requestUri = string.Format("{0}{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.Uri);

            return await RetrieveEntityAsync<CatalogVendorEntity>(requestUri);
        }
    }
}
