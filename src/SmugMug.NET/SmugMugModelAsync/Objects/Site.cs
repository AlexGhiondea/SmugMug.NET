using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace SmugMugModel
{
    public class Site
    {
        public static string APIKey { get; set; }
        public static string ApplicationSecret { get; set; }
        public Site(string ApiKey, string Secret)
        {
            APIKey = ApiKey;
            ApplicationSecret = Secret;
        }

        static public IWebProxy Proxy { get; set; }

        #region Sync
        /// <summary>
        /// Pings SmugMug
        /// </summary>
        /// <returns>Returns an empty successful response, if it completes without error.</returns>
        public bool Ping()
        {
            return PingAsync().Result;
        }

        /// <summary>
        /// Login to SmugMug using the accessToken
        /// </summary>
        public MyUser Login(Token accessToken)
        {
            if (accessToken == null)
                throw new ArgumentNullException("accessToken", "Cannot login with a null access token");

            // If we don't have the tokens
            if (accessToken.id == null || accessToken.Secret == null)
                return null;

            var oauthUser = CheckAccessToken(ref accessToken);

            if (oauthUser == null)
                return null;
            MyUser currentUser = CreateMyUser(accessToken, oauthUser);

            return currentUser;
        }

        private static MyUser CreateMyUser(Token accessToken, oAuthUser oauthUser)
        {
            MyUser currentUser = new MyUser();
            currentUser.AccountStatus = oauthUser.AccountStatus.ToString();
            currentUser.AccountType = oauthUser.AccountType.ToString();
            currentUser.DisplayName = oauthUser.Name;
            currentUser.FileSizeLimit = oauthUser.FileSizeLimit;
            currentUser.SmugVault = oauthUser.SmugVault;
            currentUser.URL = oauthUser.URL;
            currentUser.basic = new SmugMugBase();
            currentUser.basic.AccessToken = accessToken;
            currentUser.basic.NickName = oauthUser.NickName;
            currentUser.UserId = oauthUser.id;
            return currentUser;
        }

        /// <summary>
        /// Check if the token is still valid.
        /// </summary>
        private oAuthUser CheckAccessToken(ref Token accessToken)
        {
            CommunicationHelper ch = new CommunicationHelper();
            var auth = ch.ExecuteMethod<GetTokenResponse>("smugmug.auth.checkAccessToken",
                new SmugMugBase() { AccessToken = accessToken }, "oauth_token_secret", accessToken.Secret).Result;

            if (auth == null || auth.Auth == null)
            {
                return null;
            }

            // Update the token
            accessToken = auth.Auth.Token;

            return auth.Auth.User;
        }

        /// <summary>
        /// Get the request Token from SmugMug
        /// </summary>
        public Token GetRequestToken()
        {
            CommunicationHelper ch = new CommunicationHelper();
            var auth = ch.ExecuteMethod<GetTokenResponse>("smugmug.auth.getRequestToken", null).Result;
            return auth.Auth.Token;
        }

        /// <summary>
        /// Get the access Token from SmugMug
        /// </summary>
        public Token GetAccessToken(Token requestToken)
        {
            CommunicationHelper ch = new CommunicationHelper();
            SmugMugBase session = new SmugMugBase();
            session.AccessToken = requestToken;

            var auth = ch.ExecuteMethod<GetTokenResponse>("smugmug.auth.getAccessToken", session, "oauth_token_secret", requestToken.Secret).Result;
            return auth.Auth.Token;
        }

        /// <summary>
        /// Retrieves a list of style templates
        /// </summary>
        /// <returns>List of Templates (id and Name)</returns>
        public List<Template> StylesGetTemplates()
        {
            return StylesGetTemplatesAsync(false).Result;
        }

        /// <summary>
        /// Retrieves a list of style templates
        /// </summary>
        /// <param name="Associative">Returns an associative array. Default: false </param>
        /// <returns>List of Templates (id and Name)</returns>
        public List<Template> StylesGetTemplates(bool Associative)
        {
            return StylesGetTemplatesAsync(Associative).Result;
        }
        #endregion

        #region Async
        /// <summary>
        /// Pings SmugMug
        /// </summary>
        /// <returns>Returns an empty successful response, if it completes without error.</returns>
        public async Task<bool> PingAsync()
        {
            // APIKey [required], Callback, Pretty
            CommunicationHelper ch = new CommunicationHelper();
            var resp = await ch.ExecuteMethod<SmugMugResponse>("smugmug.service.ping", null);
            if (resp.stat == "ok")
                return true;
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }

        /// <summary>
        /// Login to SmugMug using the accessToken
        /// </summary>
        public async Task<MyUser> LoginAsync(Token accessToken)
        {
            //TODO: accessToken is not updated!!!
            var tuple = await CheckAccessTokenAsync(accessToken);
            //item1 = oauthUser
            //item2 = accessToken

            if (tuple.Item1 == null)
                return null;

            accessToken.Access = tuple.Item2.Access;
            accessToken.Permissions = tuple.Item2.Permissions;
            MyUser currentUser = CreateMyUser(accessToken, tuple.Item1);
            return currentUser;
        }

        /// <summary>
        /// Check if the token is still valid.
        /// </summary>
        private async Task<Tuple<oAuthUser, Token>> CheckAccessTokenAsync(Token accessToken)
        {
            CommunicationHelper ch = new CommunicationHelper();
            var auth = await ch.ExecuteMethod<GetTokenResponse>("smugmug.auth.checkAccessToken",
                new SmugMugBase() { AccessToken = accessToken }, "oauth_token_secret", accessToken.Secret);

            if (auth == null || auth.Auth == null)
            {
                return null;
            }

            // Update the token
            accessToken = auth.Auth.Token;

            return new Tuple<oAuthUser, Token>(auth.Auth.User, accessToken);
        }

        /// <summary>
        /// Get the request Token from SmugMug
        /// </summary>
        public async Task<Token> GetRequestTokenAsync()
        {
            CommunicationHelper ch = new CommunicationHelper();
            var auth = await ch.ExecuteMethod<GetTokenResponse>("smugmug.auth.getRequestToken", null);
            return auth.Auth.Token;
        }

        /// <summary>
        /// Get the access Token from SmugMug
        /// </summary>
        public async Task<Token> GetAccessTokenAsync(Token requestToken)
        {
            CommunicationHelper ch = new CommunicationHelper();
            SmugMugBase session = new SmugMugBase();
            session.AccessToken = requestToken;

            var auth = await ch.ExecuteMethod<GetTokenResponse>("smugmug.auth.getAccessToken", session, "oauth_token_secret", requestToken.Secret);
            return auth.Auth.Token;
        }

        /// <summary>
        /// Retrieves a list of style templates
        /// </summary>
        /// <returns>List of Templates (id and Name)</returns>
        public async Task<List<Template>> StylesGetTemplatesAsync()
        {
            return await StylesGetTemplatesAsync(false);
        }

        /// <summary>
        /// Retrieves a list of style templates
        /// </summary>
        /// <param name="Associative">Returns an associative array. Default: false </param>
        /// <returns>List of Templates (id and Name)</returns>
        public async Task<List<Template>> StylesGetTemplatesAsync(bool Associative)
        {
            CommunicationHelper ch = new CommunicationHelper();
            // Associative, Callback, Pretty, Strict
            var resp = await ch.ExecuteMethod<TemplateResponse>("smugmug.styles.getTemplates", null, "Associative", Associative);
            if (resp.stat == "ok")
            {
                var temp = new List<Template>();
                temp.AddRange(resp.Templates);
                return temp;
            }
            else
            {
                Console.WriteLine(resp.message);
                throw new SmugMugException(resp.code, resp.message, resp.method);
            }
        }
        #endregion
    }
}
