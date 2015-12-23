// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogProductEntity : SmugMugEntity
    {

        public async Task<CatalogCategoryEntity> Fixup_catalogcategory___ ()
        {
            // /catalog/category/(*) 
            return await catalogcategory___(string.Empty); 
        }

        public async Task<CatalogSubCategoryEntity> Fixup_catalog___prints___ ()
        {
            // /catalog/(*)/prints/(*) 
            return await catalog___prints___(string.Empty, string.Empty); 
        }

        public async Task<CatalogSkuEntity[]> Fixup_catalogproduct____options ()
        {
            // /catalog/product/(*)!options 
            return await catalogproduct____options(string.Empty); 
        }

        public async Task<CatalogVendorEntity> Fixup_catalogvendor___ ()
        {
            // /catalog/vendor/(*) 
            return await catalogvendor___(string.Empty); 
        }
    }
}
