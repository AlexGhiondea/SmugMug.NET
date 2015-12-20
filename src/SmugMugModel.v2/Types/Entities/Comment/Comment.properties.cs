// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CommentEntity : SmugMugEntity
    {
        private string _comment;
        private DateTime _date;
        private string _name;
        private long _rating;
        private long _serviceID;
        private long _socialID;
        private CommentStatusEnum _status;


        public string Comment {
            get {
                return _comment;
            }
            set {
                if (_comment != value)
                {
                    _comment = value;
                    NotifyPropertyValueChanged("Comment", _comment);
                }
            }
        }


        public DateTime Date {
            get {
                return _date;
            }
            set {
                if (_date != value)
                {
                    _date = value;
                    NotifyPropertyValueChanged("Date", _date);
                }
            }
        }


        public string Name {
            get {
                return _name;
            }
            set {
                if (_name != value)
                {
                    _name = value;
                    NotifyPropertyValueChanged("Name", _name);
                }
            }
        }


        public long Rating {
            get {
                return _rating;
            }
            set {
                if (_rating != value)
                {
                    _rating = value;
                    NotifyPropertyValueChanged("Rating", _rating);
                }
            }
        }


        public long ServiceID {
            get {
                return _serviceID;
            }
            set {
                if (_serviceID != value)
                {
                    _serviceID = value;
                    NotifyPropertyValueChanged("ServiceID", _serviceID);
                }
            }
        }


        public long SocialID {
            get {
                return _socialID;
            }
            set {
                if (_socialID != value)
                {
                    _socialID = value;
                    NotifyPropertyValueChanged("SocialID", _socialID);
                }
            }
        }


        public CommentStatusEnum Status {
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
    }
}
