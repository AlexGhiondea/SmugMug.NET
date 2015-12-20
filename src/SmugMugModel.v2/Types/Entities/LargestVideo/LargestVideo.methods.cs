// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class LargestVideoEntity : SmugMugEntity
    {
        public LargestVideoEntity()
        {
            //Empty constructor to enable deserialization
        }

        public LargestVideoEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public ImageSizeCustomEntity image____sizecustom (string param1)
        {
            // /image/(*)!sizecustom 
            return default(ImageSizeCustomEntity); 
        }

        public VideoSize1920Entity video____size1920 (string param1)
        {
            // /video/(*)!size1920 
            return default(VideoSize1920Entity); 
        }
    }
}
