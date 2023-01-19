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
        DataResponse RequestWebApiDel(Int64 idRequest);
        [OperationContract]
        DataResponse RequestWebApiAddUpdate(RequestWebApi oRequestWebApi);
        [OperationContract]
        DataResponse RequestWebApiGet(ref RequestWebApi oRequestWebApi, Int64 idRequest);
        [OperationContract]
        DataResponse RequestWebApiGetByTicket(ref RequestWebApiList oRequestWebApiList, string idTicket);
    }
}
