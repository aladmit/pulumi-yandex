// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetContainerRegistry
    {
        public static Task<GetContainerRegistryResult> InvokeAsync(GetContainerRegistryArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetContainerRegistryResult>("yandex:index/getContainerRegistry:getContainerRegistry", args ?? new GetContainerRegistryArgs(), options.WithVersion());
    }


    public sealed class GetContainerRegistryArgs : Pulumi.InvokeArgs
    {
        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("labels")]
        private Dictionary<string, string>? _labels;
        public Dictionary<string, string> Labels
        {
            get => _labels ?? (_labels = new Dictionary<string, string>());
            set => _labels = value;
        }

        [Input("name")]
        public string? Name { get; set; }

        [Input("registryId")]
        public string? RegistryId { get; set; }

        public GetContainerRegistryArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetContainerRegistryResult
    {
        public readonly string CreatedAt;
        public readonly string FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string>? Labels;
        public readonly string Name;
        public readonly string RegistryId;
        public readonly string Status;

        [OutputConstructor]
        private GetContainerRegistryResult(
            string createdAt,

            string folderId,

            string id,

            ImmutableDictionary<string, string>? labels,

            string name,

            string registryId,

            string status)
        {
            CreatedAt = createdAt;
            FolderId = folderId;
            Id = id;
            Labels = labels;
            Name = name;
            RegistryId = registryId;
            Status = status;
        }
    }
}
