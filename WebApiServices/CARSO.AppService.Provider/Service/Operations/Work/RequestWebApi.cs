using CARSO.AppService.ServiceDataAccess;
using CARSO.AppService.ServiceDataContainers;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.LogLibrary.ServiceOperations;
using System;

namespace CARSO.AppService.Provider.Service
{
    /// <summary>
    /// Operaciones del esquema Work
    /// </summary>
	public partial class AppService : IAppService
    {
        /// <summary>
        /// Delegado para eliminado de un registro de RequestWebApi
        /// </summary>
        /// <param name="tx">conexión de base de datos</param>
        /// <param name="idRequest">Llave primeria del registro de la llamada a la web api de trálix</param>
        /// <returns>regresa un dataresponse con el resultado de la operación </returns>
        delegate DataResponse RequestWebApiDelDelegate(TransactionalContext tx, Int64 idRequest);

        /// <summary>
        /// Operación de eliminado de un registro de RequestWebApi
        /// </summary>
        /// <param name="tx">conexión de base de datos</param>
        /// <param name="idRequest">Llave primeria del registro de la llamada a la web api de trálix</param>
        /// <returns>regresa un dataresponse con el resultado de la operación </returns>
        public static DataResponse RequestWebApiDel(TransactionalContext tx, Int64 idRequest)
        {
            return WorkStore.RequestWebApiDelete(tx, idRequest);
        }

        /// <summary>
        /// Operación principal para el eliminado de un Código de RequestWebApi
        /// </summary>
        /// <param name="idRequest">Llave primeria del registro de la llamada a la web api de trálix</param>
        /// <returns>regresa un dataresponse con el resultado de la operación </returns>
        public DataResponse RequestWebApiDel(Int64 idRequest)
        {
            return Processor.TransactionalRootObject_QueryOperation(
                new RequestWebApiDelDelegate(RequestWebApiDel), idRequest) as DataResponse;
        }

        /// <summary>
        /// Delegado para agregar un elemento de RequestWebApi
        /// </summary>
        /// <param name="tx">conexión de base de datos</param>
        /// <param name="oRequestWebApi">Objeto de Tipo RequestWebApi</param>
        /// <returns>regresa un dataresponse con el resultado de la operación </returns>
        delegate DataResponse RequestWebApiAddUpdateDelegate(TransactionalContext tx, RequestWebApi oRequestWebApi);

        /// <summary>
        /// Operacion para agregar un elemento de RequestWebApi
        /// </summary>
        /// <param name="tx">conexión de base de datos</param>
        /// <param name="oRequestWebApi">Objeto de Tipo RequestWebApi</param>
        /// <returns>regresa un dataresponse con el resultado de la operación </returns>
        public static DataResponse RequestWebApiAddUpdate(TransactionalContext tx, RequestWebApi oRequestWebApi)
        {
            return WorkStore.RequestWebApiAddUpdate(tx, oRequestWebApi);
        }

        /// <summary>
        /// Operación principal para agregar un elemento de RequestWebApi
        /// </summary>
        /// <param name="oRequestWebApi">Objeto de Tipo RequestWebApi</param>
        /// <returns>regresa un dataresponse con el resultado de la operación </returns>
        public DataResponse RequestWebApiAddUpdate(RequestWebApi oRequestWebApi)
        {
            return Processor.TransactionalRootObject_QueryOperation(
                new RequestWebApiAddUpdateDelegate(RequestWebApiAddUpdate), oRequestWebApi) as DataResponse;
        }

        /// <summary>
        /// Delegado para obtener un registro de RequestWebApi
        /// </summary>
        /// <param name="tx">conexión de base de datos</param>
        /// <param name="oRequestWebApi">Contenedor de Tipo RequestWebApi para retornar los datos</param>
        /// <param name="idRequest">Llave primeria del registro de la llamada a la web api de trálix</param>
        /// <returns>regresa un dataresponse con el resultado de la operación </returns>
        delegate DataResponse RequestWebApiGetDelegate(TransactionalContext tx, ref RequestWebApi oRequestWebApi, Int64 idRequest);

        public static DataResponse RequestWebApiGet(TransactionalContext tx, ref RequestWebApi oRequestWebApi, Int64 idRequest)
        {
            DataResponse oDataResponse = WorkStore.RequestWebApiGet(tx, oRequestWebApi, idRequest);
            return oDataResponse;
        }

        /// <summary>
        /// Operación principal para obtener un registro de RequestWebApi
        /// </summary>
        /// <param name="oRequestWebApi">Contenedor de Tipo RequestWebApi para retornar los datos</param>
        /// <param name="idRequest">Llave primeria del registro de la llamada a la web api de trálix</param>
        /// <returns>regresa un dataresponse con el resultado de la operación </returns>
        public DataResponse RequestWebApiGet(ref RequestWebApi oRequestWebApi, Int64 idRequest)
        {
            return Processor.TransactionalRootObject_QueryOperation(
                new RequestWebApiGetDelegate(RequestWebApiGet), oRequestWebApi, idRequest) as DataResponse;
        }

        delegate DataResponse RequestWebApiGetByTicketDelegate(TransactionalContext tx, 
            ref RequestWebApiList oRequestWebApiList, string idTicket);

        public static DataResponse RequestWebApiGetByTicket(TransactionalContext tx, 
            ref RequestWebApiList oRequestWebApiList, string idTicket)
        {
            DataResponse oDataResponse = WorkStore.RequestWebApiGet(tx, oRequestWebApiList, 0, 
                idTicket, 0, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, 2);
            return oDataResponse;
        }

        public DataResponse RequestWebApiGetByTicket(ref RequestWebApiList oRequestWebApiList, string idTicket)
        {
            return Processor.TransactionalRootObject_QueryOperation(
                new RequestWebApiGetByTicketDelegate(RequestWebApiGetByTicket),
                oRequestWebApiList, idTicket) as DataResponse;
        }
    }
}