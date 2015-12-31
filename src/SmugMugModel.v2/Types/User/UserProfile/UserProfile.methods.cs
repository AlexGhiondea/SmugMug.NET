// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserProfileEntity : SmugMugEntity
    {
        public UserProfileEntity()
        {
            //Empty constructor to enable deserialization
        }

        public UserProfileEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }

        protected override IEnumerable<string> GetPatchPropertiesName()
        {
            return PatchParameters;
        }

        private static readonly List<string> PatchParameters = new List<string>(){ "BioText","BioImageUri","CoverImageUri","FirstName","LastName","DisplayName","Facebook","Twitter","Instagram","Blogger","Flickr","GooglePlus","LinkedIn","Pinterest","Tumblr","Vimeo","Wordpress","YouTube","Custom" };


        public async Task<UserEntity> user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("{0}/user/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<UserEntity>(requestUri); 
        }

        public async Task<ImageEntity> user____bioimage (string param1)
        {
            // /user/(*)!bioimage 
            string requestUri = string.Format("{0}/user/{1}!bioimage", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        public async Task<ImageEntity> user____coverimage (string param1)
        {
            // /user/(*)!coverimage 
            string requestUri = string.Format("{0}/user/{1}!coverimage", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }
    }
}
