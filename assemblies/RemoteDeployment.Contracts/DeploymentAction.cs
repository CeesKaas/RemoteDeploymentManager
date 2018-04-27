using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RemoteDeployment.Contracts
{
    [DataContract]
    [KnownType("GetKnownTypes")]
    public abstract class DeploymentAction
    {
        private static Type[] GetKnownTypes()
        {
            var type = typeof(DeploymentAction);
            var assembly = type.Assembly;
            return assembly.GetTypes().Where(_ => _.IsSubclassOf(type)).ToArray();
        }
    }
}
