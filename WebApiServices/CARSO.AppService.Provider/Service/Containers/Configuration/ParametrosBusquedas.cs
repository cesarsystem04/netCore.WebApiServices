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
    /// Elementos de Parametros
    /// </summary>
    [Serializable]
    [DataContract(IsReference = true)]
    public class ParametrosBusquedas : IDataContainer
    {
        #region Properties
        [DataMember]
        public int idParametro { get ; set ; }
        [DataMember]
        public string pColumna { get; set; }
        [DataMember]
        public string pColumnaMostrar { get; set; }
        [DataMember]
        public string Extra { get; set; }
        [DataMember]
        public string pCondicion { get; set; }
        [DataMember]
        public string pValor { get; set; }
        [DataMember]
        public string pValorMostrar { get; set; }
        [DataMember]
        public string pRestriccion { get; set; }
        [DataMember]
        public string pRestriccionMostrar { get; set; }
        #endregion Properties

        #region Constructors
        /// <summary>
        /// Constructor de la Clase
        /// </summary>
        public ParametrosBusquedas()
        {
            idParametro = 0;
            pColumna = string.Empty;
            pColumnaMostrar = string.Empty;
            pCondicion = string.Empty;
            pValor = string.Empty;
            pValorMostrar = string.Empty;
            pRestriccion = string.Empty;
            pRestriccionMostrar = string.Empty;
            Extra = string.Empty;
        }
        #endregion

        public void LoadDataFrom(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        public void SetDataTo(IDataParameterCollection pars)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Colección de objetos de tipo Código
    /// </summary>
    [Serializable]
    [DataContract]
    public class ParametrosBusquedasList : IDataContainer
    {
        #region Properties
        /// <summary>
        /// Colección con elementos de un catálogo
        /// </summary>
        [DataMember]
        public List<ParametrosBusquedas> lstParametrosBusqueda { get; set; }
        #endregion Properties

        #region Constructors
        public ParametrosBusquedasList()
        {
            lstParametrosBusqueda = new List<ParametrosBusquedas>();
        }
        #endregion Constructors

        #region Acciones
        /// <summary>
        /// Asigna al objeto los valores al arreglo
        /// </summary>
        public void AddCondicion(ParametrosBusquedas oParametros)
        {
            lstParametrosBusqueda.Add(oParametros);
        }
        #endregion
        /// <summary>
        /// No implementada
        /// </summary>
        /// <param name="reader"></param>
        public void LoadDataFrom(IDataReader reader)
        {
 	        throw new NotImplementedException();
        }
        /// <summary>
        /// No implementada
        /// </summary>
        /// <param name="pars"></param>
        public void SetDataTo(IDataParameterCollection pars)
        {
 	        throw new NotImplementedException();
        }
    }
}

