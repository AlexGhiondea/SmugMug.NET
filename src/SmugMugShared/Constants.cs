// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SmugMugShared
{
    public static class Constants
    {
        public const string RequestModifiers = @"?_pretty&_verbosity=3";
        public static class Addresses
        {
            public const string SmugMug = @"https://api.smugmug.com";

            public const string SmugMugApi = SmugMug + "/api/v2";
        }
    }
}
