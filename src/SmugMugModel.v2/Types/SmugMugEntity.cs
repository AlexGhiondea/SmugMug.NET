// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.v2.Authentication;
using SmugMug.v2.Utility;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmugMug.v2.Types
{
    public partial class SmugMugEntity
    {
        private string _uri;
        private string _uriDescription;

        public string Uri
        {
            get
            {
                return _uri;
            }
            set
            {
                if (_uri != value)
                {
                    NotifyPropertyValueChanged("Uri", oldValue: _uri, newValue: value);
                    _uri = value;
                }
            }
        }

        public string UriDescription
        {
            get
            {
                return _uriDescription;
            }
            set
            {
                if (_uriDescription != value)
                {
                    NotifyPropertyValueChanged("UriDescription", oldValue: _uriDescription, newValue: value);
                    _uriDescription = value;
                }
            }
        }

        public string TODOUrl { get; set; }
        protected OAuthToken _oauthToken;

        public SmugMugEntity()
        {

        }
        public SmugMugEntity(OAuthToken token)
        {
            _oauthToken = token;
        }

        public SmugMugEntity ParentEntity { get; set; }

        public virtual string EntityId { get { return string.Empty; } }

        protected async Task SaveAsync(string uri, List<string> patchProperties)
        {
            var patchPropertiesWithValues = GetModifedPropertiesValue(patchProperties);

            await PatchRequestAsync(uri, JsonHelpers.GetPayloadAsJson(patchPropertiesWithValues));
        }

        protected async Task CreateAsync(string uri, List<string> properties)
        {
            var patchPropertiesWithValues = GetPropertiesValue(properties);

            await PatchRequestAsync(uri, JsonHelpers.GetPayloadAsJson(patchPropertiesWithValues));
        }
    }
}
