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
     
        public DataResponse GetDivisionAll( ref DivisionList oDivisionListResponse)
        {
            return Channel.GetDivisionAll(ref oDivisionListResponse);
        }

        public DataResponse GetDivisionByKey(string codDivision, ref Division oDivisionListResponse)
        {
            return Channel.GetDivisionByKey(codDivision, ref oDivisionListResponse);
        }

        public DataResponse GetDivisionBySociedad(string codSociedad, ref DivisionList oDivisionListResponse)
        {
            return Channel.GetDivisionBySociedad(codSociedad, ref oDivisionListResponse);
        }
        public DataResponse GetDivisionBySociedades(string codSociedades, ref DivisionList oDivisionListResponse)
        {
            return Channel.GetDivisionBySociedades(codSociedades, ref oDivisionListResponse);
        }



    }
}
