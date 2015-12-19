// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
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


        public CatalogSkuEntity catalogsku___ (string param1)
        {
            // /catalog/sku/(*) 
            return default(CatalogSkuEntity); 
        }

        public void catalogsku____buy (string param1)
        {
            // /catalog/sku/(*)!buy 
             
        }
    }
}
