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
                    NotifyPropertyValueChanged(""{1}"", oldValue:{2}, newValue: value);
                    {2} = value;     
                }}
            }}
        }}
";

        public const string MethodDefinition = @"
        public async Task<{0}> {1} ({2})
        {{
            // {3} 
            {4} 
        }}";

        public const string VoidMethodDefinition = @"
        public async Task {1} ({2})
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

using System;{3}
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

        public const string ParameterNameBase = "param";
        public const string VoidMethodReturnType = "Task";

        public const string MethodReturnsParameters = @"
        private static readonly List<string> {0}Parameters = new List<string>(){{ {1} }};
";
    }
}
