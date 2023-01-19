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
        DataResponse AddAlcanceOrganizacional(AlcanceOrganizacional oAlcanceOrganizacional, string codAplicacion);
        [OperationContract]
        DataResponse GetAlcanceOrganizacional(int codAlcanceOrg, string codAplicacion, ref AlcanceOrganizacional oAlcanceOrganizacional);
        [OperationContract]
        DataResponse GetAlcanceOrganizacionalByNbAlias(string nbAlias, string codAplicacion, ref AlcanceOrganizacionalList oAlcanceOrganizacionalList);
        [OperationContract]
        DataResponse GetAlcanceOrganizacionalByNbAliasAndTipoParametro(string nbAlias, int idCodigoTipoParametro, string codAplicacion, ref AlcanceOrganizacionalList oAlcanceOrganizacionalList);
        [OperationContract]
        DataResponse DelAlcanceOrganizacional(int codAlcanceOrg, string codAplicacion);
        [OperationContract]
        DataResponse DelAlcanceOrganizacionalByAlias(string nbAlias, string codAplicacion);

    }
}
