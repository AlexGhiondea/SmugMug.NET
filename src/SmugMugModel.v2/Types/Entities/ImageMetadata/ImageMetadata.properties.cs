// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ImageMetadataEntity : SmugMugEntity
    {
        private long _altitude;
        private string _altitudeReference;
        private float _aperture;
        private string _audioCodec;
        private string _author;
        private string _authorTitle;
        private string _brightness;
        private string _caption;
        private string _category;
        private string _circleOfConfusion;
        private string _city;
        private string _colorSpace;
        private string _compressedBitsPerPixel;
        private string _contrast;
        private string _copyright;
        private string _copyrightFlag;
        private string _copyrightUrl;
        private string _country;
        private string _countryCode;
        private string _creatorContactInfo;
        private string _credit;
        private DateTime _dateCreated;
        private DateTime _dateDigitized;
        private DateTime _dateOriginal;
        private DateTime _dateTimeCreated;
        private DateTime _dateTimeModified;
        private DateTime _dateTimeOriginal;
        private string _depthOfField;
        private string _digitalZoomRatio;
        private string _duration;
        private string _exposure;
        private string _exposureCompensation;
        private string _exposureMode;
        private string _exposureProgram;
        private string _fieldOfView;
        private string _flash;
        private string _focalLength;
        private string _focalLength35mm;
        private string _gainControl;
        private string _headline;
        private string _hyperfocalDistance;
        private long _iSO;
        private string _keywords;
        private long _latitude;
        private string _latitudeReference;
        private string _lens;
        private string _lensSerialNumber;
        private string _lightSource;
        private long _longitude;
        private string _longitudeReference;
        private string _make;
        private string _metering;
        private DateTime _microDateTimeCreated;
        private DateTime _microDateTimeDigitized;
        private string _model;
        private float _normalizedLightValue;
        private long _rating;
        private string _saturation;
        private string _scaleFactor;
        private string _sceneCaptureType;
        private string _sensingMethod;
        private long _serialNumber;
        private string _sharpness;
        private string _software;
        private string _source;
        private string _specialInstructions;
        private string _state;
        private string _subjectDistance;
        private string _subjectRange;
        private string _supplementalCategories;
        private DateTime _timeCreated;
        private DateTime _timeOriginal;
        private string _title;
        private string _transmissionReference;
        private string _userComment;
        private string _videoCodec;
        private string _whiteBalance;
        private string _writerEditor;


        public long Altitude {
            get {
                return _altitude;
            }
            set {
                if (_altitude != value)
                {
                    NotifyPropertyValueChanged("Altitude", oldValue:_altitude, newValue: value);
                    _altitude = value;     
                }
            }
        }


        public string AltitudeReference {
            get {
                return _altitudeReference;
            }
            set {
                if (_altitudeReference != value)
                {
                    NotifyPropertyValueChanged("AltitudeReference", oldValue:_altitudeReference, newValue: value);
                    _altitudeReference = value;     
                }
            }
        }


        public float Aperture {
            get {
                return _aperture;
            }
            set {
                if (_aperture != value)
                {
                    NotifyPropertyValueChanged("Aperture", oldValue:_aperture, newValue: value);
                    _aperture = value;     
                }
            }
        }


        public string AudioCodec {
            get {
                return _audioCodec;
            }
            set {
                if (_audioCodec != value)
                {
                    NotifyPropertyValueChanged("AudioCodec", oldValue:_audioCodec, newValue: value);
                    _audioCodec = value;     
                }
            }
        }


        public string Author {
            get {
                return _author;
            }
            set {
                if (_author != value)
                {
                    NotifyPropertyValueChanged("Author", oldValue:_author, newValue: value);
                    _author = value;     
                }
            }
        }


        public string AuthorTitle {
            get {
                return _authorTitle;
            }
            set {
                if (_authorTitle != value)
                {
                    NotifyPropertyValueChanged("AuthorTitle", oldValue:_authorTitle, newValue: value);
                    _authorTitle = value;     
                }
            }
        }


        public string Brightness {
            get {
                return _brightness;
            }
            set {
                if (_brightness != value)
                {
                    NotifyPropertyValueChanged("Brightness", oldValue:_brightness, newValue: value);
                    _brightness = value;     
                }
            }
        }


        public string Caption {
            get {
                return _caption;
            }
            set {
                if (_caption != value)
                {
                    NotifyPropertyValueChanged("Caption", oldValue:_caption, newValue: value);
                    _caption = value;     
                }
            }
        }


        public string Category {
            get {
                return _category;
            }
            set {
                if (_category != value)
                {
                    NotifyPropertyValueChanged("Category", oldValue:_category, newValue: value);
                    _category = value;     
                }
            }
        }


        public string CircleOfConfusion {
            get {
                return _circleOfConfusion;
            }
            set {
                if (_circleOfConfusion != value)
                {
                    NotifyPropertyValueChanged("CircleOfConfusion", oldValue:_circleOfConfusion, newValue: value);
                    _circleOfConfusion = value;     
                }
            }
        }


        public string City {
            get {
                return _city;
            }
            set {
                if (_city != value)
                {
                    NotifyPropertyValueChanged("City", oldValue:_city, newValue: value);
                    _city = value;     
                }
            }
        }


        public string ColorSpace {
            get {
                return _colorSpace;
            }
            set {
                if (_colorSpace != value)
                {
                    NotifyPropertyValueChanged("ColorSpace", oldValue:_colorSpace, newValue: value);
                    _colorSpace = value;     
                }
            }
        }


        public string CompressedBitsPerPixel {
            get {
                return _compressedBitsPerPixel;
            }
            set {
                if (_compressedBitsPerPixel != value)
                {
                    NotifyPropertyValueChanged("CompressedBitsPerPixel", oldValue:_compressedBitsPerPixel, newValue: value);
                    _compressedBitsPerPixel = value;     
                }
            }
        }


        public string Contrast {
            get {
                return _contrast;
            }
            set {
                if (_contrast != value)
                {
                    NotifyPropertyValueChanged("Contrast", oldValue:_contrast, newValue: value);
                    _contrast = value;     
                }
            }
        }


        public string Copyright {
            get {
                return _copyright;
            }
            set {
                if (_copyright != value)
                {
                    NotifyPropertyValueChanged("Copyright", oldValue:_copyright, newValue: value);
                    _copyright = value;     
                }
            }
        }


        public string CopyrightFlag {
            get {
                return _copyrightFlag;
            }
            set {
                if (_copyrightFlag != value)
                {
                    NotifyPropertyValueChanged("CopyrightFlag", oldValue:_copyrightFlag, newValue: value);
                    _copyrightFlag = value;     
                }
            }
        }


        public string CopyrightUrl {
            get {
                return _copyrightUrl;
            }
            set {
                if (_copyrightUrl != value)
                {
                    NotifyPropertyValueChanged("CopyrightUrl", oldValue:_copyrightUrl, newValue: value);
                    _copyrightUrl = value;     
                }
            }
        }


        public string Country {
            get {
                return _country;
            }
            set {
                if (_country != value)
                {
                    NotifyPropertyValueChanged("Country", oldValue:_country, newValue: value);
                    _country = value;     
                }
            }
        }


        public string CountryCode {
            get {
                return _countryCode;
            }
            set {
                if (_countryCode != value)
                {
                    NotifyPropertyValueChanged("CountryCode", oldValue:_countryCode, newValue: value);
                    _countryCode = value;     
                }
            }
        }


        public string CreatorContactInfo {
            get {
                return _creatorContactInfo;
            }
            set {
                if (_creatorContactInfo != value)
                {
                    NotifyPropertyValueChanged("CreatorContactInfo", oldValue:_creatorContactInfo, newValue: value);
                    _creatorContactInfo = value;     
                }
            }
        }


        public string Credit {
            get {
                return _credit;
            }
            set {
                if (_credit != value)
                {
                    NotifyPropertyValueChanged("Credit", oldValue:_credit, newValue: value);
                    _credit = value;     
                }
            }
        }


        public DateTime DateCreated {
            get {
                return _dateCreated;
            }
            set {
                if (_dateCreated != value)
                {
                    NotifyPropertyValueChanged("DateCreated", oldValue:_dateCreated, newValue: value);
                    _dateCreated = value;     
                }
            }
        }


        public DateTime DateDigitized {
            get {
                return _dateDigitized;
            }
            set {
                if (_dateDigitized != value)
                {
                    NotifyPropertyValueChanged("DateDigitized", oldValue:_dateDigitized, newValue: value);
                    _dateDigitized = value;     
                }
            }
        }


        public DateTime DateOriginal {
            get {
                return _dateOriginal;
            }
            set {
                if (_dateOriginal != value)
                {
                    NotifyPropertyValueChanged("DateOriginal", oldValue:_dateOriginal, newValue: value);
                    _dateOriginal = value;     
                }
            }
        }


        public DateTime DateTimeCreated {
            get {
                return _dateTimeCreated;
            }
            set {
                if (_dateTimeCreated != value)
                {
                    NotifyPropertyValueChanged("DateTimeCreated", oldValue:_dateTimeCreated, newValue: value);
                    _dateTimeCreated = value;     
                }
            }
        }


        public DateTime DateTimeModified {
            get {
                return _dateTimeModified;
            }
            set {
                if (_dateTimeModified != value)
                {
                    NotifyPropertyValueChanged("DateTimeModified", oldValue:_dateTimeModified, newValue: value);
                    _dateTimeModified = value;     
                }
            }
        }


        public DateTime DateTimeOriginal {
            get {
                return _dateTimeOriginal;
            }
            set {
                if (_dateTimeOriginal != value)
                {
                    NotifyPropertyValueChanged("DateTimeOriginal", oldValue:_dateTimeOriginal, newValue: value);
                    _dateTimeOriginal = value;     
                }
            }
        }


        public string DepthOfField {
            get {
                return _depthOfField;
            }
            set {
                if (_depthOfField != value)
                {
                    NotifyPropertyValueChanged("DepthOfField", oldValue:_depthOfField, newValue: value);
                    _depthOfField = value;     
                }
            }
        }


        public string DigitalZoomRatio {
            get {
                return _digitalZoomRatio;
            }
            set {
                if (_digitalZoomRatio != value)
                {
                    NotifyPropertyValueChanged("DigitalZoomRatio", oldValue:_digitalZoomRatio, newValue: value);
                    _digitalZoomRatio = value;     
                }
            }
        }


        public string Duration {
            get {
                return _duration;
            }
            set {
                if (_duration != value)
                {
                    NotifyPropertyValueChanged("Duration", oldValue:_duration, newValue: value);
                    _duration = value;     
                }
            }
        }


        public string Exposure {
            get {
                return _exposure;
            }
            set {
                if (_exposure != value)
                {
                    NotifyPropertyValueChanged("Exposure", oldValue:_exposure, newValue: value);
                    _exposure = value;     
                }
            }
        }


        public string ExposureCompensation {
            get {
                return _exposureCompensation;
            }
            set {
                if (_exposureCompensation != value)
                {
                    NotifyPropertyValueChanged("ExposureCompensation", oldValue:_exposureCompensation, newValue: value);
                    _exposureCompensation = value;     
                }
            }
        }


        public string ExposureMode {
            get {
                return _exposureMode;
            }
            set {
                if (_exposureMode != value)
                {
                    NotifyPropertyValueChanged("ExposureMode", oldValue:_exposureMode, newValue: value);
                    _exposureMode = value;     
                }
            }
        }


        public string ExposureProgram {
            get {
                return _exposureProgram;
            }
            set {
                if (_exposureProgram != value)
                {
                    NotifyPropertyValueChanged("ExposureProgram", oldValue:_exposureProgram, newValue: value);
                    _exposureProgram = value;     
                }
            }
        }


        public string FieldOfView {
            get {
                return _fieldOfView;
            }
            set {
                if (_fieldOfView != value)
                {
                    NotifyPropertyValueChanged("FieldOfView", oldValue:_fieldOfView, newValue: value);
                    _fieldOfView = value;     
                }
            }
        }


        public string Flash {
            get {
                return _flash;
            }
            set {
                if (_flash != value)
                {
                    NotifyPropertyValueChanged("Flash", oldValue:_flash, newValue: value);
                    _flash = value;     
                }
            }
        }


        public string FocalLength {
            get {
                return _focalLength;
            }
            set {
                if (_focalLength != value)
                {
                    NotifyPropertyValueChanged("FocalLength", oldValue:_focalLength, newValue: value);
                    _focalLength = value;     
                }
            }
        }


        public string FocalLength35mm {
            get {
                return _focalLength35mm;
            }
            set {
                if (_focalLength35mm != value)
                {
                    NotifyPropertyValueChanged("FocalLength35mm", oldValue:_focalLength35mm, newValue: value);
                    _focalLength35mm = value;     
                }
            }
        }


        public string GainControl {
            get {
                return _gainControl;
            }
            set {
                if (_gainControl != value)
                {
                    NotifyPropertyValueChanged("GainControl", oldValue:_gainControl, newValue: value);
                    _gainControl = value;     
                }
            }
        }


        public string Headline {
            get {
                return _headline;
            }
            set {
                if (_headline != value)
                {
                    NotifyPropertyValueChanged("Headline", oldValue:_headline, newValue: value);
                    _headline = value;     
                }
            }
        }


        public string HyperfocalDistance {
            get {
                return _hyperfocalDistance;
            }
            set {
                if (_hyperfocalDistance != value)
                {
                    NotifyPropertyValueChanged("HyperfocalDistance", oldValue:_hyperfocalDistance, newValue: value);
                    _hyperfocalDistance = value;     
                }
            }
        }


        public long ISO {
            get {
                return _iSO;
            }
            set {
                if (_iSO != value)
                {
                    NotifyPropertyValueChanged("ISO", oldValue:_iSO, newValue: value);
                    _iSO = value;     
                }
            }
        }


        public string Keywords {
            get {
                return _keywords;
            }
            set {
                if (_keywords != value)
                {
                    NotifyPropertyValueChanged("Keywords", oldValue:_keywords, newValue: value);
                    _keywords = value;     
                }
            }
        }


        public long Latitude {
            get {
                return _latitude;
            }
            set {
                if (_latitude != value)
                {
                    NotifyPropertyValueChanged("Latitude", oldValue:_latitude, newValue: value);
                    _latitude = value;     
                }
            }
        }


        public string LatitudeReference {
            get {
                return _latitudeReference;
            }
            set {
                if (_latitudeReference != value)
                {
                    NotifyPropertyValueChanged("LatitudeReference", oldValue:_latitudeReference, newValue: value);
                    _latitudeReference = value;     
                }
            }
        }


        public string Lens {
            get {
                return _lens;
            }
            set {
                if (_lens != value)
                {
                    NotifyPropertyValueChanged("Lens", oldValue:_lens, newValue: value);
                    _lens = value;     
                }
            }
        }


        public string LensSerialNumber {
            get {
                return _lensSerialNumber;
            }
            set {
                if (_lensSerialNumber != value)
                {
                    NotifyPropertyValueChanged("LensSerialNumber", oldValue:_lensSerialNumber, newValue: value);
                    _lensSerialNumber = value;     
                }
            }
        }


        public string LightSource {
            get {
                return _lightSource;
            }
            set {
                if (_lightSource != value)
                {
                    NotifyPropertyValueChanged("LightSource", oldValue:_lightSource, newValue: value);
                    _lightSource = value;     
                }
            }
        }


        public long Longitude {
            get {
                return _longitude;
            }
            set {
                if (_longitude != value)
                {
                    NotifyPropertyValueChanged("Longitude", oldValue:_longitude, newValue: value);
                    _longitude = value;     
                }
            }
        }


        public string LongitudeReference {
            get {
                return _longitudeReference;
            }
            set {
                if (_longitudeReference != value)
                {
                    NotifyPropertyValueChanged("LongitudeReference", oldValue:_longitudeReference, newValue: value);
                    _longitudeReference = value;     
                }
            }
        }


        public string Make {
            get {
                return _make;
            }
            set {
                if (_make != value)
                {
                    NotifyPropertyValueChanged("Make", oldValue:_make, newValue: value);
                    _make = value;     
                }
            }
        }


        public string Metering {
            get {
                return _metering;
            }
            set {
                if (_metering != value)
                {
                    NotifyPropertyValueChanged("Metering", oldValue:_metering, newValue: value);
                    _metering = value;     
                }
            }
        }


        public DateTime MicroDateTimeCreated {
            get {
                return _microDateTimeCreated;
            }
            set {
                if (_microDateTimeCreated != value)
                {
                    NotifyPropertyValueChanged("MicroDateTimeCreated", oldValue:_microDateTimeCreated, newValue: value);
                    _microDateTimeCreated = value;     
                }
            }
        }


        public DateTime MicroDateTimeDigitized {
            get {
                return _microDateTimeDigitized;
            }
            set {
                if (_microDateTimeDigitized != value)
                {
                    NotifyPropertyValueChanged("MicroDateTimeDigitized", oldValue:_microDateTimeDigitized, newValue: value);
                    _microDateTimeDigitized = value;     
                }
            }
        }


        public string Model {
            get {
                return _model;
            }
            set {
                if (_model != value)
                {
                    NotifyPropertyValueChanged("Model", oldValue:_model, newValue: value);
                    _model = value;     
                }
            }
        }


        public float NormalizedLightValue {
            get {
                return _normalizedLightValue;
            }
            set {
                if (_normalizedLightValue != value)
                {
                    NotifyPropertyValueChanged("NormalizedLightValue", oldValue:_normalizedLightValue, newValue: value);
                    _normalizedLightValue = value;     
                }
            }
        }


        public long Rating {
            get {
                return _rating;
            }
            set {
                if (_rating != value)
                {
                    NotifyPropertyValueChanged("Rating", oldValue:_rating, newValue: value);
                    _rating = value;     
                }
            }
        }


        public string Saturation {
            get {
                return _saturation;
            }
            set {
                if (_saturation != value)
                {
                    NotifyPropertyValueChanged("Saturation", oldValue:_saturation, newValue: value);
                    _saturation = value;     
                }
            }
        }


        public string ScaleFactor {
            get {
                return _scaleFactor;
            }
            set {
                if (_scaleFactor != value)
                {
                    NotifyPropertyValueChanged("ScaleFactor", oldValue:_scaleFactor, newValue: value);
                    _scaleFactor = value;     
                }
            }
        }


        public string SceneCaptureType {
            get {
                return _sceneCaptureType;
            }
            set {
                if (_sceneCaptureType != value)
                {
                    NotifyPropertyValueChanged("SceneCaptureType", oldValue:_sceneCaptureType, newValue: value);
                    _sceneCaptureType = value;     
                }
            }
        }


        public string SensingMethod {
            get {
                return _sensingMethod;
            }
            set {
                if (_sensingMethod != value)
                {
                    NotifyPropertyValueChanged("SensingMethod", oldValue:_sensingMethod, newValue: value);
                    _sensingMethod = value;     
                }
            }
        }


        public long SerialNumber {
            get {
                return _serialNumber;
            }
            set {
                if (_serialNumber != value)
                {
                    NotifyPropertyValueChanged("SerialNumber", oldValue:_serialNumber, newValue: value);
                    _serialNumber = value;     
                }
            }
        }


        public string Sharpness {
            get {
                return _sharpness;
            }
            set {
                if (_sharpness != value)
                {
                    NotifyPropertyValueChanged("Sharpness", oldValue:_sharpness, newValue: value);
                    _sharpness = value;     
                }
            }
        }


        public string Software {
            get {
                return _software;
            }
            set {
                if (_software != value)
                {
                    NotifyPropertyValueChanged("Software", oldValue:_software, newValue: value);
                    _software = value;     
                }
            }
        }


        public string Source {
            get {
                return _source;
            }
            set {
                if (_source != value)
                {
                    NotifyPropertyValueChanged("Source", oldValue:_source, newValue: value);
                    _source = value;     
                }
            }
        }


        public string SpecialInstructions {
            get {
                return _specialInstructions;
            }
            set {
                if (_specialInstructions != value)
                {
                    NotifyPropertyValueChanged("SpecialInstructions", oldValue:_specialInstructions, newValue: value);
                    _specialInstructions = value;     
                }
            }
        }


        public string State {
            get {
                return _state;
            }
            set {
                if (_state != value)
                {
                    NotifyPropertyValueChanged("State", oldValue:_state, newValue: value);
                    _state = value;     
                }
            }
        }


        public string SubjectDistance {
            get {
                return _subjectDistance;
            }
            set {
                if (_subjectDistance != value)
                {
                    NotifyPropertyValueChanged("SubjectDistance", oldValue:_subjectDistance, newValue: value);
                    _subjectDistance = value;     
                }
            }
        }


        public string SubjectRange {
            get {
                return _subjectRange;
            }
            set {
                if (_subjectRange != value)
                {
                    NotifyPropertyValueChanged("SubjectRange", oldValue:_subjectRange, newValue: value);
                    _subjectRange = value;     
                }
            }
        }


        public string SupplementalCategories {
            get {
                return _supplementalCategories;
            }
            set {
                if (_supplementalCategories != value)
                {
                    NotifyPropertyValueChanged("SupplementalCategories", oldValue:_supplementalCategories, newValue: value);
                    _supplementalCategories = value;     
                }
            }
        }


        public DateTime TimeCreated {
            get {
                return _timeCreated;
            }
            set {
                if (_timeCreated != value)
                {
                    NotifyPropertyValueChanged("TimeCreated", oldValue:_timeCreated, newValue: value);
                    _timeCreated = value;     
                }
            }
        }


        public DateTime TimeOriginal {
            get {
                return _timeOriginal;
            }
            set {
                if (_timeOriginal != value)
                {
                    NotifyPropertyValueChanged("TimeOriginal", oldValue:_timeOriginal, newValue: value);
                    _timeOriginal = value;     
                }
            }
        }


        public string Title {
            get {
                return _title;
            }
            set {
                if (_title != value)
                {
                    NotifyPropertyValueChanged("Title", oldValue:_title, newValue: value);
                    _title = value;     
                }
            }
        }


        public string TransmissionReference {
            get {
                return _transmissionReference;
            }
            set {
                if (_transmissionReference != value)
                {
                    NotifyPropertyValueChanged("TransmissionReference", oldValue:_transmissionReference, newValue: value);
                    _transmissionReference = value;     
                }
            }
        }

        public string UserComment {
            get {
                return _userComment;
            }
            set {
                if (_userComment != value)
                {
                    NotifyPropertyValueChanged("UserComment", oldValue:_userComment, newValue: value);
                    _userComment = value;     
                }
            }
        }


        public string VideoCodec {
            get {
                return _videoCodec;
            }
            set {
                if (_videoCodec != value)
                {
                    NotifyPropertyValueChanged("VideoCodec", oldValue:_videoCodec, newValue: value);
                    _videoCodec = value;     
                }
            }
        }


        public string WhiteBalance {
            get {
                return _whiteBalance;
            }
            set {
                if (_whiteBalance != value)
                {
                    NotifyPropertyValueChanged("WhiteBalance", oldValue:_whiteBalance, newValue: value);
                    _whiteBalance = value;     
                }
            }
        }


        public string WriterEditor {
            get {
                return _writerEditor;
            }
            set {
                if (_writerEditor != value)
                {
                    NotifyPropertyValueChanged("WriterEditor", oldValue:_writerEditor, newValue: value);
                    _writerEditor = value;     
                }
            }
        }
    }
}
