// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ContactEntity : SmugMugEntity
    {
        public ContactEntity()
        {
            //Empty constructor to enable deserialization
        }

        public ContactEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public ContactEmailEntity[] contact____emails (string param1)
        {
            // /contact/(*)!emails 
            return default(ContactEmailEntity[]); 
        }

        public GrantEntity[] contact____grants (string param1)
        {
            // /contact/(*)!grants 
            return default(GrantEntity[]); 
        }
    }
}
