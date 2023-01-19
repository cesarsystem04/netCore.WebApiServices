using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Security.Principal;
using System.IO;
using System.Threading.Tasks;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.AppService.ServiceDataContainers;

namespace CARSO.AppService.Provider.Service
{
    public partial interface IAppService
    {
        [OperationContract]
        DataResponse AddUsuario(Usuario oUsuario, string codAplicacion);
        [OperationContract()]
        DataResponse GetUsuarioAll(int esActivo, ref UsuarioList oUsuarioListResponse);
        [OperationContract()]
        DataResponse GetUsuarioByKey(string nbAlias, ref Usuario oUsuarioResponse);
        [OperationContract()]
        DataResponse GetUsuarioAllFiltro(ref UsuarioList oUsuarioListResponse);
        [OperationContract()]
        DataResponse GetUsuarioFindUsuario(string nbAlias, string noEmpleado, string nbEmpleado, ref UsuarioList oUsuarioListResponse);
        [OperationContract()]
        DataResponse GetUsuarioBynoEmpleado(string noEmpleado, ref Usuario oUsuarioResponse);
        [OperationContract()]
        DataResponse GetUsuarioForRol(int codRol, ref UsuarioList oUsuarioListResponse);
        [OperationContract()]
        DataResponse GetUsuarioForMonitor(ref UsuarioList oUsuarioListResponse);

        [OperationContract()]
        DataResponse GetUsuarioByRolAndCodDepto(int codRol,string codDepto, ref UsuarioList oUsuarioListResponse);
     
           [OperationContract()]
        DataResponse GetUsuarioForAplicacion(string codAplicacion, ref UsuarioList oUsuarioListResponse);

           [OperationContract()]
           DataResponse GetUsuarioByCodFilialAndCodRols(int codFilial, string codAplicacion, ref UsuarioList oUsuarioListResponse);

           [OperationContract()]
           DataResponse GetUsuarioFindUsuarioAndCodAplicacion(string nbAlias, string noEmpleado, string nbEmpleado,string codAplicacion, ref UsuarioList oUsuarioListResponse);

        [OperationContract()]
        DataResponse GetUsuarioByUsuarioAndCodAplicacion(string nbAlias, string codAplicacion, ref Usuario oUsuarioResponse);

        [OperationContract()]
        DataResponse GetUsuarioFindUsuarioAndCodAplicacionAndTipo(string nbAlias, string noEmpleado, string nbEmpleado, string codAplicacion, int idCodigoTipoCuenta, ref UsuarioList oUsuarioListResponse);

    }
}
