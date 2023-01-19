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
	/// TipoPosicion
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class TipoPosicion : IDataContainer
	{
		#region Properties
		/// </summary>
		[DataMember]
		public string codTipoPosicion { get; set; }
		/// </summary>
		[DataMember]
		public string nbTipoPosicion { get; set; }
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase TipoPosicion  
		/// </summary>
		public TipoPosicion()
		{
			this.codTipoPosicion = string.Empty;
			this.nbTipoPosicion = string.Empty;
			this.esActivo = false;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(TipoPosicion rhs, TipoPosicion.TipoPosicionComparer.TipoPosicionTipoComparacion which)
		{
			switch (which)
			{
				case TipoPosicionComparer.TipoPosicionTipoComparacion.codTipoPosicion: return this.codTipoPosicion.CompareTo(rhs.codTipoPosicion);
				case TipoPosicionComparer.TipoPosicionTipoComparacion.nbTipoPosicion: return this.nbTipoPosicion.CompareTo(rhs.nbTipoPosicion);
				case TipoPosicionComparer.TipoPosicionTipoComparacion.esActivo: return this.esActivo.CompareTo(rhs.esActivo);
			}
			return 0;
		}
		public class TipoPosicionComparer : IComparer<TipoPosicion>
		{
			public enum TipoPosicionTipoComparacion
			{
				codTipoPosicion,
				nbTipoPosicion,
				esActivo,
				NULL
			}
			private TipoPosicionTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public TipoPosicionTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(TipoPosicion lhs, TipoPosicion rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(TipoPosicion lhs, TipoPosicion rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(TipoPosicion e)
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
			if (!Convert.IsDBNull(reader["codTipoPosicion"])) this.codTipoPosicion = reader["codTipoPosicion"] as string;
			if (!Convert.IsDBNull(reader["nbTipoPosicion"])) this.nbTipoPosicion = reader["nbTipoPosicion"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = (bool)reader["esActivo"];
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.codTipoPosicion != string.Empty) DataUtil.SetValue(pars, "@codTipoPosicion", this.codTipoPosicion);
			if (this.nbTipoPosicion != string.Empty) DataUtil.SetValue(pars, "@nbTipoPosicion", this.nbTipoPosicion);
			DataUtil.SetValue(pars, "@esActivo", this.esActivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de TipoPosicion 
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class TipoPosicionList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<TipoPosicion> lstTipoPosicion { get; set; }
		#endregion Properties

		#region Constructors
		public TipoPosicionList()
		{
			lstTipoPosicion = new List<TipoPosicion>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstTipoPosicion = new List<TipoPosicion>();
			while (reader.Read())
			{
				TipoPosicion oTipoPosicion = new TipoPosicion();
				if (!Convert.IsDBNull(reader["codTipoPosicion"])) oTipoPosicion.codTipoPosicion = reader["codTipoPosicion"] as string;
				if (!Convert.IsDBNull(reader["nbTipoPosicion"])) oTipoPosicion.nbTipoPosicion = reader["nbTipoPosicion"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oTipoPosicion.esActivo = (bool)reader["esActivo"];
				this.lstTipoPosicion.Add(oTipoPosicion);
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
