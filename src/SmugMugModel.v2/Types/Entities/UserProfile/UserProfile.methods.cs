// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class UserProfileEntity : SmugMugEntity
    {

        public BioImageEntity user____bioimage ()
        {
            // /user/(*)!bioimage 
            return default(BioImageEntity); 
        }

        public CoverImageEntity user____coverimage ()
        {
            // /user/(*)!coverimage 
            return default(CoverImageEntity); 
        }

        public UserEntity user___ ()
        {
            // /user/(*) 
            return default(UserEntity); 
        }

    }
}
