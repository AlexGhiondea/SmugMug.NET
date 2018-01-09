// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class DownloadEntity : SmugMugEntity
    {
        private DateTime _dateAdded;
        private DateTime _dateModified;
        private string _fileName;
        private long _part;
        private ImageStatusEnum _status;

        public DateTime DateAdded {
            get {
                return _dateAdded;
            }
            set {
                if (_dateAdded != value)
                {
                    NotifyPropertyValueChanged("DateAdded", oldValue:_dateAdded, newValue: value);
                    _dateAdded = value;     
                }
            }
        }


        public DateTime DateModified {
            get {
                return _dateModified;
            }
            set {
                if (_dateModified != value)
                {
                    NotifyPropertyValueChanged("DateModified", oldValue:_dateModified, newValue: value);
                    _dateModified = value;     
                }
            }
        }


        public string FileName {
            get {
                return _fileName;
            }
            set {
                if (_fileName != value)
                {
                    NotifyPropertyValueChanged("FileName", oldValue:_fileName, newValue: value);
                    _fileName = value;     
                }
            }
        }


        public long Part {
            get {
                return _part;
            }
            set {
                if (_part != value)
                {
                    NotifyPropertyValueChanged("Part", oldValue:_part, newValue: value);
                    _part = value;     
                }
            }
        }


        public ImageStatusEnum Status {
            get {
                return _status;
            }
            set {
                if (_status != value)
                {
                    NotifyPropertyValueChanged("Status", oldValue:_status, newValue: value);
                    _status = value;     
                }
            }
        }
    }
}
