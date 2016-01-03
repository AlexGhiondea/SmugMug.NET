// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using SmugMug.v2.Authentication;
using SmugMug.v2.Helpers;
using SmugMug.v2.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace SmugMug.v2.Types
{
    public partial class SmugMugEntity
    {
        public static async Task<TResult> RetrieveEntityAsync<TResult>(OAuthToken oauthToken, string requestUri)
            where TResult : SmugMugEntity
        {
            TResult result = await DeserializeRequestAsync<TResult>(oauthToken, requestUri);
            if (result == null)
                return null;

            return result;
        }

        public static async Task<TResult[]> RetrieveEntityArrayAsync<TResult>(OAuthToken oauthToken, string requestUri)
            where TResult : SmugMugEntity
        {
            TResult[] result = await DeserializeRequestAsync<TResult[]>(oauthToken, requestUri);
            if (result == null)
                return null;

            return result;
        }

        protected async Task<TResult[]> RetrieveEntityArrayAsync<TResult>(string requestUri)
            where TResult : SmugMugEntity
        {
            TResult[] result = await RetrieveEntityArrayAsync<TResult>(this._oauthToken, requestUri);

            if (result == null)
                return null;

            // Let each object have the token
            foreach (var item in result)
            {
                item._oauthToken = this._oauthToken;
                item.ParentEntity = this;
            }
            return result;
        }

        protected async Task<TResult> RetrieveEntityAsync<TResult>(string requestUri)
            where TResult : SmugMugEntity
        {
            TResult result = await RetrieveEntityAsync<TResult>(this._oauthToken, requestUri);
            if (result == null)
                return null;

            result._oauthToken = this._oauthToken;
            result.ParentEntity = this;
            return result;
        }

        private static async Task<TResult> DeserializeRequestAsync<TResult>(OAuthToken oauthToken, string requestUri)
        {
            using (HttpClient httpClient = HttpClientHelpers.CreateHttpClient(oauthToken))
            using (HttpResponseMessage response = await httpClient.GetAsync(requestUri))
            using (StreamReader streamReader = new StreamReader(await response.Content.ReadAsStreamAsync()))
            using (JsonTextReader jsonTextReader = new JsonTextReader(streamReader))
            {
                JObject jsonObject = JObject.Load(jsonTextReader);

                JToken objectResponse = JsonHelpers.GetDataOrDefault(jsonObject);

                if (objectResponse == null)
                    return default(TResult);

                //TODO: Implement paging
                using (JsonReader reader = objectResponse.CreateReader())
                {
                    JsonSerializerSettings settings = new JsonSerializerSettings();
                    settings.Converters = new List<JsonConverter>();
                    settings.Converters.Add(new StringEnumConverter());
                    settings.ContractResolver = new PrivateMemberContractResolver();
                    JsonSerializer jser = JsonSerializer.Create(settings);

                    return jser.Deserialize<TResult>(reader);
                }
            }
        }

        internal async Task GetRequestAsync(string requestUri)
        {
            using (HttpClient httpClient = HttpClientHelpers.CreateHttpClient(_oauthToken))
            using (HttpResponseMessage response = await httpClient.GetAsync(requestUri))
            using (StreamReader streamReader = new StreamReader(await response.Content.ReadAsStreamAsync()))
            {
            }
        }

        internal async Task PostRequestAsync(string requestUri, string content)
        {
            using (HttpClient httpClient = HttpClientHelpers.CreateHttpClient(_oauthToken))
            using (HttpContent httpContent = new StringContent(content))
            using (HttpResponseMessage response = await httpClient.PostAsync(requestUri, httpContent))
            using (StreamReader streamReader = new StreamReader(await response.Content.ReadAsStreamAsync()))
            {
            }
        }

        internal async Task PatchRequestAsync(string requestUri, string content)
        {
            using (HttpClient httpClient = HttpClientHelpers.CreateHttpClient(_oauthToken))
            using (HttpContent httpContent = new StringContent(content))
            using (HttpRequestMessage message = new HttpRequestMessage(new HttpMethod("PATCH"), requestUri))
            {
                message.Content = httpContent;
                using (HttpResponseMessage response = await httpClient.SendAsync(message))
                using (StreamReader streamReader = new StreamReader(await response.Content.ReadAsStreamAsync()))
                {
                }
            }
        }
    }
}
