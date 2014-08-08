using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmugMugModel
{
    // Indicates the program used by the camera to set exposure when the picture is taken
    public enum ExposureProgramEnum
    {
        NotDefined = 0,
        Manual = 1,
        NormalProgram = 2,
        AperturePriority = 3,
        ShutterPriority = 4,
        CreativeProgram = 5,
        ActionProgram = 6,
        PortraitMode = 7,
        LandscapeMode = 8,
    };
}
