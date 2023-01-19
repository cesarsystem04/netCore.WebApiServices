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

        public DataResponse AddEtiquetaUpdate(Etiqueta oEtiqueta)
        {
            return Channel.AddEtiquetaUpdate(oEtiqueta);
        }
        public DataResponse GetEtiquetaByKey(string codEtiqueta, string codConjunto, string codAplicacion, ref Etiqueta oEtiquetaResponse)
        {
            return Channel.GetEtiquetaByKey(codEtiqueta, codConjunto, codAplicacion, ref oEtiquetaResponse);
        }
        public DataResponse EtiquetaDeleteByCodigo(string codEtiqueta, string codConjunto, string codAplicacion)
        {
            return Channel.EtiquetaDeleteByCodigo(codEtiqueta, codConjunto, codAplicacion);
        }
    }
}
