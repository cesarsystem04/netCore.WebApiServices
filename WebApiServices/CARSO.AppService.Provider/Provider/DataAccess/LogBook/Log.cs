using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Configuration;
using System.Threading.Tasks;
using CARSO.LogLibrary.ServiceDataAccess;
using System.Web;

namespace CARSO.AppService.ServiceDataAccess
{
    public partial class LogBookStore
    {
        public static void Log(string method, string errMsg, string AppCode = "")
        {
            try
            {
                //string desc = string.Format("Error en {0} ({1}:{2})", method, err.Message, err.GetType().FullName);
                byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["dbCon"]);
                SqlConnection Connection = new SqlConnection();
                Connection.ConnectionString = System.Text.Encoding.Unicode.GetString(bytetemp);
                Connection.Open();
                if (Connection.State == ConnectionState.Open)
                {
                    SqlCommand cmd = Connection.CreateCommand();
                    cmd.CommandText = "Logbook.usp_ErrorlogAddUpdate";
                    cmd.CommandType = CommandType.StoredProcedure;
                    string current_user =System.Security.Principal.WindowsIdentity.GetCurrent().Name;
       
                    string codAplicacion = AppCode;
                    if (string.IsNullOrEmpty(AppCode))
                        codAplicacion = ConfigurationManager.AppSettings["AppCode"];
                    cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);
                    cmd.Parameters.AddWithValue("@nbAlias", current_user);
                    cmd.Parameters.AddWithValue("@dsHost", Environment.MachineName);
                    cmd.Parameters.AddWithValue("@dsNotification", errMsg);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    Exception oException = new Exception(errMsg);
                    CARSO.LogLibrary.ServiceDataAccess.EventLog.AddLog(System.Security.Principal.WindowsIdentity.GetCurrent().Name, Environment.MachineName, oException);
                }
            }
            catch (Exception error)
            {
                Exception oException = new Exception(errMsg);
                CARSO.LogLibrary.ServiceDataAccess.EventLog.AddLog(System.Security.Principal.WindowsIdentity.GetCurrent().Name, Environment.MachineName, oException);
                CARSO.LogLibrary.ServiceDataAccess.EventLog.AddLog(System.Security.Principal.WindowsIdentity.GetCurrent().Name, Environment.MachineName, error);
            }
        }

        public static void LogEntry(CARSO.LogLibrary.ServiceDataAccess.IDataContainer entry, string AppCode = "")
        {
            try
            {
                byte[] bytetemp = Convert.FromBase64String(ConfigurationManager.AppSettings["dbCon"]);
                SqlConnection Connection = new SqlConnection();
                Connection.ConnectionString = System.Text.Encoding.Unicode.GetString(bytetemp);
                Connection.Open();
                if (Connection.State == ConnectionState.Open)
                {
                    SqlCommand cmd = Connection.CreateCommand();
                    cmd.CommandText = "LogBook.usp_ErrorlogAddUpdate";
                    cmd.CommandType = CommandType.StoredProcedure;
                    CARSO.LogLibrary.ServiceOperations.LogEntry oLogEntry = (CARSO.LogLibrary.ServiceOperations.LogEntry)entry;
                    string current_user = oLogEntry.UserInfo.UserName;
                    if (string.IsNullOrEmpty(current_user))
                        current_user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                    string Host = oLogEntry.UserInfo.Host;
                    if (string.IsNullOrEmpty(Host))
                        Host = Environment.MachineName;
                    string codAplicacion = AppCode;
                    if (string.IsNullOrEmpty(AppCode))
                        codAplicacion = ConfigurationManager.AppSettings["AppCode"];
                    cmd.Parameters.AddWithValue("@codAplicacion", codAplicacion);
                    cmd.Parameters.AddWithValue("@nbAlias", current_user);
                    cmd.Parameters.AddWithValue("@dsHost", Host);
                    cmd.Parameters.AddWithValue("@dsNotification", oLogEntry.Description);
                    entry.SetDataTo(cmd.Parameters);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    Exception err = new Exception(((CARSO.LogLibrary.ServiceOperations.LogEntry)entry).Description);
                    CARSO.LogLibrary.ServiceDataAccess.EventLog.AddLog(System.Security.Principal.WindowsIdentity.GetCurrent().Name, Environment.MachineName, err);
                }
            }
            catch (Exception error)
            {
                Exception err = new Exception(((CARSO.LogLibrary.ServiceOperations.LogEntry)entry).Description);
                CARSO.LogLibrary.ServiceDataAccess.EventLog.AddLog(System.Security.Principal.WindowsIdentity.GetCurrent().Name, Environment.MachineName, err);
                CARSO.LogLibrary.ServiceDataAccess.EventLog.AddLog(System.Security.Principal.WindowsIdentity.GetCurrent().Name, Environment.MachineName, error);
            }
        }

    }
}
