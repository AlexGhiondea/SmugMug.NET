// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserProfileEntity : SmugMugEntity
    {

        public async Task<UserEntity> Fixup_user___()
        {
            // /user/(*) 
            return await user___(ParentEntity.EntityId);
        }

        public async Task<ImageEntity> GetBioImageAsync()
        {
            // /user/(*)!bioimage 
            return await user____bioimage(ParentEntity.EntityId);
        }

        public async Task<ImageEntity> GetCoverImageAsync()
        {
            // /user/(*)!coverimage 
            return await user____coverimage(ParentEntity.EntityId);
        }
    }
}
