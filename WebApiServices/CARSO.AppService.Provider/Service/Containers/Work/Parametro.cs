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
	/// Valores de los parámetros para el procesamiento
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Parametro : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Identificador del Parametro
		/// </summary>
		[DataMember]
		public Int32 IdParam { get; set; }
		/// <summary>
		/// Identificador del registro a procesar
		/// </summary>
		[DataMember]
		public string IdTicket { get; set; }
		/// <summary>
		/// Identificador del recurso
		/// </summary>
		[DataMember]
		public Int32 idResourceFile { get; set; }
		/// <summary>
		/// Nombre del parametro
		/// </summary>
		[DataMember]
		public string nbParametro { get; set; }
		/// <summary>
		/// Valor del parametro
		/// </summary>
		[DataMember]
		public string vlParametro { get; set; }
		/// <summary>
		/// Fecha de creación del registro
		/// </summary>
		[DataMember]
		public string feCreacion { get; set; }
		#endregion Properties

		#region Constructors
		/// <summary>
		/// Constructor de la Clase Valores de los parámetros para el procesamiento  
		/// </summary>
		public Parametro()
		{
			IdParam = 0;
			IdTicket = string.Empty;
			idResourceFile = 0;
			nbParametro = string.Empty;
			vlParametro = string.Empty;
			feCreacion = string.Empty;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(Parametro rhs, Parametro.ParametroComparer.ParametroTipoComparacion which)
		{
			switch (which)
			{
			}
			return 0;
		}

		public class ParametroComparer : IComparer<Parametro>
		{
			public enum ParametroTipoComparacion
			{
				NULL
			}
			private ParametroTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public ParametroTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(Parametro lhs, Parametro rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(Parametro lhs, Parametro rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(Parametro e)
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
			if (!Convert.IsDBNull(reader["IdParam"])) IdParam = Int32.Parse(reader["IdParam"].ToString());
			if (!Convert.IsDBNull(reader["IdTicket"])) IdTicket = reader["IdTicket"] as string;
			if (!Convert.IsDBNull(reader["idResourceFile"])) idResourceFile = Int32.Parse(reader["idResourceFile"].ToString());
			if (!Convert.IsDBNull(reader["nbParametro"])) nbParametro = reader["nbParametro"] as string;
			if (!Convert.IsDBNull(reader["vlParametro"])) vlParametro = reader["vlParametro"] as string;
			if (!Convert.IsDBNull(reader["feCreacion"])) feCreacion = DateTime.Parse(reader["feCreacion"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>
		public void SetDataTo(IDataParameterCollection pars)
		{
			if (IdParam != 0) DataUtil.SetValue(pars, "@IdParam", IdParam);
			if (IdTicket != string.Empty) DataUtil.SetValue(pars, "@IdTicket", IdTicket);
			if (idResourceFile != 0) DataUtil.SetValue(pars, "@idResourceFile", idResourceFile);
			if (nbParametro != string.Empty) DataUtil.SetValue(pars, "@nbParametro", nbParametro);
			if (vlParametro != string.Empty) DataUtil.SetValue(pars, "@vlParametro", vlParametro);
			if (feCreacion != string.Empty) DataUtil.SetValue(pars, "@feCreacion", DateTime.Parse(feCreacion).ToString("yyyyMMdd HH:mm:ss"));
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Parametro 
	/// </summary>
	[Serializable]
	[DataContract]
	public class ParametroList : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Parametro> lstParametro { get; set; }
		#endregion Properties

		#region Constructors
		public ParametroList()
		{
			lstParametro = new List<Parametro>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstParametro = new List<Parametro>();
			while (reader.Read())
			{
				Parametro oParametro = new Parametro();
				if (!Convert.IsDBNull(reader["IdParam"])) oParametro.IdParam = Int32.Parse(reader["IdParam"].ToString());
				if (!Convert.IsDBNull(reader["IdTicket"])) oParametro.IdTicket = reader["IdTicket"].ToString() ;
				if (!Convert.IsDBNull(reader["idResourceFile"])) oParametro.idResourceFile = Int32.Parse(reader["idResourceFile"].ToString());
				if (!Convert.IsDBNull(reader["nbParametro"])) oParametro.nbParametro = reader["nbParametro"] as string;
				if (!Convert.IsDBNull(reader["vlParametro"])) oParametro.vlParametro = reader["vlParametro"] as string;
				if (!Convert.IsDBNull(reader["feCreacion"])) oParametro.feCreacion = DateTime.Parse(reader["feCreacion"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
				lstParametro.Add(oParametro);
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