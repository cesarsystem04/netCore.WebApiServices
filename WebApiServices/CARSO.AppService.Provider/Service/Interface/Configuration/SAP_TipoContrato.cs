using CARSO.AppService.ServiceDataContainers;
using System.ServiceModel;

namespace CARSO.AppService.Provider.Service
{
    public partial interface IAppService
    {
        [OperationContract]
        DataResponse GetTipoContratoAll(ref TipoContratoList oTipoContratoList);
        [OperationContract]
        DataResponse GetTipoContratoByKey(string codTipoContrato, ref TipoContrato oTipoContrato);
    }
}