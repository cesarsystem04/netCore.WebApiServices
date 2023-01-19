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
        delegate DataResponse GetFilialByEmpresaAndGrupoDelegate(TransactionalContext tx, string noGrupo, string codEmpresa, ref FilialDMList oFilialDMList);
        public static DataResponse GetFilialByEmpresaAndGrupo(TransactionalContext tx, string noGrupo, string codEmpresa, ref FilialDMList oFilialDMList)
        {
            DataResponse oDataResponse = ConfigurationStore.GetFilialByEmpresaAndGrupo(tx, noGrupo, codEmpresa, oFilialDMList);
            return oDataResponse;
        }
        public DataResponse GetFilialByEmpresaAndGrupo(string noGrupo, string codEmpresa, ref FilialDMList oFilialDMList)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RH"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetFilialByEmpresaAndGrupoDelegate(GetFilialByEmpresaAndGrupo), dsConexion, noGrupo, codEmpresa, oFilialDMList) as DataResponse;
        }



        delegate DataResponse GetFilialByGrupoAndSectorAndEmpresaDelegate(TransactionalContext tx, string noGrupo, string codSector, string codEmpresa, ref FilialDMList oFilialDMList);
        public static DataResponse GetFilialByGrupoAndSectorAndEmpresa(TransactionalContext tx, string noGrupo, string codSector, string codEmpresa, ref FilialDMList oFilialDMList)
        {
            DataResponse oDataResponse = ConfigurationStore.GetFilialByGrupoAndSectorAndEmpresa(tx, noGrupo,codSector, codEmpresa, oFilialDMList);
            return oDataResponse;
        }
        public DataResponse GetFilialByGrupoAndSectorAndEmpresa(string noGrupo, string codSector, string codEmpresa, ref FilialDMList oFilialDMList)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RH"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetFilialByGrupoAndSectorAndEmpresaDelegate(GetFilialByGrupoAndSectorAndEmpresa), dsConexion, noGrupo,codSector, codEmpresa, oFilialDMList) as DataResponse;
        }



        delegate DataResponse GetFilialByEmpresaDelegate(TransactionalContext tx, string codEmpresa, ref FilialDMList oFilialDMList);
        public static DataResponse GetFilialByEmpresa(TransactionalContext tx, string codEmpresa, ref FilialDMList oFilialDMList)
        {
            DataResponse oDataResponse = ConfigurationStore.GetFilialByEmpresa(tx, codEmpresa, oFilialDMList);
            return oDataResponse;
        }
        public DataResponse GetFilialByEmpresa(string codEmpresa, ref FilialDMList oFilialDMList)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RH"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetFilialByEmpresaDelegate(GetFilialByEmpresa), dsConexion, codEmpresa, oFilialDMList) as DataResponse;
        }
    }
}
