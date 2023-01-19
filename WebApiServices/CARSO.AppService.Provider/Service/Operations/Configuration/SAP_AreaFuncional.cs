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
       
        delegate DataResponse GetAreaFuncionalAllDelegate(TransactionalContext tx, ref AreaFuncionalList oAreaFuncionalListResponse);
        public static DataResponse GetAreaFuncionalAll(TransactionalContext tx, ref AreaFuncionalList oAreaFuncionalListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetAreaFuncionalAll(tx, oAreaFuncionalListResponse);
            return oDataResponse;
        }
        public DataResponse GetAreaFuncionalAll(ref AreaFuncionalList oAreaFuncionalListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetAreaFuncionalAllDelegate(GetAreaFuncionalAll), dsConexion,   oAreaFuncionalListResponse) as DataResponse;
        }


        delegate DataResponse GetAreaFuncionalByKeyDelegate(TransactionalContext tx, string codAreaFuncional, ref AreaFuncional oAreaFuncionalResponse);
        public static DataResponse GetAreaFuncionalByKey(TransactionalContext tx, string codAreaFuncional, ref AreaFuncional oAreaFuncionalResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetAreaFuncionalByKey(tx, codAreaFuncional, oAreaFuncionalResponse);
            return oDataResponse;
        }
        public DataResponse GetAreaFuncionalByKey(string codAreaFuncional, ref AreaFuncional oAreaFuncionalResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetAreaFuncionalByKeyDelegate(GetAreaFuncionalByKey), dsConexion, codAreaFuncional, oAreaFuncionalResponse) as DataResponse;
        }


     

    }
}
