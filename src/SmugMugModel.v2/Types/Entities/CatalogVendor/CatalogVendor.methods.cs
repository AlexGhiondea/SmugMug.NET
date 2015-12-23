// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogVendorEntity : SmugMugEntity
    {
        public CatalogVendorEntity()
        {
            //Empty constructor to enable deserialization
        }

        public CatalogVendorEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public async Task<CatalogProductEntity[]> catalogvendor____products (string param1)
        {
            // /catalog/vendor/(*)!products 
            string requestUri = string.Format("{0}/catalog/vendor/{1}!products", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<CatalogProductEntity>(requestUri); 
        }
    }
}
