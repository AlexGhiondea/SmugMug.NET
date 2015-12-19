// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SmugMugCodeGen
{
    public static class Constants
    {
        public const string PropertyFieldDefinition = @"        private {0} {1};";

        public const string PropertyDefinition = @"
        public {0} {1} {{
            get {{
                return {2};
            }}
            set {{
                if ({2} != value)
                {{
                    {2} = value;
                    NotifyPropertyValueChanged(""{1}"", {2});
                }}
            }}
        }}
";

        public const string MethodDefinition = @"
        public {0} {1} ({2})
        {{
            // {3} 
            {4} 
        }}";

        public const string EnumDefinition = @"// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
{0}

namespace SmugMug.v2.Types
{{
    public enum {1} 
    {{
{2}
    }}
}}
";

        public const string ClassDefinition = @"// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{{{2}
    public partial class {0}Entity : SmugMugEntity
    {{
{1}
    }}
}}
";

        public const string ConstructorDefinition = @"        public {0}Entity()
        {{
            //Empty constructor to enable deserialization
        }}

        public {0}Entity(OAuthToken oauthToken)
            : base(oauthToken)
        {{
            _oauthToken = oauthToken;
        }}
";
    }
}
