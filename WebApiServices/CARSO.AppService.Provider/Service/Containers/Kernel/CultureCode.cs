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
	/// Atributo
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class CultureCode : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Nombre de Cultura
		/// </summary>
		[DataMember]
		public string nbLanguageCulture { get; set; }
		/// <summary>
		/// Descripción mostrada
		/// </summary>
		[DataMember]
		public string dsDisplayName { get; set; }
		/// <summary>
		/// Código de Cultura
		/// </summary>
		[DataMember]
		public string codCulture { get; set; }
		/// <summary>
		/// valISO639x
		/// </summary>
		[DataMember]
		public string valISO639x { get; set; }
		/// <summary>
		/// Verificador para indicar si el código de Cultura es Activo
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		#endregion Properties

		#region Constructors
		/// <summary>
		/// Constructor de la Clase CultureCode 
		/// </summary>
		public CultureCode()
		{
			nbLanguageCulture = string.Empty;
			dsDisplayName = string.Empty;
			codCulture = string.Empty;
			valISO639x = string.Empty;
			esActivo = false;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(CultureCode rhs, CultureCode.CultureCodeComparer.CultureCodeTipoComparacion which)
		{
			switch (which)
			{
				case CultureCodeComparer.CultureCodeTipoComparacion.nbLanguageCulture: return nbLanguageCulture.CompareTo(rhs.nbLanguageCulture);
				case CultureCodeComparer.CultureCodeTipoComparacion.dsDisplayName: return dsDisplayName.CompareTo(rhs.dsDisplayName);
				case CultureCodeComparer.CultureCodeTipoComparacion.codCulture: return codCulture.CompareTo(rhs.codCulture);
				case CultureCodeComparer.CultureCodeTipoComparacion.valISO639x: return valISO639x.CompareTo(rhs.valISO639x);
				case CultureCodeComparer.CultureCodeTipoComparacion.esActivo: return esActivo.CompareTo(rhs.esActivo);
			}
			return 0;
		}

		public class CultureCodeComparer : IComparer<CultureCode>
		{
			public enum CultureCodeTipoComparacion
			{
				nbLanguageCulture,
				dsDisplayName,
				codCulture,
				valISO639x,
				esActivo,
				NULL
			}

			private CultureCodeTipoComparacion _whichComparison;

			private TipoOrdenamiento _sortDirection;

			public CultureCodeTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(CultureCode lhs, CultureCode rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(CultureCode lhs, CultureCode rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(CultureCode e)
			{
				return e.GetHashCode();
			}
			[DataMember]
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
			if (!Convert.IsDBNull(reader["nbLanguageCulture"])) nbLanguageCulture = reader["nbLanguageCulture"] as string;
			if (!Convert.IsDBNull(reader["dsDisplayName"])) dsDisplayName = reader["dsDisplayName"] as string;
			if (!Convert.IsDBNull(reader["codCulture"])) codCulture = reader["codCulture"] as string;
			if (!Convert.IsDBNull(reader["valISO639x"])) valISO639x = reader["valISO639x"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) esActivo = (bool)reader["esActivo"];
		}
		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>
		public void SetDataTo(IDataParameterCollection pars)
		{
			if (nbLanguageCulture != string.Empty) DataUtil.SetValue(pars, "@nbLanguageCulture", nbLanguageCulture);
			if (dsDisplayName != string.Empty) DataUtil.SetValue(pars, "@dsDisplayName", dsDisplayName);
			if (codCulture != string.Empty) DataUtil.SetValue(pars, "@codCulture", codCulture);
			if (valISO639x != string.Empty) DataUtil.SetValue(pars, "@valISO639x", valISO639x);
			DataUtil.SetValue(pars, "@esActivo", esActivo);
			DataUtil.SetReturnedValue(pars, "@return_value");
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de CultureCode
	/// </summary>
	[Serializable]
	[DataContract]
	public class CultureCodeList : IDataContainer
	{
		#region Attributes
		/// <summary>
		/// Colección con elementos de CultureCode
		/// </summary>
		[DataMember]
		public List<CultureCode> lstCultureCode { get; set; }
		#endregion

		#region Constructors
		public CultureCodeList()
		{
			lstCultureCode = new List<CultureCode>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstCultureCode = new List<CultureCode>();

			while (reader.Read())
			{
				CultureCode oCultureCode = new CultureCode();
				if (!Convert.IsDBNull(reader["nbLanguageCulture"])) oCultureCode.nbLanguageCulture = reader["nbLanguageCulture"] as string;
				if (!Convert.IsDBNull(reader["dsDisplayName"])) oCultureCode.dsDisplayName = reader["dsDisplayName"] as string;
				if (!Convert.IsDBNull(reader["codCulture"])) oCultureCode.codCulture = reader["codCulture"] as string;
				if (!Convert.IsDBNull(reader["valISO639x"])) oCultureCode.valISO639x = reader["valISO639x"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oCultureCode.esActivo = (bool)reader["esActivo"];
				lstCultureCode.Add(oCultureCode);
			}
		}
		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>
		public void SetDataTo(IDataParameterCollection pars)
		{
			throw new NotImplementedException();
		}
		#endregion IDataContainer Members
	}
}
