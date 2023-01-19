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
        public DataResponse AddMenuMaster(MenuMaster oMenuMaster)
        {
            return Channel.AddMenuMaster(oMenuMaster);
        }
        public DataResponse GetMenuMasterByCriterio(ref MenuMasterList oMenuMasterListResponse, string codAplicacion, string nbAlias, int idCodigoCategoria = 0, int idMenuMasterParent = 0)
        {
            return Channel.GetMenuMasterByCriterio(ref oMenuMasterListResponse, codAplicacion, nbAlias, idCodigoCategoria, idMenuMasterParent);
        }
        public DataResponse GetMenuMasterByKey(int idMenuMaster, ref MenuMaster oMenuMasterResponse)
        {
            return Channel.GetMenuMasterByKey(idMenuMaster, ref oMenuMasterResponse);
        }

        public DataResponse GetMenuMasterBARolSolicitante(int idCodigoCategoria ,ref MenuMasterList oMenuMasterListResponse)
        {
            return Channel.GetMenuMasterBARolSolicitante(idCodigoCategoria,ref oMenuMasterListResponse);
        }
    }
}
