using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CARSO.AppService.ServiceDataAccess;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.LogLibrary.ServiceDataContainers;
using System.Threading.Tasks;

namespace CARSO.AppService.ServiceDataContainers
{
	/// <summary>
	/// Rol Por Dominio en el sistema
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class RolXDominio : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Propiedad de RolXDominio
		/// </summary>
		[DataMember]
		public Int32 codRol { get; set; }
		/// <summary>
		/// Propiedad de RolXDominio
		/// </summary>
		[DataMember]
		public string cvDominio { get; set; }
		#endregion Properties

		#region Constructors
		/// <summary>
		/// Constructor de la Clase
		/// </summary>
		public RolXDominio()
		{
			codRol = 0;
			cvDominio = string.Empty;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(RolXDominio rhs, RolXDominio.RolXDominioComparer.RolXDominioTipoComparacion which)
		{
			switch (which)
			{
				case RolXDominioComparer.RolXDominioTipoComparacion.codRol: return codRol.CompareTo(rhs.codRol);
				case RolXDominioComparer.RolXDominioTipoComparacion.cvDominio: return cvDominio.CompareTo(rhs.cvDominio);
			}
			return 0;
		}

		public class RolXDominioComparer : IComparer<RolXDominio>
		{
			public enum RolXDominioTipoComparacion
			{
				codRol, cvDominio, NULL
			}

			private RolXDominioTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public RolXDominioTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(RolXDominio lhs, RolXDominio rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(RolXDominio lhs, RolXDominio rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(RolXDominio e)
			{
				return e.GetHashCode();
			}

			public TipoOrdenamiento SortDirection
			{
				get { return _sortDirection; }
				set { _sortDirection = value; }
			}
		}
		#endregion

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			if (!reader.Read()) return; if (!Convert.IsDBNull(reader["codRol"])) codRol = int.Parse(reader["codRol"].ToString());
			if (!Convert.IsDBNull(reader["cvDominio"])) cvDominio = reader["cvDominio"] as string;

		}
		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>
		public void SetDataTo(IDataParameterCollection pars)
		{
			if (codRol != 0) DataUtil.SetValue(pars, "@codRol", codRol);
			if (cvDominio != string.Empty) DataUtil.SetValue(pars, "@cvDominio", cvDominio);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de RolXDominio 
	/// </summary>
	[Serializable]
	[DataContract]
	public class RolXDominioList : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<RolXDominio> lstRolXDominio { get; set; }
		#endregion

		#region Constructors
		public RolXDominioList()
		{
			lstRolXDominio = new List<RolXDominio>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(System.Data.IDataReader reader)
		{
			lstRolXDominio = new List<RolXDominio>();

			while (reader.Read())
			{
				RolXDominio oRolXDominio = new RolXDominio();
				if (!Convert.IsDBNull(reader["codRol"])) oRolXDominio.codRol = int.Parse(reader["codRol"].ToString());
				if (!Convert.IsDBNull(reader["cvDominio"])) oRolXDominio.cvDominio = reader["cvDominio"] as string;
				lstRolXDominio.Add(oRolXDominio);
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