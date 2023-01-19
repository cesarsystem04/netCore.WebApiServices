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
        DataResponse GetAreaNominaAll( ref AreaNominaList oAreaNominaListResponse);
        [OperationContract]
        DataResponse GetAreaNominaByKey(string codAreaNomina, ref AreaNomina oAreaNominaListResponse);


    }
}
