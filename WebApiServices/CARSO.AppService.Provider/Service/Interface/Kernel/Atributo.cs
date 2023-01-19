using System;
using System.Collections.Generic;
using System.Text;
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
        DataResponse AddAtributo(Atributo oAtributo);
        [OperationContract()]
        DataResponse GetAtributoByKey(ref Atributo oAtributoResponse, int idAtributo);
        [OperationContract()]
        DataResponse GetAtributoByCriterio(ref AtributoList oAtributoListResponse, int idAtributo = 0, int idObjeto = 0, string nbAtributo = "", string nbFisico = "", int esFiltrado = 2, int esPK = 2, int esFK = 2, int esObligatorio = 2, int esActivo = 2, int idCodigoTipoAtributo = 0, int noCatalogo = 0, string dsLabel = "", int noLength = 0, int noPrecision = 0, int noScale = 0);

    }
}
