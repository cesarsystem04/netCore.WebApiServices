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
	/// Sociedad
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Sociedad : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Código SAP de la Sociedad
		/// </summary>
		[DataMember]
		public string codSociedad { get; set; }
		/// <summary>
		/// Nombre de la Sociedad
		/// </summary>
		[DataMember]
		public string nbSociedad { get; set; }
		/// <summary>
		/// Activo?
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		/// <summary>
		/// Descripción de sociedad [cód. - nombre]
		/// </summary>
		[DataMember]
		public string dsSociedad
		{
			get { return string.Format("{0} - {1}", codSociedad, nbSociedad); }
			set { }
		}
		/// <summary>
		/// Razón Social de la sociedad
		/// </summary>
		[DataMember]
		public string dsRazonSocial { get; set; }
		/// <summary>
		/// Código SAP del País
		/// </summary>
		[DataMember]
		public string codPais { get; set; }
		#endregion Properties

		#region Constructors
		/// <summary>
		/// Constructor de la Clase Sociedad  
		/// </summary>
		public Sociedad()
		{
			this.codSociedad = string.Empty;
			this.nbSociedad = string.Empty;
			this.esActivo = false;
			this.dsRazonSocial = string.Empty;
			this.codPais = string.Empty;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(Sociedad rhs, Sociedad.SociedadComparer.SociedadTipoComparacion which)
		{
			switch (which)
			{
				case SociedadComparer.SociedadTipoComparacion.codSociedad: return this.codSociedad.CompareTo(rhs.codSociedad);
				case SociedadComparer.SociedadTipoComparacion.nbSociedad: return this.nbSociedad.CompareTo(rhs.nbSociedad);
				case SociedadComparer.SociedadTipoComparacion.esActivo: return this.esActivo.CompareTo(rhs.esActivo);
			}
			return 0;
		}
		public class SociedadComparer : IComparer<Sociedad>
		{
			public enum SociedadTipoComparacion
			{
				codSociedad,
				nbSociedad,
				esActivo,
				NULL
			}
			private SociedadTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public SociedadTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(Sociedad lhs, Sociedad rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(Sociedad lhs, Sociedad rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(Sociedad e)
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
			if (!Convert.IsDBNull(reader["codSociedad"])) this.codSociedad = reader["codSociedad"] as string;
			if (!Convert.IsDBNull(reader["nbSociedad"])) this.nbSociedad = reader["nbSociedad"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = (bool)reader["esActivo"];
			if (!Convert.IsDBNull(reader["dsRazonSocial"])) this.dsRazonSocial = reader["dsRazonSocial"] as string;
			if (!Convert.IsDBNull(reader["codPais"])) this.codPais = reader["codPais"] as string;
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.codSociedad != string.Empty) DataUtil.SetValue(pars, "@codSociedad", this.codSociedad);
			if (this.nbSociedad != string.Empty) DataUtil.SetValue(pars, "@nbSociedad", this.nbSociedad);
			DataUtil.SetValue(pars, "@esActivo", this.esActivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Sociedad 
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class SociedadList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Sociedad> lstSociedad { get; set; }
		#endregion Properties

		#region Constructors
		public SociedadList()
		{
			lstSociedad = new List<Sociedad>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstSociedad = new List<Sociedad>();
			while (reader.Read())
			{
				Sociedad oSociedad = new Sociedad();
				if (!Convert.IsDBNull(reader["codSociedad"])) oSociedad.codSociedad = reader["codSociedad"] as string;
				if (!Convert.IsDBNull(reader["nbSociedad"])) oSociedad.nbSociedad = reader["nbSociedad"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oSociedad.esActivo = (bool)reader["esActivo"];
				if (!Convert.IsDBNull(reader["dsRazonSocial"])) oSociedad.dsRazonSocial = reader["dsRazonSocial"] as string;
				if (!Convert.IsDBNull(reader["codPais"])) oSociedad.codPais = reader["codPais"] as string;
				this.lstSociedad.Add(oSociedad);
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

