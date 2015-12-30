// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogSkuPriceEntity : SmugMugEntity
    {

        public async Task<CatalogSkuEntity> Fixup_catalogsku___ ()
        {
            // /catalog/sku/(*) 
            return await catalogsku___(string.Empty); 
        }

        public async Task Fixup_catalogsku____buy ()
        {
            // /catalog/sku/(*)!buy 
            await catalogsku____buy(string.Empty); 
        }
    }
}
