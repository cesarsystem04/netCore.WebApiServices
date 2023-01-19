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

        delegate DataResponse GetDeptoByGrupoAndSectorAndEmpresaAndFilialDMDelegate(TransactionalContext tx, string noGrupo, string codSector, string codEmpresa, string codFilial, ref DepartamentoDMList oDepartamentoDMList);
        public static DataResponse GetDeptoByGrupoAndSectorAndEmpresaAndFilialDM(TransactionalContext tx, string noGrupo, string codSector, string codEmpresa, string codFilial, ref DepartamentoDMList oDepartamentoDMList)
        {
            DataResponse oDataResponse = ConfigurationStore.GetDeptoByGrupoAndSectorAndEmpresaAndFilialDM(tx, noGrupo, codSector, codEmpresa, codFilial, oDepartamentoDMList);
            return oDataResponse;
        }
        public DataResponse GetDeptoByGrupoAndSectorAndEmpresaAndFilialDM(string noGrupo, string codSector, string codEmpresa, string codFilial, ref DepartamentoDMList oDepartamentoDMList)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RH"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetDeptoByGrupoAndSectorAndEmpresaAndFilialDMDelegate(GetDeptoByGrupoAndSectorAndEmpresaAndFilialDM), dsConexion, noGrupo, codSector, codEmpresa, codFilial, oDepartamentoDMList) as DataResponse;
        }
    }
}
