// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class DeletedPageEntity : SmugMugEntity
    {
        public DeletedPageEntity()
        {
            //Empty constructor to enable deserialization
        }

        public DeletedPageEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public async Task<RecoverDeletedPageEntity> deletedpage____recover (string param1)
        {
            // /deleted/page/(*)!recover 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/deleted/page/{0}!recover", param1);

            return await RetrieveEntityAsync<RecoverDeletedPageEntity>(requestUri); 
        }

        public async Task<UserEntity> user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}", param1);

            return await RetrieveEntityAsync<UserEntity>(requestUri); 
        }
    }
}
