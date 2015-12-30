// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogSubCategoryEntity : SmugMugEntity
    {

        public async Task<CatalogCategoryEntity> Fixup_catalogcategory___ ()
        {
            // /catalog/category/(*) 
            return await catalogcategory___(ParentEntity.TODOUrl); 
        }
    }
}
