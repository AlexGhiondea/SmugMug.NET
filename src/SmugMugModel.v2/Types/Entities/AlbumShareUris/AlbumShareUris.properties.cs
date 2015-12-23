// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class AlbumShareUrisEntity : SmugMugEntity
    {
        private string _slideshowEmbedUri;
        private string _slideshowFlashUri;
        private string _uri;
        private string _uriDescription;


        public string SlideshowEmbedUri {
            get {
                return _slideshowEmbedUri;
            }
            set {
                if (_slideshowEmbedUri != value)
                {
                    NotifyPropertyValueChanged("SlideshowEmbedUri", oldValue:_slideshowEmbedUri, newValue: value);
                    _slideshowEmbedUri = value;     
                }
            }
        }


        public string SlideshowFlashUri {
            get {
                return _slideshowFlashUri;
            }
            set {
                if (_slideshowFlashUri != value)
                {
                    NotifyPropertyValueChanged("SlideshowFlashUri", oldValue:_slideshowFlashUri, newValue: value);
                    _slideshowFlashUri = value;     
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
                    NotifyPropertyValueChanged("Uri", oldValue:_uri, newValue: value);
                    _uri = value;     
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
                    NotifyPropertyValueChanged("UriDescription", oldValue:_uriDescription, newValue: value);
                    _uriDescription = value;     
                }
            }
        }
    }
}
