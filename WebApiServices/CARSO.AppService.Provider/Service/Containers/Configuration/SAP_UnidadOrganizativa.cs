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
	/// UnidadOrganizativa
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class UnidadOrganizativa : IDataContainer
	{
		#region Properties
		/// </summary>
		[DataMember]
		public string codUnidad { get; set; }
		/// </summary>
		[DataMember]
		public string nbUnidad { get; set; }
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		[DataMember]
		public string dsUnidad
		{
			get { return string.Format("{0} - {1}", codUnidad, nbUnidad); }
			set { }
		}
		#endregion Properties

		#region Constructors
		/// <summary>
		/// Constructor de la Clase UnidadOrganizativa  
		/// </summary>
		public UnidadOrganizativa()
		{
			this.codUnidad = string.Empty;
			this.nbUnidad = string.Empty;
			this.esActivo = false;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(UnidadOrganizativa rhs, UnidadOrganizativa.UnidadOrganizativaComparer.UnidadOrganizativaTipoComparacion which)
		{
			switch (which)
			{
				case UnidadOrganizativaComparer.UnidadOrganizativaTipoComparacion.codUnidad: return this.codUnidad.CompareTo(rhs.codUnidad);
				case UnidadOrganizativaComparer.UnidadOrganizativaTipoComparacion.nbUnidad: return this.nbUnidad.CompareTo(rhs.nbUnidad);
				case UnidadOrganizativaComparer.UnidadOrganizativaTipoComparacion.esActivo: return this.esActivo.CompareTo(rhs.esActivo);
			}
			return 0;
		}
		public class UnidadOrganizativaComparer : IComparer<UnidadOrganizativa>
		{
			public enum UnidadOrganizativaTipoComparacion
			{
				codUnidad,
				nbUnidad,
				esActivo,
				NULL
			}
			private UnidadOrganizativaTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public UnidadOrganizativaTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(UnidadOrganizativa lhs, UnidadOrganizativa rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(UnidadOrganizativa lhs, UnidadOrganizativa rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(UnidadOrganizativa e)
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
			if (!Convert.IsDBNull(reader["codUnidad"])) this.codUnidad = reader["codUnidad"] as string;
			if (!Convert.IsDBNull(reader["nbUnidad"])) this.nbUnidad = reader["nbUnidad"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = (bool)reader["esActivo"];
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.codUnidad != string.Empty) DataUtil.SetValue(pars, "@codUnidad", this.codUnidad);
			if (this.nbUnidad != string.Empty) DataUtil.SetValue(pars, "@nbUnidad", this.nbUnidad);
			DataUtil.SetValue(pars, "@esActivo", this.esActivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de UnidadOrganizativa 
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class UnidadOrganizativaList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<UnidadOrganizativa> lstUnidadOrganizativa { get; set; }
		#endregion Properties

		#region Constructors
		public UnidadOrganizativaList()
		{
			lstUnidadOrganizativa = new List<UnidadOrganizativa>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstUnidadOrganizativa = new List<UnidadOrganizativa>();
			while (reader.Read())
			{
				UnidadOrganizativa oUnidadOrganizativa = new UnidadOrganizativa();
				if (!Convert.IsDBNull(reader["codUnidad"])) oUnidadOrganizativa.codUnidad = reader["codUnidad"] as string;
				if (!Convert.IsDBNull(reader["nbUnidad"])) oUnidadOrganizativa.nbUnidad = reader["nbUnidad"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oUnidadOrganizativa.esActivo = (bool)reader["esActivo"];
				this.lstUnidadOrganizativa.Add(oUnidadOrganizativa);
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
