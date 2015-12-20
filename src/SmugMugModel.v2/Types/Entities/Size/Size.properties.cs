// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class SizeEntity : SmugMugEntity
    {
        private long _albumCount;
        private long _dynamicMediaCount;
        private long _dynamicMediaSize;
        private long _folderCount;
        private long _mediaCount;
        private long _mediaSize;
        private long _pageCount;
        private string _uri;
        private string _uriDescription;


        public long AlbumCount {
            get {
                return _albumCount;
            }
            set {
                if (_albumCount != value)
                {
                    _albumCount = value;
                    NotifyPropertyValueChanged("AlbumCount", _albumCount);
                }
            }
        }


        public long DynamicMediaCount {
            get {
                return _dynamicMediaCount;
            }
            set {
                if (_dynamicMediaCount != value)
                {
                    _dynamicMediaCount = value;
                    NotifyPropertyValueChanged("DynamicMediaCount", _dynamicMediaCount);
                }
            }
        }


        public long DynamicMediaSize {
            get {
                return _dynamicMediaSize;
            }
            set {
                if (_dynamicMediaSize != value)
                {
                    _dynamicMediaSize = value;
                    NotifyPropertyValueChanged("DynamicMediaSize", _dynamicMediaSize);
                }
            }
        }


        public long FolderCount {
            get {
                return _folderCount;
            }
            set {
                if (_folderCount != value)
                {
                    _folderCount = value;
                    NotifyPropertyValueChanged("FolderCount", _folderCount);
                }
            }
        }


        public long MediaCount {
            get {
                return _mediaCount;
            }
            set {
                if (_mediaCount != value)
                {
                    _mediaCount = value;
                    NotifyPropertyValueChanged("MediaCount", _mediaCount);
                }
            }
        }


        public long MediaSize {
            get {
                return _mediaSize;
            }
            set {
                if (_mediaSize != value)
                {
                    _mediaSize = value;
                    NotifyPropertyValueChanged("MediaSize", _mediaSize);
                }
            }
        }


        public long PageCount {
            get {
                return _pageCount;
            }
            set {
                if (_pageCount != value)
                {
                    _pageCount = value;
                    NotifyPropertyValueChanged("PageCount", _pageCount);
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
    }
}