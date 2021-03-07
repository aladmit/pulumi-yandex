// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetKubernetesNodeGroup
    {
        public static Task<GetKubernetesNodeGroupResult> InvokeAsync(GetKubernetesNodeGroupArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetKubernetesNodeGroupResult>("yandex:index/getKubernetesNodeGroup:getKubernetesNodeGroup", args ?? new GetKubernetesNodeGroupArgs(), options.WithVersion());
    }


    public sealed class GetKubernetesNodeGroupArgs : Pulumi.InvokeArgs
    {
        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("nodeGroupId")]
        public string? NodeGroupId { get; set; }

        public GetKubernetesNodeGroupArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetKubernetesNodeGroupResult
    {
        public readonly Outputs.GetKubernetesNodeGroupAllocationPolicyResult AllocationPolicy;
        public readonly ImmutableArray<string> AllowedUnsafeSysctls;
        public readonly string ClusterId;
        public readonly string CreatedAt;
        public readonly Outputs.GetKubernetesNodeGroupDeployPolicyResult DeployPolicy;
        public readonly string Description;
        public readonly string FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceGroupId;
        public readonly Outputs.GetKubernetesNodeGroupInstanceTemplateResult InstanceTemplate;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly Outputs.GetKubernetesNodeGroupMaintenancePolicyResult MaintenancePolicy;
        public readonly string Name;
        public readonly string NodeGroupId;
        public readonly ImmutableDictionary<string, string> NodeLabels;
        public readonly ImmutableArray<string> NodeTaints;
        public readonly Outputs.GetKubernetesNodeGroupScalePolicyResult ScalePolicy;
        public readonly string Status;
        public readonly Outputs.GetKubernetesNodeGroupVersionInfoResult VersionInfo;

        [OutputConstructor]
        private GetKubernetesNodeGroupResult(
            Outputs.GetKubernetesNodeGroupAllocationPolicyResult allocationPolicy,

            ImmutableArray<string> allowedUnsafeSysctls,

            string clusterId,

            string createdAt,

            Outputs.GetKubernetesNodeGroupDeployPolicyResult deployPolicy,

            string description,

            string folderId,

            string id,

            string instanceGroupId,

            Outputs.GetKubernetesNodeGroupInstanceTemplateResult instanceTemplate,

            ImmutableDictionary<string, string> labels,

            Outputs.GetKubernetesNodeGroupMaintenancePolicyResult maintenancePolicy,

            string name,

            string nodeGroupId,

            ImmutableDictionary<string, string> nodeLabels,

            ImmutableArray<string> nodeTaints,

            Outputs.GetKubernetesNodeGroupScalePolicyResult scalePolicy,

            string status,

            Outputs.GetKubernetesNodeGroupVersionInfoResult versionInfo)
        {
            AllocationPolicy = allocationPolicy;
            AllowedUnsafeSysctls = allowedUnsafeSysctls;
            ClusterId = clusterId;
            CreatedAt = createdAt;
            DeployPolicy = deployPolicy;
            Description = description;
            FolderId = folderId;
            Id = id;
            InstanceGroupId = instanceGroupId;
            InstanceTemplate = instanceTemplate;
            Labels = labels;
            MaintenancePolicy = maintenancePolicy;
            Name = name;
            NodeGroupId = nodeGroupId;
            NodeLabels = nodeLabels;
            NodeTaints = nodeTaints;
            ScalePolicy = scalePolicy;
            Status = status;
            VersionInfo = versionInfo;
        }
    }
}