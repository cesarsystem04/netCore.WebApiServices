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

        public DataResponse GetJerarquiaAll(ref JerarquiaList oJerarquiaListResponse)
        {
            return Channel.GetJerarquiaAll( ref oJerarquiaListResponse);
        }

        public DataResponse GetJerarquiaByKey(string codJerarquia, ref Jerarquia oJerarquiaListResponse)
        {
            return Channel.GetJerarquiaByKey(codJerarquia, ref oJerarquiaListResponse);
        }


    }
}
