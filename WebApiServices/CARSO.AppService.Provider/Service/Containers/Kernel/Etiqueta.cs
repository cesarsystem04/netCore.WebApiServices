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
	/// Etiquetas del Sistema
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Etiqueta : IDataContainer
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
		/// Número Consecutivo de la Etiqueta
		/// </summary>
		[DataMember]
		public Int32 noConsecutivo { get; set; }
		/// <summary>
		/// Nombre del Conjunto de Etiquetas
		/// </summary>

  
		#endregion Properties

		#region Constructors
		/// <summary>
		/// Constructor de la Clase Etiquetas del Sistema  
		/// </summary>
		public Etiqueta()
		{
			codEtiqueta = string.Empty;
			codConjunto = string.Empty;
			codAplicacion = string.Empty;
			noConsecutivo = 0;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(Etiqueta rhs, Etiqueta.EtiquetaComparer.EtiquetaTipoComparacion which)
		{
			switch (which)
			{
			}
			return 0;
		}

		public class EtiquetaComparer : IComparer<Etiqueta>
		{
			public enum EtiquetaTipoComparacion
			{
				codEtiqueta,
				codConjunto,
				codAplicacion,
				noConsecutivo,
				NULL
			}
			private EtiquetaTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public EtiquetaTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(Etiqueta lhs, Etiqueta rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(Etiqueta lhs, Etiqueta rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(Etiqueta e)
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
			if (!Convert.IsDBNull(reader["noConsecutivo"])) noConsecutivo = Int32.Parse(reader["noConsecutivo"].ToString());
		 
		 
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
			if (noConsecutivo != 0) DataUtil.SetValue(pars, "@noConsecutivo", noConsecutivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Etiqueta 
	/// </summary>
	[Serializable]
	[DataContract]
	public class EtiquetaList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Etiqueta> lstEtiqueta { get; set; }
		#endregion Properties

		#region Constructors
		public EtiquetaList()
		{
			lstEtiqueta = new List<Etiqueta>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstEtiqueta = new List<Etiqueta>();
			while (reader.Read())
			{
				Etiqueta oEtiqueta = new Etiqueta();
				if (!Convert.IsDBNull(reader["codEtiqueta"])) oEtiqueta.codEtiqueta = reader["codEtiqueta"] as string;
				if (!Convert.IsDBNull(reader["codConjunto"])) oEtiqueta.codConjunto = reader["codConjunto"] as string;
				if (!Convert.IsDBNull(reader["codAplicacion"])) oEtiqueta.codAplicacion = reader["codAplicacion"] as string;
				if (!Convert.IsDBNull(reader["noConsecutivo"])) oEtiqueta.noConsecutivo = Int32.Parse(reader["noConsecutivo"].ToString());


				lstEtiqueta.Add(oEtiqueta);
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