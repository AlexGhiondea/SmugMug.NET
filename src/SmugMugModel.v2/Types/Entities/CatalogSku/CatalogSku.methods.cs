// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
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


        public CatalogProductEntity catalogproduct___ (string param1)
        {
            // /catalog/product/(*) 
            return default(CatalogProductEntity); 
        }

        public void catalogsku____buy (string param1)
        {
            // /catalog/sku/(*)!buy 
             
        }

        public CatalogSkuPriceEntity catalogsku____price (string param1)
        {
            // /catalog/sku/(*)!price 
            return default(CatalogSkuPriceEntity); 
        }

        public CatalogSkuTypeEntity catalog___option___ (string param1, string param2)
        {
            // /catalog/(*)/option/(*) 
            return default(CatalogSkuTypeEntity); 
        }
    }
}
