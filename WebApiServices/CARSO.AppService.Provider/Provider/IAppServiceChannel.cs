using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using CARSO.AppService.Provider.Service;
using System.Threading.Tasks;

namespace CARSO.AppService.Provider.Client.Interface
{
    public interface IAppServiceChannel : IAppService, IClientChannel
    {
    }
}
