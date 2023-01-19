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
        DataResponse GetSubDivisionAll(ref SubDivisionList oSubDivisionListResponse);
        [OperationContract]
        DataResponse GetSubDivisionByKey(string codSubdivision, string codDivision, ref SubDivision oSubDivisionListResponse);

        [OperationContract]
        DataResponse GetSubDivisionByDivisiones(string codSubdivisiones, ref SubDivisionList oSubDivisionListResponse);


    }
}
