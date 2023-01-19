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
	/// Catálogo de Jerarquias
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Jerarquia : IDataContainer
	{
		#region Properties
		/// </summary>
		[DataMember]
		public string codJerarquia { get; set; }
		/// </summary>
		[DataMember]
		public string nbJerarquia { get; set; }
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase Catálogo de Jerarquias  
		/// </summary>
		public Jerarquia()
		{
			this.codJerarquia = string.Empty;
			this.nbJerarquia = string.Empty;
			this.esActivo = false;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(Jerarquia rhs, Jerarquia.JerarquiaComparer.JerarquiaTipoComparacion which)
		{
			switch (which)
			{
				case JerarquiaComparer.JerarquiaTipoComparacion.codJerarquia: return this.codJerarquia.CompareTo(rhs.codJerarquia);
				case JerarquiaComparer.JerarquiaTipoComparacion.nbJerarquia: return this.nbJerarquia.CompareTo(rhs.nbJerarquia);
				case JerarquiaComparer.JerarquiaTipoComparacion.esActivo: return this.esActivo.CompareTo(rhs.esActivo);
			}
			return 0;
		}
		public class JerarquiaComparer : IComparer<Jerarquia>
		{
			public enum JerarquiaTipoComparacion
			{
				codJerarquia,
				nbJerarquia,
				esActivo,
				NULL
			}
			private JerarquiaTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public JerarquiaTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(Jerarquia lhs, Jerarquia rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(Jerarquia lhs, Jerarquia rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(Jerarquia e)
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
			if (!Convert.IsDBNull(reader["codJerarquia"])) this.codJerarquia = reader["codJerarquia"] as string;
			if (!Convert.IsDBNull(reader["nbJerarquia"])) this.nbJerarquia = reader["nbJerarquia"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = (bool)reader["esActivo"];
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.codJerarquia != string.Empty) DataUtil.SetValue(pars, "@codJerarquia", this.codJerarquia);
			if (this.nbJerarquia != string.Empty) DataUtil.SetValue(pars, "@nbJerarquia", this.nbJerarquia);
			DataUtil.SetValue(pars, "@esActivo", this.esActivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Jerarquia 
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class JerarquiaList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Jerarquia> lstJerarquia { get; set; }
		#endregion Properties

		#region Constructors
		public JerarquiaList()
		{
			lstJerarquia = new List<Jerarquia>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstJerarquia = new List<Jerarquia>();
			while (reader.Read())
			{
				Jerarquia oJerarquia = new Jerarquia();
				if (!Convert.IsDBNull(reader["codJerarquia"])) oJerarquia.codJerarquia = reader["codJerarquia"] as string;
				if (!Convert.IsDBNull(reader["nbJerarquia"])) oJerarquia.nbJerarquia = reader["nbJerarquia"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oJerarquia.esActivo = (bool)reader["esActivo"];
				this.lstJerarquia.Add(oJerarquia);
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
