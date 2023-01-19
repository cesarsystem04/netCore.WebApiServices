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
	/// Menú principal del Sistema
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class MenuMaster : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Identificador del Elemento de Menú
		/// </summary>
		[DataMember]
		public Int32 idMenuMaster { get; set; }
		/// <summary>
		/// Identificador de la Funcionalidad
		/// </summary>
		[DataMember]
		public Int32 idFuncionalidad { get; set; }
		/// <summary>
		/// Identificador del Elemento Padre
		/// </summary>
		[DataMember]
		public Int32 idMenuMasterParent { get; set; }
		/// <summary>
		/// Código de la Aplicación
		/// </summary>
		[DataMember]
		public string codAplicacion { get; set; }
		/// <summary>
		/// Categoria del Menu
		/// </summary>
		[DataMember]
		public Int32 idCodigoCategoria { get; set; }
		/// <summary>
		/// Nombre de la opción del Menú
		/// </summary>
		[DataMember]
		public string nbOpcion { get; set; }
		/// <summary>
		/// Orden de aparición en el Menú
		/// </summary>
		[DataMember]
		public Int32 noOrden { get; set; }
		/// <summary>
		/// Ruta de la imagen que incluirá la opción en el Menú
		/// </summary>
		[DataMember]
		public string dsRutaImagen { get; set; }
		/// <summary>
		/// Categoria o grupo de opciones
		/// </summary>
		[DataMember]
		public string nbCategoria { get; set; }
		/// <summary>
		/// Categoria o grupo de opciones
		/// </summary>
		[DataMember]
		public string nbAplicacion { get; set; }
		/// <summary>
		/// Nombre de la Funcionalidad
		/// </summary>
		[DataMember]
		public string nbFuncionalidad { get; set; }
		/// <summary>
		/// Texto de ayuda en la opción del Menú
		/// </summary>
		[DataMember]
		public string dsToolTip { get; set; }
		/// <summary>
		/// Codigo de la opción para el control de la opción
		/// </summary>
		[DataMember]
		public string codOpcionValue { get; set; }
		#endregion Properties

		#region Constructors
		/// <summary>
		/// Constructor de la Clase Menú principal del Sistema  
		/// </summary>
		public MenuMaster()
		{
			idMenuMaster = 0;
			idFuncionalidad = 0;
			idMenuMasterParent = 0;
			codAplicacion = string.Empty;
			idCodigoCategoria = 0;
			nbOpcion = string.Empty;
			noOrden = 0;
			dsRutaImagen = string.Empty;
			nbCategoria = string.Empty;
			nbAplicacion = string.Empty;
			nbFuncionalidad = string.Empty;
			dsToolTip = string.Empty;
			codOpcionValue = string.Empty;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(MenuMaster rhs, MenuMaster.MenuMasterComparer.MenuMasterTipoComparacion which)
		{
			switch (which)
			{
			}
			return 0;
		}
		public class MenuMasterComparer : IComparer<MenuMaster>
		{
			public enum MenuMasterTipoComparacion
			{
				NULL
			}
			private MenuMasterTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public MenuMasterTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(MenuMaster lhs, MenuMaster rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(MenuMaster lhs, MenuMaster rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(MenuMaster e)
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
			if (!Convert.IsDBNull(reader["idMenuMaster"])) idMenuMaster = Int32.Parse(reader["idMenuMaster"].ToString());
			if (!Convert.IsDBNull(reader["idFuncionalidad"])) idFuncionalidad = Int32.Parse(reader["idFuncionalidad"].ToString());
			if (!Convert.IsDBNull(reader["idMenuMasterParent"])) idMenuMasterParent = Int32.Parse(reader["idMenuMasterParent"].ToString());
			if (!Convert.IsDBNull(reader["codAplicacion"])) codAplicacion = reader["codAplicacion"] as string;
			if (!Convert.IsDBNull(reader["idCodigoCategoria"])) idCodigoCategoria = Int32.Parse(reader["idCodigoCategoria"].ToString());
			if (!Convert.IsDBNull(reader["nbOpcion"])) nbOpcion = reader["nbOpcion"] as string;
			if (!Convert.IsDBNull(reader["noOrden"])) noOrden = Int32.Parse(reader["noOrden"].ToString());
			if (!Convert.IsDBNull(reader["dsRutaImagen"])) dsRutaImagen = reader["dsRutaImagen"] as string;
			if (!Convert.IsDBNull(reader["nbCategoria"])) nbCategoria = reader["nbCategoria"] as string;
			if (!Convert.IsDBNull(reader["nbAplicacion"])) nbAplicacion = reader["nbAplicacion"] as string;
			if (!Convert.IsDBNull(reader["nbFuncionalidad"])) nbFuncionalidad = reader["nbFuncionalidad"] as string;
			if (!Convert.IsDBNull(reader["dsToolTip"])) dsToolTip = reader["dsToolTip"] as string;
			if (!Convert.IsDBNull(reader["codOpcionValue"])) codOpcionValue = reader["codOpcionValue"] as string;
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (idMenuMaster != 0) DataUtil.SetValue(pars, "@idMenuMaster", idMenuMaster);
			if (idFuncionalidad != 0) DataUtil.SetValue(pars, "@idFuncionalidad", idFuncionalidad);
			if (idMenuMasterParent != 0) DataUtil.SetValue(pars, "@idMenuMasterParent", idMenuMasterParent);
			if (codAplicacion != string.Empty) DataUtil.SetValue(pars, "@codAplicacion", codAplicacion);
			if (idCodigoCategoria != 0) DataUtil.SetValue(pars, "@idCodigoCategoria", idCodigoCategoria);
			if (nbOpcion != string.Empty) DataUtil.SetValue(pars, "@nbOpcion", nbOpcion);
			if (noOrden != 0) DataUtil.SetValue(pars, "@noOrden", noOrden);
			if (dsRutaImagen != string.Empty) DataUtil.SetValue(pars, "@dsRutaImagen", dsRutaImagen);
			if (dsToolTip != string.Empty) DataUtil.SetValue(pars, "@dsToolTip", dsToolTip);
			if (codOpcionValue != string.Empty) DataUtil.SetValue(pars, "@codOpcionValue", codOpcionValue);
			DataUtil.SetReturnedValue(pars, "@return_value");
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de MenuMaster 
	/// </summary>
	[Serializable]
	[DataContract]
	public class MenuMasterList : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<MenuMaster> lstMenuMaster { get; set; }
		#endregion Properties

		#region Constructors
		public MenuMasterList()
		{
			lstMenuMaster = new List<MenuMaster>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstMenuMaster = new List<MenuMaster>();
			while (reader.Read())
			{
				MenuMaster oMenuMaster = new MenuMaster();
				if (!Convert.IsDBNull(reader["idMenuMaster"])) oMenuMaster.idMenuMaster = Int32.Parse(reader["idMenuMaster"].ToString());
				if (!Convert.IsDBNull(reader["idFuncionalidad"])) oMenuMaster.idFuncionalidad = Int32.Parse(reader["idFuncionalidad"].ToString());
				if (!Convert.IsDBNull(reader["idMenuMasterParent"])) oMenuMaster.idMenuMasterParent = Int32.Parse(reader["idMenuMasterParent"].ToString());
				if (!Convert.IsDBNull(reader["codAplicacion"])) oMenuMaster.codAplicacion = reader["codAplicacion"] as string;
				if (!Convert.IsDBNull(reader["idCodigoCategoria"])) oMenuMaster.idCodigoCategoria = Int32.Parse(reader["idCodigoCategoria"].ToString());
				if (!Convert.IsDBNull(reader["nbOpcion"])) oMenuMaster.nbOpcion = reader["nbOpcion"] as string;
				if (!Convert.IsDBNull(reader["noOrden"])) oMenuMaster.noOrden = Int32.Parse(reader["noOrden"].ToString());
				if (!Convert.IsDBNull(reader["dsRutaImagen"])) oMenuMaster.dsRutaImagen = reader["dsRutaImagen"] as string;
				if (!Convert.IsDBNull(reader["nbCategoria"])) oMenuMaster.nbCategoria = reader["nbCategoria"] as string;
				if (!Convert.IsDBNull(reader["nbAplicacion"])) oMenuMaster.nbAplicacion = reader["nbAplicacion"] as string;
				if (!Convert.IsDBNull(reader["nbFuncionalidad"])) oMenuMaster.nbFuncionalidad = reader["nbFuncionalidad"] as string;
				if (!Convert.IsDBNull(reader["dsToolTip"])) oMenuMaster.dsToolTip = reader["dsToolTip"] as string;
				if (!Convert.IsDBNull(reader["codOpcionValue"])) oMenuMaster.codOpcionValue = reader["codOpcionValue"] as string;
				lstMenuMaster.Add(oMenuMaster);
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