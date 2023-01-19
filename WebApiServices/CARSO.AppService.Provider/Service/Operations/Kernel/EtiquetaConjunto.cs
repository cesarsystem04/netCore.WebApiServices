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


        delegate DataResponse AddEtiquetaConjuntoUpdateDelegate(TransactionalContext tx, EtiquetaConjunto oEtiquetaConjunto);
        public static DataResponse AddEtiquetaConjuntoUpdate(TransactionalContext tx, EtiquetaConjunto oEtiquetaConjunto)
        {
            DataResponse oDataResponse = KernelStore.AddEtiquetaConjuntoUpdate(tx, oEtiquetaConjunto);
            return oDataResponse;
        }
        public DataResponse AddEtiquetaConjuntoUpdate(EtiquetaConjunto oEtiquetaConjunto)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddEtiquetaConjuntoUpdateDelegate(AddEtiquetaConjuntoUpdate), oEtiquetaConjunto) as DataResponse;
        }


        delegate DataResponse GetEtiquetaConjuntoByKeyDelegate(TransactionalContext tx, string codConjunto, string codAplicacion, ref EtiquetaConjunto oEtiquetaConjuntoResponse);
        public static DataResponse GetEtiquetaConjuntoByKey(TransactionalContext tx, string codConjunto, string codAplicacion, ref EtiquetaConjunto oEtiquetaConjuntoResponse)
        {
            DataResponse oDataResponse = KernelStore.GetEtiquetaConjuntoByKey(tx, codConjunto, codAplicacion, oEtiquetaConjuntoResponse);
            return oDataResponse;
        }
        public DataResponse GetEtiquetaConjuntoByKey(string codConjunto, string codAplicacion, ref EtiquetaConjunto oEtiquetaConjuntoResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetEtiquetaConjuntoByKeyDelegate(GetEtiquetaConjuntoByKey), codConjunto, codAplicacion, oEtiquetaConjuntoResponse) as DataResponse;
        }




        delegate DataResponse EtiquetaConjuntoDeleteByCodigoDelegate(TransactionalContext tx, string codConjunto, string codAplicacion);
        public static DataResponse EtiquetaConjuntoDeleteByCodigo(TransactionalContext tx, string codConjunto, string codAplicacion)
        {
            DataResponse oDataResponse = KernelStore.EtiquetaConjuntoDeleteByCodigo(tx, codConjunto, codAplicacion);
            return oDataResponse;
        }
        public DataResponse EtiquetaConjuntoDeleteByCodigo(string codConjunto, string codAplicacion)
        {
            return Processor.TransactionalRootObject_QueryOperation(new EtiquetaConjuntoDeleteByCodigoDelegate(EtiquetaConjuntoDeleteByCodigo), codConjunto, codAplicacion) as DataResponse;
        }


    }
}
