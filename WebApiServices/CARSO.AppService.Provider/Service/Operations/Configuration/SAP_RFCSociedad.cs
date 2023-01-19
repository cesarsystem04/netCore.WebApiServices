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
       
        delegate DataResponse GetRFCSociedadAllDelegate(TransactionalContext tx, ref RFCSociedadList oRFCSociedadListResponse);
        public static DataResponse GetRFCSociedadAll(TransactionalContext tx, ref RFCSociedadList oRFCSociedadListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetRFCSociedadAll(tx, oRFCSociedadListResponse);
            return oDataResponse;
        }
        public  DataResponse GetRFCSociedadAll(ref RFCSociedadList oRFCSociedadListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);

            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetRFCSociedadAllDelegate(GetRFCSociedadAll), dsConexion, oRFCSociedadListResponse) as DataResponse;
        }


        delegate DataResponse GetRFCSociedadByKeyDelegate(TransactionalContext tx, string codSociedad, ref RFCSociedad oRFCSociedadResponse);
        public static DataResponse GetRFCSociedadByKey(TransactionalContext tx, string codSociedad, ref RFCSociedad oRFCSociedadResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetRFCSociedadByKey(tx, codSociedad, oRFCSociedadResponse);
            return oDataResponse;
        }
        public  DataResponse GetRFCSociedadByKey(string codSociedad, ref RFCSociedad oRFCSociedadResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetRFCSociedadByKeyDelegate(GetRFCSociedadByKey), dsConexion, codSociedad, oRFCSociedadResponse) as DataResponse;
        }


     

    }
}
