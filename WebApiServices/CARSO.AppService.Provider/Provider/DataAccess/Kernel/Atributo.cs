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
        public static DataResponse AddAtributo(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.usp_AtributoAddUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            AtributoSetNullParemeters(cmd);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("AddAtributo", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = cmd.Parameters["@return_value"].Value.ToString();
            return oDataResponse;
        }

        private static void AtributoSetNullParemeters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@idAtributo", null);
            cmd.Parameters.AddWithValue("@idObjeto", null);
            cmd.Parameters.AddWithValue("@nbAtributo", null);
            cmd.Parameters.AddWithValue("@nbFisico", null);
            cmd.Parameters.AddWithValue("@esFiltrado", null);
            cmd.Parameters.AddWithValue("@esPK", null);
            cmd.Parameters.AddWithValue("@esFK", null);
            cmd.Parameters.AddWithValue("@esObligatorio", null);
            cmd.Parameters.AddWithValue("@esActivo", null);
            cmd.Parameters.AddWithValue("@idCodigoTipoAtributo", null);
            cmd.Parameters.AddWithValue("@noCatalogo", null);
            cmd.Parameters.AddWithValue("@dsLabel", null);
            cmd.Parameters.AddWithValue("@noLength", null);
            cmd.Parameters.AddWithValue("@noPrecision", null);
            cmd.Parameters.AddWithValue("@noScale", null);
            cmd.Parameters.AddWithValue("@return_value", null);
        }

        public static DataResponse GetAtributoByKey(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, IDataContainer databag, int idAtributo)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.usp_AtributoGetByKey";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idAtributo", idAtributo);

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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetAtributoByKey", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetAtributoByCriterio(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, IDataContainer databag, int idAtributo = 0, int idObjeto = 0, string nbAtributo = "", string nbFisico = "", int esFiltrado = 2, int esPK = 2, int esFK = 2, int esObligatorio = 2, int esActivo = 2, int idCodigoTipoAtributo = 0, int noCatalogo = 0, string dsLabel = "", int noLength = 0, int noPrecision = 0, int noScale = 0)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.usp_AtributoGetByCriterio";
            cmd.CommandType = CommandType.StoredProcedure;

            if (idAtributo != 0)
                cmd.Parameters.AddWithValue("@idAtributo", idAtributo);
            if (idObjeto != 0)
                cmd.Parameters.AddWithValue("@idObjeto", idObjeto);
            if (nbAtributo != "")
                cmd.Parameters.AddWithValue("@nbAtributo", nbAtributo);
            if (nbFisico != "")
                cmd.Parameters.AddWithValue("@nbFisico", nbFisico);
            if (esFiltrado != 2)
                cmd.Parameters.AddWithValue("@esFiltrado", esFiltrado);
            if (esPK != 2)
                cmd.Parameters.AddWithValue("@esPK", esPK);
            if (esFK != 2)
                cmd.Parameters.AddWithValue("@esFK", esFK);
            if (esObligatorio != 2)
                cmd.Parameters.AddWithValue("@esObligatorio", esObligatorio);
            if (esActivo != 2)
                cmd.Parameters.AddWithValue("@esActivo", esActivo);
            if (idCodigoTipoAtributo != 0)
                cmd.Parameters.AddWithValue("@idCodigoTipoAtributo", idCodigoTipoAtributo);
            if (noCatalogo != 0)
                cmd.Parameters.AddWithValue("@noCatalogo", noCatalogo);
            if (dsLabel != "")
                cmd.Parameters.AddWithValue("@dsLabel", dsLabel);
            if (noLength != 0)
                cmd.Parameters.AddWithValue("@noLength", noLength);
            if (noPrecision != 0)
                cmd.Parameters.AddWithValue("@noPrecision", noPrecision);
            if (noScale != 0)
                cmd.Parameters.AddWithValue("@noScale", noScale);

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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetAtributoByCriterio", err, ConfigurationManager.AppSettings["AppCode"]);
            }

            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }
    }
}
