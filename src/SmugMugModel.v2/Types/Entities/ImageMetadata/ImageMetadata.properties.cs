// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ImageMetadataEntity : SmugMugEntity
    {
        private int _altitude;
        private string _altitudeReference;
        private string _aperture;
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
        private string _iSO;
        private string _keywords;
        private int _latitude;
        private string _latitudeReference;
        private string _lens;
        private string _lensSerialNumber;
        private string _lightSource;
        private int _longitude;
        private string _longitudeReference;
        private string _make;
        private string _metering;
        private DateTime _microDateTimeCreated;
        private DateTime _microDateTimeDigitized;
        private string _model;
        private string _normalizedLightValue;
        private string _rating;
        private string _saturation;
        private string _scaleFactor;
        private string _sceneCaptureType;
        private string _sensingMethod;
        private string _serialNumber;
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
        private string _uri;
        private string _uriDescription;
        private string _userComment;
        private string _videoCodec;
        private string _whiteBalance;
        private string _writerEditor;


        public int Altitude {
            get {
                return _altitude;
            }
            set {
                if (_altitude != value)
                {
                    _altitude = value;
                    NotifyPropertyValueChanged("Altitude", _altitude);
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
                    _altitudeReference = value;
                    NotifyPropertyValueChanged("AltitudeReference", _altitudeReference);
                }
            }
        }


        public string Aperture {
            get {
                return _aperture;
            }
            set {
                if (_aperture != value)
                {
                    _aperture = value;
                    NotifyPropertyValueChanged("Aperture", _aperture);
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
                    _audioCodec = value;
                    NotifyPropertyValueChanged("AudioCodec", _audioCodec);
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
                    _author = value;
                    NotifyPropertyValueChanged("Author", _author);
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
                    _authorTitle = value;
                    NotifyPropertyValueChanged("AuthorTitle", _authorTitle);
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
                    _brightness = value;
                    NotifyPropertyValueChanged("Brightness", _brightness);
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
                    _caption = value;
                    NotifyPropertyValueChanged("Caption", _caption);
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
                    _category = value;
                    NotifyPropertyValueChanged("Category", _category);
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
                    _circleOfConfusion = value;
                    NotifyPropertyValueChanged("CircleOfConfusion", _circleOfConfusion);
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
                    _city = value;
                    NotifyPropertyValueChanged("City", _city);
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
                    _colorSpace = value;
                    NotifyPropertyValueChanged("ColorSpace", _colorSpace);
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
                    _compressedBitsPerPixel = value;
                    NotifyPropertyValueChanged("CompressedBitsPerPixel", _compressedBitsPerPixel);
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
                    _contrast = value;
                    NotifyPropertyValueChanged("Contrast", _contrast);
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
                    _copyright = value;
                    NotifyPropertyValueChanged("Copyright", _copyright);
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
                    _copyrightFlag = value;
                    NotifyPropertyValueChanged("CopyrightFlag", _copyrightFlag);
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
                    _copyrightUrl = value;
                    NotifyPropertyValueChanged("CopyrightUrl", _copyrightUrl);
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
                    _country = value;
                    NotifyPropertyValueChanged("Country", _country);
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
                    _countryCode = value;
                    NotifyPropertyValueChanged("CountryCode", _countryCode);
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
                    _creatorContactInfo = value;
                    NotifyPropertyValueChanged("CreatorContactInfo", _creatorContactInfo);
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
                    _credit = value;
                    NotifyPropertyValueChanged("Credit", _credit);
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
                    _dateCreated = value;
                    NotifyPropertyValueChanged("DateCreated", _dateCreated);
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
                    _dateDigitized = value;
                    NotifyPropertyValueChanged("DateDigitized", _dateDigitized);
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
                    _dateOriginal = value;
                    NotifyPropertyValueChanged("DateOriginal", _dateOriginal);
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
                    _dateTimeCreated = value;
                    NotifyPropertyValueChanged("DateTimeCreated", _dateTimeCreated);
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
                    _dateTimeModified = value;
                    NotifyPropertyValueChanged("DateTimeModified", _dateTimeModified);
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
                    _dateTimeOriginal = value;
                    NotifyPropertyValueChanged("DateTimeOriginal", _dateTimeOriginal);
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
                    _depthOfField = value;
                    NotifyPropertyValueChanged("DepthOfField", _depthOfField);
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
                    _digitalZoomRatio = value;
                    NotifyPropertyValueChanged("DigitalZoomRatio", _digitalZoomRatio);
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
                    _duration = value;
                    NotifyPropertyValueChanged("Duration", _duration);
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
                    _exposure = value;
                    NotifyPropertyValueChanged("Exposure", _exposure);
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
                    _exposureCompensation = value;
                    NotifyPropertyValueChanged("ExposureCompensation", _exposureCompensation);
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
                    _exposureMode = value;
                    NotifyPropertyValueChanged("ExposureMode", _exposureMode);
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
                    _exposureProgram = value;
                    NotifyPropertyValueChanged("ExposureProgram", _exposureProgram);
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
                    _fieldOfView = value;
                    NotifyPropertyValueChanged("FieldOfView", _fieldOfView);
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
                    _flash = value;
                    NotifyPropertyValueChanged("Flash", _flash);
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
                    _focalLength = value;
                    NotifyPropertyValueChanged("FocalLength", _focalLength);
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
                    _focalLength35mm = value;
                    NotifyPropertyValueChanged("FocalLength35mm", _focalLength35mm);
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
                    _gainControl = value;
                    NotifyPropertyValueChanged("GainControl", _gainControl);
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
                    _headline = value;
                    NotifyPropertyValueChanged("Headline", _headline);
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
                    _hyperfocalDistance = value;
                    NotifyPropertyValueChanged("HyperfocalDistance", _hyperfocalDistance);
                }
            }
        }


        public string ISO {
            get {
                return _iSO;
            }
            set {
                if (_iSO != value)
                {
                    _iSO = value;
                    NotifyPropertyValueChanged("ISO", _iSO);
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
                    _keywords = value;
                    NotifyPropertyValueChanged("Keywords", _keywords);
                }
            }
        }


        public int Latitude {
            get {
                return _latitude;
            }
            set {
                if (_latitude != value)
                {
                    _latitude = value;
                    NotifyPropertyValueChanged("Latitude", _latitude);
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
                    _latitudeReference = value;
                    NotifyPropertyValueChanged("LatitudeReference", _latitudeReference);
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
                    _lens = value;
                    NotifyPropertyValueChanged("Lens", _lens);
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
                    _lensSerialNumber = value;
                    NotifyPropertyValueChanged("LensSerialNumber", _lensSerialNumber);
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
                    _lightSource = value;
                    NotifyPropertyValueChanged("LightSource", _lightSource);
                }
            }
        }


        public int Longitude {
            get {
                return _longitude;
            }
            set {
                if (_longitude != value)
                {
                    _longitude = value;
                    NotifyPropertyValueChanged("Longitude", _longitude);
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
                    _longitudeReference = value;
                    NotifyPropertyValueChanged("LongitudeReference", _longitudeReference);
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
                    _make = value;
                    NotifyPropertyValueChanged("Make", _make);
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
                    _metering = value;
                    NotifyPropertyValueChanged("Metering", _metering);
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
                    _microDateTimeCreated = value;
                    NotifyPropertyValueChanged("MicroDateTimeCreated", _microDateTimeCreated);
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
                    _microDateTimeDigitized = value;
                    NotifyPropertyValueChanged("MicroDateTimeDigitized", _microDateTimeDigitized);
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
                    _model = value;
                    NotifyPropertyValueChanged("Model", _model);
                }
            }
        }


        public string NormalizedLightValue {
            get {
                return _normalizedLightValue;
            }
            set {
                if (_normalizedLightValue != value)
                {
                    _normalizedLightValue = value;
                    NotifyPropertyValueChanged("NormalizedLightValue", _normalizedLightValue);
                }
            }
        }


        public string Rating {
            get {
                return _rating;
            }
            set {
                if (_rating != value)
                {
                    _rating = value;
                    NotifyPropertyValueChanged("Rating", _rating);
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
                    _saturation = value;
                    NotifyPropertyValueChanged("Saturation", _saturation);
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
                    _scaleFactor = value;
                    NotifyPropertyValueChanged("ScaleFactor", _scaleFactor);
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
                    _sceneCaptureType = value;
                    NotifyPropertyValueChanged("SceneCaptureType", _sceneCaptureType);
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
                    _sensingMethod = value;
                    NotifyPropertyValueChanged("SensingMethod", _sensingMethod);
                }
            }
        }


        public string SerialNumber {
            get {
                return _serialNumber;
            }
            set {
                if (_serialNumber != value)
                {
                    _serialNumber = value;
                    NotifyPropertyValueChanged("SerialNumber", _serialNumber);
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
                    _sharpness = value;
                    NotifyPropertyValueChanged("Sharpness", _sharpness);
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
                    _software = value;
                    NotifyPropertyValueChanged("Software", _software);
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
                    _source = value;
                    NotifyPropertyValueChanged("Source", _source);
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
                    _specialInstructions = value;
                    NotifyPropertyValueChanged("SpecialInstructions", _specialInstructions);
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
                    _state = value;
                    NotifyPropertyValueChanged("State", _state);
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
                    _subjectDistance = value;
                    NotifyPropertyValueChanged("SubjectDistance", _subjectDistance);
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
                    _subjectRange = value;
                    NotifyPropertyValueChanged("SubjectRange", _subjectRange);
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
                    _supplementalCategories = value;
                    NotifyPropertyValueChanged("SupplementalCategories", _supplementalCategories);
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
                    _timeCreated = value;
                    NotifyPropertyValueChanged("TimeCreated", _timeCreated);
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
                    _timeOriginal = value;
                    NotifyPropertyValueChanged("TimeOriginal", _timeOriginal);
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
                    _title = value;
                    NotifyPropertyValueChanged("Title", _title);
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
                    _transmissionReference = value;
                    NotifyPropertyValueChanged("TransmissionReference", _transmissionReference);
                }
            }
        }


        public string Uri {
            get {
                return _uri;
            }
            set {
                if (_uri != value)
                {
                    _uri = value;
                    NotifyPropertyValueChanged("Uri", _uri);
                }
            }
        }


        public string UriDescription {
            get {
                return _uriDescription;
            }
            set {
                if (_uriDescription != value)
                {
                    _uriDescription = value;
                    NotifyPropertyValueChanged("UriDescription", _uriDescription);
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
                    _userComment = value;
                    NotifyPropertyValueChanged("UserComment", _userComment);
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
                    _videoCodec = value;
                    NotifyPropertyValueChanged("VideoCodec", _videoCodec);
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
                    _whiteBalance = value;
                    NotifyPropertyValueChanged("WhiteBalance", _whiteBalance);
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
                    _writerEditor = value;
                    NotifyPropertyValueChanged("WriterEditor", _writerEditor);
                }
            }
        }
    }
}
