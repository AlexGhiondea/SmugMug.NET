// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserTopKeywordsEntity : SmugMugEntity
    {
        public UserTopKeywordsEntity()
        {
            //Empty constructor to enable deserialization
        }

        public UserTopKeywordsEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }
    }
}
