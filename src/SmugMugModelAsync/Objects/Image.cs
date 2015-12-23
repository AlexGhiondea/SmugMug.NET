using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmugMugModel
{
    public class Image : SmugMugObject
    {
        #region Properties
        /// <summary>
        /// The id for the image
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// The key of the image
        /// </summary>
        public string Key { get; set; }

        public Album Album { get; set; }
        /// <summary>
        /// The altitude at which this image (or video) was taken
        /// </summary>
        public long Altitude { get; set; }
        /// <summary>
        /// Indicates the lens aperture set when the image was shot
        /// </summary>
        public string Aperture { get; set; }
        /// <summary>
        /// The bytes transferred for this image (or video) for a given month.
        /// </summary>
        public long Bytes { get; set; }
        /// <summary>
        /// The size of the image (or video) in bytes
        /// </summary>
        public long ByteCount { get; set; }
        /// <summary>
        /// Indicates the value of brightness applied by the camera when the image was shot
        /// </summary>
        public string Brightness { get; set; }
        /// <summary>
        /// The caption for this image (or video)
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// Indicates the width of the CCD sensor, given in millimeters (mm)
        /// </summary>
        public string CCDWidth { get; set; }
        /// <summary>
        /// Indicates the colorspace used by the image (Values: 1 - sRGB, 39321 - Uncalibrated)
        /// </summary>
        public ColorSpaceEnum ColorSpace { get; set; }
        public List<Comment> Comments { get; set; }
        /// <summary>
        /// The compression mode used for a compressed image is indicated in unit bits per pixel
        /// </summary>
        public string CompressedBitsPerPixel { get; set; }
        /// <summary>
        /// Indicates the direction of contrast processing applied by the camera when the image was shot. Values: 0 - Normal, 1 - Soft, 2 - Hard)
        /// </summary>
        public ContrastEnum Contrast { get; set; }
        /// <summary>
        /// The date that this image (or video) was uploaded (owner)
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// The date and time of image creation/modification
        /// </summary>
        public string DateTime { get; set; }
        /// <summary>
        /// The date and time when the image was stored as digital data
        /// </summary>
        public string DateTimeDigitized { get; set; }
        /// <summary>
        /// The date and time when the original image data was generated
        /// </summary>
        public string DateTimeOriginal { get; set; }
        /// <summary>
        /// Indicates the digital zoom ratio when the image was shot
        /// </summary>
        public string DigitalZoomRatio { get; set; }
        /// <summary>
        /// The duration of the video in sec (video, power and pro)
        /// </summary>
        public long Duration { get; set; }
        /// <summary>
        /// Indicates the exposure bias set when the image was shot
        /// </summary>
        public string ExposureBiasValue { get; set; }
        /// <summary>
        /// Indicates the exposure mode set when the image was shot. Values: 0 - Auto exposure, 1 - Manual exposure, 2 - Auto bracket)
        /// </summary>
        public ExposureModeEnum ExposureMode { get; set; }
        /// <summary>
        /// Indicates the program used by the camera to set exposure when the picture is taken (NotDefined = 0, Manual = 1, NormalProgram = 2, AperturePriority = 3, ShutterPriority = 4, CreativeProgram = 5, ActionProgram = 6, PortraitMode = 7, LandscapeMode = 8)
        /// </summary>
        public ExposureProgramEnum ExposureProgram { get; set; }
        /// <summary>
        /// Indicates the exposure time, given in seconds (sec)
        /// </summary>
        public string ExposureTime { get; set; }
        public string Extras { get; set; }
        /// <summary>
        /// The filename of the image (or video). Only by Owner
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Indicates the status of flash when the image was shot (FlashDidNotFire = 0, FlashFired = 1, StrobeReturnLightNotDetected = 5, StrobeReturnLightDetected = 7, FlashFiredCompulsoryFlashMode = 9, FlashFiredCompulsoryFlashModeReturnLightNotDetected = 13, FlashFiredCompulsoryFlashModeReturnLightDetected = 15, FlashDidNotFireCompulsoryFlashMode = 16, FlashDidNotFireAutoMode = 24, FlashFiredAutoMode = 25, FlashFiredAutoModeReturnLightNotDetected = 29, FlashFiredAutoModeReturnLightDetected = 31, NoFlashFunction = 32, FlashFiredRedEyeReductionMode = 65, FlashFiredRedEyeReductionModeReturnLightNotDetected = 69, FlashFiredRedEyeReductionModeReturnLightDetected = 71, FlashFiredCompulsoryFlashModeRedEyeReductionMode = 73, FlashFiredCompulsoryFlashModeRedEyeReductionModeReturnLightNotDetected = 77, FlashFiredCompulsoryFlashModeRedEyeReductionModeReturnLightDetected = 79, FlashFiredAutoModeRedEyeReductionMode = 89, FlashFiredAutoModeReturnLightNotDetectedRedEyeReductionMode = 93, FlashFiredAutoModeReturnLightDetectedRedEyeReductionMode = 95,)
        /// </summary>
        public FlashEnum Flash { get; set; }
        /// <summary>
        /// Indicates the actual focal length of the lens, in mm
        /// </summary>
        public string FocalLength { get; set; }
        /// <summary>
        /// Indicates the equivalent focal length assuming a 35mm film camera, in mm
        /// </summary>
        public string FocalLengthIn35mmFilm { get; set; }
        /// <summary>
        /// The original format of this image (or video) (owner)
        /// </summary>
        public string Format { get; set;         }
        /// <summary>
        /// The total hits for this image (or video) for a given month.
        /// </summary>
        public long Hits { get; set; }
        /// <summary>
        /// The height of the crop
        /// </summary>
        public long Height { get; set; }
        /// <summary>
        /// Hide the image (or video). Only by Owner
        /// </summary>
        public bool Hidden { get; set; }
        /// <summary>
        /// Indicates the ISO Speed and ISO Latitude of the camera or input device ( the sensitivity of film )
        /// </summary>
        public long ISO { get; set; }
        /// <summary>
        /// The keyword string for the image (or video). Only by Owner
        /// </summary>
        public string Keywords { get; set; }
        /// <summary>
        /// The number of Large hits for this image (or video) for a given month.
        /// </summary>
        public long Large { get; set; }
        /// <summary>
        /// The date that this image (or video) was last updated
        /// </summary>
        public string LastUpdated { get; set; }
        /// <summary>
        /// The latitude at which this image (or video) was taken
        /// </summary>
        public double Latitude { get; set; }
        /// <summary>
        /// Indicates the kind of light source (Unknown = 0, Daylight = 1, Fluorescent = 2, Tungsten = 3, Flash = 4, FineWeather = 9, CloudyWeather = 10, Shade = 11, DaylightFluorescent = 12, DayWhiteFluorescent = 13, CoolWhiteFluorescent = 14, WhiteFluorescent = 15, StandardLightA = 17, StandardLightB = 18, StandardLightC = 19, D55 = 20, D65 = 21, D75 = 22, D50 = 23, ISOStudioTungsten = 24, OtherLightSource = 255,)
        /// </summary>
        public LightSourceEnum LightSource { get; set; }
        /// <summary>
        /// The url for the Large version of this image
        /// </summary>
        public string LargeURL { get; set; }
        /// <summary>
        /// The Lightbox URL for this image.
        /// </summary>
        public string LightboxURL { get; set; }
        /// <summary>
        /// The longitude at which this image (or video) was taken
        /// </summary>
        public double Longitude { get; set; }
        /// <summary>
        /// Indicates the manufacturer of the camera or input device
        /// </summary>
        public string Make { get; set; }
        /// <summary>
        /// Only by Owner
        /// </summary>
        public string MD5Sum { get; set; }
        /// <summary>
        /// Indicates the metering mode set when the image was shot ( Unknown = 0, Average = 1, CenterWeightedAverage = 2, Spot = 3, MultiSpot = 4, Pattern = 5, Partial = 6,)
        /// </summary>
        public MeteringEnum Metering { get; set; }
        /// <summary>
        /// The number of Medium hits for this image (or video) for a given month.
        /// </summary>
        public long Medium { get; set; }
        /// <summary>
        /// The url for the Medium version of this image.
        /// </summary>
        public string MediumURL { get; set; }
        /// <summary>
        /// Indicates the model name or model number of the camera or input device
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// The number of Original hits for this image (or video) for a given month.
        /// </summary>
        public long Original { get; set; }
        /// <summary>
        /// The url for the Original version of this image.
        /// </summary>
        public string OriginalURL { get; set; }
        /// <summary>
        /// The position of this image (or video) within the album
        /// </summary>
        public float Position { get; set; }
        /// <summary>
        /// Indicates the direction of saturation processing applied by the camera when the image was shot (Normal = 0, Low = 1, HighSaturation = 2,)
        /// </summary>
        public SaturationEnum Saturation { get; set; }
        /// <summary>
        /// Indicates the image sensor type on the camera or input device (NotDefined = 1, OneChipColorAreaSensor = 2, TwoChipColorAreaSensor = 3, ThreeChipColorAreaSensor = 4, ColorSequentialAreaSensor = 5, TrilinearSensor = 7, ColorSequentialLinearSensor = 8,)
        /// </summary>
        public SensingMethodEnum SensingMethod { get; set; }
        /// <summary>
        /// /The current revision of this image (or video)
        /// </summary>
        public long Serial { get; set; }
        /// <summary>
        /// Indicates the direction of sharpness processing applied by the camera when the image was shot (Normal = 0, Soft = 1, Hard = 2,)
        /// </summary>
        public SharpnessEnum Sharpness { get; set; }
        /// <summary>
        /// The size of this image (or video) in bytes
        /// </summary>
        public long Size { get; set; }
        /// <summary>
        /// The number of Small hits for this image (or video) for a given month
        /// </summary>
        public long Small { get; set; }
        /// <summary>
        /// The URL for the Small version of this image.
        /// </summary>
        public string SmallURL { get; set; }

        public string smugXMLName { get; set; }
        /// <summary>
        /// The status for this image.
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Indicates the distance to the subject, given in meters
        /// </summary>
        public string SubjectDistance { get; set; }
        /// <summary>
        /// Indicates the distance to the subject (Unknown = 0, Macro = 1, CloseView = 2, DistantView = 3,)
        /// </summary>
        public SubjectDistanceRangeEnum SubjectDistanceRange { get; set; }

        public long Tiny { get; set; }
        /// <summary>
        /// The URL for the Tiny version of this image.
        /// </summary>
        public string TinyURL { get; set; }

        public long Thumb { get; set; }
        /// <summary>
        /// The URL for the Thumb version of this image.
        /// </summary>
        public string ThumbURL { get; set; }
        /// <summary>
        /// The type for this image. Values: Collected, Smart
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// The URL for this image
        /// </summary>
        public string URL { get; set; }
        /// <summary>
        /// User - DisplayName, NickName, URL
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// The url for the 320 version of this video.
        /// </summary>
        public string Video320URL { get; set; }
        /// <summary>
        /// The url for the 640 version of this video.
        /// </summary>
        public string Video640URL { get; set; }
        /// <summary>
        /// The url for the 960 version of this video.
        /// </summary>
        public string Video960URL { get; set; }
        /// <summary>
        /// The url for the 1280 version of this video.
        /// </summary>
        public string Video1280URL { get; set; }
        /// <summary>
        /// The url for the 1920 version of this video.
        /// </summary>
        public string Video1920URL { get; set; }
        /// <summary>
        /// The url for the SMIL version of this video.
        /// </summary>
        public string VideoSMILURL { get; set; }
        /// <summary>
        /// The url for the Streaming version of this video.
        /// </summary>
        public string VideoStreamingURL { get; set; }
        /// <summary>
        /// If the image is watermarked
        /// </summary>
        public bool Watermark { get; set; }
        /// <summary>
        /// Indicates the white balance mode set when the image was shot (AutoWhiteBalance = 0, ManualWhiteBalance = 1,)
        /// </summary>
        public WhiteBalanceEnum WhiteBalance { get; set; }
        /// <summary>
        /// The width of the crop
        /// </summary>
        public long Width { get; set; }
        /// <summary>
        /// The number of XLarge hits for this image (or video) for a given month
        /// </summary>
        public long XLarge { get; set; }
        /// <summary>
        /// The url for the XLarge version of this image
        /// </summary>
        public string XLargeURL { get; set; }
        /// <summary>
        /// The number of X2Large hits for this image (or video) for a given month
        /// </summary>
        public long X2Large { get; set; }
        /// <summary>
        /// The url for the X2Large version of this image
        /// </summary>
        public string X2LargeURL { get; set; }
        /// <summary>
        /// The number of X3Large hits for this image (or video) for a given month
        /// </summary>
        public long X3Large { get; set; }
        /// <summary>
        /// The url for the X3Large version of this image
        /// </summary>
        public string X3LargeURL { get; set; }
        #endregion

        #region Sync
        /// <summary>
        /// Changes the position of an image in an album
        /// </summary>
        /// <param name="Position">The new position within the album</param>
        /// <returns></returns>
        public bool ChangePosition(int Position)
        {
            return ChangePositionAsync(Position).Result;
        }

        /// <summary>
        /// Updates specific settings (AlbumID - move, Altitude, Caption, FileName, Hidden, Keywords, Latitude, Longitude) for a given image specified by ImageID. If any of the parameters are missing or are empty strings "", they're ignored and the current settings are preserved. Otherwise, they're updated with the new settings. 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool ChangeSettings()
        {
            return ChangeSettings("");
        }

        /// <summary>
        /// Updates specific settings (AlbumID - move, Altitude, Caption, FileName, Hidden, Keywords, Latitude, Longitude) for a given image specified by ImageID. If any of the parameters are missing or are empty strings "", they're ignored and the current settings are preserved. Otherwise, they're updated with the new settings. 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool ChangeSettings(string Extras)
        {
            return ChangeSettingsAsync(Extras).Result;
        }


        /// <summary>
        /// Crops an image, starting point (0,0)
        /// </summary>
        /// <param name="Height"></param>
        /// <param name="Width"></param>
        /// <returns></returns>
        public bool Crop(int Height, int Width)
        {
            return Crop(Height, Width, 0, 0);
        }

        /// <summary>
        /// Crops an image
        /// </summary>
        /// <param name="Height"></param>
        /// <param name="Width"></param>
        /// <param name="X">X coordonate of the starting point, default 0(top left)</param>
        /// <param name="Y">Y coordonate of the starting point, default 0</param>
        /// <returns></returns>
        public bool Crop(int Height, int Width, int X, int Y)
        {
            return CropAsync(Height, Width, X, Y).Result;
        }

        /// <summary>
        /// Crops the thumbnail of an image (starting point (0,0))
        /// </summary>
        /// <param name="Height"></param>
        /// <param name="Width"></param>
        /// <returns></returns>
        public bool ZoomThumbnail(int Height, int Width)
        {
            return ZoomThumbnail(Height, Width, 0, 0);
        }

        /// <summary>
        /// Crops the thumbnail of an image
        /// </summary>
        /// <param name="Height"></param>
        /// <param name="Width"></param>
        /// <param name="X">X coordonate of the starting point, default 0 (top left)</param>
        /// <param name="Y">Y coordonate of the starting point, default 0</param>
        /// <returns></returns>
        public bool ZoomThumbnail(int Height, int Width, int X, int Y)
        {
            return ZoomThumbnailAsync(Height, Width, X, Y).Result;
        }

        /// <summary>
        /// Rotates an image
        /// </summary>
        /// <param name="de">The degrees of rotation. Left=90, Down=180, Right=270</param>
        /// <returns>bool</returns>
        public bool Rotate(DegreesEnum de)
        {
            return Rotate(de, false);
        }

        /// <summary>
        /// Rotates an image
        /// </summary>
        /// <param name="de">The degrees of rotation. Left=90, Down=180, Right=270</param>
        /// <param name="Flip">If true, mirror the image in the horizontal direction</param>
        /// <returns>bool</returns>
        public bool Rotate(DegreesEnum de, bool Flip)
        {
            return RotateAsync(de, Flip).Result;
        }

        /// <summary>
        /// Returns camera and photograph details about an image (id, Key, Aperture, Brightness, CCDWidth, ColorSpace, CompressedBitsPixel, Contrast, DateTime, DateTimeDigitized, DateTimeOriginal, DigitalZoomRatio, ExposureBias, ExposureMode, ExposureProgram, ExposureTime, Flash, FocalLength, FocalLengthIn35mmFilm, ISO, LightSource, Make, Metering, Model, Saturation, SensingMethod, Sharpness, SubjectDistance, SubjectDistanceRange, WhiteBalance). The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, the album owner must have specified that EXIF data is allowed. Note that many photos have no EXIF data, so an empty or partially returned result is very normal
        /// </summary>
        /// <returns>Image with properties id, Key, Aperture, Brightness, CCDWidth, ColorSpace, CompressedBitsPixel, Contrast, DateTime, DateTimeDigitized, DateTimeOriginal, DigitalZoomRatio, ExposureBias, ExposureMode, ExposureProgram, ExposureTime, Flash, FocalLength, FocalLengthIn35mmFilm, ISO, LightSource, Make, Metering, Model, Saturation, SensingMethod, Sharpness, SubjectDistance, SubjectDistanceRange, WhiteBalance)</returns>
        public Image GetEXIF()
        {
            return GetEXIF("");
        }

        /// <summary>
        /// Returns camera and photograph details about an image (id, Key, Aperture, Brightness, CCDWidth, ColorSpace, CompressedBitsPixel, Contrast, DateTime, DateTimeDigitized, DateTimeOriginal, DigitalZoomRatio, ExposureBias, ExposureMode, ExposureProgram, ExposureTime, Flash, FocalLength, FocalLengthIn35mmFilm, ISO, LightSource, Make, Metering, Model, Saturation, SensingMethod, Sharpness, SubjectDistance, SubjectDistanceRange, WhiteBalance). The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, the album owner must have specified that EXIF data is allowed. Note that many photos have no EXIF data, so an empty or partially returned result is very normal
        /// </summary>
        /// <param name="SitePassword">The site password for a specific user</param>
        /// <returns>Image with properties id, Key, Aperture, Brightness, CCDWidth, ColorSpace, CompressedBitsPixel, Contrast, DateTime, DateTimeDigitized, DateTimeOriginal, DigitalZoomRatio, ExposureBias, ExposureMode, ExposureProgram, ExposureTime, Flash, FocalLength, FocalLengthIn35mmFilm, ISO, LightSource, Make, Metering, Model, Saturation, SensingMethod, Sharpness, SubjectDistance, SubjectDistanceRange, WhiteBalance)</returns>
        public Image GetEXIF(string SitePassword)
        {
            return GetEXIFAsync(SitePassword).Result;
        }

        /// <summary>
        /// Populate the current image with camera and photograph details (id, Key, Aperture, Brightness, CCDWidth, ColorSpace, CompressedBitsPixel, Contrast, DateTime, DateTimeDigitized, DateTimeOriginal, DigitalZoomRatio, ExposureBias, ExposureMode, ExposureProgram, ExposureTime, Flash, FocalLength, FocalLengthIn35mmFilm, ISO, LightSource, Make, Metering, Model, Saturation, SensingMethod, Sharpness, SubjectDistance, SubjectDistanceRange, WhiteBalance). The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, the album owner must have specified that EXIF data is allowed. Note that many photos have no EXIF data, so an empty or partially returned result is very normal
        /// </summary>
        public void PopulateImageWithEXIFFromSite()
        {
            PopulateImageWithEXIFFromSiteAsync("").Wait();
        }

        /// <summary>
        /// Populate the current image with camera and photograph details (id, Key, Aperture, Brightness, CCDWidth, ColorSpace, CompressedBitsPixel, Contrast, DateTime, DateTimeDigitized, DateTimeOriginal, DigitalZoomRatio, ExposureBias, ExposureMode, ExposureProgram, ExposureTime, Flash, FocalLength, FocalLengthIn35mmFilm, ISO, LightSource, Make, Metering, Model, Saturation, SensingMethod, Sharpness, SubjectDistance, SubjectDistanceRange, WhiteBalance). The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, the album owner must have specified that EXIF data is allowed. Note that many photos have no EXIF data, so an empty or partially returned result is very normal
        /// </summary>
        /// <param name="SitePassword">The site password for a specific user</param>
        public void PopulateImageWithEXIFFromSite(string SitePassword)
        {
            PopulateImageWithEXIFFromSiteAsync(SitePassword).Wait();
        }

        /// <summary>
        /// Returns details about the image specified by ImageID (id, Key, Album -Id,Key,URL; Altitude, Caption, Date, FileName, Duration, Format, Heaight, Hidden, Keywords, LargeURL, LastUpdated, Latitude, Longitude, MD5Sum, MediumURL, OriginalURL, Position, Serial, Size, SmallURL, ThumbURL, TinyURL, Video320URL, Video640URL, Video960URL, Video1280URL, Video1920URL, Width, X2LardeURL, X3LargeURL, XLargeURL). The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, some fields are only returned to the Album owner
        /// </summary>
        /// <returns>Image with properties</returns>
        public Image GetInfo()
        {
            return GetInfo(false, "");
        }

        /// <summary>
        /// Returns details about the image specified by ImageID (id, Key, Album -Id,Key,URL; Altitude, Caption, Date, FileName, Duration, Format, Heaight, Hidden, Keywords, LargeURL, LastUpdated, Latitude, Longitude, MD5Sum, MediumURL, OriginalURL, Position, Serial, Size, SmallURL, ThumbURL, TinyURL, Video320URL, Video640URL, Video960URL, Video1280URL, Video1920URL, Width, X2LardeURL, X3LargeURL, XLargeURL). The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, some fields are only returned to the Album owner
        /// </summary>
        /// <param name="Sandboxed">Forces URLs to a location with a crossdomain.xml file. Default: false</param> 
        /// <param name="SitePassword">The site password for a specific user</param>
        /// <returns>Image with properties</returns>
        public Image GetInfo(bool Sandboxed, string SitePassword)
        {
            return GetInfoAsync(Sandboxed, SitePassword).Result;
        }

        /// <summary>
        /// Populate the current image with info from the site. The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, some fields are only returned to the Album owner
        /// </summary>
        /// <returns></returns>
        public void PopulateImageWithInfoFromSite()
        {
            PopulateImageWithInfoFromSite(false, "");
        }

        /// <summary>
        /// Populate the current image with info from the site. The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, some fields are only returned to the Album owner
        /// </summary>
        /// <param name="Sandboxed">Forces URLs to a location with a crossdomain.xml file. Default: false</param>
        /// <param name="SitePassword">The site password for a specific user</param>
        public void PopulateImageWithInfoFromSite(bool Sandboxed, string SitePassword)
        {
            PopulateImageWithInfoFromSiteAsync(Sandboxed, SitePassword).Wait();
        }

        /// <summary>
        /// Return all the URLs for the various sizes of the image specified by ImageID. The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, obvious restrictions on Originals and Larges apply if so set by the owner. They will return as empty strings for those URLs if they're unavailable
        /// </summary>
        /// <returns>Image</returns>
        public Image GetURLs()
        {
            return GetURLsAsync(false, "", "").Result;
        }

        /// <summary>
        /// Return all the URLs for the various sizes of the image specified by ImageID. The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, obvious restrictions on Originals and Larges apply if so set by the owner. They will return as empty strings for those URLs if they're unavailable
        /// </summary> 
        /// <param name="Sandboxed">Forces URLs to a location with a crossdomain.xml file. Default: false</param>
        /// <param name="SitePassword">The site password for a specific user</param>
        /// <returns>Image</returns>
        public Image GetURLs(bool Sandboxed, string SitePassword, string CustomSize)
        {
            return GetURLsAsync(Sandboxed, SitePassword, CustomSize).Result;
        }

        /// <summary>
        /// Populate the current image with all the URLs for the various sizes from the site. The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, obvious restrictions on Originals and Larges apply if so set by the owner. They will return as empty strings for those URLs if they're unavailable
        /// </summary>
        public void PopulateImageWithURLsFromSite()
        {
            PopulateImageWithURLsFromSiteAsync(false, "", "").Wait();
        }

        /// <summary>
        /// Populate the current image with all the URLs for the various sizes from the site. The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, obvious restrictions on Originals and Larges apply if so set by the owner. They will return as empty strings for those URLs if they're unavailable
        /// </summary>
        /// <param name="Sandboxed">Forces URLs to a location with a crossdomain.xml file. Default: false</param>
        /// <param name="SitePassword">The site password for a specific user</param>
        /// <returns></returns>
        public void PopulateImageWithURLsFromSite(bool Sandboxed, string SitePassword)
        {
            PopulateImageWithURLsFromSiteAsync(Sandboxed, SitePassword, "").Wait();
        }

        /// <summary>
        /// Deletes the specified Image
        /// </summary>
        /// <returns>bool</returns>
        public bool Delete()
        {
            return DeleteAsync().Result;
        }



        /// <summary>
        /// Gets transfer statistics for the given Image during the given Month (Bytes, Hits, Large, Medium, Original, Small, Thumb, Tiny, X2Large, X3Large, XLarge, Video320, Video640, Video960, Video1280, Video1920). SmugMug only keeps the last few months of traffic on file, so requesting farther back then 2 months may not return valid results. A float is provided for Original because it's possible to watch only a portion of a video
        /// </summary>
        /// <param name="Month"></param>
        /// <returns></returns>
        public Image GetStats(int Month, int Year)
        {
            return GetStatsAsync(Month, Year).Result;
        }

        /// <summary>
        /// Populate the current image with transfer statistics from the site for the given Month (Bytes, Hits, Large, Medium, Original, Small, Thumb, Tiny, X2Large, X3Large, XLarge, Video320, Video640, Video960, Video1280, Video1920). SmugMug only keeps the last few months of traffic on file, so requesting farther back then 2 months may not return valid results. A float is provided for Original because it's possible to watch only a portion of a video
        /// </summary>
        /// <param name="Month"></param>
        /// <returns></returns>
        public void PopulateImageWithStatsFromSite(int Month, int Year)
        {
            PopulateImageWithStatsFromSiteAsync(Month, Year).Wait();
        }

        /// <summary>
        /// Retrieves pricing for an image (doesn't work anymore?)
        /// </summary>
        /// <returns></returns>
        public bool GetPricing()
        {
            return GetPricingAsync().Result;
        }



        /// <summary>
        /// Applies a watermark to an image
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public bool ApplyWatermark(Watermark w)
        {
            return ApplyWatermarkAsync(w).Result;
        }

        /// <summary>
        /// Removes a watermark from an image
        /// </summary>
        /// <returns></returns>
        public bool RemoveWatermark()
        {
            return RemoveWatermarkAsync().Result;
        }

        /// <summary>
        /// Creates a new watermark from a specified image
        /// </summary>
        /// <param name="Name">The name for the watermark</param>
        /// <returns>Watermark</returns>
        public Watermark CreateWatermark(string Name)
        {
            return CreateWatermark(Name, 0, PinnedEnum.Center, false, "");
        }

        /// <summary>
        /// Creates a new watermark from a specified image
        /// </summary>
        /// <param name="Name">The name for the watermark</param>
        /// <param name="Dissolve">The opacity of the watermark on the target image. Default: 0  Min: 0  Max: 100  </param>
        /// <param name="Pinned">The location of the watermark on the target image. Values:  Bottom, BottomLeft, BottomRight, Center (default), Left, Right, Tile, Top, TopLeft, TopRight</param> 
        /// <param name="Thumbs">This watermark is applied to thumbnail image sizes. Default: false  </param>
        /// <returns>Watermark</returns>
        public Watermark CreateWatermark(string Name, int Dissolve, PinnedEnum Pinned, bool Thumbs)
        {
            return CreateWatermark(Name, Dissolve, Pinned, Thumbs, "");
        }

        /// <summary>
        /// Creates a new watermark from a specified image
        /// </summary>
        /// <param name="Name">The name for the watermark</param>
        /// <param name="Dissolve">The opacity of the watermark on the target image. Default: 0  Min: 0  Max: 100  </param>
        /// <param name="Pinned">The location of the watermark on the target image. Values:  Bottom, BottomLeft, BottomRight, Center (default), Left, Right, Tile, Top, TopLeft, TopRight</param> 
        /// <param name="Thumbs">This watermark is applied to thumbnail image sizes. Default: false  </param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns>Watermark</returns>
        public Watermark CreateWatermark(string Name, int Dissolve, PinnedEnum Pinned, bool Thumbs, string Extras)
        {
            return CreateWatermarkAsync(Name, Dissolve, Pinned, Thumbs, Extras).Result;
        }

        /// <summary>
        /// Add a comment to an image
        /// </summary>
        /// <param name="Text">The text for the comment</param>
        /// <returns></returns>
        public Comment AddComment(string Text)
        {
            return AddComment(Text, 0, "");
        }

        /// <summary>
        /// Add a comment to an image
        /// </summary>
        /// <param name="Text">The text for the comment</param>
        /// <param name="Rating">The rating for this comment. Values:  0 - No Rating (Default), 1 - 1 Star Rating, 2 - 2 Star Rating, 3 - 3 Star Rating, 4 - 4 Star Rating, 5 - 5 Star Rating</param>
        /// <returns></returns>
        public Comment AddComment(string Text, int Rating)
        {
            return AddComment(Text, Rating, "");
        }

        /// <summary>
        /// Add a comment to an image
        /// </summary>
        /// <param name="Text">The text for the comment</param>
        /// <param name="Rating">The rating for this comment. Values:  0 - No Rating (Default), 1 - 1 Star Rating, 2 - 2 Star Rating, 3 - 3 Star Rating, 4 - 4 Star Rating, 5 - 5 Star Rating</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns></returns>
        public Comment AddComment(string Text, int Rating, string Extras)
        {
            return AddCommentAsync(Text, Rating, Extras).Result;
        }

        /// <summary>
        /// Retrieves a list of comments for an image
        /// </summary>
        public void  GetComments()
        {
            GetComments(false, 0, "");
        }

        /// <summary>
        /// Retrieves a list of comments for an image
        /// </summary>
        /// <param name="SitePassword">The site password for a specific user</param>
        public void GetComments(string SitePassword)
        {
            GetComments(false, 0, SitePassword);
        }

        /// <summary>
        /// Retrieves a list of comments for an image
        /// </summary>
        /// <param name="Associative">Returns an associative array. Default: false</param>
        /// <param name="LastUpdated">Return results where LastUpdated is after the epoch time provided</param>
        /// <param name="SitePassword">The site password for a specific user</param>
        public void GetComments(bool Associative, int LastUpdated, string SitePassword)
        {
            GetCommentsAsync(Associative, LastUpdated, SitePassword).Wait();
        }

        /// <summary>
        /// Create a printmark (basic)
        /// </summary>
        /// <param name="Name">The name for the printmark</param>
        /// <returns>New printmark (id)</returns>
        public Printmark CreatePrintmark(string Name)
        {
            return CreatePrintmark(Name, 0, "BottomRight", "");
        }

        /// <summary>
        /// Create a printmark (basic+extras)
        /// </summary>
        /// <param name="Name">The name for the printmark</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns>New printmark (id)</returns>
        public Printmark CreatePrintmark(string Name, string Extras)
        {
            return CreatePrintmark(Name, 0, "BottomRight", Extras);
        }

        /// <summary>
        /// Create a printmark (all params)
        /// </summary>
        /// <param name="Name">The name for the printmark</param>
        /// <param name="Dissolve">The opacity of the printmark on the target image. Default: 0. Min: 0. Max: 100</param>
        /// <param name="Location">The location of the printmark on the target image. Values: TopLeft, TopRight, BottomLeft, BottomRight(default), Top, Bottom</param>
        /// <returns>New printmark (id)</returns>
        public Printmark CreatePrintmark(string Name, int Dissolve, string Location)
        {
            return CreatePrintmark(Name, Dissolve, Location, "");
        }

        /// <summary>
        /// Create a printmark (all params+extras)
        /// </summary>
        /// <param name="Name">The name for the printmark</param>
        /// <param name="Dissolve">The opacity of the printmark on the target image. Default: 0. Min: 0. Max: 100</param>
        /// <param name="Location">The location of the printmark on the target image. Values: TopLeft, TopRight, BottomLeft, BottomRight(default), Top, Bottom</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns>New printmark (id)</returns>
        public Printmark CreatePrintmark(string Name, int Dissolve, string Location, string Extras)
        {
            return CreatePrintmarkAsync(Name, Dissolve, Location, Extras).Result;
        }

        /// <summary>
        /// Collect an image into an album
        /// </summary>
        /// <param name="a">Album into which to collect the image</param>
        /// <returns></returns>
        public Image CollectIntoAlbum()
        {
            return CollectIntoAlbumAsync("").Result;
        }

        /// <summary>
        /// Collect an image into an album
        /// </summary>
        /// <param name="a">Album into which to collect the image</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns></returns>
        public Image CollectIntoAlbum(string Extras)
        {
            return CollectIntoAlbumAsync(Extras).Result;
        }

        #endregion

        #region Async
        /// <summary>
        /// Changes the position of an image in an album
        /// </summary>
        /// <param name="Position">The new position within the album</param>
        /// <returns></returns>
        public async Task<bool> ChangePositionAsync(int Position)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], Position [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.changePosition", basic, "ImageID", id, "Position", Position);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Updates specific settings (AlbumID - move, Altitude, Caption, FileName, Hidden, Keywords, Latitude, Longitude) for a given image specified by ImageID. If any of the parameters are missing or are empty strings "", they're ignored and the current settings are preserved. Otherwise, they're updated with the new settings. 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public async Task<bool> ChangeSettingsAsync()
        {
            return await ChangeSettingsAsync("");
        }

        /// <summary>
        /// Updates specific settings (AlbumID - move, Altitude, Caption, FileName, Hidden, Keywords, Latitude, Longitude) for a given image specified by ImageID. If any of the parameters are missing or are empty strings "", they're ignored and the current settings are preserved. Otherwise, they're updated with the new settings. 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public async Task<bool> ChangeSettingsAsync(string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            this.Extras = Extras;
            // SessionID [required], ImageId [required], AlbumID, Altitude, Callback, Caption, FileName, Hidden, Keywords, Latitude, Longitude, Pretty, Strict
            var ls = BuildPropertiesValueList(this);
            ls.Add("ImageID"); ls.Add(this.id.ToString());
            var resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.changeSettings", basic, ls.ToArray());

            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }


        /// <summary>
        /// Crops an image, starting point (0,0)
        /// </summary>
        /// <param name="Height"></param>
        /// <param name="Width"></param>
        /// <returns></returns>
        public async Task<bool> CropAsync(int Height, int Width)
        {
            return await CropAsync(Height, Width, 0, 0);
        }

        /// <summary>
        /// Crops an image
        /// </summary>
        /// <param name="Height"></param>
        /// <param name="Width"></param>
        /// <param name="X">X coordonate of the starting point, default 0(top left)</param>
        /// <param name="Y">Y coordonate of the starting point, default 0</param>
        /// <returns></returns>
        public async Task<bool> CropAsync(int Height, int Width, int X, int Y)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], Height [required], Width [required], Callback, Pretty, Strict, X, Y
            var resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.crop", basic, "ImageID", id, "Height", Height, "Width", Width, "X", X, "Y", Y);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Crops the thumbnail of an image (starting point (0,0))
        /// </summary>
        /// <param name="Height"></param>
        /// <param name="Width"></param>
        /// <returns></returns>
        public async Task<bool> ZoomThumbnailAsync(int Height, int Width)
        {
            return await ZoomThumbnailAsync(Height, Width, 0, 0);
        }

        /// <summary>
        /// Crops the thumbnail of an image
        /// </summary>
        /// <param name="Height"></param>
        /// <param name="Width"></param>
        /// <param name="X">X coordonate of the starting point, default 0 (top left)</param>
        /// <param name="Y">Y coordonate of the starting point, default 0</param>
        /// <returns></returns>
        public async Task<bool> ZoomThumbnailAsync(int Height, int Width, int X, int Y)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], Height [required], Width [required], X, Y, Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.zoomThumbnail", basic, "ImageID", id, "Height", Height, "Width", Width, "X", X, "Y", Y);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Rotates an image
        /// </summary>
        /// <param name="de">The degrees of rotation. Left=90, Down=180, Right=270</param>
        /// <returns>bool</returns>
        public async Task<bool> RotateAsync(DegreesEnum de)
        {
            return await RotateAsync(de, false);
        }

        /// <summary>
        /// Rotates an image
        /// </summary>
        /// <param name="de">The degrees of rotation. Left=90, Down=180, Right=270</param>
        /// <param name="Flip">If true, mirror the image in the horizontal direction</param>
        /// <returns>bool</returns>
        public async Task<bool> RotateAsync(DegreesEnum de, bool Flip)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], Degrees [required], Flip [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.rotate", basic, "ImageID", id, "Degrees", (int)de, "Flip", Flip);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Returns camera and photograph details about an image (id, Key, Aperture, Brightness, CCDWidth, ColorSpace, CompressedBitsPixel, Contrast, DateTime, DateTimeDigitized, DateTimeOriginal, DigitalZoomRatio, ExposureBias, ExposureMode, ExposureProgram, ExposureTime, Flash, FocalLength, FocalLengthIn35mmFilm, ISO, LightSource, Make, Metering, Model, Saturation, SensingMethod, Sharpness, SubjectDistance, SubjectDistanceRange, WhiteBalance). The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, the album owner must have specified that EXIF data is allowed. Note that many photos have no EXIF data, so an empty or partially returned result is very normal
        /// </summary>
        /// <returns>Image with properties id, Key, Aperture, Brightness, CCDWidth, ColorSpace, CompressedBitsPixel, Contrast, DateTime, DateTimeDigitized, DateTimeOriginal, DigitalZoomRatio, ExposureBias, ExposureMode, ExposureProgram, ExposureTime, Flash, FocalLength, FocalLengthIn35mmFilm, ISO, LightSource, Make, Metering, Model, Saturation, SensingMethod, Sharpness, SubjectDistance, SubjectDistanceRange, WhiteBalance)</returns>
        public async Task<Image> GetEXIFAsync()
        {
            return await GetEXIFAsync("");
        }

        /// <summary>
        /// Returns camera and photograph details about an image (id, Key, Aperture, Brightness, CCDWidth, ColorSpace, CompressedBitsPixel, Contrast, DateTime, DateTimeDigitized, DateTimeOriginal, DigitalZoomRatio, ExposureBias, ExposureMode, ExposureProgram, ExposureTime, Flash, FocalLength, FocalLengthIn35mmFilm, ISO, LightSource, Make, Metering, Model, Saturation, SensingMethod, Sharpness, SubjectDistance, SubjectDistanceRange, WhiteBalance). The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, the album owner must have specified that EXIF data is allowed. Note that many photos have no EXIF data, so an empty or partially returned result is very normal
        /// </summary>
        /// <param name="SitePassword">The site password for a specific user</param>
        /// <returns>Image with properties id, Key, Aperture, Brightness, CCDWidth, ColorSpace, CompressedBitsPixel, Contrast, DateTime, DateTimeDigitized, DateTimeOriginal, DigitalZoomRatio, ExposureBias, ExposureMode, ExposureProgram, ExposureTime, Flash, FocalLength, FocalLengthIn35mmFilm, ISO, LightSource, Make, Metering, Model, Saturation, SensingMethod, Sharpness, SubjectDistance, SubjectDistanceRange, WhiteBalance)</returns>
        public async Task<Image> GetEXIFAsync(string SitePassword)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], ImageKey [required], Callback, Password, Pretty, SitePassword, Strict 
            ImageResponse resp = new ImageResponse();
            if ((Album != null) && (Album.Password != null) && (Album.Password != String.Empty))
                resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.getEXIF", basic, "ImageID", id, "ImageKey", Key, "SitePassword", SitePassword, "Password", Album.Password);
            else
                resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.getEXIF", basic, "ImageID", id, "ImageKey", Key, "SitePassword", SitePassword);
            if (resp.stat == "ok")
            {
                var temp = resp.Image;
                temp.basic = basic;
                temp.Key = Key;
                return temp;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Populate the current image with camera and photograph details (id, Key, Aperture, Brightness, CCDWidth, ColorSpace, CompressedBitsPixel, Contrast, DateTime, DateTimeDigitized, DateTimeOriginal, DigitalZoomRatio, ExposureBias, ExposureMode, ExposureProgram, ExposureTime, Flash, FocalLength, FocalLengthIn35mmFilm, ISO, LightSource, Make, Metering, Model, Saturation, SensingMethod, Sharpness, SubjectDistance, SubjectDistanceRange, WhiteBalance). The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, the album owner must have specified that EXIF data is allowed. Note that many photos have no EXIF data, so an empty or partially returned result is very normal
        /// </summary>
        public async Task PopulateImageWithEXIFFromSiteAsync()
        {
            await PopulateImageWithEXIFFromSiteAsync("");
        }

        /// <summary>
        /// Populate the current image with camera and photograph details (id, Key, Aperture, Brightness, CCDWidth, ColorSpace, CompressedBitsPixel, Contrast, DateTime, DateTimeDigitized, DateTimeOriginal, DigitalZoomRatio, ExposureBias, ExposureMode, ExposureProgram, ExposureTime, Flash, FocalLength, FocalLengthIn35mmFilm, ISO, LightSource, Make, Metering, Model, Saturation, SensingMethod, Sharpness, SubjectDistance, SubjectDistanceRange, WhiteBalance). The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, the album owner must have specified that EXIF data is allowed. Note that many photos have no EXIF data, so an empty or partially returned result is very normal
        /// </summary>
        /// <param name="SitePassword">The site password for a specific user</param>
        public async Task PopulateImageWithEXIFFromSiteAsync(string SitePassword)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], ImageKey [required], Callback, Password, Pretty, SitePassword, Strict
            ImageResponse resp = new ImageResponse();
            if ((Album != null) && (Album.Password != null) && (Album.Password != String.Empty))
                resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.getEXIF", basic, "ImageID", id, "ImageKey", Key, "SitePassword", SitePassword, "Password", Album.Password);
            else
                resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.getEXIF", basic, "ImageID", id, "ImageKey", Key, "SitePassword", SitePassword);

            if (resp.stat == "ok")
            {
                PopulateWithResponse(resp.Image, this);
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Returns details about the image specified by ImageID (id, Key, Album -Id,Key,URL; Altitude, Caption, Date, FileName, Duration, Format, Heaight, Hidden, Keywords, LargeURL, LastUpdated, Latitude, Longitude, MD5Sum, MediumURL, OriginalURL, Position, Serial, Size, SmallURL, ThumbURL, TinyURL, Video320URL, Video640URL, Video960URL, Video1280URL, Video1920URL, Width, X2LardeURL, X3LargeURL, XLargeURL). The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, some fields are only returned to the Album owner
        /// </summary>
        /// <returns>Image with properties</returns>
        public async Task<Image> GetInfoAsync()
        {
            return await GetInfoAsync(false, "");
        }

        /// <summary>
        /// Returns details about the image specified by ImageID (id, Key, Album -Id,Key,URL; Altitude, Caption, Date, FileName, Duration, Format, Heaight, Hidden, Keywords, LargeURL, LastUpdated, Latitude, Longitude, MD5Sum, MediumURL, OriginalURL, Position, Serial, Size, SmallURL, ThumbURL, TinyURL, Video320URL, Video640URL, Video960URL, Video1280URL, Video1920URL, Width, X2LardeURL, X3LargeURL, XLargeURL). The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, some fields are only returned to the Album owner
        /// </summary>
        /// <param name="Sandboxed">Forces URLs to a location with a crossdomain.xml file. Default: false</param> 
        /// <param name="SitePassword">The site password for a specific user</param>
        /// <returns>Image with properties</returns>
        public async Task<Image> GetInfoAsync(bool Sandboxed, string SitePassword)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], ImageKey [required], Callback, Password, Pretty, Sandboxed (boolean. Forces URLs to a location with a crossdomain.xml file. Default: false), SitePassword, Strict
            ImageResponse resp = new ImageResponse();
            if ((Album != null) && (Album.Password != null) && (Album.Password != String.Empty))
                resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.getInfo", basic, "ImageID", id, "ImageKey", Key, "Sandboxed", Sandboxed, "SitePassword", SitePassword, "Password", Album.Password);
            else
                resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.getInfo", basic, "ImageID", id, "ImageKey", Key, "Sandboxed", Sandboxed, "SitePassword", SitePassword);
            if (resp.stat == "ok")
            {
                var temp = resp.Image;
                temp.basic = basic;
                return temp;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Populate the current image with info from the site. The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, some fields are only returned to the Album owner
        /// </summary>
        /// <returns></returns>
        public async Task PopulateImageWithInfoFromSiteAsync()
        {
            await PopulateImageWithInfoFromSiteAsync(false, "");
        }

        /// <summary>
        /// Populate the current image with info from the site. The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, some fields are only returned to the Album owner
        /// </summary>
        /// <param name="Sandboxed">Forces URLs to a location with a crossdomain.xml file. Default: false</param>
        /// <param name="SitePassword">The site password for a specific user</param>
        public async Task PopulateImageWithInfoFromSiteAsync(bool Sandboxed, string SitePassword)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], ImageKey [required], Callback, Password, Pretty, Sandboxed, SitePassword, Strict
            ImageResponse resp = new ImageResponse();
            if ((Album != null) && (Album.Password != null) && (Album.Password != String.Empty))
                resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.getInfo", basic, "ImageID", id, "ImageKey", Key, "Sandboxed", Sandboxed, "SitePassword", SitePassword, "Password", Album.Password);
            else
                resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.getInfo", basic, "ImageID", id, "ImageKey", Key, "Sandboxed", Sandboxed, "SitePassword", SitePassword);
            if (resp.stat == "ok")
                PopulateWithResponse(resp.Image, this);
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Return all the URLs for the various sizes of the image specified by ImageID. The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, obvious restrictions on Originals and Larges apply if so set by the owner. They will return as empty strings for those URLs if they're unavailable
        /// </summary>
        /// <returns>Image</returns>
        public async Task<Image> GetURLsAsync()
        {
            return await GetURLsAsync(false, "", "");
        }

        /// <summary>
        /// Return all the URLs for the various sizes of the image specified by ImageID. The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, obvious restrictions on Originals and Larges apply if so set by the owner. They will return as empty strings for those URLs if they're unavailable
        /// </summary> 
        /// <param name="Sandboxed">Forces URLs to a location with a crossdomain.xml file. Default: false</param>
        /// <param name="SitePassword">The site password for a specific user</param>
        /// <returns>Image</returns>
        public async Task<Image> GetURLsAsync(bool Sandboxed, string SitePassword, string CustomSize)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], ImageKey [required], Callback, Password, Pretty, Sandboxed (boolean. Forces URLs to a location with a crossdomain.xml file. Default: false), SitePassword, Strict, TemplateID
            ImageResponse resp = new ImageResponse();
            if ((Album != null) && (Album.Password != null) && (Album.Password != String.Empty))
                resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.getURLs", basic, "ImageID", id, "ImageKey", Key, "Sandboxed", Sandboxed, "SitePassword", SitePassword, "Password", Album.Password, "CustomSize", CustomSize);
            else
                resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.getURLs", basic, "ImageID", id, "ImageKey", Key, "Sandboxed", Sandboxed, "SitePassword", SitePassword, "CustomSize", CustomSize);
            if (resp.stat == "ok")
            {
                var temp = resp.Image;
                temp.basic = basic;
                return temp;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Populate the current image with all the URLs for the various sizes from the site. The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, obvious restrictions on Originals and Larges apply if so set by the owner. They will return as empty strings for those URLs if they're unavailable
        /// </summary>
        public async Task PopulateImageWithURLsFromSiteAsync()
        {
            await PopulateImageWithURLsFromSiteAsync(false, "", "");
        }

        /// <summary>
        /// Populate the current image with all the URLs for the various sizes from the site. The Album must be owned by the Session holder, or else be Public (if password-protected, a Password must be provided), to return results. Otherwise, an "invalid user" faultCode will result. Additionally, obvious restrictions on Originals and Larges apply if so set by the owner. They will return as empty strings for those URLs if they're unavailable
        /// </summary>
        /// <param name="Sandboxed">Forces URLs to a location with a crossdomain.xml file. Default: false</param>
        /// <param name="SitePassword">The site password for a specific user</param>
        /// <returns></returns>
        public async Task PopulateImageWithURLsFromSiteAsync(bool Sandboxed, string SitePassword, string CustomSize)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], ImageKey [required], Callback, Password, Pretty, Sandboxed, SitePassword, Strict, TemplateID
            ImageResponse resp = new ImageResponse();
            if ((Album != null) && (Album.Password != null) && (Album.Password != String.Empty))
                resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.getURLs", basic, "ImageID", id, "ImageKey", Key, "Sandboxed", Sandboxed, "SitePassword", SitePassword, "Password", Album.Password, "CustomSize", CustomSize);
            else
                resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.getURLs", basic, "ImageID", id, "ImageKey", Key, "Sandboxed", Sandboxed, "SitePassword", SitePassword, "CustomSize", CustomSize);

            if (resp.stat == "ok")
            {
                PopulateWithResponse(resp.Image, this);
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Deletes the specified Image
        /// </summary>
        /// <returns>bool</returns>
        public async Task<bool> DeleteAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.delete", basic, "ImageID", id);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }



        /// <summary>
        /// Gets transfer statistics for the given Image during the given Month (Bytes, Hits, Large, Medium, Original, Small, Thumb, Tiny, X2Large, X3Large, XLarge, Video320, Video640, Video960, Video1280, Video1920). SmugMug only keeps the last few months of traffic on file, so requesting farther back then 2 months may not return valid results. A float is provided for Original because it's possible to watch only a portion of a video
        /// </summary>
        /// <param name="Month"></param>
        /// <returns></returns>
        public async Task<Image> GetStatsAsync(int Month, int Year)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], Month [required], Year [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.getStats", basic, "ImageID", id, "Month", Month, "Year", Year);
            if (resp.stat == "ok")
            {
                var temp = resp.Image;
                temp.basic = basic;
                return temp;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Populate the current image with transfer statistics from the site for the given Month (Bytes, Hits, Large, Medium, Original, Small, Thumb, Tiny, X2Large, X3Large, XLarge, Video320, Video640, Video960, Video1280, Video1920). SmugMug only keeps the last few months of traffic on file, so requesting farther back then 2 months may not return valid results. A float is provided for Original because it's possible to watch only a portion of a video
        /// </summary>
        /// <param name="Month"></param>
        /// <returns></returns>
        public async Task PopulateImageWithStatsFromSiteAsync(int Month, int Year)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], Month [required], Year [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.getStats", basic, "ImageID", id, "Month", Month, "Year", Year);
            if (resp.stat == "ok")
                PopulateWithResponse(resp.Image, this);
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Retrieves pricing for an image (doesn't work anymore?)
        /// </summary>
        /// <returns></returns>
        public async Task<bool> GetPricingAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], Callback, Pretty, ProductID, ProductType, Strict
            var resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.getPricing", basic, "ImageID", id);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }



        /// <summary>
        /// Applies a watermark to an image
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public async Task<bool> ApplyWatermarkAsync(Watermark w)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], WatermarkID [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.applyWatermark", basic, "ImageID", id, "WatermarkID", w.id);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Removes a watermark from an image
        /// </summary>
        /// <returns></returns>
        public async Task<bool> RemoveWatermarkAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.removeWatermark", basic, "ImageID", id);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Creates a new watermark from a specified image
        /// </summary>
        /// <param name="Name">The name for the watermark</param>
        /// <returns>Watermark</returns>
        public async Task<Watermark> CreateWatermarkAsync(string Name)
        {
            return await CreateWatermarkAsync(Name, 0, PinnedEnum.Center, false, "");
        }

        /// <summary>
        /// Creates a new watermark from a specified image
        /// </summary>
        /// <param name="Name">The name for the watermark</param>
        /// <param name="Dissolve">The opacity of the watermark on the target image. Default: 0  Min: 0  Max: 100  </param>
        /// <param name="Pinned">The location of the watermark on the target image. Values:  Bottom, BottomLeft, BottomRight, Center (default), Left, Right, Tile, Top, TopLeft, TopRight</param> 
        /// <param name="Thumbs">This watermark is applied to thumbnail image sizes. Default: false  </param>
        /// <returns>Watermark</returns>
        public async Task<Watermark> CreateWatermarkAsync(string Name, int Dissolve, PinnedEnum Pinned, bool Thumbs)
        {
            return await CreateWatermarkAsync(Name, Dissolve, Pinned, Thumbs, "");
        }

        /// <summary>
        /// Creates a new watermark from a specified image
        /// </summary>
        /// <param name="Name">The name for the watermark</param>
        /// <param name="Dissolve">The opacity of the watermark on the target image. Default: 0  Min: 0  Max: 100  </param>
        /// <param name="Pinned">The location of the watermark on the target image. Values:  Bottom, BottomLeft, BottomRight, Center (default), Left, Right, Tile, Top, TopLeft, TopRight</param> 
        /// <param name="Thumbs">This watermark is applied to thumbnail image sizes. Default: false  </param>
        /// <param name="Extras">A comma seperated string of additional attributes to return in the response.</param>
        /// <returns>Watermark</returns>
        public async Task<Watermark> CreateWatermarkAsync(string Name, int Dissolve, PinnedEnum Pinned, bool Thumbs, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageID [required], Name [required], Callback, Dissolve, Pinned, Pretty, Strict, Thumbs
            var resp = await ch.ExecuteMethod<WatermarkResponse>("smugmug.watermarks.create", basic, "ImageID", id, "Name", Name, "Dissolve", Dissolve, "Pinned", Pinned, "Thumbs", Thumbs, "Extras", Extras);
            if (resp.stat == "ok")
            {
                var myWatermark = resp.Watermark;
                if (myWatermark != null)
                {
                    myWatermark.basic = basic;
                    myWatermark.Name = Name;
                }
                return myWatermark;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Add a comment to an image
        /// </summary>
        /// <param name="Text">The text for the comment</param>
        /// <returns></returns>
        public async Task<Comment> AddCommentAsync(string Text)
        {
            return await AddCommentAsync(Text, 0, "");
        }

        /// <summary>
        /// Add a comment to an image
        /// </summary>
        /// <param name="Text">The text for the comment</param>
        /// <param name="Rating">The rating for this comment. Values:  0 - No Rating (Default), 1 - 1 Star Rating, 2 - 2 Star Rating, 3 - 3 Star Rating, 4 - 4 Star Rating, 5 - 5 Star Rating</param>
        /// <returns></returns>
        public async Task<Comment> AddCommentAsync(string Text, int Rating)
        {
            return await AddCommentAsync(Text, Rating, "");
        }

        /// <summary>
        /// Add a comment to an image
        /// </summary>
        /// <param name="Text">The text for the comment</param>
        /// <param name="Rating">The rating for this comment. Values:  0 - No Rating (Default), 1 - 1 Star Rating, 2 - 2 Star Rating, 3 - 3 Star Rating, 4 - 4 Star Rating, 5 - 5 Star Rating</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns></returns>
        public async Task<Comment> AddCommentAsync(string Text, int Rating, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageID [required], ImageKey [required], Text [required], Callback, Extras, Pretty, Rating, Strict
            var resp = await ch.ExecuteMethod<CommentResponse>("smugmug.images.comments.add", basic, "ImageID", id, "ImageKey", Key, "Text", Text, "Rating", Rating, "Extras", Extras);
            if (resp.stat == "ok")
            {
                var myComment = resp.Comment;
                if (myComment != null)
                {
                    if (string.IsNullOrEmpty(myComment.Text))
                        myComment.Text = Text;
                    if (myComment.Rating == 0)
                        myComment.Rating = Rating;
                    if (this.Comments == null)
                        this.Comments = new List<Comment>();
                    this.Comments.Add(myComment);
                }
                return myComment;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Retrieves a list of comments for an image
        /// </summary>
        public async Task GetCommentsAsync()
        {
            await GetCommentsAsync(false, 0, "");
        }

        /// <summary>
        /// Retrieves a list of comments for an image
        /// </summary>
        /// <param name="SitePassword">The site password for a specific user</param>
        public async Task GetCommentsAsync(string SitePassword)
        {
            await GetCommentsAsync(false, 0, SitePassword);
        }

        /// <summary>
        /// Retrieves a list of comments for an image
        /// </summary>
        /// <param name="Associative">Returns an associative array. Default: false</param>
        /// <param name="LastUpdated">Return results where LastUpdated is after the epoch time provided</param>
        /// <param name="SitePassword">The site password for a specific user</param>
        public async Task GetCommentsAsync(bool Associative, int LastUpdated, string SitePassword)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], ImageKey [required], Associative, Callback, LastUpdated, Password, Pretty, SitePassword, Strict
            ImageResponse resp = new ImageResponse();
            if ((Album != null) && (!String.IsNullOrEmpty(Album.Password)))
                resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.comments.get", basic, "ImageID", id, "ImageKey", Key, "SitePassword", SitePassword, "Password", Album.Password, "LastUpdated", LastUpdated, "Associative", Associative);
            else
                resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.comments.get", basic, "ImageID", id, "ImageKey", Key, "SitePassword", SitePassword, "LastUpdated", LastUpdated, "Associative", Associative);
            if (resp.stat == "ok")
            {
                if (this.Comments == null)
                    this.Comments = new List<Comment>();
                this.Comments = resp.Image.Comments;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Create a printmark (basic)
        /// </summary>
        /// <param name="Name">The name for the printmark</param>
        /// <returns>New printmark (id)</returns>
        public async Task<Printmark> CreatePrintmarkAsync(string Name)
        {
            return await CreatePrintmarkAsync(Name, 0, "BottomRight", "");
        }

        /// <summary>
        /// Create a printmark (basic+extras)
        /// </summary>
        /// <param name="Name">The name for the printmark</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns>New printmark (id)</returns>
        public async Task<Printmark> CreatePrintmarkAsync(string Name, string Extras)
        {
            return await CreatePrintmarkAsync(Name, 0, "BottomRight", Extras);
        }

        /// <summary>
        /// Create a printmark (all params)
        /// </summary>
        /// <param name="Name">The name for the printmark</param>
        /// <param name="Dissolve">The opacity of the printmark on the target image. Default: 0. Min: 0. Max: 100</param>
        /// <param name="Location">The location of the printmark on the target image. Values: TopLeft, TopRight, BottomLeft, BottomRight(default), Top, Bottom</param>
        /// <returns>New printmark (id)</returns>
        public async Task<Printmark> CreatePrintmarkAsync(string Name, int Dissolve, string Location)
        {
            return await CreatePrintmarkAsync(Name, Dissolve, Location, "");
        }

        /// <summary>
        /// Create a printmark (all params+extras)
        /// </summary>
        /// <param name="Name">The name for the printmark</param>
        /// <param name="Dissolve">The opacity of the printmark on the target image. Default: 0. Min: 0. Max: 100</param>
        /// <param name="Location">The location of the printmark on the target image. Values: TopLeft, TopRight, BottomLeft, BottomRight(default), Top, Bottom</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns>New printmark (id)</returns>
        public async Task<Printmark> CreatePrintmarkAsync(string Name, int Dissolve, string Location, string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], ImageId [required], Name [required], Callback, Dissolve, Extras, Pretty, Location, Strict
            var resp = await ch.ExecuteMethod<PrintmarkResponse>("smugmug.printmarks.create", basic, "ImageID", this.id, "Name", Name, "Dissolve", Dissolve, "Location", Location, "Extras", Extras);
            if (resp.stat == "ok")
            {
                var myPrintmark = resp.Printmark;
                if (myPrintmark != null)
                {
                    myPrintmark.basic = basic;
                    myPrintmark.Image = this;
                }
                return myPrintmark;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }
        /// <summary>
        /// Collect an image into an album
        /// </summary>
        /// <param name="a">Album into which to collect the image</param>
        /// <returns></returns>
        public async Task<Image> CollectIntoAlbumAsync()
        {
            return await CollectIntoAlbumAsync("");
        }

        /// <summary>
        /// Collect an image into an album
        /// </summary>
        /// <param name="a">Album into which to collect the image</param>
        /// <param name="Extras">A comma separated string of additional attributes to return in the response</param>
        /// <returns></returns>
        public async Task<Image> CollectIntoAlbumAsync(string Extras)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // SessionID [required], AlbumID [required], ImageID [required], ImageKey [required], Callback, Extras, Pretty, Strict
            var resp = await ch.ExecuteMethod<ImageResponse>("smugmug.images.collect", basic, "AlbumID", this.Album.id, "ImageID", this.id, "ImageKey", this.Key, "Extras", Extras);
            if (resp.stat == "ok")
            {
                var myImage = resp.Image;
                if (myImage != null)
                {
                    myImage.basic = basic;
                }
                return myImage;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }
        #endregion
    }
}
