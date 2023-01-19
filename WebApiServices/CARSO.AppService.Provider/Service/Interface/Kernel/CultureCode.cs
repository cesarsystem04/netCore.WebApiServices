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
        DataResponse AddCultureCode(CultureCode oCultureCode);
        [OperationContract()]
        DataResponse GetCultureCodeByKey(ref CultureCode oCultureCodeResponse, string nbLanguageCulture);
        [OperationContract()]
        DataResponse GetCultureCodeByCriterio(ref CultureCodeList oCultureCodeListResponse, string nbLanguageCulture = "", string dsDisplayName = "", string codCulture = "", string valISO639x = "", int esActivo = 2);

    }
}
