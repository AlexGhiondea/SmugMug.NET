// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
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
        public async Task<TResult> RetrieveEntityAsync<TResult>(string requestUri)
            where TResult : SmugMugEntity
        {
            TResult result = await DeserializeRequestAsync<TResult>(requestUri);
            if (result == null)
                return null;

            result._oauthToken = this._oauthToken;
            result.ParentEntity = this;
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
                item.ParentEntity = this;
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

                JToken objectResponse = GetDataAsJTokenOrDefault(jsonObject);

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

        public async Task GetRequestAsync(string requestUri)
        {
            using (HttpClient httpClient = HttpClientHelpers.CreateHttpClient(_oauthToken))
            using (HttpResponseMessage response = await httpClient.GetAsync(requestUri))
            using (StreamReader streamReader = new StreamReader(await response.Content.ReadAsStreamAsync()))
            {
            }
        }

        public async Task PostRequestAsync(string requestUri, string content)
        {
            using (HttpClient httpClient = HttpClientHelpers.CreateHttpClient(_oauthToken))
            using (HttpContent httpContent = new StringContent(content))
            using (HttpResponseMessage response = await httpClient.PostAsync(requestUri, httpContent))
            using (StreamReader streamReader = new StreamReader(await response.Content.ReadAsStreamAsync()))
            {
            }
        }

        public async Task PatchRequestAsync(string requestUri, string content)
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

        private static JToken GetDataAsJTokenOrDefault(JObject obj)
        {
            const string ResponseString = "Response";

            JProperty response = obj.Property(ResponseString);
            if (response == null)
                return null;

            JObject responseValue = response.Value as JObject;
            if (responseValue == null)
                return null;

            JProperty locatorNode = responseValue.Property("Locator");

            if (locatorNode == null)
                return null;

            string entityName = locatorNode.Value.ToString();

            JProperty objectData = responseValue.Property(entityName);
            if (objectData == null)
                return null;

            return objectData.Value;
        }
    }
}
