using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmugMugModel
{
    // Indicates the direction of saturation processing applied by the camera when the image was shot
    public enum SaturationEnum
    {
        Normal = 0,
        Low = 1,
        HighSaturation = 2,
    };
}
