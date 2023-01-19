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
       public DataResponse RequestWebApiDel(Int64 idRequest)
        {
            return Channel.RequestWebApiDel(idRequest);
        }

       public DataResponse RequestWebApiAddUpdate(RequestWebApi oRequestWebApi)
        {
            return Channel.RequestWebApiAddUpdate(oRequestWebApi);
        }

       public DataResponse RequestWebApiGet(ref RequestWebApi oRequestWebApi, Int64 idRequest)
        {
            return Channel.RequestWebApiGet(ref oRequestWebApi, idRequest);
        }

       public DataResponse RequestWebApiGetByTicket(ref RequestWebApiList oRequestWebApiList, string idTicket)
        {
            return Channel.RequestWebApiGetByTicket(ref oRequestWebApiList, idTicket);
        }
    }
}
