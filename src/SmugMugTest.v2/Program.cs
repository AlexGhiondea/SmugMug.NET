using SmugMug.v2.Authentication;
using SmugMug.v2.Authentication.Tokens;
using SmugMug.v2.Types;
using System;
using System.Diagnostics;

namespace SmugMugTest
{
    class Program
    {
        private static OAuthToken s_oauthToken;

        static void Main(string[] args)
        {
            s_oauthToken = ConsoleAuthentication.GetOAuthTokenFromProvider(new FileTokenProvider());
            Debug.Assert(!s_oauthToken.Equals(OAuthToken.Invalid));

            SiteEntity site = new SiteEntity(s_oauthToken);
            var user = site.GetAuthenticatedUserAsync().Result;

            var rootNode = user.GetRootNodeAsync().Result;

            System.Console.WriteLine(user.Name);

            foreach (var folder in rootNode.GetFoldersAsync().Result)
            {
                Console.WriteLine($"Folder: {folder.Name}");
            }

            foreach (var album in rootNode.GetAlbumsAsync().Result)
            {
                Console.WriteLine($"Album: {album.Name}");
            }

        }
    }
}
