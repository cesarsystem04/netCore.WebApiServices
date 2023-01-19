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

        delegate DataResponse GetFuncionAllDelegate(TransactionalContext tx, ref FuncionList oFuncionListResponse);
        public static DataResponse GetFuncionAll(TransactionalContext tx, ref FuncionList oFuncionListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetFuncionAll(tx, oFuncionListResponse);
            return oDataResponse;
        }
        public DataResponse GetFuncionAll( ref FuncionList oFuncionListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetFuncionAllDelegate(GetFuncionAll), dsConexion , oFuncionListResponse) as DataResponse;
        }


        delegate DataResponse GetFuncionByKeyDelegate(TransactionalContext tx, string codFuncion, ref Funcion oFuncionResponse);
        public static DataResponse GetFuncionByKey(TransactionalContext tx, string codFuncion, ref Funcion oFuncionResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetFuncionByKey(tx, codFuncion, oFuncionResponse);
            return oDataResponse;
        }
        public DataResponse GetFuncionByKey(string codFuncion, ref Funcion oFuncionResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetFuncionByKeyDelegate(GetFuncionByKey), dsConexion, codFuncion, oFuncionResponse) as DataResponse;
        }




    }
}
