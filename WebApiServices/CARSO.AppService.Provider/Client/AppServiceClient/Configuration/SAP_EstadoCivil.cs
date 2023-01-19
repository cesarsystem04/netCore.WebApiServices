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

        public DataResponse GetEstadoCivilByAll( ref EstadoCivilList oEstadoCivilListResponse)
        {
            return Channel.GetEstadoCivilByAll( ref oEstadoCivilListResponse);
        }

        public DataResponse GetEstadoCivilByKey(string codEstadoCivil, ref EstadoCivilList oEstadoCivilListResponse)
        {
            return Channel.GetEstadoCivilByKey(codEstadoCivil, ref oEstadoCivilListResponse);
        }




    }
}
