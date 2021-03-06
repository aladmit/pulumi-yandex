// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetDataprocCluster
    {
        public static Task<GetDataprocClusterResult> InvokeAsync(GetDataprocClusterArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDataprocClusterResult>("yandex:index/getDataprocCluster:getDataprocCluster", args ?? new GetDataprocClusterArgs(), options.WithVersion());
    }


    public sealed class GetDataprocClusterArgs : Pulumi.InvokeArgs
    {
        [Input("clusterId")]
        public string? ClusterId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        public GetDataprocClusterArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDataprocClusterResult
    {
        public readonly string Bucket;
        public readonly Outputs.GetDataprocClusterClusterConfigResult ClusterConfig;
        public readonly string ClusterId;
        public readonly string CreatedAt;
        public readonly string Description;
        public readonly string FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        public readonly string ServiceAccountId;
        public readonly bool UiProxy;
        public readonly string ZoneId;

        [OutputConstructor]
        private GetDataprocClusterResult(
            string bucket,

            Outputs.GetDataprocClusterClusterConfigResult clusterConfig,

            string clusterId,

            string createdAt,

            string description,

            string folderId,

            string id,

            ImmutableDictionary<string, string> labels,

            string name,

            string serviceAccountId,

            bool uiProxy,

            string zoneId)
        {
            Bucket = bucket;
            ClusterConfig = clusterConfig;
            ClusterId = clusterId;
            CreatedAt = createdAt;
            Description = description;
            FolderId = folderId;
            Id = id;
            Labels = labels;
            Name = name;
            ServiceAccountId = serviceAccountId;
            UiProxy = uiProxy;
            ZoneId = zoneId;
        }
    }
}
