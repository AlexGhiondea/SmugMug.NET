// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
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


        public UserEntity user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}", param1);

            return RetrieveEntityAsync<UserEntity>(requestUri).Result; 
        }

        public BioImageEntity user____bioimage (string param1)
        {
            // /user/(*)!bioimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!bioimage{1}", param1);

            return RetrieveEntityAsync<BioImageEntity>(requestUri).Result; 
        }

        public CoverImageEntity user____coverimage (string param1)
        {
            // /user/(*)!coverimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!coverimage{1}", param1);

            return RetrieveEntityAsync<CoverImageEntity>(requestUri).Result; 
        }
    }
}
