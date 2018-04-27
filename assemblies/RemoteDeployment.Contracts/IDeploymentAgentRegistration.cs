using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace RemoteDeployment.Contracts
{
    [ServiceContract(CallbackContract = typeof(IDeploymentAgent))]
    public interface IDeploymentAgentRegistration
    {
        [OperationContract(IsOneWay = true)]
        void Register();
        [OperationContract(IsOneWay = true)]
        void KeepAlive();

        [OperationContract]
        DeploymentConfiguration[] GetConfiguredPackages();
    }
}
