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
	/// SubDivision
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class SubDivision : IDataContainer
	{
		#region Properties
		/// </summary>
		[DataMember]
		public string codSubdivision { get; set; }
		/// </summary>
		[DataMember]
		public string codDivision { get; set; }
		/// </summary>
		[DataMember]
		public string nbSubDivision { get; set; }
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		[DataMember]
		public string dsSubdivision
		{
			get { return string.Format("{0} - {1}", codSubdivision, nbSubDivision); }
			set { }
		}
		#endregion Properties

		#region Constructors
		/// <summary>
		/// Constructor de la Clase SubDivision  
		/// </summary>
		public SubDivision()
		{
			this.codSubdivision = string.Empty;
			this.codDivision = string.Empty;
			this.nbSubDivision = string.Empty;
			this.esActivo = false;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(SubDivision rhs, SubDivision.SubDivisionComparer.SubDivisionTipoComparacion which)
		{
			switch (which)
			{
				case SubDivisionComparer.SubDivisionTipoComparacion.codSubdivision: return this.codSubdivision.CompareTo(rhs.codSubdivision);
				case SubDivisionComparer.SubDivisionTipoComparacion.codDivision: return this.codDivision.CompareTo(rhs.codDivision);
				case SubDivisionComparer.SubDivisionTipoComparacion.nbSubDivision: return this.nbSubDivision.CompareTo(rhs.nbSubDivision);
				case SubDivisionComparer.SubDivisionTipoComparacion.esActivo: return this.esActivo.CompareTo(rhs.esActivo);
			}
			return 0;
		}
		public class SubDivisionComparer : IComparer<SubDivision>
		{
			public enum SubDivisionTipoComparacion
			{
				codSubdivision,
				codDivision,
				nbSubDivision,
				esActivo,
				NULL
			}
			private SubDivisionTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public SubDivisionTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(SubDivision lhs, SubDivision rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(SubDivision lhs, SubDivision rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(SubDivision e)
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
			if (!Convert.IsDBNull(reader["codSubdivision"])) this.codSubdivision = reader["codSubdivision"] as string;
			if (!Convert.IsDBNull(reader["codDivision"])) this.codDivision = reader["codDivision"] as string;
			if (!Convert.IsDBNull(reader["nbSubDivision"])) this.nbSubDivision = reader["nbSubDivision"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = (bool)reader["esActivo"];
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.codSubdivision != string.Empty) DataUtil.SetValue(pars, "@codSubdivision", this.codSubdivision);
			if (this.codDivision != string.Empty) DataUtil.SetValue(pars, "@codDivision", this.codDivision);
			if (this.nbSubDivision != string.Empty) DataUtil.SetValue(pars, "@nbSubDivision", this.nbSubDivision);
			DataUtil.SetValue(pars, "@esActivo", this.esActivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de SubDivision 
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class SubDivisionList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<SubDivision> lstSubDivision { get; set; }
		#endregion Properties

		#region Constructors
		public SubDivisionList()
		{
			lstSubDivision = new List<SubDivision>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstSubDivision = new List<SubDivision>();
			while (reader.Read())
			{
				SubDivision oSubDivision = new SubDivision();
				if (!Convert.IsDBNull(reader["codSubdivision"])) oSubDivision.codSubdivision = reader["codSubdivision"] as string;
				if (!Convert.IsDBNull(reader["codDivision"])) oSubDivision.codDivision = reader["codDivision"] as string;
				if (!Convert.IsDBNull(reader["nbSubDivision"])) oSubDivision.nbSubDivision = reader["nbSubDivision"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oSubDivision.esActivo = (bool)reader["esActivo"];
				this.lstSubDivision.Add(oSubDivision);
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
