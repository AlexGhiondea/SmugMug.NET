using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SmugMugModel.Utility
{
    public class SmugMugAuthorize
    {
        const string authorizationUrl = "http://api.smugmug.com/services/oauth/authorize.mg";
        /// <summary>
        /// Use this method to authorize the application to SmugMug.
        /// </summary>
        public static Token AuthorizeSmugMug(Site smugmug)
        {
            Token reqTok = smugmug.GetRequestToken();

            Console.WriteLine("Press [Enter] after you authorized the application");
            Process proc = Process.Start(GetAuthorizationURL(reqTok, AccessEnum.Full, PermissionsEnum.Modify));
            Console.ReadLine();

            Token accessTok = smugmug.GetAccessToken(reqTok);

            return accessTok;
        }

        /// <summary>
        /// Generates an authorization URL based on the requestToken , requiredAccess and requiredPermissions
        /// </summary>
        public static string GetAuthorizationURL(Token requestToken, AccessEnum requiredAccess, PermissionsEnum requiredPermissions)
        {
            return string.Format("{0}?oauth_token={1}&Access={2}&Permissions={3}", authorizationUrl, requestToken.id, requiredAccess, requiredPermissions);
        }

    }
}