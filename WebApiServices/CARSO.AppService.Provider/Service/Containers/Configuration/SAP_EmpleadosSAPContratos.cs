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
	/// Datos de Contratación de Empleados
	/// </summary>
	[Serializable]
	[DataContract(IsReference = true)]
	public class EmpleadosSAPContratos : IDataContainer
	{
		#region Properties
		[DataMember]
		public string codTipoContrato { get; set; }
		[DataMember]
		public string nbTipoContrato { get; set; }
		/// </summary>
		[DataMember]
		public Int32 noDiasRenovar { get; set; }
		/// </summary>
		[DataMember]
		public string codEstadoExpedicion { get; set; }
		/// </summary>
		[DataMember]
		public string nbEstadoExpedicion { get; set; }
		/// </summary>
		[DataMember]
		public string codMunicipioExpedicion { get; set; }
		/// </summary>
		[DataMember]
		public string nbMunicipioExpedicion { get; set; }
		/// </summary>
		[DataMember]
		public string noEmpleado { get; set; }
		/// </summary>
		[DataMember]
		public string nbEmpleado { get; set; }
		/// </summary>
		[DataMember]
		public string apPaternoEmpleado { get; set; }
		/// </summary>
		[DataMember]
		public string apMaternoEmpleado { get; set; }
		/// </summary>
		[DataMember]
		public string codAreaNomina { get; set; }
		/// </summary>
		[DataMember]
		public string nbAreaNomina { get; set; }
		/// </summary>
		[DataMember]
		public string codFuncion { get; set; }
		/// </summary>
		[DataMember]
		public string nbFuncion { get; set; }
		/// </summary>
		[DataMember]
		public string noEmpleadoJefe { get; set; }
		/// </summary>
		[DataMember]
		public string nbJefe { get; set; }
		/// </summary>
		[DataMember]
		public string apPaternoJefe { get; set; }
		/// </summary>
		[DataMember]
		public string apMaternoJefe { get; set; }
		/// </summary>
		[DataMember]
		public string dsEmpleadoDomCalle { get; set; }
		/// </summary>
		[DataMember]
		public string dsEmpleadoDomNumExt { get; set; }
		/// </summary>
		[DataMember]
		public string dsEmpleadoDomNumInt { get; set; }
		/// </summary>
		[DataMember]
		public string dsEmpleadoDomColonia { get; set; }
		/// </summary>
		[DataMember]
		public string dsEmpleadoDomCP { get; set; }
		/// </summary>
		[DataMember]
		public string codEstadoEmpleado { get; set; }
		/// </summary>
		[DataMember]
		public string nbEstadoEmpleado { get; set; }
		/// </summary>
		[DataMember]
		public string codMunicipioEmpleado { get; set; }
		/// </summary>
		[DataMember]
		public string nbMunicipioEmpleado { get; set; }
		/// </summary>
		[DataMember]
		public string codPaisEmpleado { get; set; }
		/// </summary>
		[DataMember]
		public string nbPaisEmpleado { get; set; }
		/// </summary>
		[DataMember]
		public string codNacionalidadEmpleado { get; set; }
		/// </summary>
		[DataMember]
		public string nbNacionalidadEmpleado { get; set; }
		/// </summary>
		[DataMember]
		public string feNacimiento { get; set; }
		/// </summary>
		[DataMember]
		public Int32 noEdad { get; set; }
		/// </summary>
		[DataMember]
		public string codEstadoCivil { get; set; }
		/// </summary>
		[DataMember]
		public string nbEstadoCivil { get; set; }
		/// </summary>
		[DataMember]
		public string dsRFC { get; set; }
		/// </summary>
		[DataMember]
		public string dsCURP { get; set; }
		/// </summary>
		[DataMember]
		public string noSS { get; set; }
		/// </summary>
		[DataMember]
		public decimal mnSueldoMensual { get; set; }
		/// </summary>
		[DataMember]
		public string noTelefonoFijo { get; set; }
		/// </summary>
		[DataMember]
		public string noTelefonoMovil { get; set; }
		/// </summary>
		[DataMember]
		public string nbAlias { get; set; }
		/// </summary>
		[DataMember]
		public string nbDominio { get; set; }
		/// </summary>
		[DataMember]
		public decimal noProcPrimaVacacional { get; set; }
		/// </summary>
		[DataMember]
		public Int32 noDiasAguinaldo { get; set; }
		/// </summary>
		[DataMember]
		public string codSociedad { get; set; }
		/// </summary>
		[DataMember]
		public string nbSociedad { get; set; }
		/// </summary>
		[DataMember]
		public string nbRepresentanteLegal { get; set; }
		/// </summary>
		[DataMember]
		public string codEdificio { get; set; }
		/// </summary>
		[DataMember]
		public string nbEdificio { get; set; }
		/// </summary>
		[DataMember]
		public string dsSociedadDomCalle { get; set; }
		/// </summary>
		[DataMember]
		public string dsSociedadDomNumExt { get; set; }
		/// </summary>
		[DataMember]
		public string dsSociedadDomNumInt { get; set; }
		/// </summary>
		[DataMember]
		public string dsSociedadDomColonia { get; set; }
		/// </summary>
		[DataMember]
		public string dsSociedadDomCP { get; set; }
		/// </summary>
		[DataMember]
		public string codEstadoSociedad { get; set; }
		/// </summary>
		[DataMember]
		public string nbEstadoSociedad { get; set; }
		/// </summary>
		[DataMember]
		public string codMunicipioSociedad { get; set; }
		/// </summary>
		[DataMember]
		public string nbMunicipioSociedad { get; set; }
		/// </summary>
		[DataMember]
		public string codPaisSociedad { get; set; }
		/// </summary>
		[DataMember]
		public string nbPaisSociedad { get; set; }
		/// </summary>
		[DataMember]
		public string dsMotivo { get; set; }
		/// </summary>
		[DataMember]
		public string dsLabores { get; set; }
		/// </summary>
		[DataMember]
		public string feFinContrato { get; set; }
		/// </summary>
		[DataMember]
		public string codTipoPosicion { get; set; }
		/// </summary>
		[DataMember]
		public string nbTipoPosicion { get; set; }
		/// </summary>
		[DataMember]
		public Int32 noDuracionJornada { get; set; }
		/// </summary>
		[DataMember]
		public Int32 noDiasTrabajados { get; set; }
		/// </summary>
		[DataMember]
		public Int32 idCodigoDiaPago { get; set; }
		/// </summary>
		[DataMember]
		public string nbDiaPago { get; set; }
		/// </summary>
		[DataMember]
		public Int32 idCodigoDiaSemanaInicio { get; set; }
		/// </summary>
		[DataMember]
		public string nbDiaSemanaInicio { get; set; }
		/// </summary>
		[DataMember]
		public Int32 idCodigoDiaSemanaFin { get; set; }
		/// </summary>
		[DataMember]
		public string nbDiaSemanaFin { get; set; }
		/// </summary>
		[DataMember]
		public Int32 idCodigoHrInicio { get; set; }
		/// </summary>
		[DataMember]
		public string hrEntrada { get; set; }
		/// </summary>
		[DataMember]
		public Int32 idCodigoHrFin { get; set; }
		/// </summary>
		[DataMember]
		public string hrSalida { get; set; }
		/// </summary>
		[DataMember]
		public bool esTrabajaSabado { get; set; }
		/// </summary>
		[DataMember]
		public Int32 idCodigoHrInicioSabado { get; set; }
		/// </summary>
		[DataMember]
		public string hrEntradaSabado { get; set; }
		/// </summary>
		[DataMember]
		public Int32 idCodigoHrFinSabado { get; set; }
		/// </summary>
		[DataMember]
		public string hrSalidaSabado { get; set; }
		/// </summary>
		[DataMember]
		public Int32 noMinutosDescanso { get; set; }
		/// </summary>
		/// 
		[DataMember]
		public string codDivision { get; set; }
		[DataMember]
		public string nbDivision { get; set; }
		[DataMember]
		public string codSubdivision { get; set; }
		[DataMember]
		public string nbSubdivision { get; set; }
		[DataMember]
		public string codCentroCosto { get; set; }
		[DataMember]
		public string nbCentroCosto { get; set; }
		[DataMember]
		public string dsMailJefe { get; set; }
		[DataMember]
		public string nbAliasJefe { get; set; }
		[DataMember]
		public string codAreaPersonal { get; set; }
		[DataMember]
		public string nbAreaPersonal { get; set; }
		[DataMember]
		public string feAlta { get; set; }
		[DataMember]
		public string feAntiguedad { get; set; }
		[DataMember]
		public string codDepartamento { get; set; }
		[DataMember]
		public string nbDepartamento { get; set; }
		[DataMember]
		public string feFinPosicion { get; set; }
		[DataMember]
		public bool esActivo { get; set; }
		#endregion Properties

		#region Constructors
		/// <summary>
		/// Constructor de la Clase Datos de Contratación de Empleados  
		/// </summary>
		public EmpleadosSAPContratos()
		{
			this.codTipoContrato = string.Empty;
			this.nbTipoContrato = string.Empty;
			this.noDiasRenovar = 0;
			this.codEstadoExpedicion = string.Empty;
			this.nbEstadoExpedicion = string.Empty;
			this.codMunicipioExpedicion = string.Empty;
			this.nbMunicipioExpedicion = string.Empty;
			this.noEmpleado = string.Empty;
			this.nbEmpleado = string.Empty;
			this.apPaternoEmpleado = string.Empty;
			this.apMaternoEmpleado = string.Empty;
			this.codAreaNomina = string.Empty;
			this.nbAreaNomina = string.Empty;
			this.codFuncion = string.Empty;
			this.nbFuncion = string.Empty;
			this.noEmpleadoJefe = string.Empty;
			this.nbJefe = string.Empty;
			this.apPaternoJefe = string.Empty;
			this.apMaternoJefe = string.Empty;
			this.dsEmpleadoDomCalle = string.Empty;
			this.dsEmpleadoDomNumExt = string.Empty;
			this.dsEmpleadoDomNumInt = string.Empty;
			this.dsEmpleadoDomColonia = string.Empty;
			this.dsEmpleadoDomCP = string.Empty;
			this.codEstadoEmpleado = string.Empty;
			this.nbEstadoEmpleado = string.Empty;
			this.codMunicipioEmpleado = string.Empty;
			this.nbMunicipioEmpleado = string.Empty;
			this.codPaisEmpleado = string.Empty;
			this.nbPaisEmpleado = string.Empty;
			this.codNacionalidadEmpleado = string.Empty;
			this.nbNacionalidadEmpleado = string.Empty;
			this.feNacimiento = string.Empty;
			this.noEdad = 0;
			this.codEstadoCivil = string.Empty;
			this.nbEstadoCivil = string.Empty;
			this.dsRFC = string.Empty;
			this.dsCURP = string.Empty;
			this.noSS = string.Empty;
			this.mnSueldoMensual = 0;
			this.noTelefonoFijo = string.Empty;
			this.noTelefonoMovil = string.Empty;
			this.nbAlias = string.Empty;
			this.nbDominio = string.Empty;
			this.noProcPrimaVacacional = 0;
			this.noDiasAguinaldo = 0;
			this.codSociedad = string.Empty;
			this.nbSociedad = string.Empty;
			this.nbRepresentanteLegal = string.Empty;
			this.codEdificio = string.Empty;
			this.nbEdificio = string.Empty;
			this.dsSociedadDomCalle = string.Empty;
			this.dsSociedadDomNumExt = string.Empty;
			this.dsSociedadDomNumInt = string.Empty;
			this.dsSociedadDomColonia = string.Empty;
			this.dsSociedadDomCP = string.Empty;
			this.codEstadoSociedad = string.Empty;
			this.nbEstadoSociedad = string.Empty;
			this.codMunicipioSociedad = string.Empty;
			this.nbMunicipioSociedad = string.Empty;
			this.codPaisSociedad = string.Empty;
			this.nbPaisSociedad = string.Empty;
			this.dsMotivo = string.Empty;
			this.dsLabores = string.Empty;
			this.feFinContrato = string.Empty;
			this.codTipoPosicion = string.Empty;
			this.nbTipoPosicion = string.Empty;
			this.noDuracionJornada = 0;
			this.noDiasTrabajados = 0;
			this.idCodigoDiaPago = 0;
			this.nbDiaPago = string.Empty;
			this.idCodigoDiaSemanaInicio = 0;
			this.nbDiaSemanaInicio = string.Empty;
			this.idCodigoDiaSemanaFin = 0;
			this.nbDiaSemanaFin = string.Empty;
			this.idCodigoHrInicio = 0;
			this.hrEntrada = string.Empty;
			this.idCodigoHrFin = 0;
			this.hrSalida = string.Empty;
			this.esTrabajaSabado = false;
			this.idCodigoHrInicioSabado = 0;
			this.hrEntradaSabado = string.Empty;
			this.idCodigoHrFinSabado = 0;
			this.hrSalidaSabado = string.Empty;
			this.noMinutosDescanso = 0;

			codDivision = string.Empty;
			nbDivision = string.Empty;
			codSubdivision = string.Empty;
			nbSubdivision = string.Empty;
			codCentroCosto = string.Empty;
			nbCentroCosto = string.Empty;
			dsMailJefe = string.Empty;
			nbAliasJefe = string.Empty;


			codAreaPersonal = string.Empty;
			nbAreaPersonal = string.Empty;
			feAlta       = string.Empty;
			feAntiguedad = string.Empty;
			codDepartamento = string.Empty;
			nbDepartamento = string.Empty;
			feFinPosicion = string.Empty;
		}
		#endregion Constructors

		#region Compare
		public int CompareTo(EmpleadosSAPContratos rhs, EmpleadosSAPContratos.EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion which)
		{
			switch (which)
			{

				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.noDiasRenovar: return this.noDiasRenovar.CompareTo(rhs.noDiasRenovar);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.codEstadoExpedicion: return this.codEstadoExpedicion.CompareTo(rhs.codEstadoExpedicion);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbEstadoExpedicion: return this.nbEstadoExpedicion.CompareTo(rhs.nbEstadoExpedicion);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.codMunicipioExpedicion: return this.codMunicipioExpedicion.CompareTo(rhs.codMunicipioExpedicion);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbMunicipioExpedicion: return this.nbMunicipioExpedicion.CompareTo(rhs.nbMunicipioExpedicion);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.noEmpleado: return this.noEmpleado.CompareTo(rhs.noEmpleado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbEmpleado: return this.nbEmpleado.CompareTo(rhs.nbEmpleado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.apPaternoEmpleado: return this.apPaternoEmpleado.CompareTo(rhs.apPaternoEmpleado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.apMaternoEmpleado: return this.apMaternoEmpleado.CompareTo(rhs.apMaternoEmpleado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.codAreaNomina: return this.codAreaNomina.CompareTo(rhs.codAreaNomina);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbAreaNomina: return this.nbAreaNomina.CompareTo(rhs.nbAreaNomina);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.codFuncion: return this.codFuncion.CompareTo(rhs.codFuncion);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbFuncion: return this.nbFuncion.CompareTo(rhs.nbFuncion);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.noEmpleadoJefe: return this.noEmpleadoJefe.CompareTo(rhs.noEmpleadoJefe);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbJefe: return this.nbJefe.CompareTo(rhs.nbJefe);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.apPaternoJefe: return this.apPaternoJefe.CompareTo(rhs.apPaternoJefe);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.apMaternoJefe: return this.apMaternoJefe.CompareTo(rhs.apMaternoJefe);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.dsEmpleadoDomCalle: return this.dsEmpleadoDomCalle.CompareTo(rhs.dsEmpleadoDomCalle);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.dsEmpleadoDomNumExt: return this.dsEmpleadoDomNumExt.CompareTo(rhs.dsEmpleadoDomNumExt);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.dsEmpleadoDomNumInt: return this.dsEmpleadoDomNumInt.CompareTo(rhs.dsEmpleadoDomNumInt);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.dsEmpleadoDomColonia: return this.dsEmpleadoDomColonia.CompareTo(rhs.dsEmpleadoDomColonia);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.dsEmpleadoDomCP: return this.dsEmpleadoDomCP.CompareTo(rhs.dsEmpleadoDomCP);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.codEstadoEmpleado: return this.codEstadoEmpleado.CompareTo(rhs.codEstadoEmpleado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbEstadoEmpleado: return this.nbEstadoEmpleado.CompareTo(rhs.nbEstadoEmpleado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.codMunicipioEmpleado: return this.codMunicipioEmpleado.CompareTo(rhs.codMunicipioEmpleado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbMunicipioEmpleado: return this.nbMunicipioEmpleado.CompareTo(rhs.nbMunicipioEmpleado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.codPaisEmpleado: return this.codPaisEmpleado.CompareTo(rhs.codPaisEmpleado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbPaisEmpleado: return this.nbPaisEmpleado.CompareTo(rhs.nbPaisEmpleado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.codNacionalidadEmpleado: return this.codNacionalidadEmpleado.CompareTo(rhs.codNacionalidadEmpleado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbNacionalidadEmpleado: return this.nbNacionalidadEmpleado.CompareTo(rhs.nbNacionalidadEmpleado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.feNacimiento: return this.feNacimiento.CompareTo(rhs.feNacimiento);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.noEdad: return this.noEdad.CompareTo(rhs.noEdad);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.codEstadoCivil: return this.codEstadoCivil.CompareTo(rhs.codEstadoCivil);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbEstadoCivil: return this.nbEstadoCivil.CompareTo(rhs.nbEstadoCivil);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.dsRFC: return this.dsRFC.CompareTo(rhs.dsRFC);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.dsCURP: return this.dsCURP.CompareTo(rhs.dsCURP);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.noSS: return this.noSS.CompareTo(rhs.noSS);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.mnSueldoMensual: return this.mnSueldoMensual.CompareTo(rhs.mnSueldoMensual);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.noTelefonoFijo: return this.noTelefonoFijo.CompareTo(rhs.noTelefonoFijo);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.noTelefonoMovil: return this.noTelefonoMovil.CompareTo(rhs.noTelefonoMovil);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbAlias: return this.nbAlias.CompareTo(rhs.nbAlias);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbDominio: return this.nbDominio.CompareTo(rhs.nbDominio);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.noProcPrimaVacacional: return this.noProcPrimaVacacional.CompareTo(rhs.noProcPrimaVacacional);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.noDiasAguinaldo: return this.noDiasAguinaldo.CompareTo(rhs.noDiasAguinaldo);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.codSociedad: return this.codSociedad.CompareTo(rhs.codSociedad);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbSociedad: return this.nbSociedad.CompareTo(rhs.nbSociedad);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbRepresentanteLegal: return this.nbRepresentanteLegal.CompareTo(rhs.nbRepresentanteLegal);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.codEdificio: return this.codEdificio.CompareTo(rhs.codEdificio);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbEdificio: return this.nbEdificio.CompareTo(rhs.nbEdificio);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.dsSociedadDomCalle: return this.dsSociedadDomCalle.CompareTo(rhs.dsSociedadDomCalle);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.dsSociedadDomNumExt: return this.dsSociedadDomNumExt.CompareTo(rhs.dsSociedadDomNumExt);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.dsSociedadDomNumInt: return this.dsSociedadDomNumInt.CompareTo(rhs.dsSociedadDomNumInt);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.dsSociedadDomColonia: return this.dsSociedadDomColonia.CompareTo(rhs.dsSociedadDomColonia);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.dsSociedadDomCP: return this.dsSociedadDomCP.CompareTo(rhs.dsSociedadDomCP);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.codEstadoSociedad: return this.codEstadoSociedad.CompareTo(rhs.codEstadoSociedad);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbEstadoSociedad: return this.nbEstadoSociedad.CompareTo(rhs.nbEstadoSociedad);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.codMunicipioSociedad: return this.codMunicipioSociedad.CompareTo(rhs.codMunicipioSociedad);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbMunicipioSociedad: return this.nbMunicipioSociedad.CompareTo(rhs.nbMunicipioSociedad);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.codPaisSociedad: return this.codPaisSociedad.CompareTo(rhs.codPaisSociedad);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbPaisSociedad: return this.nbPaisSociedad.CompareTo(rhs.nbPaisSociedad);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.dsMotivo: return this.dsMotivo.CompareTo(rhs.dsMotivo);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.dsLabores: return this.dsLabores.CompareTo(rhs.dsLabores);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.feFinContrato: return this.feFinContrato.CompareTo(rhs.feFinContrato);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.codTipoPosicion: return this.codTipoPosicion.CompareTo(rhs.codTipoPosicion);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbTipoPosicion: return this.nbTipoPosicion.CompareTo(rhs.nbTipoPosicion);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.noDuracionJornada: return this.noDuracionJornada.CompareTo(rhs.noDuracionJornada);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.noDiasTrabajados: return this.noDiasTrabajados.CompareTo(rhs.noDiasTrabajados);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.idCodigoDiaPago: return this.idCodigoDiaPago.CompareTo(rhs.idCodigoDiaPago);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbDiaPago: return this.nbDiaPago.CompareTo(rhs.nbDiaPago);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.idCodigoDiaSemanaInicio: return this.idCodigoDiaSemanaInicio.CompareTo(rhs.idCodigoDiaSemanaInicio);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbDiaSemanaInicio: return this.nbDiaSemanaInicio.CompareTo(rhs.nbDiaSemanaInicio);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.idCodigoDiaSemanaFin: return this.idCodigoDiaSemanaFin.CompareTo(rhs.idCodigoDiaSemanaFin);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.nbDiaSemanaFin: return this.nbDiaSemanaFin.CompareTo(rhs.nbDiaSemanaFin);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.idCodigoHrInicio: return this.idCodigoHrInicio.CompareTo(rhs.idCodigoHrInicio);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.hrEntrada: return this.hrEntrada.CompareTo(rhs.hrEntrada);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.idCodigoHrFin: return this.idCodigoHrFin.CompareTo(rhs.idCodigoHrFin);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.hrSalida: return this.hrSalida.CompareTo(rhs.hrSalida);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.esTrabajaSabado: return this.esTrabajaSabado.CompareTo(rhs.esTrabajaSabado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.idCodigoHrInicioSabado: return this.idCodigoHrInicioSabado.CompareTo(rhs.idCodigoHrInicioSabado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.hrEntradaSabado: return this.hrEntradaSabado.CompareTo(rhs.hrEntradaSabado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.idCodigoHrFinSabado: return this.idCodigoHrFinSabado.CompareTo(rhs.idCodigoHrFinSabado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.hrSalidaSabado: return this.hrSalidaSabado.CompareTo(rhs.hrSalidaSabado);
				case EmpleadosSAPContratosComparer.EmpleadosSAPContratosTipoComparacion.noMinutosDescanso: return this.noMinutosDescanso.CompareTo(rhs.noMinutosDescanso);
			  
			}
			return 0;
		}
		public class EmpleadosSAPContratosComparer : IComparer<EmpleadosSAPContratos>
		{
			public enum EmpleadosSAPContratosTipoComparacion
			{
			   
				noDiasRenovar,
				codEstadoExpedicion,
				nbEstadoExpedicion,
				codMunicipioExpedicion,
				nbMunicipioExpedicion,
				noEmpleado,
				nbEmpleado,
				apPaternoEmpleado,
				apMaternoEmpleado,
				codAreaNomina,
				nbAreaNomina,
				codFuncion,
				nbFuncion,
				noEmpleadoJefe,
				nbJefe,
				apPaternoJefe,
				apMaternoJefe,
				dsEmpleadoDomCalle,
				dsEmpleadoDomNumExt,
				dsEmpleadoDomNumInt,
				dsEmpleadoDomColonia,
				dsEmpleadoDomCP,
				codEstadoEmpleado,
				nbEstadoEmpleado,
				codMunicipioEmpleado,
				nbMunicipioEmpleado,
				codPaisEmpleado,
				nbPaisEmpleado,
				codNacionalidadEmpleado,
				nbNacionalidadEmpleado,
				feNacimiento,
				noEdad,
				codEstadoCivil,
				nbEstadoCivil,
				dsRFC,
				dsCURP,
				noSS,
				mnSueldoMensual,
				noTelefonoFijo,
				noTelefonoMovil,
				nbAlias,
				nbDominio,
				noProcPrimaVacacional,
				noDiasAguinaldo,
				codSociedad,
				nbSociedad,
				nbRepresentanteLegal,
				codEdificio,
				nbEdificio,
				dsSociedadDomCalle,
				dsSociedadDomNumExt,
				dsSociedadDomNumInt,
				dsSociedadDomColonia,
				dsSociedadDomCP,
				codEstadoSociedad,
				nbEstadoSociedad,
				codMunicipioSociedad,
				nbMunicipioSociedad,
				codPaisSociedad,
				nbPaisSociedad,
				dsMotivo,
				dsLabores,
				feFinContrato,
				codTipoPosicion,
				nbTipoPosicion,
				noDuracionJornada,
				noDiasTrabajados,
				idCodigoDiaPago,
				nbDiaPago,
				idCodigoDiaSemanaInicio,
				nbDiaSemanaInicio,
				idCodigoDiaSemanaFin,
				nbDiaSemanaFin,
				idCodigoHrInicio,
				hrEntrada,
				idCodigoHrFin,
				hrSalida,
				esTrabajaSabado,
				idCodigoHrInicioSabado,
				hrEntradaSabado,
				idCodigoHrFinSabado,
				hrSalidaSabado,
				noMinutosDescanso,
			

				NULL
			}
			private EmpleadosSAPContratosTipoComparacion _whichComparison;
			private TipoOrdenamiento _sortDirection;
			public EmpleadosSAPContratosTipoComparacion WhichComparison
			{
				get { return _whichComparison; }
				set { _whichComparison = value; }
			}

			public int Compare(EmpleadosSAPContratos lhs, EmpleadosSAPContratos rhs)
			{
				return (SortDirection == TipoOrdenamiento.Asc) ? lhs.CompareTo(rhs, WhichComparison) : rhs.CompareTo(lhs, WhichComparison);
			}

			public bool Equals(EmpleadosSAPContratos lhs, EmpleadosSAPContratos rhs)
			{
				return this.Compare(lhs, rhs) == 0;
			}

			public int GetHashCode(EmpleadosSAPContratos e)
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

			if (!Convert.IsDBNull(reader["codTipoContrato"])) this.codTipoContrato = reader["codTipoContrato"] as string;
			if (!Convert.IsDBNull(reader["nbTipoContrato"])) this.nbTipoContrato = reader["nbTipoContrato"] as string;

			if (!Convert.IsDBNull(reader["noDiasRenovar"])) this.noDiasRenovar = Int32.Parse(reader["noDiasRenovar"].ToString());
			if (!Convert.IsDBNull(reader["codEstadoExpedicion"])) this.codEstadoExpedicion = reader["codEstadoExpedicion"] as string;
			if (!Convert.IsDBNull(reader["nbEstadoExpedicion"])) this.nbEstadoExpedicion = reader["nbEstadoExpedicion"] as string;
			if (!Convert.IsDBNull(reader["codMunicipioExpedicion"])) this.codMunicipioExpedicion = reader["codMunicipioExpedicion"] as string;
			if (!Convert.IsDBNull(reader["nbMunicipioExpedicion"])) this.nbMunicipioExpedicion = reader["nbMunicipioExpedicion"] as string;
			if (!Convert.IsDBNull(reader["noEmpleado"])) this.noEmpleado = reader["noEmpleado"] as string;
			if (!Convert.IsDBNull(reader["nbEmpleado"])) this.nbEmpleado = reader["nbEmpleado"] as string;
			if (!Convert.IsDBNull(reader["apPaternoEmpleado"])) this.apPaternoEmpleado = reader["apPaternoEmpleado"] as string;
			if (!Convert.IsDBNull(reader["apMaternoEmpleado"])) this.apMaternoEmpleado = reader["apMaternoEmpleado"] as string;
			if (!Convert.IsDBNull(reader["codAreaNomina"])) this.codAreaNomina = reader["codAreaNomina"] as string;
			if (!Convert.IsDBNull(reader["nbAreaNomina"])) this.nbAreaNomina = reader["nbAreaNomina"] as string;
			if (!Convert.IsDBNull(reader["codFuncion"])) this.codFuncion = reader["codFuncion"] as string;
			if (!Convert.IsDBNull(reader["nbFuncion"])) this.nbFuncion = reader["nbFuncion"] as string;
			if (!Convert.IsDBNull(reader["noEmpleadoJefe"])) this.noEmpleadoJefe = reader["noEmpleadoJefe"] as string;
			if (!Convert.IsDBNull(reader["nbJefe"])) this.nbJefe = reader["nbJefe"] as string;
			if (!Convert.IsDBNull(reader["apPaternoJefe"])) this.apPaternoJefe = reader["apPaternoJefe"] as string;
			if (!Convert.IsDBNull(reader["apMaternoJefe"])) this.apMaternoJefe = reader["apMaternoJefe"] as string;
			if (!Convert.IsDBNull(reader["dsEmpleadoDomCalle"])) this.dsEmpleadoDomCalle = reader["dsEmpleadoDomCalle"] as string;
			if (!Convert.IsDBNull(reader["dsEmpleadoDomNumExt"])) this.dsEmpleadoDomNumExt = reader["dsEmpleadoDomNumExt"] as string;
			if (!Convert.IsDBNull(reader["dsEmpleadoDomNumInt"])) this.dsEmpleadoDomNumInt = reader["dsEmpleadoDomNumInt"] as string;
			if (!Convert.IsDBNull(reader["dsEmpleadoDomColonia"])) this.dsEmpleadoDomColonia = reader["dsEmpleadoDomColonia"] as string;
			if (!Convert.IsDBNull(reader["dsEmpleadoDomCP"])) this.dsEmpleadoDomCP = reader["dsEmpleadoDomCP"] as string;
			if (!Convert.IsDBNull(reader["codEstadoEmpleado"])) this.codEstadoEmpleado = reader["codEstadoEmpleado"] as string;
			if (!Convert.IsDBNull(reader["nbEstadoEmpleado"])) this.nbEstadoEmpleado = reader["nbEstadoEmpleado"] as string;
			if (!Convert.IsDBNull(reader["codMunicipioEmpleado"])) this.codMunicipioEmpleado = reader["codMunicipioEmpleado"] as string;
			if (!Convert.IsDBNull(reader["nbMunicipioEmpleado"])) this.nbMunicipioEmpleado = reader["nbMunicipioEmpleado"] as string;
			if (!Convert.IsDBNull(reader["codPaisEmpleado"])) this.codPaisEmpleado = reader["codPaisEmpleado"] as string;
			if (!Convert.IsDBNull(reader["nbPaisEmpleado"])) this.nbPaisEmpleado = reader["nbPaisEmpleado"] as string;
			if (!Convert.IsDBNull(reader["codNacionalidadEmpleado"])) this.codNacionalidadEmpleado = reader["codNacionalidadEmpleado"] as string;
			if (!Convert.IsDBNull(reader["nbNacionalidadEmpleado"])) this.nbNacionalidadEmpleado = reader["nbNacionalidadEmpleado"] as string;
			if (!Convert.IsDBNull(reader["feNacimiento"])) this.feNacimiento =reader["feNacimiento"].ToString();
			if (!Convert.IsDBNull(reader["noEdad"])) this.noEdad = Int32.Parse(reader["noEdad"].ToString());
			if (!Convert.IsDBNull(reader["codEstadoCivil"])) this.codEstadoCivil = reader["codEstadoCivil"] as string;
			if (!Convert.IsDBNull(reader["nbEstadoCivil"])) this.nbEstadoCivil = reader["nbEstadoCivil"] as string;
			if (!Convert.IsDBNull(reader["dsRFC"])) this.dsRFC = reader["dsRFC"] as string;
			if (!Convert.IsDBNull(reader["dsCURP"])) this.dsCURP = reader["dsCURP"] as string;
			if (!Convert.IsDBNull(reader["noSS"])) this.noSS = reader["noSS"] as string;
			if (!Convert.IsDBNull(reader["mnSueldoMensual"])) this.mnSueldoMensual = decimal.Parse(reader["mnSueldoMensual"].ToString());
			if (!Convert.IsDBNull(reader["noTelefonoFijo"])) this.noTelefonoFijo = reader["noTelefonoFijo"] as string;
			if (!Convert.IsDBNull(reader["noTelefonoMovil"])) this.noTelefonoMovil = reader["noTelefonoMovil"] as string;
			if (!Convert.IsDBNull(reader["nbAlias"])) this.nbAlias = reader["nbAlias"] as string;
			if (!Convert.IsDBNull(reader["nbDominio"])) this.nbDominio = reader["nbDominio"] as string;
			if (!Convert.IsDBNull(reader["noProcPrimaVacacional"])) this.noProcPrimaVacacional = decimal.Parse(reader["noProcPrimaVacacional"].ToString());
			if (!Convert.IsDBNull(reader["noDiasAguinaldo"])) this.noDiasAguinaldo = Int32.Parse(reader["noDiasAguinaldo"].ToString());
			if (!Convert.IsDBNull(reader["codSociedad"])) this.codSociedad = reader["codSociedad"] as string;
			if (!Convert.IsDBNull(reader["nbSociedad"])) this.nbSociedad = reader["nbSociedad"] as string;
			if (!Convert.IsDBNull(reader["nbRepresentanteLegal"])) this.nbRepresentanteLegal = reader["nbRepresentanteLegal"] as string;
			if (!Convert.IsDBNull(reader["codEdificio"])) this.codEdificio = reader["codEdificio"] as string;
			if (!Convert.IsDBNull(reader["nbEdificio"])) this.nbEdificio = reader["nbEdificio"] as string;
			if (!Convert.IsDBNull(reader["dsSociedadDomCalle"])) this.dsSociedadDomCalle = reader["dsSociedadDomCalle"] as string;
			if (!Convert.IsDBNull(reader["dsSociedadDomNumExt"])) this.dsSociedadDomNumExt = reader["dsSociedadDomNumExt"] as string;
			if (!Convert.IsDBNull(reader["dsSociedadDomNumInt"])) this.dsSociedadDomNumInt = reader["dsSociedadDomNumInt"] as string;
			if (!Convert.IsDBNull(reader["dsSociedadDomColonia"])) this.dsSociedadDomColonia = reader["dsSociedadDomColonia"] as string;
			if (!Convert.IsDBNull(reader["dsSociedadDomCP"])) this.dsSociedadDomCP = reader["dsSociedadDomCP"] as string;
			if (!Convert.IsDBNull(reader["codEstadoSociedad"])) this.codEstadoSociedad = reader["codEstadoSociedad"] as string;
			if (!Convert.IsDBNull(reader["nbEstadoSociedad"])) this.nbEstadoSociedad = reader["nbEstadoSociedad"] as string;
			if (!Convert.IsDBNull(reader["codMunicipioSociedad"])) this.codMunicipioSociedad = reader["codMunicipioSociedad"] as string;
			if (!Convert.IsDBNull(reader["nbMunicipioSociedad"])) this.nbMunicipioSociedad = reader["nbMunicipioSociedad"] as string;
			if (!Convert.IsDBNull(reader["codPaisSociedad"])) this.codPaisSociedad = reader["codPaisSociedad"] as string;
			if (!Convert.IsDBNull(reader["nbPaisSociedad"])) this.nbPaisSociedad = reader["nbPaisSociedad"] as string;
			if (!Convert.IsDBNull(reader["dsMotivo"])) this.dsMotivo = reader["dsMotivo"] as string;
			if (!Convert.IsDBNull(reader["dsLabores"])) this.dsLabores = reader["dsLabores"] as string;
			if (!Convert.IsDBNull(reader["feFinContrato"])) this.feFinContrato = reader["feFinContrato"].ToString().Substring(0, 10) != "01/01/1900" ? reader["feFinContrato"].ToString() : string.Empty;
			if (!Convert.IsDBNull(reader["codTipoPosicion"])) this.codTipoPosicion = reader["codTipoPosicion"] as string;
			if (!Convert.IsDBNull(reader["nbTipoPosicion"])) this.nbTipoPosicion = reader["nbTipoPosicion"] as string;
			if (!Convert.IsDBNull(reader["noDuracionJornada"])) this.noDuracionJornada = Int32.Parse(reader["noDuracionJornada"].ToString());
			if (!Convert.IsDBNull(reader["noDiasTrabajados"])) this.noDiasTrabajados = Int32.Parse(reader["noDiasTrabajados"].ToString());
			if (!Convert.IsDBNull(reader["idCodigoDiaPago"])) this.idCodigoDiaPago = Int32.Parse(reader["idCodigoDiaPago"].ToString());
			if (!Convert.IsDBNull(reader["nbDiaPago"])) this.nbDiaPago = reader["nbDiaPago"] as string;
			if (!Convert.IsDBNull(reader["idCodigoDiaSemanaInicio"])) this.idCodigoDiaSemanaInicio = Int32.Parse(reader["idCodigoDiaSemanaInicio"].ToString());
			if (!Convert.IsDBNull(reader["nbDiaSemanaInicio"])) this.nbDiaSemanaInicio = reader["nbDiaSemanaInicio"] as string;
			if (!Convert.IsDBNull(reader["idCodigoDiaSemanaFin"])) this.idCodigoDiaSemanaFin = Int32.Parse(reader["idCodigoDiaSemanaFin"].ToString());
			if (!Convert.IsDBNull(reader["nbDiaSemanaFin"])) this.nbDiaSemanaFin = reader["nbDiaSemanaFin"] as string;
			if (!Convert.IsDBNull(reader["idCodigoHrInicio"])) this.idCodigoHrInicio = Int32.Parse(reader["idCodigoHrInicio"].ToString());
			if (!Convert.IsDBNull(reader["hrEntrada"])) this.hrEntrada = reader["hrEntrada"].ToString();
			if (!Convert.IsDBNull(reader["idCodigoHrFin"])) this.idCodigoHrFin = Int32.Parse(reader["idCodigoHrFin"].ToString());
			if (!Convert.IsDBNull(reader["hrSalida"])) this.hrSalida = reader["hrSalida"].ToString();
			if (!Convert.IsDBNull(reader["esTrabajaSabado"])) this.esTrabajaSabado = (bool)reader["esTrabajaSabado"];
			if (!Convert.IsDBNull(reader["idCodigoHrInicioSabado"])) this.idCodigoHrInicioSabado = Int32.Parse(reader["idCodigoHrInicioSabado"].ToString());
			if (!Convert.IsDBNull(reader["hrEntradaSabado"])) this.hrEntradaSabado = reader["hrEntradaSabado"].ToString();
			if (!Convert.IsDBNull(reader["idCodigoHrFinSabado"])) this.idCodigoHrFinSabado = Int32.Parse(reader["idCodigoHrFinSabado"].ToString());
			if (!Convert.IsDBNull(reader["hrSalidaSabado"])) this.hrSalidaSabado = reader["hrSalidaSabado"].ToString();
			if (!Convert.IsDBNull(reader["noMinutosDescanso"])) this.noMinutosDescanso = Int32.Parse(reader["noMinutosDescanso"].ToString());

			if (!Convert.IsDBNull(reader["codDivision"])) this.codDivision = reader["codDivision"] as string;
			if (!Convert.IsDBNull(reader["nbDivision"])) this.nbDivision = reader["nbDivision"] as string;
			if (!Convert.IsDBNull(reader["codSubdivision"])) this.codSubdivision = reader["codSubdivision"] as string;
			if (!Convert.IsDBNull(reader["nbSubdivision"])) this.nbSubdivision = reader["nbSubdivision"] as string;
			if (!Convert.IsDBNull(reader["codCentroCosto"])) this.codCentroCosto = reader["codCentroCosto"] as string;
			if (!Convert.IsDBNull(reader["nbCentroCosto"])) this.nbCentroCosto = reader["nbCentroCosto"] as string;

			if (!Convert.IsDBNull(reader["dsMailJefe"])) this.dsMailJefe = reader["dsMailJefe"] as string;

			if (!Convert.IsDBNull(reader["nbAliasJefe"])) this.nbAliasJefe = reader["nbAliasJefe"] as string;

			if (!Convert.IsDBNull(reader["codAreaPersonal"])) this.codAreaPersonal = reader["codAreaPersonal"] as string;
			if (!Convert.IsDBNull(reader["nbAreaPersonal"])) this.nbAreaPersonal = reader["nbAreaPersonal"] as string;

			if (!Convert.IsDBNull(reader["feAlta"])) this.feAlta = DateTime.Parse(reader["feAlta"] as string, 
				new System.Globalization.CultureInfo("en-US")).ToString(
				new System.Globalization.CultureInfo("es-MX").DateTimeFormat.ShortDatePattern);

			if (!Convert.IsDBNull(reader["feAntiguedad"])) this.feAntiguedad = DateTime.Parse(reader["feAntiguedad"] as string,
				new System.Globalization.CultureInfo("en-US")).ToString(
				new System.Globalization.CultureInfo("es-MX").DateTimeFormat.ShortDatePattern);

			if (!Convert.IsDBNull(reader["codDepartamento"])) this.codDepartamento = reader["codDepartamento"] as string;
			if (!Convert.IsDBNull(reader["nbDepartamento"])) this.nbDepartamento = reader["nbDepartamento"] as string;
			if (!Convert.IsDBNull(reader["feFinPosicion"])) this.feFinPosicion = reader["feFinPosicion"] as string;

			if (!Convert.IsDBNull(reader["esActivo"])) this.esActivo = Convert.ToInt32(reader["esActivo"].ToString()) == 1;
		}


		/// <summary>
		/// Asigna los valores del objeto a los parámetros del stored procedure
		/// </summary>
		/// <param name="pars">Colección de parámetros</param>

		public void SetDataTo(IDataParameterCollection pars)
		{
		//    if (this.idContrato != 0) DataUtil.SetValue(pars, "@idContrato", this.idContrato);
		//    if (this.feContratacion != string.Empty) DataUtil.SetValue(pars, "@feContratacion", this.feContratacion);
		//    if (this.noDiasRenovar != 0) DataUtil.SetValue(pars, "@noDiasRenovar", this.noDiasRenovar);
		//    if (this.codEstadoExpedicion != string.Empty) DataUtil.SetValue(pars, "@codEstadoExpedicion", this.codEstadoExpedicion);
		//    if (this.nbEstadoExpedicion != string.Empty) DataUtil.SetValue(pars, "@nbEstadoExpedicion", this.nbEstadoExpedicion);
		//    if (this.codMunicipioExpedicion != string.Empty) DataUtil.SetValue(pars, "@codMunicipioExpedicion", this.codMunicipioExpedicion);
		//    if (this.nbMunicipioExpedicion != string.Empty) DataUtil.SetValue(pars, "@nbMunicipioExpedicion", this.nbMunicipioExpedicion);
		//    if (this.noEmpleado != string.Empty) DataUtil.SetValue(pars, "@noEmpleado", this.noEmpleado);
		//    if (this.nbEmpleado != string.Empty) DataUtil.SetValue(pars, "@nbEmpleado", this.nbEmpleado);
		//    if (this.apPaternoEmpleado != string.Empty) DataUtil.SetValue(pars, "@apPaternoEmpleado", this.apPaternoEmpleado);
		//    if (this.apMaternoEmpleado != string.Empty) DataUtil.SetValue(pars, "@apMaternoEmpleado", this.apMaternoEmpleado);
		//    if (this.codAreaNomina != string.Empty) DataUtil.SetValue(pars, "@codAreaNomina", this.codAreaNomina);
		//    if (this.nbAreaNomina != string.Empty) DataUtil.SetValue(pars, "@nbAreaNomina", this.nbAreaNomina);
		//    if (this.codFuncion != string.Empty) DataUtil.SetValue(pars, "@codFuncion", this.codFuncion);
		//    if (this.nbFuncion != string.Empty) DataUtil.SetValue(pars, "@nbFuncion", this.nbFuncion);
		//    if (this.noEmpleadoJefe != string.Empty) DataUtil.SetValue(pars, "@noEmpleadoJefe", this.noEmpleadoJefe);
		//    if (this.nbJefe != string.Empty) DataUtil.SetValue(pars, "@nbJefe", this.nbJefe);
		//    if (this.apPaternoJefe != string.Empty) DataUtil.SetValue(pars, "@apPaternoJefe", this.apPaternoJefe);
		//    if (this.apMaternoJefe != string.Empty) DataUtil.SetValue(pars, "@apMaternoJefe", this.apMaternoJefe);
		//    if (this.dsEmpleadoDomCalle != string.Empty) DataUtil.SetValue(pars, "@dsEmpleadoDomCalle", this.dsEmpleadoDomCalle);
		//    if (this.dsEmpleadoDomNumExt != string.Empty) DataUtil.SetValue(pars, "@dsEmpleadoDomNumExt", this.dsEmpleadoDomNumExt);
		//    if (this.dsEmpleadoDomNumInt != string.Empty) DataUtil.SetValue(pars, "@dsEmpleadoDomNumInt", this.dsEmpleadoDomNumInt);
		//    if (this.dsEmpleadoDomColonia != string.Empty) DataUtil.SetValue(pars, "@dsEmpleadoDomColonia", this.dsEmpleadoDomColonia);
		//    if (this.dsEmpleadoDomCP != string.Empty) DataUtil.SetValue(pars, "@dsEmpleadoDomCP", this.dsEmpleadoDomCP);
		//    if (this.codEstadoEmpleado != string.Empty) DataUtil.SetValue(pars, "@codEstadoEmpleado", this.codEstadoEmpleado);
		//    if (this.nbEstadoEmpleado != string.Empty) DataUtil.SetValue(pars, "@nbEstadoEmpleado", this.nbEstadoEmpleado);
		//    if (this.codMunicipioEmpleado != string.Empty) DataUtil.SetValue(pars, "@codMunicipioEmpleado", this.codMunicipioEmpleado);
		//    if (this.nbMunicipioEmpleado != string.Empty) DataUtil.SetValue(pars, "@nbMunicipioEmpleado", this.nbMunicipioEmpleado);
		//    if (this.codPaisEmpleado != string.Empty) DataUtil.SetValue(pars, "@codPaisEmpleado", this.codPaisEmpleado);
		//    if (this.nbPaisEmpleado != string.Empty) DataUtil.SetValue(pars, "@nbPaisEmpleado", this.nbPaisEmpleado);
		//    if (this.codNacionalidadEmpleado != string.Empty) DataUtil.SetValue(pars, "@codNacionalidadEmpleado", this.codNacionalidadEmpleado);
		//    if (this.nbNacionalidadEmpleado != string.Empty) DataUtil.SetValue(pars, "@nbNacionalidadEmpleado", this.nbNacionalidadEmpleado);
		//    if (this.feNacimiento != string.Empty) DataUtil.SetValue(pars, "@feNacimiento", this.feNacimiento);
		//    if (this.noEdad != 0) DataUtil.SetValue(pars, "@noEdad", this.noEdad);
		//    if (this.codEstadoCivil != string.Empty) DataUtil.SetValue(pars, "@codEstadoCivil", this.codEstadoCivil);
		//    if (this.nbEstadoCivil != string.Empty) DataUtil.SetValue(pars, "@nbEstadoCivil", this.nbEstadoCivil);
		//    if (this.dsRFC != string.Empty) DataUtil.SetValue(pars, "@dsRFC", this.dsRFC);
		//    if (this.dsCURP != string.Empty) DataUtil.SetValue(pars, "@dsCURP", this.dsCURP);
		//    if (this.noSS != string.Empty) DataUtil.SetValue(pars, "@noSS", this.noSS);
		//    if (this.mnSueldoMensual != 0) DataUtil.SetValue(pars, "@mnSueldoMensual", this.mnSueldoMensual);
		//    if (this.noTelefonoFijo != string.Empty) DataUtil.SetValue(pars, "@noTelefonoFijo", this.noTelefonoFijo);
		//    if (this.noTelefonoMovil != string.Empty) DataUtil.SetValue(pars, "@noTelefonoMovil", this.noTelefonoMovil);
		//    if (this.nbAlias != string.Empty) DataUtil.SetValue(pars, "@nbAlias", this.nbAlias);
		//    if (this.nbDominio != string.Empty) DataUtil.SetValue(pars, "@nbDominio", this.nbDominio);
		//    DataUtil.SetValue(pars, "@noProcPrimaVacacional", this.noProcPrimaVacacional);
		//    if (this.noDiasAguinaldo != 0) DataUtil.SetValue(pars, "@noDiasAguinaldo", this.noDiasAguinaldo);
		//    if (this.codSociedad != string.Empty) DataUtil.SetValue(pars, "@codSociedad", this.codSociedad);
		//    if (this.nbSociedad != string.Empty) DataUtil.SetValue(pars, "@nbSociedad", this.nbSociedad);
		//    if (this.nbRepresentanteLegal != string.Empty) DataUtil.SetValue(pars, "@nbRepresentanteLegal", this.nbRepresentanteLegal);
		//    if (this.codEdificio != string.Empty) DataUtil.SetValue(pars, "@codEdificio", this.codEdificio);
		//    if (this.nbEdificio != string.Empty) DataUtil.SetValue(pars, "@nbEdificio", this.nbEdificio);
		//    if (this.dsSociedadDomCalle != string.Empty) DataUtil.SetValue(pars, "@dsSociedadDomCalle", this.dsSociedadDomCalle);
		//    if (this.dsSociedadDomNumExt != string.Empty) DataUtil.SetValue(pars, "@dsSociedadDomNumExt", this.dsSociedadDomNumExt);
		//    if (this.dsSociedadDomNumInt != string.Empty) DataUtil.SetValue(pars, "@dsSociedadDomNumInt", this.dsSociedadDomNumInt);
		//    if (this.dsSociedadDomColonia != string.Empty) DataUtil.SetValue(pars, "@dsSociedadDomColonia", this.dsSociedadDomColonia);
		//    if (this.dsSociedadDomCP != string.Empty) DataUtil.SetValue(pars, "@dsSociedadDomCP", this.dsSociedadDomCP);
		//    if (this.codEstadoSociedad != string.Empty) DataUtil.SetValue(pars, "@codEstadoSociedad", this.codEstadoSociedad);
		//    if (this.nbEstadoSociedad != string.Empty) DataUtil.SetValue(pars, "@nbEstadoSociedad", this.nbEstadoSociedad);
		//    if (this.codMunicipioSociedad != string.Empty) DataUtil.SetValue(pars, "@codMunicipioSociedad", this.codMunicipioSociedad);
		//    if (this.nbMunicipioSociedad != string.Empty) DataUtil.SetValue(pars, "@nbMunicipioSociedad", this.nbMunicipioSociedad);
		//    if (this.codPaisSociedad != string.Empty) DataUtil.SetValue(pars, "@codPaisSociedad", this.codPaisSociedad);
		//    if (this.nbPaisSociedad != string.Empty) DataUtil.SetValue(pars, "@nbPaisSociedad", this.nbPaisSociedad);
		//    if (this.dsMotivo != string.Empty) DataUtil.SetValue(pars, "@dsMotivo", this.dsMotivo);
		//    if (this.dsLabores != string.Empty) DataUtil.SetValue(pars, "@dsLabores", this.dsLabores);
		//    if (this.feFinContrato != string.Empty) DataUtil.SetValue(pars, "@feFinContrato", this.feFinContrato);
		//    if (this.codTipoPosicion != string.Empty) DataUtil.SetValue(pars, "@codTipoPosicion", this.codTipoPosicion);
		//    if (this.nbTipoPosicion != string.Empty) DataUtil.SetValue(pars, "@nbTipoPosicion", this.nbTipoPosicion);
		//    if (this.noDuracionJornada != 0) DataUtil.SetValue(pars, "@noDuracionJornada", this.noDuracionJornada);
		//    if (this.noDiasTrabajados != 0) DataUtil.SetValue(pars, "@noDiasTrabajados", this.noDiasTrabajados);
		//    if (this.idCodigoDiaPago != 0) DataUtil.SetValue(pars, "@idCodigoDiaPago", this.idCodigoDiaPago);
		//    if (this.nbDiaPago != string.Empty) DataUtil.SetValue(pars, "@nbDiaPago", this.nbDiaPago);
		//    if (this.idCodigoDiaSemanaInicio != 0) DataUtil.SetValue(pars, "@idCodigoDiaSemanaInicio", this.idCodigoDiaSemanaInicio);
		//    if (this.nbDiaSemanaInicio != string.Empty) DataUtil.SetValue(pars, "@nbDiaSemanaInicio", this.nbDiaSemanaInicio);
		//    if (this.idCodigoDiaSemanaFin != 0) DataUtil.SetValue(pars, "@idCodigoDiaSemanaFin", this.idCodigoDiaSemanaFin);
		//    if (this.nbDiaSemanaFin != string.Empty) DataUtil.SetValue(pars, "@nbDiaSemanaFin", this.nbDiaSemanaFin);
		//    if (this.idCodigoHrInicio != 0) DataUtil.SetValue(pars, "@idCodigoHrInicio", this.idCodigoHrInicio);
		//    if (this.hrEntrada != string.Empty) DataUtil.SetValue(pars, "@hrEntrada", this.hrEntrada);
		//    if (this.idCodigoHrFin != 0) DataUtil.SetValue(pars, "@idCodigoHrFin", this.idCodigoHrFin);
		//    if (this.hrSalida != string.Empty) DataUtil.SetValue(pars, "@hrSalida", this.hrSalida);
		//    DataUtil.SetValue(pars, "@esTrabajaSabado", this.esTrabajaSabado);
		//    if (this.idCodigoHrInicioSabado != 0) DataUtil.SetValue(pars, "@idCodigoHrInicioSabado", this.idCodigoHrInicioSabado);
		//    if (this.hrEntradaSabado != string.Empty) DataUtil.SetValue(pars, "@hrEntradaSabado", this.hrEntradaSabado);
		//    if (this.idCodigoHrFinSabado != 0) DataUtil.SetValue(pars, "@idCodigoHrFinSabado", this.idCodigoHrFinSabado);
		//    if (this.hrSalidaSabado != string.Empty) DataUtil.SetValue(pars, "@hrSalidaSabado", this.hrSalidaSabado);
		//    if (this.noMinutosDescanso != 0) DataUtil.SetValue(pars, "@noMinutosDescanso", this.noMinutosDescanso);
		//    if (this.nbCreadoPor != string.Empty) DataUtil.SetValue(pars, "@nbCreadoPor", this.nbCreadoPor);
		//    if (this.feCreacion != string.Empty) DataUtil.SetValue(pars, "@feCreacion", this.feCreacion);
		}
		#endregion IDataContainer Members
	}

	/// <summary>
	/// Colección de objetos de tipo de EmpleadosSAPContratos 
	/// </summary>
	[Serializable]
	[DataContract]
	public class EmpleadosSAPContratosList : IDataContainer
	{

		#region Properties
		/// <summary>
		/// Colección con elementos de un catálogo
		/// </summary>
		[DataMember]
		public List<EmpleadosSAPContratos> lstEmpleadosSAPContratos { get; set; }
		#endregion Properties

		#region Constructors
		public EmpleadosSAPContratosList()
		{
			lstEmpleadosSAPContratos = new List<EmpleadosSAPContratos>();
		}
		#endregion Constructors

		#region IDataContainer Members
		/// <summary>
		/// Asigna al objeto los valores de la base de datos
		/// </summary>
		/// <param name="reader">Resultado de la consulta de la base de datos</param>
		public void LoadDataFrom(IDataReader reader)
		{
			lstEmpleadosSAPContratos = new List<EmpleadosSAPContratos>();
			while (reader.Read())
			{
				EmpleadosSAPContratos oEmpleadosSAPContratos = new EmpleadosSAPContratos();
				if (!Convert.IsDBNull(reader["codTipoContrato"])) oEmpleadosSAPContratos.codTipoContrato = reader["codTipoContrato"] as string;
				if (!Convert.IsDBNull(reader["nbTipoContrato"])) oEmpleadosSAPContratos.nbTipoContrato = reader["nbTipoContrato"] as string;

				if (!Convert.IsDBNull(reader["noDiasRenovar"])) oEmpleadosSAPContratos.noDiasRenovar = Int32.Parse(reader["noDiasRenovar"].ToString());
				if (!Convert.IsDBNull(reader["codEstadoExpedicion"])) oEmpleadosSAPContratos.codEstadoExpedicion = reader["codEstadoExpedicion"] as string;
				if (!Convert.IsDBNull(reader["nbEstadoExpedicion"])) oEmpleadosSAPContratos.nbEstadoExpedicion = reader["nbEstadoExpedicion"] as string;
				if (!Convert.IsDBNull(reader["codMunicipioExpedicion"])) oEmpleadosSAPContratos.codMunicipioExpedicion = reader["codMunicipioExpedicion"] as string;
				if (!Convert.IsDBNull(reader["nbMunicipioExpedicion"])) oEmpleadosSAPContratos.nbMunicipioExpedicion = reader["nbMunicipioExpedicion"] as string;
				if (!Convert.IsDBNull(reader["noEmpleado"])) oEmpleadosSAPContratos.noEmpleado = reader["noEmpleado"] as string;
				if (!Convert.IsDBNull(reader["nbEmpleado"])) oEmpleadosSAPContratos.nbEmpleado = reader["nbEmpleado"] as string;
				if (!Convert.IsDBNull(reader["apPaternoEmpleado"])) oEmpleadosSAPContratos.apPaternoEmpleado = reader["apPaternoEmpleado"] as string;
				if (!Convert.IsDBNull(reader["apMaternoEmpleado"])) oEmpleadosSAPContratos.apMaternoEmpleado = reader["apMaternoEmpleado"] as string;
				if (!Convert.IsDBNull(reader["codAreaNomina"])) oEmpleadosSAPContratos.codAreaNomina = reader["codAreaNomina"] as string;
				if (!Convert.IsDBNull(reader["nbAreaNomina"])) oEmpleadosSAPContratos.nbAreaNomina = reader["nbAreaNomina"] as string;
				if (!Convert.IsDBNull(reader["codFuncion"])) oEmpleadosSAPContratos.codFuncion = reader["codFuncion"] as string;
				if (!Convert.IsDBNull(reader["nbFuncion"])) oEmpleadosSAPContratos.nbFuncion = reader["nbFuncion"] as string;
				if (!Convert.IsDBNull(reader["noEmpleadoJefe"])) oEmpleadosSAPContratos.noEmpleadoJefe = reader["noEmpleadoJefe"] as string;
				if (!Convert.IsDBNull(reader["nbJefe"])) oEmpleadosSAPContratos.nbJefe = reader["nbJefe"] as string;
				if (!Convert.IsDBNull(reader["apPaternoJefe"])) oEmpleadosSAPContratos.apPaternoJefe = reader["apPaternoJefe"] as string;
				if (!Convert.IsDBNull(reader["apMaternoJefe"])) oEmpleadosSAPContratos.apMaternoJefe = reader["apMaternoJefe"] as string;
				if (!Convert.IsDBNull(reader["dsEmpleadoDomCalle"])) oEmpleadosSAPContratos.dsEmpleadoDomCalle = reader["dsEmpleadoDomCalle"] as string;
				if (!Convert.IsDBNull(reader["dsEmpleadoDomNumExt"])) oEmpleadosSAPContratos.dsEmpleadoDomNumExt = reader["dsEmpleadoDomNumExt"] as string;
				if (!Convert.IsDBNull(reader["dsEmpleadoDomNumInt"])) oEmpleadosSAPContratos.dsEmpleadoDomNumInt = reader["dsEmpleadoDomNumInt"] as string;
				if (!Convert.IsDBNull(reader["dsEmpleadoDomColonia"])) oEmpleadosSAPContratos.dsEmpleadoDomColonia = reader["dsEmpleadoDomColonia"] as string;
				if (!Convert.IsDBNull(reader["dsEmpleadoDomCP"])) oEmpleadosSAPContratos.dsEmpleadoDomCP = reader["dsEmpleadoDomCP"] as string;
				if (!Convert.IsDBNull(reader["codEstadoEmpleado"])) oEmpleadosSAPContratos.codEstadoEmpleado = reader["codEstadoEmpleado"] as string;
				if (!Convert.IsDBNull(reader["nbEstadoEmpleado"])) oEmpleadosSAPContratos.nbEstadoEmpleado = reader["nbEstadoEmpleado"] as string;
				if (!Convert.IsDBNull(reader["codMunicipioEmpleado"])) oEmpleadosSAPContratos.codMunicipioEmpleado = reader["codMunicipioEmpleado"] as string;
				if (!Convert.IsDBNull(reader["nbMunicipioEmpleado"])) oEmpleadosSAPContratos.nbMunicipioEmpleado = reader["nbMunicipioEmpleado"] as string;
				if (!Convert.IsDBNull(reader["codPaisEmpleado"])) oEmpleadosSAPContratos.codPaisEmpleado = reader["codPaisEmpleado"] as string;
				if (!Convert.IsDBNull(reader["nbPaisEmpleado"])) oEmpleadosSAPContratos.nbPaisEmpleado = reader["nbPaisEmpleado"] as string;
				if (!Convert.IsDBNull(reader["codNacionalidadEmpleado"])) oEmpleadosSAPContratos.codNacionalidadEmpleado = reader["codNacionalidadEmpleado"] as string;
				if (!Convert.IsDBNull(reader["nbNacionalidadEmpleado"])) oEmpleadosSAPContratos.nbNacionalidadEmpleado = reader["nbNacionalidadEmpleado"] as string;
				if (!Convert.IsDBNull(reader["feNacimiento"])) oEmpleadosSAPContratos.feNacimiento = reader["feNacimiento"].ToString();
				if (!Convert.IsDBNull(reader["noEdad"])) oEmpleadosSAPContratos.noEdad = Int32.Parse(reader["noEdad"].ToString());
				if (!Convert.IsDBNull(reader["codEstadoCivil"])) oEmpleadosSAPContratos.codEstadoCivil = reader["codEstadoCivil"] as string;
				if (!Convert.IsDBNull(reader["nbEstadoCivil"])) oEmpleadosSAPContratos.nbEstadoCivil = reader["nbEstadoCivil"] as string;
				if (!Convert.IsDBNull(reader["dsRFC"])) oEmpleadosSAPContratos.dsRFC = reader["dsRFC"] as string;
				if (!Convert.IsDBNull(reader["dsCURP"])) oEmpleadosSAPContratos.dsCURP = reader["dsCURP"] as string;
				if (!Convert.IsDBNull(reader["noSS"])) oEmpleadosSAPContratos.noSS = reader["noSS"] as string;
				if (!Convert.IsDBNull(reader["mnSueldoMensual"])) oEmpleadosSAPContratos.mnSueldoMensual = decimal.Parse(reader["mnSueldoMensual"].ToString());
				if (!Convert.IsDBNull(reader["noTelefonoFijo"])) oEmpleadosSAPContratos.noTelefonoFijo = reader["noTelefonoFijo"] as string;
				if (!Convert.IsDBNull(reader["noTelefonoMovil"])) oEmpleadosSAPContratos.noTelefonoMovil = reader["noTelefonoMovil"] as string;
				if (!Convert.IsDBNull(reader["nbAlias"])) oEmpleadosSAPContratos.nbAlias = reader["nbAlias"] as string;
				if (!Convert.IsDBNull(reader["nbDominio"])) oEmpleadosSAPContratos.nbDominio = reader["nbDominio"] as string;
				if (!Convert.IsDBNull(reader["noProcPrimaVacacional"])) oEmpleadosSAPContratos.noProcPrimaVacacional = decimal.Parse(reader["noProcPrimaVacacional"].ToString());
				if (!Convert.IsDBNull(reader["noDiasAguinaldo"])) oEmpleadosSAPContratos.noDiasAguinaldo = Int32.Parse(reader["noDiasAguinaldo"].ToString());
				if (!Convert.IsDBNull(reader["codSociedad"])) oEmpleadosSAPContratos.codSociedad = reader["codSociedad"] as string;
				if (!Convert.IsDBNull(reader["nbSociedad"])) oEmpleadosSAPContratos.nbSociedad = reader["nbSociedad"] as string;
				if (!Convert.IsDBNull(reader["nbRepresentanteLegal"])) oEmpleadosSAPContratos.nbRepresentanteLegal = reader["nbRepresentanteLegal"] as string;
				if (!Convert.IsDBNull(reader["codEdificio"])) oEmpleadosSAPContratos.codEdificio = reader["codEdificio"] as string;
				if (!Convert.IsDBNull(reader["nbEdificio"])) oEmpleadosSAPContratos.nbEdificio = reader["nbEdificio"] as string;
				if (!Convert.IsDBNull(reader["dsSociedadDomCalle"])) oEmpleadosSAPContratos.dsSociedadDomCalle = reader["dsSociedadDomCalle"] as string;
				if (!Convert.IsDBNull(reader["dsSociedadDomNumExt"])) oEmpleadosSAPContratos.dsSociedadDomNumExt = reader["dsSociedadDomNumExt"] as string;
				if (!Convert.IsDBNull(reader["dsSociedadDomNumInt"])) oEmpleadosSAPContratos.dsSociedadDomNumInt = reader["dsSociedadDomNumInt"] as string;
				if (!Convert.IsDBNull(reader["dsSociedadDomColonia"])) oEmpleadosSAPContratos.dsSociedadDomColonia = reader["dsSociedadDomColonia"] as string;
				if (!Convert.IsDBNull(reader["dsSociedadDomCP"])) oEmpleadosSAPContratos.dsSociedadDomCP = reader["dsSociedadDomCP"] as string;
				if (!Convert.IsDBNull(reader["codEstadoSociedad"])) oEmpleadosSAPContratos.codEstadoSociedad = reader["codEstadoSociedad"] as string;
				if (!Convert.IsDBNull(reader["nbEstadoSociedad"])) oEmpleadosSAPContratos.nbEstadoSociedad = reader["nbEstadoSociedad"] as string;
				if (!Convert.IsDBNull(reader["codMunicipioSociedad"])) oEmpleadosSAPContratos.codMunicipioSociedad = reader["codMunicipioSociedad"] as string;
				if (!Convert.IsDBNull(reader["nbMunicipioSociedad"])) oEmpleadosSAPContratos.nbMunicipioSociedad = reader["nbMunicipioSociedad"] as string;
				if (!Convert.IsDBNull(reader["codPaisSociedad"])) oEmpleadosSAPContratos.codPaisSociedad = reader["codPaisSociedad"] as string;
				if (!Convert.IsDBNull(reader["nbPaisSociedad"])) oEmpleadosSAPContratos.nbPaisSociedad = reader["nbPaisSociedad"] as string;
				if (!Convert.IsDBNull(reader["dsMotivo"])) oEmpleadosSAPContratos.dsMotivo = reader["dsMotivo"] as string;
				if (!Convert.IsDBNull(reader["dsLabores"])) oEmpleadosSAPContratos.dsLabores = reader["dsLabores"] as string;
				if (!Convert.IsDBNull(reader["feFinContrato"])) oEmpleadosSAPContratos.feFinContrato = reader["feFinContrato"].ToString().Substring(0, 10) != "01/01/1900" ? reader["feFinContrato"].ToString() : string.Empty;
				if (!Convert.IsDBNull(reader["codTipoPosicion"])) oEmpleadosSAPContratos.codTipoPosicion = reader["codTipoPosicion"] as string;
				if (!Convert.IsDBNull(reader["nbTipoPosicion"])) oEmpleadosSAPContratos.nbTipoPosicion = reader["nbTipoPosicion"] as string;
				if (!Convert.IsDBNull(reader["noDuracionJornada"])) oEmpleadosSAPContratos.noDuracionJornada = Int32.Parse(reader["noDuracionJornada"].ToString());
				if (!Convert.IsDBNull(reader["noDiasTrabajados"])) oEmpleadosSAPContratos.noDiasTrabajados = Int32.Parse(reader["noDiasTrabajados"].ToString());
				if (!Convert.IsDBNull(reader["idCodigoDiaPago"])) oEmpleadosSAPContratos.idCodigoDiaPago = Int32.Parse(reader["idCodigoDiaPago"].ToString());
				if (!Convert.IsDBNull(reader["nbDiaPago"])) oEmpleadosSAPContratos.nbDiaPago = reader["nbDiaPago"] as string;
				if (!Convert.IsDBNull(reader["idCodigoDiaSemanaInicio"])) oEmpleadosSAPContratos.idCodigoDiaSemanaInicio = Int32.Parse(reader["idCodigoDiaSemanaInicio"].ToString());
				if (!Convert.IsDBNull(reader["nbDiaSemanaInicio"])) oEmpleadosSAPContratos.nbDiaSemanaInicio = reader["nbDiaSemanaInicio"] as string;
				if (!Convert.IsDBNull(reader["idCodigoDiaSemanaFin"])) oEmpleadosSAPContratos.idCodigoDiaSemanaFin = Int32.Parse(reader["idCodigoDiaSemanaFin"].ToString());
				if (!Convert.IsDBNull(reader["nbDiaSemanaFin"])) oEmpleadosSAPContratos.nbDiaSemanaFin = reader["nbDiaSemanaFin"] as string;
				if (!Convert.IsDBNull(reader["idCodigoHrInicio"])) oEmpleadosSAPContratos.idCodigoHrInicio = Int32.Parse(reader["idCodigoHrInicio"].ToString());
				if (!Convert.IsDBNull(reader["hrEntrada"])) oEmpleadosSAPContratos.hrEntrada = reader["hrEntrada"] as string;
				if (!Convert.IsDBNull(reader["idCodigoHrFin"])) oEmpleadosSAPContratos.idCodigoHrFin = Int32.Parse(reader["idCodigoHrFin"].ToString());
				if (!Convert.IsDBNull(reader["hrSalida"])) oEmpleadosSAPContratos.hrSalida = reader["hrSalida"] as string;
				if (!Convert.IsDBNull(reader["esTrabajaSabado"])) oEmpleadosSAPContratos.esTrabajaSabado = (bool)reader["esTrabajaSabado"];
				if (!Convert.IsDBNull(reader["idCodigoHrInicioSabado"])) oEmpleadosSAPContratos.idCodigoHrInicioSabado = Int32.Parse(reader["idCodigoHrInicioSabado"].ToString());
				if (!Convert.IsDBNull(reader["hrEntradaSabado"])) oEmpleadosSAPContratos.hrEntradaSabado = reader["hrEntradaSabado"] as string;
				if (!Convert.IsDBNull(reader["idCodigoHrFinSabado"])) oEmpleadosSAPContratos.idCodigoHrFinSabado = Int32.Parse(reader["idCodigoHrFinSabado"].ToString());
				if (!Convert.IsDBNull(reader["hrSalidaSabado"])) oEmpleadosSAPContratos.hrSalidaSabado = reader["hrSalidaSabado"] as string;
				if (!Convert.IsDBNull(reader["noMinutosDescanso"])) oEmpleadosSAPContratos.noMinutosDescanso = Int32.Parse(reader["noMinutosDescanso"].ToString());

				if (!Convert.IsDBNull(reader["codDivision"])) oEmpleadosSAPContratos.codDivision = reader["codDivision"] as string;
				if (!Convert.IsDBNull(reader["nbDivision"])) oEmpleadosSAPContratos.nbDivision = reader["nbDivision"] as string;
				if (!Convert.IsDBNull(reader["codSubdivision"])) oEmpleadosSAPContratos.codSubdivision = reader["codSubdivision"] as string;
				if (!Convert.IsDBNull(reader["nbSubdivision"])) oEmpleadosSAPContratos.nbSubdivision = reader["nbSubdivision"] as string;
				if (!Convert.IsDBNull(reader["codCentroCosto"])) oEmpleadosSAPContratos.codCentroCosto = reader["codCentroCosto"] as string;
				if (!Convert.IsDBNull(reader["nbCentroCosto"])) oEmpleadosSAPContratos.nbCentroCosto = reader["nbCentroCosto"] as string;

				if (!Convert.IsDBNull(reader["dsMailJefe"])) oEmpleadosSAPContratos.dsMailJefe = reader["dsMailJefe"] as string;
				if (!Convert.IsDBNull(reader["nbAliasJefe"])) oEmpleadosSAPContratos.nbAliasJefe = reader["nbAliasJefe"] as string;

				if (!Convert.IsDBNull(reader["codAreaPersonal"])) oEmpleadosSAPContratos.codAreaPersonal = reader["codAreaPersonal"] as string;
				if (!Convert.IsDBNull(reader["nbAreaPersonal"])) oEmpleadosSAPContratos.nbAreaPersonal = reader["nbAreaPersonal"] as string;

				if (!Convert.IsDBNull(reader["feAntiguedad"])) oEmpleadosSAPContratos.feAntiguedad = DateTime.Parse(reader["feAntiguedad"] as string,
					new System.Globalization.CultureInfo("en-US")).ToString(
					new System.Globalization.CultureInfo("es-MX").DateTimeFormat.ShortDatePattern);

				if (!Convert.IsDBNull(reader["feAlta"])) oEmpleadosSAPContratos.feAlta = DateTime.Parse(reader["feAlta"] as string,
					new System.Globalization.CultureInfo("en-US")).ToString(
					new System.Globalization.CultureInfo("es-MX").DateTimeFormat.ShortDatePattern);

				if (!Convert.IsDBNull(reader["codDepartamento"])) oEmpleadosSAPContratos.codDepartamento = reader["codDepartamento"] as string;
				if (!Convert.IsDBNull(reader["nbDepartamento"])) oEmpleadosSAPContratos.nbDepartamento = reader["nbDepartamento"] as string;
				if (!Convert.IsDBNull(reader["feFinPosicion"])) oEmpleadosSAPContratos.feFinPosicion = reader["feFinPosicion"] as string;

				if (!Convert.IsDBNull(reader["esActivo"])) oEmpleadosSAPContratos.esActivo = Convert.ToInt32(reader["esActivo"].ToString()) == 1;

				this.lstEmpleadosSAPContratos.Add(oEmpleadosSAPContratos);
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

