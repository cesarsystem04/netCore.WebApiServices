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
        public DataResponse AddTipoProcesoXPeriodo(Int32 idPeriodo, Int32 idCodigoTipoProcesoMasivo)
        {
            return Channel.AddTipoProcesoXPeriodo(idPeriodo, idCodigoTipoProcesoMasivo);
        }

        public DataResponse DelTipoProcesoXPeriodoByPeriodo(Int32 idPeriodo)
        {
            return Channel.DelTipoProcesoXPeriodoByPeriodo(idPeriodo);
        }

        public DataResponse GetTipoProcesoXPeriodoByPeriodo(Int32 idPeriodo, ref TipoProcesoXPeriodoList oTipoProcesoXPeriodoListResponse)
        {
            return Channel.GetTipoProcesoXPeriodoByPeriodo(idPeriodo, ref oTipoProcesoXPeriodoListResponse);
        }

    }
}
