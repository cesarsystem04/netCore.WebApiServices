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
      
        delegate DataResponse GetUbicacionAllDelegate(TransactionalContext tx, ref UbicacionList oUbicacionListResponse);
        public static DataResponse GetUbicacionAll(TransactionalContext tx, ref UbicacionList oUbicacionListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetUbicacionAll(tx, oUbicacionListResponse);
            return oDataResponse;
        }
        public DataResponse GetUbicacionAll(ref UbicacionList oUbicacionListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetUbicacionAllDelegate(GetUbicacionAll), dsConexion,   oUbicacionListResponse) as DataResponse;
        }


        delegate DataResponse GetUbicacionByKeyDelegate(TransactionalContext tx, string codEdificio, ref Ubicacion oUbicacionResponse);
        public static DataResponse GetUbicacionByKey(TransactionalContext tx, string codEdificio, ref Ubicacion oUbicacionResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetUbicacionByKey(tx, codEdificio, oUbicacionResponse);
            return oDataResponse;
        }
        public DataResponse GetUbicacionByKey(string codEdificio, ref Ubicacion oUbicacionResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetUbicacionByKeyDelegate(GetUbicacionByKey), dsConexion, codEdificio, oUbicacionResponse) as DataResponse;
        }




    }
}
