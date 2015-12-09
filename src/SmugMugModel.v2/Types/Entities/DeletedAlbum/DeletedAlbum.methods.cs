// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class DeletedAlbumEntity : SmugMugEntity
    {

        public UserEntity user___ ()
        {
            // /user/(*) 
            return default(UserEntity); 
        }

        public RecoverDeletedAlbumEntity deletedalbum____recover ()
        {
            // /deleted/album/(*)!recover 
            return default(RecoverDeletedAlbumEntity); 
        }

    }
}
