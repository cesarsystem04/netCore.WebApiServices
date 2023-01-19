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
	/// Division
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Division : IDataContainer
	{
		#region Properties
		/// </summary>
		[DataMember]
		public string codDivision { get; set; }
		/// </summary>
		[DataMember]
		public string nbDivision { get; set; }
		[DataMember]
		public string codSociedad { get; set; }
		/// </summary>
		[DataMember]
		public string nbSociedad { get; set; }
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		[DataMember]
		public string dsDivision
		{
			get { return string.Format("{0} - {1}", codDivision, nbDivision); }
			set { }
		}
		#endregion Properties

		#region Constructors
		/// <summary>
		/// Constructor de la Clase Division  
		/// </summary>
		public Division()
		{
			this.codDivision = string.Empty;
			this.nbDivision = string.Empty;
			this.codSociedad = string.Empty;
			this.nbSociedad = string.Empty;
			this.esActivo = false;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(Division rhs, Division.DivisionComparer.DivisionTipoComparacion which)
		{
			switch (which)
			{
				case DivisionComparer.DivisionTipoComparacion.codDivision: return this.codDivision.CompareTo(rhs.codDivision);
				case DivisionComparer.DivisionTipoComparacion.nbDivision: return this.nbDivision.CompareTo(rhs.nbDivision);
				case DivisionComparer.DivisionTipoComparacion.esActivo: return this.esActivo.CompareTo(rhs.esActivo);
			}
			return 0;
		}
		public class DivisionComparer : IComparer<Division>
		{
			public enum DivisionTipoComparacion
			{
				codDivision,
				nbDivision,
				esActivo,
				NULL
			}
			private DivisionTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public DivisionTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(Division lhs, Division rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(Division lhs, Division rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(Division e)
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
			if (!Convert.IsDBNull(reader["codDivision"])) this.codDivision = reader["codDivision"] as string;
			if (!Convert.IsDBNull(reader["nbDivision"])) this.nbDivision = reader["nbDivision"] as string;
			if (!Convert.IsDBNull(reader["codSociedad"])) this.codSociedad = reader["codSociedad"] as string;
			if (!Convert.IsDBNull(reader["nbSociedad"])) this.nbSociedad = reader["nbSociedad"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = (bool)reader["esActivo"];
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.codDivision != string.Empty) DataUtil.SetValue(pars, "@codDivision", this.codDivision);
			if (this.codSociedad != string.Empty) DataUtil.SetValue(pars, "@codSociedad", this.codSociedad);
			if (this.nbDivision != string.Empty) DataUtil.SetValue(pars, "@nbDivision", this.nbDivision);
			DataUtil.SetValue(pars, "@esActivo", this.esActivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Division 
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class DivisionList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Division> lstDivision { get; set; }
		#endregion Properties

		#region Constructors
		public DivisionList()
		{
			lstDivision = new List<Division>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstDivision = new List<Division>();
			while (reader.Read())
			{
				Division oDivision = new Division();
				if (!Convert.IsDBNull(reader["codDivision"])) oDivision.codDivision = reader["codDivision"] as string;
				if (!Convert.IsDBNull(reader["codSociedad"])) oDivision.codSociedad = reader["codSociedad"] as string;
				if (!Convert.IsDBNull(reader["nbSociedad"])) oDivision.nbSociedad = reader["nbSociedad"] as string;
				if (!Convert.IsDBNull(reader["nbDivision"])) oDivision.nbDivision = reader["nbDivision"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oDivision.esActivo = (bool)reader["esActivo"];
				this.lstDivision.Add(oDivision);
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
