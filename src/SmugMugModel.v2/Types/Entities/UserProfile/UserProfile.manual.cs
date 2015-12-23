// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserProfileEntity : SmugMugEntity
    {

        public async Task<UserEntity> Fixup_user___ ()
        {
            // /user/(*) 
            return await user___(string.Empty); 
        }

        public async Task<BioImageEntity> Fixup_user____bioimage ()
        {
            // /user/(*)!bioimage 
            return await user____bioimage(string.Empty); 
        }

        public async Task<CoverImageEntity> Fixup_user____coverimage ()
        {
            // /user/(*)!coverimage 
            return await user____coverimage(string.Empty); 
        }
    }
}
