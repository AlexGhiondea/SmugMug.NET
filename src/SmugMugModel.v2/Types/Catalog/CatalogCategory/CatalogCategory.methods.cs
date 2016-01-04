// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogCategoryEntity : SmugMugEntity
    {
        public CatalogCategoryEntity()
        {
            //Empty constructor to enable deserialization
        }

        public CatalogCategoryEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        private async Task<CatalogSubCategoryEntity[]> catalogcategory____subcategories (string param1)
        {
            // /catalog/category/(*)!subcategories 
            string requestUri = string.Format("{0}/catalog/category/{1}!subcategories", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<CatalogSubCategoryEntity>(requestUri); 
        }
    }
}
