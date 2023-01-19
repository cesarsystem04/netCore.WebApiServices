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
   
        public static DataResponse GetEstadoAll(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Configuration.usp_EstadoGetAll";
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetEstadoAll", err);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetEstadoByEstado(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string codEstado, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Configuration.usp_EstadoGetByEstado";
            cmd.Parameters.AddWithValue("@codEstado", codEstado);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetEstadoByEstado", err);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetEstadoByKey(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string codEstado, string codMunicipio, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Configuration.usp_EstadoGetByKey";
            cmd.Parameters.AddWithValue("@codEstado", codEstado);
            cmd.Parameters.AddWithValue("@codMunicipio", codMunicipio);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetEstadoByKey", err);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }


    }
}
