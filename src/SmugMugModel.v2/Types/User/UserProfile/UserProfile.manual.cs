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
            // return await user___(ParentEntity.EntityId);

            // /user/(*) 
            string requestUri = string.Format("{0}/user/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId);

            return await RetrieveEntityAsync<UserEntity>(requestUri);
        }

        public async Task<ImageEntity> GetBioImageAsync()
        {
            // /user/(*)!bioimage 
            //return await user____bioimage(ParentEntity.EntityId);

            // /user/(*)!bioimage 
            string requestUri = string.Format("{0}/user/{1}!bioimage", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId);

            return await RetrieveEntityAsync<ImageEntity>(requestUri);
        }

        public async Task<ImageEntity> GetCoverImageAsync()
        {
            // /user/(*)!coverimage 
            string requestUri = string.Format("{0}/user/{1}!coverimage", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId);

            return await RetrieveEntityAsync<ImageEntity>(requestUri);
        }
    }
}
