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
        #region DiaFestivo
        public static DataResponse AddDiaFestivoUpdate(TransactionalContext tx, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Configuration.usp_DiaFestivoAddUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            DiaFestivoSetNullParameters(cmd);
            databag.SetDataTo(cmd.Parameters);
            SqlParameter outMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 1000);
            outMensaje.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outMensaje);
            SqlParameter outError = new SqlParameter("@NumeroError", SqlDbType.Int);
            outError.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outError);
            cmd.ExecuteNonQuery();
            if (int.Parse(outError.Value.ToString()) != 0)
            {
                Exception err = new Exception(string.Format("Error ({0}:{1})", outError.Value.ToString(), outMensaje.Value.ToString()));
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("AddDiaFestivoUpdate", err, ConfigurationManager.AppSettings["AppCode"]);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = cmd.Parameters["@return_value"].Value.ToString();
            return oDataResponse;
        }

        private static void DiaFestivoSetNullParameters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@IdDiaFestivo", 0);
            cmd.Parameters.AddWithValue("@nbDiaFestivo", null);
            cmd.Parameters.AddWithValue("@noAnio", 0);
            cmd.Parameters.AddWithValue("@feDiaFestivo", null);
            cmd.Parameters.AddWithValue("@return_value", null);
        }


        public static DataResponse DiaFestivoDeleteByCodigo(TransactionalContext tx, long IdDiaFestivo)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Configuration.usp_DiaFestivoDeleteByCodigo";
            cmd.Parameters.AddWithValue("@IdDiaFestivo", IdDiaFestivo);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter outMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 1000);
            outMensaje.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outMensaje);
            SqlParameter outError = new SqlParameter("@NumeroError", SqlDbType.Int);
            outError.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outError);
            using (IDataReader reader = cmd.ExecuteReader())
            {
            }

            if (int.Parse(outError.Value.ToString()) != 0)
            {
                Exception err = new Exception(string.Format("Error ({0}:{1})", outError.Value.ToString(), outMensaje.Value.ToString()));
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("DiaFestivoDeleteByCodigo", err, ConfigurationManager.AppSettings["AppCode"]);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetDiaFestivoAll(TransactionalContext tx, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Configuration.usp_DiaFestivoGetAll";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter outMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 1000);
            outMensaje.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outMensaje);
            SqlParameter outError = new SqlParameter("@NumeroError", SqlDbType.Int);
            outError.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outError);
            using (IDataReader reader = cmd.ExecuteReader())
            { databag.LoadDataFrom(reader); }
            if (int.Parse(outError.Value.ToString()) != 0)
            {
                Exception err = new Exception(string.Format("Error ({0}:{1})", outError.Value.ToString(), outMensaje.Value.ToString()));
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetDiaFestivoAll", err, ConfigurationManager.AppSettings["AppCode"]);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetDiaFestivoByCriterio(TransactionalContext tx, string nbDiaFestivo, int noAnio, string feInicio, string feFin, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Configuration.usp_DiaFestivoGetByCriterio";
            cmd.Parameters.AddWithValue("@nbDiaFestivo", nbDiaFestivo);
            cmd.Parameters.AddWithValue("@noAnio", noAnio);
            cmd.Parameters.AddWithValue("@feInicio", feInicio);
            cmd.Parameters.AddWithValue("@feFin", feFin);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter outMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 1000);
            outMensaje.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outMensaje);
            SqlParameter outError = new SqlParameter("@NumeroError", SqlDbType.Int);
            outError.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outError);
            using (IDataReader reader = cmd.ExecuteReader())
            { databag.LoadDataFrom(reader); }
            if (int.Parse(outError.Value.ToString()) != 0)
            {
                Exception err = new Exception(string.Format("Error ({0}:{1})", outError.Value.ToString(), outMensaje.Value.ToString()));
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetDiaFestivoByCriterio", err, ConfigurationManager.AppSettings["AppCode"]);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetDiaFestivoByKey(TransactionalContext tx, long IdDiaFestivo, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Configuration.usp_DiaFestivoGetByKey";
            cmd.Parameters.AddWithValue("@IdDiaFestivo", IdDiaFestivo);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter outMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 1000);
            outMensaje.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outMensaje);
            SqlParameter outError = new SqlParameter("@NumeroError", SqlDbType.Int);
            outError.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outError);
            using (IDataReader reader = cmd.ExecuteReader())
            { databag.LoadDataFrom(reader); }
            if (int.Parse(outError.Value.ToString()) != 0)
            {
                Exception err = new Exception(string.Format("Error ({0}:{1})", outError.Value.ToString(), outMensaje.Value.ToString()));
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetDiaFestivoByKey", err, ConfigurationManager.AppSettings["AppCode"]);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }
        #endregion
    }
}