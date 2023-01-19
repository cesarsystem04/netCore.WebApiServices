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
        delegate DataResponse AddMenuMasterDelegate(TransactionalContext tx, MenuMaster oMenuMaster);
        public static DataResponse AddMenuMaster(TransactionalContext tx, MenuMaster oMenuMaster)
        {
            DataResponse oDataResponse = SecurityStore.AddMenuMaster(tx, oMenuMaster);
            return oDataResponse;
        }
        public DataResponse AddMenuMaster(MenuMaster oMenuMaster)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddMenuMasterDelegate(AddMenuMaster), oMenuMaster) as DataResponse;
        }


        delegate DataResponse GetMenuMasterByCriterioDelegate(TransactionalContext tx, ref MenuMasterList oMenuMasterListResponse, string codAplicacion, string nbAlias, int idCodigoCategoria = 0, int idMenuMasterParent = 0);
        public static DataResponse GetMenuMasterByCriterio(TransactionalContext tx, ref MenuMasterList oMenuMasterListResponse, string codAplicacion, string nbAlias, int idCodigoCategoria = 0, int idMenuMasterParent = 0)
        {
            DataResponse oDataResponse = SecurityStore.GetMenuMasterByCriterio(tx, oMenuMasterListResponse, codAplicacion, nbAlias, idCodigoCategoria, idMenuMasterParent);
            return oDataResponse;
        }
        public DataResponse GetMenuMasterByCriterio(ref MenuMasterList oMenuMasterListResponse, string codAplicacion, string nbAlias, int idCodigoCategoria = 0, int idMenuMasterParent = 0)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetMenuMasterByCriterioDelegate(GetMenuMasterByCriterio), oMenuMasterListResponse, codAplicacion, nbAlias, idCodigoCategoria, idMenuMasterParent) as DataResponse;
        }


        delegate DataResponse GetMenuMasterByKeyDelegate(TransactionalContext tx, int idMenuMaster, ref MenuMaster oMenuMasterResponse);
        public static DataResponse GetMenuMasterByKey(TransactionalContext tx, int idMenuMaster, ref MenuMaster oMenuMasterResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetMenuMasterByKey(tx, idMenuMaster, oMenuMasterResponse);
            return oDataResponse;
        }
        public DataResponse GetMenuMasterByKey(int idMenuMaster, ref MenuMaster oMenuMasterResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetMenuMasterByKeyDelegate(GetMenuMasterByKey), idMenuMaster, oMenuMasterResponse) as DataResponse;
        }


        delegate DataResponse GetMenuMasterBARolSolicitanteDelegate(TransactionalContext tx, int idCodigoCategoria, ref MenuMasterList oMenuMasterListResponse);
        public static DataResponse GetMenuMasterBARolSolicitante(TransactionalContext tx,  int idCodigoCategoria, ref MenuMasterList oMenuMasterListResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetMenuMasterBARolSolicitante(tx,idCodigoCategoria, oMenuMasterListResponse);
            return oDataResponse;
        }
        public DataResponse GetMenuMasterBARolSolicitante( int idCodigoCategoria,ref MenuMasterList oMenuMasterListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetMenuMasterBARolSolicitanteDelegate(GetMenuMasterBARolSolicitante),idCodigoCategoria, oMenuMasterListResponse) as DataResponse;
        }


    }
}