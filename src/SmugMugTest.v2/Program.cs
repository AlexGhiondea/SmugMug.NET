using SmugMug.v2.Authentication;
using SmugMug.v2.Authentication.Tokens;
using SmugMug.v2.Types;
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
        }
    }
}
