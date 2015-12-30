// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ImageEntity : SmugMugEntity
    {
        private long _altitude;
        private string _archivedMD5;
        private long _archivedSize;
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
        private long _originalHeight;
        private long _originalSize;
        private long _originalWidth;
        private bool _processing;
        private bool _protected;
        private string _thumbnailUrl;
        private string _title;
        private string _uploadKey;
        private WatermarkEnum _watermark;
        private bool _watermarked;
        private string _webUri;


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


        public string ArchivedMD5 {
            get {
                return _archivedMD5;
            }
            set {
                if (_archivedMD5 != value)
                {
                    NotifyPropertyValueChanged("ArchivedMD5", oldValue:_archivedMD5, newValue: value);
                    _archivedMD5 = value;     
                }
            }
        }


        public long ArchivedSize {
            get {
                return _archivedSize;
            }
            set {
                if (_archivedSize != value)
                {
                    NotifyPropertyValueChanged("ArchivedSize", oldValue:_archivedSize, newValue: value);
                    _archivedSize = value;     
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
                    NotifyPropertyValueChanged("ArchivedUri", oldValue:_archivedUri, newValue: value);
                    _archivedUri = value;     
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
                    NotifyPropertyValueChanged("CanEdit", oldValue:_canEdit, newValue: value);
                    _canEdit = value;     
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


        public bool Collectable {
            get {
                return _collectable;
            }
            set {
                if (_collectable != value)
                {
                    NotifyPropertyValueChanged("Collectable", oldValue:_collectable, newValue: value);
                    _collectable = value;     
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
                    NotifyPropertyValueChanged("Date", oldValue:_date, newValue: value);
                    _date = value;     
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
                    NotifyPropertyValueChanged("EZProject", oldValue:_eZProject, newValue: value);
                    _eZProject = value;     
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
                    NotifyPropertyValueChanged("FileName", oldValue:_fileName, newValue: value);
                    _fileName = value;     
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
                    NotifyPropertyValueChanged("Format", oldValue:_format, newValue: value);
                    _format = value;     
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
                    NotifyPropertyValueChanged("FormattedValues", oldValue:_formattedValues, newValue: value);
                    _formattedValues = value;     
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
                    NotifyPropertyValueChanged("Hidden", oldValue:_hidden, newValue: value);
                    _hidden = value;     
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
                    NotifyPropertyValueChanged("ImageKey", oldValue:_imageKey, newValue: value);
                    _imageKey = value;     
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
                    NotifyPropertyValueChanged("IsArchive", oldValue:_isArchive, newValue: value);
                    _isArchive = value;     
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
                    NotifyPropertyValueChanged("IsVideo", oldValue:_isVideo, newValue: value);
                    _isVideo = value;     
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
                    NotifyPropertyValueChanged("KeywordArray", oldValue:_keywordArray, newValue: value);
                    _keywordArray = value;     
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


        public DateTime LastUpdated {
            get {
                return _lastUpdated;
            }
            set {
                if (_lastUpdated != value)
                {
                    NotifyPropertyValueChanged("LastUpdated", oldValue:_lastUpdated, newValue: value);
                    _lastUpdated = value;     
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
                    NotifyPropertyValueChanged("Latitude", oldValue:_latitude, newValue: value);
                    _latitude = value;     
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
                    NotifyPropertyValueChanged("Longitude", oldValue:_longitude, newValue: value);
                    _longitude = value;     
                }
            }
        }


        public long OriginalHeight {
            get {
                return _originalHeight;
            }
            set {
                if (_originalHeight != value)
                {
                    NotifyPropertyValueChanged("OriginalHeight", oldValue:_originalHeight, newValue: value);
                    _originalHeight = value;     
                }
            }
        }


        public long OriginalSize {
            get {
                return _originalSize;
            }
            set {
                if (_originalSize != value)
                {
                    NotifyPropertyValueChanged("OriginalSize", oldValue:_originalSize, newValue: value);
                    _originalSize = value;     
                }
            }
        }


        public long OriginalWidth {
            get {
                return _originalWidth;
            }
            set {
                if (_originalWidth != value)
                {
                    NotifyPropertyValueChanged("OriginalWidth", oldValue:_originalWidth, newValue: value);
                    _originalWidth = value;     
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
                    NotifyPropertyValueChanged("Processing", oldValue:_processing, newValue: value);
                    _processing = value;     
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
                    NotifyPropertyValueChanged("Protected", oldValue:_protected, newValue: value);
                    _protected = value;     
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
                    NotifyPropertyValueChanged("ThumbnailUrl", oldValue:_thumbnailUrl, newValue: value);
                    _thumbnailUrl = value;     
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


        public string UploadKey {
            get {
                return _uploadKey;
            }
            set {
                if (_uploadKey != value)
                {
                    NotifyPropertyValueChanged("UploadKey", oldValue:_uploadKey, newValue: value);
                    _uploadKey = value;     
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
                    NotifyPropertyValueChanged("Watermark", oldValue:_watermark, newValue: value);
                    _watermark = value;     
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
                    NotifyPropertyValueChanged("Watermarked", oldValue:_watermarked, newValue: value);
                    _watermarked = value;     
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
                    NotifyPropertyValueChanged("WebUri", oldValue:_webUri, newValue: value);
                    _webUri = value;     
                }
            }
        }
    }
}
