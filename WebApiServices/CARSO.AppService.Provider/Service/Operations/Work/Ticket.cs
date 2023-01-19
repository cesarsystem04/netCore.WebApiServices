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
        delegate DataResponse AddTicketDelegate(TransactionalContext tx, Ticket oTicket);
        public static DataResponse AddTicket(TransactionalContext tx, Ticket oTicket)
        {
            return WorkStore.addTicket(tx, oTicket) as DataResponse;

        }
        public DataResponse AddTicket(Ticket oTicket, ParametroList oParametroList)
        {
            DataResponse oDataResponse = Processor.TransactionalRootObject_QueryOperation(new AddTicketDelegate(AddTicket), oTicket) as DataResponse;
            foreach (Parametro oParametro in oParametroList.lstParametro)
            {
                oParametro.IdTicket = oDataResponse.idRegistro;
                DataResponse oDataParametroResponse = new DataResponse();
                oDataParametroResponse = AddParametro(oParametro);

            }
            return oDataResponse;

        }

        delegate DataResponse GetTicketByKeyDelegate(TransactionalContext tx, ref Ticket oTicket, string idTicket);
        public static DataResponse GetTicketByKey(TransactionalContext tx, ref Ticket oTicket, string idTicket)
        {
            DataResponse oDataResponse = WorkStore.GetTicketByKey(tx, oTicket, idTicket);
            return oDataResponse;
        }
        public DataResponse GetTicketByKey(string idTicket, ref Ticket oTicket)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetTicketByKeyDelegate(GetTicketByKey), oTicket, idTicket) as DataResponse;
        }



        delegate DataResponse GetTicketByFindDelegate(TransactionalContext tx, ref TicketList oTicketList, string idTicket, int idCodigoEstatus, int idRegistro, int idCodigoTipoProcesoMasivo, string FeInicio, string FeFin, string CreadoPor);
        public static DataResponse GetTicketByFind(TransactionalContext tx, ref TicketList oTicketList, string idTicket, int idCodigoEstatus, int idRegistro, int idCodigoTipoProcesoMasivo, string FeInicio, string FeFin, string CreadoPor)
        {
            DataResponse oDataResponse = WorkStore.GetTicketByFind(tx, oTicketList, idTicket, idCodigoEstatus, idRegistro, idCodigoTipoProcesoMasivo, FeInicio, FeFin, CreadoPor);
            return oDataResponse;
        }
        public  DataResponse GetTicketByFind(ref TicketList oTicketList, string idTicket, int idCodigoEstatus, int idRegistro, int idCodigoTipoProcesoMasivo, string FeInicio, string FeFin, string CreadoPor)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetTicketByFindDelegate(GetTicketByFind), oTicketList, idTicket, idCodigoEstatus, idRegistro, idCodigoTipoProcesoMasivo, FeInicio, FeFin, CreadoPor) as DataResponse;
        }



    }
}
