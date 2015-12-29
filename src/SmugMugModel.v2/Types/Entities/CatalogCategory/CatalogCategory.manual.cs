// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogCategoryEntity : SmugMugEntity
    {

        public async Task<CatalogSubCategoryEntity[]> GetSubcategoriesAsync ()
        {
            // /catalog/category/(*)!subcategories 
            string requestUri = string.Format("{0}{1}!subcategories", SmugMug.v2.Constants.Addresses.SmugMug,Uri);

            return await RetrieveEntityArrayAsync<CatalogSubCategoryEntity>(requestUri); 
        }
    }
}
