// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class DataprocClusterClusterConfigHadoop
    {
        public readonly ImmutableDictionary<string, string>? Properties;
        public readonly ImmutableArray<string> Services;
        public readonly ImmutableArray<string> SshPublicKeys;

        [OutputConstructor]
        private DataprocClusterClusterConfigHadoop(
            ImmutableDictionary<string, string>? properties,

            ImmutableArray<string> services,

            ImmutableArray<string> sshPublicKeys)
        {
            Properties = properties;
            Services = services;
            SshPublicKeys = sshPublicKeys;
        }
    }
}
