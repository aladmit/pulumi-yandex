// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetMdbRedisCluster
    {
        public static Task<GetMdbRedisClusterResult> InvokeAsync(GetMdbRedisClusterArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMdbRedisClusterResult>("yandex:index/getMdbRedisCluster:getMdbRedisCluster", args ?? new GetMdbRedisClusterArgs(), options.WithVersion());
    }


    public sealed class GetMdbRedisClusterArgs : Pulumi.InvokeArgs
    {
        [Input("clusterId")]
        public string? ClusterId { get; set; }

        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        public GetMdbRedisClusterArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetMdbRedisClusterResult
    {
        public readonly string ClusterId;
        public readonly Outputs.GetMdbRedisClusterConfigResult Config;
        public readonly string CreatedAt;
        public readonly string Description;
        public readonly string Environment;
        public readonly string FolderId;
        public readonly string Health;
        public readonly ImmutableArray<Outputs.GetMdbRedisClusterHostResult> Hosts;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        public readonly string NetworkId;
        public readonly Outputs.GetMdbRedisClusterResourcesResult Resources;
        public readonly ImmutableArray<string> SecurityGroupIds;
        public readonly bool Sharded;
        public readonly string Status;

        [OutputConstructor]
        private GetMdbRedisClusterResult(
            string clusterId,

            Outputs.GetMdbRedisClusterConfigResult config,

            string createdAt,

            string description,

            string environment,

            string folderId,

            string health,

            ImmutableArray<Outputs.GetMdbRedisClusterHostResult> hosts,

            string id,

            ImmutableDictionary<string, string> labels,

            string name,

            string networkId,

            Outputs.GetMdbRedisClusterResourcesResult resources,

            ImmutableArray<string> securityGroupIds,

            bool sharded,

            string status)
        {
            ClusterId = clusterId;
            Config = config;
            CreatedAt = createdAt;
            Description = description;
            Environment = environment;
            FolderId = folderId;
            Health = health;
            Hosts = hosts;
            Id = id;
            Labels = labels;
            Name = name;
            NetworkId = networkId;
            Resources = resources;
            SecurityGroupIds = securityGroupIds;
            Sharded = sharded;
            Status = status;
        }
    }
}