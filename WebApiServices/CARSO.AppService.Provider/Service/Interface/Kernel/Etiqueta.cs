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
        DataResponse AddEtiquetaUpdate(Etiqueta oEtiqueta);
        [OperationContract]
        DataResponse GetEtiquetaByKey(string codEtiqueta, string codConjunto, string codAplicacion, ref Etiqueta oEtiquetaResponse);
        [OperationContract]
        DataResponse EtiquetaDeleteByCodigo(string codEtiqueta, string codConjunto, string codAplicacion);


    }
}
