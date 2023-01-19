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
    public partial class KernelStore
    {

        public static DataResponse AddAplicacion(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.usp_AplicacionAddUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            AplicacionSetNullParemeters(cmd);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("AddAplicacion", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        private static void AplicacionSetNullParemeters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@codAplicacion", null);
            cmd.Parameters.AddWithValue("@nbAplicacion", null);
            cmd.Parameters.AddWithValue("@ActivateLog", null);
            cmd.Parameters.AddWithValue("@dsTitulo", null);
            cmd.Parameters.AddWithValue("@noVersion", null);
            cmd.Parameters.AddWithValue("@nbInstanciaDB", null);
            cmd.Parameters.AddWithValue("@nbDB", null);
            cmd.Parameters.AddWithValue("@CreadoPor", null);
            cmd.Parameters.AddWithValue("@idResourceBanner", null);
            cmd.Parameters.AddWithValue("@idResourceLogo", null);
            cmd.Parameters.AddWithValue("@idResourceImgHome", null);
            cmd.Parameters.AddWithValue("@idResourceImgReplicaDer", null);
            cmd.Parameters.AddWithValue("@idResourceImgReplicaIzq", null);
            cmd.Parameters.AddWithValue("@dsSubTitulo", null);
            cmd.Parameters.AddWithValue("@idCodigoAmbiente", null);
        }

        public static DataResponse GetAplicacionByKey(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, IDataContainer databag, string codAplicacion)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.usp_AplicacionGetByKey";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);

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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetAplicacionByKey", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

    }
}
