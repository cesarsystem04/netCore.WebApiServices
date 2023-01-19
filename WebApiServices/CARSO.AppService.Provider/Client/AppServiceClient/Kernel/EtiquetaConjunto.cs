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

        public DataResponse AddEtiquetaConjuntoUpdate(EtiquetaConjunto oEtiquetaConjunto)
        {
            return Channel.AddEtiquetaConjuntoUpdate(oEtiquetaConjunto);
        }

        public DataResponse GetEtiquetaConjuntoByKey(string codConjunto, string codAplicacion, ref EtiquetaConjunto oEtiquetaConjuntoResponse)
        {
            return Channel.GetEtiquetaConjuntoByKey(codConjunto, codAplicacion, ref oEtiquetaConjuntoResponse);
        }
        public DataResponse EtiquetaConjuntoDeleteByCodigo(string codConjunto, string codAplicacion)
        {
            return Channel.EtiquetaConjuntoDeleteByCodigo(codConjunto, codAplicacion);
        }

    }
}
