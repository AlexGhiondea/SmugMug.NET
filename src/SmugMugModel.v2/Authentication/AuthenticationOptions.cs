// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace SmugMug.v2.Authentication
{
    public class AuthenticationOptions
    {
        public static readonly AuthenticationOptions Default = new AuthenticationOptions();

        public static readonly AuthenticationOptions FullAccess = new AuthenticationOptions() { Access = AccessLevel.Full, Permission = PermissionLevel.Modify };

        public PermissionLevel? Permission { get; set; }

        public AccessLevel? Access { get; set; }

        /// <summary>
        /// To allow use of third-party logins (like Facebook)
        /// </summary>
        public bool? AllowThirdPartyLogin { get; set; }

        /// <summary>
        /// To display the sign-up button on the login page
        /// </summary>
        public bool? ShowSignUpButton { get; set; }

        /// <summary>
        /// To pre-populate the email/nickname field
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Scale factor for mobile devices to inject into the viewport meta tag (0.0 to 1.0)
        /// </summary>
        public float? ViewportScale { get; set; }

        public string AsQueryString()
        {
            List<string> options = new List<string>();

            if (Access != null)
            {
                options.Add(string.Format("Access={0}", Access));
            }

            if (Permission != null)
            {
                options.Add(string.Format("Permissions={0}", Permission));
            }

            if (AllowThirdPartyLogin != null)
            {
                options.Add(string.Format("allowThirdPartyLogin={0}", (bool)AllowThirdPartyLogin ? 1 : 0));
            }

            if (ShowSignUpButton != null)
            {
                options.Add(string.Format("showSignUpButton={0}", ShowSignUpButton));
            }

            if (UserName != null)
            {
                options.Add(string.Format("username", UserName));
            }

            if (ViewportScale != null)
            {
                options.Add(string.Format("viewportScale", ViewportScale));
            }

            return string.Join("&", options);
        }
    }
}
