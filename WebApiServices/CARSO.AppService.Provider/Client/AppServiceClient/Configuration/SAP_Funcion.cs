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
  
        public DataResponse GetFuncionAll( ref FuncionList oFuncionListResponse)
        {
            return Channel.GetFuncionAll( ref oFuncionListResponse);
        }

        public DataResponse GetFuncionByKey(string codFuncion, ref Funcion oFuncionListResponse)
        {
            return Channel.GetFuncionByKey(codFuncion, ref oFuncionListResponse);
        }

      

    }
}
