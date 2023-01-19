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


        delegate DataResponse GetCentroCostoAllDelegate(TransactionalContext tx, ref CentroCostoList oCentroCostoListResponse);
        public static DataResponse GetCentroCostoAll(TransactionalContext tx, ref CentroCostoList oCentroCostoListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetCentroCostoAll(tx, oCentroCostoListResponse);
            return oDataResponse;
        }
        public DataResponse GetCentroCostoAll( ref CentroCostoList oCentroCostoListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetCentroCostoAllDelegate(GetCentroCostoAll), dsConexion,  oCentroCostoListResponse) as DataResponse;
        }


        delegate DataResponse GetCentroCostoByKeyDelegate(TransactionalContext tx, string codCentroCosto, ref CentroCosto oCentroCostoResponse);
        public static DataResponse GetCentroCostoByKey(TransactionalContext tx, string codCentroCosto, ref CentroCosto oCentroCostoResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetCentroCostoByKey(tx, codCentroCosto, oCentroCostoResponse);
            return oDataResponse;
        }
        public DataResponse GetCentroCostoByKey(string codCentroCosto, ref CentroCosto oCentroCostoResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetCentroCostoByKeyDelegate(GetCentroCostoByKey), dsConexion, codCentroCosto, oCentroCostoResponse) as DataResponse;
        }




        delegate DataResponse GetCentroCostoBySociedadDelegate(TransactionalContext tx, string codSociedad, ref CentroCostoList oCentroCostoResponse);
        public static DataResponse GetCentroCostoBySociedad(TransactionalContext tx, string codSociedad, ref CentroCostoList oCentroCostoResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetCentroCostoBySociedad(tx, codSociedad, oCentroCostoResponse);
            return oDataResponse;
        }
        public DataResponse GetCentroCostoBySociedad(string codSociedad, ref CentroCostoList oCentroCostoResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetCentroCostoBySociedadDelegate(GetCentroCostoBySociedad), dsConexion, codSociedad, oCentroCostoResponse) as DataResponse;
        }


        delegate DataResponse GetCentroCostoBySociedadesDelegate(TransactionalContext tx, string codSociedades, ref CentroCostoList oCentroCostoResponse);
        public static DataResponse GetCentroCostoBySociedades(TransactionalContext tx, string codSociedades, ref CentroCostoList oCentroCostoResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetCentroCostoBySociedades(tx, codSociedades, oCentroCostoResponse);
            return oDataResponse;
        }
        public DataResponse GetCentroCostoBySociedades(string codSociedades, ref CentroCostoList oCentroCostoResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetCentroCostoBySociedadesDelegate(GetCentroCostoBySociedades), dsConexion, codSociedades, oCentroCostoResponse) as DataResponse;
        }




    }
}
