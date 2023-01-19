using System;
using System.Security.Principal;
using System.Runtime.InteropServices;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.LogLibrary.ServiceOperations;
using System.Threading.Tasks;
using CARSO.AppService.ServiceDataContainers;
using CARSO.AppService.ServiceDataAccess;
using System.Configuration;

namespace CARSO.AppService.Provider.Service
{
    public partial class AppService : IAppService
    {

        public void Log(string method, string errMsg, string AppCode = "")
        {
            ServiceDataAccess.LogBookStore.Log(method, errMsg, AppCode);
        }

        public void LogEntry(LogEntry entry, string AppCode = "")
        {
            ServiceDataAccess.LogBookStore.LogEntry(entry, AppCode);
        }

    }
}
