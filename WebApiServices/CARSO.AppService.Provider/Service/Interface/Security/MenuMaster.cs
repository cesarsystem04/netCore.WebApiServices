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
        DataResponse AddMenuMaster(MenuMaster oMenuMaster);
        [OperationContract()]
        DataResponse GetMenuMasterByCriterio(ref MenuMasterList oMenuMasterListResponse, string codAplicacion, string nbAlias, int idCodigoCategoria = 0, int idMenuMasterParent = 0);
        [OperationContract()]
        DataResponse GetMenuMasterByKey(int idMenuMaster, ref MenuMaster oMenuMasterResponse);

        [OperationContract()]
        DataResponse GetMenuMasterBARolSolicitante(int idCodigoCategoria,ref MenuMasterList oMenuMasterListResponse);
      
    }
}
