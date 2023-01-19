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
	/// Etiqueta por Idioma
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class EtiquetaXCultura : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Código de la Etiqueta
		/// </summary>
		[DataMember]
		public string codEtiqueta { get; set; }
		/// <summary>
		/// Código del Conjunto de Etiquetas
		/// </summary>
		[DataMember]
		public string codConjunto { get; set; }
		/// <summary>
		/// Código de la Aplicación
		/// </summary>
		[DataMember]
		public string codAplicacion { get; set; }
		/// <summary>
		/// Identificador de la cultura del lenguaje
		/// </summary>
		[DataMember]
		public string nbLanguageCulture { get; set; }
		/// <summary>
		/// Etiqueta
		/// </summary>
		[DataMember]
		public string nbEtiqueta { get; set; }
		/// <summary>
		/// Descripción opcional de la etiqueta
		/// </summary>
		[DataMember]
		public string dsEtiqueta { get; set; }

		[DataMember]

		public string nbConjunto { get; set; }

		[DataMember]
		public string dsDisplayName { get; set; }
		#endregion Properties

		#region Constructors
		/// <summary>
		/// Constructor de la Clase Etiqueta por Idioma  
		/// </summary>
		public EtiquetaXCultura()
		{
			codEtiqueta = string.Empty;
			codConjunto = string.Empty;
			codAplicacion = string.Empty;
			nbLanguageCulture = string.Empty;
			nbEtiqueta = string.Empty;
			dsEtiqueta = string.Empty;
			nbLanguageCulture = string.Empty;

			nbConjunto = string.Empty;
			dsDisplayName = string.Empty;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(EtiquetaXCultura rhs, EtiquetaXCultura.EtiquetaXCulturaComparer.EtiquetaXCulturaTipoComparacion which)
		{
			switch (which)
			{
			}
			return 0;
		}
		public class EtiquetaXCulturaComparer : IComparer<EtiquetaXCultura>
		{
			public enum EtiquetaXCulturaTipoComparacion
			{
				codEtiqueta,
				codConjunto,
				codAplicacion,
				nbLanguageCulture,
				nbEtiqueta,
				dsEtiqueta,
				nbConjunto,
				dsDisplayName,
				NULL
			}
			private EtiquetaXCulturaTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public EtiquetaXCulturaTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(EtiquetaXCultura lhs, EtiquetaXCultura rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(EtiquetaXCultura lhs, EtiquetaXCultura rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(EtiquetaXCultura e)
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
			if (!Convert.IsDBNull(reader["codEtiqueta"])) codEtiqueta = reader["codEtiqueta"] as string;
			if (!Convert.IsDBNull(reader["codConjunto"])) codConjunto = reader["codConjunto"] as string;
			if (!Convert.IsDBNull(reader["codAplicacion"])) codAplicacion = reader["codAplicacion"] as string;
			if (!Convert.IsDBNull(reader["nbLanguageCulture"])) nbLanguageCulture = reader["nbLanguageCulture"] as string;
			if (!Convert.IsDBNull(reader["nbEtiqueta"])) nbEtiqueta = reader["nbEtiqueta"] as string;
			if (!Convert.IsDBNull(reader["dsEtiqueta"])) dsEtiqueta = reader["dsEtiqueta"] as string;
			if (!Convert.IsDBNull(reader["nbLanguageCulture"])) nbLanguageCulture = reader["nbLanguageCulture"] as string;

			if (!Convert.IsDBNull(reader["nbConjunto"])) nbConjunto = reader["nbConjunto"] as string;
			if (!Convert.IsDBNull(reader["dsDisplayName"])) dsDisplayName = reader["dsDisplayName"] as string;

		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (codEtiqueta != string.Empty) DataUtil.SetValue(pars, "@codEtiqueta", codEtiqueta);
			if (codConjunto != string.Empty) DataUtil.SetValue(pars, "@codConjunto", codConjunto);
			if (codAplicacion != string.Empty) DataUtil.SetValue(pars, "@codAplicacion", codAplicacion);
			if (nbLanguageCulture != string.Empty) DataUtil.SetValue(pars, "@nbLanguageCulture", nbLanguageCulture);
			if (nbEtiqueta != string.Empty) DataUtil.SetValue(pars, "@nbEtiqueta", nbEtiqueta);
			if (dsEtiqueta != string.Empty) DataUtil.SetValue(pars, "@dsEtiqueta", dsEtiqueta);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de EtiquetaXCultura 
	/// </summary>
	[Serializable]
	[DataContract]
	public class EtiquetaXCulturaList : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<EtiquetaXCultura> lstEtiquetaXCultura { get; set; }
		#endregion Properties

		#region Constructors
		public EtiquetaXCulturaList()
		{
			lstEtiquetaXCultura = new List<EtiquetaXCultura>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstEtiquetaXCultura = new List<EtiquetaXCultura>();
			while (reader.Read())
			{
				EtiquetaXCultura oEtiquetaXCultura = new EtiquetaXCultura();
				if (!Convert.IsDBNull(reader["codEtiqueta"])) oEtiquetaXCultura.codEtiqueta = reader["codEtiqueta"] as string;
				if (!Convert.IsDBNull(reader["codConjunto"])) oEtiquetaXCultura.codConjunto = reader["codConjunto"] as string;
				if (!Convert.IsDBNull(reader["codAplicacion"])) oEtiquetaXCultura.codAplicacion = reader["codAplicacion"] as string;
				if (!Convert.IsDBNull(reader["nbLanguageCulture"])) oEtiquetaXCultura.nbLanguageCulture = reader["nbLanguageCulture"] as string;
				if (!Convert.IsDBNull(reader["nbEtiqueta"])) oEtiquetaXCultura.nbEtiqueta = reader["nbEtiqueta"] as string;
				if (!Convert.IsDBNull(reader["dsEtiqueta"])) oEtiquetaXCultura.dsEtiqueta = reader["dsEtiqueta"] as string;
				if (!Convert.IsDBNull(reader["nbLanguageCulture"])) oEtiquetaXCultura.nbLanguageCulture = reader["nbLanguageCulture"] as string;
			
				if (!Convert.IsDBNull(reader["nbConjunto"])) oEtiquetaXCultura.nbConjunto = reader["nbConjunto"] as string;
				if (!Convert.IsDBNull(reader["dsDisplayName"])) oEtiquetaXCultura.dsDisplayName = reader["dsDisplayName"] as string;
				lstEtiquetaXCultura.Add(oEtiquetaXCultura);
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