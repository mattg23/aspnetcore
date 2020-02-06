// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Microsoft.AspNetCore.Components.WebAssembly.Authentication
{
    public class OidcProviderOptions
    {
        public string Authority { get; set; }

        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        public IList<string> DefaultScopes { get; set; } = new List<string> { "openid", "profile" };

        [JsonPropertyName("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonPropertyName("post_logout_redirect_uri")]
        public string PostLogoutRedirectUri { get; set; }
    }
}
