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
    /// <summary>
    /// Acceso a Datos para Objetos de Work
    /// </summary>
	public partial class WorkStore
    {
        /// <summary>
        /// Método para agregar, eliminar o modificar Registro de llamadas y respuestas a la Web API de Trálix
        /// </summary>
        /// <param name="tx">conexión de base de datos</param>
        /// <param name="databag">objeto con las propiedades para actualizar</param>
        /// <param name="Operacion">Tipo de Operación a realizar (A-Alta, B-Baja, C-Cambios)</param>
        /// <param name="XMLCriteriosEliminado">XML de los Parámetros de Eliminación de registros</param>
        /// <returns>regresa un dataresponse con el resultado de la operación </returns>
		public static DataResponse RequestWebApiAddUpdate(TransactionalContext tx, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Work.usp_RequestWebApiAddUpdate";
            cmd.CommandType = CommandType.StoredProcedure;

            RequestWebApiSetNullParameters(cmd);

            databag.SetDataTo(cmd.Parameters);
            SqlParameter outMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 1000);
            outMensaje.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(outMensaje);
            SqlParameter outError = new SqlParameter("@NumeroError", SqlDbType.Int);
            outError.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outError);

            cmd.ExecuteNonQuery();

            if (Convert.ToInt32(outError.Value) != 0)
            {
                Exception err = new Exception(string.Format("Error ({0}:{1})", outError.Value, outMensaje.Value));
                LogLibrary.ServiceOperations.LogOperation.Log("RequestWebApiAddUpdate", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = Convert.ToInt32(outError.Value);
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = cmd.Parameters["@return_value"].Value.ToString();

            return oDataResponse;
        }

        public static DataResponse RequestWebApiDelete(TransactionalContext tx, long idRequest)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Work.usp_RequestWebApiDelete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idRequest", idRequest);

            SqlParameter outMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 1000);
            outMensaje.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outMensaje);

            SqlParameter outError = new SqlParameter("@NumeroError", SqlDbType.Int);
            outError.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outError);

            cmd.ExecuteNonQuery();

            if (Convert.ToInt32(outError.Value) != 0)
            {
                Exception err = new Exception(string.Format("Error ({0}:{1})", outError.Value, outMensaje.Value));
                LogLibrary.ServiceOperations.LogOperation.Log("RequestWebApiDelete", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = Convert.ToInt32(outError.Value);
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = cmd.Parameters["@return_value"].Value.ToString();

            return oDataResponse;
        }

        public static DataResponse RequestWebApiGet(TransactionalContext tx, IDataContainer databag, 
            long idRequest, string idTicket, long idRecibo, string methodAddress, string feRequestIni, 
            string feRequestFin, string feResponseIni, string feResponseFin, byte esExitoso)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Work.usp_RequestWebApiGetByCriterio";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idRequest", idRequest != 0 ? idRequest.ToString() : null);
            cmd.Parameters.AddWithValue("@idTicket", !string.IsNullOrWhiteSpace(idTicket) ? idTicket : null);
            cmd.Parameters.AddWithValue("@idRecibo", idRecibo != 0 ? idRecibo.ToString() : null);
            cmd.Parameters.AddWithValue("@methodAddress", !string.IsNullOrWhiteSpace(methodAddress) ? methodAddress : null);
            cmd.Parameters.AddWithValue("@feRequestIni", !string.IsNullOrWhiteSpace(@feRequestIni) ? @feRequestIni : null);
            cmd.Parameters.AddWithValue("@feRequestFin", !string.IsNullOrWhiteSpace(@feRequestFin) ? @feRequestFin : null);
            cmd.Parameters.AddWithValue("@feResponseIni", !string.IsNullOrWhiteSpace(@feResponseIni) ? @feResponseIni : null);
            cmd.Parameters.AddWithValue("@feResponseFin", !string.IsNullOrWhiteSpace(@feResponseFin) ? @feResponseFin : null);
            cmd.Parameters.AddWithValue("@esExitoso", esExitoso != 0 ? esExitoso.ToString() : null);

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

            if (Convert.ToInt32(outError.Value) != 0)
            {
                Exception err = new Exception(string.Format("Error ({0}:{1})", outError.Value, outMensaje.Value));
                LogLibrary.ServiceOperations.LogOperation.Log("RequestWebApiGet", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = Convert.ToInt32(outError.Value);
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;

            return oDataResponse;
        }

        public static DataResponse RequestWebApiGet(TransactionalContext tx, IDataContainer databag, long idRequest)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Work.usp_RequestWebApiGetByCriterio";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idRequest", idRequest);

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

            if (Convert.ToInt32(outError.Value) != 0)
            {
                Exception err = new Exception(string.Format("Error ({0}:{1})", outError.Value, outMensaje.Value));
                LogLibrary.ServiceOperations.LogOperation.Log("RequestWebApiGet", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = Convert.ToInt32(outError.Value);
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;

            return oDataResponse;
        }

        /// <summary>
        /// Inicialización de parámetros en Nulo para Preguntas
        /// <param name="cmd">Comando de SQL con la colección de Parámetros</param>
        /// </summary>
        private static void RequestWebApiSetNullParameters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@idRequest", null);
            cmd.Parameters.AddWithValue("@idTicket", null);
            cmd.Parameters.AddWithValue("@idRecibo", null);
            cmd.Parameters.AddWithValue("@methodAddress", null);
            cmd.Parameters.AddWithValue("@dsRequest", null);
            cmd.Parameters.AddWithValue("@dsResponse", null);
            cmd.Parameters.AddWithValue("@feRequest", null);
            cmd.Parameters.AddWithValue("@feRespose", null);
            cmd.Parameters.AddWithValue("@esExitoso", null);
            cmd.Parameters.AddWithValue("@return_value", null);
        }
    }
}

