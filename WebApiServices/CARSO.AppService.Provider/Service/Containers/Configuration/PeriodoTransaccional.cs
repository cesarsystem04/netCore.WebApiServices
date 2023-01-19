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
	/// Periodos Transaccionales para Procesos Masivos
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class PeriodoTransaccional : IDataContainer
	{
		#region Attributes
		private bool _esPorDiaSemana;
		private bool _esPorFrecuencia;
		private bool _esPorPeriodo;
		private string _dsTipo;
		private bool _esLunes;
		private bool _esMartes;
		private bool _esMiercoles;
		private bool _esJueves;
		private bool _esViernes;
		private bool _esSabado;
		private bool _esDomingo;
		private string _dsPeriodo;
		private string _hrInicio;
		private string _hrFin;
		private string _dsRangoHorario;
		private Int32 _noOcurrencia;
		private string _nbCodigoTipoOcurrencia;
		private string _dsEjecucion;
		private string _nbCodigoFrecuencia;
		private string _feInicioPeriodo;
		private string _feFinPeriodo;
		#endregion Attributes

		#region Properties
		/// <summary>
		/// Identificador del Periodo
		/// </summary>
		[DataMember]
		public Int32 idPeriodo { get; set; }
		/// <summary>
		/// Código de la Aplicación
		/// </summary>
		[DataMember]
		public string codAplicacion { get; set; }
		/// <summary>
		/// Indica si es por frecuencia
		/// </summary>
		[DataMember]
		public bool esPorFrecuencia { get { return _esPorFrecuencia; } set { _esPorFrecuencia = value; } }
		/// <summary>
		/// Tipo de frecuencia
		/// </summary>
		[DataMember]
		public Int32 idCodigoFrecuencia { get; set; }
		/// <summary>
		/// Indica si es por periodo
		/// </summary>
		[DataMember]
		public bool esPorPeriodo { get { return _esPorPeriodo; } set { _esPorPeriodo = value; } }
		/// <summary>
		/// Fecha de Inicio
		/// </summary>
		[DataMember]
		public string feInicioPeriodo { get { return _feInicioPeriodo; } set { _feInicioPeriodo = value; } }
		/// <summary>
		/// Fecha Final
		/// </summary>
		[DataMember]
		public string feFinPeriodo { get { return _feFinPeriodo; } set { _feFinPeriodo = value; } }
		/// <summary>
		/// Indica si es por día de la semana
		/// </summary>
		[DataMember]
		public bool esPorDiaSemana { get { return _esPorDiaSemana; } set { _esPorDiaSemana = value;} }
		/// <summary>
		/// Indica si aplica para el Lunes
		/// </summary>
		[DataMember]
		public bool esLunes { get { return _esLunes; } set { _esLunes = value; } }
		/// <summary>
		/// Indica si aplica para el Martes
		/// </summary>
		[DataMember]
		public bool esMartes { get { return _esMartes; } set { _esMartes = value; } }
		/// <summary>
		/// Indica si aplica para el Miercoles
		/// </summary>
		[DataMember]
		public bool esMiercoles { get { return _esMiercoles; } set { _esMiercoles = value; } }
		/// <summary>
		/// Indica si aplica para el Jueves
		/// </summary>
		[DataMember]
		public bool esJueves { get { return _esJueves; } set { _esJueves = value; } }
		/// <summary>
		/// Indica si aplica para el Viernes
		/// </summary>
		[DataMember]
		public bool esViernes { get { return _esViernes; } set { _esViernes = value; } }
		/// <summary>
		/// Indica si aplica para el Sabado
		/// </summary>
		[DataMember]
		public bool esSabado { get { return _esSabado; } set { _esSabado = value; } }
		/// <summary>
		/// Indica si aplica para el Domingo
		/// </summary>
		[DataMember]
		public bool esDomingo { get { return _esDomingo; } set { _esDomingo = value; } }
		/// <summary>
		/// Número de transacciones a procesar
		/// </summary>
		[DataMember]
		public Int32 noTransacciones { get; set; }
		/// <summary>
		/// Hora de inicio de la ejecución
		/// </summary>
		[DataMember]
		public string hrInicio { get { return _hrInicio; } set { _hrInicio = value; } }
		/// <summary>
		/// Hora final de la ejecución
		/// </summary>
		[DataMember]
		public string hrFin { get { return _hrFin; } set { _hrFin = value; } }
		/// <summary>
		/// Valor de la unidad de tiempo para la ejecución
		/// </summary>
		[DataMember]
		public Int32 noOcurrencia { get { return _noOcurrencia; } set { _noOcurrencia = value; } }
		/// <summary>
		/// Tipo de Ocurrencia
		/// </summary>
		[DataMember]
		public Int32 idCodigoTipoOcurrencia { get; set; }
		/// <summary>
		/// Número de prioridad
		/// </summary>
		[DataMember]
		public Int32 noPrioridad { get; set; }
		/// <summary>
		/// Indica si el registro es activo
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		/// <summary>
		/// Identificador del Usuario
		/// </summary>
		[DataMember]
		public string CreadoPor { get; set; }
		/// <summary>
		/// Fecha de creación 
		/// </summary>
		[DataMember]
		public string feCreacion { get; set; }
		/// <summary>
		/// Nombre de la Aplicación
		/// </summary>
		[DataMember]
		public string nbdAplicacion { get; set; }
		/// <summary>
		/// Nombre del elemento
		/// </summary>
		[DataMember]
		public string nbCodigoFrecuencia { get { return _nbCodigoFrecuencia; } set { _nbCodigoFrecuencia = value; } }
		/// <summary>
		/// Identificador del usuario en el Directorio Activo
		/// </summary>
		[DataMember]
		public string nbCreadoPor { get; set; }
		/// <summary>
		/// Nombre del elemento
		/// </summary>
		[DataMember]
		public string nbCodigoTipoOcurrencia { get { return _nbCodigoTipoOcurrencia; } set { _nbCodigoTipoOcurrencia = value; } }
		[DataMember]
		public string dsTipo
		{
			get
			{
				string Descripcion = string.Empty;
				if (_esPorDiaSemana)
					Descripcion = "Por día de la semana";
				if (_esPorFrecuencia)
					Descripcion = "Por Frecuencia";
				if (_esPorPeriodo)
					Descripcion = "Por Periodo";
				return Descripcion;
			}
			set { _dsTipo = value; }
		}
		[DataMember]
		public string dsPeriodo
		{
			get
			{
				string Descripcion = string.Empty;
				if (_esPorDiaSemana)
				{
					if (_esLunes)
						Descripcion += Descripcion == string.Empty ? "LU" : ", LU";
					if (_esMartes)
						Descripcion += Descripcion == string.Empty ? "MA" : ", MA";
					if (_esMiercoles)
						Descripcion += Descripcion == string.Empty ? "MI" : ", MI";
					if (_esJueves)
						Descripcion += Descripcion == string.Empty ? "JU" : ", JU";
					if (_esViernes)
						Descripcion += Descripcion == string.Empty ? "VI" : ", VI";
					if (_esSabado)
						Descripcion += Descripcion == string.Empty ? "SA" : ", SA";
					if (_esDomingo)
						Descripcion += Descripcion == string.Empty ? "DO" : ", DO";
				}
				if (_esPorFrecuencia)
					Descripcion = _nbCodigoFrecuencia;
				if (_esPorPeriodo)
					Descripcion = _feInicioPeriodo + " - " + _feFinPeriodo;
				return Descripcion;
			}
			set
			{
				_dsPeriodo = value;
			}
		}
		[DataMember]
		public string dsRangoHorario
		{
			get
			{
				return _hrInicio + " - " + _hrFin + " Hrs.";
			}
			set
			{
				_dsRangoHorario = value;
			}
		}
		[DataMember]
		public string dsEjecucion
		{
			get
			{
				return "Cada " + _noOcurrencia.ToString() + " " + _nbCodigoTipoOcurrencia;
			}
			set
			{
				_dsEjecucion = value;
			}
		}

		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase Periodos Transaccionales para Procesos Masivos  
		/// </summary>
		public PeriodoTransaccional()
		{
			idPeriodo = 0;
			codAplicacion = string.Empty;
			_esPorFrecuencia = false;
			idCodigoFrecuencia = 0;
			_esPorPeriodo = false;
			_feInicioPeriodo = string.Empty;
			_feFinPeriodo = string.Empty;
			_esPorDiaSemana = false;
			_esLunes = false;
			_esMartes = false;
			_esMiercoles = false;
			_esJueves = false;
			_esViernes = false;
			_esSabado = false;
			_esDomingo = false;
			noTransacciones = 0;
			_hrInicio = string.Empty;
			_hrFin = string.Empty;
			_noOcurrencia = 0;
			idCodigoTipoOcurrencia = 0;
			noPrioridad = 0;
			esActivo = false;
			CreadoPor = string.Empty;
			feCreacion = string.Empty;
			nbdAplicacion = string.Empty;
			_nbCodigoFrecuencia = string.Empty;
			nbCreadoPor = string.Empty;
			_nbCodigoTipoOcurrencia = string.Empty;
			_dsTipo = string.Empty;
			_dsPeriodo = string.Empty;
			_dsRangoHorario = string.Empty;
			_dsEjecucion = string.Empty;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(PeriodoTransaccional rhs, PeriodoTransaccional.PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion which)
		{
			switch (which)
			{
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.idPeriodo:return idPeriodo.CompareTo(rhs.idPeriodo);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.codAplicacion:return codAplicacion.CompareTo(rhs.codAplicacion);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.esPorFrecuencia:return esPorFrecuencia.CompareTo(rhs.esPorFrecuencia);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.idCodigoFrecuencia:return idCodigoFrecuencia.CompareTo(rhs.idCodigoFrecuencia);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.esPorPeriodo:return esPorPeriodo.CompareTo(rhs.esPorPeriodo);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.feInicioPeriodo:return feInicioPeriodo.CompareTo(rhs.feInicioPeriodo);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.feFinPeriodo:return feFinPeriodo.CompareTo(rhs.feFinPeriodo);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.esPorDiaSemana:return esPorDiaSemana.CompareTo(rhs.esPorDiaSemana);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.noTransacciones:return noTransacciones.CompareTo(rhs.noTransacciones);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.hrInicio:return hrInicio.CompareTo(rhs.hrInicio);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.hrFin:return hrFin.CompareTo(rhs.hrFin);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.noOcurrencia:return noOcurrencia.CompareTo(rhs.noOcurrencia);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.idCodigoTipoOcurrencia:return idCodigoTipoOcurrencia.CompareTo(rhs.idCodigoTipoOcurrencia);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.noPrioridad:return noPrioridad.CompareTo(rhs.noPrioridad);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.esActivo:return esActivo.CompareTo(rhs.esActivo);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.CreadoPor:return CreadoPor.CompareTo(rhs.CreadoPor);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.feCreacion:return feCreacion.CompareTo(rhs.feCreacion);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.nbCodigoFrecuencia:return nbCodigoFrecuencia.CompareTo(rhs.nbCodigoFrecuencia);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.nbCodigoTipoOcurrencia:return nbCodigoTipoOcurrencia.CompareTo(rhs.nbCodigoTipoOcurrencia);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.nbdAplicacion:return nbdAplicacion.CompareTo(rhs.nbdAplicacion);
				case PeriodoTransaccionalComparer.PeriodoTransaccionalTipoComparacion.nbCreadoPor:return nbCreadoPor.CompareTo(rhs.nbCreadoPor);
			}
			return 0;
		}
		public class PeriodoTransaccionalComparer : IComparer<PeriodoTransaccional>
		{
			public enum PeriodoTransaccionalTipoComparacion
			{
				idPeriodo,
				codAplicacion,
				esPorFrecuencia,
				idCodigoFrecuencia,
				esPorPeriodo,
				feInicioPeriodo,
				feFinPeriodo,
				esPorDiaSemana,
				noTransacciones,
				hrInicio,
				hrFin,
				noOcurrencia,
				idCodigoTipoOcurrencia,
				noPrioridad,
				esActivo,
				CreadoPor,
				feCreacion,
				nbCodigoFrecuencia,
				nbCodigoTipoOcurrencia,
				nbdAplicacion,
				nbCreadoPor,
				NULL
			}
			private PeriodoTransaccionalTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public PeriodoTransaccionalTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}
			
			public int Compare(PeriodoTransaccional lhs, PeriodoTransaccional rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}
			
			public bool Equals(PeriodoTransaccional lhs, PeriodoTransaccional rhs)
			{
				return Compare(lhs, rhs) == 0;
			}
			
			public int GetHashCode(PeriodoTransaccional e)
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
			if (!Convert.IsDBNull(reader["idPeriodo"])) idPeriodo = Int32.Parse(reader["idPeriodo"].ToString());
			if (!Convert.IsDBNull(reader["codAplicacion"])) codAplicacion = reader["codAplicacion"] as string;
			if (!Convert.IsDBNull(reader["esPorFrecuencia"])) esPorFrecuencia = (bool)reader["esPorFrecuencia"];
			if (!Convert.IsDBNull(reader["idCodigoFrecuencia"])) idCodigoFrecuencia = Int32.Parse(reader["idCodigoFrecuencia"].ToString());
			if (!Convert.IsDBNull(reader["esPorPeriodo"])) esPorPeriodo = (bool)reader["esPorPeriodo"];
			if (!Convert.IsDBNull(reader["feInicioPeriodo"])) feInicioPeriodo = DateTime.Parse(reader["feInicioPeriodo"].ToString()).ToShortDateString();
			if (!Convert.IsDBNull(reader["feFinPeriodo"])) feFinPeriodo = DateTime.Parse(reader["feFinPeriodo"].ToString()).ToShortDateString();
			if (!Convert.IsDBNull(reader["esPorDiaSemana"])) esPorDiaSemana = (bool)reader["esPorDiaSemana"];
			if (!Convert.IsDBNull(reader["esLunes"])) esLunes = (bool)reader["esLunes"];
			if (!Convert.IsDBNull(reader["esMartes"])) esMartes = (bool)reader["esMartes"];
			if (!Convert.IsDBNull(reader["esMiercoles"])) esMiercoles = (bool)reader["esMiercoles"];
			if (!Convert.IsDBNull(reader["esJueves"])) esJueves = (bool)reader["esJueves"];
			if (!Convert.IsDBNull(reader["esViernes"])) esViernes = (bool)reader["esViernes"];
			if (!Convert.IsDBNull(reader["esSabado"])) esSabado = (bool)reader["esSabado"];
			if (!Convert.IsDBNull(reader["esDomingo"])) esDomingo = (bool)reader["esDomingo"];
			if (!Convert.IsDBNull(reader["noTransacciones"])) noTransacciones = Int32.Parse(reader["noTransacciones"].ToString());
			if (!Convert.IsDBNull(reader["hrInicio"])) hrInicio = reader["hrInicio"] as string;
			if (!Convert.IsDBNull(reader["hrFin"])) hrFin = reader["hrFin"] as string;
			if (!Convert.IsDBNull(reader["noOcurrencia"])) noOcurrencia = Int32.Parse(reader["noOcurrencia"].ToString());
			if (!Convert.IsDBNull(reader["idCodigoTipoOcurrencia"])) idCodigoTipoOcurrencia = Int32.Parse(reader["idCodigoTipoOcurrencia"].ToString());
			if (!Convert.IsDBNull(reader["noPrioridad"])) noPrioridad = Int32.Parse(reader["noPrioridad"].ToString());
			if (!Convert.IsDBNull(reader["esActivo"])) esActivo = (bool)reader["esActivo"];
			if (!Convert.IsDBNull(reader["CreadoPor"])) CreadoPor = reader["CreadoPor"] as string;
			if (!Convert.IsDBNull(reader["feCreacion"])) feCreacion = DateTime.Parse(reader["feCreacion"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
			if (!Convert.IsDBNull(reader["nbdAplicacion"])) nbdAplicacion = reader["nbdAplicacion"] as string;
			if (!Convert.IsDBNull(reader["nbCodigoFrecuencia"])) nbCodigoFrecuencia = reader["nbCodigoFrecuencia"] as string;
			if (!Convert.IsDBNull(reader["nbCreadoPor"])) nbCreadoPor = reader["nbCreadoPor"] as string;
			if (!Convert.IsDBNull(reader["nbCodigoTipoOcurrencia"])) nbCodigoTipoOcurrencia = reader["nbCodigoTipoOcurrencia"] as string;
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (idPeriodo != 0) DataUtil.SetValue(pars, "@idPeriodo", idPeriodo);
			if (codAplicacion != string.Empty) DataUtil.SetValue(pars, "@codAplicacion", codAplicacion);
			DataUtil.SetValue(pars, "@esPorFrecuencia", esPorFrecuencia);
			if (idCodigoFrecuencia != 0) DataUtil.SetValue(pars, "@idCodigoFrecuencia", idCodigoFrecuencia);
			DataUtil.SetValue(pars, "@esPorPeriodo", esPorPeriodo);
			if (feInicioPeriodo != string.Empty) DataUtil.SetValue(pars, "@feInicioPeriodo", DateTime.Parse(feInicioPeriodo).ToString("yyyyMMdd"));
			if (feFinPeriodo != string.Empty) DataUtil.SetValue(pars, "@feFinPeriodo", DateTime.Parse(feFinPeriodo).ToString("yyyyMMdd"));
			DataUtil.SetValue(pars, "@esPorDiaSemana", esPorDiaSemana);
			DataUtil.SetValue(pars, "@esLunes", esLunes);
			DataUtil.SetValue(pars, "@esMartes", esMartes);
			DataUtil.SetValue(pars, "@esMiercoles", esMiercoles);
			DataUtil.SetValue(pars, "@esJueves", esJueves);
			DataUtil.SetValue(pars, "@esViernes", esViernes);
			DataUtil.SetValue(pars, "@esSabado", esSabado);
			DataUtil.SetValue(pars, "@esDomingo", esDomingo);
			if (noTransacciones != 0) DataUtil.SetValue(pars, "@noTransacciones", noTransacciones);
			if (hrInicio != string.Empty) DataUtil.SetValue(pars, "@hrInicio", hrInicio);
			if (hrFin != string.Empty) DataUtil.SetValue(pars, "@hrFin", hrFin);
			if (noOcurrencia != 0) DataUtil.SetValue(pars, "@noOcurrencia", noOcurrencia);
			if (idCodigoTipoOcurrencia != 0) DataUtil.SetValue(pars, "@idCodigoTipoOcurrencia", idCodigoTipoOcurrencia);
			if (noPrioridad != 0) DataUtil.SetValue(pars, "@noPrioridad", noPrioridad);
			DataUtil.SetValue(pars, "@esActivo", esActivo);
			if (CreadoPor != string.Empty) DataUtil.SetValue(pars, "@CreadoPor", CreadoPor);
			if (feCreacion != string.Empty) DataUtil.SetValue(pars, "@feCreacion", feCreacion);
			DataUtil.SetReturnedValue(pars, "@return_value");
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de PeriodoTransaccional 
	/// </summary>
	[Serializable]
	[DataContract]
	public class PeriodoTransaccionalList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<PeriodoTransaccional> lstPeriodoTransaccional { get; set; }
		#endregion Properties

		#region Constructors
		public PeriodoTransaccionalList()
		{
			lstPeriodoTransaccional = new List<PeriodoTransaccional>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstPeriodoTransaccional = new List<PeriodoTransaccional>();
			while (reader.Read())
			{
				PeriodoTransaccional oPeriodoTransaccional = new PeriodoTransaccional();
				if (!Convert.IsDBNull(reader["idPeriodo"])) oPeriodoTransaccional.idPeriodo = Int32.Parse(reader["idPeriodo"].ToString());
				if (!Convert.IsDBNull(reader["codAplicacion"])) oPeriodoTransaccional.codAplicacion = reader["codAplicacion"] as string;
				if (!Convert.IsDBNull(reader["esPorFrecuencia"])) oPeriodoTransaccional.esPorFrecuencia = (bool)reader["esPorFrecuencia"];
				if (!Convert.IsDBNull(reader["idCodigoFrecuencia"])) oPeriodoTransaccional.idCodigoFrecuencia = Int32.Parse(reader["idCodigoFrecuencia"].ToString());
				if (!Convert.IsDBNull(reader["esPorPeriodo"])) oPeriodoTransaccional.esPorPeriodo = (bool)reader["esPorPeriodo"];
				if (!Convert.IsDBNull(reader["feInicioPeriodo"])) oPeriodoTransaccional.feInicioPeriodo = DateTime.Parse(reader["feInicioPeriodo"].ToString()).ToShortDateString();
				if (!Convert.IsDBNull(reader["feFinPeriodo"])) oPeriodoTransaccional.feFinPeriodo = DateTime.Parse(reader["feFinPeriodo"].ToString()).ToShortDateString();
				if (!Convert.IsDBNull(reader["esPorDiaSemana"])) oPeriodoTransaccional.esPorDiaSemana = (bool)reader["esPorDiaSemana"];
				if (!Convert.IsDBNull(reader["esLunes"])) oPeriodoTransaccional.esLunes = (bool)reader["esLunes"];
				if (!Convert.IsDBNull(reader["esMartes"])) oPeriodoTransaccional.esMartes = (bool)reader["esMartes"];
				if (!Convert.IsDBNull(reader["esMiercoles"])) oPeriodoTransaccional.esMiercoles = (bool)reader["esMiercoles"];
				if (!Convert.IsDBNull(reader["esJueves"])) oPeriodoTransaccional.esJueves = (bool)reader["esJueves"];
				if (!Convert.IsDBNull(reader["esViernes"])) oPeriodoTransaccional.esViernes = (bool)reader["esViernes"];
				if (!Convert.IsDBNull(reader["esSabado"])) oPeriodoTransaccional.esSabado = (bool)reader["esSabado"];
				if (!Convert.IsDBNull(reader["esDomingo"])) oPeriodoTransaccional.esDomingo = (bool)reader["esDomingo"];
				if (!Convert.IsDBNull(reader["noTransacciones"])) oPeriodoTransaccional.noTransacciones = Int32.Parse(reader["noTransacciones"].ToString());
				if (!Convert.IsDBNull(reader["hrInicio"])) oPeriodoTransaccional.hrInicio = reader["hrInicio"] as string;
				if (!Convert.IsDBNull(reader["hrFin"])) oPeriodoTransaccional.hrFin = reader["hrFin"] as string;
				if (!Convert.IsDBNull(reader["noOcurrencia"])) oPeriodoTransaccional.noOcurrencia = Int32.Parse(reader["noOcurrencia"].ToString());
				if (!Convert.IsDBNull(reader["idCodigoTipoOcurrencia"])) oPeriodoTransaccional.idCodigoTipoOcurrencia = Int32.Parse(reader["idCodigoTipoOcurrencia"].ToString());
				if (!Convert.IsDBNull(reader["noPrioridad"])) oPeriodoTransaccional.noPrioridad = Int32.Parse(reader["noPrioridad"].ToString());
				if (!Convert.IsDBNull(reader["esActivo"])) oPeriodoTransaccional.esActivo = (bool)reader["esActivo"];
				if (!Convert.IsDBNull(reader["CreadoPor"])) oPeriodoTransaccional.CreadoPor = reader["CreadoPor"] as string;
				if (!Convert.IsDBNull(reader["feCreacion"])) oPeriodoTransaccional.feCreacion = DateTime.Parse(reader["feCreacion"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
				if (!Convert.IsDBNull(reader["nbdAplicacion"])) oPeriodoTransaccional.nbdAplicacion = reader["nbdAplicacion"] as string;
				if (!Convert.IsDBNull(reader["nbCodigoFrecuencia"])) oPeriodoTransaccional.nbCodigoFrecuencia = reader["nbCodigoFrecuencia"] as string;
				if (!Convert.IsDBNull(reader["nbCreadoPor"])) oPeriodoTransaccional.nbCreadoPor = reader["nbCreadoPor"] as string;
				if (!Convert.IsDBNull(reader["nbCodigoTipoOcurrencia"])) oPeriodoTransaccional.nbCodigoTipoOcurrencia = reader["nbCodigoTipoOcurrencia"] as string;
				lstPeriodoTransaccional.Add(oPeriodoTransaccional);
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
