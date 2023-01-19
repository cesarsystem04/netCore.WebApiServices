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
       
        public DataResponse GetEstadoAll( ref EstadoList oEstadoListResponse)
        {
            return Channel.GetEstadoAll( ref oEstadoListResponse);
        }

        public DataResponse GetEstadoByEstado(string codEstado, ref EstadoList oEstadoListResponse)
        {
            return Channel.GetEstadoByEstado(codEstado, ref oEstadoListResponse);
        }

        public DataResponse GetEstadoByKey(string codEstado, string codMunicipio, ref Estado oEstadoListResponse)
        {
            return Channel.GetEstadoByKey(codEstado, codMunicipio, ref oEstadoListResponse);
        }

    

    }
}
