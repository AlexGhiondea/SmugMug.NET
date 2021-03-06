﻿// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SmugMugCodeGen
{
    public static class Helpers
    {
        public static string NormalizeString(string input)
        {
            return NormalizeString(input, new char[0]);
        }

        public static string NormalizeString(string input, params char[] additionalCharsToEscape)
        {
            HashSet<char> additionalCharactersToSkip = new HashSet<char>(additionalCharsToEscape);
            StringBuilder sb = new StringBuilder();

            if (char.IsDigit(input[0]))
                sb.Append('_');

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsWhiteSpace(input[i]))
                    continue;

                if (input[i] == '\\' || input[i] == '/' || input[i] == ',' || input[i] == '-')
                    continue;

                if (additionalCharactersToSkip.Count > 0 && additionalCharactersToSkip.Contains(input[i]))
                {
                    sb.Append('_');
                    continue;
                }

                sb.Append(input[i]);
            }
            return sb.ToString();
        }

        public static bool TryCreateDirectory(string directoryName)
        {
            try
            {
                Directory.CreateDirectory(directoryName);
            }
            catch (Exception e)
            {
                SmugMugShared.Extensions.ConsolePrinter.Write(ConsoleColor.Red, "Could not create output directory {0}: {1}", directoryName, e.Message);
                return false;
            }

            return true;
        }
    }
}
