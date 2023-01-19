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
        DataResponse GetDivisionAll(ref DivisionList oDivisionListResponse);
        [OperationContract]
        DataResponse GetDivisionByKey(string codDivision, ref Division oDivisionListResponse);

        [OperationContract]
        DataResponse GetDivisionBySociedad(string codSociedad, ref DivisionList oDivisionListResponse);
        [OperationContract]
        DataResponse GetDivisionBySociedades(string codSociedades, ref DivisionList oDivisionListResponse);


    }
}
