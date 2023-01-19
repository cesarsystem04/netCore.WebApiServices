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
	/// RFCSociedad
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class RFCSociedad : IDataContainer
	{
		#region Properties
		/// </summary>
		[DataMember]
		public string codSociedad { get; set; }
		/// </summary>
		[DataMember]
		public string nbRFC { get; set; }
		/// </summary>
		[DataMember]
		public string nbCalle { get; set; }
		/// </summary>
		[DataMember]
		public string nbEdificio { get; set; }
		/// </summary>
		[DataMember]
		public string nbDistrito { get; set; }
		/// </summary>
		[DataMember]
		public string nbPoblacion { get; set; }
		/// </summary>
		[DataMember]
		public string nbCP { get; set; }
		/// </summary>
		[DataMember]
		public string nbRegion { get; set; }
		/// </summary>
		[DataMember]
		public string codMunicipio { get; set; }
		/// </summary>
		[DataMember]
		public string nbTelefono { get; set; }
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase RFCSociedad  
		/// </summary>
		public RFCSociedad()
		{
			this.codSociedad = string.Empty;
			this.nbRFC = string.Empty;
			this.nbCalle = string.Empty;
			this.nbEdificio = string.Empty;
			this.nbDistrito = string.Empty;
			this.nbPoblacion = string.Empty;
			this.nbCP = string.Empty;
			this.nbRegion = string.Empty;
			this.codMunicipio = string.Empty;
			this.nbTelefono = string.Empty;
			this.esActivo = false;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(RFCSociedad rhs, RFCSociedad.RFCSociedadComparer.RFCSociedadTipoComparacion which)
		{
			switch (which)
			{
				case RFCSociedadComparer.RFCSociedadTipoComparacion.codSociedad: return this.codSociedad.CompareTo(rhs.codSociedad);
				case RFCSociedadComparer.RFCSociedadTipoComparacion.nbRFC: return this.nbRFC.CompareTo(rhs.nbRFC);
				case RFCSociedadComparer.RFCSociedadTipoComparacion.nbCalle: return this.nbCalle.CompareTo(rhs.nbCalle);
				case RFCSociedadComparer.RFCSociedadTipoComparacion.nbEdificio: return this.nbEdificio.CompareTo(rhs.nbEdificio);
				case RFCSociedadComparer.RFCSociedadTipoComparacion.nbDistrito: return this.nbDistrito.CompareTo(rhs.nbDistrito);
				case RFCSociedadComparer.RFCSociedadTipoComparacion.nbPoblacion: return this.nbPoblacion.CompareTo(rhs.nbPoblacion);
				case RFCSociedadComparer.RFCSociedadTipoComparacion.nbCP: return this.nbCP.CompareTo(rhs.nbCP);
				case RFCSociedadComparer.RFCSociedadTipoComparacion.nbRegion: return this.nbRegion.CompareTo(rhs.nbRegion);
				case RFCSociedadComparer.RFCSociedadTipoComparacion.codMunicipio: return this.codMunicipio.CompareTo(rhs.codMunicipio);
				case RFCSociedadComparer.RFCSociedadTipoComparacion.nbTelefono: return this.nbTelefono.CompareTo(rhs.nbTelefono);
				case RFCSociedadComparer.RFCSociedadTipoComparacion.esActivo: return this.esActivo.CompareTo(rhs.esActivo);
			}
			return 0;
		}
		public class RFCSociedadComparer : IComparer<RFCSociedad>
		{
			public enum RFCSociedadTipoComparacion
			{
				codSociedad,
				nbRFC,
				nbCalle,
				nbEdificio,
				nbDistrito,
				nbPoblacion,
				nbCP,
				nbRegion,
				codMunicipio,
				nbTelefono,
				esActivo,
				NULL
			}
			private RFCSociedadTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public RFCSociedadTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(RFCSociedad lhs, RFCSociedad rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(RFCSociedad lhs, RFCSociedad rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(RFCSociedad e)
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
			if (!Convert.IsDBNull(reader["nbRFC"])) this.nbRFC = reader["nbRFC"] as string;
			if (!Convert.IsDBNull(reader["nbCalle"])) this.nbCalle = reader["nbCalle"] as string;
			if (!Convert.IsDBNull(reader["nbEdificio"])) this.nbEdificio = reader["nbEdificio"] as string;
			if (!Convert.IsDBNull(reader["nbDistrito"])) this.nbDistrito = reader["nbDistrito"] as string;
			if (!Convert.IsDBNull(reader["nbPoblacion"])) this.nbPoblacion = reader["nbPoblacion"] as string;
			if (!Convert.IsDBNull(reader["nbCP"])) this.nbCP = reader["nbCP"] as string;
			if (!Convert.IsDBNull(reader["nbRegion"])) this.nbRegion = reader["nbRegion"] as string;
			if (!Convert.IsDBNull(reader["codMunicipio"])) this.codMunicipio = reader["codMunicipio"] as string;
			if (!Convert.IsDBNull(reader["nbTelefono"])) this.nbTelefono = reader["nbTelefono"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = (bool)reader["esActivo"];
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.codSociedad != string.Empty) DataUtil.SetValue(pars, "@codSociedad", this.codSociedad);
			if (this.nbRFC != string.Empty) DataUtil.SetValue(pars, "@nbRFC", this.nbRFC);
			if (this.nbCalle != string.Empty) DataUtil.SetValue(pars, "@nbCalle", this.nbCalle);
			if (this.nbEdificio != string.Empty) DataUtil.SetValue(pars, "@nbEdificio", this.nbEdificio);
			if (this.nbDistrito != string.Empty) DataUtil.SetValue(pars, "@nbDistrito", this.nbDistrito);
			if (this.nbPoblacion != string.Empty) DataUtil.SetValue(pars, "@nbPoblacion", this.nbPoblacion);
			if (this.nbCP != string.Empty) DataUtil.SetValue(pars, "@nbCP", this.nbCP);
			if (this.nbRegion != string.Empty) DataUtil.SetValue(pars, "@nbRegion", this.nbRegion);
			if (this.codMunicipio != string.Empty) DataUtil.SetValue(pars, "@codMunicipio", this.codMunicipio);
			if (this.nbTelefono != string.Empty) DataUtil.SetValue(pars, "@nbTelefono", this.nbTelefono);
			DataUtil.SetValue(pars, "@esActivo", this.esActivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de RFCSociedad 
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class RFCSociedadList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<RFCSociedad> lstRFCSociedad { get; set; }
		#endregion Properties

		#region Constructors
		public RFCSociedadList()
		{
			lstRFCSociedad = new List<RFCSociedad>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstRFCSociedad = new List<RFCSociedad>();
			while (reader.Read())
			{
				RFCSociedad oRFCSociedad = new RFCSociedad();
				if (!Convert.IsDBNull(reader["codSociedad"])) oRFCSociedad.codSociedad = reader["codSociedad"] as string;
				if (!Convert.IsDBNull(reader["nbRFC"])) oRFCSociedad.nbRFC = reader["nbRFC"] as string;
				if (!Convert.IsDBNull(reader["nbCalle"])) oRFCSociedad.nbCalle = reader["nbCalle"] as string;
				if (!Convert.IsDBNull(reader["nbEdificio"])) oRFCSociedad.nbEdificio = reader["nbEdificio"] as string;
				if (!Convert.IsDBNull(reader["nbDistrito"])) oRFCSociedad.nbDistrito = reader["nbDistrito"] as string;
				if (!Convert.IsDBNull(reader["nbPoblacion"])) oRFCSociedad.nbPoblacion = reader["nbPoblacion"] as string;
				if (!Convert.IsDBNull(reader["nbCP"])) oRFCSociedad.nbCP = reader["nbCP"] as string;
				if (!Convert.IsDBNull(reader["nbRegion"])) oRFCSociedad.nbRegion = reader["nbRegion"] as string;
				if (!Convert.IsDBNull(reader["codMunicipio"])) oRFCSociedad.codMunicipio = reader["codMunicipio"] as string;
				if (!Convert.IsDBNull(reader["nbTelefono"])) oRFCSociedad.nbTelefono = reader["nbTelefono"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oRFCSociedad.esActivo = (bool)reader["esActivo"];
				this.lstRFCSociedad.Add(oRFCSociedad);
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
