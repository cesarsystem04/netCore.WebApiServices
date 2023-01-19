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
        DataResponse AddUsuarioXRol(UsuarioXRol oUsuarioXRol);
        [OperationContract()]
        DataResponse GetUsuarioXRolGetByKey(int codRol, string nbAlias, ref UsuarioXRolList oUsuarioXRolListResponse);

        [OperationContract()]
        DataResponse DelUsuarioXRol(int codRol, string nbAlias);

        [OperationContract()]
        DataResponse DelUsuarioXRolBynbAlias(string nbAlias, string codAplicacion);

    }
}
