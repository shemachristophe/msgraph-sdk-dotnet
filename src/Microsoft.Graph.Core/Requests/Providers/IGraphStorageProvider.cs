using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Graph
{
    public interface IGraphStorageProvider
    {
        Task SetStorageItemAsync(string itemId, object item);
        Task<object> GetStorageItemAsync(string itemId);
    }
}
