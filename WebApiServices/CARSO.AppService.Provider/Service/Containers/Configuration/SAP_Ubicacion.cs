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
	/// Ubicacion
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Ubicacion : IDataContainer
	{
		#region Properties
		/// </summary>
		[DataMember]
		public string codEdificio { get; set; }
		/// </summary>
		[DataMember]
		public string nbObjeto { get; set; }
		/// </summary>
		[DataMember]
		public string nbDireccion { get; set; }
		/// </summary>
		[DataMember]
		public string nbCalle { get; set; }
		/// </summary>
		[DataMember]
		public string nbPoblacion { get; set; }
		/// </summary>
		[DataMember]
		public string nbCP { get; set; }
		/// </summary>
		[DataMember]
		public string codPais { get; set; }
		/// </summary>
		[DataMember]
		public string codTelefono { get; set; }
		/// </summary>
		[DataMember]
		public string codFax { get; set; }
		/// </summary>
		[DataMember]
		public string codRegion { get; set; }
		/// </summary>
		[DataMember]
		public string nbCalle2 { get; set; }
		/// </summary>
		[DataMember]
		public string noEdificio { get; set; }
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		#endregion Properties


		#region Constructors
		/// <summary>
		/// Constructor de la Clase Ubicacion  
		/// </summary>
		public Ubicacion()
		{
			this.codEdificio = string.Empty;
			this.nbObjeto = string.Empty;
			this.nbDireccion = string.Empty;
			this.nbCalle = string.Empty;
			this.nbPoblacion = string.Empty;
			this.nbCP = string.Empty;
			this.codPais = string.Empty;
			this.codTelefono = string.Empty;
			this.codFax = string.Empty;
			this.codRegion = string.Empty;
			this.nbCalle2 = string.Empty;
			this.noEdificio = string.Empty;
			this.esActivo = false;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(Ubicacion rhs, Ubicacion.UbicacionComparer.UbicacionTipoComparacion which)
		{
			switch (which)
			{
				case UbicacionComparer.UbicacionTipoComparacion.codEdificio: return this.codEdificio.CompareTo(rhs.codEdificio);
				case UbicacionComparer.UbicacionTipoComparacion.nbObjeto: return this.nbObjeto.CompareTo(rhs.nbObjeto);
				case UbicacionComparer.UbicacionTipoComparacion.nbDireccion: return this.nbDireccion.CompareTo(rhs.nbDireccion);
				case UbicacionComparer.UbicacionTipoComparacion.nbCalle: return this.nbCalle.CompareTo(rhs.nbCalle);
				case UbicacionComparer.UbicacionTipoComparacion.nbPoblacion: return this.nbPoblacion.CompareTo(rhs.nbPoblacion);
				case UbicacionComparer.UbicacionTipoComparacion.nbCP: return this.nbCP.CompareTo(rhs.nbCP);
				case UbicacionComparer.UbicacionTipoComparacion.codPais: return this.codPais.CompareTo(rhs.codPais);
				case UbicacionComparer.UbicacionTipoComparacion.codTelefono: return this.codTelefono.CompareTo(rhs.codTelefono);
				case UbicacionComparer.UbicacionTipoComparacion.codFax: return this.codFax.CompareTo(rhs.codFax);
				case UbicacionComparer.UbicacionTipoComparacion.codRegion: return this.codRegion.CompareTo(rhs.codRegion);
				case UbicacionComparer.UbicacionTipoComparacion.nbCalle2: return this.nbCalle2.CompareTo(rhs.nbCalle2);
				case UbicacionComparer.UbicacionTipoComparacion.noEdificio: return this.noEdificio.CompareTo(rhs.noEdificio);
				case UbicacionComparer.UbicacionTipoComparacion.esActivo: return this.esActivo.CompareTo(rhs.esActivo);
			}
			return 0;
		}
		public class UbicacionComparer : IComparer<Ubicacion>
		{
			public enum UbicacionTipoComparacion
			{
				codEdificio,
				nbObjeto,
				nbDireccion,
				nbCalle,
				nbPoblacion,
				nbCP,
				codPais,
				codTelefono,
				codFax,
				codRegion,
				nbCalle2,
				noEdificio,
				esActivo,
				NULL
			}
			private UbicacionTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public UbicacionTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(Ubicacion lhs, Ubicacion rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(Ubicacion lhs, Ubicacion rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(Ubicacion e)
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
			if (!Convert.IsDBNull(reader["codEdificio"])) this.codEdificio = reader["codEdificio"] as string;
			if (!Convert.IsDBNull(reader["nbObjeto"])) this.nbObjeto = reader["nbObjeto"] as string;
			if (!Convert.IsDBNull(reader["nbDireccion"])) this.nbDireccion = reader["nbDireccion"] as string;
			if (!Convert.IsDBNull(reader["nbCalle"])) this.nbCalle = reader["nbCalle"] as string;
			if (!Convert.IsDBNull(reader["nbPoblacion"])) this.nbPoblacion = reader["nbPoblacion"] as string;
			if (!Convert.IsDBNull(reader["nbCP"])) this.nbCP = reader["nbCP"] as string;
			if (!Convert.IsDBNull(reader["codPais"])) this.codPais = reader["codPais"] as string;
			if (!Convert.IsDBNull(reader["codTelefono"])) this.codTelefono = reader["codTelefono"] as string;
			if (!Convert.IsDBNull(reader["codFax"])) this.codFax = reader["codFax"] as string;
			if (!Convert.IsDBNull(reader["codRegion"])) this.codRegion = reader["codRegion"] as string;
			if (!Convert.IsDBNull(reader["nbCalle2"])) this.nbCalle2 = reader["nbCalle2"] as string;
			if (!Convert.IsDBNull(reader["noEdificio"])) this.noEdificio = reader["noEdificio"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = (bool)reader["esActivo"];
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.codEdificio != string.Empty) DataUtil.SetValue(pars, "@codEdificio", this.codEdificio);
			if (this.nbObjeto != string.Empty) DataUtil.SetValue(pars, "@nbObjeto", this.nbObjeto);
			if (this.nbDireccion != string.Empty) DataUtil.SetValue(pars, "@nbDireccion", this.nbDireccion);
			if (this.nbCalle != string.Empty) DataUtil.SetValue(pars, "@nbCalle", this.nbCalle);
			if (this.nbPoblacion != string.Empty) DataUtil.SetValue(pars, "@nbPoblacion", this.nbPoblacion);
			if (this.nbCP != string.Empty) DataUtil.SetValue(pars, "@nbCP", this.nbCP);
			if (this.codPais != string.Empty) DataUtil.SetValue(pars, "@codPais", this.codPais);
			if (this.codTelefono != string.Empty) DataUtil.SetValue(pars, "@codTelefono", this.codTelefono);
			if (this.codFax != string.Empty) DataUtil.SetValue(pars, "@codFax", this.codFax);
			if (this.codRegion != string.Empty) DataUtil.SetValue(pars, "@codRegion", this.codRegion);
			if (this.nbCalle2 != string.Empty) DataUtil.SetValue(pars, "@nbCalle2", this.nbCalle2);
			if (this.noEdificio != string.Empty) DataUtil.SetValue(pars, "@noEdificio", this.noEdificio);
			DataUtil.SetValue(pars, "@esActivo", this.esActivo);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Ubicacion 
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class UbicacionList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Ubicacion> lstUbicacion { get; set; }
		#endregion Properties

		#region Constructors
		public UbicacionList()
		{
			lstUbicacion = new List<Ubicacion>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstUbicacion = new List<Ubicacion>();

				while (reader.Read())
			{
				Ubicacion oUbicacion = new Ubicacion();
				if (!Convert.IsDBNull(reader["codEdificio"])) oUbicacion.codEdificio = reader["codEdificio"] as string;
				if (!Convert.IsDBNull(reader["nbObjeto"])) oUbicacion.nbObjeto = reader["nbObjeto"] as string;
				if (!Convert.IsDBNull(reader["nbDireccion"])) oUbicacion.nbDireccion = reader["nbDireccion"] as string;
				if (!Convert.IsDBNull(reader["nbCalle"])) oUbicacion.nbCalle = reader["nbCalle"] as string;
				if (!Convert.IsDBNull(reader["nbPoblacion"])) oUbicacion.nbPoblacion = reader["nbPoblacion"] as string;
				if (!Convert.IsDBNull(reader["nbCP"])) oUbicacion.nbCP = reader["nbCP"] as string;
				if (!Convert.IsDBNull(reader["codPais"])) oUbicacion.codPais = reader["codPais"] as string;
				if (!Convert.IsDBNull(reader["codTelefono"])) oUbicacion.codTelefono = reader["codTelefono"] as string;
				if (!Convert.IsDBNull(reader["codFax"])) oUbicacion.codFax = reader["codFax"] as string;
				if (!Convert.IsDBNull(reader["codRegion"])) oUbicacion.codRegion = reader["codRegion"] as string;
				if (!Convert.IsDBNull(reader["nbCalle2"])) oUbicacion.nbCalle2 = reader["nbCalle2"] as string;
				if (!Convert.IsDBNull(reader["noEdificio"])) oUbicacion.noEdificio = reader["noEdificio"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oUbicacion.esActivo = (bool)reader["esActivo"];
				this.lstUbicacion.Add(oUbicacion);
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
