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

        public DataResponse GetTipoContratoAll(ref TipoContratoList oTipoContratoList)
        {
            return Channel.GetTipoContratoAll(ref oTipoContratoList);
        }

        public DataResponse GetTipoContratoByKey(string codTipoContrato, ref TipoContrato oTipoContrato)
        {
            return Channel.GetTipoContratoByKey(codTipoContrato, ref oTipoContrato);
        }
    }
}