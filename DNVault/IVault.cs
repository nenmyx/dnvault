using System.Collections.Generic;

namespace DNVault
{
    interface IVault
    {
        List<string> FetchIndex();
    }
}