using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncVsAsyncBouncyBox;

public interface IDatabase
{
    string GetSync(int index);
    Task<string> GetSyncAsync(int index);
}
