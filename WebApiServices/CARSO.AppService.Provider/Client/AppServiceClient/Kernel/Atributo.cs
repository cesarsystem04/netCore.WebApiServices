using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Security.Principal;
using System.IO;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.AppService.Provider.Service;
using CARSO.AppService.ServiceDataContainers;
using System.Threading.Tasks;

namespace CARSO.AppService.Provider.Client
{
    public partial class AppServiceClient : ClientBase<IAppService>, IAppService
    {
        public DataResponse AddAtributo(Atributo oAtributo)
        {
            return Channel.AddAtributo(oAtributo);
        }

        public DataResponse GetAtributoByKey(ref Atributo oAtributoResponse, int idAtributo)
        {
            return Channel.GetAtributoByKey(ref oAtributoResponse, idAtributo);
        }

        public DataResponse GetAtributoByCriterio(ref AtributoList oAtributoListResponse, int idAtributo = 0, int idObjeto = 0, string nbAtributo = "", string nbFisico = "", int esFiltrado = 2, int esPK = 2, int esFK = 2, int esObligatorio = 2, int esActivo = 2, int idCodigoTipoAtributo = 0, int noCatalogo = 0, string dsLabel = "", int noLength = 0, int noPrecision = 0, int noScale = 0)
        {
            return Channel.GetAtributoByCriterio(ref oAtributoListResponse, idAtributo, idObjeto, nbAtributo, nbFisico, esFiltrado, esPK, esFK, esObligatorio, esActivo, idCodigoTipoAtributo, noCatalogo, dsLabel, noLength, noPrecision, noScale);
        }

    }
}
