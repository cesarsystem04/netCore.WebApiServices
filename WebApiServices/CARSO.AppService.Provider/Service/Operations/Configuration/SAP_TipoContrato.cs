using CARSO.AppService.ServiceDataAccess;
using CARSO.AppService.ServiceDataContainers;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.LogLibrary.ServiceOperations;
using System;
using System.Configuration;

namespace CARSO.AppService.Provider.Service
{
    public partial class AppService : IAppService
    {
        delegate DataResponse GetTipoContratoAllDelegate(TransactionalContext tx, ref TipoContratoList oTipoContratoList);
        public static DataResponse GetTipoContratoAll(TransactionalContext tx, ref TipoContratoList oTipoContratoList)
        {
            DataResponse oDataResponse = ConfigurationStore.GetTipoContratoAll(tx, oTipoContratoList);
            return oDataResponse;
        }
        public DataResponse GetTipoContratoAll(ref TipoContratoList oTipoContratoList)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(
                new GetTipoContratoAllDelegate(GetTipoContratoAll), dsConexion, oTipoContratoList) as DataResponse;
        }

        delegate DataResponse GetTipoContratoByKeyDelegate(TransactionalContext tx, string codTipoContrato, ref TipoContrato oTipoContrato);
        public static DataResponse GetTipoContratoByKey(TransactionalContext tx, string codTipoContrato, ref TipoContrato oTipoContrato)
        {
            DataResponse oDataResponse = ConfigurationStore.GetTipoContratoByKey(tx, codTipoContrato, oTipoContrato);
            return oDataResponse;
        }
        public DataResponse GetTipoContratoByKey(string codTipoContrato, ref TipoContrato oTipoContrato)
        {
            string dsConexion = string.Empty;
            byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["RHSAP"]);
            dsConexion = System.Text.Encoding.Unicode.GetString(bytetemp);
            return Processor.TransactionalRootObject_QueryOperationCustomConection(
                new GetTipoContratoByKeyDelegate(GetTipoContratoByKey), dsConexion, codTipoContrato, oTipoContrato) as DataResponse;
        }
    }
}
