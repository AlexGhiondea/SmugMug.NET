// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMugShared.Extensions
{
    public static class ConsolePrinter
    {
        public static void Write(ConsoleColor color, string message, params object[] args)
        {
            var curColor = Console.ForegroundColor;
            Console.ForegroundColor = color;

            Console.WriteLine(message, args);

            Console.ForegroundColor = curColor;
        }
    }
}
