// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ImageEntity : SmugMugEntity
    {
        private int _altitude;
        private string _archivedMD5;
        private int _archivedSize;
        private string _archivedUri;
        private bool _canEdit;
        private string _caption;
        private bool _collectable;
        private DateTime _date;
        private bool _eZProject;
        private string _fileName;
        private string _format;
        private CaptionEntity _formattedValues;
        private bool _hidden;
        private string _imageKey;
        private bool _isArchive;
        private bool _isVideo;
        private string[] _keywordArray;
        private string _keywords;
        private DateTime _lastUpdated;
        private decimal _latitude;
        private decimal _longitude;
        private int _originalHeight;
        private int _originalSize;
        private int _originalWidth;
        private bool _processing;
        private bool _protected;
        private string _thumbnailUrl;
        private string _title;
        private string _uploadKey;
        private string _uri;
        private string _uriDescription;
        private WatermarkEnum _watermark;
        private bool _watermarked;
        private string _webUri;


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


        public string ArchivedMD5 {
            get {
                return _archivedMD5;
            }
            set {
                if (_archivedMD5 != value)
                {
                    _archivedMD5 = value;
                    NotifyPropertyValueChanged("ArchivedMD5", _archivedMD5);
                }
            }
        }


        public int ArchivedSize {
            get {
                return _archivedSize;
            }
            set {
                if (_archivedSize != value)
                {
                    _archivedSize = value;
                    NotifyPropertyValueChanged("ArchivedSize", _archivedSize);
                }
            }
        }


        public string ArchivedUri {
            get {
                return _archivedUri;
            }
            set {
                if (_archivedUri != value)
                {
                    _archivedUri = value;
                    NotifyPropertyValueChanged("ArchivedUri", _archivedUri);
                }
            }
        }


        public bool CanEdit {
            get {
                return _canEdit;
            }
            set {
                if (_canEdit != value)
                {
                    _canEdit = value;
                    NotifyPropertyValueChanged("CanEdit", _canEdit);
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


        public bool Collectable {
            get {
                return _collectable;
            }
            set {
                if (_collectable != value)
                {
                    _collectable = value;
                    NotifyPropertyValueChanged("Collectable", _collectable);
                }
            }
        }


        public DateTime Date {
            get {
                return _date;
            }
            set {
                if (_date != value)
                {
                    _date = value;
                    NotifyPropertyValueChanged("Date", _date);
                }
            }
        }


        public bool EZProject {
            get {
                return _eZProject;
            }
            set {
                if (_eZProject != value)
                {
                    _eZProject = value;
                    NotifyPropertyValueChanged("EZProject", _eZProject);
                }
            }
        }


        public string FileName {
            get {
                return _fileName;
            }
            set {
                if (_fileName != value)
                {
                    _fileName = value;
                    NotifyPropertyValueChanged("FileName", _fileName);
                }
            }
        }


        public string Format {
            get {
                return _format;
            }
            set {
                if (_format != value)
                {
                    _format = value;
                    NotifyPropertyValueChanged("Format", _format);
                }
            }
        }


        public CaptionEntity FormattedValues {
            get {
                return _formattedValues;
            }
            set {
                if (_formattedValues != value)
                {
                    _formattedValues = value;
                    NotifyPropertyValueChanged("FormattedValues", _formattedValues);
                }
            }
        }


        public bool Hidden {
            get {
                return _hidden;
            }
            set {
                if (_hidden != value)
                {
                    _hidden = value;
                    NotifyPropertyValueChanged("Hidden", _hidden);
                }
            }
        }


        public string ImageKey {
            get {
                return _imageKey;
            }
            set {
                if (_imageKey != value)
                {
                    _imageKey = value;
                    NotifyPropertyValueChanged("ImageKey", _imageKey);
                }
            }
        }


        public bool IsArchive {
            get {
                return _isArchive;
            }
            set {
                if (_isArchive != value)
                {
                    _isArchive = value;
                    NotifyPropertyValueChanged("IsArchive", _isArchive);
                }
            }
        }


        public bool IsVideo {
            get {
                return _isVideo;
            }
            set {
                if (_isVideo != value)
                {
                    _isVideo = value;
                    NotifyPropertyValueChanged("IsVideo", _isVideo);
                }
            }
        }


        public string[] KeywordArray {
            get {
                return _keywordArray;
            }
            set {
                if (_keywordArray != value)
                {
                    _keywordArray = value;
                    NotifyPropertyValueChanged("KeywordArray", _keywordArray);
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


        public DateTime LastUpdated {
            get {
                return _lastUpdated;
            }
            set {
                if (_lastUpdated != value)
                {
                    _lastUpdated = value;
                    NotifyPropertyValueChanged("LastUpdated", _lastUpdated);
                }
            }
        }


        public decimal Latitude {
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


        public decimal Longitude {
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


        public int OriginalHeight {
            get {
                return _originalHeight;
            }
            set {
                if (_originalHeight != value)
                {
                    _originalHeight = value;
                    NotifyPropertyValueChanged("OriginalHeight", _originalHeight);
                }
            }
        }


        public int OriginalSize {
            get {
                return _originalSize;
            }
            set {
                if (_originalSize != value)
                {
                    _originalSize = value;
                    NotifyPropertyValueChanged("OriginalSize", _originalSize);
                }
            }
        }


        public int OriginalWidth {
            get {
                return _originalWidth;
            }
            set {
                if (_originalWidth != value)
                {
                    _originalWidth = value;
                    NotifyPropertyValueChanged("OriginalWidth", _originalWidth);
                }
            }
        }


        public bool Processing {
            get {
                return _processing;
            }
            set {
                if (_processing != value)
                {
                    _processing = value;
                    NotifyPropertyValueChanged("Processing", _processing);
                }
            }
        }


        public bool Protected {
            get {
                return _protected;
            }
            set {
                if (_protected != value)
                {
                    _protected = value;
                    NotifyPropertyValueChanged("Protected", _protected);
                }
            }
        }


        public string ThumbnailUrl {
            get {
                return _thumbnailUrl;
            }
            set {
                if (_thumbnailUrl != value)
                {
                    _thumbnailUrl = value;
                    NotifyPropertyValueChanged("ThumbnailUrl", _thumbnailUrl);
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


        public string UploadKey {
            get {
                return _uploadKey;
            }
            set {
                if (_uploadKey != value)
                {
                    _uploadKey = value;
                    NotifyPropertyValueChanged("UploadKey", _uploadKey);
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


        public WatermarkEnum Watermark {
            get {
                return _watermark;
            }
            set {
                if (_watermark != value)
                {
                    _watermark = value;
                    NotifyPropertyValueChanged("Watermark", _watermark);
                }
            }
        }


        public bool Watermarked {
            get {
                return _watermarked;
            }
            set {
                if (_watermarked != value)
                {
                    _watermarked = value;
                    NotifyPropertyValueChanged("Watermarked", _watermarked);
                }
            }
        }


        public string WebUri {
            get {
                return _webUri;
            }
            set {
                if (_webUri != value)
                {
                    _webUri = value;
                    NotifyPropertyValueChanged("WebUri", _webUri);
                }
            }
        }
    }
}
