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
       
        delegate DataResponse GetEstadoCivilByAllDelegate(TransactionalContext tx, ref EstadoCivilList oEstadoCivilListResponse);
        public static DataResponse GetEstadoCivilByAll(TransactionalContext tx, ref EstadoCivilList oEstadoCivilListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetEstadoCivilByAll(tx, oEstadoCivilListResponse);
            return oDataResponse;
        }
        public DataResponse GetEstadoCivilByAll( ref EstadoCivilList oEstadoCivilListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEstadoCivilByAllDelegate(GetEstadoCivilByAll), dsConexion,   oEstadoCivilListResponse) as DataResponse;
        }


        delegate DataResponse GetEstadoCivilByKeyDelegate(TransactionalContext tx, string codEstadoCivil, ref EstadoCivilList oEstadoCivilListResponse);
        public static DataResponse GetEstadoCivilByKey(TransactionalContext tx, string codEstadoCivil, ref EstadoCivilList oEstadoCivilListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetEstadoCivilByKey(tx, codEstadoCivil, oEstadoCivilListResponse);
            return oDataResponse;
        }
        public DataResponse GetEstadoCivilByKey(string codEstadoCivil, ref EstadoCivilList oEstadoCivilListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEstadoCivilByKeyDelegate(GetEstadoCivilByKey), dsConexion, codEstadoCivil, oEstadoCivilListResponse) as DataResponse;
        }



    }
}
