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
	/// AreaNomina
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class AreaNomina : IDataContainer
	{
		#region Properties
		/// </summary>
		[DataMember]
		public string codAreaNomina { get; set; }
		/// </summary>
		[DataMember]
		public string nbAreaNomina { get; set; }
		/// </summary>
		[DataMember]
		public string nbParametro { get; set; }
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase AreaNomina  
		/// </summary>
		public AreaNomina()
		{
			this.codAreaNomina = string.Empty;
			this.nbAreaNomina = string.Empty;
			this.nbParametro = string.Empty;
			this.esActivo = false;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(AreaNomina rhs, AreaNomina.AreaNominaComparer.AreaNominaTipoComparacion which)
		{
			switch (which)
			{
				case AreaNominaComparer.AreaNominaTipoComparacion.codAreaNomina: return this.codAreaNomina.CompareTo(rhs.codAreaNomina);
				case AreaNominaComparer.AreaNominaTipoComparacion.nbAreaNomina: return this.nbAreaNomina.CompareTo(rhs.nbAreaNomina);
				case AreaNominaComparer.AreaNominaTipoComparacion.nbParametro: return this.nbParametro.CompareTo(rhs.nbParametro);
				case AreaNominaComparer.AreaNominaTipoComparacion.esActivo: return this.esActivo.CompareTo(rhs.esActivo);
			}
			return 0;
		}
		public class AreaNominaComparer : IComparer<AreaNomina>
		{
			public enum AreaNominaTipoComparacion
			{
				codAreaNomina,
				nbAreaNomina,
				nbParametro,
				esActivo,
				NULL
			}
			private AreaNominaTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public AreaNominaTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(AreaNomina lhs, AreaNomina rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(AreaNomina lhs, AreaNomina rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(AreaNomina e)
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
			if (!Convert.IsDBNull(reader["codAreaNomina"])) this.codAreaNomina = reader["codAreaNomina"] as string;
			if (!Convert.IsDBNull(reader["nbAreaNomina"])) this.nbAreaNomina = reader["nbAreaNomina"] as string;
			if (!Convert.IsDBNull(reader["nbParametro"])) this.nbParametro = reader["nbParametro"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = (bool)reader["esActivo"];
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.codAreaNomina != string.Empty) DataUtil.SetValue(pars, "@codAreaNomina", this.codAreaNomina);
			if (this.nbAreaNomina != string.Empty) DataUtil.SetValue(pars, "@nbAreaNomina", this.nbAreaNomina);
			if (this.nbParametro != string.Empty) DataUtil.SetValue(pars, "@nbParametro", this.nbParametro);
			DataUtil.SetValue(pars, "@esActivo", this.esActivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de AreaNomina 
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class AreaNominaList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<AreaNomina> lstAreaNomina { get; set; }
		#endregion Properties

		#region Constructors
		public AreaNominaList()
		{
			lstAreaNomina = new List<AreaNomina>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstAreaNomina = new List<AreaNomina>();
			while (reader.Read())
			{
				AreaNomina oAreaNomina = new AreaNomina();
				if (!Convert.IsDBNull(reader["codAreaNomina"])) oAreaNomina.codAreaNomina = reader["codAreaNomina"] as string;
				if (!Convert.IsDBNull(reader["nbAreaNomina"])) oAreaNomina.nbAreaNomina = reader["nbAreaNomina"] as string;
				if (!Convert.IsDBNull(reader["nbParametro"])) oAreaNomina.nbParametro = reader["nbParametro"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oAreaNomina.esActivo = (bool)reader["esActivo"];
				this.lstAreaNomina.Add(oAreaNomina);
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
