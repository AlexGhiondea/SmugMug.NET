// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class DeletedAlbumEntity : SmugMugEntity
    {

        public async Task<RecoverDeletedAlbumEntity> Fixup_deletedalbum____recover ()
        {
            // /deleted/album/(*)!recover 
            return await deletedalbum____recover(string.Empty); 
        }

        public async Task<UserEntity> Fixup_user___ ()
        {
            // /user/(*) 
            return await user___(string.Empty); 
        }
    }
}
