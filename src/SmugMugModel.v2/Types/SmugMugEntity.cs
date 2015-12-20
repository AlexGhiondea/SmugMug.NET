// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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

        public async Task<TResult> RetrieveEntityAsync<TResult>(string requestUri)
            where TResult : SmugMugEntity
        {
            TResult result = await DeserializeRequestAsync<TResult>(requestUri);
            if (result == null)
                return null;

            result._oauthToken = this._oauthToken;
            return result;
        }

        public async Task<TResult[]> RetrieveEntityArrayAsync<TResult>(string requestUri)
            where TResult : SmugMugEntity
        {
            TResult[] result = await DeserializeRequestAsync<TResult[]>(requestUri);
            if (result == null)
                return null;

            // Let each object have the token
            foreach (var item in result)
            {
                item._oauthToken = this._oauthToken;
            }
            return result;
        }

        private async Task<TResult> DeserializeRequestAsync<TResult>(string requestUri)
        {
            using (HttpClient httpClient = HttpClientHelpers.CreateHttpClient(_oauthToken))
            using (HttpResponseMessage response = await httpClient.GetAsync(requestUri))
            using (StreamReader streamReader = new StreamReader(await response.Content.ReadAsStreamAsync()))
            using (JsonTextReader jsonTextReader = new JsonTextReader(streamReader))
            {
                JObject jsonObject = JObject.Load(jsonTextReader);

                // find the right object name to deserialize
                string entityName = GetEntityNameFromTypeName(typeof(TResult));

                JToken objectResponse = GetDataAsJTokenOrDefault(jsonObject, entityName);

                if (objectResponse == null)
                    return default(TResult);

                //TODO: Implement paging
                using (JsonReader reader = objectResponse.CreateReader())
                {
                    JsonSerializerSettings settings = new JsonSerializerSettings();
                    settings.Converters = new List<JsonConverter>();
                    settings.Converters.Add(new StringEnumConverter());
                    JsonSerializer jser = JsonSerializer.Create(settings);

                    return jser.Deserialize<TResult>(reader);
                }
            }
        }

        public async Task GetRequestAsync(string requestUri)
        {
            using (HttpClient httpClient = HttpClientHelpers.CreateHttpClient(_oauthToken))
            using (HttpResponseMessage response = await httpClient.GetAsync(requestUri))
            using (StreamReader streamReader = new StreamReader(await response.Content.ReadAsStreamAsync()))
            {
            }
        }

        private static JToken GetDataAsJTokenOrDefault(JObject obj, string entityName)
        {
            const string ResponseString = "Response";

            JProperty response = obj.Property(ResponseString);
            if (response == null)
                return null;

            JObject responseValue = response.Value as JObject;
            if (responseValue == null)
                return null;

            JProperty objectData = responseValue.Property(entityName);
            if (objectData == null)
                return null;

            return objectData.Value;
        }

        private static string GetEntityNameFromTypeName(Type type)
        {
            return type.Name.Replace("Entity", "").Replace("[]", "");
        }
    }
}
