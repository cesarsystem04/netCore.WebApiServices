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
      
        delegate DataResponse GetSubDivisionAllDelegate(TransactionalContext tx, ref SubDivisionList oSubDivisionListResponse);
        public static DataResponse GetSubDivisionAll(TransactionalContext tx, ref SubDivisionList oSubDivisionListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetSubDivisionAll(tx, oSubDivisionListResponse);
            return oDataResponse;
        }
        public  DataResponse GetSubDivisionAll( ref SubDivisionList oSubDivisionListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);

            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetSubDivisionAllDelegate(GetSubDivisionAll), dsConexion, oSubDivisionListResponse) as DataResponse;
        }


        delegate DataResponse GetSubDivisionByKeyDelegate(TransactionalContext tx, string codSubdivision, string codDivision,ref  SubDivision oSubDivisionResponse);
        public static DataResponse GetSubDivisionByKey(TransactionalContext tx, string codSubdivision, string codDivision,ref SubDivision oSubDivisionResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetSubDivisionByKey(tx, codSubdivision, codDivision, oSubDivisionResponse);
            return oDataResponse;
        }
        public  DataResponse GetSubDivisionByKey(string codSubdivision, string codDivision, ref SubDivision oSubDivisionResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);

            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetSubDivisionByKeyDelegate(GetSubDivisionByKey), dsConexion, codSubdivision, codDivision, oSubDivisionResponse) as DataResponse;
        }



        delegate DataResponse GetSubDivisionByDivisionesDelegate(TransactionalContext tx, string codDivisiones,  ref SubDivisionList oSubDivisionResponse);
        public static DataResponse GetSubDivisionByDivisiones(TransactionalContext tx, string codDivisiones,  ref SubDivisionList oSubDivisionResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetSubDivisionByDivisiones(tx, codDivisiones, oSubDivisionResponse);
            return oDataResponse;
        }
        public DataResponse GetSubDivisionByDivisiones(string codDivisiones,  ref SubDivisionList oSubDivisionResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);

            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetSubDivisionByDivisionesDelegate(GetSubDivisionByDivisiones), dsConexion, codDivisiones,  oSubDivisionResponse) as DataResponse;
        }

    }
}
