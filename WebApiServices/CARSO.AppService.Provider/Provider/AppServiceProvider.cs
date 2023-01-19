using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CARSO.LogLibrary.ServiceDataContainers;
using System.Xml.XmlConfiguration;
using System.Web.UI.WebControls;



namespace CARSO.AppService
{
    /// <summary>
    /// Objeto de Retorno para el acceso a datos
    /// </summary>
    [Serializable]
    public class DataResponse
    {
        [MessageBodyMember]
        public int NumeroError;
        [MessageBodyMember]
        public string Mensaje;
        [MessageBodyMember]
        public string idRegistro;
    }

    [Serializable]
    public enum EstatusActivo
    {
        Todos,
        Activos,
        Inactivos
    }


    [Serializable]
    public enum CatalogoTipo
    {
        Ninguno = 0,
        FrecuenciaProcesoBatch = 1,
        TipoOcurrencia = 2,
        TipoProcesoMasivo = 3,
        SysObjectType = 500,
        DataTypeDB = 501,
        TipoCuentaUsuario = 700,
        FuncionalidadCategoria = 701,
        TipoOperacionFuncionalidad =702,
        TipoParametro = 703,
        FuncionalidadCategoriaHojasTecnicas = 704,
        EstatusTicket = 200,
        TipoFiltrosBool = 141,
        TipoFiltrosFecha = 142,
        TipoFiltrosNumericos = 143,
        TipoRestriccion = 137,
        FuncionalidadCategoriaBolsaDeTrabajo = 705,
        FuncionalidadCategoriaBoletosAvion = 706,
        FuncionalidadCategoriaSisCorp = 707,
         
      
    }

    [Serializable]
    public enum EstatusTicket
    {
       
        [StringValue("TERR")]
        Error = 1,
        [StringValue("TGEN")]
        Generado=2,
        [StringValue("TENPROC")]
        EnProceso=3,
        [StringValue("TPROC")]
        Procesado=4
        
    }

    [Serializable]
    public enum TipoSistema
    {
        [StringValue("TERR")]
        Error = 1,
        [StringValue("TGEN")]
        Generado = 2,
        [StringValue("TENPROC")]
        EnProceso = 3,
        [StringValue("TPROC")]
        Procesado=4
    }

    [Serializable]
    public enum TipoProcesoMasivo
    {
         
        
        [StringValue("TPMNM")]
        Notificaciones = 1,
        [StringValue("TPMRN")]
        TimbradoNomina=2,
        [StringValue("TPMFE")]
        TimbradoFacturas=3,
        [StringValue("TPMFE")]
        GeneracionCuentasGastos=4,
        [StringValue("TPMVFE")]
        ValidacionFacturaB2B

    }

    [Serializable]
    public enum TipoParametro
    {
        [StringValue("TPGRUPO")]
        Grupo = 1,
        [StringValue("TPEMPR")]
        Empresa = 2,
        [StringValue("TPFILI")]
        Filial = 3
    }

}
