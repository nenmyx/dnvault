using System;
using System.Collections.Generic;
using System.Net.Http;

namespace DNVault
{
    public class Vault : HttpClient, IVault
    {
        public string UserKey {get;private set;}
        public Uri Host {get;private set;}

        public Vault(string userkey, string  host)
        {
            UserKey = userkey;
            Host = new Uri(host);
        }

        public List<string> FetchIndex()
        {
            throw new NotImplementedException();
        }
    }
}
