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

        public static DataResponse AddEtiquetaXCulturaUpdate(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.usp_EtiquetaXCulturaAddUpdate";
            cmd.CommandType = CommandType.StoredProcedure;
            EtiquetaXCulturaSetNullParameters(cmd);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("AddEtiquetaXCulturaUpdate", err, ConfigurationManager.AppSettings["AppCode"]);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        private static void EtiquetaXCulturaSetNullParameters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@codEtiqueta", null);
            cmd.Parameters.AddWithValue("@codConjunto", null);
            cmd.Parameters.AddWithValue("@codAplicacion", null);
            cmd.Parameters.AddWithValue("@nbLanguageCulture", null);
            cmd.Parameters.AddWithValue("@nbEtiqueta", null);
            cmd.Parameters.AddWithValue("@dsEtiqueta", null);
        }

        public static DataResponse GetEtiquetaXCulturaByKey(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string codEtiqueta, string codConjunto, string codAplicacion, string nbLanguageCulture, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.usp_EtiquetaXCulturaGetByKey";
            cmd.Parameters.AddWithValue("@codEtiqueta", codEtiqueta);
            cmd.Parameters.AddWithValue("@codConjunto", codConjunto);
            cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);
            cmd.Parameters.AddWithValue("@nbLanguageCulture", nbLanguageCulture);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetEtiquetaXCulturaByKey", err, ConfigurationManager.AppSettings["AppCode"]);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetEtiquetaXCulturaBycodEtiqueta(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string codEtiqueta, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.usp_EtiquetaXCulturaGetByCodEtiqueta";
            cmd.Parameters.AddWithValue("@codEtiqueta", codEtiqueta);

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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetEtiquetaXCulturaByCodEtiqueta", err, ConfigurationManager.AppSettings["AppCode"]);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse EtiquetaXCulturaDeleteByCodigo(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string codEtiqueta, string codConjunto, string codAplicacion, string nbLanguageCulture)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.usp_EtiquetaXCulturaDeleteByCodigo";
            cmd.Parameters.AddWithValue("@codEtiqueta", codEtiqueta);
            cmd.Parameters.AddWithValue("@codConjunto", codConjunto);
            cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);
            cmd.Parameters.AddWithValue("@nbLanguageCulture", nbLanguageCulture);
            cmd.CommandType = CommandType.StoredProcedure;
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("EtiquetaXCulturaDeleteByCodigo", err, ConfigurationManager.AppSettings["AppCode"]);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }
        public static DataResponse EtiquetaXCulturaDeleteBycodEtiqueta(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string codEtiqueta, string codConjunto, string codAplicacion)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.[usp_EtiquetaXCulturaDeleteBycodEtiqueta]";
            cmd.Parameters.AddWithValue("@codEtiqueta", codEtiqueta);
            cmd.Parameters.AddWithValue("@codConjunto", codConjunto);
            cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);

            cmd.CommandType = CommandType.StoredProcedure;
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("EtiquetaXCulturaDeleteByCodigo", err, ConfigurationManager.AppSettings["AppCode"]);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }
        public static DataResponse GetEtiquetaXCulturaGetByCodConjuntoAndnbLangeageCulture(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx,  string codConjunto, string codAplicacion, string nbLanguageCulture, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.usp_EtiquetaXCulturaGetByCodConjuntoAndnbLangeageCulture";
           
            cmd.Parameters.AddWithValue("@codConjunto", codConjunto);
            cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);
            cmd.Parameters.AddWithValue("@nbLanguageCulture", nbLanguageCulture);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("EtiquetaXCulturaGetByCodConjuntoAndnbLangeageCulture", err, ConfigurationManager.AppSettings["AppCode"]);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }


        public static DataResponse GetEtiquetaXCulturaGetByCodEtiquetaNormaAndnbLangeageCulture(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string codEtiqueta, string codAplicacion, string nbLanguageCulture, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.usp_EtiquetaXCulturaGetByCodEtiquetaNormaAndnbLangeageCulture";

            cmd.Parameters.AddWithValue("@codEtiqueta", codEtiqueta);
            cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);
            cmd.Parameters.AddWithValue("@nbLanguageCulture", nbLanguageCulture);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetEtiquetaXCulturaGetByCodEtiquetaNormaAndnbLangeageCulture", err, ConfigurationManager.AppSettings["AppCode"]);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCulture(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string codEtiqueta, string codAplicacion, string nbLanguageCulture, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.usp_EtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCulture";

            cmd.Parameters.AddWithValue("@codEtiqueta", codEtiqueta);
            cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);
            cmd.Parameters.AddWithValue("@nbLanguageCulture", nbLanguageCulture);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCulture", err, ConfigurationManager.AppSettings["AppCode"]);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }


        public static DataResponse GetEtiquetaXCulturaGetByCodEtiquetaClasificadorVisibleAndnbLangeageCulture(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string codEtiqueta, string codAplicacion, string nbLanguageCulture, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.usp_EtiquetaXCulturaGetByCodEtiquetaClasificadorVisibleAndnbLangeageCulture";

            cmd.Parameters.AddWithValue("@codEtiqueta", codEtiqueta);
            cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);
            cmd.Parameters.AddWithValue("@nbLanguageCulture", nbLanguageCulture);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetEtiquetaXCulturaGetByCodEtiquetaClasificadorVisibleAndnbLangeageCulture", err, ConfigurationManager.AppSettings["AppCode"]);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCultureandidNorma(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string codEtiqueta, string codAplicacion, string nbLanguageCulture,int idNorma, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.[usp_EtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCultureandidNorma]";

            cmd.Parameters.AddWithValue("@codEtiqueta", codEtiqueta);
            cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);
            cmd.Parameters.AddWithValue("@nbLanguageCulture", nbLanguageCulture);
            cmd.Parameters.AddWithValue("@idNorma", idNorma);
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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCultureandidNorma", err, ConfigurationManager.AppSettings["AppCode"]);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }

        public static DataResponse GetEtiquetaXCulturaGetByCodEtiquetas(CARSO.LogLibrary.ServiceDataAccess.TransactionalContext tx, string codEtiquetas, string codAplicacion, string nbLanguageCulture, IDataContainer databag)
        {
            SqlCommand cmd = tx.Connection.CreateCommand();
            cmd.Transaction = tx.Transaction;
            cmd.CommandText = "Kernel.[usp_EtiquetaXCulturaGetByCodEtiquetas]";

            cmd.Parameters.AddWithValue("@codEtiquetas", codEtiquetas);
            cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);
            cmd.Parameters.AddWithValue("@nbLanguageCulture", nbLanguageCulture);

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
                CARSO.LogLibrary.ServiceOperations.LogOperation.Log("GetEtiquetaXCulturaGetByCodEtiquetaSubclaseAndnbLangeageCultureandidNorma", err, ConfigurationManager.AppSettings["AppCode"]);
            }
            DataResponse oDataResponse = new DataResponse();
            oDataResponse.NumeroError = int.Parse(outError.Value.ToString());
            oDataResponse.Mensaje = outMensaje.Value.ToString();
            oDataResponse.idRegistro = string.Empty;
            return oDataResponse;
        }
    }
}
