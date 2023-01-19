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
        delegate DataResponse AddEtiquetaUpdateDelegate(TransactionalContext tx, Etiqueta oEtiqueta);
        public static DataResponse AddEtiquetaUpdate(TransactionalContext tx, Etiqueta oEtiqueta)
        {
            DataResponse oDataResponse = KernelStore.AddEtiquetaUpdate(tx, oEtiqueta);
            return oDataResponse;
        }
        public DataResponse AddEtiquetaUpdate(Etiqueta oEtiqueta)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddEtiquetaUpdateDelegate(AddEtiquetaUpdate), oEtiqueta) as DataResponse;
        }



        delegate DataResponse GetEtiquetaByKeyDelegate(TransactionalContext tx, string codEtiqueta, string codConjunto, string codAplicacion, ref Etiqueta oEtiquetaResponse);
        public static DataResponse GetEtiquetaByKey(TransactionalContext tx, string codEtiqueta, string codConjunto, string codAplicacion, ref Etiqueta oEtiquetaResponse)
        {
            DataResponse oDataResponse = KernelStore.GetEtiquetaByKey(tx, codEtiqueta, codConjunto, codAplicacion, oEtiquetaResponse);
            return oDataResponse;
        }
        public DataResponse GetEtiquetaByKey(string codEtiqueta, string codConjunto, string codAplicacion, ref Etiqueta oEtiquetaResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetEtiquetaByKeyDelegate(GetEtiquetaByKey), codEtiqueta, codConjunto, codAplicacion, oEtiquetaResponse) as DataResponse;
        }

        delegate DataResponse EtiquetaDeleteByCodigoDelegate(TransactionalContext tx, string codEtiqueta, string codConjunto, string codAplicacion);
        public static DataResponse EtiquetaDeleteByCodigo(TransactionalContext tx, string codEtiqueta, string codConjunto, string codAplicacion)
        {
            DataResponse oDataResponse = KernelStore.EtiquetaDeleteByCodigo(tx, codEtiqueta, codConjunto, codAplicacion);
            return oDataResponse;
        }
        public DataResponse EtiquetaDeleteByCodigo(string codEtiqueta, string codConjunto, string codAplicacion)
        {
            return Processor.TransactionalRootObject_QueryOperation(new EtiquetaDeleteByCodigoDelegate(EtiquetaDeleteByCodigo), codEtiqueta, codConjunto, codAplicacion) as DataResponse;
        }

    }
}
