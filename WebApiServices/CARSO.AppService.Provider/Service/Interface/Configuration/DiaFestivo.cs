using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Security.Principal;
using System.IO;
using System.Threading.Tasks;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.AppService.ServiceDataContainers;
using CARSO.AppServiceDB.ServiceDataContainers;

namespace CARSO.AppService.Provider.Service
{
    public partial interface IAppService
    {
        #region DiaFestivo
        [OperationContract]
        DataResponse AddDiaFestivoUpdate(DiaFestivo oDiaFestivo);
        [OperationContract]
        DataResponse DiaFestivoDeleteByCodigo(long IdDiaFestivo);
        [OperationContract]
        DataResponse GetDiaFestivoAll(ref DiaFestivoList oDiaFestivoListResponse);
        [OperationContract]
        DataResponse GetDiaFestivoByCriterio(string nbDiaFestivo, int noAnio, string feInicio, string feFin, ref DiaFestivoList oDiaFestivoListResponse);
        [OperationContract]
        DataResponse GetDiaFestivoByKey(long IdDiaFestivo, ref DiaFestivo oDiaFestivoResponse);
        #endregion
    }
}