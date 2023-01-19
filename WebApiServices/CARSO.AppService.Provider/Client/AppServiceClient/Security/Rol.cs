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
        public DataResponse AddRol(Rol oRol)
        {
            return Channel.AddRol(oRol);
        }

        public DataResponse GetRolAll(int Estatus, string codAplicacion, ref RolList oRolListResponse)
        {
            return Channel.GetRolAll(Estatus, codAplicacion, ref oRolListResponse);
        }

        public DataResponse GetRolByKey(int idRol, ref Rol oRolResponse)
        {
            return Channel.GetRolByKey(idRol, ref oRolResponse);
        }

        public DataResponse GetRolByAlias(string nbAlias, string codAplicacion, ref RolList oRolListResponse)
        {
            return Channel.GetRolByAlias(nbAlias, codAplicacion, ref oRolListResponse);
        }

        public DataResponse GetRolOfUser(string nbAlias, string codAplicacion, ref RolList oRolListResponse)
        {
            return Channel.GetRolOfUser(nbAlias, codAplicacion, ref oRolListResponse);
        }

        public DataResponse GetRolByCriterio(ref RolList oRolListResponse, string codAplicacion, int estatus = -1, string nbRol = "", string dsRol = "")
        {
            return Channel.GetRolByCriterio(ref oRolListResponse, codAplicacion, estatus, nbRol, dsRol);
        }
    }
}
