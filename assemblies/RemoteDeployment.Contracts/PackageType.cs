using System.Runtime.Serialization;

namespace RemoteDeployment.Contracts
{
    [DataContract]
    public enum PackageType
    {
        [EnumMember]
        Executable,

        [EnumMember]
        Msi,

        [EnumMember]
        PowershellScript,

        [EnumMember]
        BatchScript,

        [EnumMember]
        SqlScript
    }
}