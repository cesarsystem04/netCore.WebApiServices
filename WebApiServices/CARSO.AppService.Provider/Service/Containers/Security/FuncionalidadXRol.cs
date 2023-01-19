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
	/// Funcionalidad por Rol
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class FuncionalidadXRol : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Codigo del Rol
		/// </summary>
		[DataMember]
		public Int32 codRol { get; set; }
		/// <summary>
		/// Identificador de la Funcionalidad
		/// </summary>
		[DataMember]
		public Int32 idFuncionalidad { get; set; }
		/// <summary>
		/// Clave del Dominio
		/// </summary>
		[DataMember]
		public string cvDominio { get; set; }
		/// <summary>
		/// Verificador para indicar si al Rol se le permite Consultar
		/// </summary>
		[DataMember]
		public bool esConsultar { get; set; }
		/// <summary>
		/// Verificador para indicar si al Rol se le permite Actualizar
		/// </summary>
		[DataMember]
		public bool esActualizar { get; set; }
		/// <summary>
		/// Verificador para indicar si al Rol se le permite Agregar registros
		/// </summary>
		[DataMember]
		public bool esAgregar { get; set; }
		/// <summary>
		/// Verificador para indicar si al Rol se le permite Imprimir
		/// </summary>
		[DataMember]
		public bool esImprimir { get; set; }
		/// <summary>
		/// Tiene permitido ejecutar operaciones especiales
		/// </summary>
		[DataMember]
		public bool esEspecial { get; set; }
		[DataMember]
		public string nbFuncionalidad { get; set; }
		[DataMember]
		public string nbdRol { get; set; }
		[DataMember]
		public string nbDominio { get; set; }
		#endregion Properties

		#region Constructors
		/// <summary>
		/// Constructor de la Clase Funcionalidad por Rol  
		/// </summary>
		public FuncionalidadXRol()
		{
			codRol = 0;
			idFuncionalidad = 0;
			cvDominio = string.Empty;
			esConsultar = false;
			esActualizar = false;
			esAgregar = false;
			esImprimir = false;
			esEspecial = false;
			nbFuncionalidad = string.Empty;
			nbdRol = string.Empty;
			nbDominio = string.Empty;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(FuncionalidadXRol rhs, FuncionalidadXRol.FuncionalidadXRolComparer.FuncionalidadXRolTipoComparacion which)
		{
			switch (which)
			{
			}
			return 0;
		}
		public class FuncionalidadXRolComparer : IComparer<FuncionalidadXRol>
		{
			public enum FuncionalidadXRolTipoComparacion
			{
				NULL
			}
			private FuncionalidadXRolTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public FuncionalidadXRolTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(FuncionalidadXRol lhs, FuncionalidadXRol rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(FuncionalidadXRol lhs, FuncionalidadXRol rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(FuncionalidadXRol e)
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
			if (!Convert.IsDBNull(reader["codRol"])) codRol = Int32.Parse(reader["codRol"].ToString());
			if (!Convert.IsDBNull(reader["idFuncionalidad"])) idFuncionalidad = Int32.Parse(reader["idFuncionalidad"].ToString());
			if (!Convert.IsDBNull(reader["cvDominio"])) cvDominio = reader["cvDominio"] as string;
			if (!Convert.IsDBNull(reader["esConsultar"])) esConsultar = (bool)reader["esConsultar"];
			if (!Convert.IsDBNull(reader["esActualizar"])) esActualizar = (bool)reader["esActualizar"];
			if (!Convert.IsDBNull(reader["esAgregar"])) esAgregar = (bool)reader["esAgregar"];
			if (!Convert.IsDBNull(reader["esImprimir"])) esImprimir = (bool)reader["esImprimir"];
			if (!Convert.IsDBNull(reader["esEspecial"])) esEspecial = (bool)reader["esEspecial"];
			if (!Convert.IsDBNull(reader["nbFuncionalidad"])) nbFuncionalidad = reader["nbFuncionalidad"] as string;
			if (!Convert.IsDBNull(reader["nbdRol"])) nbdRol = reader["nbdRol"] as string;
			if (!Convert.IsDBNull(reader["nbDominio"])) nbDominio = reader["nbDominio"] as string;
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (codRol != 0) DataUtil.SetValue(pars, "@codRol", codRol);
			if (idFuncionalidad != 0) DataUtil.SetValue(pars, "@idFuncionalidad", idFuncionalidad);
			if (cvDominio != string.Empty) DataUtil.SetValue(pars, "@cvDominio", cvDominio);
			DataUtil.SetValue(pars, "@esConsultar", esConsultar);
			DataUtil.SetValue(pars, "@esActualizar", esActualizar);
			DataUtil.SetValue(pars, "@esAgregar", esAgregar);
			DataUtil.SetValue(pars, "@esImprimir", esImprimir);
			DataUtil.SetValue(pars, "@esEspecial", esEspecial);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de FuncionalidadXRol 
	/// </summary>
	[Serializable]
	[DataContract]
	public class FuncionalidadXRolList : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<FuncionalidadXRol> lstFuncionalidadXRol { get; set; }
		#endregion Properties

		#region Constructors
		public FuncionalidadXRolList()
		{
			lstFuncionalidadXRol = new List<FuncionalidadXRol>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			while (reader.Read())
			{
				FuncionalidadXRol oFuncionalidadXRol = new FuncionalidadXRol();
				if (!Convert.IsDBNull(reader["codRol"])) oFuncionalidadXRol.codRol = Int32.Parse(reader["codRol"].ToString());
				if (!Convert.IsDBNull(reader["idFuncionalidad"])) oFuncionalidadXRol.idFuncionalidad = Int32.Parse(reader["idFuncionalidad"].ToString());
				if (!Convert.IsDBNull(reader["cvDominio"])) oFuncionalidadXRol.cvDominio = reader["cvDominio"] as string;
				if (!Convert.IsDBNull(reader["esConsultar"])) oFuncionalidadXRol.esConsultar = (bool)reader["esConsultar"];
				if (!Convert.IsDBNull(reader["esActualizar"])) oFuncionalidadXRol.esActualizar = (bool)reader["esActualizar"];
				if (!Convert.IsDBNull(reader["esAgregar"])) oFuncionalidadXRol.esAgregar = (bool)reader["esAgregar"];
				if (!Convert.IsDBNull(reader["esImprimir"])) oFuncionalidadXRol.esImprimir = (bool)reader["esImprimir"];
				if (!Convert.IsDBNull(reader["esEspecial"])) oFuncionalidadXRol.esEspecial = (bool)reader["esEspecial"];
				if (!Convert.IsDBNull(reader["nbFuncionalidad"])) oFuncionalidadXRol.nbFuncionalidad = reader["nbFuncionalidad"] as string;
				if (!Convert.IsDBNull(reader["nbdRol"])) oFuncionalidadXRol.nbdRol = reader["nbdRol"] as string;
				if (!Convert.IsDBNull(reader["nbDominio"])) oFuncionalidadXRol.nbDominio = reader["nbDominio"] as string;
				lstFuncionalidadXRol.Add(oFuncionalidadXRol);
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