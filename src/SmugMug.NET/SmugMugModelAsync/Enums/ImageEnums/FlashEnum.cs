using System;
using System.Collections.Generic;
using System.Text;

namespace SmugMugModel
{
    // Indicates the status of flash when the image was shot
    public enum FlashEnum
    {
        FlashDidNotFire = 0,
        FlashFired = 1,
        StrobeReturnLightNotDetected = 5,
        StrobeReturnLightDetected = 7,
        FlashFiredCompulsoryFlashMode = 9,
        FlashFiredCompulsoryFlashModeReturnLightNotDetected = 13,
        FlashFiredCompulsoryFlashModeReturnLightDetected = 15,
        FlashDidNotFireCompulsoryFlashMode = 16,
        FlashDidNotFireAutoMode = 24,
        FlashFiredAutoMode = 25,
        FlashFiredAutoModeReturnLightNotDetected = 29,
        FlashFiredAutoModeReturnLightDetected = 31,
        NoFlashFunction = 32,
        FlashFiredRedEyeReductionMode = 65,
        FlashFiredRedEyeReductionModeReturnLightNotDetected = 69,
        FlashFiredRedEyeReductionModeReturnLightDetected = 71,
        FlashFiredCompulsoryFlashModeRedEyeReductionMode = 73,
        FlashFiredCompulsoryFlashModeRedEyeReductionModeReturnLightNotDetected = 77,
        FlashFiredCompulsoryFlashModeRedEyeReductionModeReturnLightDetected = 79,
        FlashFiredAutoModeRedEyeReductionMode = 89,
        FlashFiredAutoModeReturnLightNotDetectedRedEyeReductionMode = 93,
        FlashFiredAutoModeReturnLightDetectedRedEyeReductionMode = 95,
    };
}
