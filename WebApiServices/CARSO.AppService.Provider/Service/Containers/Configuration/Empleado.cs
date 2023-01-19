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
	/// Elementos de Empleado
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class Empleado : IDataContainer
	{
		#region Properties
		[DataMember]
		public int noGrupo {get; set;}
		[DataMember]
		public string Grupo {get; set;}
		[DataMember]
		public string codSector {get; set;}
		[DataMember]
		public string nbSector {get; set;}
		[DataMember]
		public string codEmpresa {get; set;}
		[DataMember]
		public string nbEmpresa {get; set;}
		[DataMember]
		public string codFilial {get; set;}
		[DataMember]
		public string nbFilial {get; set;}
		[DataMember]
		public string codJerarquia {get; set;}
		[DataMember]
		public string nbJerarquia {get; set;}
		[DataMember]
		public string noEmpleado {get; set;}
		[DataMember]
		public string nbEmpleado {get; set;}
		[DataMember]
		public string apPaterno {get; set;}
		[DataMember]
		public string apMaterno {get; set;}
		[DataMember]
		public string dsEmail {get; set;}
		[DataMember]
		public string nbAlias {get; set;}
		[DataMember]
		public string codDepartamento {get; set;}
		[DataMember]
		public string nbDepartamento {get; set;}
		[DataMember]
		public string codUbicacionPago {get; set;}
		[DataMember]
		public string nbUbicacion {get; set;}
		[DataMember]
		public string codTipoNomina {get; set;}
		[DataMember]
		public string dsTipoNomina {get; set;}
		[DataMember]
		public string feNacimiento {get; set;}
		[DataMember]
		public string dsFehaAntiguedad {get; set;}
		[DataMember]
		public string GENERO {get; set;}
		[DataMember]
		public string codTipoEmpleado {get; set;}
		[DataMember]
		public string dsRfc {get; set;}
		[DataMember]
		public string dsCURP { get; set; }
        [DataMember]
        public bool esConfidencial { get; set; }
        [DataMember]
        public bool esActivo { get; set; }
        [DataMember]
        public string esSindicalizado { get; set; }
        [DataMember]
        public string NSS { get; set; }
        #endregion

        #region Constructors
        public Empleado()
		{
			noGrupo = 0;
			Grupo = string.Empty;
			codSector = string.Empty;
			nbSector = string.Empty;
			codEmpresa = string.Empty;
			nbEmpresa = string.Empty;
			codFilial = string.Empty;
			nbFilial = string.Empty;
			codJerarquia = string.Empty;
			nbJerarquia = string.Empty;
			noEmpleado = string.Empty;
			nbEmpleado = string.Empty;
			apPaterno = string.Empty;
			apMaterno = string.Empty;
			dsEmail = string.Empty;
			nbAlias = string.Empty;
			codDepartamento = string.Empty;
			nbDepartamento = string.Empty;
			codUbicacionPago = string.Empty;
			nbUbicacion = string.Empty;
			codTipoNomina = string.Empty;
			dsTipoNomina = string.Empty;
			feNacimiento = string.Empty;
			dsFehaAntiguedad = string.Empty;
			GENERO = string.Empty;
			codTipoEmpleado = string.Empty;
			dsRfc = string.Empty;
			dsCURP = string.Empty;
            esConfidencial = false;
            esActivo = false;
            esSindicalizado = string.Empty;
            NSS = string.Empty;

        }
		#endregion

		#region IDataContainer Members
		public void LoadDataFrom(IDataReader reader)
		{
			if (!reader.Read()) return;
			if (!Convert.IsDBNull(reader["noGrupo"])) noGrupo = Int32.Parse(reader["noGrupo"].ToString());
			if (!Convert.IsDBNull(reader["Grupo"])) Grupo = reader["Grupo"].ToString();
			if (!Convert.IsDBNull(reader["codSector"])) codSector = reader["codSector"].ToString();
			if (!Convert.IsDBNull(reader["nbSector"])) nbSector = reader["nbSector"].ToString();
			if (!Convert.IsDBNull(reader["codEmpresa"])) codEmpresa = reader["codEmpresa"].ToString();
			if (!Convert.IsDBNull(reader["nbEmpresa"])) nbEmpresa = reader["nbEmpresa"].ToString();
			if (!Convert.IsDBNull(reader["codFilial"])) codFilial = reader["codFilial"].ToString();
			if (!Convert.IsDBNull(reader["nbFilial"])) nbFilial = reader["nbFilial"].ToString();
			if (!Convert.IsDBNull(reader["codJerarquia"])) codJerarquia = reader["codJerarquia"].ToString();
			if (!Convert.IsDBNull(reader["nbJerarquia"])) nbJerarquia = reader["nbJerarquia"].ToString();
			if (!Convert.IsDBNull(reader["noEmpleado"])) noEmpleado = reader["noEmpleado"].ToString();
			if (!Convert.IsDBNull(reader["nbEmpleado"])) nbEmpleado = reader["nbEmpleado"].ToString();
			if (!Convert.IsDBNull(reader["apPaterno"])) apPaterno = reader["apPaterno"].ToString();
			if (!Convert.IsDBNull(reader["apMaterno"])) apMaterno = reader["apMaterno"].ToString();
			if (!Convert.IsDBNull(reader["dsEmail"])) dsEmail = reader["dsEmail"].ToString();
			if (!Convert.IsDBNull(reader["nbAlias"])) nbAlias = reader["nbAlias"].ToString();
			if (!Convert.IsDBNull(reader["codDepartamento"])) codDepartamento = reader["codDepartamento"].ToString();
			if (!Convert.IsDBNull(reader["nbDepartamento"])) nbDepartamento = reader["nbDepartamento"].ToString();
			if (!Convert.IsDBNull(reader["codUbicacionPago"])) codUbicacionPago = reader["codUbicacionPago"].ToString();
			if (!Convert.IsDBNull(reader["nbUbicacion"])) nbUbicacion = reader["nbUbicacion"].ToString();
			if (!Convert.IsDBNull(reader["codTipoNomina"])) codTipoNomina = reader["codTipoNomina"].ToString();
			if (!Convert.IsDBNull(reader["dsTipoNomina"])) dsTipoNomina = reader["dsTipoNomina"].ToString();
            if (!Convert.IsDBNull(reader["feNacimiento"])) feNacimiento = reader["feNacimiento"].ToString();
            if (!Convert.IsDBNull(reader["dsFehaAntiguedad"])) dsFehaAntiguedad = reader["dsFehaAntiguedad"].ToString();
			if (!Convert.IsDBNull(reader["GENERO"])) GENERO = reader["GENERO"].ToString();
			if (!Convert.IsDBNull(reader["codTipoEmpleado"])) codTipoEmpleado = reader["codTipoEmpleado"].ToString();
			if (!Convert.IsDBNull(reader["dsRfc"])) dsRfc = reader["dsRfc"].ToString();
			if (!Convert.IsDBNull(reader["dsCURP"])) dsCURP = reader["dsCURP"].ToString();
            if (!Convert.IsDBNull(reader["esConfidencial"])) esConfidencial = Convert.ToInt32(reader["esConfidencial"]) != 0;
            if (!Convert.IsDBNull(reader["esActivo"])) esActivo = Convert.ToInt32(reader["esActivo"]) != 0;

            if (!Convert.IsDBNull(reader["esSindicalizado"])) esSindicalizado = reader["esSindicalizado"].ToString();
            if (!Convert.IsDBNull(reader["NSS"])) NSS = reader["NSS"].ToString();
      

        }

        public void SetDataTo(IDataParameterCollection pars)
		{
			throw new NotImplementedException();
		}
		#endregion IDataContainer Members
	}

	// frosasl: Búsqueda de Empleados por criterios (Boletos de Avión)
	/// <summary>
	/// Lista de Elementos Empleado
	/// </summary>
	[Serializable,
	DataContract]
	public class EmpleadosList:IDataContainer
	{
		#region Properties
		[DataMember]
		public List<Empleado> lstEmpleados { get; set; }
		#endregion

		#region Constructors
		public EmpleadosList()
		{
			lstEmpleados = new List<Empleado>();
		}
		#endregion

		#region IDataContainer Members
		void IDataContainer.LoadDataFrom(IDataReader reader)
		{
			lstEmpleados = new List<Empleado>();
			while (reader.Read())
			{
				Empleado oEmpleado = new Empleado();
				if (!Convert.IsDBNull(reader["noGrupo"])) oEmpleado.noGrupo = Int32.Parse(reader["noGrupo"].ToString());
				if (!Convert.IsDBNull(reader["Grupo"])) oEmpleado.Grupo = reader["Grupo"].ToString();
				if (!Convert.IsDBNull(reader["codSector"])) oEmpleado.codSector = reader["codSector"].ToString();
				if (!Convert.IsDBNull(reader["nbSector"])) oEmpleado.nbSector = reader["nbSector"].ToString();
				if (!Convert.IsDBNull(reader["codEmpresa"])) oEmpleado.codEmpresa = reader["codEmpresa"].ToString();
				if (!Convert.IsDBNull(reader["nbEmpresa"])) oEmpleado.nbEmpresa = reader["nbEmpresa"].ToString();
				if (!Convert.IsDBNull(reader["codFilial"])) oEmpleado.codFilial = reader["codFilial"].ToString();
				if (!Convert.IsDBNull(reader["nbFilial"])) oEmpleado.nbFilial = reader["nbFilial"].ToString();
				if (!Convert.IsDBNull(reader["codJerarquia"])) oEmpleado.codJerarquia = reader["codJerarquia"].ToString();
				if (!Convert.IsDBNull(reader["nbJerarquia"])) oEmpleado.nbJerarquia = reader["nbJerarquia"].ToString();
				if (!Convert.IsDBNull(reader["noEmpleado"])) oEmpleado.noEmpleado = reader["noEmpleado"].ToString();
				if (!Convert.IsDBNull(reader["nbEmpleado"])) oEmpleado.nbEmpleado = reader["nbEmpleado"].ToString();
				if (!Convert.IsDBNull(reader["apPaterno"])) oEmpleado.apPaterno = reader["apPaterno"].ToString();
				if (!Convert.IsDBNull(reader["apMaterno"])) oEmpleado.apMaterno = reader["apMaterno"].ToString();
				if (!Convert.IsDBNull(reader["dsEmail"])) oEmpleado.dsEmail = reader["dsEmail"].ToString();
				if (!Convert.IsDBNull(reader["nbAlias"])) oEmpleado.nbAlias = reader["nbAlias"].ToString();
				if (!Convert.IsDBNull(reader["codDepartamento"])) oEmpleado.codDepartamento = reader["codDepartamento"].ToString();
				if (!Convert.IsDBNull(reader["nbDepartamento"])) oEmpleado.nbDepartamento = reader["nbDepartamento"].ToString();
				if (!Convert.IsDBNull(reader["codUbicacionPago"])) oEmpleado.codUbicacionPago = reader["codUbicacionPago"].ToString();
				if (!Convert.IsDBNull(reader["nbUbicacion"])) oEmpleado.nbUbicacion = reader["nbUbicacion"].ToString();
				if (!Convert.IsDBNull(reader["codTipoNomina"])) oEmpleado.codTipoNomina = reader["codTipoNomina"].ToString();
				if (!Convert.IsDBNull(reader["dsTipoNomina"])) oEmpleado.dsTipoNomina = reader["dsTipoNomina"].ToString();
				if (!Convert.IsDBNull(reader["feNacimiento"])) oEmpleado.feNacimiento = reader["feNacimiento"].ToString();
				if (!Convert.IsDBNull(reader["dsFehaAntiguedad"])) oEmpleado.dsFehaAntiguedad = reader["dsFehaAntiguedad"].ToString();
				if (!Convert.IsDBNull(reader["GENERO"])) oEmpleado.GENERO = reader["GENERO"].ToString();
				if (!Convert.IsDBNull(reader["codTipoEmpleado"])) oEmpleado.codTipoEmpleado = reader["codTipoEmpleado"].ToString();
				if (!Convert.IsDBNull(reader["dsRfc"])) oEmpleado.dsRfc = reader["dsRfc"].ToString();
				if (!Convert.IsDBNull(reader["dsCURP"])) oEmpleado.dsCURP = reader["dsCURP"].ToString();
                if (!Convert.IsDBNull(reader["esConfidencial"])) oEmpleado.esConfidencial = Convert.ToInt32(reader["esConfidencial"]) != 0;
                if (!Convert.IsDBNull(reader["esActivo"])) oEmpleado.esActivo = Convert.ToInt32(reader["esActivo"]) != 0;

                if (!Convert.IsDBNull(reader["esSindicalizado"])) oEmpleado.esSindicalizado = reader["esSindicalizado"].ToString();
                if (!Convert.IsDBNull(reader["NSS"])) oEmpleado.NSS = reader["NSS"].ToString();

               
                lstEmpleados.Add(oEmpleado);
			}
		}

		void IDataContainer.SetDataTo(IDataParameterCollection pars)
		{
			//throw new NotImplementedException();
		}
		#endregion
	}
}