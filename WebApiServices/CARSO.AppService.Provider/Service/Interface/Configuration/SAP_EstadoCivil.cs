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
        DataResponse GetEstadoCivilByAll( ref EstadoCivilList oEstadoCivilListResponse);
        [OperationContract]
        DataResponse GetEstadoCivilByKey(string codEstadoCivil, ref EstadoCivilList oEstadoCivilListResponse);


    }
}
