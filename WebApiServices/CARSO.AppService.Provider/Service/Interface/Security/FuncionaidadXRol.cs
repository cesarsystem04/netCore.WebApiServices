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
        DataResponse AddFuncionalidadXRol(FuncionalidadXRol oFuncionalidadXRol);
        [OperationContract()]
        DataResponse GetFuncionalidadXRolAll(ref FuncionalidadXRolList oFuncionalidadXRolListResponse);
        [OperationContract()]
        DataResponse GetFuncionalidadXRolByKey(int codRol, int idFuncionalidad, string cvDominio, ref FuncionalidadXRol oFuncionalidadXRolResponse);
        [OperationContract()]
        DataResponse GetFuncionalidadXRolByUserAndFuncionalidad(string nbAlias, int idFuncionalidad, string codAplicacion, ref FuncionalidadXRol oFuncionalidadXRolResponse);
        [OperationContract()]
        DataResponse GetFuncionalidadXRolByUserAndComponente(string nbAlias, string nbComponente, ref FuncionalidadXRol oFuncionalidadXRolResponse);
        [OperationContract()]
        DataResponse GetFuncionalidadXRolByPK(int codRol, int idFuncionalidad, string cvDominio, ref FuncionalidadXRol oFuncionalidadXRolResponse);
        [OperationContract()]
        DataResponse DelFuncionalidadXRol(int codRol, string cvDominio);

    }
}
