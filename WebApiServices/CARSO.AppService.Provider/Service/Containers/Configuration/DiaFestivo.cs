using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.LogLibrary.ServiceDataContainers;
using System.Threading.Tasks;

namespace CARSO.AppServiceDB.ServiceDataContainers
{
	/// <summary>
	/// Catálogo de Dias Festivos
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class DiaFestivo : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Id de Dia Festivo
		/// </summary>
		[DataMember]
		public Int64 IdDiaFestivo { get; set; }
		/// <summary>
		/// Nombre del Dia Festivo que se Conmemora
		/// </summary>
		[DataMember]
		public string nbDiaFestivo { get; set; }
		/// <summary>
		/// Año en curso
		/// </summary>
		[DataMember]
		public Int32 noAnio { get; set; }
		/// <summary>
		/// Fecha del Dia Festivo
		/// </summary>
		[DataMember]
		public string feDiaFestivo { get; set; }
		#endregion Properties

		#region Constructors
		/// <summary>
		/// Constructor de la Clase Catálogo de Dias Festivos  
		/// </summary>
		public DiaFestivo()
		{
			this.IdDiaFestivo = 0;
			this.nbDiaFestivo = string.Empty;
			this.noAnio = 0;
			this.feDiaFestivo = string.Empty;

		}
		#endregion Constructors

		#region Compare
		public int CompareTo(DiaFestivo rhs, DiaFestivo.DiaFestivoComparer.DiaFestivoTipoComparacion which)
		{
			switch (which)
			{
				case DiaFestivoComparer.DiaFestivoTipoComparacion.IdDiaFestivo: return IdDiaFestivo.CompareTo(rhs.IdDiaFestivo);
				case DiaFestivoComparer.DiaFestivoTipoComparacion.nbDiaFestivo: return nbDiaFestivo.CompareTo(rhs.nbDiaFestivo);
				case DiaFestivoComparer.DiaFestivoTipoComparacion.noAnio: return noAnio.CompareTo(rhs.noAnio);
				case DiaFestivoComparer.DiaFestivoTipoComparacion.feDiaFestivo: return feDiaFestivo.CompareTo(rhs.feDiaFestivo);
			}
			return 0;
		}
		public class DiaFestivoComparer : IComparer<DiaFestivo>
		{
			public enum DiaFestivoTipoComparacion
			{
				IdDiaFestivo,
				nbDiaFestivo,
				noAnio,
				feDiaFestivo,
				NULL
			}

			private DiaFestivoTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;

			public DiaFestivoTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(DiaFestivo lhs, DiaFestivo rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(DiaFestivo lhs, DiaFestivo rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(DiaFestivo e)
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
			if (!Convert.IsDBNull(reader["IdDiaFestivo"])) this.IdDiaFestivo = Int64.Parse(reader["IdDiaFestivo"].ToString());
			if (!Convert.IsDBNull(reader["nbDiaFestivo"])) this.nbDiaFestivo = reader["nbDiaFestivo"] as string;
			if (!Convert.IsDBNull(reader["noAnio"])) this.noAnio = Int32.Parse(reader["noAnio"].ToString());
			if (!Convert.IsDBNull(reader["feDiaFestivo"])) this.feDiaFestivo = DateTime.Parse(reader["feDiaFestivo"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (this.IdDiaFestivo != 0) DataUtil.SetValue(pars, "@IdDiaFestivo", this.IdDiaFestivo);
			if (this.nbDiaFestivo != string.Empty) DataUtil.SetValue(pars, "@nbDiaFestivo", this.nbDiaFestivo);
			if (this.noAnio != 0) DataUtil.SetValue(pars, "@noAnio", this.noAnio);
			if (this.feDiaFestivo != string.Empty) DataUtil.SetValue(pars, "@feDiaFestivo", this.feDiaFestivo);
			DataUtil.SetReturnedValue(pars, "@return_value");
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de DiaFestivo 
	/// </summary>
	[Serializable]
	[DataContract(IsReference =true)]
	public class DiaFestivoList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<DiaFestivo> lstDiaFestivo { get; set; }
		#endregion Properties

		#region Constructors
		public DiaFestivoList()
		{
			lstDiaFestivo = new List<DiaFestivo>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			while (reader.Read())
			{
				DiaFestivo oDiaFestivo = new DiaFestivo();

				if (!Convert.IsDBNull(reader["IdDiaFestivo"])) oDiaFestivo.IdDiaFestivo = Int64.Parse(reader["IdDiaFestivo"].ToString());
				if (!Convert.IsDBNull(reader["nbDiaFestivo"])) oDiaFestivo.nbDiaFestivo = reader["nbDiaFestivo"] as string;
				if (!Convert.IsDBNull(reader["noAnio"])) oDiaFestivo.noAnio = Int32.Parse(reader["noAnio"].ToString());
				if (!Convert.IsDBNull(reader["feDiaFestivo"])) oDiaFestivo.feDiaFestivo = DateTime.Parse(reader["feDiaFestivo"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
				this.lstDiaFestivo.Add(oDiaFestivo);
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