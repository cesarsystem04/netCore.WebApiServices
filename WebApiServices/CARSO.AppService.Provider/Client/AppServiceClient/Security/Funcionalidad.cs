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
        public DataResponse AddFuncionalidad(Funcionalidad oFuncionalidad)
        {
            return Channel.AddFuncionalidad(oFuncionalidad);
        }
        public DataResponse GetFuncionalidadAll(string codAplicacion, ref FuncionalidadList oFuncionalidadListResponse)
        {
            return Channel.GetFuncionalidadAll(codAplicacion, ref oFuncionalidadListResponse);
        }
        public DataResponse GetFuncionalidadByKey(int idFuncionalidad, ref Funcionalidad oFuncionalidadResponse)
        {
            return Channel.GetFuncionalidadByKey(idFuncionalidad, ref oFuncionalidadResponse);
        }
        public DataResponse GetFuncionalidadByCategoria(int idCategoria, string codAplicacion, ref FuncionalidadList oFuncionalidadListResponse)
        {
            return Channel.GetFuncionalidadByCategoria(idCategoria, codAplicacion, ref oFuncionalidadListResponse);
        }
        public DataResponse GetFuncionalidadByComponente(string Componente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse)
        {
            return Channel.GetFuncionalidadByComponente(Componente, codAplicacion, ref oFuncionalidadResponse);
        }
        public DataResponse GetFuncionalidadBySubComponente(string Componente, string subComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse)
        {
            return Channel.GetFuncionalidadBySubComponente(Componente, subComponente, codAplicacion, ref oFuncionalidadResponse);
        }
        public DataResponse CountFuncionalidadByMenuOptionPermitidoByCategoria(string nbAlias, int noCatalogo, string codCategoria, string codAplicacion)
        {
            return Channel.CountFuncionalidadByMenuOptionPermitidoByCategoria(nbAlias, noCatalogo, codCategoria, codAplicacion);
        }
        public DataResponse CountFuncionalidadByMenuOption(int noCatalogo, string codCategoria, string nbComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse)
        {
            return Channel.CountFuncionalidadByMenuOption(noCatalogo, codCategoria, nbComponente, codAplicacion, ref oFuncionalidadResponse);
        }
        public DataResponse CountFuncionalidadByMenuOptionPermitido(string nbAlias, string nbComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse)
        {
            return Channel.CountFuncionalidadByMenuOptionPermitido(nbAlias, nbComponente, codAplicacion, ref oFuncionalidadResponse);
        }
        public DataResponse CountFuncionalidadByMenuOptionPermitido(string nbAlias, string nbComponente, string nbSubComponente, string codAplicacion, ref Funcionalidad oFuncionalidadResponse)
        {
            return Channel.CountFuncionalidadByMenuOptionPermitido(nbAlias, nbComponente, nbSubComponente, codAplicacion, ref oFuncionalidadResponse);
        }
        public DataResponse AccesoPermitido(string nbAlias, string codAplicacion)
        {
            return Channel.AccesoPermitido(nbAlias, codAplicacion);
        }
        public DataResponse AccesoPermitido(string nbAlias, int idFuncionalidad, string codAplicacion)
        {
            return Channel.AccesoPermitido(nbAlias, idFuncionalidad, codAplicacion);
        }
    }
}
