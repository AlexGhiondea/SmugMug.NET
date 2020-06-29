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
        protected OAuthToken _oauthToken;
        private string _uri;
        private string _uriDescription;
        private string _nodeId;

        public Dictionary<string, UriDescriptor> Uris { get; set; }

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

        public SmugMugEntity Parent { get; set; }

        public virtual string EntityId { get { return string.Empty; } }

        public virtual string PatchUri { get { return Uri; } }

        public SmugMugEntity()
        {

        }

        public SmugMugEntity(OAuthToken token)
        {
            _oauthToken = token;
        }

        public async Task SaveAsync()
        {
            // We get the modified properties and post them to the objects's uri
            var patchPropertiesWithValues = GetModifedPropertiesValue(GetPatchPropertiesName());

            await PatchRequestAsync(Constants.Addresses.SmugMug + AppendSuffixToUrl(this.PatchUri), JsonHelpers.GetPayloadAsJson(patchPropertiesWithValues));
        }

        protected async Task CreateAsync(string uri, List<string> properties)
        {
            var patchPropertiesWithValues = GetPropertiesValue(properties);

            await PostRequestAsync(uri, JsonHelpers.GetPayloadAsJson(patchPropertiesWithValues));
        }
        
        protected string AppendSuffixToUrl(string url)
        {
            if (url.EndsWith("-0"))
                return url;

            return $"{url}-0";
        }

        public string NodeId
        {
            get
            {
                if (_nodeId != null)
                {
                    return _nodeId;
                }

                // get it from the Node Uri.
                UriDescriptor val;
                if (Uris.TryGetValue("Node", out val))
                {
                    var posLastSlash = val.Uri.LastIndexOf("/");
                    if (posLastSlash >= 0)
                        _nodeId = val.Uri.Substring(posLastSlash + 1);
                    else
                        _nodeId = string.Empty;
                }
                return _nodeId;
            }
            set
            {
                _nodeId = value;
            }
        }
    }
}
