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
        DataResponse GetAreaFuncionalAll( ref AreaFuncionalList oAreaFuncionalListResponse);
        [OperationContract]
        DataResponse GetAreaFuncionalByKey(string codAreaFuncional, ref AreaFuncional oAreaFuncionalListResponse);


    }
}
