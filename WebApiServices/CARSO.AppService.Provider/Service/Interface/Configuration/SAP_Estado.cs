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
        DataResponse GetEstadoAll( ref EstadoList oEstadoListResponse);
        [OperationContract]
        DataResponse GetEstadoByEstado(string codEstado, ref EstadoList oEstadoListResponse);
        [OperationContract]
        DataResponse GetEstadoByKey(string codEstado, string codMunicipio, ref Estado oEstadoListResponse);


    }
}
