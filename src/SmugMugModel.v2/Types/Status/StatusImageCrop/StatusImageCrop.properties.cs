// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class StatusImageCropEntity : StatusImageEntity
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
                    NotifyPropertyValueChanged("ImageUri", oldValue:_imageUri, newValue: value);
                    _imageUri = value;     
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
                    NotifyPropertyValueChanged("LastUpdated", oldValue:_lastUpdated, newValue: value);
                    _lastUpdated = value;     
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
                    NotifyPropertyValueChanged("Message", oldValue:_message, newValue: value);
                    _message = value;     
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
                    NotifyPropertyValueChanged("QueueName", oldValue:_queueName, newValue: value);
                    _queueName = value;     
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


        public DateTime TimeIn {
            get {
                return _timeIn;
            }
            set {
                if (_timeIn != value)
                {
                    NotifyPropertyValueChanged("TimeIn", oldValue:_timeIn, newValue: value);
                    _timeIn = value;     
                }
            }
        }
    }
}
