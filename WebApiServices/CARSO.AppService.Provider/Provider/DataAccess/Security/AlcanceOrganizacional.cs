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

        public static DataResponse AddAlcanceOrganizacional(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, IDataContainer databag, string codAplicacion)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Security.usp_AlcanceOrganizacionalAddUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            AlcanceOrganizacionalSetNullParemeters(cmd);
            cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("AddAlcanceOrganizacional", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = cmd.Parameters["@return_value"].Value.ToString();
            return oDataResponse;
        }
        private static void AlcanceOrganizacionalSetNullParemeters(SqlCommand cmd)
        {

            cmd.Parameters.AddWithValue("@codAlcanceOrg", 0);
            cmd.Parameters.AddWithValue("@nbAlias", null);
            cmd.Parameters.AddWithValue("@idCodigoTipoParametro", 0);
            cmd.Parameters.AddWithValue("@dsValor", null);
            cmd.Parameters.AddWithValue("@return_value", null);

        }
        public static DataResponse GetAlcanceOrganizacional(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, int codAlcanceOrg, string codAplicacion, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Security.usp_CatalogoGetByKey";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codAlcanceOrg", codAlcanceOrg);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetAlcanceOrganizacional", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetAlcanceOrganizacionalByNbAlias(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string nbAlias, string codAplicacion, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Security.usp_AlcanceOrganizacionalGetByAlias";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nbAlias", nbAlias);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetAlcanceOrganizacionalByNbAlias", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetAlcanceOrganizacionalByNbAliasAndTipoParametro(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string nbAlias, int idCodigoTipoParametro, string codAplicacion, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Security.usp_AlcanceOrganizacionalGetByAliasAndTipoParametro";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nbAlias", nbAlias);
            cmd.Parameters.AddWithValue("@idCodigoTipoParametro", idCodigoTipoParametro);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetAlcanceOrganizacionalByNbAliasAndTipoParametro", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse DelAlcanceOrganizacional(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, int codAlcanceOrg, string codAplicacion)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Security.usp_AlcanceOrganizacionalDel";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codAlcanceOrg", codAlcanceOrg);
            cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("DelAlcanceOrganizacional", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse DelAlcanceOrganizacionalByAlias(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string nbAlias, string codAplicacion)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Security.usp_AlcanceOrganizacionalDelByAlias";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nbAlias", nbAlias);
            cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("DelAlcanceOrganizacionalByAlias", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }
    }
}
