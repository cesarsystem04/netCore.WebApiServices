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
         DataResponse GetCentroCostoAll( ref CentroCostoList oCentroCostoListResponse);
        [OperationContract]
        DataResponse GetCentroCostoByKey(string codCentroCosto, ref CentroCosto oCentroCostoListResponse);

        [OperationContract]
        DataResponse GetCentroCostoBySociedad(string codSociedad, ref CentroCostoList oCentroCostoListResponse);
        [OperationContract]
        DataResponse GetCentroCostoBySociedades(string codSociedades, ref CentroCostoList oCentroCostoListResponse);


    }
}
