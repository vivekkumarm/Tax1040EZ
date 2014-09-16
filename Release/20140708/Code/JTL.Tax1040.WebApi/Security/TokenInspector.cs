using JTL.Tax1040.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace JTL.Tax1040.WebApi.Security
{
    public class TokenInspector : System.Net.Http.DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            const string TOKEN_NAME = "X-Token";
            string encryptedToken = string.Empty;

            Token token = null;
            //  CheckFormAuth(request);
            if (request.Headers.Contains(TOKEN_NAME))
            {
                encryptedToken = request.Headers.GetValues(TOKEN_NAME).First();
                try
                {
                    token = Token.Decrypt(encryptedToken);
                    bool isValidUserId = false;

                    IUserRepository userRepository = new UserRepository();
                    isValidUserId = userRepository.ValidUserID(Convert.ToInt64(token.UserId));


                    bool requestIPMatchesTokenIP = token.IP.Equals(request.GetClientIP());

                    //System.Security.Principal.GenericPrincipal principal = new System.Security.Principal.GenericPrincipal(
                    //    new System.Security.Principal.GenericIdentity(token.UserId),
                    //    new String[1] { token.AccessLevel });
                    //HttpContext.Current.User = principal;
                    //Thread.CurrentPrincipal = principal;

                    if (!isValidUserId || !requestIPMatchesTokenIP)
                    {
                        HttpResponseMessage reply = request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Invalid indentity or client machine.");
                        return Task.FromResult(reply);
                    }
                }
                catch (Exception ex)
                {
                    HttpResponseMessage reply = request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Invalid token." + ex.Message);
                    return Task.FromResult(reply);
                }
            }
            else
            {
                HttpResponseMessage reply = request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Request is missing authorization token.");
                return Task.FromResult(reply);
            }

            return base.SendAsync(request, cancellationToken);
        }

        public void CheckFormAuth(HttpRequestMessage request)
        {
            string cookieName = FormsAuthentication.FormsCookieName;
            HttpCookie authCookie = HttpContext.Current.Request.Cookies[cookieName];

            if (null == authCookie)
            {
                //// There is no authentication cookie.
                return;

            }

            FormsAuthenticationTicket authTicket = null;
            try
            {
                authTicket = FormsAuthentication.Decrypt(authCookie.Value);
            }
            catch (Exception ex)
            {
                return;
            }

            if (null == authTicket)
            {
                // Cookie failed to decrypt.
                return;

            }

            //string[] roles = new string[1];
            //roles[0] = authTicket.UserData;
            //FormsIdentity id = new FormsIdentity(authTicket);
            //System.Security.Principal.GenericPrincipal principal = new System.Security.Principal.GenericPrincipal(id, roles);
            //HttpContext.Current.User = principal;
            //Thread.CurrentPrincipal = principal;

        }
    }



    public static class Extensions
    {
        public static string GetClientIP(this HttpRequestMessage request)
        {
            return ((HttpContextWrapper)request.Properties["MS_HttpContext"]).Request.UserHostAddress;
        }

        public static Dictionary<string, string> ToDictionary(this string keyValue)
        {
            return keyValue.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(part => part.Split('='))
                          .ToDictionary(split => split[0], split => split[1]);
        }
    }

    public class Token
    {
        public Token(string userId, string fromIP)//, string accessLevel)
        {
            UserId = userId;
            IP = fromIP;
          //  AccessLevel = accessLevel;
        }

        public string UserId { get; private set; }
        public string IP { get; private set; }
        //     public string AccessLevel { get; private set; }
        public string Encrypt()
        {
            CryptographyHelper cryptographyHelper = new CryptographyHelper();
            X509Certificate2 certificate = cryptographyHelper.GetX509Certificate("CN=WebAPI-Token");
            return cryptographyHelper.Encrypt(certificate, this.ToString());
        }

        public override string ToString()
        {
            return String.Format("UserId={0};IP={1}", this.UserId, this.IP);
            // return String.Format("UserId={0};IP={1};AccessLevel={2}", this.UserId, this.IP, this.AccessLevel);
        }

        public static Token Decrypt(string encryptedToken)
        {
            CryptographyHelper cryptographyHelper = new CryptographyHelper();
            X509Certificate2 certificate = cryptographyHelper.GetX509Certificate("CN=WebAPI-Token");
            string decrypted = cryptographyHelper.Decrypt(certificate, encryptedToken);
            Dictionary<string, string> encrypt = decrypted.ToDictionary();
            // return new Token(encrypt["UserId"], encrypt["IP"], encrypt["AccessLevel"]);
            return new Token(encrypt["UserId"], encrypt["IP"]);
        }
    }

    public class CryptographyHelper
    {
        public X509Certificate2 GetX509Certificate(string subjectName)
        {
            X509Store certificateStore = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            certificateStore.Open(OpenFlags.ReadOnly);
            X509Certificate2 certificate;

            try
            {
                certificate = certificateStore.Certificates.OfType<X509Certificate2>().FirstOrDefault(cert => cert.SubjectName.Name.Equals(subjectName, StringComparison.OrdinalIgnoreCase));

                if (certificate == null)
                {
                    certificateStore = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                    certificateStore.Open(OpenFlags.ReadOnly);
                    certificate = certificateStore.Certificates.OfType<X509Certificate2>().FirstOrDefault(cert => cert.SubjectName.Name.Equals(subjectName, StringComparison.OrdinalIgnoreCase));
                }

            }
            finally
            {
                certificateStore.Close();
            }

            if (certificate == null)
                throw new Exception(String.Format("Certificate '{0}' is not found.", subjectName));

            return certificate;
        }

        public string Encrypt(X509Certificate2 certificate, string plainToken)
        {
            RSACryptoServiceProvider cryptoProvidor = (RSACryptoServiceProvider)certificate.PublicKey.Key;
            byte[] encryptedTokenBytes = cryptoProvidor.Encrypt(Encoding.UTF8.GetBytes(plainToken), true);
            return Convert.ToBase64String(encryptedTokenBytes);
        }

        public string Decrypt(X509Certificate2 certificate, string encryptedToken)
        {
            RSACryptoServiceProvider cryptoProvidor = (RSACryptoServiceProvider)certificate.PrivateKey;
            byte[] decryptedTokenBytes = cryptoProvidor.Decrypt(Convert.FromBase64String(encryptedToken), true);
            return Encoding.UTF8.GetString(decryptedTokenBytes);
        }
    }
}