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
        public static DataResponse addBitacora(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Work.usp_BitacoraAddUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            BitacoraSetNullParemeters(cmd);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("addBitacora", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = cmd.Parameters["@return_value"].Value.ToString();
            return oDataResponse;
        }

        private static void BitacoraSetNullParemeters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@idBitacora", null);
            cmd.Parameters.AddWithValue("@idTicket", null);
            cmd.Parameters.AddWithValue("@fechaIni", null);
            cmd.Parameters.AddWithValue("@fechaFin", null);
            cmd.Parameters.AddWithValue("@codSistema", null);
            cmd.Parameters.AddWithValue("@nbOperacion", null);
            cmd.Parameters.AddWithValue("@dsRespuesta", null);
            cmd.Parameters.AddWithValue("@return_value", null);
        }
    }
}
