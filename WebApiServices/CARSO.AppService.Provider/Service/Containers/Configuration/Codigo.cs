using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.LogLibrary.ServiceDataContainers;
using System.Threading.Tasks;

namespace CARSO.AppService.ServiceDataContainers
{
	/// <summary>
	/// Elementos de configuración de Catálogos
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Codigo : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Identificador del elemento de catálogo
		/// </summary>
		[DataMember]
		public Int32 idCodigo { get; set; }
		/// <summary>
		/// Catálogo al que corresponde el elemento
		/// </summary>
		[DataMember]
		public Int32 noCatalogo { get; set; }
		/// <summary>
		/// Nombre del elemento
		/// </summary>
		[DataMember]
		public string nbCodigo { get; set; }
		/// <summary>
		/// Descripción del elemento
		/// </summary>
		[DataMember]
		public string dsCodigo { get; set; }
		/// <summary>
		/// Descripción o código extra
		/// </summary>
		[DataMember]
		public string dsExtra { get; set; }
		/// <summary>
		/// Orden en el que se mostrará el elemento
		/// </summary>
		[DataMember]
		public Int16 noOrden { get; set; }
		/// <summary>
		/// Código de referencia externa
		/// </summary>
		[DataMember]
		public string rfExterna { get; set; }
		/// <summary>
		/// Verificador para indicar si el elemento es activo
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		/// <summary>
		/// Tipo de Operación al que aplica el elemento
		/// </summary>
		[DataMember]
		public Int32 idCodigoTipoOperacion { get; set; }
		/// <summary>
		/// Indicador si el elemento es utilizado para cualquier tipo de operación
		/// </summary>
		[DataMember]
		public bool esParaTodos { get; set; }
		/// <summary>
		/// Nombre del Catálogo
		/// </summary>
		[DataMember]
		public string nbCatalogo { get; set; }
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase Elementos de configuración de Catálogos  
		/// </summary>
		public Codigo()
		{
			idCodigo = 0;
			noCatalogo = 0;
			nbCodigo = string.Empty;
			dsCodigo = string.Empty;
			dsExtra = string.Empty;
			noOrden = 0;
			rfExterna = string.Empty;
			esActivo = false;
			idCodigoTipoOperacion = 0;
			esParaTodos = false;
			nbCatalogo = string.Empty;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(Codigo rhs, Codigo.CodigoComparer.CodigoTipoComparacion which)
		{
			switch (which)
			{
				case CodigoComparer.CodigoTipoComparacion.noCatalogo: return noCatalogo.CompareTo(rhs.noCatalogo);
				case CodigoComparer.CodigoTipoComparacion.nbCodigo: return nbCodigo.CompareTo(rhs.nbCodigo);
				case CodigoComparer.CodigoTipoComparacion.dsExtra: return dsExtra.CompareTo(rhs.dsExtra);
				case CodigoComparer.CodigoTipoComparacion.noOrden: return noOrden.CompareTo(rhs.noOrden);
				case CodigoComparer.CodigoTipoComparacion.rfExterna: return rfExterna.CompareTo(rhs.rfExterna);
				case CodigoComparer.CodigoTipoComparacion.esActivo: return esActivo.CompareTo(rhs.esActivo);
				case CodigoComparer.CodigoTipoComparacion.nbCatalogo: return nbCatalogo.CompareTo(rhs.nbCatalogo);
			}
			return 0;
		}
		public class CodigoComparer : IComparer<Codigo>
		{
			public enum CodigoTipoComparacion
			{
				noCatalogo,
				nbCodigo,
				dsExtra,
				noOrden,
				rfExterna,
				esActivo,
				nbCatalogo,
				NULL
			}
			private CodigoTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public CodigoTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(Codigo lhs, Codigo rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(Codigo lhs, Codigo rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(Codigo e)
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
			if (!Convert.IsDBNull(reader["idCodigo"])) idCodigo = Int32.Parse(reader["idCodigo"].ToString());
			if (!Convert.IsDBNull(reader["noCatalogo"])) noCatalogo = Int32.Parse(reader["noCatalogo"].ToString());
			if (!Convert.IsDBNull(reader["nbCodigo"])) nbCodigo = reader["nbCodigo"] as string;
			if (!Convert.IsDBNull(reader["dsCodigo"])) dsCodigo = reader["dsCodigo"] as string;
			if (!Convert.IsDBNull(reader["dsExtra"])) dsExtra = reader["dsExtra"] as string;
			if (!Convert.IsDBNull(reader["noOrden"])) noOrden = Int16.Parse(reader["noOrden"].ToString());
			if (!Convert.IsDBNull(reader["rfExterna"])) rfExterna = reader["rfExterna"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) esActivo = (bool)reader["esActivo"];
			if (!Convert.IsDBNull(reader["idCodigoTipoOperacion"])) idCodigoTipoOperacion = Int32.Parse(reader["idCodigoTipoOperacion"].ToString());
			if (!Convert.IsDBNull(reader["esParaTodos"])) esParaTodos = (bool)reader["esParaTodos"];
			if (!Convert.IsDBNull(reader["nbCatalogo"])) nbCatalogo = reader["nbCatalogo"] as string;
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (idCodigo != 0) DataUtil.SetValue(pars, "@idCodigo", idCodigo);
			if (noCatalogo != 0) DataUtil.SetValue(pars, "@noCatalogo", noCatalogo);
			if (nbCodigo != string.Empty) DataUtil.SetValue(pars, "@nbCodigo", nbCodigo);
			if (dsCodigo != string.Empty) DataUtil.SetValue(pars, "@dsCodigo", dsCodigo);
			if (dsExtra != string.Empty) DataUtil.SetValue(pars, "@dsExtra", dsExtra);
			if (noOrden != 0) DataUtil.SetValue(pars, "@noOrden", noOrden);
			if (rfExterna != string.Empty) DataUtil.SetValue(pars, "@rfExterna", rfExterna);
			DataUtil.SetValue(pars, "@esActivo", esActivo);
			if (idCodigoTipoOperacion != 0) DataUtil.SetValue(pars, "@idCodigoTipoOperacion", idCodigoTipoOperacion);
			DataUtil.SetValue(pars, "@esParaTodos", esParaTodos);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Codigo 
	/// </summary>
	[Serializable]
	[DataContract]
	public class CodigoList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Codigo> lstCodigo { get; set; }
		#endregion Properties

		#region Constructors
		public CodigoList()
		{
			lstCodigo = new List<Codigo>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstCodigo = new List<Codigo>();
			while (reader.Read())
			{
				Codigo oCodigo = new Codigo();
				if (!Convert.IsDBNull(reader["idCodigo"])) oCodigo.idCodigo = Int32.Parse(reader["idCodigo"].ToString());
				if (!Convert.IsDBNull(reader["noCatalogo"])) oCodigo.noCatalogo = Int32.Parse(reader["noCatalogo"].ToString());
				if (!Convert.IsDBNull(reader["nbCodigo"])) oCodigo.nbCodigo = reader["nbCodigo"] as string;
				if (!Convert.IsDBNull(reader["dsCodigo"])) oCodigo.dsCodigo = reader["dsCodigo"] as string;
				if (!Convert.IsDBNull(reader["dsExtra"])) oCodigo.dsExtra = reader["dsExtra"] as string;
				if (!Convert.IsDBNull(reader["noOrden"])) oCodigo.noOrden = Int16.Parse(reader["noOrden"].ToString());
				if (!Convert.IsDBNull(reader["rfExterna"])) oCodigo.rfExterna = reader["rfExterna"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oCodigo.esActivo = (bool)reader["esActivo"];
				if (!Convert.IsDBNull(reader["idCodigoTipoOperacion"])) oCodigo.idCodigoTipoOperacion = Int32.Parse(reader["idCodigoTipoOperacion"].ToString());
				if (!Convert.IsDBNull(reader["esParaTodos"])) oCodigo.esParaTodos = (bool)reader["esParaTodos"];
				if (!Convert.IsDBNull(reader["nbCatalogo"])) oCodigo.nbCatalogo = reader["nbCatalogo"] as string;
				lstCodigo.Add(oCodigo);
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
