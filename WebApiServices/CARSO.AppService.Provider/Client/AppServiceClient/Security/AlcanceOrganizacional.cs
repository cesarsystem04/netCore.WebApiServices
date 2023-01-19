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
        public DataResponse AddAlcanceOrganizacional(AlcanceOrganizacional oAlcanceOrganizacional, string codAplicacion)
        {
            return Channel.AddAlcanceOrganizacional(oAlcanceOrganizacional, codAplicacion);
        }
        public DataResponse GetAlcanceOrganizacional(int codAlcanceOrg, string codAplicacion, ref AlcanceOrganizacional oAlcanceOrganizacional)
        {
            return Channel.GetAlcanceOrganizacional(codAlcanceOrg, codAplicacion, ref oAlcanceOrganizacional);
        }
        public DataResponse GetAlcanceOrganizacionalByNbAlias(string nbAlias, string codAplicacion, ref AlcanceOrganizacionalList oAlcanceOrganizacionalList)
        {
            return Channel.GetAlcanceOrganizacionalByNbAlias(nbAlias, codAplicacion, ref oAlcanceOrganizacionalList);
        }
        public DataResponse GetAlcanceOrganizacionalByNbAliasAndTipoParametro(string nbAlias, int idCodigoTipoParametro, string codAplicacion, ref AlcanceOrganizacionalList oAlcanceOrganizacionalList)
        {
            return Channel.GetAlcanceOrganizacionalByNbAliasAndTipoParametro(nbAlias, idCodigoTipoParametro, codAplicacion, ref oAlcanceOrganizacionalList);
        }
        public DataResponse DelAlcanceOrganizacional(int codAlcanceOrg, string codAplicacion)
        {
            return Channel.DelAlcanceOrganizacional(codAlcanceOrg, codAplicacion);
        }
        public DataResponse DelAlcanceOrganizacionalByAlias(string nbAlias, string codAplicacion)
        {
            return Channel.DelAlcanceOrganizacionalByAlias(nbAlias, codAplicacion);
        }

    }
}
