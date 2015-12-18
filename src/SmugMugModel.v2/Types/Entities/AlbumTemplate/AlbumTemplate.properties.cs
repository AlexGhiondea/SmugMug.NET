// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class AlbumTemplateEntity : SmugMugEntity
    {
        private bool _allowDownloads;
        private string _backprinting;
        private BoutiquePackagingEnum _boutiquePackaging;
        private bool _canRank;
        private bool _clean;
        private bool _comments;
        private string _communityUri;
        private bool _eXIF;
        private bool _external;
        private bool _familyEdit;
        private bool _filenames;
        private bool _friendEdit;
        private bool _geography;
        private HeaderEnum _header;
        private bool _hideOwner;
        private InterceptShippingEnum _interceptShipping;
        private LargestSizeEnum _largestSize;
        private string _name;
        private bool _packagingBranding;
        private string _password;
        private string _passwordHint;
        private bool _printable;
        private string _printmarkUri;
        private int _proofDays;
        private bool _protected;
        private bool _public;
        private bool _share;
        private SmugSearchableEnum _smugSearchable;
        private SortDirectionEnum _sortDirection;
        private SortMethodEnum _sortMethod;
        private bool _squareThumbs;
        private string _templateUri;
        private bool _watermark;
        private string _watermarkUri;
        private bool _worldSearchable;


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


        public bool Public {
            get {
                return _public;
            }
            set {
                if (_public != value)
                {
                    _public = value;
                    NotifyPropertyValueChanged("Public", _public);
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
