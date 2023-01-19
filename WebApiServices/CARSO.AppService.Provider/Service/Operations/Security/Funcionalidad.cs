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
        delegate DataResponse AddFuncionalidadDelegate(TransactionalContext tx, Funcionalidad oFuncionalidad);
        public static DataResponse AddFuncionalidad(TransactionalContext tx, Funcionalidad oFuncionalidad)
        {
            DataResponse oDataResponse = SecurityStore.AddFuncionalidad(tx, oFuncionalidad);
            return oDataResponse;
        }
        public DataResponse AddFuncionalidad(Funcionalidad oFuncionalidad)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddFuncionalidadDelegate(AddFuncionalidad), oFuncionalidad) as DataResponse;
        }


        delegate DataResponse GetFuncionalidadAllDelegate(TransactionalContext tx, string codAplicacion, ref FuncionalidadList oFuncionalidadListResponse);
        public static DataResponse GetFuncionalidadAll(TransactionalContext tx, string codAplicacion, ref FuncionalidadList oFuncionalidadListResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetFuncionalidadAll(tx, codAplicacion, oFuncionalidadListResponse);
            return oDataResponse;
        }
        public DataResponse GetFuncionalidadAll(string codAplicacion, ref FuncionalidadList oFuncionalidadListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetFuncionalidadAllDelegate(GetFuncionalidadAll), codAplicacion, oFuncionalidadListResponse) as DataResponse;
        }


        delegate DataResponse GetFuncionalidadByKeyDelegate(TransactionalContext tx, int idFuncionalidad, ref Funcionalidad oFuncionalidadResponse);
        public static DataResponse GetFuncionalidadByKey(TransactionalContext tx, int idFuncionalidad, ref Funcionalidad oFuncionalidadResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetFuncionalidadByKey(tx, idFuncionalidad, oFuncionalidadResponse);
            return oDataResponse;
        }
        public DataResponse GetFuncionalidadByKey(int idFuncionalidad, ref Funcionalidad oFuncionalidadResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetFuncionalidadByKeyDelegate(GetFuncionalidadByKey), idFuncionalidad, oFuncionalidadResponse) as DataResponse;
        }


        delegate DataResponse GetFuncionalidadByCategoriaDelegate(TransactionalContext tx, int idCategoria, string codAplicacion, ref FuncionalidadList oFuncionalidadListResponse);
        public static DataResponse GetFuncionalidadByCategoria(TransactionalContext tx, int idCategoria, string codAplicacion, ref FuncionalidadList oFuncionalidadListResponse)
        {
            //FuncionalidadList oFuncionalidadList = new FuncionalidadList();
            DataResponse oDataResponse = SecurityStore.GetFuncionalidadByCategoria(tx, idCategoria, codAplicacion, oFuncionalidadListResponse);
            return oDataResponse;
        }
        public DataResponse GetFuncionalidadByCategoria(int idCategoria, string codAplicacion, ref FuncionalidadList oFuncionalidadListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetFuncionalidadByCategoriaDelegate(GetFuncionalidadByCategoria), idCategoria, codAplicacion, oFuncionalidadListResponse) as DataResponse;
        }


        delegate DataResponse GetFuncionalidadByComponenteDelegate(TransactionalContext tx, string Componente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse);
        public static DataResponse GetFuncionalidadByComponente(TransactionalContext tx, string Componente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse)
        {
            //Funcionalidad oFuncionalidad = new Funcionalidad();
            DataResponse oDataResponse = SecurityStore.GetFuncionalidadByComponente(tx, Componente, codAplicacion, oFuncionalidadResponse);
            return oDataResponse;
        }
        public DataResponse GetFuncionalidadByComponente(string Componente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetFuncionalidadByComponenteDelegate(GetFuncionalidadByComponente), Componente, codAplicacion, oFuncionalidadResponse) as DataResponse;
        }

        delegate DataResponse GetFuncionalidadBySubComponenteDelegate(TransactionalContext tx, string Componente, string subComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse);
        public static DataResponse GetFuncionalidadBySubComponente(TransactionalContext tx, string Componente, string subComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse)
        {
            //Funcionalidad oFuncionalidad = new Funcionalidad();
            DataResponse oDataResponse = SecurityStore.GetFuncionalidadBySubComponente(tx, Componente, subComponente, codAplicacion, oFuncionalidadResponse);
            return oDataResponse;
        }
        public DataResponse GetFuncionalidadBySubComponente(string Componente, string subComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetFuncionalidadBySubComponenteDelegate(GetFuncionalidadBySubComponente), Componente, subComponente, codAplicacion, oFuncionalidadResponse) as DataResponse;
        }

        delegate DataResponse CountFuncionalidadByMenuOptionDelegate(TransactionalContext tx, int noCatalogo, string codCategoria, string nbComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse);
        public static DataResponse CountFuncionalidadByMenuOption(TransactionalContext tx, int noCatalogo, string codCategoria, string nbComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse)
        {
            DataResponse oDataResponse = SecurityStore.CountFuncionalidadByMenuOption(tx, noCatalogo, codCategoria, nbComponente, codAplicacion, oFuncionalidadResponse);
            return oDataResponse;
        }
        public DataResponse CountFuncionalidadByMenuOption(int noCatalogo, string codCategoria, string nbComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new CountFuncionalidadByMenuOptionDelegate(CountFuncionalidadByMenuOption), noCatalogo, codCategoria, nbComponente, codAplicacion, oFuncionalidadResponse) as DataResponse;
        }

        delegate DataResponse CountFuncionalidadByMenuOptionPermitidoByCategoriaDelegate(TransactionalContext tx, string nbAlias, int noCatalogo, string codCategoria, string codAplicacion);
        public static DataResponse CountFuncionalidadByMenuOptionPermitidoByCategoria(TransactionalContext tx, string nbAlias, int noCatalogo, string codCategoria, string codAplicacion)
        {
            DataResponse oDataResponse = SecurityStore.CountFuncionalidadByMenuOptionPermitidoByCategoria(tx, nbAlias, noCatalogo, codCategoria, codAplicacion);
            return oDataResponse;
        }
        public DataResponse CountFuncionalidadByMenuOptionPermitidoByCategoria(string nbAlias, int noCatalogo, string codCategoria, string codAplicacion)
        {
            return Processor.TransactionalRootObject_QueryOperation(new CountFuncionalidadByMenuOptionPermitidoByCategoriaDelegate(CountFuncionalidadByMenuOptionPermitidoByCategoria), nbAlias, noCatalogo, codCategoria, codAplicacion) as DataResponse;
        }

        delegate DataResponse CountFuncionalidadBySubMenuOptionPermitidoDelegate(TransactionalContext tx, string nbAlias, string nbComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse);
        public static DataResponse CountFuncionalidadByMenuOptionPermitido(TransactionalContext tx, string nbAlias, string nbComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse)
        {
            DataResponse oDataResponse = SecurityStore.CountFuncionalidadByMenuOptionPermitido(tx, nbAlias, nbComponente, codAplicacion, oFuncionalidadResponse);
            return oDataResponse;

        }
        public DataResponse CountFuncionalidadByMenuOptionPermitido(string nbAlias, string nbComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new CountFuncionalidadBySubMenuOptionPermitidoDelegate(CountFuncionalidadByMenuOptionPermitido), nbAlias, nbComponente, codAplicacion, oFuncionalidadResponse) as DataResponse;
        }

        delegate DataResponse CountFuncionalidadBySubMenuOptionPermitido2Delegate(TransactionalContext tx, string nbAlias, string nbComponente, string nbSubComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse);
        public static DataResponse CountFuncionalidadByMenuOptionPermitido(TransactionalContext tx, string nbAlias, string nbComponente, string nbSubComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse)
        {
            DataResponse oDataResponse = SecurityStore.CountFuncionalidadByMenuOptionPermitido(tx, nbAlias, nbComponente, nbSubComponente, codAplicacion, oFuncionalidadResponse);
            return oDataResponse;
        }
        public DataResponse CountFuncionalidadByMenuOptionPermitido(string nbAlias, string nbComponente, string nbSubComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new CountFuncionalidadBySubMenuOptionPermitido2Delegate(CountFuncionalidadByMenuOptionPermitido), nbAlias, nbComponente, nbSubComponente, codAplicacion, oFuncionalidadResponse) as DataResponse;
        }

        delegate DataResponse AccesoPermitidoDelegate(TransactionalContext tx, string nbAlias, string codAplicacion);
        public DataResponse AccesoPermitido(TransactionalContext tx, string nbAlias, string codAplicacion)
        {
            DataResponse oDataResponse = SecurityStore.AccesoPermitido(tx, nbAlias, codAplicacion);
            return oDataResponse;
        }
        public DataResponse AccesoPermitido(string nbAlias, string codAplicacion)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AccesoPermitidoDelegate(AccesoPermitido), nbAlias, codAplicacion) as DataResponse;
        }

        delegate DataResponse AccesoPermitidoByFuncionalidadDelegate(TransactionalContext tx, string nbAlias, int idFuncionalidad, string codAplicacion);
        public static DataResponse AccesoPermitido(TransactionalContext tx, string nbAlias, int idFuncionalidad, string codAplicacion)
        {
            DataResponse oDataResponse = SecurityStore.AccesoPermitido(tx, nbAlias, idFuncionalidad, codAplicacion);
            return oDataResponse;
        }
        public DataResponse AccesoPermitido(string nbAlias, int idFuncionalidad, string codAplicacion)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AccesoPermitidoByFuncionalidadDelegate(AccesoPermitido), nbAlias, idFuncionalidad, codAplicacion) as DataResponse;
        }



        delegate DataResponse GetFuncionalidadByUsuarioDelegate(TransactionalContext tx, string nbAlias, string codAplicacion, ref FuncionalidadList oFuncionalidadListResponse);
        public static DataResponse GetFuncionalidadByUsuario(TransactionalContext tx, string nbAlias, string codAplicacion, ref FuncionalidadList oFuncionalidadListResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetFuncionalidadByUsuario(tx, nbAlias, codAplicacion, oFuncionalidadListResponse);
            return oDataResponse;
        }
        public DataResponse GetFuncionalidadByUsuario(string nbAlias, string codAplicacion, ref FuncionalidadList oFuncionalidadListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetFuncionalidadByUsuarioDelegate(GetFuncionalidadByUsuario), nbAlias, codAplicacion, oFuncionalidadListResponse) as DataResponse;
        }

    }
}