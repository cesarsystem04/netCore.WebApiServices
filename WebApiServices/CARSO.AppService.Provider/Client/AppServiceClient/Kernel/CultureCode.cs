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
        public DataResponse AddCultureCode(CultureCode oCultureCode)
        {
            return Channel.AddCultureCode(oCultureCode);
        }

        public DataResponse GetCultureCodeByKey(ref CultureCode oCultureCodeResponse, string nbLanguageCulture)
        {
            return Channel.GetCultureCodeByKey(ref oCultureCodeResponse, nbLanguageCulture);
        }

        public DataResponse GetCultureCodeByCriterio(ref CultureCodeList oCultureCodeListResponse, string nbLanguageCulture = "", string dsDisplayName = "", string codCulture = "", string valISO639x = "", int esActivo = 2)
        {
            return Channel.GetCultureCodeByCriterio(ref oCultureCodeListResponse, nbLanguageCulture, dsDisplayName, codCulture, valISO639x, esActivo);
        }

    }
}
