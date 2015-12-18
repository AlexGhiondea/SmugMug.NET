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
                    _slideshowEmbedUri = value;
                    NotifyPropertyValueChanged("SlideshowEmbedUri", _slideshowEmbedUri);
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
                    _slideshowFlashUri = value;
                    NotifyPropertyValueChanged("SlideshowFlashUri", _slideshowFlashUri);
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
