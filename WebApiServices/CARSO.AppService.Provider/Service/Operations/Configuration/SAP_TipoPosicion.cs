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
     
        delegate DataResponse GetTipoPosicionAllDelegate(TransactionalContext tx, ref TipoPosicionList oTipoPosicionListResponse);
        public static DataResponse GetTipoPosicionAll(TransactionalContext tx, ref TipoPosicionList oTipoPosicionListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetTipoPosicionAll(tx, oTipoPosicionListResponse);
            return oDataResponse;
        }
        public DataResponse GetTipoPosicionAll(ref TipoPosicionList oTipoPosicionListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetTipoPosicionAllDelegate(GetTipoPosicionAll), dsConexion , oTipoPosicionListResponse) as DataResponse;
        }


        delegate DataResponse GetTipoPosicionByKeyDelegate(TransactionalContext tx, string codTipoPosicion, ref TipoPosicion oTipoPosicionResponse);
        public static DataResponse GetTipoPosicionByKey(TransactionalContext tx, string codTipoPosicion, ref TipoPosicion oTipoPosicionResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetTipoPosicionByKey(tx, codTipoPosicion, oTipoPosicionResponse);
            return oDataResponse;
        }
        public DataResponse GetTipoPosicionByKey(string codTipoPosicion, ref TipoPosicion oTipoPosicionResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetTipoPosicionByKeyDelegate(GetTipoPosicionByKey), dsConexion, codTipoPosicion, oTipoPosicionResponse) as DataResponse;
        }

        public void Log(string v, string message, object value)
        {
            throw new NotImplementedException();
        }
    }
}
