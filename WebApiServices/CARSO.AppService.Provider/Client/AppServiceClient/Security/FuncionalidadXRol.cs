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
        public DataResponse AddFuncionalidadXRol(FuncionalidadXRol oFuncionalidadXRol)
        {
            return Channel.AddFuncionalidadXRol(oFuncionalidadXRol);
        }
        public DataResponse GetFuncionalidadXRolAll(ref FuncionalidadXRolList oFuncionalidadXRolListResponse)
        {
            return Channel.GetFuncionalidadXRolAll(ref oFuncionalidadXRolListResponse);
        }
        public DataResponse GetFuncionalidadXRolByKey(int codRol, int idFuncionalidad, string cvDominio, ref FuncionalidadXRol oFuncionalidadXRolResponse)
        {
            return Channel.GetFuncionalidadXRolByKey(codRol, idFuncionalidad, cvDominio, ref oFuncionalidadXRolResponse);
        }
        public DataResponse GetFuncionalidadXRolByPK(int codRol, int idFuncionalidad, string cvDominio, ref FuncionalidadXRol oFuncionalidadXRolResponse)
        {
            return Channel.GetFuncionalidadXRolByPK(codRol, idFuncionalidad, cvDominio, ref oFuncionalidadXRolResponse);
        }
        public DataResponse GetFuncionalidadXRolByUserAndFuncionalidad(string nbAlias, int idFuncionalidad, string codAplicacion, ref FuncionalidadXRol oFuncionalidadXRolResponse)
        {
            return Channel.GetFuncionalidadXRolByUserAndFuncionalidad(nbAlias, idFuncionalidad, codAplicacion, ref oFuncionalidadXRolResponse);
        }
        public DataResponse GetFuncionalidadXRolByUserAndComponente(string nbAlias, string nbComponente, ref FuncionalidadXRol oFuncionalidadXRolResponse)
        {
            return Channel.GetFuncionalidadXRolByUserAndComponente(nbAlias, nbComponente, ref oFuncionalidadXRolResponse);
        }
        public DataResponse DelFuncionalidadXRol(int codRol, string cvDominio)
        {
            return Channel.DelFuncionalidadXRol(codRol, cvDominio);
        }
    }
}