// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Text;

namespace SmugMugCodeGen
{
    public static class Helpers
    {
        public static string NormalizeString(string input)
        {
            StringBuilder sb = new StringBuilder();

            if (char.IsDigit(input[0]))
                sb.Append('_');

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsWhiteSpace(input[i]))
                    continue;

                if (input[i] == '\\' || input[i] == '/' || input[i] == ',')
                    continue;

                sb.Append(input[i]);
            }
            return sb.ToString();
        }
    }
}
