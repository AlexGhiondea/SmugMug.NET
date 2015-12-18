// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class SizeEntity : SmugMugEntity
    {
        private int _albumCount;
        private int _dynamicMediaCount;
        private int _dynamicMediaSize;
        private int _folderCount;
        private int _mediaCount;
        private int _mediaSize;
        private int _pageCount;
        private string _uri;
        private string _uriDescription;


        public int AlbumCount {
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


        public int DynamicMediaCount {
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


        public int DynamicMediaSize {
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


        public int FolderCount {
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


        public int MediaCount {
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


        public int MediaSize {
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


        public int PageCount {
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
