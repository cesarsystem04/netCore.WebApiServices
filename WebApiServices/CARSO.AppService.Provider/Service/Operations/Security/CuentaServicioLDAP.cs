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
        delegate DataResponse GetCuentaServicioLDAPDelegate(TransactionalContext tx, int idCodigoTipoServicio, int idCodigoTipoOperacion, string nbCuentaServicio, string dsPassword, ref CuentaServicioLDAP oCuentaServicioLDAP);
        public static DataResponse GetCuentaServicioLDAP(TransactionalContext tx, int idCodigoTipoServicio, int idCodigoTipoOperacion, string nbCuentaServicio, string dsPassword, ref CuentaServicioLDAP oCuentaServicioLDAP)
        {
            DataResponse oDataResponse = SecurityStore.GetCuentaServicioLDAP(tx, idCodigoTipoServicio, idCodigoTipoOperacion, nbCuentaServicio, dsPassword, oCuentaServicioLDAP);
            return oDataResponse;
        }
        public DataResponse GetCuentaServicioLDAP(int idCodigoTipoServicio, int idCodigoTipoOperacion, string nbCuentaServicio, string dsPassword, ref CuentaServicioLDAP oCuentaServicioLDAP)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetCuentaServicioLDAPDelegate(GetCuentaServicioLDAP), idCodigoTipoServicio, idCodigoTipoOperacion, nbCuentaServicio, dsPassword, oCuentaServicioLDAP) as DataResponse;
        }

        delegate DataResponse AddLogServiceDelegate(TransactionalContext tx, int idCuentaServicio);
        public static DataResponse AddLogService(TransactionalContext tx, int idCuentaServicio)
        {
            DataResponse oDataResponse = SecurityStore.AddLogService(tx, idCuentaServicio);
            return oDataResponse;
        }
        public DataResponse AddLogService(int idCuentaServicio)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddLogServiceDelegate(AddLogService), idCuentaServicio) as DataResponse;
        }
    }
}
