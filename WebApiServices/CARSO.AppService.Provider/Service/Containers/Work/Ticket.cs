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
	/// Registros para procesamiento por Lotes
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Ticket : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Identificador del registro a procesar
		/// </summary>
		[DataMember]
		public string idTicket { get; set; }
		/// <summary>
		/// Código de la Aplicación
		/// </summary>
		[DataMember]
		public string codAplicacion { get; set; }
		/// <summary>
		/// Identificador del elemento de catálogo para el Tipo de Procesamiento Masivo
		/// </summary>
		[DataMember]
		public Int32 idCodigoTipoProcesoMasivo { get; set; }
		/// <summary>
		/// Identificador del registro de origen
		/// </summary>
		[DataMember]
		public string idRegistro { get; set; }
		/// <summary>
		/// Identificador del elemento de catálogo para el Estatus del Ticket
		/// </summary>
		[DataMember]
		public Int32 idCodigoEstatus { get; set; }
		/// <summary>
		/// Código de Respuesta del Servicio
		/// </summary>
		[DataMember]
		public string codRespuesta { get; set; }
		/// <summary>
		/// Descripción de la respuesta del Servicio
		/// </summary>
		[DataMember]
		public string dsRespuesta { get; set; }
		/// <summary>
		/// Fecha y hora de procesamiento
		/// </summary>
		[DataMember]
		public string feProcesamiento { get; set; }
		/// <summary>
		/// Verificador para indicar si se incluye en procesamiento masivo(1) o ejecución directa(0)
		/// </summary>
		[DataMember]
		public bool esMasivo { get; set; }
		/// <summary>
		/// Identificador del usuario en el Directorio Activo
		/// </summary>
		[DataMember]
		public string CreadoPor { get; set; }
		/// <summary>
		/// Fecha de Creación
		/// </summary>
		[DataMember]
		public string feCreacion { get; set; }
		/// <summary>
		/// Descripción del código de tipo de proceso masivo
		/// </summary>
		[DataMember]
		public string nbCodigoTipoProcesoMasivo { get; set; }
		/// <summary>
		/// Descripción del código de tipo de estatus
		/// </summary>
		[DataMember]
		public string nbCodigoEstatus { get; set; }
		/// <summary>
		/// Descripción del codigo de Aplicación
		/// </summary>
		[DataMember]
		public string nbdAplicacion { get; set; }
		[DataMember]
		public string nbCreadoPor { get; set; }
        [DataMember]
        public string nbOrigen { get; set; }
        #endregion Properties

        #region Constructors
        /// <summary>
        /// Constructor de la Clase Registros para procesamiento por Lotes  
        /// </summary>
        public Ticket()
		{
			idTicket = string.Empty;
			codAplicacion = string.Empty;
			idCodigoTipoProcesoMasivo = 0;
			idRegistro = string.Empty;
			idCodigoEstatus = 0;
			codRespuesta = string.Empty;
			dsRespuesta = string.Empty;
			feProcesamiento = string.Empty;
			esMasivo = false;
			CreadoPor = string.Empty;
			feCreacion = string.Empty;
			nbdAplicacion = string.Empty;
			nbCodigoTipoProcesoMasivo = string.Empty;
			nbCodigoEstatus = string.Empty;
			nbCreadoPor = string.Empty;
            nbOrigen = string.Empty;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(Ticket rhs, Ticket.TicketComparer.TicketTipoComparacion which)
		{
			switch (which)
			{
			}
			return 0;
		}
		public class TicketComparer : IComparer<Ticket>
		{
			public enum TicketTipoComparacion
			{
				NULL
			}
			private TicketTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public TicketTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(Ticket lhs, Ticket rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(Ticket lhs, Ticket rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(Ticket e)
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
			if (!Convert.IsDBNull(reader["idTicket"])) idTicket = reader["idTicket"].ToString();
			if (!Convert.IsDBNull(reader["codAplicacion"])) codAplicacion = reader["codAplicacion"] as string;
			if (!Convert.IsDBNull(reader["idCodigoTipoProcesoMasivo"])) idCodigoTipoProcesoMasivo = Int32.Parse(reader["idCodigoTipoProcesoMasivo"].ToString());
			if (!Convert.IsDBNull(reader["idRegistro"])) idRegistro = reader["idRegistro"] as string;
			if (!Convert.IsDBNull(reader["idCodigoEstatus"])) idCodigoEstatus = Int32.Parse(reader["idCodigoEstatus"].ToString());
			if (!Convert.IsDBNull(reader["codRespuesta"])) codRespuesta = reader["codRespuesta"] as string;
			if (!Convert.IsDBNull(reader["dsRespuesta"])) dsRespuesta = reader["dsRespuesta"] as string;
			if (!Convert.IsDBNull(reader["feProcesamiento"])) feProcesamiento = DateTime.Parse(reader["feProcesamiento"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
			if (!Convert.IsDBNull(reader["esMasivo"])) esMasivo = (bool)reader["esMasivo"];
			if (!Convert.IsDBNull(reader["CreadoPor"])) CreadoPor = reader["CreadoPor"] as string;
			if (!Convert.IsDBNull(reader["feCreacion"])) feCreacion = DateTime.Parse(reader["feCreacion"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
			if (!Convert.IsDBNull(reader["nbCodigoTipoProcesoMasivo"])) nbCodigoTipoProcesoMasivo = reader["nbCodigoTipoProcesoMasivo"] as string;
			if (!Convert.IsDBNull(reader["nbCodigoEstatus"])) nbCodigoEstatus = reader["nbCodigoEstatus"] as string;
			if (!Convert.IsDBNull(reader["nbdAplicacion"])) nbdAplicacion = reader["nbdAplicacion"] as string;
			if (!Convert.IsDBNull(reader["nbCreadoPor"])) nbCreadoPor = reader["nbCreadoPor"] as string;
            if (!Convert.IsDBNull(reader["nbOrigen"])) nbOrigen = reader["nbOrigen"] as string;
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>
		public void SetDataTo(IDataParameterCollection pars)
		{
			if (idTicket != string.Empty) DataUtil.SetValue(pars, "@idTicket", idTicket);
			if (codAplicacion != string.Empty) DataUtil.SetValue(pars, "@codAplicacion", codAplicacion);
			if (idCodigoTipoProcesoMasivo != 0) DataUtil.SetValue(pars, "@idCodigoTipoProcesoMasivo", idCodigoTipoProcesoMasivo);
			if (idRegistro != string.Empty) DataUtil.SetValue(pars, "@idRegistro", idRegistro);
			if (idCodigoEstatus != 0) DataUtil.SetValue(pars, "@idCodigoEstatus", idCodigoEstatus);
			if (codRespuesta != string.Empty) DataUtil.SetValue(pars, "@codRespuesta", codRespuesta);
			if (dsRespuesta != string.Empty) DataUtil.SetValue(pars, "@dsRespuesta", dsRespuesta);
			if (feProcesamiento != string.Empty) DataUtil.SetValue(pars, "@feProcesamiento", DateTime.Parse(feProcesamiento).ToString("yyyyMMdd HH:mm:ss"));
			DataUtil.SetValue(pars, "@esMasivo", esMasivo);
			if (CreadoPor != string.Empty) DataUtil.SetValue(pars, "@CreadoPor", CreadoPor);
			if (feCreacion != string.Empty) DataUtil.SetValue(pars, "@feCreacion", DateTime.Parse(feCreacion).ToString("yyyyMMdd HH:mm:ss"));
            if (!string.IsNullOrWhiteSpace(nbOrigen)) DataUtil.SetValue(pars, "@nbOrigen", nbOrigen);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Ticket 
	/// </summary>
	[Serializable]
	[DataContract]
	public class TicketList : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Ticket> lstTicket { get; set; }
		#endregion Properties

		#region Constructors

		public TicketList()
		{
			lstTicket = new List<Ticket>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstTicket = new List<Ticket>();

			while (reader.Read())
			{
				Ticket oTicket = new Ticket();
				if (!Convert.IsDBNull(reader["idTicket"])) oTicket.idTicket = reader["idTicket"].ToString();
				if (!Convert.IsDBNull(reader["codAplicacion"])) oTicket.codAplicacion = reader["codAplicacion"] as string;
				if (!Convert.IsDBNull(reader["idCodigoTipoProcesoMasivo"])) oTicket.idCodigoTipoProcesoMasivo = Int32.Parse(reader["idCodigoTipoProcesoMasivo"].ToString());
				if (!Convert.IsDBNull(reader["idRegistro"])) oTicket.idRegistro = reader["idRegistro"] as string;
				if (!Convert.IsDBNull(reader["idCodigoEstatus"])) oTicket.idCodigoEstatus = Int32.Parse(reader["idCodigoEstatus"].ToString());
				if (!Convert.IsDBNull(reader["codRespuesta"])) oTicket.codRespuesta = reader["codRespuesta"] as string;
				if (!Convert.IsDBNull(reader["dsRespuesta"])) oTicket.dsRespuesta = reader["dsRespuesta"] as string;
				if (!Convert.IsDBNull(reader["feProcesamiento"])) oTicket.feProcesamiento = DateTime.Parse(reader["feProcesamiento"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
				if (!Convert.IsDBNull(reader["esMasivo"])) oTicket.esMasivo = (bool)reader["esMasivo"];
				if (!Convert.IsDBNull(reader["CreadoPor"])) oTicket.CreadoPor = reader["CreadoPor"] as string;
				if (!Convert.IsDBNull(reader["feCreacion"])) oTicket.feCreacion = DateTime.Parse(reader["feCreacion"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
				if (!Convert.IsDBNull(reader["nbCodigoTipoProcesoMasivo"])) oTicket.nbCodigoTipoProcesoMasivo = reader["nbCodigoTipoProcesoMasivo"] as string;
				if (!Convert.IsDBNull(reader["nbCodigoEstatus"])) oTicket.nbCodigoEstatus = reader["nbCodigoEstatus"] as string;
				if (!Convert.IsDBNull(reader["nbdAplicacion"])) oTicket.nbdAplicacion = reader["nbdAplicacion"] as string;
				if (!Convert.IsDBNull(reader["nbCreadoPor"])) oTicket.nbCreadoPor = reader["nbCreadoPor"] as string;
                if (!Convert.IsDBNull(reader["nbOrigen"])) oTicket.nbOrigen = reader["nbOrigen"] as string;

				lstTicket.Add(oTicket);
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