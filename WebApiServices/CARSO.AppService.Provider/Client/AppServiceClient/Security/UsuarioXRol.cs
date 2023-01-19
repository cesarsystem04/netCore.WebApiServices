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
        public DataResponse AddUsuarioXRol(UsuarioXRol oUsuarioXRol)
        {
            return Channel.AddUsuarioXRol(oUsuarioXRol);
        }

        public DataResponse GetUsuarioXRolGetByKey(int codRol, string nbAlias, ref UsuarioXRolList oUsuarioXRolListResponse)
        {
            return Channel.GetUsuarioXRolGetByKey(codRol, nbAlias, ref oUsuarioXRolListResponse);
        }

        public DataResponse DelUsuarioXRol(int codRol, string nbAlias)
        {
            return Channel.DelUsuarioXRol(codRol, nbAlias);
        }
        public DataResponse DelUsuarioXRolBynbAlias(string nbAlias,string codAplicacion)
        {
            return Channel.DelUsuarioXRolBynbAlias(nbAlias, codAplicacion);
        }

    }
}
