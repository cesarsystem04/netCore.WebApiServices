using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Security.Principal;
using System.IO;
using CARSO.LogLibrary.ServiceDataAccess;
using CARSO.AppService.Provider.Service;
using CARSO.AppService.ServiceDataContainers;
using System.Threading.Tasks;

namespace CARSO.AppService.Provider.Client
{
    public partial class AppServiceClient : ClientBase<IAppService>, IAppService
    {
        public DataResponse AddUsuario(Usuario oUsuario, string codAplicacion)
        {
            return Channel.AddUsuario(oUsuario, codAplicacion);
        }
        public DataResponse GetUsuarioAll(int esActivo, ref UsuarioList oUsuarioListResponse)
        {
            return Channel.GetUsuarioAll(esActivo, ref oUsuarioListResponse);
        }
        public DataResponse GetUsuarioByKey(string nbAlias, ref Usuario oUsuarioResponse)
        {
            return Channel.GetUsuarioByKey(nbAlias, ref oUsuarioResponse);
        }
        public DataResponse GetUsuarioAllFiltro(ref UsuarioList oUsuarioListResponse)
        {
            return Channel.GetUsuarioAllFiltro(ref oUsuarioListResponse);
        }
        public DataResponse GetUsuarioFindUsuario(string nbAlias, string noEmpleado, string nbEmpleado, ref UsuarioList oUsuarioListResponse)
        {
            return Channel.GetUsuarioFindUsuario(nbAlias, noEmpleado, nbEmpleado, ref oUsuarioListResponse);
        }
        public DataResponse GetUsuarioBynoEmpleado(string noEmpleado, ref Usuario oUsuarioResponse)
        {
            return Channel.GetUsuarioBynoEmpleado(noEmpleado, ref oUsuarioResponse);
        }
        public DataResponse GetUsuarioForRol(int codRol, ref UsuarioList oUsuarioListResponse)
        {
            return Channel.GetUsuarioForRol(codRol, ref oUsuarioListResponse);
        }
        public DataResponse GetUsuarioForMonitor(ref UsuarioList oUsuarioListResponse)
        {
            return Channel.GetUsuarioForMonitor(ref oUsuarioListResponse);
        }
        public DataResponse  GetUsuarioByRolAndCodDepto(int codRol,string codDepto, ref UsuarioList oUsuarioListResponse)
        {
            return Channel. GetUsuarioByRolAndCodDepto( codRol, codDepto, ref oUsuarioListResponse);
        }
        public DataResponse GetUsuarioForAplicacion(string codAplicacion, ref UsuarioList oUsuarioListResponse)
        {
            return Channel.GetUsuarioForAplicacion(codAplicacion, ref oUsuarioListResponse);
        }
        public DataResponse GetUsuarioByCodFilialAndCodRols(int codFilial,string codRoles, ref UsuarioList oUsuarioListResponse)
        {
            return Channel.GetUsuarioByCodFilialAndCodRols(codFilial,codRoles, ref oUsuarioListResponse);
        }


        public DataResponse GetUsuarioFindUsuarioAndCodAplicacion(string nbAlias, string noEmpleado, string nbEmpleado, string codAplicacion, ref UsuarioList oUsuarioListResponse)
        {
            return Channel.GetUsuarioFindUsuarioAndCodAplicacion(nbAlias, noEmpleado, nbEmpleado, codAplicacion, ref oUsuarioListResponse);
        }

        public DataResponse GetUsuarioByUsuarioAndCodAplicacion(string nbAlias, string codAplicacion, ref Usuario oUsuarioResponse)
        {
            return Channel.GetUsuarioByUsuarioAndCodAplicacion(nbAlias, codAplicacion, ref oUsuarioResponse);
        }

        public DataResponse GetUsuarioFindUsuarioAndCodAplicacionAndTipo(string nbAlias, string noEmpleado, string nbEmpleado, string codAplicacion, int idCodigoTipoCuenta, ref UsuarioList oUsuarioListResponse)
        {
            return Channel.GetUsuarioFindUsuarioAndCodAplicacionAndTipo(nbAlias, noEmpleado, nbEmpleado, codAplicacion, idCodigoTipoCuenta, ref oUsuarioListResponse);
        }
    }
}
