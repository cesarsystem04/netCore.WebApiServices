using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.LogLibrary.ServiceDataContainers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;

namespace CARSO.AppService.ServiceDataContainers
{
    /// <summary>
    /// Tipo de Contrato en SAP
    /// </summary>
    [Serializable]
    [DataContract(IsReference = true)]
    public class TipoContrato : IDataContainer
    {
        #region Properties
        /// <summary>
        /// Código del Tipo de Contrato en SAP
        /// </summary>
        [DataMember]
        public string codTipoContrato { get; set; }
        /// <summary>
        /// Nombre del Tipo de Contrato en SAP
        /// </summary>
        [DataMember]
        public string nbTipoContrato { get; set; }
        /// <summary>
        /// Indica si es activo o No
        /// </summary>
        [DataMember]
        public bool esActivo { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor de la Clase
        /// </summary>
        public TipoContrato()
        {
            this.codTipoContrato = string.Empty;
            this.nbTipoContrato = string.Empty;
            this.esActivo = false;
        }
        #endregion

        #region IDataContainer Members
        /// <summary>
        /// Asigna los valores de la base de datos
        /// </summary>
        /// <param name="reader">Resultado de la consulta en base de datos</param>
        public void LoadDataFrom(IDataReader reader)
        {
            if (!reader.Read()) return;
            if (!Convert.IsDBNull(reader["codTipoContrato"])) this.codTipoContrato = reader["codTipoContrato"] as string;
            if (!Convert.IsDBNull(reader["nbTipoContrato"])) this.nbTipoContrato = reader["nbTipoContrato"] as string;
            if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = (bool)reader["esActivo"];
        }

        /// <summary>
        /// Asigna los valores del objeto a los parámetros del stored procedure
        /// </summary>
        /// <param name="pars">Colección de parámetros</param>
        public void SetDataTo(IDataParameterCollection pars)
        {
            if (this.codTipoContrato != string.Empty) DataUtil.SetValue(pars, "@codTipoContrato", this.codTipoContrato);
            if (this.nbTipoContrato != string.Empty) DataUtil.SetValue(pars, "@nbTipoContrato", this.nbTipoContrato);
            DataUtil.SetValue(pars, "@esActivo", this.esActivo);
        }
        #endregion

        #region Equals & GetHashCode
        /// <summary>
        /// Indica si los objetos a comparar son iguales
        /// </summary>
        /// <param name="obj">objeto a comparar</param>
        /// <returns>true si es igual y false en caso contrario</returns>
        public override bool Equals(object obj)
        {
            bool esIgual = false;

            esIgual = obj != null && obj is TipoContrato;

            if (!esIgual) return esIgual;

            TipoContrato that = obj as TipoContrato;

            esIgual = this.codTipoContrato == that.codTipoContrato &&
                this.nbTipoContrato == that.nbTipoContrato &&
                this.esActivo == that.esActivo;

            return esIgual;
        }

        /// <summary>
        /// Devuelve el hashcode del objeto
        /// </summary>
        /// <returns>un valor entero equivalente al hashcode</returns>
        public override int GetHashCode()
        {
            return this.codTipoContrato.GetHashCode();
        }
        #endregion
    }

    /// <summary>
    /// Coleccion de tipos de contrato
    /// </summary>
    [Serializable]
    [DataContract(IsReference = true)]
    public class TipoContratoList : IDataContainer
    {
        #region Properties
        /// <summary>
        /// Lista de Tipos de Contrato
        /// </summary>
        [DataMember]
        public List<TipoContrato> lstTipoContrato { get; set; }
        #endregion

        #region Constructor
        public TipoContratoList()
        {
            this.lstTipoContrato = new List<TipoContrato>();
        }
        #endregion

        #region IDataContainer Members
        /// <summary>
        /// Asigna al objeto los valores de la base de datos
        /// </summary>
        /// <param name="reader">Resultado de la consulta de la base de datos</param>
        public void LoadDataFrom(IDataReader reader)
        {
            this.lstTipoContrato = new List<TipoContrato>();
            while (reader.Read())
            {
                TipoContrato oTipoContrato = new TipoContrato();
                if (!Convert.IsDBNull(reader["codTipoContrato"])) oTipoContrato.codTipoContrato = reader["codTipoContrato"] as string;
                if (!Convert.IsDBNull(reader["nbTipoContrato"])) oTipoContrato.nbTipoContrato = reader["nbTipoContrato"] as string;
                if (!Convert.IsDBNull(reader["esActivo"])) oTipoContrato.esActivo = (bool)reader["esActivo"];
                this.lstTipoContrato.Add(oTipoContrato);
            }
        }

        /// <summary>
        /// Asigna los valores del objeto a los parámetros del stored procedure
        /// </summary>
        /// <param name="pars">Colección de parámetros</param>
        public void SetDataTo(IDataParameterCollection pars) { }
        #endregion
    }
}
