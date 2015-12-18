// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class EmbedVideoEntity : SmugMugEntity
    {
        private string _compact;
        private string _embedSize1280;
        private string _embedSize1920;
        private string _embedSize320;
        private string _embedSize640;
        private string _embedSize960;
        private string _small;
        private string _uri;
        private string _uriDescription;


        public string Compact {
            get {
                return _compact;
            }
            set {
                if (_compact != value)
                {
                    _compact = value;
                    NotifyPropertyValueChanged("Compact", _compact);
                }
            }
        }


        public string EmbedSize1280 {
            get {
                return _embedSize1280;
            }
            set {
                if (_embedSize1280 != value)
                {
                    _embedSize1280 = value;
                    NotifyPropertyValueChanged("EmbedSize1280", _embedSize1280);
                }
            }
        }


        public string EmbedSize1920 {
            get {
                return _embedSize1920;
            }
            set {
                if (_embedSize1920 != value)
                {
                    _embedSize1920 = value;
                    NotifyPropertyValueChanged("EmbedSize1920", _embedSize1920);
                }
            }
        }


        public string EmbedSize320 {
            get {
                return _embedSize320;
            }
            set {
                if (_embedSize320 != value)
                {
                    _embedSize320 = value;
                    NotifyPropertyValueChanged("EmbedSize320", _embedSize320);
                }
            }
        }


        public string EmbedSize640 {
            get {
                return _embedSize640;
            }
            set {
                if (_embedSize640 != value)
                {
                    _embedSize640 = value;
                    NotifyPropertyValueChanged("EmbedSize640", _embedSize640);
                }
            }
        }


        public string EmbedSize960 {
            get {
                return _embedSize960;
            }
            set {
                if (_embedSize960 != value)
                {
                    _embedSize960 = value;
                    NotifyPropertyValueChanged("EmbedSize960", _embedSize960);
                }
            }
        }


        public string Small {
            get {
                return _small;
            }
            set {
                if (_small != value)
                {
                    _small = value;
                    NotifyPropertyValueChanged("Small", _small);
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
