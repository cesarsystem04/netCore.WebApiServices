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
        delegate DataResponse AddAlcanceOrganizacionalDelegate(TransactionalContext tx, AlcanceOrganizacional oAlcanceOrganizacional, string codAplicacion);
        public static DataResponse AddAlcanceOrganizacional(TransactionalContext tx, AlcanceOrganizacional oAlcanceOrganizacional, string codAplicacion)
        {
            DataResponse oDataResponse = SecurityStore.AddAlcanceOrganizacional(tx, oAlcanceOrganizacional, codAplicacion);
            return oDataResponse;
        }
        public DataResponse AddAlcanceOrganizacional(AlcanceOrganizacional oAlcanceOrganizacional, string codAplicacion)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddAlcanceOrganizacionalDelegate(AddAlcanceOrganizacional), oAlcanceOrganizacional, codAplicacion) as DataResponse;
        }

        delegate DataResponse GetAlcanceOrganizacionalDelegate(TransactionalContext tx, int codAlcanceOrg, string codAplicacion, ref AlcanceOrganizacional oAlcanceOrganizacional);
        public static DataResponse GetAlcanceOrganizacional(TransactionalContext tx, int codAlcanceOrg, string codAplicacion, ref AlcanceOrganizacional oAlcanceOrganizacional)
        {
            DataResponse oDataResponse = SecurityStore.GetAlcanceOrganizacional(tx, codAlcanceOrg, codAplicacion, oAlcanceOrganizacional);
            return oDataResponse;
        }
        public DataResponse GetAlcanceOrganizacional(int codAlcanceOrg, string codAplicacion, ref AlcanceOrganizacional oAlcanceOrganizacional)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetAlcanceOrganizacionalDelegate(GetAlcanceOrganizacional), codAlcanceOrg, codAplicacion, oAlcanceOrganizacional) as DataResponse;
        }

        delegate DataResponse GetAlcanceOrganizacionalByNbAliasDelegate(TransactionalContext tx, string nbAlias, string codAplicacion, ref AlcanceOrganizacionalList oAlcanceOrganizacionalList);
        public static DataResponse GetAlcanceOrganizacionalByNbAlias(TransactionalContext tx, string nbAlias, string codAplicacion, ref AlcanceOrganizacionalList oAlcanceOrganizacionalList)
        {
            DataResponse oDataResponse = SecurityStore.GetAlcanceOrganizacionalByNbAlias(tx, nbAlias, codAplicacion, oAlcanceOrganizacionalList);
            return oDataResponse;
        }
        public DataResponse GetAlcanceOrganizacionalByNbAlias(string nbAlias, string codAplicacion, ref AlcanceOrganizacionalList oAlcanceOrganizacionalList)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetAlcanceOrganizacionalByNbAliasDelegate(GetAlcanceOrganizacionalByNbAlias), nbAlias, codAplicacion, oAlcanceOrganizacionalList) as DataResponse;
        }

        delegate DataResponse GetAlcanceOrganizacionalByNbAliasAndTipoParametroDelegate(TransactionalContext tx, string nbAlias, int idCodigoTipoParametro, string codAplicacion, ref AlcanceOrganizacionalList oAlcanceOrganizacionalList);
        public static DataResponse GetAlcanceOrganizacionalByNbAliasAndTipoParametro(TransactionalContext tx, string nbAlias, int idCodigoTipoParametro, string codAplicacion, ref AlcanceOrganizacionalList oAlcanceOrganizacionalList)
        {
            DataResponse oDataResponse = SecurityStore.GetAlcanceOrganizacionalByNbAliasAndTipoParametro(tx, nbAlias, idCodigoTipoParametro, codAplicacion, oAlcanceOrganizacionalList);
            return oDataResponse;
        }
        public DataResponse GetAlcanceOrganizacionalByNbAliasAndTipoParametro(string nbAlias, int idCodigoTipoParametro, string codAplicacion, ref AlcanceOrganizacionalList oAlcanceOrganizacionalList)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetAlcanceOrganizacionalByNbAliasAndTipoParametroDelegate(GetAlcanceOrganizacionalByNbAliasAndTipoParametro), nbAlias, idCodigoTipoParametro, codAplicacion, oAlcanceOrganizacionalList) as DataResponse;
        }

        delegate DataResponse DelAlcanceOrganizacionalDelegate(TransactionalContext tx, int codAlcanceOrg, string codAplicacion);
        public static DataResponse DelAlcanceOrganizacional(TransactionalContext tx, int codAlcanceOrg, string codAplicacion)
        {
            DataResponse oDataResponse = SecurityStore.DelAlcanceOrganizacional(tx, codAlcanceOrg, codAplicacion);
            return oDataResponse;
        }
        public DataResponse DelAlcanceOrganizacional(int codAlcanceOrg, string codAplicacion)
        {
            return Processor.TransactionalRootObject_QueryOperation(new DelAlcanceOrganizacionalDelegate(DelAlcanceOrganizacional), codAlcanceOrg, codAplicacion) as DataResponse;
        }

        delegate DataResponse DelAlcanceOrganizacionalByAliasDelegate(TransactionalContext tx, string nbAlias, string codAplicacion);
        public static DataResponse DelAlcanceOrganizacionalByAlias(TransactionalContext tx, string nbAlias, string codAplicacion)
        {
            DataResponse oDataResponse = SecurityStore.DelAlcanceOrganizacionalByAlias(tx, nbAlias, codAplicacion);
            return oDataResponse;
        }
        public DataResponse DelAlcanceOrganizacionalByAlias(string nbAlias, string codAplicacion)
        {
            return Processor.TransactionalRootObject_QueryOperation(new DelAlcanceOrganizacionalByAliasDelegate(DelAlcanceOrganizacionalByAlias), nbAlias, codAplicacion) as DataResponse;
        }
    }
}
