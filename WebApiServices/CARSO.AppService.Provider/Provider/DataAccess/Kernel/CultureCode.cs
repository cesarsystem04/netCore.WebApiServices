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
        public static DataResponse AddCultureCode(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.usp_CultureCodeAddUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            CultureCodeSetNullParemeters(cmd);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("AddCultureCode", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = cmd.Parameters["@return_value"].Value.ToString();
            return oDataResponse;
        }

        private static void CultureCodeSetNullParemeters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@nbLanguageCulture", null);
            cmd.Parameters.AddWithValue("@dsDisplayName", null);
            cmd.Parameters.AddWithValue("@codCulture", null);
            cmd.Parameters.AddWithValue("@valISO639x", null);
            cmd.Parameters.AddWithValue("@esActivo", null);
            cmd.Parameters.AddWithValue("@return_value", null);
        }

        public static DataResponse GetCultureCodeByKey(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, IDataContainer databag, string nbLanguageCulture)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.usp_CultureCodeGetByKey";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nbLanguageCulture", nbLanguageCulture);

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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetCultureCodeByKey", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetCultureCodeByCriterio(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, IDataContainer databag, string nbLanguageCulture = "", string dsDisplayName = "", string codCulture = "", string valISO639x = "", int esActivo = 2)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.usp_CultureCodeGetByCriterio";
            cmd.CommandType = CommandType.StoredProcedure;

            if (nbLanguageCulture != "")
                cmd.Parameters.AddWithValue("@nbLanguageCulture", nbLanguageCulture);
            if (dsDisplayName != "")
                cmd.Parameters.AddWithValue("@dsDisplayName", dsDisplayName);
            if (codCulture != "")
                cmd.Parameters.AddWithValue("@codCulture", codCulture);
            if (valISO639x != "")
                cmd.Parameters.AddWithValue("@valISO639x", valISO639x);
            if (esActivo != 2)
                cmd.Parameters.AddWithValue("@esActivo", esActivo);

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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetCultureCodeByCriterio", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }
    }
}
