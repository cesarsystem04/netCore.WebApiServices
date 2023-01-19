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
        delegate DataResponse AddUsuarioDelegate(TransactionalContext tx, Usuario oUsuario, string codAplicacion);
        public static DataResponse AddUsuario(TransactionalContext tx, Usuario oUsuario, string codAplicacion)
        {
            DataResponse oDataResponse = SecurityStore.AddUsuario(tx, oUsuario, codAplicacion);
            return oDataResponse;
        }
        public DataResponse AddUsuario(Usuario oUsuario, string codAplicacion)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddUsuarioDelegate(AddUsuario), oUsuario, codAplicacion) as DataResponse;
        }


        delegate DataResponse GetUsuarioAllDelegate(TransactionalContext tx, int esActivo, ref UsuarioList oUsuarioListResponse);
        public static DataResponse GetUsuarioAll(TransactionalContext tx, int esActivo, ref UsuarioList oUsuarioListResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetUsuarioAll(tx, esActivo, oUsuarioListResponse);
            return oDataResponse;
        }
        public DataResponse GetUsuarioAll(int esActivo, ref UsuarioList oUsuarioListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetUsuarioAllDelegate(GetUsuarioAll), esActivo, oUsuarioListResponse) as DataResponse;
        }


        delegate DataResponse GetUsuarioByKeyDelegate(TransactionalContext tx, string nbAlias, ref Usuario oUsuarioResponse);
        public static DataResponse GetUsuarioByKey(TransactionalContext tx, string nbAlias, ref Usuario oUsuarioResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetUsuarioByKey(tx, nbAlias, oUsuarioResponse);
            return oDataResponse;
        } 
        public DataResponse GetUsuarioByKey(string nbAlias, ref Usuario oUsuarioResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetUsuarioByKeyDelegate(GetUsuarioByKey), nbAlias, oUsuarioResponse) as DataResponse;
        }


        delegate DataResponse GetUsuarioAllFiltroDelegate(TransactionalContext tx, ref UsuarioList oUsuarioListResponse);
        public static DataResponse GetUsuarioAllFiltro(TransactionalContext tx, ref UsuarioList oUsuarioListResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetUsuarioAllFiltro(tx, oUsuarioListResponse);
            return oDataResponse;
        }
        public DataResponse GetUsuarioAllFiltro(ref UsuarioList oUsuarioListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetUsuarioAllFiltroDelegate(GetUsuarioAllFiltro), oUsuarioListResponse) as DataResponse;
        }

        delegate DataResponse GetUsuarioForRolDelegate(TransactionalContext tx, int codRol, ref UsuarioList oUsuarioListResponse);
        public static DataResponse GetUsuarioForRol(TransactionalContext tx, int codRol, ref UsuarioList oUsuarioListResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetUsuarioForRol(tx, codRol, oUsuarioListResponse);
            return oDataResponse;
        }
        public DataResponse GetUsuarioForRol(int codRol, ref UsuarioList oUsuarioListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetUsuarioForRolDelegate(GetUsuarioForRol), codRol, oUsuarioListResponse) as DataResponse;
        }

        delegate DataResponse GetUsuarioForMonitorDelegate(TransactionalContext tx, ref UsuarioList oUsuarioListResponse);
        public static DataResponse GetUsuarioForMonitor(TransactionalContext tx, ref UsuarioList oUsuarioListResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetUsuarioForMonitor(tx, oUsuarioListResponse);
            return oDataResponse;
        }
        public DataResponse GetUsuarioForMonitor(ref UsuarioList oUsuarioListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetUsuarioForMonitorDelegate(GetUsuarioForMonitor), oUsuarioListResponse) as DataResponse;
        }

        delegate DataResponse GetUsuarioByRolAndCodDeptoDelegate(TransactionalContext tx, int codRol,string codDepto, ref UsuarioList oUsuarioListResponse);
        public static DataResponse GetUsuarioByRolAndCodDepto(TransactionalContext tx, int codRol,string codDepto, ref UsuarioList oUsuarioListResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetUsuarioByRolAndCodDepto(tx, codRol,codDepto, oUsuarioListResponse);
            return oDataResponse;
        }
        public DataResponse GetUsuarioByRolAndCodDepto(int codRol,string codDepto, ref UsuarioList oUsuarioListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetUsuarioByRolAndCodDeptoDelegate(GetUsuarioByRolAndCodDepto), codRol,codDepto, oUsuarioListResponse) as DataResponse;
        }



        delegate DataResponse GetUsuarioFindUsuarioDelegate(TransactionalContext tx, string nbAlias, string noEmpleado, string nbEmpleado, ref UsuarioList oUsuarioListResponse);
        public static DataResponse GetUsuarioFindUsuario(TransactionalContext tx, string nbAlias, string noEmpleado, string nbEmpleado, ref UsuarioList oUsuarioListResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetUsuarioFindUsuario(tx, nbAlias, noEmpleado, nbEmpleado, oUsuarioListResponse);
            return oDataResponse;
        }



        

        public DataResponse GetUsuarioFindUsuario(string nbAlias, string noEmpleado, string nbEmpleado, ref UsuarioList oUsuarioListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetUsuarioFindUsuarioDelegate(GetUsuarioFindUsuario), nbAlias, noEmpleado, nbEmpleado, oUsuarioListResponse) as DataResponse;
        }

        delegate DataResponse GetUsuarioBynoEmpleadoDelegate(TransactionalContext tx, string noEmpleado, ref Usuario oUsuarioResponse);
        public static DataResponse GetUsuarioBynoEmpleado(TransactionalContext tx, string noEmpleado, ref Usuario oUsuarioResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetUsuarioBynoEmpleado(tx, noEmpleado, oUsuarioResponse);
            return oDataResponse;
        }
        public DataResponse GetUsuarioBynoEmpleado(string noEmpleado, ref Usuario oUsuarioResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetUsuarioBynoEmpleadoDelegate(GetUsuarioBynoEmpleado), noEmpleado, oUsuarioResponse) as DataResponse;
        }

        delegate DataResponse GetUsuarioForAplicacionDelegate(TransactionalContext tx, string codAplicacion, ref UsuarioList oUsuarioResponse);
        public static DataResponse GetUsuarioForAplicacion(TransactionalContext tx, string codAplicacion, ref UsuarioList oUsuarioResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetUsuarioForAplicacion(tx, codAplicacion, oUsuarioResponse);
            return oDataResponse;
        }
        public DataResponse GetUsuarioForAplicacion(string codAplicacion, ref UsuarioList oUsuarioResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetUsuarioForAplicacionDelegate(GetUsuarioForAplicacion), codAplicacion, oUsuarioResponse) as DataResponse;
        }





        delegate DataResponse GetUsuarioByCodFilialAndCodRolsDelegate(TransactionalContext tx,int codFilial, string codRoles, ref UsuarioList oUsuarioResponse);
        public static DataResponse GetUsuarioByCodFilialAndCodRols(TransactionalContext tx, int codFilial, string codRoles, ref UsuarioList oUsuarioResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetUsuarioByCodFilialAndCodRols(tx, codFilial, codRoles, oUsuarioResponse);
            return oDataResponse;
        }
        public DataResponse GetUsuarioByCodFilialAndCodRols(int codFilial, string codRoles, ref UsuarioList oUsuarioResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetUsuarioByCodFilialAndCodRolsDelegate(GetUsuarioByCodFilialAndCodRols), codFilial, codRoles, oUsuarioResponse) as DataResponse;
        }



        delegate DataResponse GetUsuarioFindUsuarioAndCodAplicacionDelegate(TransactionalContext tx, string nbAlias, string noEmpleado, string nbEmpleado,string codAplicacion, ref UsuarioList oUsuarioListResponse);
        public static DataResponse GetUsuarioFindUsuarioAndCodAplicacion(TransactionalContext tx, string nbAlias, string noEmpleado, string nbEmpleado,string codAplicacion, ref UsuarioList oUsuarioListResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetUsuarioFindUsuarioAndCodAplicacion(tx, nbAlias, noEmpleado, nbEmpleado,codAplicacion, oUsuarioListResponse);
            return oDataResponse;
        }
        public DataResponse GetUsuarioFindUsuarioAndCodAplicacion(string nbAlias, string noEmpleado, string nbEmpleado,string codAplicacion, ref UsuarioList oUsuarioListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetUsuarioFindUsuarioAndCodAplicacionDelegate(GetUsuarioFindUsuarioAndCodAplicacion), nbAlias, noEmpleado, nbEmpleado,codAplicacion, oUsuarioListResponse) as DataResponse;
        }

        delegate DataResponse GetUsuarioByUsuarioAndCodAplicacionDelegate(TransactionalContext tx, string nbAlias, string codAplicacion, ref Usuario oUsuarioResponse);
        public static DataResponse GetUsuarioByUsuarioAndCodAplicacion(TransactionalContext tx, string nbAlias, string codAplicacion, ref Usuario oUsuarioResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetUsuarioByUsuarioAndCodAplicacion(tx, nbAlias, codAplicacion, oUsuarioResponse);
            return oDataResponse;
        }
        public DataResponse GetUsuarioByUsuarioAndCodAplicacion(string nbAlias, string codAplicacion, ref Usuario oUsuarioResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetUsuarioByUsuarioAndCodAplicacionDelegate(GetUsuarioByUsuarioAndCodAplicacion), nbAlias, codAplicacion, oUsuarioResponse) as DataResponse;
        }

        delegate DataResponse GetUsuarioFindUsuarioAndCodAplicacionAndTipoDelegate(TransactionalContext tx, string nbAlias, string noEmpleado, string nbEmpleado, string codAplicacion, int idCodigoTipoCuenta, ref UsuarioList oUsuarioListResponse);
        public static DataResponse GetUsuarioFindUsuarioAndCodAplicacionAndTipo(TransactionalContext tx, string nbAlias, string noEmpleado, string nbEmpleado, string codAplicacion, int idCodigoTipoCuenta, ref UsuarioList oUsuarioListResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetUsuarioFindUsuarioAndCodAplicacionAndTipo(tx, nbAlias, noEmpleado, nbEmpleado, codAplicacion, idCodigoTipoCuenta, oUsuarioListResponse);
            return oDataResponse;
        }
        public DataResponse GetUsuarioFindUsuarioAndCodAplicacionAndTipo(string nbAlias, string noEmpleado, string nbEmpleado, string codAplicacion, int idCodigoTipoCuenta, ref UsuarioList oUsuarioListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetUsuarioFindUsuarioAndCodAplicacionAndTipoDelegate(GetUsuarioFindUsuarioAndCodAplicacionAndTipo), nbAlias, noEmpleado, nbEmpleado, codAplicacion, idCodigoTipoCuenta, oUsuarioListResponse) as DataResponse;
        }
    }
}