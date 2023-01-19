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
        delegate DataResponse AddRolXDominioDelegate(TransactionalContext tx, RolXDominio oRolXDominio);
        public static DataResponse AddRolXDominio(TransactionalContext tx, RolXDominio oRolXDominio)
        {
            DataResponse oDataResponse = SecurityStore.AddRolXDominio(tx, oRolXDominio);
            return oDataResponse;
        }
        public DataResponse AddRolXDominio(RolXDominio oRolXDominio)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddRolXDominioDelegate(AddRolXDominio), oRolXDominio) as DataResponse;
        }

        delegate DataResponse GetRolXDominioByKeyDelegate(TransactionalContext tx, int codRol, string cvDominio, ref RolXDominio oRolXDominioResponse);
        public static DataResponse GetRolXDominioByKey(TransactionalContext tx, int codRol, string cvDominio, ref RolXDominio oRolXDominioResponse)
        {
            DataResponse oDataResponse = SecurityStore.GetRolXDominioByKey(tx, codRol, cvDominio, oRolXDominioResponse);
            return oDataResponse;
        }
        public DataResponse GetRolXDominioByKey(int codRol, string cvDominio, ref RolXDominio oRolXDominioResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetRolXDominioByKeyDelegate(GetRolXDominioByKey), codRol, cvDominio, oRolXDominioResponse) as DataResponse;
        }

    }
}