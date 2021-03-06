// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetComputeDiskPlacementGroup
    {
        public static Task<GetComputeDiskPlacementGroupResult> InvokeAsync(GetComputeDiskPlacementGroupArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetComputeDiskPlacementGroupResult>("yandex:index/getComputeDiskPlacementGroup:getComputeDiskPlacementGroup", args ?? new GetComputeDiskPlacementGroupArgs(), options.WithVersion());
    }


    public sealed class GetComputeDiskPlacementGroupArgs : Pulumi.InvokeArgs
    {
        [Input("description")]
        public string? Description { get; set; }

        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("groupId")]
        public string? GroupId { get; set; }

        [Input("labels")]
        private Dictionary<string, string>? _labels;
        public Dictionary<string, string> Labels
        {
            get => _labels ?? (_labels = new Dictionary<string, string>());
            set => _labels = value;
        }

        [Input("name")]
        public string? Name { get; set; }

        [Input("zone")]
        public string? Zone { get; set; }

        public GetComputeDiskPlacementGroupArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetComputeDiskPlacementGroupResult
    {
        public readonly string CreatedAt;
        public readonly string? Description;
        public readonly string FolderId;
        public readonly string GroupId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string>? Labels;
        public readonly string? Name;
        public readonly string Status;
        public readonly string? Zone;

        [OutputConstructor]
        private GetComputeDiskPlacementGroupResult(
            string createdAt,

            string? description,

            string folderId,

            string groupId,

            string id,

            ImmutableDictionary<string, string>? labels,

            string? name,

            string status,

            string? zone)
        {
            CreatedAt = createdAt;
            Description = description;
            FolderId = folderId;
            GroupId = groupId;
            Id = id;
            Labels = labels;
            Name = name;
            Status = status;
            Zone = zone;
        }
    }
}
