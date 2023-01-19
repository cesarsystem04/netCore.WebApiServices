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
        public DataResponse GetEmpresaByGrupo(string noGrupo, ref EmpresaDMList oEmpresaDMList)
        {
            return Channel.GetEmpresaByGrupo(noGrupo, ref oEmpresaDMList);
        }

        public DataResponse GetFilialByEmpresaAndGrupo(string noGrupo, string codEmpresa, ref FilialDMList oFilialDMList)
        {
            return Channel.GetFilialByEmpresaAndGrupo(noGrupo, codEmpresa, ref oFilialDMList);
        }

        public DataResponse GetFilialByGrupoAndSectorAndEmpresa(string noGrupo, string codSector, string codEmpresa, ref FilialDMList oFilialDMList)
        {
            return Channel.GetFilialByGrupoAndSectorAndEmpresa(noGrupo, codSector, codEmpresa, ref oFilialDMList);
        }

        public DataResponse GetEmpresaByEmpresa(string codEmpresa, ref EmpresaDMList oEmpresaDMList)
        {
            return Channel.GetEmpresaByEmpresa(codEmpresa, ref oEmpresaDMList);
        }

        public DataResponse GetFilialByEmpresa(string codEmpresa, ref FilialDMList oFilialDMList)
        {
            return Channel.GetFilialByEmpresa(codEmpresa, ref oFilialDMList);
        }

        public DataResponse GetCatalogoByEmpresaBynoGrupoAndSectorDM(string codEmpresa, string codSector, ref EmpresaDMList oEmpresaDMList)
        {
            return Channel.GetCatalogoByEmpresaBynoGrupoAndSectorDM(codEmpresa, codSector, ref oEmpresaDMList);
        }
    }
}
