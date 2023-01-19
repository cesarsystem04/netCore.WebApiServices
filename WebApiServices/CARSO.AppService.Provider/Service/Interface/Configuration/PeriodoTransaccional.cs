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
        [OperationContract()]
        DataResponse GetPeriodoTransaccionalAll(string codAplicacion, EstatusActivo Estatus, ref PeriodoTransaccionalList oPeriodoTransaccionalListResponse);
        [OperationContract]
        DataResponse GetPeriodoTransaccional(Int32 idPeriodo, ref PeriodoTransaccional oPeriodoTransaccionalResponse);
        [OperationContract]
        DataResponse GetPeriodoTransaccionalByNoMax();

    }
}
