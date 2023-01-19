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
        delegate DataResponse AddPeriodoTransaccionalDelegate(TransactionalContext tx, PeriodoTransaccional oPeriodoTransaccional);
        public static DataResponse AddPeriodoTransaccional(TransactionalContext tx, PeriodoTransaccional oPeriodoTransaccional)
        {
            DataResponse oDataResponse = ConfigurationStore.AddPeriodoTransaccional(tx, oPeriodoTransaccional);
            return oDataResponse;
        }
        public DataResponse AddPeriodoTransaccional(PeriodoTransaccional oPeriodoTransaccional)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddPeriodoTransaccionalDelegate(AddPeriodoTransaccional), oPeriodoTransaccional) as DataResponse;
        }


        delegate DataResponse GetPeriodoTransaccionalAllDelegate(TransactionalContext tx, string codAplicacion, EstatusActivo Estatus, ref PeriodoTransaccionalList oPeriodoTransaccionalListResponse);
        public static DataResponse GetPeriodoTransaccionalAll(TransactionalContext tx, string codAplicacion, EstatusActivo Estatus, ref PeriodoTransaccionalList oPeriodoTransaccionalListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetPeriodoTransaccionalAll(tx, codAplicacion, Estatus, oPeriodoTransaccionalListResponse);
            return oDataResponse;
        }
        public DataResponse GetPeriodoTransaccionalAll(string codAplicacion, EstatusActivo Estatus, ref PeriodoTransaccionalList oPeriodoTransaccionalListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetPeriodoTransaccionalAllDelegate(GetPeriodoTransaccionalAll), codAplicacion, Estatus, oPeriodoTransaccionalListResponse) as DataResponse;
        }

        delegate DataResponse GetPeriodoTransaccionalDelegate(TransactionalContext tx, Int32 idPeriodo, ref PeriodoTransaccional oPeriodoTransaccionalResponse);
        public static DataResponse GetPeriodoTransaccional(TransactionalContext tx, Int32 idPeriodo, ref PeriodoTransaccional oPeriodoTransaccionalResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetPeriodoTransaccional(tx, idPeriodo, oPeriodoTransaccionalResponse);
            return oDataResponse;
        }
        public DataResponse GetPeriodoTransaccional(Int32 idPeriodo, ref PeriodoTransaccional oPeriodoTransaccionalResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetPeriodoTransaccionalDelegate(GetPeriodoTransaccional), idPeriodo, oPeriodoTransaccionalResponse) as DataResponse;
        }

        delegate DataResponse GetPeriodoTransaccionalByNoMaxDelegate(TransactionalContext tx);
        public static DataResponse GetPeriodoTransaccionalByNoMax(TransactionalContext tx)
        {
            DataResponse oDataResponse = ConfigurationStore.GetPeriodoTransaccionalByNoMax(tx);
            return oDataResponse;
        }
        public DataResponse GetPeriodoTransaccionalByNoMax()
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetPeriodoTransaccionalByNoMaxDelegate(GetPeriodoTransaccionalByNoMax)) as DataResponse;
        }

    }
}
