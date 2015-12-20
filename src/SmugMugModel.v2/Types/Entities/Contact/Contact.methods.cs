// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ContactEntity : SmugMugEntity
    {
        public ContactEntity()
        {
            //Empty constructor to enable deserialization
        }

        public ContactEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public async Task<ContactEmailEntity[]> contact____emails (string param1)
        {
            // /contact/(*)!emails 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/contact/{0}!emails", param1);

            return await RetrieveEntityArrayAsync<ContactEmailEntity>(requestUri); 
        }

        public async Task<GrantEntity[]> contact____grants (string param1)
        {
            // /contact/(*)!grants 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/contact/{0}!grants", param1);

            return await RetrieveEntityArrayAsync<GrantEntity>(requestUri); 
        }
    }
}
