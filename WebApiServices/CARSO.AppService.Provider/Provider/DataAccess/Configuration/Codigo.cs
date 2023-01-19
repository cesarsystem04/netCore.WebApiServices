using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Configuration;
using System.Threading.Tasks;
using CARSO.LogLibrary.ServiceDataAccess;

namespace CARSO.AppService.ServiceDataAccess
{
    public partial class ConfigurationStore
    {

        public static DataResponse GetCodigoByCatalogo(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, Int32 noCatalogo, EstatusActivo Estatus, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Configuration.usp_CodigoGetByCatalogo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@noCatalogo", noCatalogo);
            cmd.Parameters.AddWithValue("@dsExtra", null);
            cmd.Parameters.AddWithValue("@rfExterna", null);
            if (Estatus == EstatusActivo.Activos)
                cmd.Parameters.AddWithValue("@esActivo", 1);
            else if (Estatus == EstatusActivo.Inactivos)
                cmd.Parameters.AddWithValue("@esActivo", 0);
            else
                cmd.Parameters.AddWithValue("@esActivo", null);

            SqlParameter outMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 1000);
            outMensaje.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outMensaje);
            SqlParameter outError = new SqlParameter("@NumeroError", SqlDbType.Int);
            outError.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outError);
            using (IDataReader reader = cmd.ExecuteReader())
            {
                databag.LoadDataFrom(reader);
            }

            if (int.Parse(outError.Value.ToString()) != 0)
            {
                Exception err = new Exception(string.Format("Error ({0}:{1})", outError.Value.ToString(), outMensaje.Value.ToString()));
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetCodigoByCatalogo", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetCodigoByKey(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, Int32 idCodigo, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Configuration.usp_CodigoGetByKey";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCodigo", idCodigo);
            SqlParameter outMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 1000);
            outMensaje.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outMensaje);
            SqlParameter outError = new SqlParameter("@NumeroError", SqlDbType.Int);
            outError.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outError);
            using (IDataReader reader = cmd.ExecuteReader())
            {
                databag.LoadDataFrom(reader);
            }

            if (int.Parse(outError.Value.ToString()) != 0)
            {
                Exception err = new Exception(string.Format("Error ({0}:{1})", outError.Value.ToString(), outMensaje.Value.ToString()));
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetCodigoByKey", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetCodigoByCatalogoAndDsExtra(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, Int32 noCatalogo, string dsExtra, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Configuration.usp_CodigoGetByCatalogo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@noCatalogo", noCatalogo);
            cmd.Parameters.AddWithValue("@dsExtra", dsExtra);
            cmd.Parameters.AddWithValue("@esActivo", null);
            cmd.Parameters.AddWithValue("@rfExterna", null);
            SqlParameter outMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 1000);
            outMensaje.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outMensaje);
            SqlParameter outError = new SqlParameter("@NumeroError", SqlDbType.Int);
            outError.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outError);
            using (IDataReader reader = cmd.ExecuteReader())
            {
                databag.LoadDataFrom(reader);
            }

            if (int.Parse(outError.Value.ToString()) != 0)
            {
                Exception err = new Exception(string.Format("Error ({0}:{1})", outError.Value.ToString(), outMensaje.Value.ToString()));
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetCodigoByCatalogoAndDsExtra", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetCodigoByCatalogoAndRfExterna(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, Int32 noCatalogo, string rfExterna, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Configuration.usp_CodigoGetByCatalogo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@noCatalogo", noCatalogo);
            cmd.Parameters.AddWithValue("@rfExterna", rfExterna);
            cmd.Parameters.AddWithValue("@esActivo", null);
            cmd.Parameters.AddWithValue("@dsExtra", null);

            SqlParameter outMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 1000);
            outMensaje.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outMensaje);
            SqlParameter outError = new SqlParameter("@NumeroError", SqlDbType.Int);
            outError.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outError);
            using (IDataReader reader = cmd.ExecuteReader())
            {
                databag.LoadDataFrom(reader);
            }

            if (int.Parse(outError.Value.ToString()) != 0)
            {
                Exception err = new Exception(string.Format("Error ({0}:{1})", outError.Value.ToString(), outMensaje.Value.ToString()));
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetCodigoByCatalogoAndRfExterna", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

    }
}
