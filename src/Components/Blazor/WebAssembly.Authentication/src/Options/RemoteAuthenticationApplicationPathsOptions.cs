// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Components.WebAssembly.Authentication
{
    /// <summary>
    /// Represents the options for the paths used by the application for authentication operations. These paths are relative to the base.
    /// </summary>
    public class RemoteAuthenticationApplicationPathsOptions
    {
        /// <summary>
        /// Gets or sets the path to the endpoint for registering new users. It might be absolute and point outside of the application.
        /// </summary>
        public string RegisterPath { get; set; }

        /// <summary>
        /// Gets or sets the path to the endpoint for registering new users. It might be absolute and point outside of the application.
        /// </summary>
        public string ProfilePath { get; set; }

        /// <summary>
        /// Gets or sets the path to the login page.
        /// </summary>
        public string LoginPath { get; set; } = RemoteAuthenticationDefaults.LoginPath;

        /// <summary>
        /// Gets or sets the path to the login callback page.
        /// </summary>
        public string LoginCallbackPath { get; set; } = RemoteAuthenticationDefaults.LoginCallbackPath;

        /// <summary>
        /// Gets or sets the path to the login failed page.
        /// </summary>
        public string LoginFailedPath { get; set; } = RemoteAuthenticationDefaults.LoginFailedPath;

        /// <summary>
        /// Gets or sets the path to the logout page.
        /// </summary>
        public string LogoutPath { get; set; } = RemoteAuthenticationDefaults.LogoutPath;

        /// <summary>
        /// Gets or sets the path to the logout page.
        /// </summary>
        public string LogoutCallbackPath { get; set; } = RemoteAuthenticationDefaults.LogoutCallbackPath;

        /// <summary>
        /// Gets or sets the path to the logout page.
        /// </summary>
        public string LogoutFailedPath { get; set; } = RemoteAuthenticationDefaults.LogoutFailedPath;

        /// <summary>
        /// Gets or sets the path to the logout page.
        /// </summary>
        public string LogoutSucceededPath { get; set; } = RemoteAuthenticationDefaults.LogoutSucceededPath;
    }
}
