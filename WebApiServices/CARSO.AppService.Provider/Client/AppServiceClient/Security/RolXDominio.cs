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
        public DataResponse AddRolXDominio(RolXDominio oRolXDominio)
        {
            return Channel.AddRolXDominio(oRolXDominio);
        }

        public DataResponse GetRolXDominioByKey(int codRol, string cvDominio, ref RolXDominio oRolXDominioResponse)
        {
            return Channel.GetRolXDominioByKey(codRol, cvDominio, ref oRolXDominioResponse);
        }

    }
}
