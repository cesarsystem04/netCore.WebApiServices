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
	/// AreaDePersonal
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class AreaDePersonal : IDataContainer
	{
		#region Properties
		/// </summary>
		[DataMember]
		public string codGrupoPersonal { get; set; }
		/// </summary>
		[DataMember]
		public string dsGrupoPersonal { get; set; }
		/// </summary>
		[DataMember]
		public string codAreaPersonal { get; set; }
		/// </summary>
		[DataMember]
		public string dsAreaPersonal { get; set; }
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase AreaDePersonal  
		/// </summary>
		public AreaDePersonal()
		{
			this.codGrupoPersonal = string.Empty;
			this.dsGrupoPersonal = string.Empty;
			this.codAreaPersonal = string.Empty;
			this.dsAreaPersonal = string.Empty;
			this.esActivo = false;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(AreaDePersonal rhs, AreaDePersonal.AreaDePersonalComparer.AreaDePersonalTipoComparacion which)
		{
			switch (which)
			{
				case AreaDePersonalComparer.AreaDePersonalTipoComparacion.codGrupoPersonal: return this.codGrupoPersonal.CompareTo(rhs.codGrupoPersonal);
				case AreaDePersonalComparer.AreaDePersonalTipoComparacion.dsGrupoPersonal: return this.dsGrupoPersonal.CompareTo(rhs.dsGrupoPersonal);
				case AreaDePersonalComparer.AreaDePersonalTipoComparacion.codAreaPersonal: return this.codAreaPersonal.CompareTo(rhs.codAreaPersonal);
				case AreaDePersonalComparer.AreaDePersonalTipoComparacion.dsAreaPersonal: return this.dsAreaPersonal.CompareTo(rhs.dsAreaPersonal);
				case AreaDePersonalComparer.AreaDePersonalTipoComparacion.esActivo: return this.esActivo.CompareTo(rhs.esActivo);
			}
			return 0;
		}
		public class AreaDePersonalComparer : IComparer<AreaDePersonal>
		{
			public enum AreaDePersonalTipoComparacion
			{
				codGrupoPersonal,
				dsGrupoPersonal,
				codAreaPersonal,
				dsAreaPersonal,
				esActivo,
				NULL
			}
			private AreaDePersonalTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public AreaDePersonalTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(AreaDePersonal lhs, AreaDePersonal rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(AreaDePersonal lhs, AreaDePersonal rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(AreaDePersonal e)
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
			if (!Convert.IsDBNull(reader["codGrupoPersonal"])) this.codGrupoPersonal = reader["codGrupoPersonal"] as string;
			if (!Convert.IsDBNull(reader["dsGrupoPersonal"])) this.dsGrupoPersonal = reader["dsGrupoPersonal"] as string;
			if (!Convert.IsDBNull(reader["codAreaPersonal"])) this.codAreaPersonal = reader["codAreaPersonal"] as string;
			if (!Convert.IsDBNull(reader["dsAreaPersonal"])) this.dsAreaPersonal = reader["dsAreaPersonal"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = (bool)reader["esActivo"];
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.codGrupoPersonal != string.Empty) DataUtil.SetValue(pars, "@codGrupoPersonal", this.codGrupoPersonal);
			if (this.dsGrupoPersonal != string.Empty) DataUtil.SetValue(pars, "@dsGrupoPersonal", this.dsGrupoPersonal);
			if (this.codAreaPersonal != string.Empty) DataUtil.SetValue(pars, "@codAreaPersonal", this.codAreaPersonal);
			if (this.dsAreaPersonal != string.Empty) DataUtil.SetValue(pars, "@dsAreaPersonal", this.dsAreaPersonal);
			DataUtil.SetValue(pars, "@esActivo", this.esActivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de AreaDePersonal 
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class AreaDePersonalList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<AreaDePersonal> lstAreaDePersonal { get; set; }
		#endregion Properties

		#region Constructors
		public AreaDePersonalList()
		{
			lstAreaDePersonal = new List<AreaDePersonal>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstAreaDePersonal = new List<AreaDePersonal>();
			while (reader.Read())
			{
				AreaDePersonal oAreaDePersonal = new AreaDePersonal();
				if (!Convert.IsDBNull(reader["codGrupoPersonal"])) oAreaDePersonal.codGrupoPersonal = reader["codGrupoPersonal"] as string;
				if (!Convert.IsDBNull(reader["dsGrupoPersonal"])) oAreaDePersonal.dsGrupoPersonal = reader["dsGrupoPersonal"] as string;
				if (!Convert.IsDBNull(reader["codAreaPersonal"])) oAreaDePersonal.codAreaPersonal = reader["codAreaPersonal"] as string;
				if (!Convert.IsDBNull(reader["dsAreaPersonal"])) oAreaDePersonal.dsAreaPersonal = reader["dsAreaPersonal"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oAreaDePersonal.esActivo = (bool)reader["esActivo"];
				this.lstAreaDePersonal.Add(oAreaDePersonal);
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
