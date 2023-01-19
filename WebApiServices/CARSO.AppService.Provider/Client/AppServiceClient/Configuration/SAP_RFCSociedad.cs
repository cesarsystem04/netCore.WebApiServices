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

    
        public DataResponse GetRFCSociedadAll( ref RFCSociedadList oRFCSociedadListResponse)
        {
            return Channel.GetRFCSociedadAll(ref oRFCSociedadListResponse);
        }

        public DataResponse GetRFCSociedadByKey(string codSociedad, ref RFCSociedad oRFCSociedadResponse)
        {
            return Channel.GetRFCSociedadByKey(codSociedad, ref oRFCSociedadResponse);
        }

   

    }
}
