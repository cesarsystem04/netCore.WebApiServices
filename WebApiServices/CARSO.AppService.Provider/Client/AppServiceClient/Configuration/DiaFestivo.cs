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
using CARSO.AppServiceDB.ServiceDataContainers;

namespace CARSO.AppService.Provider.Client
{
    public partial class AppServiceClient : ClientBase<IAppService>, IAppService
    {
        #region DiaFestivo
        public DataResponse AddDiaFestivoUpdate(DiaFestivo oDiaFestivo)
        {
            return Channel.AddDiaFestivoUpdate(oDiaFestivo);
        }

        public DataResponse DiaFestivoDeleteByCodigo(long IdDiaFestivo)
        {
            return Channel.DiaFestivoDeleteByCodigo(IdDiaFestivo);
        }

        public DataResponse GetDiaFestivoAll(ref DiaFestivoList oDiaFestivoListResponse)
        {
            return Channel.GetDiaFestivoAll(ref oDiaFestivoListResponse);
        }

        public DataResponse GetDiaFestivoByCriterio(string nbDiaFestivo, int noAnio, string feInicio, string feFin, ref DiaFestivoList oDiaFestivoListResponse)
        {
            return Channel.GetDiaFestivoByCriterio(nbDiaFestivo, noAnio, feInicio, feFin, ref oDiaFestivoListResponse);
        }

        public DataResponse GetDiaFestivoByKey(long IdDiaFestivo, ref DiaFestivo oDiaFestivoResponse)
        {
            return Channel.GetDiaFestivoByKey(IdDiaFestivo, ref oDiaFestivoResponse);
        }
        #endregion
    }
}