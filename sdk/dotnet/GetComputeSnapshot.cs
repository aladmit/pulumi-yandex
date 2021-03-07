// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetComputeSnapshot
    {
        public static Task<GetComputeSnapshotResult> InvokeAsync(GetComputeSnapshotArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetComputeSnapshotResult>("yandex:index/getComputeSnapshot:getComputeSnapshot", args ?? new GetComputeSnapshotArgs(), options.WithVersion());
    }


    public sealed class GetComputeSnapshotArgs : Pulumi.InvokeArgs
    {
        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("snapshotId")]
        public string? SnapshotId { get; set; }

        public GetComputeSnapshotArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetComputeSnapshotResult
    {
        public readonly string CreatedAt;
        public readonly string Description;
        public readonly int DiskSize;
        public readonly string FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        public readonly ImmutableArray<string> ProductIds;
        public readonly string SnapshotId;
        public readonly string SourceDiskId;
        public readonly string Status;
        public readonly int StorageSize;

        [OutputConstructor]
        private GetComputeSnapshotResult(
            string createdAt,

            string description,

            int diskSize,

            string folderId,

            string id,

            ImmutableDictionary<string, string> labels,

            string name,

            ImmutableArray<string> productIds,

            string snapshotId,

            string sourceDiskId,

            string status,

            int storageSize)
        {
            CreatedAt = createdAt;
            Description = description;
            DiskSize = diskSize;
            FolderId = folderId;
            Id = id;
            Labels = labels;
            Name = name;
            ProductIds = productIds;
            SnapshotId = snapshotId;
            SourceDiskId = sourceDiskId;
            Status = status;
            StorageSize = storageSize;
        }
    }
}