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
    
        delegate DataResponse GetAreaNominaAllDelegate(TransactionalContext tx,ref  AreaNominaList oAreaNominaListResponse);
        public static DataResponse GetAreaNominaAll(TransactionalContext tx,ref  AreaNominaList oAreaNominaListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetAreaNominaAll(tx, oAreaNominaListResponse);
            return oDataResponse;
        }
        public  DataResponse GetAreaNominaAll(ref AreaNominaList oAreaNominaListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetAreaNominaAllDelegate(GetAreaNominaAll), dsConexion, oAreaNominaListResponse) as DataResponse;
        }


        delegate DataResponse GetAreaNominaByKeyDelegate(TransactionalContext tx, string codAreaNomina, ref AreaNomina oAreaNominaResponse);
        public static DataResponse GetAreaNominaByKey(TransactionalContext tx, string codAreaNomina, ref AreaNomina oAreaNominaResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetAreaNominaByKey(tx, codAreaNomina, oAreaNominaResponse);
            return oDataResponse;
        }
        public  DataResponse GetAreaNominaByKey(string codAreaNomina, ref AreaNomina oAreaNominaResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetAreaNominaByKeyDelegate(GetAreaNominaByKey), dsConexion, codAreaNomina, oAreaNominaResponse) as DataResponse;
        }



    }
}
