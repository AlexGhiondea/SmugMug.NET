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
            return default(CatalogCategoryEntity); 
        }

        public CatalogSubCategoryEntity catalog___prints___ (string param1, string param2)
        {
            // /catalog/(*)/prints/(*) 
            return default(CatalogSubCategoryEntity); 
        }

        public CatalogSkuEntity[] catalogproduct____options (string param1)
        {
            // /catalog/product/(*)!options 
            return default(CatalogSkuEntity[]); 
        }

        public CatalogVendorEntity catalogvendor___ (string param1)
        {
            // /catalog/vendor/(*) 
            return default(CatalogVendorEntity); 
        }
    }
}
