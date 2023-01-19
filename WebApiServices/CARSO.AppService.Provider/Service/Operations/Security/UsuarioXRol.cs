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
        delegate DataResponse AddUsuarioXRolDelegate(TransactionalContext tx, UsuarioXRol oUsuarioXRol);
        public static DataResponse AddUsuarioXRol(TransactionalContext tx, UsuarioXRol oUsuarioXRol)
        {
            DataResponse oDataResponse = SecurityStore.AddUsuarioXRol(tx, oUsuarioXRol);
            return oDataResponse;
        }
        public DataResponse AddUsuarioXRol(UsuarioXRol oUsuarioXRol)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddUsuarioXRolDelegate(AddUsuarioXRol), oUsuarioXRol) as DataResponse;
        }

        delegate DataResponse GetUsuarioXRolByKeyDelegate(TransactionalContext tx, int codRol, string nbAlias, ref UsuarioXRolList oUsuarioXRolResponse);
        public static DataResponse GetUsuarioXRolGetByKey(TransactionalContext tx, int codRol, string nbAlias, ref UsuarioXRolList oUsuarioXRolResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetUsuarioXRolGetByKey(tx, codRol, nbAlias, oUsuarioXRolResponse);
            return oDataResponse;
        }
        public DataResponse GetUsuarioXRolGetByKey(int codRol, string nbAlias, ref UsuarioXRolList oUsuarioXRolResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetUsuarioXRolByKeyDelegate(GetUsuarioXRolGetByKey), codRol, nbAlias, oUsuarioXRolResponse) as DataResponse;
        }


        delegate DataResponse GetUsuarioXRolByAliasDelegate(TransactionalContext tx, string codAplicacion, string nbAlias, ref UsuarioXRolList oUsuarioXRolResponse);
        public static DataResponse GetUsuarioXRolByAlias(TransactionalContext tx, string codAplicacion, string nbAlias, ref UsuarioXRolList oUsuarioXRolResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetUsuarioXRolByAlias(tx, codAplicacion, nbAlias, oUsuarioXRolResponse);
            return oDataResponse;
        }
        public DataResponse GetUsuarioXRolByAlias(string codAplicacion, string nbAlias, ref UsuarioXRolList oUsuarioXRolResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetUsuarioXRolByAliasDelegate(GetUsuarioXRolByAlias), codAplicacion, nbAlias, oUsuarioXRolResponse) as DataResponse;
        }




        delegate DataResponse DelUsuarioXRolDelegate(TransactionalContext tx, int codRol, string nbAlias);
        public static DataResponse DelUsuarioXRol(TransactionalContext tx, int codRol, string nbAlias)
        {
            DataResponse oDataResponse = SecurityStore.DelUsuarioXRol(tx, codRol, nbAlias);
            return oDataResponse;
        }
        public DataResponse DelUsuarioXRol(int codRol, string nbAlias)
        {
            return Processor.TransactionalRootObject_QueryOperation(new DelUsuarioXRolDelegate(DelUsuarioXRol), codRol, nbAlias) as DataResponse;
        }

        delegate DataResponse DelUsuarioXRolBynbAliasDelegate(TransactionalContext tx, string nbAlias, string codAplicacion);
        public static DataResponse DelUsuarioXRolBynbAlias(TransactionalContext tx, string nbAlias, string codAplicacion)
        {
            DataResponse oDataResponse = SecurityStore.DelUsuarioXRolBynbAlias(tx, nbAlias, codAplicacion);
            return oDataResponse;
        }
        public DataResponse DelUsuarioXRolBynbAlias(string nbAlias, string codAplicacion)
        {
            return Processor.TransactionalRootObject_QueryOperation(new DelUsuarioXRolBynbAliasDelegate(DelUsuarioXRolBynbAlias), nbAlias, codAplicacion) as DataResponse;
        }

    }
}