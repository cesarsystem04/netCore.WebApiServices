using System;
using System.Security.Principal;
using System.Runtime.InteropServices;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.LogLibrary.ServiceOperations;
using System.Threading.Tasks;
using CARSO.AppService.ServiceDataContainers;
using CARSO.AppService.ServiceDataAccess;
using System.Configuration;

namespace CARSO.AppService.Provider.Service
{
    public partial class AppService : IAppService
    {

        delegate DataResponse AddAtributoDelegate(TransactionalContext tx, Atributo oAtributo);
        public static DataResponse AddAtributo(TransactionalContext tx, Atributo oAtributo)
        {
            DataResponse oDataResponse = KernelStore.AddAtributo(tx, oAtributo);
            return oDataResponse;
        }
        public DataResponse AddAtributo(Atributo oAtributo)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddAtributoDelegate(AddAtributo), oAtributo) as DataResponse;
        }

        delegate DataResponse GetAtributoByKeyDelegate(TransactionalContext tx, ref Atributo oAtributoResponse, int idAtributo);
        public static DataResponse GetAtributoByKey(TransactionalContext tx, ref Atributo oAtributoResponse, int idAtributo)
        {
            DataResponse oDataResponse = KernelStore.GetAtributoByKey(tx, oAtributoResponse, idAtributo);
            return oDataResponse;
        }
        public DataResponse GetAtributoByKey(ref Atributo oAtributoResponse, int idAtributo)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetAtributoByKeyDelegate(GetAtributoByKey), oAtributoResponse, idAtributo) as DataResponse;
        }

        delegate DataResponse GetAtributoByCriterioDelegate(TransactionalContext tx, ref AtributoList oAtributoListResponse, int idAtributo = 0, int idObjeto = 0, string nbAtributo = "", string nbFisico = "", int esFiltrado = 2, int esPK = 2, int esFK = 2, int esObligatorio = 2, int esActivo = 2, int idCodigoTipoAtributo = 0, int noCatalogo = 0, string dsLabel = "", int noLength = 0, int noPrecision = 0, int noScale = 0);
        public static DataResponse GetAtributoByCriterio(TransactionalContext tx, ref AtributoList oAtributoListResponse, int idAtributo = 0, int idObjeto = 0, string nbAtributo = "", string nbFisico = "", int esFiltrado = 2, int esPK = 2, int esFK = 2, int esObligatorio = 2, int esActivo = 2, int idCodigoTipoAtributo = 0, int noCatalogo = 0, string dsLabel = "", int noLength = 0, int noPrecision = 0, int noScale = 0)
        {
            DataResponse oDataResponse = KernelStore.GetAtributoByCriterio(tx, oAtributoListResponse, idAtributo, idObjeto, nbAtributo, nbFisico, esFiltrado, esPK, esFK, esObligatorio, esActivo, idCodigoTipoAtributo, noCatalogo, dsLabel, noLength, noPrecision, noScale);
            return oDataResponse;
        }
        public DataResponse GetAtributoByCriterio(ref AtributoList oAtributoListResponse, int idAtributo = 0, int idObjeto = 0, string nbAtributo = "", string nbFisico = "", int esFiltrado = 2, int esPK = 2, int esFK = 2, int esObligatorio = 2, int esActivo = 2, int idCodigoTipoAtributo = 0, int noCatalogo = 0, string dsLabel = "", int noLength = 0, int noPrecision = 0, int noScale = 0)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetAtributoByCriterioDelegate(GetAtributoByCriterio), oAtributoListResponse, idAtributo, idObjeto, nbAtributo, nbFisico, esFiltrado, esPK, esFK, esObligatorio, esActivo, idCodigoTipoAtributo, noCatalogo, dsLabel, noLength, noPrecision, noScale) as DataResponse;
        }

    }
}
