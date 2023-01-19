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

        [OperationContract]
        DataResponse AddEtiquetaXCulturaUpdate(EtiquetaXCultura oEtiquetaXCultura);
        [OperationContract]
        DataResponse GetEtiquetaXCulturaByKey(string codEtiqueta, string codConjunto, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCultura oEtiquetaXCulturaResponse);
        [OperationContract]
        DataResponse GetEtiquetaXCulturaBycodEtiqueta(string codEtiqueta, ref EtiquetaXCulturaList oEtiquetaXCulturaListResponse);
        [OperationContract]
        DataResponse EtiquetaXCulturaDeleteByCodigo(string codEtiqueta, string codConjunto, string codAplicacion, string nbLanguageCulture);

        [OperationContract]
        DataResponse EtiquetaXCulturaDeleteBycodEtiqueta(string codEtiqueta, string codConjunto, string codAplicacion);

        [OperationContract]
        DataResponse GetEtiquetaXCulturaGetByCodConjuntoAndnbLangeageCulture(string codConjunto, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse);
      
        [OperationContract]
        DataResponse GetEtiquetaXCulturaGetByCodEtiquetaNormaAndnbLangeageCulture(string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse);

        [OperationContract]
        DataResponse GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCulture(string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse);

        [OperationContract]
        DataResponse GetEtiquetaXCulturaGetByCodEtiquetaClasificadorVisibleAndnbLangeageCulture(string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse);

        [OperationContract]
        DataResponse GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCultureandidNorma(string codEtiqueta, string codAplicacion, string nbLanguageCulture,int idNorma, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse);
       
        [OperationContract]
        DataResponse GetEtiquetaXCulturaGetByCodEtiquetas(string codEtiqueta, string codAplicacion, string nbLanguageCulture,  ref EtiquetaXCulturaList oEtiquetaXCulturaResponse);
   

    }
}
