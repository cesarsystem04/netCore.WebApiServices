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
        delegate DataResponse AddCultureCodeDelegate(TransactionalContext tx, CultureCode oCultureCode);
        public static DataResponse AddCultureCode(TransactionalContext tx, CultureCode oCultureCode)
        {
            DataResponse oDataResponse = KernelStore.AddCultureCode(tx, oCultureCode);
            return oDataResponse;
        }
        public DataResponse AddCultureCode(CultureCode oCultureCode)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddCultureCodeDelegate(AddCultureCode), oCultureCode) as DataResponse;
        }

        delegate DataResponse GetCultureCodeByKeyDelegate(TransactionalContext tx, ref CultureCode oCultureCodeResponse, string nbLanguageCulture);
        public static DataResponse GetCultureCodeByKey(TransactionalContext tx, ref CultureCode oCultureCodeResponse, string nbLanguageCulture)
        {
            DataResponse oDataResponse = KernelStore.GetCultureCodeByKey(tx, oCultureCodeResponse, nbLanguageCulture);
            return oDataResponse;
        }
        public DataResponse GetCultureCodeByKey(ref CultureCode oCultureCodeResponse, string nbLanguageCulture)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetCultureCodeByKeyDelegate(GetCultureCodeByKey), oCultureCodeResponse, nbLanguageCulture) as DataResponse;
        }

        delegate DataResponse GetCultureCodeByCriterioDelegate(TransactionalContext tx, ref CultureCodeList oCultureCodeListResponse, string nbLanguageCulture = "", string dsDisplayName = "", string codCulture = "", string valISO639x = "", int esActivo = 2);
        public static DataResponse GetCultureCodeByCriterio(TransactionalContext tx, ref CultureCodeList oCultureCodeListResponse, string nbLanguageCulture = "", string dsDisplayName = "", string codCulture = "", string valISO639x = "", int esActivo = 2)
        {
            DataResponse oDataResponse = KernelStore.GetCultureCodeByCriterio(tx, oCultureCodeListResponse, nbLanguageCulture, dsDisplayName, codCulture, valISO639x, esActivo);
            return oDataResponse;
        }
        public DataResponse GetCultureCodeByCriterio(ref CultureCodeList oCultureCodeListResponse, string nbLanguageCulture = "", string dsDisplayName = "", string codCulture = "", string valISO639x = "", int esActivo = 2)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetCultureCodeByCriterioDelegate(GetCultureCodeByCriterio), oCultureCodeListResponse, nbLanguageCulture, dsDisplayName, codCulture, valISO639x, esActivo) as DataResponse;
        }

    }
}
