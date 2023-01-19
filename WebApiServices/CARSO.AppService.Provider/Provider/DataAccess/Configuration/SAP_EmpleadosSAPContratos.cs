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
        public static DataResponse GetEmpleadosSAPContratos(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, int noDias, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Util.usp_EmpleadosSAPContratosGet";
            cmd.Parameters.AddWithValue("@noDias", noDias);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter outMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 1000);
            outMensaje.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outMensaje);
            SqlParameter outError = new SqlParameter("@NumeroError", SqlDbType.Int);
            outError.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outError);
            cmd.CommandTimeout = 0;
            using (IDataReader reader = cmd.ExecuteReader())
            { databag.LoadDataFrom(reader); }
            if (int.Parse(outError.Value.ToString()) != 0)
            {
                Exception err = new Exception(string.Format("Error ({0}:{1})", outError.Value.ToString(), outMensaje.Value.ToString()));
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetEmpleadosSAPContratos", err);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }
        
                  public static DataResponse GetEmpleadosSAPContratosbyNoEmpleado(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string NoEmpleado, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Util.[usp_EmpleadosSAPContratosGetByEmpleado]";
            cmd.Parameters.AddWithValue("@NoEmpleado", NoEmpleado);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetEmpleadosSAPContratosbyNoEmpleado", err);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }
    }
}
