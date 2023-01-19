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
	/// Funcionalidad del Sistema
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Funcionalidad : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Identificador de la Funcionalidad
		/// </summary>
		[DataMember]
		public Int32 idFuncionalidad { get; set; }
		/// <summary>
		/// Código de la Aplicación
		/// </summary>
		[DataMember]
		public string codAplicacion { get; set; }
		/// <summary>
		/// Código de la Categoria
		/// </summary>
		[DataMember]
		public Int32 idCodigoCategoria { get; set; }
		/// <summary>
		/// Nombre de la Funcionalidad
		/// </summary>
		[DataMember]
		public string nbFuncionalidad { get; set; }
		/// <summary>
		/// Descripcion de la Funcinalidad
		/// </summary>
		[DataMember]
		public string dsFuncionalidad { get; set; }
		/// <summary>
		/// Nombre del Componente
		/// </summary>
		[DataMember]
		public string nbComponente { get; set; }
		/// <summary>
		/// Descripcion del Titulo
		/// </summary>
		[DataMember]
		public string dsTitulo { get; set; }
		/// <summary>
		/// Ruta de la Imagen para el Título
		/// </summary>
		[DataMember]
		public string dsRutaImagen { get; set; }
		/// <summary>
		/// Indica si es Activo
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		/// <summary>
		/// Verificación para indicar si en la funcionalidad se permite Consultar
		/// </summary>
		[DataMember]
		public bool esConsultar { get; set; }
		/// <summary>
		/// Verificación para indicar si en la funcionalidad se permite Actualizar
		/// </summary>
		[DataMember]
		public bool esActualizar { get; set; }
		/// <summary>
		/// Verificación para indicar si en la funcionalidad se permite Agregar
		/// </summary>
		[DataMember]
		public bool esAgregar { get; set; }
		/// <summary>
		/// Verificación para indicar si en la funcionalidad se permite Imprimir
		/// </summary>
		[DataMember]
		public bool esImprimir { get; set; }
		/// <summary>
		/// Verificación para indicar si en la funcionalidad se permite operaciones Especiales
		/// </summary>
		[DataMember]
		public bool esEspecial { get; set; }
		/// <summary>
		/// Nombre del Tipo de Operación
		/// </summary>
		[DataMember]
		public string nbCodigoTipoOperacion { get; set; }
		/// <summary>
		/// Nombre de la Aplicación
		/// </summary>
		[DataMember]
		public string nbAplicacion { get; set; }
		/// <summary>
		/// Indica si es un componente dentro de una pagina de tipo Content
		/// </summary>
		[DataMember]
		public bool esContent { get; set; }
		/// <summary>
		/// Ruta del Componente
		/// </summary>
		[DataMember]
		public string urlRutaContent { get; set; }
		/// <summary>
		/// Número de Filas del Grid de Visión General, cuando aplique
		/// </summary>
		[DataMember]
		public Int16 noFilasVisionGeneral { get; set; }
		/// <summary>
		/// Identificador de la Funcionalidad Padre
		/// </summary>
		[DataMember]
		public Int32 idFuncionalidadPadre { get; set; }
		/// <summary>
		/// Identificador del Tipo de Operación
		/// </summary>
		[DataMember]
		public Int32 idCodigoTipoOperacion { get; set; }
		/// <summary>
		/// Nombre de la Funcionalidad
		/// </summary>
		[DataMember]
		public string nbFuncionalidadPadre { get; set; }
		/// <summary>
		/// Nombre de la Categoría
		/// </summary>
		[DataMember]
		public string nbCategoria { get; set; }
		/// <summary>
		/// Número de Ordenamiento
		/// </summary>
		[DataMember]
		public int noOrden { get; set; }

		#endregion Properties

		#region Constructors
		/// <summary>
		/// Constructor de la Clase Funcionalidad del Sistema  
		/// </summary>
		public Funcionalidad()
		{
			idFuncionalidad = 0;
			codAplicacion = string.Empty;
			idCodigoCategoria = 0;
			nbFuncionalidad = string.Empty;
			dsFuncionalidad = string.Empty;
			nbComponente = string.Empty;
			dsTitulo = string.Empty;
			dsRutaImagen = string.Empty;
			esActivo = false;
			esConsultar = false;
			esActualizar = false;
			esAgregar = false;
			esImprimir = false;
			esEspecial = false;
			esContent = false;
			urlRutaContent = string.Empty;
			noFilasVisionGeneral = 0;
			idFuncionalidadPadre = 0;
			idCodigoTipoOperacion = 0;
			nbAplicacion = string.Empty;
			nbCodigoTipoOperacion = string.Empty;
			nbFuncionalidadPadre = string.Empty;
			nbCategoria = string.Empty;
			noOrden = 0;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(Funcionalidad rhs, Funcionalidad.FuncionalidadComparer.FuncionalidadTipoComparacion which)
		{
			switch (which)
			{
				case FuncionalidadComparer.FuncionalidadTipoComparacion.idFuncionalidad: return idFuncionalidad.CompareTo(rhs.idFuncionalidad);
				case FuncionalidadComparer.FuncionalidadTipoComparacion.codAplicacion: return codAplicacion.CompareTo(rhs.codAplicacion);
				case FuncionalidadComparer.FuncionalidadTipoComparacion.idCodigoCategoria: return idCodigoCategoria.CompareTo(rhs.idCodigoCategoria);
				case FuncionalidadComparer.FuncionalidadTipoComparacion.nbFuncionalidad: return nbFuncionalidad.CompareTo(rhs.nbFuncionalidad);
				case FuncionalidadComparer.FuncionalidadTipoComparacion.nbComponente: return nbComponente.CompareTo(rhs.nbComponente);
				case FuncionalidadComparer.FuncionalidadTipoComparacion.dsTitulo: return dsTitulo.CompareTo(rhs.dsTitulo);
				case FuncionalidadComparer.FuncionalidadTipoComparacion.esActivo: return esActivo.CompareTo(rhs.esActivo);
				case FuncionalidadComparer.FuncionalidadTipoComparacion.idFuncionalidadPadre: return idFuncionalidadPadre.CompareTo(rhs.idFuncionalidadPadre);
				case FuncionalidadComparer.FuncionalidadTipoComparacion.idCodigoTipoOperacion: return idCodigoTipoOperacion.CompareTo(rhs.idCodigoTipoOperacion);
				case FuncionalidadComparer.FuncionalidadTipoComparacion.nbCodigoTipoOperacion: return nbCodigoTipoOperacion.CompareTo(rhs.nbCodigoTipoOperacion);
				case FuncionalidadComparer.FuncionalidadTipoComparacion.nbAplicacion: return nbAplicacion.CompareTo(rhs.nbAplicacion);
				case FuncionalidadComparer.FuncionalidadTipoComparacion.nbFuncionalidadPadre: return nbFuncionalidadPadre.CompareTo(rhs.nbFuncionalidadPadre);
				case FuncionalidadComparer.FuncionalidadTipoComparacion.noOrden: return nbFuncionalidadPadre.CompareTo(rhs.noOrden);
			}
			return 0;
		}
		public class FuncionalidadComparer : IComparer<Funcionalidad>
		{
			public enum FuncionalidadTipoComparacion
			{
				idFuncionalidad,
				codAplicacion,
				idCodigoCategoria,
				nbFuncionalidad,
				nbComponente,
				dsTitulo,
				esActivo,
				idFuncionalidadPadre,
				idCodigoTipoOperacion,
				nbCodigoTipoOperacion,
				nbAplicacion,
				nbFuncionalidadPadre,
				noOrden,
				NULL
			}
			private FuncionalidadTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public FuncionalidadTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(Funcionalidad lhs, Funcionalidad rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(Funcionalidad lhs, Funcionalidad rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(Funcionalidad e)
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
			if (!Convert.IsDBNull(reader["idFuncionalidad"])) idFuncionalidad = Int32.Parse(reader["idFuncionalidad"].ToString());
			if (!Convert.IsDBNull(reader["codAplicacion"])) codAplicacion = reader["codAplicacion"] as string;
			if (!Convert.IsDBNull(reader["idCodigoCategoria"])) idCodigoCategoria = Int32.Parse(reader["idCodigoCategoria"].ToString());
			if (!Convert.IsDBNull(reader["nbFuncionalidad"])) nbFuncionalidad = reader["nbFuncionalidad"] as string;
			if (!Convert.IsDBNull(reader["dsFuncionalidad"])) dsFuncionalidad = reader["dsFuncionalidad"] as string;
			if (!Convert.IsDBNull(reader["nbComponente"])) nbComponente = reader["nbComponente"] as string;
			if (!Convert.IsDBNull(reader["dsTitulo"])) dsTitulo = reader["dsTitulo"] as string;
			if (!Convert.IsDBNull(reader["dsRutaImagen"])) dsRutaImagen = reader["dsRutaImagen"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) esActivo = (bool)reader["esActivo"];
			if (!Convert.IsDBNull(reader["esConsultar"])) esConsultar = (bool)reader["esConsultar"];
			if (!Convert.IsDBNull(reader["esActualizar"])) esActualizar = (bool)reader["esActualizar"];
			if (!Convert.IsDBNull(reader["esAgregar"])) esAgregar = (bool)reader["esAgregar"];
			if (!Convert.IsDBNull(reader["esImprimir"])) esImprimir = (bool)reader["esImprimir"];
			if (!Convert.IsDBNull(reader["esEspecial"])) esEspecial = (bool)reader["esEspecial"];
			if (!Convert.IsDBNull(reader["esContent"])) esContent = (bool)reader["esContent"];
			if (!Convert.IsDBNull(reader["urlRutaContent"])) urlRutaContent = reader["urlRutaContent"] as string;
			if (!Convert.IsDBNull(reader["noFilasVisionGeneral"])) noFilasVisionGeneral = Int16.Parse(reader["noFilasVisionGeneral"].ToString());
			if (!Convert.IsDBNull(reader["idFuncionalidadPadre"])) idFuncionalidadPadre = Int32.Parse(reader["idFuncionalidadPadre"].ToString());
			if (!Convert.IsDBNull(reader["idCodigoTipoOperacion"])) idCodigoTipoOperacion = Int32.Parse(reader["idCodigoTipoOperacion"].ToString());
			if (!Convert.IsDBNull(reader["nbAplicacion"])) nbAplicacion = reader["nbAplicacion"] as string;
			if (!Convert.IsDBNull(reader["nbCodigoTipoOperacion"])) nbCodigoTipoOperacion = reader["nbCodigoTipoOperacion"] as string;
			if (!Convert.IsDBNull(reader["nbFuncionalidadPadre"])) nbFuncionalidadPadre = reader["nbFuncionalidadPadre"] as string;
			if (!Convert.IsDBNull(reader["nbCategoria"])) nbCategoria = reader["nbCategoria"] as string;
			if (!Convert.IsDBNull(reader["noOrden"])) noOrden = Int32.Parse(reader["noOrden"].ToString());
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (idFuncionalidad != 0) DataUtil.SetValue(pars, "@idFuncionalidad", idFuncionalidad);
			if (codAplicacion != string.Empty) DataUtil.SetValue(pars, "@codAplicacion", codAplicacion);
			if (idCodigoCategoria != 0) DataUtil.SetValue(pars, "@idCodigoCategoria", idCodigoCategoria);
			if (nbFuncionalidad != string.Empty) DataUtil.SetValue(pars, "@nbFuncionalidad", nbFuncionalidad);
			if (dsFuncionalidad != string.Empty) DataUtil.SetValue(pars, "@dsFuncionalidad", dsFuncionalidad);
			if (nbComponente != string.Empty) DataUtil.SetValue(pars, "@nbComponente", nbComponente);
			if (dsTitulo != string.Empty) DataUtil.SetValue(pars, "@dsTitulo", dsTitulo);
			if (dsRutaImagen != string.Empty) DataUtil.SetValue(pars, "@dsRutaImagen", dsRutaImagen);
			DataUtil.SetValue(pars, "@esActivo", esActivo);
			DataUtil.SetValue(pars, "@esConsultar", esConsultar);
			DataUtil.SetValue(pars, "@esActualizar", esActualizar);
			DataUtil.SetValue(pars, "@esAgregar", esAgregar);
			DataUtil.SetValue(pars, "@esImprimir", esImprimir);
			DataUtil.SetValue(pars, "@esEspecial", esEspecial);
			DataUtil.SetValue(pars, "@esContent", esContent);
			if (urlRutaContent != string.Empty) DataUtil.SetValue(pars, "@urlRutaContent", urlRutaContent);
			if (noFilasVisionGeneral != 0) DataUtil.SetValue(pars, "@noFilasVisionGeneral", noFilasVisionGeneral);
			if (idFuncionalidadPadre != 0) DataUtil.SetValue(pars, "@idFuncionalidadPadre", idFuncionalidadPadre);
			if (idCodigoTipoOperacion != 0) DataUtil.SetValue(pars, "@idCodigoTipoOperacion", idCodigoTipoOperacion);
			if (noOrden != 0) DataUtil.SetValue(pars, "@noOrden", noOrden);
			DataUtil.SetReturnedValue(pars, "@return_value");
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Funcionalidad 
	/// </summary>
	[Serializable]
	[DataContract]
	public class FuncionalidadList : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		 [DataMember]
		public List<Funcionalidad> lstFuncionalidad { get; set; }
		#endregion Properties

		#region Constructors
		public FuncionalidadList()
		{
			lstFuncionalidad = new List<Funcionalidad>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstFuncionalidad = new List<Funcionalidad>();
			while (reader.Read())
			{
				Funcionalidad oFuncionalidad = new Funcionalidad();
				if (!Convert.IsDBNull(reader["idFuncionalidad"])) oFuncionalidad.idFuncionalidad = Int32.Parse(reader["idFuncionalidad"].ToString());
				if (!Convert.IsDBNull(reader["codAplicacion"])) oFuncionalidad.codAplicacion = reader["codAplicacion"] as string;
				if (!Convert.IsDBNull(reader["idCodigoCategoria"])) oFuncionalidad.idCodigoCategoria = Int32.Parse(reader["idCodigoCategoria"].ToString());
				if (!Convert.IsDBNull(reader["nbFuncionalidad"])) oFuncionalidad.nbFuncionalidad = reader["nbFuncionalidad"] as string;
				if (!Convert.IsDBNull(reader["dsFuncionalidad"])) oFuncionalidad.dsFuncionalidad = reader["dsFuncionalidad"] as string;
				if (!Convert.IsDBNull(reader["nbComponente"])) oFuncionalidad.nbComponente = reader["nbComponente"] as string;
				if (!Convert.IsDBNull(reader["dsTitulo"])) oFuncionalidad.dsTitulo = reader["dsTitulo"] as string;
				if (!Convert.IsDBNull(reader["dsRutaImagen"])) oFuncionalidad.dsRutaImagen = reader["dsRutaImagen"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oFuncionalidad.esActivo = (bool)reader["esActivo"];
				if (!Convert.IsDBNull(reader["esConsultar"])) oFuncionalidad.esConsultar = (bool)reader["esConsultar"];
				if (!Convert.IsDBNull(reader["esActualizar"])) oFuncionalidad.esActualizar = (bool)reader["esActualizar"];
				if (!Convert.IsDBNull(reader["esAgregar"])) oFuncionalidad.esAgregar = (bool)reader["esAgregar"];
				if (!Convert.IsDBNull(reader["esImprimir"])) oFuncionalidad.esImprimir = (bool)reader["esImprimir"];
				if (!Convert.IsDBNull(reader["esEspecial"])) oFuncionalidad.esEspecial = (bool)reader["esEspecial"];
				if (!Convert.IsDBNull(reader["esContent"])) oFuncionalidad.esContent = (bool)reader["esContent"];
				if (!Convert.IsDBNull(reader["urlRutaContent"])) oFuncionalidad.urlRutaContent = reader["urlRutaContent"] as string;
				if (!Convert.IsDBNull(reader["noFilasVisionGeneral"])) oFuncionalidad.noFilasVisionGeneral = Int16.Parse(reader["noFilasVisionGeneral"].ToString());
				if (!Convert.IsDBNull(reader["idFuncionalidadPadre"])) oFuncionalidad.idFuncionalidadPadre = Int32.Parse(reader["idFuncionalidadPadre"].ToString());
				if (!Convert.IsDBNull(reader["idCodigoTipoOperacion"])) oFuncionalidad.idCodigoTipoOperacion = Int32.Parse(reader["idCodigoTipoOperacion"].ToString());
				if (!Convert.IsDBNull(reader["nbAplicacion"])) oFuncionalidad.nbAplicacion = reader["nbAplicacion"] as string;
				if (!Convert.IsDBNull(reader["nbCodigoTipoOperacion"])) oFuncionalidad.nbCodigoTipoOperacion = reader["nbCodigoTipoOperacion"] as string;
				if (!Convert.IsDBNull(reader["nbFuncionalidadPadre"])) oFuncionalidad.nbFuncionalidadPadre = reader["nbFuncionalidadPadre"] as string;
				if (!Convert.IsDBNull(reader["nbCategoria"])) oFuncionalidad.nbCategoria = reader["nbCategoria"] as string;
				if (!Convert.IsDBNull(reader["noOrden"])) oFuncionalidad.noOrden = Int32.Parse(reader["noOrden"].ToString());
				lstFuncionalidad.Add(oFuncionalidad);
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