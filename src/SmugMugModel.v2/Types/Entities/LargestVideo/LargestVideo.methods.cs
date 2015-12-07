// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class LargestVideoEntity : SmugMugEntity
    {

        public VideoSize1920Entity video____size1920 ()
        {
            // /video/(*)!size1920 
            return default(VideoSize1920Entity); 
        }

        public ImageSizeCustomEntity image____sizecustom ()
        {
            // /image/(*)!sizecustom 
            return default(ImageSizeCustomEntity); 
        }

    }
}
