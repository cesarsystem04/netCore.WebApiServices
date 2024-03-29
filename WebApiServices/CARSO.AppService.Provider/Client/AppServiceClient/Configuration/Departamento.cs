﻿using System;
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
        public DataResponse GetDeptoByGrupoAndSectorAndEmpresaAndFilialDM(string noGrupo, string codSector, string codEmpresa, string codFilial, ref DepartamentoDMList oDepartamentoDMList)
        {
            return Channel.GetDeptoByGrupoAndSectorAndEmpresaAndFilialDM(noGrupo, codSector, codEmpresa, codFilial, ref oDepartamentoDMList);
        }
    }
}
