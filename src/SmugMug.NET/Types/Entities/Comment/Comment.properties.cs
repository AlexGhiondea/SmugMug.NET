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
                    NotifyPropertyValueChanged("Comment", oldValue:_comment, newValue: value);
                    _comment = value;     
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
                    NotifyPropertyValueChanged("Date", oldValue:_date, newValue: value);
                    _date = value;     
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
                    NotifyPropertyValueChanged("Name", oldValue:_name, newValue: value);
                    _name = value;     
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
                    NotifyPropertyValueChanged("Rating", oldValue:_rating, newValue: value);
                    _rating = value;     
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
                    NotifyPropertyValueChanged("ServiceID", oldValue:_serviceID, newValue: value);
                    _serviceID = value;     
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
                    NotifyPropertyValueChanged("SocialID", oldValue:_socialID, newValue: value);
                    _socialID = value;     
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
                    NotifyPropertyValueChanged("Status", oldValue:_status, newValue: value);
                    _status = value;     
                }
            }
        }
    }
}
