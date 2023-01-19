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

        delegate DataResponse GetEmpresaByGrupoDelegate(TransactionalContext tx, string noGrupo, ref EmpresaDMList oEmpresaDMList);
        public static DataResponse GetEmpresaByGrupo(TransactionalContext tx, string noGrupo, ref EmpresaDMList oEmpresaDMList)
        {
            DataResponse oDataResponse = ConfigurationStore.GetEmpresaByGrupo(tx, noGrupo, oEmpresaDMList);
            return oDataResponse;
        }
        public DataResponse GetEmpresaByGrupo(string noGrupo, ref EmpresaDMList oEmpresaDMList)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RH"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEmpresaByGrupoDelegate(GetEmpresaByGrupo), dsConexion, noGrupo, oEmpresaDMList) as DataResponse;
        }

        delegate DataResponse GetEmpresaByEmpresaDelegate(TransactionalContext tx, string codEmpresa, ref EmpresaDMList oEmpresaDMList);
        public static DataResponse GetEmpresaByEmpresa(TransactionalContext tx, string codEmpresa, ref EmpresaDMList oEmpresaDMList)
        {
            DataResponse oDataResponse = ConfigurationStore.GetEmpresaByEmpresa(tx, codEmpresa, oEmpresaDMList);
            return oDataResponse;
        }
        public DataResponse GetEmpresaByEmpresa(string codEmpresa, ref EmpresaDMList oEmpresaDMList)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RH"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEmpresaByEmpresaDelegate(GetEmpresaByEmpresa), dsConexion, codEmpresa, oEmpresaDMList) as DataResponse;
        }



        delegate DataResponse GetCatalogoByEmpresaBynoGrupoAndSectorDMDelegate(TransactionalContext tx, string codEmpresa, string codSector, ref EmpresaDMList oEmpresaDMList);
        public static DataResponse GetCatalogoByEmpresaBynoGrupoAndSectorDM(TransactionalContext tx, string codEmpresa, string codSector, ref EmpresaDMList oEmpresaDMList)
        {
            DataResponse oDataResponse = ConfigurationStore.GetCatalogoByEmpresaBynoGrupoAndSectorDM(tx, codEmpresa,codSector, oEmpresaDMList);
            return oDataResponse;
        }
        public DataResponse GetCatalogoByEmpresaBynoGrupoAndSectorDM(string codEmpresa,string codSector, ref EmpresaDMList oEmpresaDMList)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RH"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetCatalogoByEmpresaBynoGrupoAndSectorDMDelegate(GetCatalogoByEmpresaBynoGrupoAndSectorDM), dsConexion, codEmpresa, codSector, oEmpresaDMList) as DataResponse;
        }

    }
}
