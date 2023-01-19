using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CARSO.AppService.ServiceDataAccess;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.LogLibrary.ServiceDataContainers;
using System.Threading.Tasks;

namespace CARSO.AppService.ServiceDataContainers
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class CuentaServicioLDAP : IDataContainer
    {

        #region Properties
        public int idCuentaServicio { get; set; }
        public int idCodigoTipoServicio { get; set; }
        public int idCodigoTipoOperacion { get; set; }
        public string nbCuentaServicio { get; set; }
        public string dsCuentaServicio { get; set; }
        public string dsPassword { get; set; }
        public bool esActivo { get; set; }
        #endregion

        #region Constructors
        public CuentaServicioLDAP()
        {
            idCuentaServicio = 0;
            idCodigoTipoServicio = 0;
            idCodigoTipoOperacion = 0;
            nbCuentaServicio = string.Empty;
            dsCuentaServicio = string.Empty;
            dsPassword = string.Empty;
            esActivo = true;
        }
        #endregion

        public void LoadDataFrom(IDataReader reader)
        {
            if (!reader.Read()) return;
            if (!Convert.IsDBNull(reader["idCuentaServicio"])) idCuentaServicio = int.Parse(reader["idCuentaServicio"].ToString());
            if (!Convert.IsDBNull(reader["idCodigoTipoServicio"])) idCodigoTipoServicio = int.Parse(reader["idCodigoTipoServicio"].ToString());
            if (!Convert.IsDBNull(reader["idCodigoTipoOperacion"])) idCodigoTipoOperacion = int.Parse(reader["idCodigoTipoOperacion"].ToString());
            if (!Convert.IsDBNull(reader["nbCuentaServicio"])) nbCuentaServicio = reader["nbCuentaServicio"].ToString();
            if (!Convert.IsDBNull(reader["dsCuentaServicio"])) dsCuentaServicio = reader["dsCuentaServicio"].ToString();
            if (!Convert.IsDBNull(reader["dsPassword"])) dsPassword = reader["dsPassword"].ToString();
            if (!Convert.IsDBNull(reader["esActivo"])) esActivo = bool.Parse(reader["esActivo"].ToString());
        }

        public void SetDataTo(IDataParameterCollection pars)
        {
            throw new NotImplementedException();
        }
    }
}