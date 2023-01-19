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
        #region AreaDePersonal
        delegate DataResponse GetAreaDePersonalAllDelegate(TransactionalContext tx, ref AreaDePersonalList oAreaDePersonalListResponse);
        public static DataResponse GetAreaDePersonalAll(TransactionalContext tx, ref AreaDePersonalList oAreaDePersonalListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetAreaDePersonalAll(tx, oAreaDePersonalListResponse);
            return oDataResponse;
        }
        public  DataResponse GetAreaDePersonalAll(ref AreaDePersonalList oAreaDePersonalListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);

            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetAreaDePersonalAllDelegate(GetAreaDePersonalAll) , dsConexion, oAreaDePersonalListResponse) as DataResponse;
        }


        delegate DataResponse GetAreaDePersonalByKeyDelegate(TransactionalContext tx, string codGrupoPersonal, string codAreaPersonal, ref AreaDePersonal oAreaDePersonalResponse);
        public static DataResponse GetAreaDePersonalByKey(TransactionalContext tx, string codGrupoPersonal, string codAreaPersonal, ref AreaDePersonal oAreaDePersonalResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetAreaDePersonalByKey(tx, codGrupoPersonal, codAreaPersonal, oAreaDePersonalResponse);
            return oDataResponse;
        }
        public  DataResponse GetAreaDePersonalByKey(string codGrupoPersonal, string codAreaPersonal, ref AreaDePersonal oAreaDePersonalResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);

            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetAreaDePersonalByKeyDelegate(GetAreaDePersonalByKey), dsConexion, codGrupoPersonal, codAreaPersonal, oAreaDePersonalResponse) as DataResponse;
        }


        #endregion

    }
}
