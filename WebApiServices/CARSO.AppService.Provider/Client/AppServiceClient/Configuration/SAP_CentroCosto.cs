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
    
        public DataResponse GetCentroCostoAll(ref CentroCostoList oCentroCostoListResponse)
        {
            return Channel.GetCentroCostoAll( ref oCentroCostoListResponse);
        }

        public DataResponse GetCentroCostoByKey(string codCentroCosto, ref CentroCosto oCentroCostoListResponse)
        {
            return Channel.GetCentroCostoByKey(codCentroCosto, ref oCentroCostoListResponse);
        }

        public DataResponse GetCentroCostoBySociedad(string codSociedad, ref CentroCostoList oCentroCostoListResponse)
        {
            return Channel.GetCentroCostoBySociedad(codSociedad, ref oCentroCostoListResponse);
        }

        public DataResponse GetCentroCostoBySociedades(string codSociedades, ref CentroCostoList oCentroCostoListResponse)
        {
            return Channel.GetCentroCostoBySociedades(codSociedades, ref oCentroCostoListResponse);
        }

    }
}
