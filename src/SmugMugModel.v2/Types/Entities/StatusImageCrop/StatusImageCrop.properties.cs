// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class StatusImageCropEntity : SmugMugEntity
    {
        private string _imageUri;
        private DateTime _lastUpdated;
        private string _message;
        private string _queueName;
        private ImageStatusEnum _status;
        private DateTime _timeIn;


        public string ImageUri {
            get {
                return _imageUri;
            }
            set {
                if (_imageUri != value)
                {
                    _imageUri = value;
                    NotifyPropertyValueChanged("ImageUri", _imageUri);
                }
            }
        }


        public DateTime LastUpdated {
            get {
                return _lastUpdated;
            }
            set {
                if (_lastUpdated != value)
                {
                    _lastUpdated = value;
                    NotifyPropertyValueChanged("LastUpdated", _lastUpdated);
                }
            }
        }


        public string Message {
            get {
                return _message;
            }
            set {
                if (_message != value)
                {
                    _message = value;
                    NotifyPropertyValueChanged("Message", _message);
                }
            }
        }


        public string QueueName {
            get {
                return _queueName;
            }
            set {
                if (_queueName != value)
                {
                    _queueName = value;
                    NotifyPropertyValueChanged("QueueName", _queueName);
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
                    _status = value;
                    NotifyPropertyValueChanged("Status", _status);
                }
            }
        }


        public DateTime TimeIn {
            get {
                return _timeIn;
            }
            set {
                if (_timeIn != value)
                {
                    _timeIn = value;
                    NotifyPropertyValueChanged("TimeIn", _timeIn);
                }
            }
        }
    }
}
