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
	/// Usuarios del Sistema
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Usuario : IDataContainer
	{
		#region Properties
		/// <summary>
		/// Identificador del usuario en el Directorio Activo
		/// </summary>
		[DataMember]
		public string nbAlias { get; set; }
		/// <summary>
		/// Identificador del elemento de catálogo para el Tipo de Cuenta
		/// </summary>
		[DataMember]
		public Int32 idCodigoTipoCuenta { get; set; }
		/// <summary>
		/// Identificador de la cultura del lenguaje
		/// </summary>
		[DataMember]
		public string nbLanguageCulture { get; set; }
		/// <summary>
		/// Número de empleado del usuario en Protheus
		/// </summary>
		[DataMember]
		public string noEmpleado { get; set; }
		/// <summary>
		/// Nombre completo del usuario
		/// </summary>
		[DataMember]
		public string nbEmpleado { get; set; }
		/// <summary>
		/// Correo electrónico del usuario
		/// </summary>
		[DataMember]
		public string dsMail { get; set; }
		/// <summary>
		/// Verificador para indicar si el usuario es activo
		/// </summary>
		[DataMember]
		public bool esActivo { get; set; }
		/// <summary>
		/// Texto de estado Activo-Inactivo
		/// </summary>
		//[DataMember]
		//public string strActivo { get; set; }
		/// <summary>
		/// Fecha de registro del usuario
		/// </summary>
		[DataMember]
		public string feRegistro { get; set; }
		/// <summary>
		/// Indica si este usuario es super ususario
		/// </summary>
		[DataMember]
		public bool esSuperUsuario { get; set; }
		/// <summary>
		/// Nombre del elemento
		/// </summary>
		[DataMember]
		public string nbCodigoTipoCuenta { get; set; }
		/// <summary>
		/// Nombre de la cultura del lenguaje
		/// </summary>
		[DataMember]
		public string nbLanguage { get; set; }
		/// <summary>
		/// Orden
		/// </summary>
		[DataMember]
		public int noOrden { get; set; }

		[DataMember]
		public string codAplicacion { get; set; }
		[DataMember]
		public string dsEmpresa { get; set; }
        [DataMember]
        public bool esNCPermitido { get; set; }
        #endregion Properties

        #region Constructors
        /// <summary>
        /// Constructor de la Clase Usuarios del Sistema  
        /// </summary>

        public Usuario()
		{
			nbAlias = string.Empty;
			idCodigoTipoCuenta = 0;
			nbLanguageCulture = string.Empty;
			noEmpleado = string.Empty;
			nbEmpleado = string.Empty;
			dsMail = string.Empty;
			esActivo = false;
			feRegistro = string.Empty;
			esSuperUsuario = false;
			nbCodigoTipoCuenta = string.Empty;
			nbLanguage = string.Empty;
			noOrden = 0;
			codAplicacion = string.Empty;
			dsEmpresa = string.Empty;
            esNCPermitido = false;
		}
		#endregion Constructors

		#region Compare
		  
		public int CompareTo(Usuario rhs, Usuario.UsuarioComparer.UsuarioTipoComparacion which)
		{
			switch (which)
			{
				case UsuarioComparer.UsuarioTipoComparacion.nbAlias:
					return nbAlias.CompareTo(rhs.nbAlias);
				case UsuarioComparer.UsuarioTipoComparacion.nbLanguageCulture:
					return nbLanguageCulture.CompareTo(rhs.nbLanguageCulture);
				case UsuarioComparer.UsuarioTipoComparacion.noEmpleado:
					return noEmpleado.CompareTo(rhs.noEmpleado);
				case UsuarioComparer.UsuarioTipoComparacion.nbEmpleado:
					return nbEmpleado.CompareTo(rhs.nbEmpleado);
				case UsuarioComparer.UsuarioTipoComparacion.dsMail:
					return dsMail.CompareTo(rhs.dsMail);
				//case UsuarioComparer.UsuarioTipoComparacion.strActivo:
				//    return this.strActivo.CompareTo(rhs.strActivo);
				case UsuarioComparer.UsuarioTipoComparacion.feRegistro:
					return feRegistro.CompareTo(rhs.feRegistro);
				case UsuarioComparer.UsuarioTipoComparacion.nbLanguage:
					return nbLanguage.CompareTo(rhs.nbLanguage);
				case UsuarioComparer.UsuarioTipoComparacion.noOrden:
					return noOrden.CompareTo(rhs.noOrden);
			}
			return 0;
		}
		[DataContract]
		public class UsuarioComparer : IComparer<Usuario>
		{
			public enum UsuarioTipoComparacion
			{
				nbAlias,
				nbLanguageCulture,
				noEmpleado,
				nbEmpleado,
				dsMail,
				//strActivo,
				feRegistro,
				nbLanguage,
				noOrden,
				NULL
			}
	 [DataMember]
			private UsuarioTipoComparacion _whichComparison;
			[DataMember]
			private TipoOrdenamiento _sortDirection;
 [DataMember]
			public UsuarioTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}
		   
			public int Compare(Usuario lhs, Usuario rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(Usuario lhs, Usuario rhs)
			{
				return Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(Usuario e)
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
			if (!Convert.IsDBNull(reader["nbAlias"])) nbAlias = reader["nbAlias"] as string;
			if (!Convert.IsDBNull(reader["idCodigoTipoCuenta"])) idCodigoTipoCuenta = Int32.Parse(reader["idCodigoTipoCuenta"].ToString());
			if (!Convert.IsDBNull(reader["nbLanguageCulture"])) nbLanguageCulture = reader["nbLanguageCulture"] as string;
			if (!Convert.IsDBNull(reader["noEmpleado"])) noEmpleado = reader["noEmpleado"] as string;
			if (!Convert.IsDBNull(reader["nbEmpleado"])) nbEmpleado = reader["nbEmpleado"] as string;
			if (!Convert.IsDBNull(reader["dsMail"])) dsMail = reader["dsMail"] as string;
			if (!Convert.IsDBNull(reader["esActivo"])) esActivo = (bool)reader["esActivo"];
			if (!Convert.IsDBNull(reader["feRegistro"])) feRegistro = DateTime.Parse(reader["feRegistro"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
			if (!Convert.IsDBNull(reader["esSuperUsuario"])) esSuperUsuario = (bool)reader["esSuperUsuario"];
			if (!Convert.IsDBNull(reader["nbCodigoTipoCuenta"])) nbCodigoTipoCuenta = reader["nbCodigoTipoCuenta"] as string;
			if (!Convert.IsDBNull(reader["nbLanguage"])) nbLanguage = reader["nbLanguage"] as string;
			if (!Convert.IsDBNull(reader["noOrden"])) noOrden = Int32.Parse(reader["noOrden"].ToString());
			if (!Convert.IsDBNull(reader["codAplicacion"])) codAplicacion = reader["codAplicacion"] as string;
			if (!Convert.IsDBNull(reader["dsEmpresa"])) dsEmpresa = reader["dsEmpresa"] as string;
            if (!Convert.IsDBNull(reader["esNCPermitido"])) esNCPermitido = (bool)reader["esNCPermitido"];
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
			if (nbAlias != string.Empty) DataUtil.SetValue(pars, "@nbAlias", nbAlias);
			if (idCodigoTipoCuenta != 0) DataUtil.SetValue(pars, "@idCodigoTipoCuenta", idCodigoTipoCuenta);
			if (nbLanguageCulture != string.Empty) DataUtil.SetValue(pars, "@nbLanguageCulture", nbLanguageCulture);
			if (noEmpleado != string.Empty) DataUtil.SetValue(pars, "@noEmpleado", noEmpleado);
			if (nbEmpleado != string.Empty) DataUtil.SetValue(pars, "@nbEmpleado", nbEmpleado);
			if (dsMail != string.Empty) DataUtil.SetValue(pars, "@dsMail", dsMail);
			DataUtil.SetValue(pars, "@esActivo", esActivo);
			DataUtil.SetValue(pars, "@esSuperUsuario", esSuperUsuario);
			if (dsEmpresa != string.Empty) DataUtil.SetValue(pars, "@dsEmpresa", dsEmpresa);
            DataUtil.SetValue(pars, "@esNCPermitido", esNCPermitido);
			DataUtil.SetReturnedValue(pars, "@return_value");
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de Usuario 
	/// </summary>
	[Serializable]
	[DataContract]
	public class UsuarioList : IDataContainer
	{
		private List<Usuario> _lstUsuario;
		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<Usuario> lstUsuario { get { return _lstUsuario; } }
		/// <summary>
		/// Criterios de Busqueda
		/// </summary>
		[DataMember]
		public List<ParametrosBusquedas> LstParametros { get; set; }
		#endregion Properties

		#region Constructors
		public UsuarioList()
		{
			_lstUsuario = new List<Usuario>();
			LstParametros = new List<ParametrosBusquedas>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			_lstUsuario = new List<Usuario>();
			while (reader.Read())
			{
				Usuario oUsuario = new Usuario();
				if (!Convert.IsDBNull(reader["nbAlias"])) oUsuario.nbAlias = reader["nbAlias"] as string;
				if (!Convert.IsDBNull(reader["idCodigoTipoCuenta"])) oUsuario.idCodigoTipoCuenta = Int32.Parse(reader["idCodigoTipoCuenta"].ToString());
				if (!Convert.IsDBNull(reader["nbLanguageCulture"])) oUsuario.nbLanguageCulture = reader["nbLanguageCulture"] as string;
				if (!Convert.IsDBNull(reader["noEmpleado"])) oUsuario.noEmpleado = reader["noEmpleado"] as string;
				if (!Convert.IsDBNull(reader["nbEmpleado"])) oUsuario.nbEmpleado = reader["nbEmpleado"] as string;
				if (!Convert.IsDBNull(reader["dsMail"])) oUsuario.dsMail = reader["dsMail"] as string;
				if (!Convert.IsDBNull(reader["esActivo"])) oUsuario.esActivo = (bool)reader["esActivo"];
				if (!Convert.IsDBNull(reader["feRegistro"])) oUsuario.feRegistro = DateTime.Parse(reader["feRegistro"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
				if (!Convert.IsDBNull(reader["esSuperUsuario"])) oUsuario.esSuperUsuario = (bool)reader["esSuperUsuario"];
				if (!Convert.IsDBNull(reader["nbCodigoTipoCuenta"])) oUsuario.nbCodigoTipoCuenta = reader["nbCodigoTipoCuenta"] as string;
				if (!Convert.IsDBNull(reader["nbLanguage"])) oUsuario.nbLanguage = reader["nbLanguage"] as string;
				if (!Convert.IsDBNull(reader["noOrden"])) oUsuario.noOrden = Int32.Parse(reader["noOrden"].ToString());
				if (!Convert.IsDBNull(reader["codAplicacion"])) oUsuario.codAplicacion = reader["codAplicacion"] as string;
				if (!Convert.IsDBNull(reader["dsEmpresa"])) oUsuario.dsEmpresa = reader["dsEmpresa"] as string;
                if (!Convert.IsDBNull(reader["esNCPermitido"])) oUsuario.esNCPermitido = (bool)reader["esNCPermitido"];

                _lstUsuario.Add(oUsuario);
			}
		}

		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>
		public void SetDataTo(System.Data.IDataParameterCollection pars) 
		{
			List<string> pasarLista = new List<string>();
			foreach (ParametrosBusquedas item in LstParametros)
			{
				string condicion = item.pColumna + item.pValor;
				pasarLista.Add(item.pRestriccion + condicion);
			}

			if (pasarLista.Count >= 1) DataUtil.SetValue(pars, "@nbAlias", pasarLista[0].ToString());
			if (pasarLista.Count >= 3) DataUtil.SetValue(pars, "@nbLanguageCulture", pasarLista[2].ToString());
			if (pasarLista.Count >= 4) DataUtil.SetValue(pars, "@noEmpleado", pasarLista[3].ToString());
			if (pasarLista.Count >= 5) DataUtil.SetValue(pars, "@nbEmpleado", pasarLista[4].ToString());
			if (pasarLista.Count >= 6) DataUtil.SetValue(pars, "@dsMail", pasarLista[5].ToString());
			if (pasarLista.Count >= 7) DataUtil.SetValue(pars, "@esActivo", pasarLista[6].ToString());
			if (pasarLista.Count >= 8) DataUtil.SetValue(pars, "@feRegistro", pasarLista[7].ToString());
		}
		#endregion IDataContainer Members
	}
}