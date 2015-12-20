// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
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


        public CatalogCategoryEntity catalogcategory___ (string param1)
        {
            // /catalog/category/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/catalog/category/{0}", param1);

            return RetrieveEntityAsync<CatalogCategoryEntity>(requestUri).Result; 
        }

        public CatalogSubCategoryEntity catalog___prints___ (string param1, string param2)
        {
            // /catalog/(*)/prints/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/catalog/{0}/prints/{1}", param1,param2);

            return RetrieveEntityAsync<CatalogSubCategoryEntity>(requestUri).Result; 
        }

        public CatalogSkuEntity[] catalogproduct____options (string param1)
        {
            // /catalog/product/(*)!options 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/catalog/product/{0}!options", param1);

            return RetrieveEntityArrayAsync<CatalogSkuEntity>(requestUri).Result; 
        }

        public CatalogVendorEntity catalogvendor___ (string param1)
        {
            // /catalog/vendor/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/catalog/vendor/{0}", param1);

            return RetrieveEntityAsync<CatalogVendorEntity>(requestUri).Result; 
        }
    }
}
