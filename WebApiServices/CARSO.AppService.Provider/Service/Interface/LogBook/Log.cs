using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Security.Principal;
using System.IO;
using System.Threading.Tasks;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.AppService.ServiceDataContainers;

namespace CARSO.AppService.Provider.Service
{
    public partial interface IAppService
    {
        [OperationContract]
        void Log(string method, string errMsg, string AppCode = "");
        [OperationContract]
        void LogEntry(CARSO.LogLibrary.ServiceOperations.LogEntry entry, string AppCode = "");
        [OperationContract]
        DataResponse AddPeriodoTransaccional(PeriodoTransaccional oPeriodoTransaccional);

    }
}
