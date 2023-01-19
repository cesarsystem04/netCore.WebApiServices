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
	/// Pais
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Pais : IDataContainer
	{
		#region Properties
		/// </summary>
		[DataMember]
		public string codPais { get; set; }
		/// </summary>
		[DataMember]
		public string nbPais { get; set; }
		/// </summary>
		[DataMember]
		public string nbNacionalidad { get; set; }
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase Pais  
		/// </summary>
		public Pais()
		{
			this.codPais = string.Empty;
			this.nbPais = string.Empty;
			this.nbNacionalidad = string.Empty;
			this.esActivo = false;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(Pais rhs, Pais.PaisComparer.PaisTipoComparacion which)
		{
			switch (which)
			{
				case PaisComparer.PaisTipoComparacion.codPais: return this.codPais.CompareTo(rhs.codPais);
				case PaisComparer.PaisTipoComparacion.nbPais: return this.nbPais.CompareTo(rhs.nbPais);
				case PaisComparer.PaisTipoComparacion.nbNacionalidad: return this.nbNacionalidad.CompareTo(rhs.nbNacionalidad);
				case PaisComparer.PaisTipoComparacion.esActivo: return this.esActivo.CompareTo(rhs.esActivo);
			}
			return 0;
		}
		public class PaisComparer : IComparer<Pais>
		{
			public enum PaisTipoComparacion
			{
				codPais,
				nbPais,
				nbNacionalidad,
				esActivo,
				NULL
			}
			private PaisTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public PaisTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(Pais lhs, Pais rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(Pais lhs, Pais rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(Pais e)
			{
				return e.GetHashCode();
			}

			public TipoOrdenamiento SortDirection
			{
				get { return _sortDirection; }
				set { _sortDirection = value; }
			}
		}
		#endregion Compare

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			if (!reader.Read()) return;
			if (!Convert.IsDBNull(reader["codPais"])) this.codPais = reader["codPais"] as string;
			if (!Convert.IsDBNull(reader["nbPais"])) this.nbPais = reader["nbPais"] as string;
			if (!Convert.IsDBNull(reader["nbNacionalidad"])) this.nbNacionalidad = reader["nbNacionalidad"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = (bool)reader["esActivo"];
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.codPais != string.Empty) DataUtil.SetValue(pars, "@codPais", this.codPais);
			if (this.nbPais != string.Empty) DataUtil.SetValue(pars, "@nbPais", this.nbPais);
			if (this.nbNacionalidad != string.Empty) DataUtil.SetValue(pars, "@nbNacionalidad", this.nbNacionalidad);
			DataUtil.SetValue(pars, "@esActivo", this.esActivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Pais 
	/// </summary>
	[Serializable]
	[DataContract]
	public class PaisList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Pais> lstPais { get; set; }
		#endregion Properties

		#region Constructors
		public PaisList()
		{
			lstPais = new List<Pais>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstPais = new List<Pais>();
			while (reader.Read())
			{
				Pais oPais = new Pais();
				if (!Convert.IsDBNull(reader["codPais"])) oPais.codPais = reader["codPais"] as string;
				if (!Convert.IsDBNull(reader["nbPais"])) oPais.nbPais = reader["nbPais"] as string;
				if (!Convert.IsDBNull(reader["nbNacionalidad"])) oPais.nbNacionalidad = reader["nbNacionalidad"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oPais.esActivo = (bool)reader["esActivo"];
				this.lstPais.Add(oPais);
			}
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>
		public void SetDataTo(System.Data.IDataParameterCollection pars) { }
		#endregion IDataContainer Members
	}
}
