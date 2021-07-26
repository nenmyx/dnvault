using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DNVault
{
    public class Vault : IVault
    {
        public string UserKey {get;private set;}
        private HttpClient _httpClient;

        public Vault(string userkey, string  host)
        {
            UserKey = userkey;

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(host);
            _httpClient.DefaultRequestHeaders.Add("Authorization", userkey);
        }

        public List<string> FetchIndex()
        {
            throw new NotImplementedException();
        }
    }
}
