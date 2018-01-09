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

        public long AlbumCount {
            get {
                return _albumCount;
            }
            set {
                if (_albumCount != value)
                {
                    NotifyPropertyValueChanged("AlbumCount", oldValue:_albumCount, newValue: value);
                    _albumCount = value;     
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
                    NotifyPropertyValueChanged("DynamicMediaCount", oldValue:_dynamicMediaCount, newValue: value);
                    _dynamicMediaCount = value;     
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
                    NotifyPropertyValueChanged("DynamicMediaSize", oldValue:_dynamicMediaSize, newValue: value);
                    _dynamicMediaSize = value;     
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
                    NotifyPropertyValueChanged("FolderCount", oldValue:_folderCount, newValue: value);
                    _folderCount = value;     
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
                    NotifyPropertyValueChanged("MediaCount", oldValue:_mediaCount, newValue: value);
                    _mediaCount = value;     
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
                    NotifyPropertyValueChanged("MediaSize", oldValue:_mediaSize, newValue: value);
                    _mediaSize = value;     
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
                    NotifyPropertyValueChanged("PageCount", oldValue:_pageCount, newValue: value);
                    _pageCount = value;     
                }
            }
        }
    }
}
