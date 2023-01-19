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
        delegate DataResponse GetCodigoByCatalogoDelegate(TransactionalContext tx, CatalogoTipo TipoCatalogo, EstatusActivo Estatus, ref CodigoList oCodigoListResponse);
        public static DataResponse GetCodigoByCatalogo(TransactionalContext tx, CatalogoTipo TipoCatalogo, EstatusActivo Estatus, ref CodigoList oCodigoListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetCodigoByCatalogo(tx, TipoCatalogo.GetHashCode(), Estatus, oCodigoListResponse);
            return oDataResponse;
        }
        public DataResponse GetCodigoByCatalogo(CatalogoTipo TipoCatalogo, EstatusActivo Estatus, ref CodigoList oCodigoListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetCodigoByCatalogoDelegate(GetCodigoByCatalogo), TipoCatalogo, Estatus, oCodigoListResponse) as DataResponse;
        }


        delegate DataResponse GetCodigoByKeyDelegate(TransactionalContext tx, int idCodigo, ref Codigo oCodigoResponse);
        public static DataResponse GetCodigoByKey(TransactionalContext tx, int idCodigo, ref Codigo oCodigoResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetCodigoByKey(tx, idCodigo, oCodigoResponse);
            return oDataResponse;
        }
        public DataResponse GetCodigoByKey(int idCodigo, ref Codigo oCodigoResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetCodigoByKeyDelegate(GetCodigoByKey), idCodigo, oCodigoResponse) as DataResponse;
        }

        delegate DataResponse GetCodigoByCatalogoAndDsExtraDelegate(TransactionalContext tx, CatalogoTipo TipoCatalogo, string dsExtra, ref Codigo oCodigoResponse);
        public static DataResponse GetCodigoByCatalogoAndDsExtra(TransactionalContext tx, CatalogoTipo TipoCatalogo, string dsExtra, ref Codigo oCodigoResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetCodigoByCatalogoAndDsExtra(tx, TipoCatalogo.GetHashCode(), dsExtra, oCodigoResponse);
            return oDataResponse;
        }
        public DataResponse GetCodigoByCatalogoAndDsExtra(CatalogoTipo TipoCatalogo, string dsExtra, ref Codigo oCodigoResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetCodigoByCatalogoAndDsExtraDelegate(GetCodigoByCatalogoAndDsExtra), TipoCatalogo, dsExtra, oCodigoResponse) as DataResponse;
        }

        delegate DataResponse GetCodigoByCatalogoAndRfExternaDelegate(TransactionalContext tx, CatalogoTipo TipoCatalogo, string rfExterna, ref Codigo oCodigoResponse);
        public static DataResponse GetCodigoByCatalogoAndRfExterna(TransactionalContext tx, CatalogoTipo TipoCatalogo, string rfExterna, ref Codigo oCodigoResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetCodigoByCatalogoAndRfExterna(tx, TipoCatalogo.GetHashCode(), rfExterna, oCodigoResponse);
            return oDataResponse;
        }
        public DataResponse GetCodigoByCatalogoAndRfExterna(CatalogoTipo TipoCatalogo, string rfExterna, ref Codigo oCodigoResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetCodigoByCatalogoAndRfExternaDelegate(GetCodigoByCatalogoAndRfExterna), TipoCatalogo, rfExterna, oCodigoResponse) as DataResponse;
        }
    }
}
