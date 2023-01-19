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
        delegate DataResponse AddParametroDelegate(TransactionalContext tx, Parametro oParametro);
        public static DataResponse AddParametro(TransactionalContext tx, Parametro oParametro)
        {
            DataResponse oDataResponse = WorkStore.addParametro(tx, oParametro);
            return oDataResponse;
        }
        public DataResponse AddParametro(Parametro oParametro)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddParametroDelegate(AddParametro), oParametro) as DataResponse;
        }

        delegate DataResponse GetParametroByKeyDelegate(TransactionalContext tx, ref Parametro oParametro, int idParametro);
        public static DataResponse GetParametroByKey(TransactionalContext tx, ref Parametro oParametro, int idParametro)
        {
            DataResponse oDataResponse = WorkStore.GetParametroByKey(tx, oParametro, idParametro);
            return oDataResponse;
        }
        public DataResponse GetParametroByKey(int idParametro, ref Parametro oParametro)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetParametroByKeyDelegate(GetParametroByKey), oParametro, idParametro) as DataResponse;
        }

        delegate DataResponse GetParametroByTicketDelegate(TransactionalContext tx, ref ParametroList oParametroList, string idTicket);
        public static DataResponse GetParametroByTicket(TransactionalContext tx, ref ParametroList oParametroList, string idTicket)
        {
            DataResponse oDataResponse = WorkStore.GetParametroByTicket(tx, oParametroList, idTicket);
            return oDataResponse;
        }
        public DataResponse GetParametroByTicket(ref ParametroList oParametroList, string idTicket)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetParametroByTicketDelegate(GetParametroByTicket), oParametroList, idTicket) as DataResponse;
        }
    
    }
}
