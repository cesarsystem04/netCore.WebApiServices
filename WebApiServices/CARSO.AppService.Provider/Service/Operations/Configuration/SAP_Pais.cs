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
  
        delegate DataResponse GetPaisByAllDelegate(TransactionalContext tx, ref PaisList oPaisListResponse);
        public static DataResponse GetPaisByAll(TransactionalContext tx, ref PaisList oPaisListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetPaisByAll(tx, oPaisListResponse);
            return oDataResponse;
        }
        public DataResponse GetPaisByAll( ref PaisList oPaisListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetPaisByAllDelegate(GetPaisByAll), dsConexion,  oPaisListResponse) as DataResponse;
        }


        delegate DataResponse GetPaisByKeyDelegate(TransactionalContext tx, string codPais, ref PaisList oPaisListResponse);
        public static DataResponse GetPaisByKey(TransactionalContext tx, string codPais, ref PaisList oPaisListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetPaisByKey(tx, codPais, oPaisListResponse);
            return oDataResponse;
        }
        public DataResponse GetPaisByKey(string codPais, ref PaisList oPaisListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetPaisByKeyDelegate(GetPaisByKey), dsConexion, codPais, oPaisListResponse) as DataResponse;
        }




    }
}
