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
    public partial class WorkStore
    {
        public static DataResponse addTicket(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Work.usp_TicketAddUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            TicketSetNullParemeters(cmd);
            databag.SetDataTo(cmd.Parameters);
            SqlParameter outMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 1000);
            outMensaje.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outMensaje);
            SqlParameter outError = new SqlParameter("@NumeroError", SqlDbType.Int);
            outError.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outError);
            SqlParameter outTicket = new SqlParameter("@Ticket", SqlDbType.VarChar, 36);
            outTicket.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outTicket);

            cmd.ExecuteNonQuery();
            if (int.Parse(outError.Value.ToString()) != 0)
            {
                Exception err = new Exception(string.Format("Error ({0}:{1})", outError.Value.ToString(), outMensaje.Value.ToString()));
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("addTicket", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = outTicket.Value.ToString();
            return oDataResponse;
        }

        private static void TicketSetNullParemeters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@idTicket", null);
            cmd.Parameters.AddWithValue("@codAplicacion", null);
            cmd.Parameters.AddWithValue("@idCodigoTipoProcesoMasivo", null);
            cmd.Parameters.AddWithValue("@CreadoPor", null);
            cmd.Parameters.AddWithValue("@feCreacion", null);
            cmd.Parameters.AddWithValue("@idRegistro", null);
            cmd.Parameters.AddWithValue("@idCodigoEstatus", null);
            cmd.Parameters.AddWithValue("@codRespuesta", null);
            cmd.Parameters.AddWithValue("@dsRespuesta", null);
            cmd.Parameters.AddWithValue("@feProcesamiento", null);
            cmd.Parameters.AddWithValue("@nbOrigen", null);
            cmd.Parameters.AddWithValue("@esMasivo", null);
        }

        public static DataResponse GetTicketByKey(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, IDataContainer databag, string idTicket)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Work.usp_TicketGetByKey";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idTicket", !string.IsNullOrWhiteSpace(idTicket) ? idTicket : null);

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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetTicketByKey", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();

            return oDataResponse;
        }
        public static DataResponse GetTicketByFind(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, IDataContainer databag, string idTicket, int idCodigoEstatus, int idRegistro, int idCodigoTipoProcesoMasivo, string FeInicio, string FeFin, string CreadoPor)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Work.usp_TicketFind";
            cmd.CommandType = CommandType.StoredProcedure;
            if (idTicket != string.Empty)
                cmd.Parameters.AddWithValue("@idTicket", idTicket);
            if (idCodigoEstatus != 0)
                cmd.Parameters.AddWithValue("@idCodigoEstatus", idCodigoEstatus);
            if (idRegistro != 0)
                cmd.Parameters.AddWithValue("@idRegistro", idRegistro);
            if (idCodigoTipoProcesoMasivo != 0)
                cmd.Parameters.AddWithValue("@idCodigoTipoProcesoMasivo", idCodigoTipoProcesoMasivo);
            if (FeInicio != string.Empty)
                cmd.Parameters.AddWithValue("@FeInicio", DateTime.Parse(FeInicio).ToString("yyyyMMdd"));
            if (FeFin != string.Empty)
                cmd.Parameters.AddWithValue("@FeFin", DateTime.Parse(FeFin).ToString("yyyyMMdd"));
            if (CreadoPor != string.Empty)
                cmd.Parameters.AddWithValue("@CreadoPor", CreadoPor);

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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetTicketByFind", err);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();

            return oDataResponse;
        }
    }
}
