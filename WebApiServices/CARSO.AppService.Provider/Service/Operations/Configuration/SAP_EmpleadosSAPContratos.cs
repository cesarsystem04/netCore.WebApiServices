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
        delegate DataResponse GetEmpleadosSAPContratosDelegate(TransactionalContext tx, int noDias, ref EmpleadosSAPContratosList oEmpleadosSAPContratosListResponse);
        public static DataResponse GetEmpleadosSAPContratos(TransactionalContext tx, int noDias, ref EmpleadosSAPContratosList oEmpleadosSAPContratosListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetEmpleadosSAPContratos(tx, noDias, oEmpleadosSAPContratosListResponse);
            return oDataResponse;
        }
        public DataResponse GetEmpleadosSAPContratos(int noDias, ref EmpleadosSAPContratosList oEmpleadosSAPContratosListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEmpleadosSAPContratosDelegate(GetEmpleadosSAPContratos), dsConexion, noDias, oEmpleadosSAPContratosListResponse) as DataResponse;
        }

        delegate DataResponse GetEmpleadosSAPContratosbyNoEmpleadoDelegate(TransactionalContext tx, string noEmpleado, ref EmpleadosSAPContratos oEmpleadosSAPContratosResponse);
        public static DataResponse GetEmpleadosSAPContratosbyNoEmpleado(TransactionalContext tx, string noEmpleado, ref EmpleadosSAPContratos oEmpleadosSAPContratosResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetEmpleadosSAPContratosbyNoEmpleado(tx, noEmpleado, oEmpleadosSAPContratosResponse);
            return oDataResponse;
        }
        public DataResponse GetEmpleadosSAPContratosbyNoEmpleado(string noEmpleado, ref EmpleadosSAPContratos oEmpleadosSAPContratosResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEmpleadosSAPContratosbyNoEmpleadoDelegate(GetEmpleadosSAPContratosbyNoEmpleado), dsConexion, noEmpleado, oEmpleadosSAPContratosResponse) as DataResponse;
        }
    }
}
