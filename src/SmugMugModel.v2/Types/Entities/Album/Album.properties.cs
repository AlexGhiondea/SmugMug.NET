// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

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
        private int _imageCount;
        private DateTime _imagesLastUpdated;
        private InterceptShippingEnum _interceptShipping;
        private string _keywords;
        private LargestSizeEnum _largestSize;
        private DateTime _lastUpdated;
        private string _name;
        private string _niceName;
        private string _nodeID;
        private int _originalSizes;
        private bool _packagingBranding;
        private string _password;
        private string _passwordHint;
        private bool _printable;
        private string _printmarkUri;
        private PrivacyEnum _privacy;
        private int _proofDays;
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
        private int _totalSizes;
        private string _uploadKey;
        private string _uri;
        private string _uriDescription;
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
                    _albumKey = value;
                    NotifyPropertyValueChanged("AlbumKey", _albumKey);
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
                    _allowDownloads = value;
                    NotifyPropertyValueChanged("AllowDownloads", _allowDownloads);
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
                    _autoRename = value;
                    NotifyPropertyValueChanged("AutoRename", _autoRename);
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
                    _backprinting = value;
                    NotifyPropertyValueChanged("Backprinting", _backprinting);
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
                    _boutiquePackaging = value;
                    NotifyPropertyValueChanged("BoutiquePackaging", _boutiquePackaging);
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
                    _canRank = value;
                    NotifyPropertyValueChanged("CanRank", _canRank);
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
                    _canShare = value;
                    NotifyPropertyValueChanged("CanShare", _canShare);
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
                    _clean = value;
                    NotifyPropertyValueChanged("Clean", _clean);
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
                    _comments = value;
                    NotifyPropertyValueChanged("Comments", _comments);
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
                    _communityUri = value;
                    NotifyPropertyValueChanged("CommunityUri", _communityUri);
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


        public string Description {
            get {
                return _description;
            }
            set {
                if (_description != value)
                {
                    _description = value;
                    NotifyPropertyValueChanged("Description", _description);
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
                    _downloadPassword = value;
                    NotifyPropertyValueChanged("DownloadPassword", _downloadPassword);
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
                    _eXIF = value;
                    NotifyPropertyValueChanged("EXIF", _eXIF);
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
                    _external = value;
                    NotifyPropertyValueChanged("External", _external);
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
                    _familyEdit = value;
                    NotifyPropertyValueChanged("FamilyEdit", _familyEdit);
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
                    _filenames = value;
                    NotifyPropertyValueChanged("Filenames", _filenames);
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
                    _friendEdit = value;
                    NotifyPropertyValueChanged("FriendEdit", _friendEdit);
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
                    _geography = value;
                    NotifyPropertyValueChanged("Geography", _geography);
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
                    _hasDownloadPassword = value;
                    NotifyPropertyValueChanged("HasDownloadPassword", _hasDownloadPassword);
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
                    _header = value;
                    NotifyPropertyValueChanged("Header", _header);
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
                    _hideOwner = value;
                    NotifyPropertyValueChanged("HideOwner", _hideOwner);
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
                    _highlightAlbumImageUri = value;
                    NotifyPropertyValueChanged("HighlightAlbumImageUri", _highlightAlbumImageUri);
                }
            }
        }


        public int ImageCount {
            get {
                return _imageCount;
            }
            set {
                if (_imageCount != value)
                {
                    _imageCount = value;
                    NotifyPropertyValueChanged("ImageCount", _imageCount);
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
                    _imagesLastUpdated = value;
                    NotifyPropertyValueChanged("ImagesLastUpdated", _imagesLastUpdated);
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
                    _interceptShipping = value;
                    NotifyPropertyValueChanged("InterceptShipping", _interceptShipping);
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


        public LargestSizeEnum LargestSize {
            get {
                return _largestSize;
            }
            set {
                if (_largestSize != value)
                {
                    _largestSize = value;
                    NotifyPropertyValueChanged("LargestSize", _largestSize);
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


        public string Name {
            get {
                return _name;
            }
            set {
                if (_name != value)
                {
                    _name = value;
                    NotifyPropertyValueChanged("Name", _name);
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
                    _niceName = value;
                    NotifyPropertyValueChanged("NiceName", _niceName);
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
                    _nodeID = value;
                    NotifyPropertyValueChanged("NodeID", _nodeID);
                }
            }
        }


        public int OriginalSizes {
            get {
                return _originalSizes;
            }
            set {
                if (_originalSizes != value)
                {
                    _originalSizes = value;
                    NotifyPropertyValueChanged("OriginalSizes", _originalSizes);
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
                    _packagingBranding = value;
                    NotifyPropertyValueChanged("PackagingBranding", _packagingBranding);
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
                    _password = value;
                    NotifyPropertyValueChanged("Password", _password);
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
                    _passwordHint = value;
                    NotifyPropertyValueChanged("PasswordHint", _passwordHint);
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
                    _printable = value;
                    NotifyPropertyValueChanged("Printable", _printable);
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
                    _printmarkUri = value;
                    NotifyPropertyValueChanged("PrintmarkUri", _printmarkUri);
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
                    _privacy = value;
                    NotifyPropertyValueChanged("Privacy", _privacy);
                }
            }
        }


        public int ProofDays {
            get {
                return _proofDays;
            }
            set {
                if (_proofDays != value)
                {
                    _proofDays = value;
                    NotifyPropertyValueChanged("ProofDays", _proofDays);
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


        public string ResponseLevel {
            get {
                return _responseLevel;
            }
            set {
                if (_responseLevel != value)
                {
                    _responseLevel = value;
                    NotifyPropertyValueChanged("ResponseLevel", _responseLevel);
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
                    _securityType = value;
                    NotifyPropertyValueChanged("SecurityType", _securityType);
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
                    _share = value;
                    NotifyPropertyValueChanged("Share", _share);
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
                    _smugSearchable = value;
                    NotifyPropertyValueChanged("SmugSearchable", _smugSearchable);
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
                    _sortDirection = value;
                    NotifyPropertyValueChanged("SortDirection", _sortDirection);
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
                    _sortMethod = value;
                    NotifyPropertyValueChanged("SortMethod", _sortMethod);
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
                    _squareThumbs = value;
                    NotifyPropertyValueChanged("SquareThumbs", _squareThumbs);
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
                    _templateUri = value;
                    NotifyPropertyValueChanged("TemplateUri", _templateUri);
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
                    _themeUri = value;
                    NotifyPropertyValueChanged("ThemeUri", _themeUri);
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


        public int TotalSizes {
            get {
                return _totalSizes;
            }
            set {
                if (_totalSizes != value)
                {
                    _totalSizes = value;
                    NotifyPropertyValueChanged("TotalSizes", _totalSizes);
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


        public string UrlName {
            get {
                return _urlName;
            }
            set {
                if (_urlName != value)
                {
                    _urlName = value;
                    NotifyPropertyValueChanged("UrlName", _urlName);
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
                    _urlPath = value;
                    NotifyPropertyValueChanged("UrlPath", _urlPath);
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
                    _watermark = value;
                    NotifyPropertyValueChanged("Watermark", _watermark);
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
                    _watermarkUri = value;
                    NotifyPropertyValueChanged("WatermarkUri", _watermarkUri);
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


        public bool WorldSearchable {
            get {
                return _worldSearchable;
            }
            set {
                if (_worldSearchable != value)
                {
                    _worldSearchable = value;
                    NotifyPropertyValueChanged("WorldSearchable", _worldSearchable);
                }
            }
        }



    }
}
