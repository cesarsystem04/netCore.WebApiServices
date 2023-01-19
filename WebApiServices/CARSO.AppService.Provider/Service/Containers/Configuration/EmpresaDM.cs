using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.LogLibrary.ServiceDataContainers;
using System.Threading.Tasks;
using System.Linq;

namespace CARSO.AppService.ServiceDataContainers
{
    /// <summary>
    /// Elementos de Empleado
    /// </summary>
    [Serializable]
    [DataContract(IsReference = true)]
    public class EmpresaDM : IDataContainer
    {
        #region Properties
        /// <summary>
        /// Codigo del elemento Empresa
        /// </summary>
        [DataMember]
        public string codEmpresa { get; set; }
        /// <summary>
        /// Nombre del elemento Empresa
        /// </summary>
        [DataMember]
        public string nbEmpresa { get; set; }
        /// <summary>
        /// Identificador si el elemento es activo o no
        /// </summary>
        [DataMember]
        public bool esActivo { get; set; }
        /// <summary>
        /// Identificador si el elemento se Sincroniza o no
        /// </summary>
        [DataMember]
        public bool esSincroniza { get; set; }
        /// <summary>
        /// Nombre del elemento Empresa mas el codigo
        /// </summary>
        [DataMember]
        public string nbEmpresaCode { get => string.Format("{0} - {1}", codEmpresa, nbEmpresa); set { } }
        /// <summary>
        /// Grupo al que pertenece 1 = Condumex, 2 = CARSO
        /// </summary>
        [DataMember]
        public int noGrupo { get; set; }
        /// <summary>
        /// RFC de la Empresa
        /// </summary>
        [DataMember]
        public string RfcEmpresa { get; set; }
        /// <summary>
        /// Identificador de la empresa noGrupo|codEmpresa
        /// </summary>
        [DataMember]
        public string codEmpresaID { get => string.Format("{0}|{1}", noGrupo, codEmpresa); set { } }
        /// <summary>
        /// Descripción de la empresa codEmpresa - nbEmpresa (RfcEmpresa)
        /// </summary>
        [DataMember]
        public string dsEmpresa { get => string.Format("{0} - {1} ({2})", codEmpresa, nbEmpresa, RfcEmpresa); set { } }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor de la Clase
        /// </summary>
        public EmpresaDM()
        {
            codEmpresa = string.Empty;
            nbEmpresa = string.Empty;
            noGrupo = 0;
            RfcEmpresa = string.Empty;
            esActivo = true;
            esSincroniza = false;
        }
        #endregion

        #region Equals and GetHashCode
        /// <summary>
        /// Implementación del equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is EmpresaDM))
                return false;

            EmpresaDM that = (EmpresaDM)obj;

            return this.codEmpresaID == that.codEmpresaID;
        }

        public override int GetHashCode()
        {
            return this.codEmpresaID.GetHashCode();
        }
        #endregion

        #region IDataContainer Members
        public void LoadDataFrom(IDataReader reader)
        {
            if (!reader.Read()) return;
            if (!Convert.IsDBNull(reader["noGrupo"])) noGrupo = int.Parse(reader["noGrupo"].ToString());
            if (!Convert.IsDBNull(reader["codEmpresa"])) codEmpresa = reader["codEmpresa"] as string;
            if (!Convert.IsDBNull(reader["nbEmpresa"])) nbEmpresa = reader["nbEmpresa"] as string;
            if (!Convert.IsDBNull(reader["RFCEmpresa"])) RfcEmpresa = reader["RFCEmpresa"] as string;
            esActivo = (bool)reader["esActivo"];
            esSincroniza = (bool)reader["esSincroniza"];
        }

        public void SetDataTo(IDataParameterCollection pars)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

    [Serializable]
    [DataContract(IsReference = true)]
    public class EmpresaDMList : IDataContainer
    {
        #region Properties
        /// <summary>
        /// Colección con elementos de un catálogo
        /// </summary>
        [DataMember]
        public List<EmpresaDM> lstEmpresaDM { get; set; }
        #endregion Properties

        #region Constructors
        public EmpresaDMList()
        {
            lstEmpresaDM = new List<EmpresaDM>();
        }
        #endregion

        #region IDataReader Members
        public void LoadDataFrom(IDataReader reader)
        {
            lstEmpresaDM = new List<EmpresaDM>();
            while (reader.Read())
            {
                EmpresaDM oEmpresa = new EmpresaDM();

                if (!Convert.IsDBNull(reader["noGrupo"])) oEmpresa.noGrupo = int.Parse(reader["noGrupo"].ToString());
                if (!Convert.IsDBNull(reader["codEmpresa"])) oEmpresa.codEmpresa = reader["codEmpresa"] as string;
                if (!Convert.IsDBNull(reader["nbEmpresa"])) oEmpresa.nbEmpresa = reader["nbEmpresa"] as string;
                if (!Convert.IsDBNull(reader["RFCEmpresa"])) oEmpresa.RfcEmpresa = reader["RFCEmpresa"] as string;
                oEmpresa.esActivo = (bool)reader["esActivo"];
                oEmpresa.esSincroniza = (bool)reader["esSincroniza"];

                if (!lstEmpresaDM.Contains(oEmpresa))
                    lstEmpresaDM.Add(oEmpresa);
            }
        }

        public void SetDataTo(IDataParameterCollection pars)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
