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
        DataResponse AddFuncionalidad(Funcionalidad oFuncionalidad);
        [OperationContract()]
        DataResponse GetFuncionalidadAll(string codAplicacion, ref FuncionalidadList oFuncionalidadListResponse);
        [OperationContract()]
        DataResponse GetFuncionalidadByKey(int idFuncionalidad, ref Funcionalidad oFuncionalidadResponse);
        [OperationContract()]
        DataResponse GetFuncionalidadByCategoria(int idCategoria, string codAplicacion, ref FuncionalidadList oFuncionalidadListResponse);
        [OperationContract(Name = "GetFuncionalidadByComponente")]
        DataResponse GetFuncionalidadByComponente(string Componente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse);
        [OperationContract(Name = "GetFuncionalidadBySubComponente")]
        DataResponse GetFuncionalidadBySubComponente(string Componente, string subComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse);
        [OperationContract]
        DataResponse CountFuncionalidadByMenuOption(int noCatalogo, string codCategoria, string nbComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse);
        [OperationContract(Name = "CountFuncionalidadByMenuOptionPermitidoByCategoria")]
        DataResponse CountFuncionalidadByMenuOptionPermitidoByCategoria(string nbAlias, int noCatalogo, string codCategoria, string codAplicacion);
        [OperationContract(Name = "CountFuncionalidadByMenuOptionPermitidobyComponente")]
        DataResponse CountFuncionalidadByMenuOptionPermitido(string nbAlias, string nbComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse);
        [OperationContract(Name = "CountFuncionalidadByMenuOptionPermitidobySubComponente")]
        DataResponse CountFuncionalidadByMenuOptionPermitido(string nbAlias, string nbComponente, string nbSubComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse);
        [OperationContract(Name = "AccesoPermitidoByAplicacion")]
        DataResponse AccesoPermitido(string nbAlias, string codAplicacion);
        [OperationContract(Name = "AccesoPermitidoByFuncionalidad")]
        DataResponse AccesoPermitido(string nbAlias, int idFuncionalidad, string codAplicacion);
    }
}
