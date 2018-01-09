// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
namespace SmugMug.Shared.Descriptors
{
    public class Limits
    {
        // INFINITY, NEGATIVE_INFINITY, POSITIVE_INFINITY, and numbers

        private double maxVal, minVal;

        public Limits(string min, string max)
        {
            minVal = Parse(min);
            maxVal = Parse(max);
        }

        private double Parse(string value)
        {
            if (string.IsNullOrEmpty(value))
                return 0;

            if (StringComparer.OrdinalIgnoreCase.Equals("infinity", value) ||
                StringComparer.OrdinalIgnoreCase.Equals("positive_infinity", value))
                return double.PositiveInfinity;

            if (StringComparer.OrdinalIgnoreCase.Equals("-infinity", value) ||
                StringComparer.OrdinalIgnoreCase.Equals("negative_infinity", value))
                return double.NegativeInfinity;

            if (StringComparer.OrdinalIgnoreCase.Equals("all", value))
                return double.PositiveInfinity;

            return double.Parse(value);
        }
        public double Min { get { return minVal; } }
        public double Max { get { return maxVal; } }
    }
}
