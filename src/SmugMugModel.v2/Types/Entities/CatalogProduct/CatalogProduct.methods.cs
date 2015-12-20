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


        public async Task<CatalogCategoryEntity> catalogcategory___ (string param1)
        {
            // /catalog/category/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/catalog/category/{0}", param1);

            return await RetrieveEntityAsync<CatalogCategoryEntity>(requestUri); 
        }

        public async Task<CatalogSubCategoryEntity> catalog___prints___ (string param1, string param2)
        {
            // /catalog/(*)/prints/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/catalog/{0}/prints/{1}", param1,param2);

            return await RetrieveEntityAsync<CatalogSubCategoryEntity>(requestUri); 
        }

        public async Task<CatalogSkuEntity[]> catalogproduct____options (string param1)
        {
            // /catalog/product/(*)!options 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/catalog/product/{0}!options", param1);

            return await RetrieveEntityArrayAsync<CatalogSkuEntity>(requestUri); 
        }

        public async Task<CatalogVendorEntity> catalogvendor___ (string param1)
        {
            // /catalog/vendor/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/catalog/vendor/{0}", param1);

            return await RetrieveEntityAsync<CatalogVendorEntity>(requestUri); 
        }
    }
}
