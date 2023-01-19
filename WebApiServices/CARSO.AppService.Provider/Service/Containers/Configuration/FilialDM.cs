using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.LogLibrary.ServiceDataContainers;
using System.Threading.Tasks;

namespace CARSO.AppService.ServiceDataContainers
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class FilialDM : IDataContainer
    {
        #region Properties
        /// <summary>
        /// Código de la Filial
        /// </summary>
         [DataMember]
        public string codFilial { get; set; }
        /// <summary>
        /// Nombre de la Filial
        /// </summary>
         [DataMember]
        public string nbFilial { get; set; }
        /// <summary>
        /// Nombre de la Filial con codigo
        /// </summary>
         [DataMember]
        public string nbFilialCode { get => string.Format("{0} - {1}", codFilial, nbFilial); set { } }
        /// <summary>
        /// Grupo de la filial Condumex = 1, Carso = 2
        /// </summary>
        [DataMember]
        public int noGrupo { get; set; }
        /// <summary>
        /// Cód de la Empresa
        /// </summary>
        [DataMember]
        public string codEmpresa { get; set; }
        /// <summary>
        /// RFC de la Empresa matriz
        /// </summary>
        [DataMember]
        public string RfcEmpresa { get; set; }
        /// <summary>
        /// Identificador de la filial
        /// </summary>
        [DataMember]
        public string codFilialID { get => string.Format("{0}|{1}|{2}", noGrupo, codEmpresa, codFilial); set { } }
        #endregion Properties

        #region Constructors
        /// <summary>
        /// Constructor de la Clase
        /// </summary>
        public FilialDM()
        {
            noGrupo = 0;
            codEmpresa = string.Empty;
            codFilial = string.Empty;
            nbFilial = string.Empty;
            RfcEmpresa = string.Empty;
        }
        #endregion Constructors

        #region IDataContainer Members
        public void LoadDataFrom(IDataReader reader)
        {
            if (!reader.Read()) return;
            if (!Convert.IsDBNull(reader["noGrupo"])) noGrupo = int.Parse(reader["noGrupo"].ToString());
            if (!Convert.IsDBNull(reader["codEmpresa"])) codEmpresa = reader["codEmpresa"] as string;
            if (!Convert.IsDBNull(reader["codFilial"])) codFilial = reader["codFilial"] as string;
            if (!Convert.IsDBNull(reader["nbFilial"])) nbFilial = reader["nbFilial"] as string;
            if (!Convert.IsDBNull(reader["RFCEmpresa"])) RfcEmpresa = reader["RFCEmpresa"] as string;
        }

        public void SetDataTo(IDataParameterCollection pars)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Equals & GetHashCode
        /// <summary>
        /// Implementación de Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is FilialDM))
                return false;

            FilialDM that = (FilialDM)obj;

            return this.codFilialID == that.codFilialID;
        }

        /// <summary>
        /// Implementación de GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.codFilialID.GetHashCode();
        }
        #endregion
    }

    [Serializable]
    [DataContract(IsReference = true)]
    public class FilialDMList : IDataContainer
    {
        #region Properties
        /// <summary>
        /// Colección con elementos de un catálogo
        /// </summary>
         [DataMember]
        public List<FilialDM> lstFilialDM { get; set; }
        #endregion

        #region Constructors
        public FilialDMList()
        {
            lstFilialDM = new List<FilialDM>();
        }
        #endregion Constructors

        #region IDataReader Members
        public void LoadDataFrom(IDataReader reader)
        {
            lstFilialDM = new List<FilialDM>();
            while (reader.Read())
            {
                FilialDM oFilial = new FilialDM();

                if (!Convert.IsDBNull(reader["noGrupo"])) oFilial.noGrupo = int.Parse(reader["noGrupo"].ToString());
                if (!Convert.IsDBNull(reader["codEmpresa"])) oFilial.codEmpresa = reader["codEmpresa"] as string;
                if (!Convert.IsDBNull(reader["codFilial"])) oFilial.codFilial = reader["codFilial"] as string;
                if (!Convert.IsDBNull(reader["nbFilial"])) oFilial.nbFilial = reader["nbFilial"] as string;
                if (!Convert.IsDBNull(reader["RFCEmpresa"])) oFilial.RfcEmpresa = reader["RFCEmpresa"] as string;

                lstFilialDM.Add(oFilial);
            }
        }

        public void SetDataTo(IDataParameterCollection pars)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

}
