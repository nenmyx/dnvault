using System.Collections.Generic;
using System.Threading.Tasks;

namespace DNVault
{
    /// <summary>
    /// Represents a client capable of interacting with a Vault instance.
    /// </summary>
    interface IVault
    {
        Task<List<string>> FetchIndex();
        Task Save(string fileName, byte[] content);
        Task Delete(string fileName);
        Task<byte[]> Retrieve(string fileName);
    }
}