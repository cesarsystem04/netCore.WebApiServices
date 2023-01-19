using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Security.Principal;
using System.IO;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.AppService.Provider.Service;
using CARSO.AppService.ServiceDataContainers;
using System.Threading.Tasks;

namespace CARSO.AppService.Provider.Client
{
    public partial class AppServiceClient : ClientBase<IAppService>, IAppService
    {
        public DataResponse Get
            (string noEmpleado, ref Empleado oEmpleado)
        {
            return Channel.GetEmpleado(noEmpleado, ref oEmpleado);
        }

        public DataResponse GetEmpleadoByAlias(string nbAlias, ref Empleado oEmpleado)
        {
            return Channel.GetEmpleadoByAlias(nbAlias, ref oEmpleado);
        }



        public DataResponse GetEmpleadoConInactivo(string noEmpleado, ref Empleado oEmpleado)
        {
            return Channel.GetEmpleadoConInactivo(noEmpleado, ref oEmpleado);
        }


        public DataResponse GetEmpleadoPorAlcance(string noEmpleado, string codFilial, string codEmpresa, ref Empleado oEmpleado)
        {

            return Channel.GetEmpleadoPorAlcance(noEmpleado, codFilial, codEmpresa,  ref oEmpleado);
        }


        public DataResponse GetEmpleadoByRFC(string RFC, ref Empleado oEmpleado)
        {
            return Channel.GetEmpleadoByRFC(RFC, ref oEmpleado);
        }

        // frosasl: Búsqueda de Empleados por criterios (Boletos de Avión)
        public DataResponse GetEmpleadoByCriteria(string noEmpleado, string nbAlias,
            string nbEmpleado, ref EmpleadosList oEmpleadosList)
        {
            return Channel.GetEmpleadoByCriteria(noEmpleado, nbAlias, nbEmpleado,
                ref oEmpleadosList);
        }

        public DataResponse GetEmpleadoPorAlcanceNomina(string noEmpleado, int noGrupo, string codEmpresa, string codFilial,
            int esNCPermitido, ref EmpleadosList oEmpleadosList)
        {
            return Channel.GetEmpleadoPorAlcanceNomina(noEmpleado, noGrupo, codEmpresa, codFilial, esNCPermitido,
                ref oEmpleadosList);
        }

        public DataResponse GetEmpleadoPorCriterioNomina(string RfcEmpleado, string RfcEmpresa, 
            int esNCPermitido, ref EmpleadosList oEmpleadosList)
        {
            return Channel.GetEmpleadoPorCriterioNomina(RfcEmpleado, RfcEmpresa, esNCPermitido,
                ref oEmpleadosList);
        }
    }
}
