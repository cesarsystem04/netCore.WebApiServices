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
        public DataResponse AddPeriodoTransaccional(PeriodoTransaccional oPeriodoTransaccional)
        {
            return Channel.AddPeriodoTransaccional(oPeriodoTransaccional);
        }

        public DataResponse GetPeriodoTransaccionalAll(string codAplicacion, EstatusActivo Estatus, ref PeriodoTransaccionalList oPeriodoTransaccionalListResponse)
        {
            return Channel.GetPeriodoTransaccionalAll(codAplicacion, Estatus, ref oPeriodoTransaccionalListResponse);
        }

        public DataResponse GetPeriodoTransaccional(Int32 idPeriodo, ref PeriodoTransaccional oPeriodoTransaccionalResponse)
        {
            return Channel.GetPeriodoTransaccional(idPeriodo, ref oPeriodoTransaccionalResponse);
        }

        public DataResponse GetPeriodoTransaccionalByNoMax()
        {
            return Channel.GetPeriodoTransaccionalByNoMax();
        }

    }
}
