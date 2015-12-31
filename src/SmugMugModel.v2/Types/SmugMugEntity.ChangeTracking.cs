// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace SmugMug.v2.Types
{
    public partial class SmugMugEntity
    {
        private Dictionary<string, PropertyData> _storage = new Dictionary<string, PropertyData>();
        private readonly object _syncLock = new object();
        private bool _trackChanges = true;

        // We are going to use the serializing/serialized callbacks to figure out when the serialization process
        // is complete so that we can start tracking user changes to the object.
        [OnDeserializing]
        protected void PauseChangeTracking(StreamingContext context)
        {
            _trackChanges = false;
        }

        [OnDeserialized]
        protected void ResumeChangeTracking(StreamingContext context)
        {
            _trackChanges = true;
        }

        protected void NotifyPropertyValueChanged(string propertyName, object oldValue, object newValue)
        {
            if (!_trackChanges)
                return;

            PropertyData dataInStorage;
            if (_storage.TryGetValue(propertyName, out dataInStorage))
            {
                // currentData is the value that was first captured.
                // setting it back to that value should remove this property from the
                // list of changed values
                if (dataInStorage.OldValue.Equals(newValue))
                {
                    Debug.WriteLine("Same as original {0}, remove tracking", newValue);
                    lock (_syncLock)
                    {
                        _storage.Remove(propertyName);
                    }
                }
                else
                {
                    dataInStorage.NewValue = newValue;
                    lock (_syncLock)
                    {
                        _storage[propertyName] = dataInStorage;
                    }
                }
                return;
            }

            // if the old and new values are the same, nothing to do.
            if (oldValue.Equals(newValue))
                return;

            dataInStorage = new PropertyData(oldValue, newValue);
            lock (_syncLock)
            {
                Debug.WriteLine("New value! '{0}'", newValue);
                _storage.Add(propertyName, dataInStorage);
            }
        }

        protected List<KeyValuePair<string, object>> GetModifedPropertiesValue(List<string> allowedProperties)
        {
            List<KeyValuePair<string, object>> properties = new List<KeyValuePair<string, object>>();

            //NOTE: This uses the information from the change tracking storage 
            HashSet<string> allowedPropertiesSet = new HashSet<string>(allowedProperties, StringComparer.OrdinalIgnoreCase);

            lock (_syncLock)
            {
                foreach (var item in _storage)
                {
                    if (allowedPropertiesSet.Contains(item.Key))
                    {
                        properties.Add(new KeyValuePair<string, object>(item.Key, item.Value.NewValue));
                    }
                }

            }
            return properties;
        }

        protected List<KeyValuePair<string, object>> GetPropertiesValue(List<string> requestedProperties)
        {
            List<KeyValuePair<string, object>> result = new List<KeyValuePair<string, object>>();
            Type thisType = this.GetType();

            foreach (var propertyName in requestedProperties)
            {
                PropertyInfo property = thisType.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public);
                if (property == null)
                {
                    Debug.Write(string.Format("Could not find property {0} on type {1}", propertyName, thisType.Name));
                    continue;
                }

                object value = property.GetValue(this);
                result.Add(new KeyValuePair<string, object>(propertyName, value));
            }

            return result;
        }

        protected virtual IEnumerable<string> GetPostPropertiesName()
        {
            return Enumerable.Empty<string>();
        }

        protected virtual IEnumerable<string> GetPatchPropertiesName()
        {
            return Enumerable.Empty<string>();
        }
    }
}
