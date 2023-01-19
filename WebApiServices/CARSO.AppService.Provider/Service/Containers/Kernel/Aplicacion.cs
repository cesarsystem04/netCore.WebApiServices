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
	/// Configuración de la Aplicación
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Aplicacion : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Código de la Aplicación
		/// </summary>
		[DataMember]
		public string codAplicacion { get; set; }
		/// <summary>
		/// Imagen del Banner del Encabezado
		/// </summary>
		[DataMember]
		public Int32 idResourceBanner { get; set; }
		/// <summary>
		/// Logo Corporativo
		/// </summary>
		[DataMember]
		public Int32 idResourceLogo { get; set; }
		/// <summary>
		/// Imagen de fondo de la pagina home
		/// </summary>
		[DataMember]
		public Int32 idResourceImgHome { get; set; }
		/// <summary>
		/// Imagen para el borde de replica derecha
		/// </summary>
		[DataMember]
		public Int32 idResourceImgReplicaDer { get; set; }
		/// <summary>
		/// Imagen para el borde de replica izquierda
		/// </summary>
		[DataMember]
		public Int32 idResourceImgReplicaIzq { get; set; }
		/// <summary>
		/// Nombre de la Aplicación
		/// </summary>
		[DataMember]
		public string nbAplicacion { get; set; }
		/// <summary>
		/// Verificador para indicar la activación del Log a nivel Aplicación
		/// </summary>
		[DataMember]
		public bool ActivateLog { get; set; }
		/// <summary>
		/// Titulo a mostrar en el encabezado
		/// </summary>
		[DataMember]
		public string dsTitulo { get; set; }
		/// <summary>
		/// Subtitulo a mostrar en el encabezado
		/// </summary>
		[DataMember]
		public string dsSubTitulo { get; set; }
		/// <summary>
		/// Identificador del Ambiente
		/// </summary>
		[DataMember]
		public int idCodigoAmbiente { get; set; }
		/// <summary>
		/// Tipo de Ambiente
		/// </summary>
		[DataMember]
		public string nbAmbiente { get; set; }
		/// <summary>
		/// Número de la Versión
		/// </summary>
		[DataMember]
		public string noVersion { get; set; }
		/// <summary>
		/// Instancia de Base de Datos
		/// </summary>
		[DataMember]
		public string nbInstanciaDB { get; set; }
		/// <summary>
		/// Nombre de la Base de Datos
		/// </summary>
		[DataMember]
		public string nbDB { get; set; }
		/// <summary>
		/// Alias del Usuario
		/// </summary>
		[DataMember]
		public string CreadoPor { get; set; }
		/// <summary>
		/// Fecha de creación
		/// </summary>
		[DataMember]
		public string feCreacion { get; set; }
	   
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase Configuración de la Aplicación  
		/// </summary>
		public Aplicacion()
		{
			codAplicacion = string.Empty;
			idResourceBanner = 0;
			idResourceLogo = 0;
			idResourceImgHome = 0;
			idResourceImgReplicaDer = 0;
			idResourceImgReplicaIzq = 0;
			nbAplicacion = string.Empty;
			ActivateLog = false;
			dsTitulo = string.Empty;
			dsSubTitulo = string.Empty;
			idCodigoAmbiente = 0;
			nbAmbiente = string.Empty;
			noVersion = string.Empty;
			nbInstanciaDB = string.Empty;
			nbDB = string.Empty;
			CreadoPor = string.Empty;
			feCreacion = string.Empty;
		   
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(Aplicacion rhs, Aplicacion.AplicacionComparer.AplicacionTipoComparacion which)
		{
			switch (which)
			{
				case AplicacionComparer.AplicacionTipoComparacion.codAplicacion: return codAplicacion.CompareTo(rhs.codAplicacion);
				case AplicacionComparer.AplicacionTipoComparacion.nbAplicacion: return nbAplicacion.CompareTo(rhs.nbAplicacion);
				case AplicacionComparer.AplicacionTipoComparacion.nbInstanciaDB: return nbInstanciaDB.CompareTo(rhs.nbInstanciaDB);
				case AplicacionComparer.AplicacionTipoComparacion.nbDB: return nbDB.CompareTo(rhs.nbDB);
				case AplicacionComparer.AplicacionTipoComparacion.CreadoPor: return CreadoPor.CompareTo(rhs.CreadoPor);
				case AplicacionComparer.AplicacionTipoComparacion.feCreacion: return feCreacion.CompareTo(rhs.feCreacion);
			}
			return 0;
		}
		public class AplicacionComparer : IComparer<Aplicacion>
		{
			public enum AplicacionTipoComparacion
			{
				codAplicacion,
				nbAplicacion,
				nbInstanciaDB,
				nbDB,
				CreadoPor,
				feCreacion,
				NULL
			}
			private AplicacionTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public AplicacionTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(Aplicacion lhs, Aplicacion rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(Aplicacion lhs, Aplicacion rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(Aplicacion e)
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
			if (!Convert.IsDBNull(reader["codAplicacion"])) codAplicacion = reader["codAplicacion"] as string;
			if (!Convert.IsDBNull(reader["idResourceBanner"])) idResourceBanner = Int32.Parse(reader["idResourceBanner"].ToString());
			if (!Convert.IsDBNull(reader["idResourceLogo"])) idResourceLogo = Int32.Parse(reader["idResourceLogo"].ToString());
			if (!Convert.IsDBNull(reader["idResourceImgHome"])) idResourceImgHome = Int32.Parse(reader["idResourceImgHome"].ToString());
			if (!Convert.IsDBNull(reader["idResourceImgReplicaDer"])) idResourceImgReplicaDer = Int32.Parse(reader["idResourceImgReplicaDer"].ToString());
			if (!Convert.IsDBNull(reader["idResourceImgReplicaIzq"])) idResourceImgReplicaIzq = Int32.Parse(reader["idResourceImgReplicaIzq"].ToString());
			if (!Convert.IsDBNull(reader["nbAplicacion"])) nbAplicacion = reader["nbAplicacion"] as string;
			if (!Convert.IsDBNull(reader["ActivateLog"])) ActivateLog = (bool)reader["ActivateLog"];
			if (!Convert.IsDBNull(reader["dsTitulo"])) dsTitulo = reader["dsTitulo"] as string;
			if (!Convert.IsDBNull(reader["dsSubTitulo"])) dsSubTitulo = reader["dsSubTitulo"] as string;
			if (!Convert.IsDBNull(reader["idCodigoAmbiente"])) idCodigoAmbiente = Int32.Parse(reader["idCodigoAmbiente"].ToString());
			if (!Convert.IsDBNull(reader["nbAmbiente"])) nbAmbiente = reader["nbAmbiente"] as string;
			if (!Convert.IsDBNull(reader["noVersion"])) noVersion = reader["noVersion"] as string;
			if (!Convert.IsDBNull(reader["nbInstanciaDB"])) nbInstanciaDB = reader["nbInstanciaDB"] as string;
			if (!Convert.IsDBNull(reader["nbDB"])) nbDB = reader["nbDB"] as string;
			if (!Convert.IsDBNull(reader["CreadoPor"])) CreadoPor = reader["CreadoPor"] as string;
			if (!Convert.IsDBNull(reader["feCreacion"])) feCreacion = DateTime.Parse(reader["feCreacion"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");

		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (codAplicacion != string.Empty) DataUtil.SetValue(pars, "@codAplicacion", codAplicacion);
			if (idResourceBanner != 0) DataUtil.SetValue(pars, "@idResourceBanner", idResourceBanner);
			if (idResourceLogo != 0) DataUtil.SetValue(pars, "@idResourceLogo", idResourceLogo);
			if (idResourceImgHome != 0) DataUtil.SetValue(pars, "@idResourceImgHome", idResourceImgHome);
			if (idResourceImgReplicaDer != 0) DataUtil.SetValue(pars, "@idResourceImgReplicaDer", idResourceImgReplicaDer);
			if (idResourceImgReplicaIzq != 0) DataUtil.SetValue(pars, "@idResourceImgReplicaIzq", idResourceImgReplicaIzq);
			if (nbAplicacion != string.Empty) DataUtil.SetValue(pars, "@nbAplicacion", nbAplicacion);
			DataUtil.SetValue(pars, "@ActivateLog", ActivateLog);
			if (dsTitulo != string.Empty) DataUtil.SetValue(pars, "@dsTitulo", dsTitulo);
			if (dsSubTitulo != string.Empty) DataUtil.SetValue(pars, "@dsSubTitulo", dsSubTitulo);
			if (idCodigoAmbiente != 0) DataUtil.SetValue(pars, "@idCodigoAmbiente", idCodigoAmbiente);
			if (noVersion != string.Empty) DataUtil.SetValue(pars, "@noVersion", noVersion);
			if (nbInstanciaDB != string.Empty) DataUtil.SetValue(pars, "@nbInstanciaDB", nbInstanciaDB);
			if (nbDB != string.Empty) DataUtil.SetValue(pars, "@nbDB", nbDB);
			if (CreadoPor != string.Empty) DataUtil.SetValue(pars, "@CreadoPor", CreadoPor);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Aplicacion 
	/// </summary>
	[Serializable]
	[DataContract]
	public class AplicacionList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Aplicacion> lstAplicacion { get; set; }
		#endregion Properties

		#region Constructors
		public AplicacionList()
		{
			lstAplicacion = new List<Aplicacion>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstAplicacion = new List<Aplicacion>();
			while (reader.Read())
			{
				Aplicacion oAplicacion = new Aplicacion();
				if (!Convert.IsDBNull(reader["codAplicacion"])) oAplicacion.codAplicacion = reader["codAplicacion"] as string;
				if (!Convert.IsDBNull(reader["idResourceBanner"])) oAplicacion.idResourceBanner = Int32.Parse(reader["idResourceBanner"].ToString());
				if (!Convert.IsDBNull(reader["idResourceLogo"])) oAplicacion.idResourceLogo = Int32.Parse(reader["idResourceLogo"].ToString());
				if (!Convert.IsDBNull(reader["idResourceImgHome"])) oAplicacion.idResourceImgHome = Int32.Parse(reader["idResourceImgHome"].ToString());
				if (!Convert.IsDBNull(reader["idResourceImgReplicaDer"])) oAplicacion.idResourceImgReplicaDer = Int32.Parse(reader["idResourceImgReplicaDer"].ToString());
				if (!Convert.IsDBNull(reader["idResourceImgReplicaIzq"])) oAplicacion.idResourceImgReplicaIzq = Int32.Parse(reader["idResourceImgReplicaIzq"].ToString());
				if (!Convert.IsDBNull(reader["nbAplicacion"])) oAplicacion.nbAplicacion = reader["nbAplicacion"] as string;
				if (!Convert.IsDBNull(reader["ActivateLog"])) oAplicacion.ActivateLog = (bool)reader["ActivateLog"];
				if (!Convert.IsDBNull(reader["dsTitulo"])) oAplicacion.dsTitulo = reader["dsTitulo"] as string;
				if (!Convert.IsDBNull(reader["dsSubTitulo"])) oAplicacion.dsSubTitulo = reader["dsSubTitulo"] as string;
				if (!Convert.IsDBNull(reader["idCodigoAmbiente"])) oAplicacion.idCodigoAmbiente = Int32.Parse(reader["idCodigoAmbiente"].ToString());
				if (!Convert.IsDBNull(reader["nbAmbiente"])) oAplicacion.nbAmbiente = reader["nbAmbiente"] as string;
				if (!Convert.IsDBNull(reader["noVersion"])) oAplicacion.noVersion = reader["noVersion"] as string;
				if (!Convert.IsDBNull(reader["nbInstanciaDB"])) oAplicacion.nbInstanciaDB = reader["nbInstanciaDB"] as string;
				if (!Convert.IsDBNull(reader["nbDB"])) oAplicacion.nbDB = reader["nbDB"] as string;
				if (!Convert.IsDBNull(reader["CreadoPor"])) oAplicacion.CreadoPor = reader["CreadoPor"] as string;
				if (!Convert.IsDBNull(reader["feCreacion"])) oAplicacion.feCreacion = DateTime.Parse(reader["feCreacion"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");

				lstAplicacion.Add(oAplicacion);
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
