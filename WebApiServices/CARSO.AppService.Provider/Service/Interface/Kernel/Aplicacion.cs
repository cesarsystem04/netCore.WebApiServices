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
        DataResponse AddAplicacion(Aplicacion oAplicacion);
        [OperationContract()]
        DataResponse GetAplicacionByKey(ref Aplicacion oAplicacionResponse, string codAplicacion);

    }
}
