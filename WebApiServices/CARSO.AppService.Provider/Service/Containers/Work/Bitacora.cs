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
	/// Codigo de sistema
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Bitacora : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Clave unica de la bitacora
		/// </summary>
		[DataMember]
		public Int32 idBitacora { get; set; }
		/// <summary>
		/// Identificador del registro a procesar
		/// </summary>
		[DataMember]
		public string idTicket { get; set; }
		/// <summary>
		/// Fecha inicial de procesamiento
		/// </summary>
		[DataMember]
		public string fechaIni { get; set; }
		/// <summary>
		/// Fecha final de procesamiento
		/// </summary>
		[DataMember]
		public string fechaFin { get; set; }
		/// <summary>
		/// Codigo de sistema
		/// </summary>
		[DataMember]
		public string codSistema { get; set; }
		/// <summary>
		/// Codigo de sistema
		/// </summary>
		[DataMember]
		public string nbOperacion { get; set; }
		/// <summary>
		/// respuesta del proveedor
		/// </summary>
		[DataMember]
		public string dsRespuesta { get; set; }
		#endregion Properties

		#region Constructors
		/// <summary>
		/// Constructor de la Clase Codigo de sistema  
		/// </summary>
		public Bitacora()
		{
			idBitacora = 0;
			idTicket = string.Empty;
			fechaIni = string.Empty;
			fechaFin = string.Empty;
			codSistema = string.Empty;
			nbOperacion = string.Empty;
			dsRespuesta = string.Empty;   
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(Bitacora rhs, Bitacora.BitacoraComparer.BitacoraTipoComparacion which)
		{
			switch (which)
			{
			}
			return 0;
		}
		public class BitacoraComparer : IComparer<Bitacora>
		{
			public enum BitacoraTipoComparacion
			{
				NULL
			}
			private BitacoraTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public BitacoraTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(Bitacora lhs, Bitacora rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(Bitacora lhs, Bitacora rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(Bitacora e)
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
			if (!Convert.IsDBNull(reader["idBitacora"])) idBitacora = Int32.Parse(reader["idBitacora"].ToString());
			if (!Convert.IsDBNull(reader["idTicket"])) idTicket = reader["idTicket"] as string;
			if (!Convert.IsDBNull(reader["fechaIni"])) fechaIni = DateTime.Parse(reader["fechaIni"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
			if (!Convert.IsDBNull(reader["fechaFin"])) fechaFin = DateTime.Parse(reader["fechaFin"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
			if (!Convert.IsDBNull(reader["codSistema"])) codSistema = reader["codSistema"] as string;
			if (!Convert.IsDBNull(reader["nbOperacion"])) nbOperacion = reader["nbOperacion"] as string;
			if (!Convert.IsDBNull(reader["dsRespuesta"])) dsRespuesta = reader["dsRespuesta"] as string;
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>
		public void SetDataTo(IDataParameterCollection pars)
		{
			if (idBitacora != 0) DataUtil.SetValue(pars, "@idBitacora", idBitacora);
			if (idTicket != string.Empty) DataUtil.SetValue(pars, "@idTicket", idTicket);
			if (fechaIni != string.Empty) DataUtil.SetValue(pars, "@fechaIni", fechaIni);
			if (fechaFin != string.Empty) DataUtil.SetValue(pars, "@fechaFin", fechaFin);
			if (codSistema != string.Empty) DataUtil.SetValue(pars, "@codSistema", codSistema);
			if (nbOperacion != string.Empty) DataUtil.SetValue(pars, "@nbOperacion", nbOperacion);
			if (dsRespuesta != string.Empty) DataUtil.SetValue(pars, "@dsRespuesta", dsRespuesta);
			DataUtil.SetReturnedValue(pars, "@return_value");
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Bitacora 
	/// </summary>
	[Serializable]
	[DataContract]
	public class BitacoraList : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Bitacora> lstBitacora { get; set; }
		#endregion Properties

		#region Constructors
		public BitacoraList()
		{
			lstBitacora = new List<Bitacora>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstBitacora = new List<Bitacora>();
			while (reader.Read())
			{
				Bitacora oBitacora = new Bitacora();
				if (!Convert.IsDBNull(reader["idBitacora"])) oBitacora.idBitacora = Int32.Parse(reader["idBitacora"].ToString());
				if (!Convert.IsDBNull(reader["idTicket"])) oBitacora.idTicket = reader["idTicket"] as string;
				if (!Convert.IsDBNull(reader["fechaIni"])) oBitacora.fechaIni = DateTime.Parse(reader["fechaIni"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
				if (!Convert.IsDBNull(reader["fechaFin"])) oBitacora.fechaFin = DateTime.Parse(reader["fechaFin"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
				if (!Convert.IsDBNull(reader["codSistema"])) oBitacora.codSistema = reader["codSistema"] as string;
				if (!Convert.IsDBNull(reader["nbOperacion"])) oBitacora.nbOperacion = reader["nbOperacion"] as string;
				if (!Convert.IsDBNull(reader["dsRespuesta"])) oBitacora.dsRespuesta = reader["dsRespuesta"] as string;
				lstBitacora.Add(oBitacora);
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