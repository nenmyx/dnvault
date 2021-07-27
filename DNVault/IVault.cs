using System.Collections.Generic;

namespace DNVault
{
    /// <summary>
    /// Represents a client capable of interacting with a Vault instance.
    /// </summary>
    interface IVault
    {
        /// <summary>
        /// Fetch a list of remote files associated with your user key.
        /// </summary>
        /// <returns>Collection of filenames.</returns>
        List<string> FetchIndex();
    }
}