// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.v2.Authentication;
using System.Threading.Tasks;

namespace SmugMug.v2.Types
{
    public class SiteEntity : SmugMugEntity
    {
        public SiteEntity(OAuthToken token)
        {
            _oauthToken = token;
        }

        public async Task<UserEntity> GetAuthenticatedUserAsync()
        {
            // /album/(*)!applyalbumtemplate 
            string requestUri = string.Format("{0}!authuser", SmugMug.v2.Constants.Addresses.SmugMugApi);

            return await RetrieveEntityAsync<UserEntity>(requestUri);
        }
    }
}
