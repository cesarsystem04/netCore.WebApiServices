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

        public DataResponse AddEtiquetaXCulturaUpdate(EtiquetaXCultura oEtiquetaXCultura)
        {
            return Channel.AddEtiquetaXCulturaUpdate(oEtiquetaXCultura);
        }

        public DataResponse GetEtiquetaXCulturaByKey(string codEtiqueta, string codConjunto, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCultura oEtiquetaXCulturaResponse)
        {
            return Channel.GetEtiquetaXCulturaByKey(codEtiqueta, codConjunto, codAplicacion, nbLanguageCulture, ref oEtiquetaXCulturaResponse);
        }
        public DataResponse GetEtiquetaXCulturaBycodEtiqueta(string codEtiqueta, ref EtiquetaXCulturaList oEtiquetaXCulturaListResponse)
        {
            return Channel.GetEtiquetaXCulturaBycodEtiqueta(codEtiqueta, ref oEtiquetaXCulturaListResponse);
        }

        public DataResponse EtiquetaXCulturaDeleteByCodigo(string codEtiqueta, string codConjunto, string codAplicacion, string nbLanguageCulture)
        {
            return Channel.EtiquetaXCulturaDeleteByCodigo(codEtiqueta, codConjunto, codAplicacion, nbLanguageCulture);
        }
        public DataResponse EtiquetaXCulturaDeleteBycodEtiqueta(string codEtiqueta, string codConjunto, string codAplicacion)
        {
            return Channel.EtiquetaXCulturaDeleteBycodEtiqueta(codEtiqueta, codConjunto, codAplicacion);
        }

        public DataResponse GetEtiquetaXCulturaGetByCodConjuntoAndnbLangeageCulture( string codConjunto, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            return Channel.GetEtiquetaXCulturaGetByCodConjuntoAndnbLangeageCulture( codConjunto, codAplicacion, nbLanguageCulture, ref oEtiquetaXCulturaResponse);
        }
        public DataResponse GetEtiquetaXCulturaGetByCodEtiquetaNormaAndnbLangeageCulture(string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            return Channel.GetEtiquetaXCulturaGetByCodEtiquetaNormaAndnbLangeageCulture(codEtiqueta, codAplicacion, nbLanguageCulture, ref oEtiquetaXCulturaResponse);
        }
        public DataResponse GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCulture(string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            return Channel.GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCulture(codEtiqueta, codAplicacion, nbLanguageCulture, ref oEtiquetaXCulturaResponse);
        }

        public DataResponse GetEtiquetaXCulturaGetByCodEtiquetaClasificadorVisibleAndnbLangeageCulture(string codEtiqueta, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            return Channel.GetEtiquetaXCulturaGetByCodEtiquetaClasificadorVisibleAndnbLangeageCulture(codEtiqueta, codAplicacion, nbLanguageCulture, ref oEtiquetaXCulturaResponse);
        }

        public DataResponse GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCultureandidNorma(string codEtiqueta, string codAplicacion, string nbLanguageCulture,int idNorma, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            return Channel.GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCultureandidNorma(codEtiqueta, codAplicacion, nbLanguageCulture,idNorma, ref oEtiquetaXCulturaResponse);
        }
        public DataResponse GetEtiquetaXCulturaGetByCodEtiquetas(string codEtiquetas, string codAplicacion, string nbLanguageCulture, ref EtiquetaXCulturaList oEtiquetaXCulturaResponse)
        {
            return Channel.GetEtiquetaXCulturaGetByCodEtiquetas(codEtiquetas, codAplicacion, nbLanguageCulture,  ref oEtiquetaXCulturaResponse);
        }
    }
}
