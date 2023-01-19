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
        delegate DataResponse GetSociedadAllDelegate(TransactionalContext tx,ref  SociedadList oSociedadListResponse);
        public static DataResponse GetSociedadAll(TransactionalContext tx,ref  SociedadList oSociedadListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetSociedadAll(tx, oSociedadListResponse);
            return oDataResponse;
        }
        public  DataResponse GetSociedadAll( ref SociedadList oSociedadListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);

            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetSociedadAllDelegate(GetSociedadAll),dsConexion,oSociedadListResponse) as DataResponse;
        }


        delegate DataResponse GetSociedadByKeyDelegate(TransactionalContext tx, string codSociedad,ref Sociedad oSociedadResponse);
        public  static DataResponse GetSociedadByKey(TransactionalContext tx, string codSociedad, ref Sociedad oSociedadResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetSociedadByKey(tx, codSociedad, oSociedadResponse);
            return oDataResponse;
        }
        public  DataResponse GetSociedadByKey(string codSociedad, ref Sociedad oSociedadResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);

            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetSociedadByKeyDelegate(GetSociedadByKey), dsConexion, codSociedad, oSociedadResponse) as DataResponse;
        }
    }



}
