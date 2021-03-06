// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetKubernetesCluster
    {
        public static Task<GetKubernetesClusterResult> InvokeAsync(GetKubernetesClusterArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetKubernetesClusterResult>("yandex:index/getKubernetesCluster:getKubernetesCluster", args ?? new GetKubernetesClusterArgs(), options.WithVersion());
    }


    public sealed class GetKubernetesClusterArgs : Pulumi.InvokeArgs
    {
        [Input("clusterId")]
        public string? ClusterId { get; set; }

        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        public GetKubernetesClusterArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetKubernetesClusterResult
    {
        public readonly string ClusterId;
        public readonly string ClusterIpv4Range;
        public readonly string CreatedAt;
        public readonly string Description;
        public readonly string FolderId;
        public readonly string Health;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly Outputs.GetKubernetesClusterKmsProviderResult KmsProvider;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly Outputs.GetKubernetesClusterMasterResult Master;
        public readonly string Name;
        public readonly string NetworkId;
        public readonly string NetworkPolicyProvider;
        public readonly int NodeIpv4CidrMaskSize;
        public readonly string NodeServiceAccountId;
        public readonly string ReleaseChannel;
        public readonly string ServiceAccountId;
        public readonly string ServiceIpv4Range;
        public readonly string Status;

        [OutputConstructor]
        private GetKubernetesClusterResult(
            string clusterId,

            string clusterIpv4Range,

            string createdAt,

            string description,

            string folderId,

            string health,

            string id,

            Outputs.GetKubernetesClusterKmsProviderResult kmsProvider,

            ImmutableDictionary<string, string> labels,

            Outputs.GetKubernetesClusterMasterResult master,

            string name,

            string networkId,

            string networkPolicyProvider,

            int nodeIpv4CidrMaskSize,

            string nodeServiceAccountId,

            string releaseChannel,

            string serviceAccountId,

            string serviceIpv4Range,

            string status)
        {
            ClusterId = clusterId;
            ClusterIpv4Range = clusterIpv4Range;
            CreatedAt = createdAt;
            Description = description;
            FolderId = folderId;
            Health = health;
            Id = id;
            KmsProvider = kmsProvider;
            Labels = labels;
            Master = master;
            Name = name;
            NetworkId = networkId;
            NetworkPolicyProvider = networkPolicyProvider;
            NodeIpv4CidrMaskSize = nodeIpv4CidrMaskSize;
            NodeServiceAccountId = nodeServiceAccountId;
            ReleaseChannel = releaseChannel;
            ServiceAccountId = serviceAccountId;
            ServiceIpv4Range = serviceIpv4Range;
            Status = status;
        }
    }
}
