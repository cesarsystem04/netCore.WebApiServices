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
	/// Conjunto de Etiquetass
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class EtiquetaConjunto : IDataContainer
	{
		#region Properties
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
		/// Nombre del Conjunto de Etiquetas
		/// </summary>
		[DataMember]
		public string nbConjunto { get; set; }
		/// <summary>
		/// Nombre de la Aplicación
		/// </summary>
		[DataMember]
		public string nbdAplicacion { get; set; }
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase Conjunto de Etiquetass  
		/// </summary>
		public EtiquetaConjunto()
		{
			codConjunto = string.Empty;
			codAplicacion = string.Empty;
			nbConjunto = string.Empty;
			nbdAplicacion = string.Empty;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(EtiquetaConjunto rhs, EtiquetaConjunto.EtiquetaConjuntoComparer.EtiquetaConjuntoTipoComparacion which)
		{
			switch (which)
			{
			}
			return 0;
		}
		public class EtiquetaConjuntoComparer : IComparer<EtiquetaConjunto>
		{
			public enum EtiquetaConjuntoTipoComparacion
			{
				codConjunto,
				codAplicacion,
				nbConjunto,
				nbdAplicacion,
				NULL
			}
			private EtiquetaConjuntoTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public EtiquetaConjuntoTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(EtiquetaConjunto lhs, EtiquetaConjunto rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(EtiquetaConjunto lhs, EtiquetaConjunto rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(EtiquetaConjunto e)
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
			if (!Convert.IsDBNull(reader["codConjunto"])) codConjunto = reader["codConjunto"] as string;
			if (!Convert.IsDBNull(reader["codAplicacion"])) codAplicacion = reader["codAplicacion"] as string;
			if (!Convert.IsDBNull(reader["nbConjunto"])) nbConjunto = reader["nbConjunto"] as string;
			if (!Convert.IsDBNull(reader["nbdAplicacion"])) nbdAplicacion = reader["nbdAplicacion"] as string;
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (codConjunto != string.Empty) DataUtil.SetValue(pars, "@codConjunto", codConjunto);
			if (codAplicacion != string.Empty) DataUtil.SetValue(pars, "@codAplicacion", codAplicacion);
			if (nbConjunto != string.Empty) DataUtil.SetValue(pars, "@nbConjunto", nbConjunto);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de EtiquetaConjunto 
	/// </summary>
	[Serializable]
	[DataContract]
	public class EtiquetaConjuntoList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<EtiquetaConjunto> lstEtiquetaConjunto { get; set; }
		#endregion Properties

		#region Constructors
		public EtiquetaConjuntoList()
		{
			lstEtiquetaConjunto = new List<EtiquetaConjunto>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstEtiquetaConjunto = new List<EtiquetaConjunto>();
			while (reader.Read())
			{
				EtiquetaConjunto oEtiquetaConjunto = new EtiquetaConjunto();
				if (!Convert.IsDBNull(reader["codConjunto"])) oEtiquetaConjunto.codConjunto = reader["codConjunto"] as string;
				if (!Convert.IsDBNull(reader["codAplicacion"])) oEtiquetaConjunto.codAplicacion = reader["codAplicacion"] as string;
				if (!Convert.IsDBNull(reader["nbConjunto"])) oEtiquetaConjunto.nbConjunto = reader["nbConjunto"] as string;
				if (!Convert.IsDBNull(reader["nbdAplicacion"])) oEtiquetaConjunto.nbdAplicacion = reader["nbdAplicacion"] as string;
				lstEtiquetaConjunto.Add(oEtiquetaConjunto);
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