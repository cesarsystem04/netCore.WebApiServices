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
       
        delegate DataResponse GetDivisionAllDelegate(TransactionalContext tx, ref DivisionList oDivisionListResponse);
        public static DataResponse GetDivisionAll(TransactionalContext tx, ref DivisionList oDivisionListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetDivisionAll(tx, oDivisionListResponse);
            return oDataResponse;
        }
        public  DataResponse GetDivisionAll( ref DivisionList oDivisionListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);

            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetDivisionAllDelegate(GetDivisionAll), dsConexion,  oDivisionListResponse) as DataResponse;
        }


        delegate DataResponse GetDivisionByKeyDelegate(TransactionalContext tx, string codDivision,ref Division oDivisionResponse);
        public static DataResponse GetDivisionByKey(TransactionalContext tx, string codDivision, ref Division oDivisionResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetDivisionByKey(tx, codDivision, oDivisionResponse);
            return oDataResponse;
        }
        public  DataResponse GetDivisionByKey(string codDivision,ref Division oDivisionResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);

            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetDivisionByKeyDelegate(GetDivisionByKey), dsConexion, codDivision, oDivisionResponse) as DataResponse;
        }

        delegate DataResponse GetDivisionBySociedadDelegate(TransactionalContext tx, string codSociedad, ref DivisionList  oDivisionResponse);
        public static DataResponse GetDivisionBySociedad(TransactionalContext tx, string codSociedad, ref DivisionList oDivisionResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetDivisionBySociedad(tx, codSociedad, oDivisionResponse);
            return oDataResponse;
        }
        public DataResponse GetDivisionBySociedad(string codSociedad, ref DivisionList oDivisionResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);

            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetDivisionBySociedadDelegate(GetDivisionBySociedad), dsConexion, codSociedad, oDivisionResponse) as DataResponse;
        }

        delegate DataResponse GetDivisionBySociedadesDelegate(TransactionalContext tx, string codSociedades, ref DivisionList oDivisionResponse);
        public static DataResponse GetDivisionBySociedades(TransactionalContext tx, string codSociedades, ref DivisionList oDivisionResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetDivisionBySociedades(tx, codSociedades, oDivisionResponse);
            return oDataResponse;
        }
        public DataResponse GetDivisionBySociedades(string codSociedades, ref DivisionList oDivisionResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);

            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetDivisionBySociedadesDelegate(GetDivisionBySociedades), dsConexion, codSociedades, oDivisionResponse) as DataResponse;
        }

    }
}
