// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SmugMug.v2.Authentication;
using SmugMug.v2.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace SmugMug.v2.Types
{
    public class SmugMugEntity
    {
        private Dictionary<string, object> _storage = new Dictionary<string, object>();
        private readonly object _syncLock = new object();
        protected OAuthToken _oauthToken;

        public SmugMugEntity()
        {

        }
        public SmugMugEntity(OAuthToken token)
        {
            _oauthToken = token;
        }

        protected void NotifyPropertyValueChanged(string propertyName, object newValue)
        {
            object firstCapturedData;
            if (_storage.TryGetValue(propertyName, out firstCapturedData))
            {
                // currentData is the value that was first captured.
                // setting it back to that value should remove this property from the
                // list of changed values
                if (firstCapturedData.Equals(newValue))
                {
                    Debug.WriteLine("Same as original {0}, remove tracking", newValue);
                    lock (_syncLock)
                    {
                        _storage.Remove(propertyName);
                    }
                }
                return;
            }

            lock (_syncLock)
            {
                Debug.WriteLine("New value! '{0}'", newValue);
                _storage.Add(propertyName, newValue);
            }
        }
    }
}
