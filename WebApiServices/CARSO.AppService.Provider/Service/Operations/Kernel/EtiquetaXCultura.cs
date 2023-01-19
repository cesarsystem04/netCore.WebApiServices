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

        delegate DataResponse AddEtiquetaXCulturaUpdateDelegate(TransactionalContext tx, EtiquetaXCultura oEtiquetaXCultura);
        public static DataResponse AddEtiquetaXCulturaUpdate(TransactionalContext tx, EtiquetaXCultura oEtiquetaXCultura)
        {
            DataResponse oDataResponse = KernelStore.AddEtiquetaXCulturaUpdate(tx, oEtiquetaXCultura);
            return oDataResponse;
        }
        public DataResponse AddEtiquetaXCulturaUpdate(EtiquetaXCultura oEtiquetaXCultura)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddEtiquetaXCulturaUpdateDelegate(AddEtiquetaXCulturaUpdate), oEtiquetaXCultura) as DataResponse;
        }


        delegate DataResponse GetEtiquetaXCulturaByKeyDelegate(TransactionalContext tx, string codEtiqueta, string codConjunto, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCultura oEtiquetaXCulturaResponse);
        public static DataResponse GetEtiquetaXCulturaByKey(TransactionalContext tx, string codEtiqueta, string codConjunto, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCultura oEtiquetaXCulturaResponse)
        {
            DataResponse oDataResponse = KernelStore.GetEtiquetaXCulturaByKey(tx, codEtiqueta, codConjunto, codAplicacion, nbLanguageCulture, oEtiquetaXCulturaResponse);
            return oDataResponse;
        }
        public DataResponse GetEtiquetaXCulturaByKey(string codEtiqueta, string codConjunto, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCultura oEtiquetaXCulturaResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetEtiquetaXCulturaByKeyDelegate(GetEtiquetaXCulturaByKey), codEtiqueta, codConjunto, codAplicacion, nbLanguageCulture, oEtiquetaXCulturaResponse) as DataResponse;
        }


        delegate DataResponse GetEtiquetaXCulturaBycodEtiquetaDelegate(TransactionalContext tx, string codEtiqueta, ref EtiquetaXCulturaList oEtiquetaXCulturaListResponse);
        public static DataResponse GetEtiquetaXCulturaBycodEtiqueta(TransactionalContext tx, string codEtiqueta, ref EtiquetaXCulturaList oEtiquetaXCulturaListResponse)
        {
            DataResponse oDataResponse = KernelStore.GetEtiquetaXCulturaBycodEtiqueta(tx, codEtiqueta, oEtiquetaXCulturaListResponse);
            return oDataResponse;
        }
        public DataResponse GetEtiquetaXCulturaBycodEtiqueta(string codEtiqueta, ref EtiquetaXCulturaList oEtiquetaXCulturaListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetEtiquetaXCulturaBycodEtiquetaDelegate(GetEtiquetaXCulturaBycodEtiqueta), codEtiqueta, oEtiquetaXCulturaListResponse) as DataResponse;
        }


        delegate DataResponse EtiquetaXCulturaDeleteByCodigoDelegate(TransactionalContext tx, string codEtiqueta, string codConjunto, string codAplicacion, string nbLanguageCulture);
        public static DataResponse EtiquetaXCulturaDeleteByCodigo(TransactionalContext tx, string codEtiqueta, string codConjunto, string codAplicacion, string nbLanguageCulture)
        {
            DataResponse oDataResponse = KernelStore.EtiquetaXCulturaDeleteByCodigo(tx, codEtiqueta, codConjunto, codAplicacion, nbLanguageCulture);
            return oDataResponse;
        }
        public DataResponse EtiquetaXCulturaDeleteByCodigo(string codEtiqueta, string codConjunto, string codAplicacion, string nbLanguageCulture)
        {
            return Processor.TransactionalRootObject_QueryOperation(new EtiquetaXCulturaDeleteByCodigoDelegate(EtiquetaXCulturaDeleteByCodigo), codEtiqueta, codConjunto, codAplicacion, nbLanguageCulture) as DataResponse;
        }



        delegate DataResponse EtiquetaXCulturaDeleteBycodEtiquetaDelegate(TransactionalContext tx, string codEtiqueta, string codConjunto, string codAplicacion);
        public static DataResponse EtiquetaXCulturaDeleteBycodEtiqueta(TransactionalContext tx, string codEtiqueta, string codConjunto, string codAplicacion)
        {
            DataResponse oDataResponse = KernelStore.EtiquetaXCulturaDeleteBycodEtiqueta(tx, codEtiqueta, codConjunto, codAplicacion);
            return oDataResponse;
        }
        public DataResponse EtiquetaXCulturaDeleteBycodEtiqueta(string codEtiqueta, string codConjunto, string codAplicacion)
        {
            return Processor.TransactionalRootObject_QueryOperation(new EtiquetaXCulturaDeleteBycodEtiquetaDelegate(EtiquetaXCulturaDeleteBycodEtiqueta), codEtiqueta, codConjunto, codAplicacion) as DataResponse;
        }


        delegate DataResponse GetEtiquetaXCulturaGetByCodConjuntoAndnbLangeageCultureDelegate(TransactionalContext tx,   string codConjunto, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse);
        public static DataResponse GetEtiquetaXCulturaGetByCodConjuntoAndnbLangeageCulture(TransactionalContext tx, string codConjunto, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            DataResponse oDataResponse = KernelStore.GetEtiquetaXCulturaGetByCodConjuntoAndnbLangeageCulture(tx,  codConjunto, codAplicacion, nbLanguageCulture, oEtiquetaXCulturaResponse);
            return oDataResponse;
        }
        public DataResponse GetEtiquetaXCulturaGetByCodConjuntoAndnbLangeageCulture(string codConjunto, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetEtiquetaXCulturaGetByCodConjuntoAndnbLangeageCultureDelegate(GetEtiquetaXCulturaGetByCodConjuntoAndnbLangeageCulture),  codConjunto, codAplicacion, nbLanguageCulture, oEtiquetaXCulturaResponse) as DataResponse;
        }


        delegate DataResponse GetEtiquetaXCulturaGetByCodEtiquetaNormaAndnbLangeageCultureDelegate(TransactionalContext tx, string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse);
        public static DataResponse GetEtiquetaXCulturaGetByCodEtiquetaNormaAndnbLangeageCulture(TransactionalContext tx, string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            DataResponse oDataResponse = KernelStore.GetEtiquetaXCulturaGetByCodEtiquetaNormaAndnbLangeageCulture(tx, codEtiqueta, codAplicacion, nbLanguageCulture, oEtiquetaXCulturaResponse);
            return oDataResponse;
        }
        public DataResponse GetEtiquetaXCulturaGetByCodEtiquetaNormaAndnbLangeageCulture(string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetEtiquetaXCulturaGetByCodEtiquetaNormaAndnbLangeageCultureDelegate(GetEtiquetaXCulturaGetByCodEtiquetaNormaAndnbLangeageCulture), codEtiqueta, codAplicacion, nbLanguageCulture, oEtiquetaXCulturaResponse) as DataResponse;
        }


        delegate DataResponse GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCultureDelegate(TransactionalContext tx, string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse);
        public static DataResponse GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCulture(TransactionalContext tx, string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            DataResponse oDataResponse = KernelStore.GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCulture(tx, codEtiqueta, codAplicacion, nbLanguageCulture, oEtiquetaXCulturaResponse);
            return oDataResponse;
        }
        public DataResponse GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCulture(string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCultureDelegate(GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCulture), codEtiqueta, codAplicacion, nbLanguageCulture, oEtiquetaXCulturaResponse) as DataResponse;
        }



        delegate DataResponse GetEtiquetaXCulturaGetByCodEtiquetaClasificadorVisibleAndnbLangeageCultureDelegate(TransactionalContext tx, string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse);
        public static DataResponse GetEtiquetaXCulturaGetByCodEtiquetaClasificadorVisibleAndnbLangeageCulture(TransactionalContext tx, string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            DataResponse oDataResponse = KernelStore.GetEtiquetaXCulturaGetByCodEtiquetaClasificadorVisibleAndnbLangeageCulture(tx, codEtiqueta, codAplicacion, nbLanguageCulture, oEtiquetaXCulturaResponse);
            return oDataResponse;
        }
        public DataResponse GetEtiquetaXCulturaGetByCodEtiquetaClasificadorVisibleAndnbLangeageCulture(string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetEtiquetaXCulturaGetByCodEtiquetaClasificadorVisibleAndnbLangeageCultureDelegate(GetEtiquetaXCulturaGetByCodEtiquetaClasificadorVisibleAndnbLangeageCulture), codEtiqueta, codAplicacion, nbLanguageCulture, oEtiquetaXCulturaResponse) as DataResponse;
        }



        delegate DataResponse GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCultureandidNormaDelegate(TransactionalContext tx, string codEtiqueta, string codAplicacion, string nbLanguageCulture,int idNorma, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse);
        public static DataResponse GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCultureandidNorma(TransactionalContext tx, string codEtiqueta, string codAplicacion, string nbLanguageCulture, int idNorma, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            DataResponse oDataResponse = KernelStore.GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCultureandidNorma(tx, codEtiqueta, codAplicacion, nbLanguageCulture, idNorma,oEtiquetaXCulturaResponse);
            return oDataResponse;
        }
        public DataResponse GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCultureandidNorma(string codEtiqueta, string codAplicacion, string nbLanguageCulture, int idNorma, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCultureandidNormaDelegate(GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCultureandidNorma), codEtiqueta, codAplicacion, nbLanguageCulture,idNorma, oEtiquetaXCulturaResponse) as DataResponse;
        }

        delegate DataResponse GetEtiquetaXCulturaGetByCodEtiquetasDelegate(TransactionalContext tx, string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse);
        public static DataResponse GetEtiquetaXCulturaGetByCodEtiquetas(TransactionalContext tx, string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            DataResponse oDataResponse = KernelStore.GetEtiquetaXCulturaGetByCodEtiquetas(tx, codEtiqueta, codAplicacion, nbLanguageCulture,  oEtiquetaXCulturaResponse);
            return oDataResponse;
        }
        public DataResponse GetEtiquetaXCulturaGetByCodEtiquetas(string codEtiqueta, string codAplicacion, string nbLanguageCulture,  ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetEtiquetaXCulturaGetByCodEtiquetasDelegate(GetEtiquetaXCulturaGetByCodEtiquetas), codEtiqueta, codAplicacion, nbLanguageCulture, oEtiquetaXCulturaResponse) as DataResponse;
        }
    }
}
