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
    public sealed class MdbRedisClusterConfig
    {
        public readonly string? MaxmemoryPolicy;
        public readonly string Password;
        public readonly int? Timeout;
        public readonly string Version;

        [OutputConstructor]
        private MdbRedisClusterConfig(
            string? maxmemoryPolicy,

            string password,

            int? timeout,

            string version)
        {
            MaxmemoryPolicy = maxmemoryPolicy;
            Password = password;
            Timeout = timeout;
            Version = version;
        }
    }
}