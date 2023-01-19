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
	/// Rol del sistema
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Rol : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Código del rol del sistema
		/// </summary>
		[DataMember]
		public Int32 codRol { get; set; }
		/// <summary>
		/// Código de la Aplicación
		/// </summary>
		[DataMember]
		public string codAplicacion { get; set; }
		/// <summary>
		/// Nombre del rol
		/// </summary>
		[DataMember]
		public string nbRol { get; set; }
		/// <summary>
		/// Descripción del rol
		/// </summary>
		[DataMember]
		public string dsRol { get; set; }
		/// <summary>
		/// Verificador para indicar si el rol es activo
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		/// <summary>
		/// Nombre de la Aplicación
		/// </summary>
		[DataMember]
		public string nbdAplicacion { get; set; }
		/// <summary>
		/// Número de usuarios por Rol
		/// </summary>
		[DataMember]
		public Int32 Usuarios { get; set; }
		#endregion Properties
		
		#region Constructors
		/// <summary>
		/// Constructor de la Clase Rol del sistema  
		/// </summary>
		public Rol()
		{
			codRol = 0;
			codAplicacion = string.Empty;
			nbRol = string.Empty;
			dsRol = string.Empty;
			esActivo = false;
			nbdAplicacion = string.Empty;
			Usuarios = 0;
		}
		#endregion Constructors

		#region Compare
	 
		 
		public int CompareTo(Rol rhs, Rol.RolComparer.RolTipoComparacion which)
		{
			switch (which)
			{
				case RolComparer.RolTipoComparacion.codRol: return codRol.CompareTo(rhs.codRol);
				case RolComparer.RolTipoComparacion.codAplicacion: return codAplicacion.CompareTo(rhs.codAplicacion);
				case RolComparer.RolTipoComparacion.nbRol: return nbRol.CompareTo(rhs.nbRol);
				case RolComparer.RolTipoComparacion.esActivo: return esActivo.CompareTo(rhs.esActivo);
				case RolComparer.RolTipoComparacion.nbdAplicacion: return nbdAplicacion.CompareTo(rhs.nbdAplicacion);
				case RolComparer.RolTipoComparacion.Usuarios: return Usuarios.CompareTo(rhs.Usuarios);
			}
			return 0;
		}
		
		public class RolComparer : IComparer<Rol>
		{
			public enum RolTipoComparacion
			{
				codRol,
				codAplicacion,
				nbRol,
				esActivo,
				nbdAplicacion,
				Usuarios,
				NULL
			}
				  
			private RolTipoComparacion _whichComparison;
			 
			private TipoOrdenamiento _sortDirection;
		   
			public RolTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}
				  
			public int Compare(Rol lhs, Rol rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}
				
			public bool Equals(Rol lhs, Rol rhs)
			{
				return Compare(lhs, rhs) == 0;
			}
			
			public int GetHashCode(Rol e)
			{
				return e.GetHashCode();
			}
				  [DataMember]
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
			if (!Convert.IsDBNull(reader["codRol"])) codRol = Int32.Parse(reader["codRol"].ToString());
			if (!Convert.IsDBNull(reader["codAplicacion"])) codAplicacion = reader["codAplicacion"] as string;
			if (!Convert.IsDBNull(reader["nbRol"])) nbRol = reader["nbRol"] as string;
			if (!Convert.IsDBNull(reader["dsRol"])) dsRol = reader["dsRol"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) esActivo = (bool)reader["esActivo"];
			if (!Convert.IsDBNull(reader["nbdAplicacion"])) nbdAplicacion = reader["nbdAplicacion"] as string;
			if (!Convert.IsDBNull(reader["Usuarios"])) Usuarios = Int32.Parse(reader["Usuarios"].ToString());
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (codRol != 0) DataUtil.SetValue(pars, "@codRol", codRol);
			if (codAplicacion != string.Empty) DataUtil.SetValue(pars, "@codAplicacion", codAplicacion);
			if (nbRol != string.Empty) DataUtil.SetValue(pars, "@nbRol", nbRol);
			if (dsRol != string.Empty) DataUtil.SetValue(pars, "@dsRol", dsRol);
			DataUtil.SetValue(pars, "@esActivo", esActivo);
			DataUtil.SetReturnedValue(pars, "@return_value");
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Rol 
	/// </summary>
	[Serializable]
	[DataContract]
	public class RolList : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Rol> lstRol { get; set; }
		#endregion Properties

		#region Constructors
		public RolList()
		{
			lstRol = new List<Rol>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstRol = new List<Rol>();

			while (reader.Read())
			{
				Rol oRol = new Rol();
				if (!Convert.IsDBNull(reader["codRol"])) oRol.codRol = Int32.Parse(reader["codRol"].ToString());
				if (!Convert.IsDBNull(reader["codAplicacion"])) oRol.codAplicacion = reader["codAplicacion"] as string;
				if (!Convert.IsDBNull(reader["nbRol"])) oRol.nbRol = reader["nbRol"] as string;
				if (!Convert.IsDBNull(reader["dsRol"])) oRol.dsRol = reader["dsRol"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oRol.esActivo = (bool)reader["esActivo"];
				if (!Convert.IsDBNull(reader["nbdAplicacion"])) oRol.nbdAplicacion = reader["nbdAplicacion"] as string;
				if (!Convert.IsDBNull(reader["Usuarios"])) oRol.Usuarios = Int32.Parse(reader["Usuarios"].ToString());
				lstRol.Add(oRol);
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