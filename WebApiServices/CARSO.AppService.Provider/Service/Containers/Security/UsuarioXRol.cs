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
	/// Usuarios Por Rol en el sistema
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class UsuarioXRol : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Identificador del Rol
		/// </summary>
		[DataMember]
		public Int32 codRol { get; set; }
		/// <summary>
		/// Identificador del usuario en el Directorio Activo
		/// </summary>
		[DataMember]
		public string nbAlias { get; set; }
		/// <summary>
		/// Orden
		/// </summary>
		[DataMember]
		public Int32 noOrden { get; set; }
		/// <summary>
		/// Verificador para indicar si el Usuario X Rol es principal
		/// </summary>
		[DataMember]
		public bool esPrincipal { get; set; }
		/// <summary>
		/// Nombre del elemento Rol
		/// </summary>
		[DataMember]
		public string nbdRol { get; set; }
		/// <summary>
		/// Nombre del empleado
		/// </summary>
		[DataMember]
		public string nbEmpleado { get; set; }
		#endregion Properties

		#region Constructors
		/// <summary>
		/// Constructor de la Clase Usuarios del Sistema  
		/// </summary>
		public UsuarioXRol()
		{
			codRol = 0;
			nbAlias = string.Empty;
			noOrden = 0;
			esPrincipal = false;
			nbdRol = string.Empty;
			nbEmpleado = string.Empty;
		}
		#endregion

		#region Compare
		public int CompareTo(UsuarioXRol rhs, UsuarioXRol.UsuarioXRolComparer.UsuarioXRolTipoComparacion which)
		{
			switch (which)
			{
				case UsuarioXRolComparer.UsuarioXRolTipoComparacion.codRol:
					return codRol.CompareTo(rhs.codRol);
				case UsuarioXRolComparer.UsuarioXRolTipoComparacion.nbAlias:
					return nbAlias.CompareTo(rhs.nbAlias);
				case UsuarioXRolComparer.UsuarioXRolTipoComparacion.noOrden:
					return noOrden.CompareTo(rhs.noOrden);
				case UsuarioXRolComparer.UsuarioXRolTipoComparacion.esPrincipal:
					return esPrincipal.CompareTo(rhs.esPrincipal);
				case UsuarioXRolComparer.UsuarioXRolTipoComparacion.nbdRol:
					return nbdRol.CompareTo(rhs.nbdRol);
				case UsuarioXRolComparer.UsuarioXRolTipoComparacion.nbEmpleado:
					return nbEmpleado.CompareTo(rhs.nbEmpleado);
			}
			return 0;
		}
		[DataContract]
		public class UsuarioXRolComparer : IComparer<UsuarioXRol>
		{
			public enum UsuarioXRolTipoComparacion
			{
				codRol,
				nbAlias,
				noOrden,
				esPrincipal,
				nbdRol,
				nbEmpleado,
				NULL
			}
			private UsuarioXRolTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public UsuarioXRolTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(UsuarioXRol lhs, UsuarioXRol rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(UsuarioXRol lhs, UsuarioXRol rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(UsuarioXRol e)
			{
				return e.GetHashCode();
			}

			public TipoOrdenamiento SortDirection
			{
				get { return _sortDirection; }
				set { _sortDirection = value; }
			}
		}
		#endregion compare

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			if (!reader.Read()) return;
			if (!Convert.IsDBNull(reader["codRol"])) codRol = Int32.Parse(reader["codRol"].ToString());
			if (!Convert.IsDBNull(reader["nbAlias"])) nbAlias = reader["nbAlias"] as string;
			if (!Convert.IsDBNull(reader["noOrden"])) noOrden = Int32.Parse(reader["noOrden"].ToString());
			if (!Convert.IsDBNull(reader["esPrincipal"])) esPrincipal = (bool)reader["esPrincipal"];
			if (!Convert.IsDBNull(reader["nbdRol"])) nbdRol = reader["nbdRol"] as string;
			if (!Convert.IsDBNull(reader["nbEmpleado"])) nbEmpleado = reader["nbEmpleado"] as string;
		}
		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>
		public void SetDataTo(IDataParameterCollection pars)
		{
			if (codRol != 0) DataUtil.SetValue(pars, "@codRol", codRol);
			if (nbAlias != string.Empty) DataUtil.SetValue(pars, "@nbAlias", nbAlias);
			if (noOrden != 0) DataUtil.SetValue(pars, "@noOrden", noOrden);
			DataUtil.SetValue(pars, "@esPrincipal", esPrincipal);
			DataUtil.SetReturnedValue(pars, "@return_value");
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Usuario 
	/// </summary>
	[Serializable]
	[DataContract]
	public class UsuarioXRolList : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<UsuarioXRol> lstUsuarioXRol { get; set; }
		#endregion Properties

		#region Constructors
		public UsuarioXRolList()
		{
			lstUsuarioXRol = new List<UsuarioXRol>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstUsuarioXRol = new List<UsuarioXRol>();
			while (reader.Read())
			{
				UsuarioXRol oUsuarioXRol = new UsuarioXRol();
				if (!Convert.IsDBNull(reader["codRol"])) oUsuarioXRol.codRol = Int32.Parse(reader["codRol"].ToString());
				if (!Convert.IsDBNull(reader["nbAlias"])) oUsuarioXRol.nbAlias = reader["nbAlias"] as string;
				if (!Convert.IsDBNull(reader["noOrden"])) oUsuarioXRol.noOrden = Int32.Parse(reader["noOrden"].ToString());
				if (!Convert.IsDBNull(reader["esPrincipal"])) oUsuarioXRol.esPrincipal = (bool)reader["esPrincipal"];
				if (!Convert.IsDBNull(reader["nbdRol"])) oUsuarioXRol.nbdRol = reader["nbdRol"] as string;
				if (!Convert.IsDBNull(reader["nbEmpleado"])) oUsuarioXRol.nbEmpleado = reader["nbEmpleado"] as string;
				lstUsuarioXRol.Add(oUsuarioXRol);
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