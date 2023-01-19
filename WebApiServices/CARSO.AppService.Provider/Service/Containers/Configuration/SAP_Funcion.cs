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
	/// Funcion
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Funcion : IDataContainer
	{
		#region Properties
		/// </summary>
		[DataMember]
		public string codFuncion { get; set; }
		/// </summary>
		[DataMember]
		public string nbFuncion { get; set; }
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase Funcion  
		/// </summary>
		public Funcion()
		{
			this.codFuncion = string.Empty;
			this.nbFuncion = string.Empty;
			this.esActivo = false;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(Funcion rhs, Funcion.FuncionComparer.FuncionTipoComparacion which)
		{
			switch (which)
			{
				case FuncionComparer.FuncionTipoComparacion.codFuncion: return this.codFuncion.CompareTo(rhs.codFuncion);
				case FuncionComparer.FuncionTipoComparacion.nbFuncion: return this.nbFuncion.CompareTo(rhs.nbFuncion);
				case FuncionComparer.FuncionTipoComparacion.esActivo: return this.esActivo.CompareTo(rhs.esActivo);
			}
			return 0;
		}
		public class FuncionComparer : IComparer<Funcion>
		{
			public enum FuncionTipoComparacion
			{
				codFuncion,
				nbFuncion,
				esActivo,
				NULL
			}
			private FuncionTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public FuncionTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(Funcion lhs, Funcion rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(Funcion lhs, Funcion rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(Funcion e)
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
			if (!Convert.IsDBNull(reader["codFuncion"])) this.codFuncion = reader["codFuncion"] as string;
			if (!Convert.IsDBNull(reader["nbFuncion"])) this.nbFuncion = reader["nbFuncion"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = (bool)reader["esActivo"];
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.codFuncion != string.Empty) DataUtil.SetValue(pars, "@codFuncion", this.codFuncion);
			if (this.nbFuncion != string.Empty) DataUtil.SetValue(pars, "@nbFuncion", this.nbFuncion);
			DataUtil.SetValue(pars, "@esActivo", this.esActivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Funcion 
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class FuncionList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Funcion> lstFuncion { get; set; }
		#endregion Properties

		#region Constructors
		public FuncionList()
		{
			lstFuncion = new List<Funcion>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstFuncion = new List<Funcion>();
			while (reader.Read())
			{
				Funcion oFuncion = new Funcion();
				if (!Convert.IsDBNull(reader["codFuncion"])) oFuncion.codFuncion = reader["codFuncion"] as string;
				if (!Convert.IsDBNull(reader["nbFuncion"])) oFuncion.nbFuncion = reader["nbFuncion"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oFuncion.esActivo = (bool)reader["esActivo"];
				this.lstFuncion.Add(oFuncion);
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
