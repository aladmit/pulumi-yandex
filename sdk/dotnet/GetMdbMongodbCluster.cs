// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetMdbMongodbCluster
    {
        public static Task<GetMdbMongodbClusterResult> InvokeAsync(GetMdbMongodbClusterArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMdbMongodbClusterResult>("yandex:index/getMdbMongodbCluster:getMdbMongodbCluster", args ?? new GetMdbMongodbClusterArgs(), options.WithVersion());
    }


    public sealed class GetMdbMongodbClusterArgs : Pulumi.InvokeArgs
    {
        [Input("clusterId")]
        public string? ClusterId { get; set; }

        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        public GetMdbMongodbClusterArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetMdbMongodbClusterResult
    {
        public readonly Outputs.GetMdbMongodbClusterClusterConfigResult ClusterConfig;
        public readonly string ClusterId;
        public readonly string CreatedAt;
        public readonly ImmutableArray<Outputs.GetMdbMongodbClusterDatabaseResult> Databases;
        public readonly string Description;
        public readonly string Environment;
        public readonly string FolderId;
        public readonly string Health;
        public readonly ImmutableArray<Outputs.GetMdbMongodbClusterHostResult> Hosts;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        public readonly string NetworkId;
        public readonly Outputs.GetMdbMongodbClusterResourcesResult Resources;
        public readonly ImmutableArray<string> SecurityGroupIds;
        public readonly bool Sharded;
        public readonly string Status;
        public readonly ImmutableArray<Outputs.GetMdbMongodbClusterUserResult> Users;

        [OutputConstructor]
        private GetMdbMongodbClusterResult(
            Outputs.GetMdbMongodbClusterClusterConfigResult clusterConfig,

            string clusterId,

            string createdAt,

            ImmutableArray<Outputs.GetMdbMongodbClusterDatabaseResult> databases,

            string description,

            string environment,

            string folderId,

            string health,

            ImmutableArray<Outputs.GetMdbMongodbClusterHostResult> hosts,

            string id,

            ImmutableDictionary<string, string> labels,

            string name,

            string networkId,

            Outputs.GetMdbMongodbClusterResourcesResult resources,

            ImmutableArray<string> securityGroupIds,

            bool sharded,

            string status,

            ImmutableArray<Outputs.GetMdbMongodbClusterUserResult> users)
        {
            ClusterConfig = clusterConfig;
            ClusterId = clusterId;
            CreatedAt = createdAt;
            Databases = databases;
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
            Users = users;
        }
    }
}
