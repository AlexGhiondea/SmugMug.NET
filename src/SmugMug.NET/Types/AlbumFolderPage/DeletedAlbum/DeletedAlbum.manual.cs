// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class DeletedAlbumEntity : SmugMugEntity
    {

        public async Task<RecoverDeletedAlbumEntity> RequiresPost_Fixup_deletedalbum____recover()
        {
            // /deleted/album/(*)!recover 
            // /deleted/album/(*)!recover 
            string requestUri = string.Format("{0}/deleted/album/{1}!recover", SmugMug.v2.Constants.Addresses.SmugMugApi, string.Empty);
            return await RetrieveEntityAsync<RecoverDeletedAlbumEntity>(requestUri);
        }

        public async Task<UserEntity> GetUserAsync()
        {
            // /user/(*) 
            // /user/(*) 
            string requestUri = string.Format("{0}/user/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId);
            return await RetrieveEntityAsync<UserEntity>(requestUri);
        }
    }
}
