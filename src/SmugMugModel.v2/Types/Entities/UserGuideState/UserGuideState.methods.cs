// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserGuideStateEntity : SmugMugEntity
    {
        public UserGuideStateEntity()
        {
            //Empty constructor to enable deserialization
        }

        public UserGuideStateEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public GuideEntity guide___ (string param1)
        {
            // /guide/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/guide/{0}", param1);

            return RetrieveEntityAsync<GuideEntity>(requestUri).Result; 
        }
    }
}
