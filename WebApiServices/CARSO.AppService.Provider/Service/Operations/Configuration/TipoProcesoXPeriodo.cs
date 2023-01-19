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
        delegate DataResponse AddTipoProcesoXPeriodoDelegate(TransactionalContext tx, Int32 idPeriodo, Int32 idCodigoTipoProcesoMasivo);
        public static DataResponse AddTipoProcesoXPeriodo(TransactionalContext tx, Int32 idPeriodo, Int32 idCodigoTipoProcesoMasivo)
        {
            DataResponse oDataResponse = ConfigurationStore.AddTipoProcesoXPeriodo(tx, idPeriodo, idCodigoTipoProcesoMasivo);
            return oDataResponse;
        }
        public DataResponse AddTipoProcesoXPeriodo(Int32 idPeriodo, Int32 idCodigoTipoProcesoMasivo)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddTipoProcesoXPeriodoDelegate(AddTipoProcesoXPeriodo), idPeriodo, idCodigoTipoProcesoMasivo) as DataResponse;
        }

        delegate DataResponse DelTipoProcesoXPeriodoByPeriodoDelegate(TransactionalContext tx, Int32 idPeriodo);
        public static DataResponse DelTipoProcesoXPeriodoByPeriodo(TransactionalContext tx, Int32 idPeriodo)
        {
            DataResponse oDataResponse = ConfigurationStore.DelTipoProcesoXPeriodoByPeriodo(tx, idPeriodo);
            return oDataResponse;
        }
        public DataResponse DelTipoProcesoXPeriodoByPeriodo(Int32 idPeriodo)
        {
            return Processor.TransactionalRootObject_QueryOperation(new DelTipoProcesoXPeriodoByPeriodoDelegate(DelTipoProcesoXPeriodoByPeriodo), idPeriodo) as DataResponse;
        }

        delegate DataResponse GetTipoProcesoXPeriodoByPeriodoDelegate(TransactionalContext tx, Int32 idPeriodo, ref TipoProcesoXPeriodoList oTipoProcesoXPeriodoListResponse);
        public static DataResponse GetTipoProcesoXPeriodoByPeriodo(TransactionalContext tx, Int32 idPeriodo, ref TipoProcesoXPeriodoList oTipoProcesoXPeriodoListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetTipoProcesoXPeriodoByPeriodo(tx, idPeriodo, oTipoProcesoXPeriodoListResponse);
            return oDataResponse;
        }
        public DataResponse GetTipoProcesoXPeriodoByPeriodo(Int32 idPeriodo, ref TipoProcesoXPeriodoList oTipoProcesoXPeriodoListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetTipoProcesoXPeriodoByPeriodoDelegate(GetTipoProcesoXPeriodoByPeriodo), idPeriodo, oTipoProcesoXPeriodoListResponse) as DataResponse;
        }
    
    }
}
