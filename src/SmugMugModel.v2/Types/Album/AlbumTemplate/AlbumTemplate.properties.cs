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
        private long _proofDays;
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
                    NotifyPropertyValueChanged("AllowDownloads", oldValue:_allowDownloads, newValue: value);
                    _allowDownloads = value;     
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


        public bool Public {
            get {
                return _public;
            }
            set {
                if (_public != value)
                {
                    NotifyPropertyValueChanged("Public", oldValue:_public, newValue: value);
                    _public = value;     
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
