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

        delegate DataResponse GetEmpleadoDelegate(TransactionalContext tx, string noEmpleado, ref Empleado oEmpleado);
        public static DataResponse GetEmpleado(TransactionalContext tx, string noEmpleado, ref Empleado oEmpleado)
        {
            DataResponse oDataResponse = ConfigurationStore.GetEmpleado(tx, noEmpleado, oEmpleado);
            return oDataResponse;
        }
        public DataResponse GetEmpleado(string noEmpleado, ref Empleado oEmpleado)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RH"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEmpleadoDelegate(GetEmpleado), dsConexion, noEmpleado, oEmpleado) as DataResponse;
        }

        delegate DataResponse GetEmpleadoByAliasDelegate(TransactionalContext tx, string nbAlias, ref Empleado oEmpleado);
        public static DataResponse GetEmpleadoByAlias(TransactionalContext tx, string nbAlias, ref Empleado oEmpleado)
        {
            DataResponse oDataResponse = ConfigurationStore.GetEmpleadoByAlias(tx, nbAlias, oEmpleado);
            return oDataResponse;
        }
        public DataResponse GetEmpleadoByAlias(string nbAlias, ref Empleado oEmpleado)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RH"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEmpleadoByAliasDelegate(GetEmpleadoByAlias), dsConexion, nbAlias, oEmpleado) as DataResponse;
        }

        delegate DataResponse GetEmpleadoConInactivoDelegate(TransactionalContext tx, string noEmpleado, ref Empleado oEmpleado);
        public static DataResponse GetEmpleadoConInactivo(TransactionalContext tx, string noEmpleado, ref Empleado oEmpleado)
        {
            DataResponse oDataResponse = ConfigurationStore.GetEmpleadoConInactivo(tx, noEmpleado, oEmpleado);
            return oDataResponse;
        }
        public DataResponse GetEmpleadoConInactivo(string noEmpleado, ref Empleado oEmpleado)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RH"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEmpleadoConInactivoDelegate(GetEmpleadoConInactivo), dsConexion, noEmpleado, oEmpleado) as DataResponse;
        }


        delegate DataResponse GetEmpleadoPorAlcanceDelegate(TransactionalContext tx, string noEmpleado, string codFilial, string codEmpresa, ref Empleado oEmpleado);
        public static DataResponse GetEmpleadoPorAlcance(TransactionalContext tx, string noEmpleado, string codFilial, string codEmpresa, ref Empleado oEmpleado)
        {
            DataResponse oDataResponse = ConfigurationStore.GetEmpleadoPorAlcance(tx, noEmpleado, codFilial, codEmpresa, oEmpleado);
            return oDataResponse;
        }
        public DataResponse GetEmpleadoPorAlcance(string noEmpleado, string codFilial, string codEmpresa,  ref Empleado oEmpleado)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RH"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEmpleadoPorAlcanceDelegate(GetEmpleadoPorAlcance), dsConexion, noEmpleado, codFilial, codEmpresa,  oEmpleado) as DataResponse;
        }

        delegate DataResponse GetEmpleadoByRFCDelegate(TransactionalContext tx, string RFC, ref Empleado oEmpleado);
        public static DataResponse GetEmpleadoByRFC(TransactionalContext tx, string RFC, ref Empleado oEmpleado)
        {
            DataResponse oDataResponse = ConfigurationStore.GetEmpleadoByRFC(tx, RFC, oEmpleado);
            return oDataResponse;
        }
        public DataResponse GetEmpleadoByRFC(string RFC, ref Empleado oEmpleado)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RH"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEmpleadoByRFCDelegate(GetEmpleadoByRFC), dsConexion, RFC, oEmpleado) as DataResponse;
        }

        // frosasl: Búsqueda de Empleados por criterios (Boletos de Avión)
        delegate DataResponse GetEmpleadoByCriteriaDelegate(TransactionalContext tx, 
            string noEmpleado, string nbAlias, string nbEmpleado, ref EmpleadosList oEmpleadosList);
        public static DataResponse GetEmpleadoByCriteria(TransactionalContext tx,
            string noEmpleado, string nbAlias, string nbEmpleado, ref EmpleadosList oEmpleadosList)
        {
            DataResponse oDataResponse = ConfigurationStore.GetEmpleadoByCriteria(tx, 
                noEmpleado, nbAlias, nbEmpleado, oEmpleadosList);

            return oDataResponse;
        }
        public DataResponse GetEmpleadoByCriteria(string noEmpleado, string nbAlias, 
            string nbEmpleado, ref EmpleadosList oEmpleadosList)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RH"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEmpleadoByCriteriaDelegate(GetEmpleadoByCriteria), 
                dsConexion, noEmpleado, nbAlias, nbEmpleado, oEmpleadosList) as DataResponse;
        }

        delegate DataResponse GetEmpleadoPorAlcanceNominaDelegate(TransactionalContext tx, string noEmpleado, int noGrupo, string codEmpresa, string codFilial,
            int esNCPermitido, ref EmpleadosList oEmpleadosList);

        public static DataResponse GetEmpleadoPorAlcanceNomina(TransactionalContext tx, string noEmpleado, int noGrupo, string codEmpresa, string codFilial,
            int esNCPermitido, ref EmpleadosList oEmpleadosList)
        {
            return ConfigurationStore.GetEmpleadoByAlcanceNomina(tx, noEmpleado, noGrupo, codEmpresa, codFilial, esNCPermitido, oEmpleadosList);
        }

        public DataResponse GetEmpleadoPorAlcanceNomina(string noEmpleado, int noGrupo, string codEmpresa, string codFilial,
            int esNCPermitido, ref EmpleadosList oEmpleadosList)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RH"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);

            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEmpleadoPorAlcanceNominaDelegate(GetEmpleadoPorAlcanceNomina),
                dsConexion, noEmpleado, noGrupo, codEmpresa, codFilial, esNCPermitido, oEmpleadosList) as DataResponse;
        }

        delegate DataResponse GetEmpleadoPorCriterioNominaDelegate(TransactionalContext tx, string RfcEmpleado, string rfcEmpresa, int esNCPermitido, 
            ref EmpleadosList oEmpleadosList);

        public static DataResponse GetEmpleadoPorCriterioNomina(TransactionalContext tx, string RfcEmpleado, string RfcEmpresa, int esNCPermitido, 
            ref EmpleadosList oEmpleadosList)
        {
            return ConfigurationStore.GetEmpleadoByCriterioNomina(tx, RfcEmpleado, RfcEmpresa, esNCPermitido, oEmpleadosList);
        }

        public DataResponse GetEmpleadoPorCriterioNomina(string RfcEmpleado, string RfcEmpresa, int esNCPermitido, ref EmpleadosList oEmpleadosList)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RH"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);

            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEmpleadoPorCriterioNominaDelegate(GetEmpleadoPorCriterioNomina),
                dsConexion, RfcEmpleado, RfcEmpresa, esNCPermitido, oEmpleadosList) as DataResponse;
        }
    }

}
