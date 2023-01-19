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
	public class Atributo : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Identificador de Atributo
		/// </summary>
		[DataMember]
		public Int32 idAtributo { get; set; }
		/// <summary>
		/// Identificador de Objeto Sistema
		/// </summary>
		[DataMember]
		public Int32 idObjeto { get; set; }
		/// <summary>
		/// Identificador de Código
		/// </summary>
		[DataMember]
		public Int32 idCodigoTipoAtributo { get; set; }
		/// <summary>
		/// Número de Catálogo
		/// </summary>
		[DataMember]
		public Int32 noCatalogo { get; set; }
		/// <summary>
		/// Nombre de Atributo
		/// </summary>
		[DataMember]
		public string nbAtributo { get; set; }
		/// <summary>
		/// Nombre Físico
		/// </summary>
		[DataMember]
		public string nbFisico { get; set; }
		/// <summary>
		/// Verificador para indicar si el Atributo es Filtrado
		/// </summary>
		[DataMember]
		public bool esFiltrado { get; set; }
		/// <summary>
		/// Descripción de la etiqueta
		/// </summary>
		[DataMember]
		public string dsLabel { get; set; }
		/// <summary>
		/// Número de Longitud
		/// </summary>
		[DataMember]
		public Int32 noLength { get; set; }
		/// <summary>
		/// Número de Presición
		/// </summary>
		[DataMember]
		public Int32 noPrecision { get; set; }
		/// <summary>
		/// Número de Escala
		/// </summary>
		[DataMember]
		public Int32 noScale { get; set; }
		/// <summary>
		/// Verificador para indicar si el Atributo es PK
		/// </summary>
		[DataMember]
		public bool esPK { get; set; }
		/// <summary>
		/// Verificador para indicar si el Atributo es FK
		/// </summary>
		[DataMember]
		public bool esFK { get; set; }
		/// <summary>
		/// Verificador para indicar si el Atributo es Obligatorio
		/// </summary>
		[DataMember]
		public bool esObligatorio { get; set; }
		/// <summary>
		/// Verificador para indicar si el Atributo es Activo
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		/// <summary>
		/// Nombre físico del Objeto
		/// </summary>
		[DataMember]
		public string nbFisicoObjeto { get; set; }
		/// <summary>
		/// Número de Objeto
		/// </summary>
		[DataMember]
		public Int32 noObjeto { get; set; }
		/// <summary>
		/// Nombre del elemento Código
		/// </summary>
		[DataMember]
		public string nbCodigo { get; set; }
		/// <summary>
		/// Descripción del elemento Código
		/// </summary>
		[DataMember]
		public string dsCodigo { get; set; }
		/// <summary>
		/// Referencia Externa
		/// </summary>
		[DataMember]
		public string rfExterna { get; set; }
		#endregion Properties
		
		#region Constructors
		/// <summary>
		/// Constructor de la Clase Rol del sistema  
		/// </summary>
		public Atributo()
		{
			idAtributo = 0;
			idObjeto = 0;
			idCodigoTipoAtributo = 0;
			noCatalogo = 0;
			nbAtributo = string.Empty;
			nbFisico = string.Empty;
			esFiltrado = false;
			dsLabel = string.Empty;
			noLength = 0;
			noPrecision = 0;
			noScale = 0;
			esPK = false;
			esFK = false;
			esObligatorio = false;
			esActivo = false;
			nbFisicoObjeto = string.Empty;
			noObjeto = 0;
			nbCodigo = string.Empty;
			dsCodigo = string.Empty;
			rfExterna = string.Empty;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(Atributo rhs, Atributo.AtributoComparer.AtributoTipoComparacion which)
		{
			switch (which)
			{
				case AtributoComparer.AtributoTipoComparacion.noCatalogo: return noCatalogo.CompareTo(rhs.noCatalogo);
				case AtributoComparer.AtributoTipoComparacion.nbAtributo: return nbAtributo.CompareTo(rhs.nbAtributo);
				case AtributoComparer.AtributoTipoComparacion.nbFisico: return nbFisico.CompareTo(rhs.nbFisico);
				case AtributoComparer.AtributoTipoComparacion.esFiltrado: return esFiltrado.CompareTo(rhs.esFiltrado);
				case AtributoComparer.AtributoTipoComparacion.dsLabel: return dsLabel.CompareTo(rhs.dsLabel);
				case AtributoComparer.AtributoTipoComparacion.noLength: return noLength.CompareTo(rhs.noLength);
				case AtributoComparer.AtributoTipoComparacion.noPrecision: return noPrecision.CompareTo(rhs.noPrecision);
				case AtributoComparer.AtributoTipoComparacion.noScale: return noScale.CompareTo(rhs.noScale);
				case AtributoComparer.AtributoTipoComparacion.esObligatorio: return esObligatorio.CompareTo(rhs.esObligatorio);
				case AtributoComparer.AtributoTipoComparacion.esActivo: return esActivo.CompareTo(rhs.esActivo);
				case AtributoComparer.AtributoTipoComparacion.nbFisicoObjeto: return nbFisicoObjeto.CompareTo(rhs.nbFisicoObjeto);
				case AtributoComparer.AtributoTipoComparacion.noObjeto: return noObjeto.CompareTo(rhs.noObjeto);
				case AtributoComparer.AtributoTipoComparacion.nbCodigo: return nbCodigo.CompareTo(rhs.nbCodigo);
				case AtributoComparer.AtributoTipoComparacion.dsCodigo: return dsCodigo.CompareTo(rhs.dsCodigo);
				case AtributoComparer.AtributoTipoComparacion.rfExterna: return rfExterna.CompareTo(rhs.rfExterna);
			}
			return 0;
		}
		
		public class AtributoComparer : IComparer<Atributo>
		{
			public enum AtributoTipoComparacion
			{
				idAtributo,
				idObjeto,
				idCodigoTipoAtributo,
				noCatalogo,
				nbAtributo,
				nbFisico,
				esFiltrado,
				dsLabel,
				noLength,
				noPrecision,
				noScale,
				esPK,
				esFK,
				esObligatorio,
				esActivo,
				nbFisicoObjeto,
				noObjeto,
				nbCodigo,
				dsCodigo,
				rfExterna,
				NULL
			}
				  
			private AtributoTipoComparacion _whichComparison;
			 
			private TipoOrdenamiento _sortDirection;
		   
			public AtributoTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}
				  
			public int Compare(Atributo lhs, Atributo rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}
				
			public bool Equals(Atributo lhs, Atributo rhs)
			{
				return Compare(lhs, rhs) == 0;
			}
			
			public int GetHashCode(Atributo e)
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
			if (!reader.Read()) return;
			if (!Convert.IsDBNull(reader["idAtributo"])) idAtributo = Int32.Parse(reader["idAtributo"].ToString());
			if (!Convert.IsDBNull(reader["idObjeto"])) idObjeto = Int32.Parse(reader["idObjeto"].ToString());
			if (!Convert.IsDBNull(reader["idCodigoTipoAtributo"])) idCodigoTipoAtributo = Int32.Parse(reader["idCodigoTipoAtributo"].ToString());
			if (!Convert.IsDBNull(reader["noCatalogo"])) noCatalogo = Int32.Parse(reader["noCatalogo"].ToString());
			if (!Convert.IsDBNull(reader["nbAtributo"])) nbAtributo = reader["nbAtributo"] as string;
			if (!Convert.IsDBNull(reader["nbFisico"])) nbFisico = reader["nbFisico"] as string;
			if (!Convert.IsDBNull(reader["esFiltrado"])) esFiltrado = (bool)reader["esFiltrado"];
			if (!Convert.IsDBNull(reader["dsLabel"])) dsLabel = reader["dsLabel"] as string;
			if (!Convert.IsDBNull(reader["noLength"])) noLength = Int32.Parse(reader["noLength"].ToString());
			if (!Convert.IsDBNull(reader["noPrecision"])) noPrecision = Int32.Parse(reader["noPrecision"].ToString());
			if (!Convert.IsDBNull(reader["noScale"])) noScale = Int32.Parse(reader["noScale"].ToString());
			if (!Convert.IsDBNull(reader["esPK"])) esPK = (bool)reader["esPK"];
			if (!Convert.IsDBNull(reader["esFK"])) esFK = (bool)reader["esFK"];
			if (!Convert.IsDBNull(reader["esObligatorio"])) esObligatorio = (bool)reader["esObligatorio"];
			if (!Convert.IsDBNull(reader["esActivo"])) esActivo = (bool)reader["esActivo"];
			if (!Convert.IsDBNull(reader["nbFisicoObjeto"])) nbFisicoObjeto = reader["nbFisicoObjeto"] as string;
			if (!Convert.IsDBNull(reader["noObjeto"])) noObjeto = Int32.Parse(reader["noObjeto"].ToString());
			if (!Convert.IsDBNull(reader["nbCodigo"])) nbCodigo = reader["nbCodigo"] as string;
			if (!Convert.IsDBNull(reader["dsCodigo"])) dsCodigo = reader["dsCodigo"] as string;
			if (!Convert.IsDBNull(reader["rfExterna"])) rfExterna = reader["rfExterna"] as string;
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>
		public void SetDataTo(IDataParameterCollection pars)
		{
			if (idAtributo != 0) DataUtil.SetValue(pars, "@idAtributo", idAtributo);
			if (idObjeto != 0) DataUtil.SetValue(pars, "@idObjeto", idObjeto);
			if (idCodigoTipoAtributo != 0) DataUtil.SetValue(pars, "@idCodigoTipoAtributo", idCodigoTipoAtributo);
			if (noCatalogo != 0) DataUtil.SetValue(pars, "@noCatalogo", noCatalogo);
			if (nbAtributo != string.Empty) DataUtil.SetValue(pars, "@nbAtributo", nbAtributo);
			if (nbFisico != string.Empty) DataUtil.SetValue(pars, "@nbFisico", nbFisico);
			DataUtil.SetValue(pars, "@esFiltrado", esFiltrado);
			if (dsLabel != string.Empty) DataUtil.SetValue(pars, "@dsLabel", dsLabel);
			if (noLength != 0) DataUtil.SetValue(pars, "@noLength", noLength);
			if (noPrecision != 0) DataUtil.SetValue(pars, "@noPrecision", noPrecision);
			if (noScale != 0) DataUtil.SetValue(pars, "@noScale", noScale);
			DataUtil.SetValue(pars, "@esPK", esPK);
			DataUtil.SetValue(pars, "@esFK", esFK);
			DataUtil.SetValue(pars, "@esObligatorio", esObligatorio);
			DataUtil.SetValue(pars, "@esActivo", esActivo);
			DataUtil.SetReturnedValue(pars, "@return_value");
		}
		#endregion        
	}

	/// <summary>
	/// Colección de objetos de tipo de Rol 
	/// </summary>
	[Serializable]
	[DataContract]
	public class AtributoList : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Atributo> lstAtributo { get; set; }
		#endregion Properties

		#region Constructors
		public AtributoList()
		{
			lstAtributo = new List<Atributo>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstAtributo = new List<Atributo>();

			while (reader.Read())
			{
				Atributo oAtributo = new Atributo();
				if (!Convert.IsDBNull(reader["idAtributo"])) oAtributo.idAtributo = Int32.Parse(reader["idAtributo"].ToString());
				if (!Convert.IsDBNull(reader["idObjeto"])) oAtributo.idObjeto = Int32.Parse(reader["idObjeto"].ToString());
				if (!Convert.IsDBNull(reader["idCodigoTipoAtributo"])) oAtributo.idCodigoTipoAtributo = Int32.Parse(reader["idCodigoTipoAtributo"].ToString());
				if (!Convert.IsDBNull(reader["noCatalogo"])) oAtributo.noCatalogo = Int32.Parse(reader["noCatalogo"].ToString());
				if (!Convert.IsDBNull(reader["nbAtributo"])) oAtributo.nbAtributo = reader["nbAtributo"] as string;
				if (!Convert.IsDBNull(reader["nbFisico"])) oAtributo.nbFisico = reader["nbFisico"] as string;
				if (!Convert.IsDBNull(reader["esFiltrado"])) oAtributo.esFiltrado = (bool)reader["esFiltrado"];
				if (!Convert.IsDBNull(reader["dsLabel"])) oAtributo.dsLabel = reader["dsLabel"] as string;
				if (!Convert.IsDBNull(reader["noLength"])) oAtributo.noLength = Int32.Parse(reader["noLength"].ToString());
				if (!Convert.IsDBNull(reader["noPrecision"])) oAtributo.noPrecision = Int32.Parse(reader["noPrecision"].ToString());
				if (!Convert.IsDBNull(reader["noScale"])) oAtributo.noScale = Int32.Parse(reader["noScale"].ToString());
				if (!Convert.IsDBNull(reader["esPK"])) oAtributo.esPK = (bool)reader["esPK"];
				if (!Convert.IsDBNull(reader["esFK"])) oAtributo.esFK = (bool)reader["esFK"];
				if (!Convert.IsDBNull(reader["esObligatorio"])) oAtributo.esObligatorio = (bool)reader["esObligatorio"];
				if (!Convert.IsDBNull(reader["esActivo"])) oAtributo.esActivo = (bool)reader["esActivo"];
				if (!Convert.IsDBNull(reader["nbFisicoObjeto"])) oAtributo.nbFisicoObjeto = reader["nbFisicoObjeto"] as string;
				if (!Convert.IsDBNull(reader["noObjeto"])) oAtributo.noObjeto = Int32.Parse(reader["noObjeto"].ToString());
				if (!Convert.IsDBNull(reader["nbCodigo"])) oAtributo.nbCodigo = reader["nbCodigo"] as string;
				if (!Convert.IsDBNull(reader["dsCodigo"])) oAtributo.dsCodigo = reader["dsCodigo"] as string;
				if (!Convert.IsDBNull(reader["rfExterna"])) oAtributo.rfExterna = reader["rfExterna"] as string;
				lstAtributo.Add(oAtributo);
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
		#endregion
	}
}
