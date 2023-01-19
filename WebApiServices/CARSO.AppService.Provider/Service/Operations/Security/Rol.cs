using System;
using System.Security.Principal;
using System.Runtime.InteropServices;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.LogLibrary.ServiceOperations;
using System.Threading.Tasks;
using CARSO.AppService.ServiceDataContainers;
using CARSO.AppService.ServiceDataAccess;
using System.Configuration;

namespace CARSO.AppService.Provider.Service
{
    public partial class AppService : IAppService
    {
        delegate DataResponse AddRolDelegate(TransactionalContext tx, Rol oRol);
        public static DataResponse AddRol(TransactionalContext tx, Rol oRol)
        {
            DataResponse oDataResponse = SecurityStore.AddRol(tx, oRol);
            return oDataResponse;
        }
        public DataResponse AddRol(Rol oRol)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddRolDelegate(AddRol), oRol) as DataResponse;
        }

        delegate DataResponse GetRolAllDelegate(TransactionalContext tx, int Estatus, string codAplicacion, ref RolList oRolListResponse);
        public static DataResponse GetRolAll(TransactionalContext tx, int Estatus, string codAplicacion, ref RolList oRolListResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetRolAll(tx, Estatus, codAplicacion, oRolListResponse);
            return oDataResponse;
        }
        public DataResponse GetRolAll(int Estatus, string codAplicacion, ref RolList oRolListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetRolAllDelegate(GetRolAll), Estatus, codAplicacion, oRolListResponse) as DataResponse;
        }

        delegate DataResponse GetRolByKeyDelegate(TransactionalContext tx, int idRol, ref Rol oRolResponse);
        public static DataResponse GetRolByKey(TransactionalContext tx, int idRol, ref Rol oRolResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetRolByKey(tx, idRol, oRolResponse);
            return oDataResponse;
        }
        public DataResponse GetRolByKey(int idRol, ref Rol oRolResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetRolByKeyDelegate(GetRolByKey), idRol, oRolResponse) as DataResponse;
        }

        delegate DataResponse GetRolByAliasDelegate(TransactionalContext tx, string nbAlias, string codAplicacion, ref RolList oRolListResponse);
        public static DataResponse GetRolByAlias(TransactionalContext tx, string nbAlias, string codAplicacion, ref RolList oRolListResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetRolByAlias(tx, nbAlias, codAplicacion, oRolListResponse);
            return oDataResponse;
        }
        public DataResponse GetRolByAlias(string nbAlias, string codAplicacion, ref RolList oRolListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetRolByAliasDelegate(GetRolByAlias), nbAlias, codAplicacion, oRolListResponse) as DataResponse;
        }

        delegate DataResponse GetRolOfUserDelegate(TransactionalContext tx, string nbAlias, string codAplicacion, ref RolList oRolListResponse);
        public static DataResponse GetRolOfUser(TransactionalContext tx, string nbAlias, string codAplicacion, ref RolList oRolListResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetRolOfUser(tx, nbAlias, codAplicacion, oRolListResponse);
            return oDataResponse;
        }
        public DataResponse GetRolOfUser(string nbAlias, string codAplicacion, ref RolList oRolListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetRolOfUserDelegate(GetRolOfUser), nbAlias, codAplicacion, oRolListResponse) as DataResponse;
        }

        delegate DataResponse GetRolByCriterioDelegate(TransactionalContext tx, ref RolList oRolListResponse, string codAplicacion, int estatus = -1, string nbRol = "", string dsRol = "");
        public static DataResponse GetRolByCriterio(TransactionalContext tx, ref RolList oRolListResponse, string codAplicacion, int estatus = -1, string nbRol = "", string dsRol = "")
        {
            DataResponse oDataResponse = SecurityStore.GetRolByCriterio(tx, oRolListResponse, codAplicacion, estatus, nbRol, dsRol);
            return oDataResponse;
        }
        public DataResponse GetRolByCriterio(ref RolList oRolListResponse, string codAplicacion, int estatus = -1, string nbRol = "", string dsRol = "")
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetRolByCriterioDelegate(GetRolByCriterio), oRolListResponse, codAplicacion, estatus, nbRol, dsRol) as DataResponse;
        }
    }
}