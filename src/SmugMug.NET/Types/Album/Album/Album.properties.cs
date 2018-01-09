// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class AlbumEntity : SmugMugEntity
    {
        private string _albumKey;
        private bool _allowDownloads;
        private bool _autoRename;
        private string _backprinting;
        private BoutiquePackagingEnum _boutiquePackaging;
        private bool _canRank;
        private bool _canShare;
        private bool _clean;
        private bool _comments;
        private string _communityUri;
        private DateTime _date;
        private string _description;
        private string _downloadPassword;
        private bool _eXIF;
        private bool _external;
        private bool _familyEdit;
        private bool _filenames;
        private bool _friendEdit;
        private bool _geography;
        private bool _hasDownloadPassword;
        private HeaderEnum _header;
        private bool _hideOwner;
        private string _highlightAlbumImageUri;
        private long _imageCount;
        private DateTime _imagesLastUpdated;
        private InterceptShippingEnum _interceptShipping;
        private string _keywords;
        private LargestSizeEnum _largestSize;
        private DateTime _lastUpdated;
        private string _name;
        private string _niceName;
        private string _nodeID;
        private long _originalSizes;
        private bool _packagingBranding;
        private string _password;
        private string _passwordHint;
        private bool _printable;
        private string _printmarkUri;
        private PrivacyEnum _privacy;
        private long _proofDays;
        private bool _protected;
        private string _responseLevel;
        private SecurityTypeEnum _securityType;
        private bool _share;
        private SmugSearchableEnum _smugSearchable;
        private SortDirectionEnum _sortDirection;
        private SortMethodEnum _sortMethod;
        private bool _squareThumbs;
        private string _templateUri;
        private string _themeUri;
        private string _title;
        private long _totalSizes;
        private string _uploadKey;
        private string _urlName;
        private string _urlPath;
        private bool _watermark;
        private string _watermarkUri;
        private string _webUri;
        private bool _worldSearchable;


        public string AlbumKey {
            get {
                return _albumKey;
            }
            set {
                if (_albumKey != value)
                {
                    NotifyPropertyValueChanged("AlbumKey", oldValue:_albumKey, newValue: value);
                    _albumKey = value;     
                }
            }
        }


        public bool AllowDownloads {
            get {
                return _allowDownloads;
            }
            set {
                if (_allowDownloads != value)
                {
                    NotifyPropertyValueChanged("AllowDownloads", oldValue:_allowDownloads, newValue: value);
                    _allowDownloads = value;     
                }
            }
        }


        public bool AutoRename {
            get {
                return _autoRename;
            }
            set {
                if (_autoRename != value)
                {
                    NotifyPropertyValueChanged("AutoRename", oldValue:_autoRename, newValue: value);
                    _autoRename = value;     
                }
            }
        }


        public string Backprinting {
            get {
                return _backprinting;
            }
            set {
                if (_backprinting != value)
                {
                    NotifyPropertyValueChanged("Backprinting", oldValue:_backprinting, newValue: value);
                    _backprinting = value;     
                }
            }
        }


        public BoutiquePackagingEnum BoutiquePackaging {
            get {
                return _boutiquePackaging;
            }
            set {
                if (_boutiquePackaging != value)
                {
                    NotifyPropertyValueChanged("BoutiquePackaging", oldValue:_boutiquePackaging, newValue: value);
                    _boutiquePackaging = value;     
                }
            }
        }


        public bool CanRank {
            get {
                return _canRank;
            }
            set {
                if (_canRank != value)
                {
                    NotifyPropertyValueChanged("CanRank", oldValue:_canRank, newValue: value);
                    _canRank = value;     
                }
            }
        }


        public bool CanShare {
            get {
                return _canShare;
            }
            set {
                if (_canShare != value)
                {
                    NotifyPropertyValueChanged("CanShare", oldValue:_canShare, newValue: value);
                    _canShare = value;     
                }
            }
        }


        public bool Clean {
            get {
                return _clean;
            }
            set {
                if (_clean != value)
                {
                    NotifyPropertyValueChanged("Clean", oldValue:_clean, newValue: value);
                    _clean = value;     
                }
            }
        }


        public bool Comments {
            get {
                return _comments;
            }
            set {
                if (_comments != value)
                {
                    NotifyPropertyValueChanged("Comments", oldValue:_comments, newValue: value);
                    _comments = value;     
                }
            }
        }


        public string CommunityUri {
            get {
                return _communityUri;
            }
            set {
                if (_communityUri != value)
                {
                    NotifyPropertyValueChanged("CommunityUri", oldValue:_communityUri, newValue: value);
                    _communityUri = value;     
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


        public string Description {
            get {
                return _description;
            }
            set {
                if (_description != value)
                {
                    NotifyPropertyValueChanged("Description", oldValue:_description, newValue: value);
                    _description = value;     
                }
            }
        }


        public string DownloadPassword {
            get {
                return _downloadPassword;
            }
            set {
                if (_downloadPassword != value)
                {
                    NotifyPropertyValueChanged("DownloadPassword", oldValue:_downloadPassword, newValue: value);
                    _downloadPassword = value;     
                }
            }
        }


        public bool EXIF {
            get {
                return _eXIF;
            }
            set {
                if (_eXIF != value)
                {
                    NotifyPropertyValueChanged("EXIF", oldValue:_eXIF, newValue: value);
                    _eXIF = value;     
                }
            }
        }


        public bool External {
            get {
                return _external;
            }
            set {
                if (_external != value)
                {
                    NotifyPropertyValueChanged("External", oldValue:_external, newValue: value);
                    _external = value;     
                }
            }
        }


        public bool FamilyEdit {
            get {
                return _familyEdit;
            }
            set {
                if (_familyEdit != value)
                {
                    NotifyPropertyValueChanged("FamilyEdit", oldValue:_familyEdit, newValue: value);
                    _familyEdit = value;     
                }
            }
        }


        public bool Filenames {
            get {
                return _filenames;
            }
            set {
                if (_filenames != value)
                {
                    NotifyPropertyValueChanged("Filenames", oldValue:_filenames, newValue: value);
                    _filenames = value;     
                }
            }
        }


        public bool FriendEdit {
            get {
                return _friendEdit;
            }
            set {
                if (_friendEdit != value)
                {
                    NotifyPropertyValueChanged("FriendEdit", oldValue:_friendEdit, newValue: value);
                    _friendEdit = value;     
                }
            }
        }


        public bool Geography {
            get {
                return _geography;
            }
            set {
                if (_geography != value)
                {
                    NotifyPropertyValueChanged("Geography", oldValue:_geography, newValue: value);
                    _geography = value;     
                }
            }
        }


        public bool HasDownloadPassword {
            get {
                return _hasDownloadPassword;
            }
            set {
                if (_hasDownloadPassword != value)
                {
                    NotifyPropertyValueChanged("HasDownloadPassword", oldValue:_hasDownloadPassword, newValue: value);
                    _hasDownloadPassword = value;     
                }
            }
        }


        public HeaderEnum Header {
            get {
                return _header;
            }
            set {
                if (_header != value)
                {
                    NotifyPropertyValueChanged("Header", oldValue:_header, newValue: value);
                    _header = value;     
                }
            }
        }


        public bool HideOwner {
            get {
                return _hideOwner;
            }
            set {
                if (_hideOwner != value)
                {
                    NotifyPropertyValueChanged("HideOwner", oldValue:_hideOwner, newValue: value);
                    _hideOwner = value;     
                }
            }
        }


        public string HighlightAlbumImageUri {
            get {
                return _highlightAlbumImageUri;
            }
            set {
                if (_highlightAlbumImageUri != value)
                {
                    NotifyPropertyValueChanged("HighlightAlbumImageUri", oldValue:_highlightAlbumImageUri, newValue: value);
                    _highlightAlbumImageUri = value;     
                }
            }
        }


        public long ImageCount {
            get {
                return _imageCount;
            }
            set {
                if (_imageCount != value)
                {
                    NotifyPropertyValueChanged("ImageCount", oldValue:_imageCount, newValue: value);
                    _imageCount = value;     
                }
            }
        }


        public DateTime ImagesLastUpdated {
            get {
                return _imagesLastUpdated;
            }
            set {
                if (_imagesLastUpdated != value)
                {
                    NotifyPropertyValueChanged("ImagesLastUpdated", oldValue:_imagesLastUpdated, newValue: value);
                    _imagesLastUpdated = value;     
                }
            }
        }


        public InterceptShippingEnum InterceptShipping {
            get {
                return _interceptShipping;
            }
            set {
                if (_interceptShipping != value)
                {
                    NotifyPropertyValueChanged("InterceptShipping", oldValue:_interceptShipping, newValue: value);
                    _interceptShipping = value;     
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


        public LargestSizeEnum LargestSize {
            get {
                return _largestSize;
            }
            set {
                if (_largestSize != value)
                {
                    NotifyPropertyValueChanged("LargestSize", oldValue:_largestSize, newValue: value);
                    _largestSize = value;     
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


        public string Name {
            get {
                return _name;
            }
            set {
                if (_name != value)
                {
                    NotifyPropertyValueChanged("Name", oldValue:_name, newValue: value);
                    _name = value;     
                }
            }
        }


        public string NiceName {
            get {
                return _niceName;
            }
            set {
                if (_niceName != value)
                {
                    NotifyPropertyValueChanged("NiceName", oldValue:_niceName, newValue: value);
                    _niceName = value;     
                }
            }
        }


        public string NodeID {
            get {
                return _nodeID;
            }
            set {
                if (_nodeID != value)
                {
                    NotifyPropertyValueChanged("NodeID", oldValue:_nodeID, newValue: value);
                    _nodeID = value;     
                }
            }
        }


        public long OriginalSizes {
            get {
                return _originalSizes;
            }
            set {
                if (_originalSizes != value)
                {
                    NotifyPropertyValueChanged("OriginalSizes", oldValue:_originalSizes, newValue: value);
                    _originalSizes = value;     
                }
            }
        }


        public bool PackagingBranding {
            get {
                return _packagingBranding;
            }
            set {
                if (_packagingBranding != value)
                {
                    NotifyPropertyValueChanged("PackagingBranding", oldValue:_packagingBranding, newValue: value);
                    _packagingBranding = value;     
                }
            }
        }


        public string Password {
            get {
                return _password;
            }
            set {
                if (_password != value)
                {
                    NotifyPropertyValueChanged("Password", oldValue:_password, newValue: value);
                    _password = value;     
                }
            }
        }


        public string PasswordHint {
            get {
                return _passwordHint;
            }
            set {
                if (_passwordHint != value)
                {
                    NotifyPropertyValueChanged("PasswordHint", oldValue:_passwordHint, newValue: value);
                    _passwordHint = value;     
                }
            }
        }


        public bool Printable {
            get {
                return _printable;
            }
            set {
                if (_printable != value)
                {
                    NotifyPropertyValueChanged("Printable", oldValue:_printable, newValue: value);
                    _printable = value;     
                }
            }
        }


        public string PrintmarkUri {
            get {
                return _printmarkUri;
            }
            set {
                if (_printmarkUri != value)
                {
                    NotifyPropertyValueChanged("PrintmarkUri", oldValue:_printmarkUri, newValue: value);
                    _printmarkUri = value;     
                }
            }
        }


        public PrivacyEnum Privacy {
            get {
                return _privacy;
            }
            set {
                if (_privacy != value)
                {
                    NotifyPropertyValueChanged("Privacy", oldValue:_privacy, newValue: value);
                    _privacy = value;     
                }
            }
        }


        public long ProofDays {
            get {
                return _proofDays;
            }
            set {
                if (_proofDays != value)
                {
                    NotifyPropertyValueChanged("ProofDays", oldValue:_proofDays, newValue: value);
                    _proofDays = value;     
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


        public string ResponseLevel {
            get {
                return _responseLevel;
            }
            set {
                if (_responseLevel != value)
                {
                    NotifyPropertyValueChanged("ResponseLevel", oldValue:_responseLevel, newValue: value);
                    _responseLevel = value;     
                }
            }
        }


        public SecurityTypeEnum SecurityType {
            get {
                return _securityType;
            }
            set {
                if (_securityType != value)
                {
                    NotifyPropertyValueChanged("SecurityType", oldValue:_securityType, newValue: value);
                    _securityType = value;     
                }
            }
        }


        public bool Share {
            get {
                return _share;
            }
            set {
                if (_share != value)
                {
                    NotifyPropertyValueChanged("Share", oldValue:_share, newValue: value);
                    _share = value;     
                }
            }
        }


        public SmugSearchableEnum SmugSearchable {
            get {
                return _smugSearchable;
            }
            set {
                if (_smugSearchable != value)
                {
                    NotifyPropertyValueChanged("SmugSearchable", oldValue:_smugSearchable, newValue: value);
                    _smugSearchable = value;     
                }
            }
        }


        public SortDirectionEnum SortDirection {
            get {
                return _sortDirection;
            }
            set {
                if (_sortDirection != value)
                {
                    NotifyPropertyValueChanged("SortDirection", oldValue:_sortDirection, newValue: value);
                    _sortDirection = value;     
                }
            }
        }


        public SortMethodEnum SortMethod {
            get {
                return _sortMethod;
            }
            set {
                if (_sortMethod != value)
                {
                    NotifyPropertyValueChanged("SortMethod", oldValue:_sortMethod, newValue: value);
                    _sortMethod = value;     
                }
            }
        }


        public bool SquareThumbs {
            get {
                return _squareThumbs;
            }
            set {
                if (_squareThumbs != value)
                {
                    NotifyPropertyValueChanged("SquareThumbs", oldValue:_squareThumbs, newValue: value);
                    _squareThumbs = value;     
                }
            }
        }


        public string TemplateUri {
            get {
                return _templateUri;
            }
            set {
                if (_templateUri != value)
                {
                    NotifyPropertyValueChanged("TemplateUri", oldValue:_templateUri, newValue: value);
                    _templateUri = value;     
                }
            }
        }


        public string ThemeUri {
            get {
                return _themeUri;
            }
            set {
                if (_themeUri != value)
                {
                    NotifyPropertyValueChanged("ThemeUri", oldValue:_themeUri, newValue: value);
                    _themeUri = value;     
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


        public long TotalSizes {
            get {
                return _totalSizes;
            }
            set {
                if (_totalSizes != value)
                {
                    NotifyPropertyValueChanged("TotalSizes", oldValue:_totalSizes, newValue: value);
                    _totalSizes = value;     
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

        public string UrlName {
            get {
                return _urlName;
            }
            set {
                if (_urlName != value)
                {
                    NotifyPropertyValueChanged("UrlName", oldValue:_urlName, newValue: value);
                    _urlName = value;     
                }
            }
        }


        public string UrlPath {
            get {
                return _urlPath;
            }
            set {
                if (_urlPath != value)
                {
                    NotifyPropertyValueChanged("UrlPath", oldValue:_urlPath, newValue: value);
                    _urlPath = value;     
                }
            }
        }


        public bool Watermark {
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


        public string WatermarkUri {
            get {
                return _watermarkUri;
            }
            set {
                if (_watermarkUri != value)
                {
                    NotifyPropertyValueChanged("WatermarkUri", oldValue:_watermarkUri, newValue: value);
                    _watermarkUri = value;     
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


        public bool WorldSearchable {
            get {
                return _worldSearchable;
            }
            set {
                if (_worldSearchable != value)
                {
                    NotifyPropertyValueChanged("WorldSearchable", oldValue:_worldSearchable, newValue: value);
                    _worldSearchable = value;     
                }
            }
        }
    }
}
