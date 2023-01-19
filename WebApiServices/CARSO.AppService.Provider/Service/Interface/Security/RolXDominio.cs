﻿using System;
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
        DataResponse AddRolXDominio(RolXDominio oRolXDominio);
        [OperationContract()]
        DataResponse GetRolXDominioByKey(int codRol, string cvDominio, ref RolXDominio oRolXDominioResponse);

    }
}