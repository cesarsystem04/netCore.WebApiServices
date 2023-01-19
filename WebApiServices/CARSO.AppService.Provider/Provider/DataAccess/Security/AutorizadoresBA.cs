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
    public partial class SecurityStore
    {
        public static DataResponse GetAutorizadoresBA(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string Alias,string codDepto,string codAplicacion,string dsExtraVuelo, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Security.[usp_AutorizadoresBA]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nbAlias", Alias);
            cmd.Parameters.AddWithValue("@codDepto", codDepto);
            cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);
            cmd.Parameters.AddWithValue("@dsExtraVuelo", dsExtraVuelo);

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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("usp_AutorizadoresBA", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }
    }
}
