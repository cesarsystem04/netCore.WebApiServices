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
    /// <summary>
    /// Alcance Organizacional del Sistema
    /// </summary>
    [Serializable]
    [DataContract(IsReference = true)]
    public class AutorizadoresBA : IDataContainer
    {

        #region Properties
        /// <summary>
        /// Identificador del Alcance Organizacional
        /// </summary>
        [DataMember]
        public int Nivel { get; set; }
        /// <summary>
        /// Nombre del Alias
        /// </summary>
        [DataMember]
        public string nbAlias { get; set; }
        /// <summary>
        /// Codigo de Parametro
        /// </summary>
        [DataMember]
        public string nbEmpleado { get; set; }
        /// <summary>
        /// Valor de Parametro
        /// </summary>
        [DataMember]
        public string dsMail { get; set; }
        /// <summary>
        /// Descripcion del tipo de parametro
        /// </summary>
      
        #endregion

        #region Constructors
        public AutorizadoresBA()
        {
            Nivel = 0;
            nbAlias = string.Empty;
            nbEmpleado = string.Empty;
            dsMail = string.Empty;
         
        }
        #endregion

        #region IDataContainer Members
        public void LoadDataFrom(IDataReader reader)
        {
            if (!reader.Read()) return;
            if (!Convert.IsDBNull(reader["Nivel"])) Nivel = Int32.Parse(reader["Nivel"].ToString());
            if (!Convert.IsDBNull(reader["nbAlias"])) nbAlias = reader["nbAlias"].ToString();
            if (!Convert.IsDBNull(reader["nbEmpleado"])) nbEmpleado = reader["nbEmpleado"].ToString();
            if (!Convert.IsDBNull(reader["dsMail"])) dsMail = reader["dsMail"].ToString();
        }

        public void SetDataTo(IDataParameterCollection pars)
        {
        //    if (this.Nivel != 0) DataUtil.SetValue(pars, "@Nivel", this.Nivel);
        //    if (this.nbAlias != string.Empty) DataUtil.SetValue(pars, "@nbAlias", this.nbAlias);
        //    if (this.idCodigoTipoParametro != 0) DataUtil.SetValue(pars, "@idCodigoTipoParametro", this.idCodigoTipoParametro);
        //    if (this.dsValor != string.Empty) DataUtil.SetValue(pars, "@dsValor", this.dsValor);
        //    DataUtil.SetReturnedValue(pars, "@return_value");
        }
        #endregion
    }

    [Serializable]
    [DataContract(IsReference = true)]
    public class AutorizadoresBAList : IDataContainer
    {
        #region Properties
        /// <summary>
        /// Colección con elementos del Alcance Organizacional
        /// </summary>
        [DataMember]
        public List<AutorizadoresBA> lstAutorizadoresBA { get; set; }
        #endregion Properties

        #region Constructors
        public AutorizadoresBAList()
        {
            lstAutorizadoresBA = new List<AutorizadoresBA>();
        }
        #endregion Constructors

        #region IDataContainer Members
        public void LoadDataFrom(IDataReader reader)
        {
            lstAutorizadoresBA = new List<AutorizadoresBA>();
            while (reader.Read())
            {
                AutorizadoresBA oAutorizadoresBA = new AutorizadoresBA();
                if (!Convert.IsDBNull(reader["Nivel"])) oAutorizadoresBA.Nivel = Int32.Parse(reader["Nivel"].ToString());
                if (!Convert.IsDBNull(reader["nbAlias"])) oAutorizadoresBA.nbAlias = reader["nbAlias"].ToString();
                if (!Convert.IsDBNull(reader["nbEmpleado"])) oAutorizadoresBA.nbEmpleado = reader["nbEmpleado"].ToString();
                if (!Convert.IsDBNull(reader["dsMail"])) oAutorizadoresBA.dsMail = reader["dsMail"].ToString();
                lstAutorizadoresBA.Add(oAutorizadoresBA);
            }
        }

        public void SetDataTo(IDataParameterCollection pars)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

}
