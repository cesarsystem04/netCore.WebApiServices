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
	/// CentroCosto
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class CentroCosto : IDataContainer
	{
		#region Properties
		/// </summary>
		[DataMember]
		public string codCentroCosto { get; set; }
		/// </summary>
		[DataMember]
		public string nbCentroCosto { get; set; }
		/// </summary>
		[DataMember]
		public string feFinValidez { get; set; }
		/// </summary>
		///  [DataMember]
		public string codSociedad { get; set; }
		/// </summary>
		[DataMember]
		public string nbSociedad { get; set; }
		[DataMember]
		public bool esActivo { get; set; }
		[DataMember]
		public string dsCentroCosto
		{
			get { return string.Format("{0} - {1}", codCentroCosto, nbCentroCosto); }
			set { }
		}
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase CentroCosto  
		/// </summary>
		public CentroCosto()
		{
			this.codCentroCosto = string.Empty;
			this.nbCentroCosto = string.Empty;
			this.feFinValidez = string.Empty;
			this.codSociedad = string.Empty;
			this.nbSociedad = string.Empty;
			this.esActivo = false;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(CentroCosto rhs, CentroCosto.CentroCostoComparer.CentroCostoTipoComparacion which)
		{
			switch (which)
			{
				case CentroCostoComparer.CentroCostoTipoComparacion.codCentroCosto: return this.codCentroCosto.CompareTo(rhs.codCentroCosto);
				case CentroCostoComparer.CentroCostoTipoComparacion.nbCentroCosto: return this.nbCentroCosto.CompareTo(rhs.nbCentroCosto);
				case CentroCostoComparer.CentroCostoTipoComparacion.feFinValidez: return this.feFinValidez.CompareTo(rhs.feFinValidez);
				case CentroCostoComparer.CentroCostoTipoComparacion.esActivo: return this.esActivo.CompareTo(rhs.esActivo);
			}
			return 0;
		}
		public class CentroCostoComparer : IComparer<CentroCosto>
		{
			public enum CentroCostoTipoComparacion
			{
				codCentroCosto,
				nbCentroCosto,
				feFinValidez,
				esActivo,
				NULL
			}
			private CentroCostoTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public CentroCostoTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(CentroCosto lhs, CentroCosto rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(CentroCosto lhs, CentroCosto rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(CentroCosto e)
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
			if (!Convert.IsDBNull(reader["codCentroCosto"])) this.codCentroCosto = reader["codCentroCosto"] as string;
			if (!Convert.IsDBNull(reader["nbCentroCosto"])) this.nbCentroCosto = reader["nbCentroCosto"] as string;
			if (!Convert.IsDBNull(reader["feFinValidez"])) this.feFinValidez = reader["feFinValidez"].ToString();
			if (!Convert.IsDBNull(reader["codSociedad"])) this.codSociedad = reader["codSociedad"] as string;
			if (!Convert.IsDBNull(reader["nbSociedad"])) this.nbSociedad = reader["nbSociedad"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = (bool)reader["esActivo"];
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.codCentroCosto != string.Empty) DataUtil.SetValue(pars, "@codCentroCosto", this.codCentroCosto);
			if (this.codSociedad != string.Empty) DataUtil.SetValue(pars, "@codSociedad", this.codSociedad);
			if (this.nbCentroCosto != string.Empty) DataUtil.SetValue(pars, "@nbCentroCosto", this.nbCentroCosto);
			if (this.feFinValidez != string.Empty) DataUtil.SetValue(pars, "@feFinValidez", this.feFinValidez);
			DataUtil.SetValue(pars, "@esActivo", this.esActivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de CentroCosto 
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class CentroCostoList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<CentroCosto> lstCentroCosto { get; set; }
		#endregion Properties

		#region Constructors
		public CentroCostoList()
		{
			lstCentroCosto = new List<CentroCosto>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstCentroCosto = new List<CentroCosto>();
			while (reader.Read())
			{
				CentroCosto oCentroCosto = new CentroCosto();
				if (!Convert.IsDBNull(reader["codCentroCosto"])) oCentroCosto.codCentroCosto = reader["codCentroCosto"] as string;
				if (!Convert.IsDBNull(reader["nbCentroCosto"])) oCentroCosto.nbCentroCosto = reader["nbCentroCosto"] as string;
				if (!Convert.IsDBNull(reader["feFinValidez"])) oCentroCosto.feFinValidez = reader["feFinValidez"].ToString();
				if (!Convert.IsDBNull(reader["codSociedad"])) oCentroCosto.codSociedad = reader["codSociedad"] as string;
				if (!Convert.IsDBNull(reader["nbSociedad"])) oCentroCosto.nbSociedad = reader["nbSociedad"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oCentroCosto.esActivo = (bool)reader["esActivo"];
				this.lstCentroCosto.Add(oCentroCosto);
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
