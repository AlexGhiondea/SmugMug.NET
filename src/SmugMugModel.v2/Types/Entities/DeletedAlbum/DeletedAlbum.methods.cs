// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
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


        public async Task<RecoverDeletedAlbumEntity> deletedalbum____recover (string param1)
        {
            // /deleted/album/(*)!recover 
            string requestUri = string.Format("{0}/deleted/album/{1}!recover", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<RecoverDeletedAlbumEntity>(requestUri); 
        }

        public async Task<UserEntity> user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("{0}/user/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<UserEntity>(requestUri); 
        }
    }
}
