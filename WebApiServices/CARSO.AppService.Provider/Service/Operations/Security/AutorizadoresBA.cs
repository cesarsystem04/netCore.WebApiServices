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
        delegate DataResponse GetAutorizadoresBADelegate(TransactionalContext tx, string Alias, string codDepto, string codAplicacion, string dsExtraVuelo, ref AutorizadoresBAList oAutorizadoresBAListResponse);
        public static DataResponse GetAutorizadoresBA(TransactionalContext tx, string Alias, string codDepto, string codAplicacion, string dsExtraVuelo, ref AutorizadoresBAList oAutorizadoresBAListResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetAutorizadoresBA(tx,  Alias, codDepto, codAplicacion, dsExtraVuelo, oAutorizadoresBAListResponse);
            return oDataResponse;
        }
        public DataResponse GetAutorizadoresBA(string Alias, string codDepto, string codAplicacion, string dsExtraVuelo, ref AutorizadoresBAList oAutorizadoresBAListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetAutorizadoresBADelegate(GetAutorizadoresBA), Alias, codDepto, codAplicacion, dsExtraVuelo, oAutorizadoresBAListResponse) as DataResponse;
        }

    }
}
