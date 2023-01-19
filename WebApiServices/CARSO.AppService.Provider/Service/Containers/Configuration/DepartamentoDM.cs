using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.LogLibrary.ServiceDataContainers;
using System.Threading.Tasks;

namespace CARSO.AppService.ServiceDataContainers
{
    /// <summary>
    /// Elementos de Empleado
    /// </summary>
    [Serializable]
    [DataContract(IsReference = true)]
    public class DepartamentoDM : IDataContainer
    {
        #region Attributes
        private string _codDepartamento;
        private string _nbDepartamento;
      
        #endregion

        #region Properties
        /// <summary>
        /// Codigo del elemento Departamento
        /// </summary>
        [DataMember]
        public string codDepartamento { get { return _codDepartamento; } set { _codDepartamento = value; } }
        /// <summary>
        /// Nombre del elemento Departamento
        /// </summary>
        [DataMember]
        public string nbDepartamento { get { return _nbDepartamento; } set { _nbDepartamento = value; } }
        /// <summary>
        /// Identificador si el elemento es activo o no
        /// </summary>
       
        /// <summary>
        /// Nombre del elemento Departamento mas el codigo
        /// </summary>
       
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor de la Clase
        /// </summary>
        public DepartamentoDM()
        {
            _codDepartamento = string.Empty;
            _nbDepartamento = string.Empty;
          
        }
        #endregion

        #region IDataContainer Members
        public void LoadDataFrom(IDataReader reader)
        {
            if (!reader.Read()) return;
            if (!Convert.IsDBNull(reader["codDepartamento"]))
                codDepartamento = reader["codDepartamento"] as string;
            if (!Convert.IsDBNull(reader["nbDepartamento"]))
                nbDepartamento = reader["nbDepartamento"] as string;
          
        }

        public void SetDataTo(IDataParameterCollection pars)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

    [Serializable]
    [DataContract(IsReference = true)]
    public class DepartamentoDMList : IDataContainer
    {

        #region Properties
        /// <summary>
        /// Colección con elementos de un catálogo
        /// </summary>
        [DataMember]
        public List<DepartamentoDM> lstDepartamentoDM { get; set; }
        #endregion Properties

        #region Constructors
        public DepartamentoDMList()
        {
            lstDepartamentoDM = new List<DepartamentoDM>();
        }
        #endregion

        public void LoadDataFrom(IDataReader reader)
        {
            lstDepartamentoDM = new List<DepartamentoDM>();
            while (reader.Read())
            {
                DepartamentoDM oDepartamento = new DepartamentoDM();
                oDepartamento.codDepartamento = reader["codDepartamento"] as string;
                oDepartamento.nbDepartamento = reader["nbDepartamento"] as string;

                lstDepartamentoDM.Add(oDepartamento);
            }
        }

        public void SetDataTo(IDataParameterCollection pars)
        {
            throw new NotImplementedException();
        }
    }

}
