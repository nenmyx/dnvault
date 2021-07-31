using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

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
        private static Uri IndexUri = new Uri("cgi-bin/list");
        private static Uri SaveUri = new Uri("cgi-bin/save");
        private static Uri RetrieveUri = new Uri("cgi-bin/retrieve");

        public Vault(string userkey, string host)
        {
            UserKey = userkey;

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(host);
            _httpClient.DefaultRequestHeaders.Add("Authorization", userkey);
        }

        /// <summary>
        /// Fetch a list of remote files associated with your user key.
        /// </summary>
        /// <exception cref="System.InvalidOperationException"/>
        /// <exception cref="System.Net.Http.HttpRequestException"/>
        /// <exception cref="System.Threading.Tasks.TaskCanceledException"/>
        /// <returns>Collection of filenames.</returns>
        public Task<List<string>> FetchIndex()
        {
            var response = _httpClient.GetAsync(IndexUri);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save a file to the remote.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="content"></param>
        public Task Save(string fileName, byte[] content)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove a file from the remote.
        /// </summary>
        /// <param name="fileName"></param>
        public Task Delete(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fetch a file from the remote.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public Task<byte[]> Retrieve(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
