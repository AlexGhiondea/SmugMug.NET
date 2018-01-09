// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ContactEntity : SmugMugEntity
    {

        public async Task<ContactEmailEntity[]> GetEmailsAsync()
        {
            // /contact/(*)!emails 
            string requestUri = string.Format("{0}/{1}!emails", SmugMug.v2.Constants.Addresses.SmugMug, Uri);

            return await RetrieveEntityArrayAsync<ContactEmailEntity>(requestUri);
        }

        public async Task<GrantEntity[]> GetGrantsAsync()
        {
            // /contact/(*)!grants 
            string requestUri = string.Format("{0}/{1}!grants", SmugMug.v2.Constants.Addresses.SmugMug, Uri);

            return await RetrieveEntityArrayAsync<GrantEntity>(requestUri);
        }
    }
}
