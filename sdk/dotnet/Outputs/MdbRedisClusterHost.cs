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
    public sealed class MdbRedisClusterHost
    {
        public readonly string? Fqdn;
        public readonly string? ShardName;
        public readonly string? SubnetId;
        public readonly string Zone;

        [OutputConstructor]
        private MdbRedisClusterHost(
            string? fqdn,

            string? shardName,

            string? subnetId,

            string zone)
        {
            Fqdn = fqdn;
            ShardName = shardName;
            SubnetId = subnetId;
            Zone = zone;
        }
    }
}
