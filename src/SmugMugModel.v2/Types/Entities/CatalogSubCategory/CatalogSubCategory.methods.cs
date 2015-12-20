// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogSubCategoryEntity : SmugMugEntity
    {
        public CatalogSubCategoryEntity()
        {
            //Empty constructor to enable deserialization
        }

        public CatalogSubCategoryEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public async Task<CatalogCategoryEntity> catalogcategory___ (string param1)
        {
            // /catalog/category/(*) 
            string requestUri = string.Format("{0}/catalog/category/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<CatalogCategoryEntity>(requestUri); 
        }
    }
}
