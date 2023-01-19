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
        DataResponse AddRol(Rol oRol);
        [OperationContract()]
        DataResponse GetRolAll(int Estatus, string codAplicacion, ref RolList oRolListResponse);
        [OperationContract()]
        DataResponse GetRolByKey(int idRol, ref Rol oRolResponse);
        [OperationContract()]
        DataResponse GetRolByAlias(string nbAlias, string codAplicacion, ref RolList oRolListResponse);
        [OperationContract()]
        DataResponse GetRolOfUser(string nbAlias, string codAplicacion, ref RolList oRolListResponse);
        [OperationContract()]
        DataResponse GetRolByCriterio(ref RolList oRolListResponse, string codAplicacion, int estatus = -1, string nbRol = "", string dsRol = "");
    
    }
}
