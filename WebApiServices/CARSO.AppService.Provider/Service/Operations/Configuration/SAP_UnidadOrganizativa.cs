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
       
        delegate DataResponse GetUnidadOrganizativaAllDelegate(TransactionalContext tx, ref UnidadOrganizativaList oUnidadOrganizativaListResponse);
        public static DataResponse GetUnidadOrganizativaAll(TransactionalContext tx, ref UnidadOrganizativaList oUnidadOrganizativaListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetUnidadOrganizativaAll(tx, oUnidadOrganizativaListResponse);
            return oDataResponse;
        }
        public DataResponse GetUnidadOrganizativaAll(ref UnidadOrganizativaList oUnidadOrganizativaListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetUnidadOrganizativaAllDelegate(GetUnidadOrganizativaAll), dsConexion,   oUnidadOrganizativaListResponse) as DataResponse;
        }


        delegate DataResponse GetUnidadOrganizativaByKeyDelegate(TransactionalContext tx, ref UnidadOrganizativa oUnidadOrganizativaResponse);
        public static DataResponse GetUnidadOrganizativaByKey(TransactionalContext tx, ref UnidadOrganizativa oUnidadOrganizativaResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetUnidadOrganizativaByKey(tx, oUnidadOrganizativaResponse);
            return oDataResponse;
        }
        public DataResponse GetUnidadOrganizativaByKey( ref UnidadOrganizativa oUnidadOrganizativaResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetUnidadOrganizativaByKeyDelegate(GetUnidadOrganizativaByKey), dsConexion,  oUnidadOrganizativaResponse) as DataResponse;
        }



    }
}
