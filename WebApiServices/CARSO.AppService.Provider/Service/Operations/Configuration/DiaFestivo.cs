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
using CARSO.AppServiceDB.ServiceDataContainers;

namespace CARSO.AppService.Provider.Service
{
    public partial class AppService : IAppService
    {
        #region DiaFestivo
        delegate DataResponse AddDiaFestivoUpdateDelegate(TransactionalContext tx, DiaFestivo oDiaFestivo);
        public static DataResponse AddDiaFestivoUpdate(TransactionalContext tx, DiaFestivo oDiaFestivo)
        {
            DataResponse oDataResponse = ConfigurationStore.AddDiaFestivoUpdate(tx, oDiaFestivo);
            return oDataResponse;
        }
        public DataResponse AddDiaFestivoUpdate(DiaFestivo oDiaFestivo)
        {
            return Processor.TransactionalRootObject_QueryOperation(new AddDiaFestivoUpdateDelegate(AddDiaFestivoUpdate), oDiaFestivo) as DataResponse;
        }

        delegate DataResponse DiaFestivoDeleteByCodigoDelegate(TransactionalContext tx, long IdDiaFestivo);
        public static DataResponse DiaFestivoDeleteByCodigo(TransactionalContext tx, long IdDiaFestivo)
        {
            DataResponse oDataResponse = ConfigurationStore.DiaFestivoDeleteByCodigo(tx, IdDiaFestivo);
            return oDataResponse;
        }
        public DataResponse DiaFestivoDeleteByCodigo(long IdDiaFestivo)
        {
            return Processor.TransactionalRootObject_QueryOperation(new DiaFestivoDeleteByCodigoDelegate(DiaFestivoDeleteByCodigo), IdDiaFestivo) as DataResponse;
        }

        delegate DataResponse GetDiaFestivoAllDelegate(TransactionalContext tx, ref DiaFestivoList oDiaFestivoListResponse);
        public static DataResponse GetDiaFestivoAll(TransactionalContext tx, ref DiaFestivoList oDiaFestivoListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetDiaFestivoAll(tx, oDiaFestivoListResponse);
            return oDataResponse;
        }
        public DataResponse GetDiaFestivoAll(ref DiaFestivoList oDiaFestivoListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetDiaFestivoAllDelegate(GetDiaFestivoAll), oDiaFestivoListResponse) as DataResponse;
        }

        delegate DataResponse GetDiaFestivoByCriterioDelegate(TransactionalContext tx, string nbDiaFestivo, int noAnio, string feInicio, string feFin, ref DiaFestivoList oDiaFestivoListResponse);
        public static DataResponse GetDiaFestivoByCriterio(TransactionalContext tx, string nbDiaFestivo, int noAnio, string feInicio, string feFin, ref DiaFestivoList oDiaFestivoListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetDiaFestivoByCriterio(tx, nbDiaFestivo, noAnio, feInicio, feFin, oDiaFestivoListResponse);
            return oDataResponse;
        }
        public DataResponse GetDiaFestivoByCriterio(string nbDiaFestivo, int noAnio, string feInicio, string feFin, ref DiaFestivoList oDiaFestivoListResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetDiaFestivoByCriterioDelegate(GetDiaFestivoByCriterio), nbDiaFestivo, noAnio, feInicio, feFin, oDiaFestivoListResponse) as DataResponse;
        }

        delegate DataResponse GetDiaFestivoByKeyDelegate(TransactionalContext tx, long IdDiaFestivo, ref DiaFestivo oDiaFestivoResponse);
        public static DataResponse GetDiaFestivoByKey(TransactionalContext tx, long IdDiaFestivo, ref DiaFestivo oDiaFestivoResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetDiaFestivoByKey(tx, IdDiaFestivo, oDiaFestivoResponse);
            return oDataResponse;
        }
        public DataResponse GetDiaFestivoByKey(long IdDiaFestivo, ref DiaFestivo oDiaFestivoResponse)
        {
            return Processor.TransactionalRootObject_QueryOperation(new GetDiaFestivoByKeyDelegate(GetDiaFestivoByKey), IdDiaFestivo, oDiaFestivoResponse) as DataResponse;
        }
        #endregion
    }
}
