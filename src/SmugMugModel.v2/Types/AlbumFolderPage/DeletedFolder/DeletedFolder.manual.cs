// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class DeletedFolderEntity : SmugMugEntity
    {

        public async Task<RecoverDeletedFolderEntity> RequiresPost_Fixup_deletedfolder____recover()
        {
            // /deleted/folder/(*)!recover 
            // /deleted/folder/(*)!recover 
            string requestUri = string.Format("{0}/deleted/folder/{1}!recover", SmugMug.v2.Constants.Addresses.SmugMugApi, string.Empty);
            return await RetrieveEntityAsync<RecoverDeletedFolderEntity>(requestUri);
        }

        public async Task<UserEntity> Fixup_user___()
        {
            // /user/(*) 
            // /user/(*) 
            string requestUri = string.Format("{0}/user/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId);
            return await RetrieveEntityAsync<UserEntity>(requestUri);
        }
    }
}
