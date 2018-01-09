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

        public string Compact
        {
            get
            {
                return _compact;
            }
            set
            {
                if (_compact != value)
                {
                    NotifyPropertyValueChanged("Compact", oldValue: _compact, newValue: value);
                    _compact = value;
                }
            }
        }


        public string EmbedSize1280
        {
            get
            {
                return _embedSize1280;
            }
            set
            {
                if (_embedSize1280 != value)
                {
                    NotifyPropertyValueChanged("EmbedSize1280", oldValue: _embedSize1280, newValue: value);
                    _embedSize1280 = value;
                }
            }
        }


        public string EmbedSize1920
        {
            get
            {
                return _embedSize1920;
            }
            set
            {
                if (_embedSize1920 != value)
                {
                    NotifyPropertyValueChanged("EmbedSize1920", oldValue: _embedSize1920, newValue: value);
                    _embedSize1920 = value;
                }
            }
        }


        public string EmbedSize320
        {
            get
            {
                return _embedSize320;
            }
            set
            {
                if (_embedSize320 != value)
                {
                    NotifyPropertyValueChanged("EmbedSize320", oldValue: _embedSize320, newValue: value);
                    _embedSize320 = value;
                }
            }
        }


        public string EmbedSize640
        {
            get
            {
                return _embedSize640;
            }
            set
            {
                if (_embedSize640 != value)
                {
                    NotifyPropertyValueChanged("EmbedSize640", oldValue: _embedSize640, newValue: value);
                    _embedSize640 = value;
                }
            }
        }


        public string EmbedSize960
        {
            get
            {
                return _embedSize960;
            }
            set
            {
                if (_embedSize960 != value)
                {
                    NotifyPropertyValueChanged("EmbedSize960", oldValue: _embedSize960, newValue: value);
                    _embedSize960 = value;
                }
            }
        }


        public string Small
        {
            get
            {
                return _small;
            }
            set
            {
                if (_small != value)
                {
                    NotifyPropertyValueChanged("Small", oldValue: _small, newValue: value);
                    _small = value;
                }
            }
        }
    }
}
