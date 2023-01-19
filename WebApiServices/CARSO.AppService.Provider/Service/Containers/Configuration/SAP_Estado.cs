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
	/// Estado
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Estado : IDataContainer
	{
		#region Properties
		/// </summary>
		[DataMember]
		public string codEstado { get; set; }
		/// </summary>
		[DataMember]
		public string nbEstado { get; set; }
		/// </summary>
		[DataMember]
		public string codMunicipio { get; set; }
		/// </summary>
		[DataMember]
		public string nbMunicipio { get; set; }
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase Estado  
		/// </summary>
		public Estado()
		{
			this.codEstado = string.Empty;
			this.nbEstado = string.Empty;
			this.codMunicipio = string.Empty;
			this.nbMunicipio = string.Empty;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(Estado rhs, Estado.EstadoComparer.EstadoTipoComparacion which)
		{
			switch (which)
			{
				case EstadoComparer.EstadoTipoComparacion.codEstado: return this.codEstado.CompareTo(rhs.codEstado);
				case EstadoComparer.EstadoTipoComparacion.nbEstado: return this.nbEstado.CompareTo(rhs.nbEstado);
				case EstadoComparer.EstadoTipoComparacion.codMunicipio: return this.codMunicipio.CompareTo(rhs.codMunicipio);
				case EstadoComparer.EstadoTipoComparacion.nbMunicipio: return this.nbMunicipio.CompareTo(rhs.nbMunicipio);
			}
			return 0;
		}
		public class EstadoComparer : IComparer<Estado>
		{
			public enum EstadoTipoComparacion
			{
				codEstado,
				nbEstado,
				codMunicipio,
				nbMunicipio,
				NULL
			}
			private EstadoTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public EstadoTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(Estado lhs, Estado rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(Estado lhs, Estado rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(Estado e)
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
			if (!Convert.IsDBNull(reader["codEstado"])) this.codEstado = reader["codEstado"] as string;
			if (!Convert.IsDBNull(reader["nbEstado"])) this.nbEstado = reader["nbEstado"] as string;
			if (!Convert.IsDBNull(reader["codMunicipio"])) this.codMunicipio = reader["codMunicipio"] as string;
			if (!Convert.IsDBNull(reader["nbMunicipio"])) this.nbMunicipio = reader["nbMunicipio"] as string;
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.codEstado != string.Empty) DataUtil.SetValue(pars, "@codEstado", this.codEstado);
			if (this.nbEstado != string.Empty) DataUtil.SetValue(pars, "@nbEstado", this.nbEstado);
			if (this.codMunicipio != string.Empty) DataUtil.SetValue(pars, "@codMunicipio", this.codMunicipio);
			if (this.nbMunicipio != string.Empty) DataUtil.SetValue(pars, "@nbMunicipio", this.nbMunicipio);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Estado 
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class EstadoList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Estado> lstEstado { get; set; }
		#endregion Properties

		#region Constructors
		public EstadoList()
		{
			lstEstado = new List<Estado>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstEstado = new List<Estado>();
				while (reader.Read())
			{
				Estado oEstado = new Estado();
				if (!Convert.IsDBNull(reader["codEstado"])) oEstado.codEstado = reader["codEstado"] as string;
				if (!Convert.IsDBNull(reader["nbEstado"])) oEstado.nbEstado = reader["nbEstado"] as string;
				if (!Convert.IsDBNull(reader["codMunicipio"])) oEstado.codMunicipio = reader["codMunicipio"] as string;
				if (!Convert.IsDBNull(reader["nbMunicipio"])) oEstado.nbMunicipio = reader["nbMunicipio"] as string;
				this.lstEstado.Add(oEstado);
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
