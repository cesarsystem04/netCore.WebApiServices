﻿using System.ServiceModel;
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
        DataResponse GetUbicacionAll( ref UbicacionList oUbicacionListResponse);
        [OperationContract]
        DataResponse GetUbicacionByKey(string codEdificio, ref Ubicacion oUbicacionListResponse);


    }
}