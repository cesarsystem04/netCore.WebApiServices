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
        public DataResponse AddTicket(Ticket oTicket, ParametroList oParametroList)
        {
            return Channel.AddTicket(oTicket, oParametroList);
        }

        public DataResponse GetTicketByKey(string idTicket, ref Ticket oTicket)
        {
            return Channel.GetTicketByKey(idTicket, ref oTicket);
        }


        public DataResponse GetTicketByFind(ref TicketList oTicketList, string idTicket, int idCodigoEstatus, int idRegistro, int idCodigoTipoProcesoMasivo, string FeInicio, string FeFin, string CreadoPor)
        {
            return Channel.GetTicketByFind(ref oTicketList, idTicket, idCodigoEstatus,  idRegistro,  idCodigoTipoProcesoMasivo, FeInicio, FeFin, CreadoPor);
        }

    }
}
