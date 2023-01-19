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
    public class Sector : IDataContainer
    {
        #region Attributes
        private string _codSector;
        private string _nbSector;
    
        #endregion

        #region Properties
        /// <summary>
        /// Codigo del elemento Sector
        /// </summary>
        [DataMember]
        public string codSector { get { return _codSector; } set { _codSector = value; } }
        /// <summary>
        /// Nombre del elemento Sector
        /// </summary>
        [DataMember]
        public string nbSector { get { return _nbSector; } set { _nbSector = value; } }
        [DataMember]
        public string dsSector
        {
            get { return string.Format("{0} - {1}", codSector, nbSector); }
            set { }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor de la Clase
        /// </summary>
        public Sector()
        {
            _codSector = string.Empty;
            _nbSector = string.Empty;
           
        }
        #endregion

        #region IDataContainer Members
        public void LoadDataFrom(IDataReader reader)
        {
            if (!reader.Read()) return;
            if (!Convert.IsDBNull(reader["codSector"]))
                codSector = reader["codSector"] as string;
            if (!Convert.IsDBNull(reader["nbSector"]))
                nbSector = reader["nbSector"] as string;
        
        }

        public void SetDataTo(IDataParameterCollection pars)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

    [Serializable]
    [DataContract(IsReference = true)]
    public class SectorList : IDataContainer
    {

        #region Properties
        /// <summary>
        /// Colección con elementos de un catálogo
        /// </summary>
        [DataMember]
        public List<Sector> lstSector { get; set; }
        #endregion Properties

        #region Constructors
        public SectorList()
        {
            lstSector = new List<Sector>();
        }
        #endregion

        public void LoadDataFrom(IDataReader reader)
        {
            lstSector = new List<Sector>();
            while (reader.Read())
            {
                Sector oSector = new Sector();
                oSector.codSector = reader["codSector"] as string;
                oSector.nbSector = reader["nbSector"] as string;

                lstSector.Add(oSector);
            }
        }

        public void SetDataTo(IDataParameterCollection pars)
        {
            throw new NotImplementedException();
        }
    }

}
