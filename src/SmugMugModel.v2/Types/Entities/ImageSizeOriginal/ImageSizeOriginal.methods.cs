// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ImageSizeOriginalEntity : SmugMugEntity
    {
        public ImageSizeOriginalEntity()
        {
            //Empty constructor to enable deserialization
        }

        public ImageSizeOriginalEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }
    }
}
