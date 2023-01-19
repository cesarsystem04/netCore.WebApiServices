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
//using System.Threading.Tasks;

namespace CARSO.AppService.Provider.Client
{
    [DebuggerStepThrough]
    [Serializable]
    public partial class AppServiceClient : ClientBase<IAppService>, IAppService
    {
        #region Constructors
        public AppServiceClient()
        {
        }

        public AppServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public AppServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public AppServiceClient(string endpointConfigurationName, EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public AppServiceClient(Binding binding, EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }
        #endregion

        #region IAppService Members

        #endregion IAppService Members


        public DataResponse GetEmpleado(string noEmpleado, ref Empleado oEmpleado)
        {
            return Channel.GetEmpleado(noEmpleado, ref oEmpleado);
        }
    }
}
