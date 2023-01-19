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
	/// Catálogos del Sistema
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Catalogo : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Identificador del Catálogo
		/// </summary>
		[DataMember]
		public Int32 noCatalogo { get; set; }
		/// <summary>
		/// Nombre del Catálogo
		/// </summary>
		[DataMember]
		public string nbCatalogo { get; set; }
		/// <summary>
		/// Descripción del Catálogo
		/// </summary>
		[DataMember]
		public string dsCatalogo { get; set; }
		/// <summary>
		/// Verificador para indicar si es administrable o no el Catálogo
		/// </summary>
		[DataMember]
		public bool esAdministrable { get; set; }
		/// <summary>
		/// Verificador para determinar si el elemento es utilizado en restricciones de elementos permitidos
		/// </summary>
		[DataMember]
		public bool esUsadoComoPermitido { get; set; }
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase Catálogos del Sistema  
		/// </summary>
		public Catalogo()
		{
			noCatalogo = 0;
			nbCatalogo = string.Empty;
			dsCatalogo = string.Empty;
			esAdministrable = false;
			esUsadoComoPermitido = false;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(Catalogo rhs, Catalogo.CatalogoComparer.CatalogoTipoComparacion which)
		{
			switch (which)
			{
				case CatalogoComparer.CatalogoTipoComparacion.noCatalogo: return noCatalogo.CompareTo(rhs.noCatalogo);
				case CatalogoComparer.CatalogoTipoComparacion.nbCatalogo: return nbCatalogo.CompareTo(rhs.nbCatalogo);
				case CatalogoComparer.CatalogoTipoComparacion.esAdministrable: return esAdministrable.CompareTo(rhs.esAdministrable);
				case CatalogoComparer.CatalogoTipoComparacion.esUsadoComoPermitido: return esUsadoComoPermitido.CompareTo(rhs.esUsadoComoPermitido);
			}
			return 0;
		}
		public class CatalogoComparer : IComparer<Catalogo>
		{
			public enum CatalogoTipoComparacion
			{
				noCatalogo,
				nbCatalogo,
				esAdministrable,
				esUsadoComoPermitido,
				NULL
			}
			private CatalogoTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public CatalogoTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(Catalogo lhs, Catalogo rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(Catalogo lhs, Catalogo rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(Catalogo e)
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
			if (!Convert.IsDBNull(reader["noCatalogo"])) noCatalogo = Int32.Parse(reader["noCatalogo"].ToString());
			if (!Convert.IsDBNull(reader["nbCatalogo"])) nbCatalogo = reader["nbCatalogo"] as string;
			if (!Convert.IsDBNull(reader["dsCatalogo"])) dsCatalogo = reader["dsCatalogo"] as string;
			if (!Convert.IsDBNull(reader["esAdministrable"])) esAdministrable = (bool)reader["esAdministrable"];
			if (!Convert.IsDBNull(reader["esUsadoComoPermitido"])) esUsadoComoPermitido = (bool)reader["esUsadoComoPermitido"];
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (noCatalogo != 0) DataUtil.SetValue(pars, "@noCatalogo", noCatalogo);
			if (nbCatalogo != string.Empty) DataUtil.SetValue(pars, "@nbCatalogo", nbCatalogo);
			if (dsCatalogo != string.Empty) DataUtil.SetValue(pars, "@dsCatalogo", dsCatalogo);
			DataUtil.SetValue(pars, "@esAdministrable", esAdministrable);
			DataUtil.SetValue(pars, "@esUsadoComoPermitido", esUsadoComoPermitido);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Catalogo 
	/// </summary>
	[Serializable]
	[DataContract]
	public class CatalogoList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Catalogo> lstCatalogo { get; set; }
		#endregion Properties

		#region Constructors
		public CatalogoList()
		{
			lstCatalogo = new List<Catalogo>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstCatalogo = new List<Catalogo>();
			while (reader.Read())
			{
				Catalogo oCatalogo = new Catalogo();
				if (!Convert.IsDBNull(reader["noCatalogo"])) oCatalogo.noCatalogo = Int32.Parse(reader["noCatalogo"].ToString());
				if (!Convert.IsDBNull(reader["nbCatalogo"])) oCatalogo.nbCatalogo = reader["nbCatalogo"] as string;
				if (!Convert.IsDBNull(reader["dsCatalogo"])) oCatalogo.dsCatalogo = reader["dsCatalogo"] as string;
				if (!Convert.IsDBNull(reader["esAdministrable"])) oCatalogo.esAdministrable = (bool)reader["esAdministrable"];
				if (!Convert.IsDBNull(reader["esUsadoComoPermitido"])) oCatalogo.esUsadoComoPermitido = (bool)reader["esUsadoComoPermitido"];
				lstCatalogo.Add(oCatalogo);
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
