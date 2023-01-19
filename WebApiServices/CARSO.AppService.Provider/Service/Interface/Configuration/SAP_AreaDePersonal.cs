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
        DataResponse GetAreaDePersonalAll(ref AreaDePersonalList oAreaDePersonalListResponse);
        [OperationContract]
        DataResponse GetAreaDePersonalByKey(string codGrupoPersonal, string codAreaPersonal, ref AreaDePersonal oAreaDePersonalListResponse);


    }
}
