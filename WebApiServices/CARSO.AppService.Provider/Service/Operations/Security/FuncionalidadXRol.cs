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
        delegate DataResponse AddFuncionalidadXRolDelegate(TransactionalContext tx, FuncionalidadXRol oFuncionalidadXRol);
        public static DataResponse AddFuncionalidadXRol(TransactionalContext tx, FuncionalidadXRol oFuncionalidadXRol)
        {
            DataResponse oDataResponse = SecurityStore.AddFuncionalidadXRol(tx, oFuncionalidadXRol);
            return oDataResponse;
        }
        public DataResponse AddFuncionalidadXRol(FuncionalidadXRol oFuncionalidadXRol)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddFuncionalidadXRolDelegate(AddFuncionalidadXRol), oFuncionalidadXRol) as DataResponse;
        }

        delegate DataResponse GetFuncionalidadXRolAllDelegate(TransactionalContext tx, ref FuncionalidadXRolList oFuncionalidadXRolListResponse);
        public static DataResponse GetFuncionalidadXRolAll(TransactionalContext tx, ref FuncionalidadXRolList oFuncionalidadXRolListResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetFuncionalidadXRolAll(tx, oFuncionalidadXRolListResponse);
            return oDataResponse;
        }
        public DataResponse GetFuncionalidadXRolAll(ref FuncionalidadXRolList oFuncionalidadXRolListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetFuncionalidadXRolAllDelegate(GetFuncionalidadXRolAll), oFuncionalidadXRolListResponse) as DataResponse;
        }

        delegate DataResponse GetFuncionalidadXRolByKeyDelegate(TransactionalContext tx, int codRol, int idFuncionalidad, string cvDominio, ref FuncionalidadXRol oFuncionalidadXRolResponse);
        public static DataResponse GetFuncionalidadXRolByKey(TransactionalContext tx, int codRol, int idFuncionalidad, string cvDominio, ref FuncionalidadXRol oFuncionalidadXRolResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetFuncionalidadXRolByKey(tx, codRol, idFuncionalidad, cvDominio, oFuncionalidadXRolResponse);
            return oDataResponse;
        }
        public DataResponse GetFuncionalidadXRolByKey(int codRol, int idFuncionalidad, string cvDominio, ref FuncionalidadXRol oFuncionalidadXRolResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetFuncionalidadXRolByKeyDelegate(GetFuncionalidadXRolByKey), codRol, idFuncionalidad, cvDominio, oFuncionalidadXRolResponse) as DataResponse;
        }

        delegate DataResponse GetFuncionalidadXRolByUserAndFuncionalidadDelegate(TransactionalContext tx, string nbAlias, int idFuncionalidad, string codAplicacion, ref FuncionalidadXRol oFuncionalidadXRolResponse);
        public static DataResponse GetFuncionalidadXRolByUserAndFuncionalidad(TransactionalContext tx, string nbAlias, int idFuncionalidad, string codAplicacion, ref FuncionalidadXRol oFuncionalidadXRolResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetFuncionalidadXRolByUserAndFuncionalidad(tx, nbAlias, idFuncionalidad, codAplicacion, oFuncionalidadXRolResponse);
            return oDataResponse;
        }
        public DataResponse GetFuncionalidadXRolByUserAndFuncionalidad(string nbAlias, int idFuncionalidad, string codAplicacion, ref FuncionalidadXRol oFuncionalidadXRolResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetFuncionalidadXRolByUserAndFuncionalidadDelegate(GetFuncionalidadXRolByUserAndFuncionalidad), nbAlias, idFuncionalidad, codAplicacion, oFuncionalidadXRolResponse) as DataResponse;
        }

        delegate DataResponse GetFuncionalidadXRolByUserAndComponenteDelegate(TransactionalContext tx, string nbAlias, string nbComponente, ref FuncionalidadXRol oFuncionalidadXRolResponse);
        public static DataResponse GetFuncionalidadXRolByUserAndComponente(TransactionalContext tx, string nbAlias, string nbComponente, ref FuncionalidadXRol oFuncionalidadXRolResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetFuncionalidadXRolByUserAndComponente(tx, nbAlias, nbComponente, oFuncionalidadXRolResponse);
            return oDataResponse;
        }
        public DataResponse GetFuncionalidadXRolByUserAndComponente(string nbAlias, string nbComponente, ref FuncionalidadXRol oFuncionalidadXRolResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetFuncionalidadXRolByUserAndComponenteDelegate(GetFuncionalidadXRolByUserAndComponente), nbAlias, nbComponente, oFuncionalidadXRolResponse) as DataResponse;
        }

        delegate DataResponse GetFuncionalidadXRolByPKDelegate(TransactionalContext tx, int codRol, int idFuncionalidad, string cvDominio, ref FuncionalidadXRol oFuncionalidadXRolResponse);
        public static DataResponse GetFuncionalidadXRolByPK(TransactionalContext tx, int codRol, int idFuncionalidad, string cvDominio, ref FuncionalidadXRol oFuncionalidadXRolResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetFuncionalidadXRolByPK(tx, codRol, idFuncionalidad, cvDominio, oFuncionalidadXRolResponse);
            return oDataResponse;
        }
        public DataResponse GetFuncionalidadXRolByPK(int codRol, int idFuncionalidad, string cvDominio, ref FuncionalidadXRol oFuncionalidadXRolResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetFuncionalidadXRolByPKDelegate(GetFuncionalidadXRolByPK), codRol, idFuncionalidad, cvDominio, oFuncionalidadXRolResponse) as DataResponse;
        }

        delegate DataResponse DelFuncionalidadXRolDelegate(TransactionalContext tx, int codRol, string cvDominio);
        public static DataResponse DelFuncionalidadXRol(TransactionalContext tx, int codRol, string cvDominio)
        {
            DataResponse oDataResponse = SecurityStore.DelFuncionalidadXRol(tx, codRol, cvDominio);
            return oDataResponse;
        }
        public DataResponse DelFuncionalidadXRol(int codRol, string cvDominio)
        {
            return Processor.TransactionalRootObject_QueryOperation(new DelFuncionalidadXRolDelegate(DelFuncionalidadXRol), codRol, cvDominio) as DataResponse;
        }
    }
}