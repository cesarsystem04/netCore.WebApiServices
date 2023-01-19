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
        #region Jerarquia
        delegate DataResponse GetJerarquiaAllDelegate(TransactionalContext tx, ref JerarquiaList oJerarquiaListResponse);
        public static DataResponse GetJerarquiaAll(TransactionalContext tx, ref JerarquiaList oJerarquiaListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetJerarquiaAll(tx, oJerarquiaListResponse);
            return oDataResponse;
        }
        public DataResponse GetJerarquiaAll( ref JerarquiaList oJerarquiaListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetJerarquiaAllDelegate(GetJerarquiaAll), dsConexion,   oJerarquiaListResponse) as DataResponse;
        }


        delegate DataResponse GetJerarquiaByKeyDelegate(TransactionalContext tx, string codJerarquia, ref Jerarquia oJerarquiaResponse);
        public static DataResponse GetJerarquiaByKey(TransactionalContext tx, string codJerarquia, ref Jerarquia oJerarquiaResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetJerarquiaByKey(tx, codJerarquia, oJerarquiaResponse);
            return oDataResponse;
        }
        public DataResponse GetJerarquiaByKey(string codJerarquia, ref Jerarquia oJerarquiaResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetJerarquiaByKeyDelegate(GetJerarquiaByKey), dsConexion, codJerarquia, oJerarquiaResponse) as DataResponse;
        }


        #endregion

    }
}
