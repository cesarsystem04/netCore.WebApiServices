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
     
        public DataResponse GetSubDivisionAll( ref SubDivisionList oSubDivisionListResponse)
        {
            return Channel.GetSubDivisionAll( ref oSubDivisionListResponse);
        }

        public DataResponse GetSubDivisionByKey(string codSubdivision, string codDivision, ref SubDivision oSubDivisionListResponse)
        {
            return Channel.GetSubDivisionByKey(codSubdivision, codDivision, ref oSubDivisionListResponse);
        }
        public DataResponse GetSubDivisionByDivisiones(string codDivisiones, ref SubDivisionList oSubDivisionListResponse)
        {
            return Channel.GetSubDivisionByDivisiones( codDivisiones, ref oSubDivisionListResponse);
        }

    }
}
