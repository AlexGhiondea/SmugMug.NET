// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class DeletedAlbumEntity : SmugMugEntity
    {
        public DeletedAlbumEntity()
        {
            //Empty constructor to enable deserialization
        }

        public DeletedAlbumEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public RecoverDeletedAlbumEntity deletedalbum____recover (string param1)
        {
            // /deleted/album/(*)!recover 
            return default(RecoverDeletedAlbumEntity); 
        }

        public UserEntity user___ (string param1)
        {
            // /user/(*) 
            return default(UserEntity); 
        }
    }
}
