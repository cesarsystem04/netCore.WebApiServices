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

        delegate DataResponse GetSectorBynoGrupoDelegate(TransactionalContext tx, string noGrupo, ref SectorList oSectorList);
        public static DataResponse GetSectorBynoGrupo(TransactionalContext tx, string noGrupo, ref SectorList oSectorList)
        {
            DataResponse oDataResponse = ConfigurationStore.GetSectorBynoGrupo(tx, noGrupo, oSectorList);
            return oDataResponse;
        }
        public DataResponse GetSectorBynoGrupo(string noGrupo, ref SectorList oSectorList)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RH"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetSectorBynoGrupoDelegate(GetSectorBynoGrupo), dsConexion, noGrupo, oSectorList) as DataResponse;
        }
    }
}
