// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.v2.Authentication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmugMug.v2.Types
{
    public partial class SmugMugEntity
    {
        protected OAuthToken _oauthToken;

        public SmugMugEntity()
        {

        }
        public SmugMugEntity(OAuthToken token)
        {
            _oauthToken = token;
        }

        protected async Task SaveAsync(string uri, List<string> patchProperties)
        {
            await PatchRequestAsync(uri, GetPropertyChangesAsJson(patchProperties));
        }

        protected async Task CreateAsync(string uri, List<string> postProperties)
        {
            await PostRequestAsync(uri, GetPropertyChangesAsJson(postProperties));
        }
    }
}
