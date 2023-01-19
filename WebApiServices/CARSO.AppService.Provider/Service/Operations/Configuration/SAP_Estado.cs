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
  
        delegate DataResponse GetEstadoAllDelegate(TransactionalContext tx, ref EstadoList oEstadoListResponse);
        public static DataResponse GetEstadoAll(TransactionalContext tx, ref EstadoList oEstadoListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetEstadoAll(tx, oEstadoListResponse);
            return oDataResponse;
        }
        public DataResponse GetEstadoAll( ref EstadoList oEstadoListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEstadoAllDelegate(GetEstadoAll), dsConexion,   oEstadoListResponse) as DataResponse;
        }


        delegate DataResponse GetEstadoByEstadoDelegate(TransactionalContext tx, string codEstado, ref EstadoList oEstadoListResponse);
        public static DataResponse GetEstadoByEstado(TransactionalContext tx, string codEstado, ref EstadoList oEstadoListResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetEstadoByEstado(tx, codEstado, oEstadoListResponse);
            return oDataResponse;
        }
        public DataResponse GetEstadoByEstado(string codEstado, ref EstadoList oEstadoListResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEstadoByEstadoDelegate(GetEstadoByEstado), dsConexion, codEstado, oEstadoListResponse) as DataResponse;
        }


        delegate DataResponse GetEstadoByKeyDelegate(TransactionalContext tx, string codEstado, string codMunicipio, ref Estado oEstadoResponse);
        public static DataResponse GetEstadoByKey(TransactionalContext tx, string codEstado, string codMunicipio, ref Estado oEstadoResponse)
        {
            DataResponse oDataResponse = ConfigurationStore.GetEstadoByKey(tx, codEstado, codMunicipio, oEstadoResponse);
            return oDataResponse;
        }
        public DataResponse GetEstadoByKey(string codEstado, string codMunicipio, ref Estado oEstadoResponse)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(new GetEstadoByKeyDelegate(GetEstadoByKey), dsConexion, codEstado, codMunicipio, oEstadoResponse) as DataResponse;
        }


       

    }
}
