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
    public class AlcanceOrganizacional : IDataContainer
    {

        #region Properties
        /// <summary>
        /// Identificador del Alcance Organizacional
        /// </summary>
        [DataMember]
        public int codAlcanceOrg { get; set; }
        /// <summary>
        /// Nombre del Alias
        /// </summary>
        [DataMember]
        public string nbAlias { get; set; }
        /// <summary>
        /// Codigo de Parametro
        /// </summary>
        [DataMember]
        public int idCodigoTipoParametro { get; set; }
        /// <summary>
        /// Valor de Parametro
        /// </summary>
        [DataMember]
        public string dsValor { get; set; }
        /// <summary>
        /// Descripcion del tipo de parametro
        /// </summary>
        [DataMember]
        public string TipoParametro { get; set; }
        #endregion

        #region Constructors
        public AlcanceOrganizacional()
        {
            codAlcanceOrg = 0;
            nbAlias = string.Empty;
            idCodigoTipoParametro = 0;
            dsValor = string.Empty;
            TipoParametro = string.Empty;
        }
        #endregion

        #region IDataContainer Members
        public void LoadDataFrom(IDataReader reader)
        {
            if (!reader.Read()) return;
            if (!Convert.IsDBNull(reader["codAlcanceOrg"])) codAlcanceOrg = Int32.Parse(reader["codAlcanceOrg"].ToString());
            if (!Convert.IsDBNull(reader["nbAlias"])) nbAlias = reader["nbAlias"].ToString();
            if (!Convert.IsDBNull(reader["idCodigoTipoParametro"])) idCodigoTipoParametro = Int32.Parse(reader["idCodigoTipoParametro"].ToString());
            if (!Convert.IsDBNull(reader["dsValor"])) dsValor = reader["dsValor"].ToString();
            if (!Convert.IsDBNull(reader["TipoParametro"])) TipoParametro = reader["TipoParametro"].ToString();
        }

        public void SetDataTo(IDataParameterCollection pars)
        {
            if (codAlcanceOrg != 0) DataUtil.SetValue(pars, "@codAlcanceOrg", codAlcanceOrg);
            if (nbAlias != string.Empty) DataUtil.SetValue(pars, "@nbAlias", nbAlias);
            if (idCodigoTipoParametro != 0) DataUtil.SetValue(pars, "@idCodigoTipoParametro", idCodigoTipoParametro);
            if (dsValor != string.Empty) DataUtil.SetValue(pars, "@dsValor", dsValor);
            DataUtil.SetReturnedValue(pars, "@return_value");
        }
        #endregion
    }

    [Serializable]
    [DataContract(IsReference = true)]
    public class AlcanceOrganizacionalList : IDataContainer
    {
        #region Properties
        /// <summary>
        /// Colección con elementos del Alcance Organizacional
        /// </summary>
         [DataMember]
        public List<AlcanceOrganizacional> lstAlcanceOrganizacional { get; set; }
        #endregion Properties

        #region Constructors
        public AlcanceOrganizacionalList()
        {
            lstAlcanceOrganizacional = new List<AlcanceOrganizacional>();
        }
        #endregion Constructors

        #region IDataContainer Members
        public void LoadDataFrom(IDataReader reader)
        {
            lstAlcanceOrganizacional = new List<AlcanceOrganizacional>();
            while (reader.Read())
            {
                AlcanceOrganizacional oAlcanceOrganizacional = new AlcanceOrganizacional();
                if (!Convert.IsDBNull(reader["codAlcanceOrg"])) oAlcanceOrganizacional.codAlcanceOrg = Int32.Parse(reader["codAlcanceOrg"].ToString());
                if (!Convert.IsDBNull(reader["nbAlias"])) oAlcanceOrganizacional.nbAlias = reader["nbAlias"].ToString();
                if (!Convert.IsDBNull(reader["idCodigoTipoParametro"])) oAlcanceOrganizacional.idCodigoTipoParametro = Int32.Parse(reader["idCodigoTipoParametro"].ToString());
                if (!Convert.IsDBNull(reader["dsValor"])) oAlcanceOrganizacional.dsValor = reader["dsValor"].ToString();
                if (!Convert.IsDBNull(reader["TipoParametro"])) oAlcanceOrganizacional.TipoParametro = reader["TipoParametro"].ToString();
                lstAlcanceOrganizacional.Add(oAlcanceOrganizacional);
            }
        }

        public void SetDataTo(IDataParameterCollection pars)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

}
