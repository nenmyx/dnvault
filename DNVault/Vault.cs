using System;
using System.Collections.Generic;
using System.Net.Http;

namespace DNVault
{
    /// <summary>
    /// Base IVault implementation.
    /// </summary>
    public class Vault : IVault
    {
        /// <summary>
        /// Vault user key, get this from your administrator.
        /// Refer to Vault documentation if you are that administrator.
        /// </summary>
        public string UserKey {get;private set;}
        private HttpClient _httpClient;

        public Vault(string userkey, string host)
        {
            UserKey = userkey;

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(host);
            _httpClient.DefaultRequestHeaders.Add("Authorization", userkey);
        }

        public List<string> FetchIndex()
        {
            // TODO Olivia: this
            throw new NotImplementedException();
        }
    }
}
