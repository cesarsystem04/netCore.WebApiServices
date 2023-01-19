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
        DataResponse GetEmpresaByGrupo(string noGrupo, ref EmpresaDMList oEmpresaDMList);
        [OperationContract]
        DataResponse GetFilialByEmpresaAndGrupo(string noGrupo, string codEmpresa, ref FilialDMList oFilialDMList);
        [OperationContract]
        DataResponse GetEmpresaByEmpresa(string codEmpresa, ref EmpresaDMList oEmpresaDMList);
        [OperationContract]
        DataResponse GetFilialByEmpresa(string codEmpresa, ref FilialDMList oFilialDMList);

        [OperationContract]
        DataResponse GetCatalogoByEmpresaBynoGrupoAndSectorDM(string codEmpresa, string codSector, ref EmpresaDMList oEmpresaDMList);

        [OperationContract]
        DataResponse GetFilialByGrupoAndSectorAndEmpresa(string noGrupo,  string codSector,string codEmpresa, ref FilialDMList oFilialDMList);
    
    }
}
