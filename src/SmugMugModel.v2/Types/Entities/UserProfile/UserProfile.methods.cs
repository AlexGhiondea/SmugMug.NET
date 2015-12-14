// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class UserProfileEntity : SmugMugEntity
    {

        public BioImageEntity user____bioimage (string param1)
        {
            // /user/(*)!bioimage 
            return default(BioImageEntity); 
        }

        public CoverImageEntity user____coverimage (string param1)
        {
            // /user/(*)!coverimage 
            return default(CoverImageEntity); 
        }

        public UserEntity user___ (string param1)
        {
            // /user/(*) 
            return default(UserEntity); 
        }

    }
}
