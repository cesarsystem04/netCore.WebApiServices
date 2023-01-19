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
        public static DataResponse AddPeriodoTransaccional(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Configuration.usp_PeriodoTransaccionalAddUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            PeriodoTransaccionalSetNullParemeters(cmd);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("AddPeriodoTransaccional", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = cmd.Parameters["@return_value"].Value.ToString();

            return oDataResponse;
        }

        private static void PeriodoTransaccionalSetNullParemeters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@idPeriodo", 0);
            cmd.Parameters.AddWithValue("@codAplicacion", null);
            cmd.Parameters.AddWithValue("@esPorFrecuencia", 0);
            cmd.Parameters.AddWithValue("@esPorPeriodo", 0);
            cmd.Parameters.AddWithValue("@esPorDiaSemana", 0);
            cmd.Parameters.AddWithValue("@esLunes", 0);
            cmd.Parameters.AddWithValue("@esMartes", 0);
            cmd.Parameters.AddWithValue("@esMiercoles", 0);
            cmd.Parameters.AddWithValue("@esJueves", 0);
            cmd.Parameters.AddWithValue("@esViernes", 0);
            cmd.Parameters.AddWithValue("@esSabado", 0);
            cmd.Parameters.AddWithValue("@esDomingo", 0);
            cmd.Parameters.AddWithValue("@noTransacciones", null);
            cmd.Parameters.AddWithValue("@hrInicio", null);
            cmd.Parameters.AddWithValue("@hrFin", null);
            cmd.Parameters.AddWithValue("@noOcurrencia", null);
            cmd.Parameters.AddWithValue("@idCodigoTipoOcurrencia", null);
            cmd.Parameters.AddWithValue("@noPrioridad", null);
            cmd.Parameters.AddWithValue("@esActivo", 1);
            cmd.Parameters.AddWithValue("@feCreacion", null);
            cmd.Parameters.AddWithValue("@idCodigoFrecuencia", null);
            cmd.Parameters.AddWithValue("@feInicioPeriodo", null);
            cmd.Parameters.AddWithValue("@feFinPeriodo", null);
            cmd.Parameters.AddWithValue("@CreadoPor", null);
            cmd.Parameters.AddWithValue("@return_value", null);
        }

        public static DataResponse GetPeriodoTransaccionalAll(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string codAplicacion, EstatusActivo Estatus, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Configuration.usp_PeriodoTransaccionalGetAll";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);
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

        public static DataResponse GetPeriodoTransaccional(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, Int32 idPeriodo, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Configuration.usp_PeriodoTransaccionalGetByKey";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idPeriodo", idPeriodo);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetPeriodoTransaccional", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetPeriodoTransaccionalByNoMax(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Configuration.usp_PeriodosTransaccionalesByNoPrioridadMax";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter outMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 1000);
            outMensaje.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outMensaje);
            SqlParameter outError = new SqlParameter("@NumeroError", SqlDbType.Int);
            outError.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outError);
            int _noMax = int.Parse(cmd.ExecuteScalar().ToString());
            if (int.Parse(outError.Value.ToString()) != 0)
            {
                Exception err = new Exception(string.Format("Error ({0}:{1})", outError.Value.ToString(), outMensaje.Value.ToString()));
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("AddPeriodoTransaccional", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = _noMax.ToString();

            return oDataResponse;
        }

    }
}
