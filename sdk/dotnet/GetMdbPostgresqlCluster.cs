// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetMdbPostgresqlCluster
    {
        public static Task<GetMdbPostgresqlClusterResult> InvokeAsync(GetMdbPostgresqlClusterArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMdbPostgresqlClusterResult>("yandex:index/getMdbPostgresqlCluster:getMdbPostgresqlCluster", args ?? new GetMdbPostgresqlClusterArgs(), options.WithVersion());
    }


    public sealed class GetMdbPostgresqlClusterArgs : Pulumi.InvokeArgs
    {
        [Input("clusterId")]
        public string? ClusterId { get; set; }

        [Input("description")]
        public string? Description { get; set; }

        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        public GetMdbPostgresqlClusterArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetMdbPostgresqlClusterResult
    {
        public readonly string ClusterId;
        public readonly Outputs.GetMdbPostgresqlClusterConfigResult Config;
        public readonly string CreatedAt;
        public readonly ImmutableArray<Outputs.GetMdbPostgresqlClusterDatabaseResult> Databases;
        public readonly string? Description;
        public readonly string Environment;
        public readonly string FolderId;
        public readonly string Health;
        public readonly ImmutableArray<Outputs.GetMdbPostgresqlClusterHostResult> Hosts;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        public readonly string NetworkId;
        public readonly ImmutableArray<string> SecurityGroupIds;
        public readonly string Status;
        public readonly ImmutableArray<Outputs.GetMdbPostgresqlClusterUserResult> Users;

        [OutputConstructor]
        private GetMdbPostgresqlClusterResult(
            string clusterId,

            Outputs.GetMdbPostgresqlClusterConfigResult config,

            string createdAt,

            ImmutableArray<Outputs.GetMdbPostgresqlClusterDatabaseResult> databases,

            string? description,

            string environment,

            string folderId,

            string health,

            ImmutableArray<Outputs.GetMdbPostgresqlClusterHostResult> hosts,

            string id,

            ImmutableDictionary<string, string> labels,

            string name,

            string networkId,

            ImmutableArray<string> securityGroupIds,

            string status,

            ImmutableArray<Outputs.GetMdbPostgresqlClusterUserResult> users)
        {
            ClusterId = clusterId;
            Config = config;
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
            SecurityGroupIds = securityGroupIds;
            Status = status;
            Users = users;
        }
    }
}