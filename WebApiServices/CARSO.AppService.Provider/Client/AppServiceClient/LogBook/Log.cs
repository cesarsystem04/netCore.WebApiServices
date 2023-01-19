using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Security.Principal;
using System.IO;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.AppService.Provider.Service;
using CARSO.AppService.ServiceDataContainers;
using System.Threading.Tasks;

namespace CARSO.AppService.Provider.Client
{
    public partial class AppServiceClient : ClientBase<IAppService>, IAppService
    {
        public void Log(string method, string errMsg, string AppCode = "")
        {
            Channel.Log(method, errMsg, AppCode);
        }

        public void LogEntry(LogLibrary.ServiceOperations.LogEntry entry, string AppCode = "")
        {
            Channel.LogEntry(entry, AppCode);
        }

    }
}
