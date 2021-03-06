// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetComputeInstance
    {
        public static Task<GetComputeInstanceResult> InvokeAsync(GetComputeInstanceArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetComputeInstanceResult>("yandex:index/getComputeInstance:getComputeInstance", args ?? new GetComputeInstanceArgs(), options.WithVersion());
    }


    public sealed class GetComputeInstanceArgs : Pulumi.InvokeArgs
    {
        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("instanceId")]
        public string? InstanceId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("placementPolicy")]
        public Inputs.GetComputeInstancePlacementPolicyArgs? PlacementPolicy { get; set; }

        [Input("schedulingPolicy")]
        public Inputs.GetComputeInstanceSchedulingPolicyArgs? SchedulingPolicy { get; set; }

        public GetComputeInstanceArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetComputeInstanceResult
    {
        public readonly Outputs.GetComputeInstanceBootDiskResult BootDisk;
        public readonly string CreatedAt;
        public readonly string Description;
        public readonly string FolderId;
        public readonly string Fqdn;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly ImmutableDictionary<string, string> Metadata;
        public readonly string Name;
        public readonly string NetworkAccelerationType;
        public readonly ImmutableArray<Outputs.GetComputeInstanceNetworkInterfaceResult> NetworkInterfaces;
        public readonly Outputs.GetComputeInstancePlacementPolicyResult? PlacementPolicy;
        public readonly string PlatformId;
        public readonly Outputs.GetComputeInstanceResourcesResult Resources;
        public readonly Outputs.GetComputeInstanceSchedulingPolicyResult SchedulingPolicy;
        public readonly ImmutableArray<Outputs.GetComputeInstanceSecondaryDiskResult> SecondaryDisks;
        public readonly string ServiceAccountId;
        public readonly string Status;
        public readonly string Zone;

        [OutputConstructor]
        private GetComputeInstanceResult(
            Outputs.GetComputeInstanceBootDiskResult bootDisk,

            string createdAt,

            string description,

            string folderId,

            string fqdn,

            string id,

            string instanceId,

            ImmutableDictionary<string, string> labels,

            ImmutableDictionary<string, string> metadata,

            string name,

            string networkAccelerationType,

            ImmutableArray<Outputs.GetComputeInstanceNetworkInterfaceResult> networkInterfaces,

            Outputs.GetComputeInstancePlacementPolicyResult? placementPolicy,

            string platformId,

            Outputs.GetComputeInstanceResourcesResult resources,

            Outputs.GetComputeInstanceSchedulingPolicyResult schedulingPolicy,

            ImmutableArray<Outputs.GetComputeInstanceSecondaryDiskResult> secondaryDisks,

            string serviceAccountId,

            string status,

            string zone)
        {
            BootDisk = bootDisk;
            CreatedAt = createdAt;
            Description = description;
            FolderId = folderId;
            Fqdn = fqdn;
            Id = id;
            InstanceId = instanceId;
            Labels = labels;
            Metadata = metadata;
            Name = name;
            NetworkAccelerationType = networkAccelerationType;
            NetworkInterfaces = networkInterfaces;
            PlacementPolicy = placementPolicy;
            PlatformId = platformId;
            Resources = resources;
            SchedulingPolicy = schedulingPolicy;
            SecondaryDisks = secondaryDisks;
            ServiceAccountId = serviceAccountId;
            Status = status;
            Zone = zone;
        }
    }
}
