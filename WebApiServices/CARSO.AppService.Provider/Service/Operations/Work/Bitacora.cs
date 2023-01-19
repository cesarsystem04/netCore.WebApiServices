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
        delegate DataResponse AddBitacoraDelegate(TransactionalContext tx, Bitacora oBitacora);
        public static DataResponse AddBitacora(TransactionalContext tx, Bitacora oBitacora)
        {
            return WorkStore.addBitacora(tx, oBitacora) as DataResponse;

        }
        public DataResponse AddBitacora(Bitacora oBitacora)
        {
            DataResponse oDataResponse = Processor.TransactionalRootObject_QueryOperation(new AddBitacoraDelegate(AddBitacora), oBitacora) as DataResponse;
            return oDataResponse;
        }

    }
}
