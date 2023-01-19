using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Security.Principal;
using System.IO;
using System.Threading.Tasks;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.AppService.ServiceDataContainers;

namespace CARSO.AppService.Provider.Service
{
    public partial interface IAppService
    {
        [OperationContract]
        DataResponse GetEmpleado(string noEmpleado, ref Empleado oEmpleado);
        [OperationContract]
        DataResponse GetEmpleadoByAlias(string nbAlias, ref Empleado oEmpleado);
        [OperationContract]
        DataResponse GetEmpleadoConInactivo(string noEmpleado, ref Empleado oEmpleado);
        [OperationContract]
        DataResponse GetEmpleadoPorAlcance(string noEmpleado, string codFilial, string codEmpresa, ref Empleado oEmpleado);
        [OperationContract]
        DataResponse GetEmpleadoByRFC(string RFC, ref Empleado oEmpleado);
        // frosasl: Búsqueda de Empleados por criterios (Boletos de Avión)
        [OperationContract]
        DataResponse GetEmpleadoByCriteria(string noEmpleado, string nbAlias,
            string nbEmpleado, ref EmpleadosList oEmpleadosList);
        [OperationContract]
        DataResponse GetEmpleadoPorAlcanceNomina(string noEmpleado, int noGrupo, string codEmpresa, string codFilial,
            int esNCPermitido, ref EmpleadosList oEmpleadosList);
        [OperationContract]
        DataResponse GetEmpleadoPorCriterioNomina(string RfcEmpleado, string RfcEmpresa, int esNCPermitido,
            ref EmpleadosList oEmpleadosList);
    }
}
