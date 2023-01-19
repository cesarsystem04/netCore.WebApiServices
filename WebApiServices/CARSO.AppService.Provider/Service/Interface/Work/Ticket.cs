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
        DataResponse AddTicket(Ticket oTicket, ParametroList oParametroList);
        [OperationContract]
        DataResponse GetTicketByKey(string idTicket, ref Ticket oTicket);

        [OperationContract]
        DataResponse GetTicketByFind(ref TicketList oTicketList, string idTicket, int idCodigoEstatus, int idRegistro, int idCodigoTipoProcesoMasivo, string FeInicio, string FeFin, string CreadoPor);

    }
}
