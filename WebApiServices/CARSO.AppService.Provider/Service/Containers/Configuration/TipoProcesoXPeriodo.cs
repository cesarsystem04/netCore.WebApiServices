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
	/// Tipo de Proceso por Periodo Transaccional
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class TipoProcesoXPeriodo : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Identificador del Periodo
		/// </summary>
		[DataMember]
		public Int32 idPeriodo { get; set; }
		/// <summary>
		/// Identificador del elemento de catálogo para el Tipo de Proceso Masivo
		/// </summary>
		[DataMember]
		public Int32 idCodigoTipoProcesoMasivo { get; set; }
		/// <summary>
		/// Tipo de Proceso Masivo
		/// </summary>
		[DataMember]
		public string nbCodigoTipoProcesoMasivo { get; set; }
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase Tipo de Proceso por Periodo Transaccional  
		/// </summary>
		public TipoProcesoXPeriodo()
		{
			idPeriodo = 0;
			idCodigoTipoProcesoMasivo = 0;
			nbCodigoTipoProcesoMasivo = string.Empty;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(TipoProcesoXPeriodo rhs, TipoProcesoXPeriodo.TipoProcesoXPeriodoComparer.TipoProcesoXPeriodoTipoComparacion which)
		{
			switch (which)
			{
				case TipoProcesoXPeriodoComparer.TipoProcesoXPeriodoTipoComparacion.idPeriodo: return idPeriodo.CompareTo(rhs.idPeriodo);
				case TipoProcesoXPeriodoComparer.TipoProcesoXPeriodoTipoComparacion.idCodigoTipoProcesoMasivo: return idCodigoTipoProcesoMasivo.CompareTo(rhs.idCodigoTipoProcesoMasivo);
				case TipoProcesoXPeriodoComparer.TipoProcesoXPeriodoTipoComparacion.nbCodigoTipoProcesoMasivo: return nbCodigoTipoProcesoMasivo.CompareTo(rhs.nbCodigoTipoProcesoMasivo);
			}
			return 0;
		}
		public class TipoProcesoXPeriodoComparer : IComparer<TipoProcesoXPeriodo>
		{
			public enum TipoProcesoXPeriodoTipoComparacion
			{
				idPeriodo,
				idCodigoTipoProcesoMasivo,
				nbCodigoTipoProcesoMasivo,
				nbPeriodo,
				NULL
			}
			private TipoProcesoXPeriodoTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public TipoProcesoXPeriodoTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(TipoProcesoXPeriodo lhs, TipoProcesoXPeriodo rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(TipoProcesoXPeriodo lhs, TipoProcesoXPeriodo rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(TipoProcesoXPeriodo e)
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
			if (!Convert.IsDBNull(reader["idCodigoTipoProcesoMasivo"])) idCodigoTipoProcesoMasivo = Int32.Parse(reader["idCodigoTipoProcesoMasivo"].ToString());
			if (!Convert.IsDBNull(reader["nbCodigoTipoProcesoMasivo"])) nbCodigoTipoProcesoMasivo = reader["nbCodigoTipoProcesoMasivo"] as string;
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (idPeriodo != 0) DataUtil.SetValue(pars, "@idPeriodo", idPeriodo);
			if (idCodigoTipoProcesoMasivo != 0) DataUtil.SetValue(pars, "@idCodigoTipoProcesoMasivo", idCodigoTipoProcesoMasivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de TipoProcesoXPeriodo 
	/// </summary>
	[Serializable]
	[DataContract]
	public class TipoProcesoXPeriodoList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<TipoProcesoXPeriodo> lstTipoProcesoXPeriodo { get; set; }
		#endregion Properties

		#region Constructors
		public TipoProcesoXPeriodoList()
		{
			lstTipoProcesoXPeriodo = new List<TipoProcesoXPeriodo>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstTipoProcesoXPeriodo = new List<TipoProcesoXPeriodo>();
			while (reader.Read())
			{
				TipoProcesoXPeriodo oTipoProcesoXPeriodo = new TipoProcesoXPeriodo();
				if (!Convert.IsDBNull(reader["idPeriodo"])) oTipoProcesoXPeriodo.idPeriodo = Int32.Parse(reader["idPeriodo"].ToString());
				if (!Convert.IsDBNull(reader["idCodigoTipoProcesoMasivo"])) oTipoProcesoXPeriodo.idCodigoTipoProcesoMasivo = Int32.Parse(reader["idCodigoTipoProcesoMasivo"].ToString());
				if (!Convert.IsDBNull(reader["nbCodigoTipoProcesoMasivo"])) oTipoProcesoXPeriodo.nbCodigoTipoProcesoMasivo = reader["nbCodigoTipoProcesoMasivo"] as string;
				lstTipoProcesoXPeriodo.Add(oTipoProcesoXPeriodo);
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
