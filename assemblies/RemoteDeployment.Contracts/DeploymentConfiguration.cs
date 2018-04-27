using System.Runtime.Serialization;

namespace RemoteDeployment.Contracts
{
    [DataContract]
    public class DeploymentConfiguration
    {
        [DataMember]
        public PackageType PackageType { get; set; }
    }
}