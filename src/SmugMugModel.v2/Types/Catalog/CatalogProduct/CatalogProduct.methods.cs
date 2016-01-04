// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogProductEntity : SmugMugEntity
    {
        public CatalogProductEntity()
        {
            //Empty constructor to enable deserialization
        }

        public CatalogProductEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        private async Task<CatalogCategoryEntity> catalogcategory___ (string param1)
        {
            // /catalog/category/(*) 
            string requestUri = string.Format("{0}/catalog/category/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<CatalogCategoryEntity>(requestUri); 
        }

        private async Task<CatalogSubCategoryEntity> catalog___prints___ (string param1, string param2)
        {
            // /catalog/(*)/prints/(*) 
            string requestUri = string.Format("{0}/catalog/{1}/prints/{2}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<CatalogSubCategoryEntity>(requestUri); 
        }

        private async Task<CatalogSkuEntity[]> catalogproduct____options (string param1)
        {
            // /catalog/product/(*)!options 
            string requestUri = string.Format("{0}/catalog/product/{1}!options", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<CatalogSkuEntity>(requestUri); 
        }

        private async Task<CatalogVendorEntity> catalogvendor___ (string param1)
        {
            // /catalog/vendor/(*) 
            string requestUri = string.Format("{0}/catalog/vendor/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<CatalogVendorEntity>(requestUri); 
        }
    }
}
