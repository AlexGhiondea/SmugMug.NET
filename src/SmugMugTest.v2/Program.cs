using SmugMug.v2.Authentication;
using SmugMug.v2.Authentication.Tokens;
using System.Diagnostics;

namespace SmugMugTest
{
    class Program
    {
        private static OAuthToken s_oauthToken;

        static void Main(string[] args)
        {
            s_oauthToken = ConsoleAuthentication.GetOAuthToken(new FileTokenProvider());
            Debug.Assert(!s_oauthToken.Equals(OAuthToken.Invalid));


        }
    }
}
