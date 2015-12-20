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
            string requestUri = string.Format("https://api.smugmug.com/api/v2/deleted/album/{0}!recover", param1);

            return RetrieveEntityAsync<RecoverDeletedAlbumEntity>(requestUri).Result; 
        }

        public UserEntity user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}", param1);

            return RetrieveEntityAsync<UserEntity>(requestUri).Result; 
        }
    }
}
