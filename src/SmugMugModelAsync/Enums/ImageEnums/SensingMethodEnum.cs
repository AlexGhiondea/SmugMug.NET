using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmugMugModel
{
    // Indicates the image sensor type on the camera or input device
    public enum SensingMethodEnum
    {
        NotDefined = 1,
        OneChipColorAreaSensor = 2,
        TwoChipColorAreaSensor = 3,
        ThreeChipColorAreaSensor = 4,
        ColorSequentialAreaSensor = 5,
        TrilinearSensor = 7,
        ColorSequentialLinearSensor = 8,
    }
}
