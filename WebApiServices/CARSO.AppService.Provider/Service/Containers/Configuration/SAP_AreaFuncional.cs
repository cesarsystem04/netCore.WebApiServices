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
	/// AreaFuncional
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class AreaFuncional : IDataContainer
	{
		#region Properties
		/// </summary>
		[DataMember]
		public string codAreaFuncional { get; set; }
		/// </summary>
		[DataMember]
		public string nbAreaFuncional { get; set; }
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase AreaFuncional  
		/// </summary>
		public AreaFuncional()
		{
			this.codAreaFuncional = string.Empty;
			this.nbAreaFuncional = string.Empty;
			this.esActivo = false;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(AreaFuncional rhs, AreaFuncional.AreaFuncionalComparer.AreaFuncionalTipoComparacion which)
		{
			switch (which)
			{
				case AreaFuncionalComparer.AreaFuncionalTipoComparacion.codAreaFuncional: return this.codAreaFuncional.CompareTo(rhs.codAreaFuncional);
				case AreaFuncionalComparer.AreaFuncionalTipoComparacion.nbAreaFuncional: return this.nbAreaFuncional.CompareTo(rhs.nbAreaFuncional);
				case AreaFuncionalComparer.AreaFuncionalTipoComparacion.esActivo: return this.esActivo.CompareTo(rhs.esActivo);
			}
			return 0;
		}
		public class AreaFuncionalComparer : IComparer<AreaFuncional>
		{
			public enum AreaFuncionalTipoComparacion
			{
				codAreaFuncional,
				nbAreaFuncional,
				esActivo,
				NULL
			}
			private AreaFuncionalTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public AreaFuncionalTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(AreaFuncional lhs, AreaFuncional rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(AreaFuncional lhs, AreaFuncional rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(AreaFuncional e)
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
			if (!Convert.IsDBNull(reader["codAreaFuncional"])) this.codAreaFuncional = reader["codAreaFuncional"] as string;
			if (!Convert.IsDBNull(reader["nbAreaFuncional"])) this.nbAreaFuncional = reader["nbAreaFuncional"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = (bool)reader["esActivo"];
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.codAreaFuncional != string.Empty) DataUtil.SetValue(pars, "@codAreaFuncional", this.codAreaFuncional);
			if (this.nbAreaFuncional != string.Empty) DataUtil.SetValue(pars, "@nbAreaFuncional", this.nbAreaFuncional);
			DataUtil.SetValue(pars, "@esActivo", this.esActivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de AreaFuncional 
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class AreaFuncionalList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<AreaFuncional> lstAreaFuncional { get; set; }
		#endregion Properties

		#region Constructors
		public AreaFuncionalList()
		{
			lstAreaFuncional = new List<AreaFuncional>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstAreaFuncional = new List<AreaFuncional>();
			while (reader.Read())
			{
				AreaFuncional oAreaFuncional = new AreaFuncional();
				if (!Convert.IsDBNull(reader["codAreaFuncional"])) oAreaFuncional.codAreaFuncional = reader["codAreaFuncional"] as string;
				if (!Convert.IsDBNull(reader["nbAreaFuncional"])) oAreaFuncional.nbAreaFuncional = reader["nbAreaFuncional"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oAreaFuncional.esActivo = (bool)reader["esActivo"];
				this.lstAreaFuncional.Add(oAreaFuncional);
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
