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
	/// EstadoCivil
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class EstadoCivil : IDataContainer
	{
		#region Properties
		/// </summary>
		[DataMember]
		public string codEstadoCivil { get; set; }
		/// </summary>
		[DataMember]
		public string nbEstadoCivil { get; set; }
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase EstadoCivil  
		/// </summary>
		public EstadoCivil()
		{
			this.codEstadoCivil = string.Empty;
			this.nbEstadoCivil = string.Empty;
			this.esActivo = false;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(EstadoCivil rhs, EstadoCivil.EstadoCivilComparer.EstadoCivilTipoComparacion which)
		{
			switch (which)
			{
				case EstadoCivilComparer.EstadoCivilTipoComparacion.codEstadoCivil: return this.codEstadoCivil.CompareTo(rhs.codEstadoCivil);
				case EstadoCivilComparer.EstadoCivilTipoComparacion.nbEstadoCivil: return this.nbEstadoCivil.CompareTo(rhs.nbEstadoCivil);
				case EstadoCivilComparer.EstadoCivilTipoComparacion.esActivo: return this.esActivo.CompareTo(rhs.esActivo);
			}
			return 0;
		}
		public class EstadoCivilComparer : IComparer<EstadoCivil>
		{
			public enum EstadoCivilTipoComparacion
			{
				codEstadoCivil,
				nbEstadoCivil,
				esActivo,
				NULL
			}
			private EstadoCivilTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public EstadoCivilTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(EstadoCivil lhs, EstadoCivil rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(EstadoCivil lhs, EstadoCivil rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(EstadoCivil e)
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
			if (!Convert.IsDBNull(reader["codEstadoCivil"])) this.codEstadoCivil = reader["codEstadoCivil"] as string;
			if (!Convert.IsDBNull(reader["nbEstadoCivil"])) this.nbEstadoCivil = reader["nbEstadoCivil"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = (bool)reader["esActivo"];
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.codEstadoCivil != string.Empty) DataUtil.SetValue(pars, "@codEstadoCivil", this.codEstadoCivil);
			if (this.nbEstadoCivil != string.Empty) DataUtil.SetValue(pars, "@nbEstadoCivil", this.nbEstadoCivil);
			DataUtil.SetValue(pars, "@esActivo", this.esActivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de EstadoCivil 
	/// </summary>
	[Serializable]
	[DataContract]
	public class EstadoCivilList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<EstadoCivil> lstEstadoCivil { get; set; }
		#endregion Properties

		#region Constructors
		public EstadoCivilList()
		{
			lstEstadoCivil = new List<EstadoCivil>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstEstadoCivil = new List<EstadoCivil>();
			while (reader.Read())
			{
				EstadoCivil oEstadoCivil = new EstadoCivil();
				if (!Convert.IsDBNull(reader["codEstadoCivil"])) oEstadoCivil.codEstadoCivil = reader["codEstadoCivil"] as string;
				if (!Convert.IsDBNull(reader["nbEstadoCivil"])) oEstadoCivil.nbEstadoCivil = reader["nbEstadoCivil"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oEstadoCivil.esActivo = (bool)reader["esActivo"];
				this.lstEstadoCivil.Add(oEstadoCivil);
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