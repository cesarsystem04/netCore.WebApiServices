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
        delegate DataResponse AddAplicacionDelegate(TransactionalContext tx, Aplicacion oAplicacion);
        public static DataResponse AddAplicacion(TransactionalContext tx, Aplicacion oAplicacion)
        {
            DataResponse oDataResponse = KernelStore.AddAplicacion(tx, oAplicacion);
            return oDataResponse;
        }
        public DataResponse AddAplicacion(Aplicacion oAplicacion)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddAplicacionDelegate(AddAplicacion), oAplicacion) as DataResponse;
        }

        delegate DataResponse GetAplicacionByKeyDelegate(TransactionalContext tx, ref Aplicacion oAplicacionResponse, string codAplicacion);
        public static DataResponse GetAplicacionByKey(TransactionalContext tx, ref Aplicacion oAplicacionResponse, string codAplicacion)
        {
            DataResponse oDataResponse = KernelStore.GetAplicacionByKey(tx, oAplicacionResponse, codAplicacion);
            return oDataResponse;
        }
        public DataResponse GetAplicacionByKey(ref Aplicacion oAplicacionResponse, string codAplicacion)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetAplicacionByKeyDelegate(GetAplicacionByKey), oAplicacionResponse, codAplicacion) as DataResponse;
        }

    }


}
