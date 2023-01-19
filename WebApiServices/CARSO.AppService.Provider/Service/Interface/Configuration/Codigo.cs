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
        [OperationContract()]
        DataResponse GetCodigoByCatalogo(CatalogoTipo TipoCatalogo, EstatusActivo Estatus, ref CodigoList oCodigoListResponse);
        [OperationContract]
        DataResponse GetCodigoByKey(int idCodigo, ref Codigo oCodigoResponse);
        [OperationContract]
        DataResponse GetCodigoByCatalogoAndDsExtra(CatalogoTipo TipoCatalogo, string dsExtra, ref Codigo oCodigoResponse);
        [OperationContract]
        DataResponse GetCodigoByCatalogoAndRfExterna(CatalogoTipo TipoCatalogo, string rfExterna, ref Codigo oCodigoResponse);

    }
}
