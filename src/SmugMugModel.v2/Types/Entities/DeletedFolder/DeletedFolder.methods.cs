// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class DeletedFolderEntity : SmugMugEntity
    {
        public DeletedFolderEntity()
        {
            //Empty constructor to enable deserialization
        }

        public DeletedFolderEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public async Task<RecoverDeletedFolderEntity> deletedfolder____recover (string param1)
        {
            // /deleted/folder/(*)!recover 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/deleted/folder/{0}!recover", param1);

            return await RetrieveEntityAsync<RecoverDeletedFolderEntity>(requestUri); 
        }

        public async Task<UserEntity> user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}", param1);

            return await RetrieveEntityAsync<UserEntity>(requestUri); 
        }
    }
}
