// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class RecoverDeletedPageEntity : SmugMugEntity
    {
        public RecoverDeletedPageEntity()
        {
            //Empty constructor to enable deserialization
        }

        public RecoverDeletedPageEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }
    }
}