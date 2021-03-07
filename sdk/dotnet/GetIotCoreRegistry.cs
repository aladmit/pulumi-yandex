// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetIotCoreRegistry
    {
        public static Task<GetIotCoreRegistryResult> InvokeAsync(GetIotCoreRegistryArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetIotCoreRegistryResult>("yandex:index/getIotCoreRegistry:getIotCoreRegistry", args ?? new GetIotCoreRegistryArgs(), options.WithVersion());
    }


    public sealed class GetIotCoreRegistryArgs : Pulumi.InvokeArgs
    {
        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("registryId")]
        public string? RegistryId { get; set; }

        public GetIotCoreRegistryArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetIotCoreRegistryResult
    {
        public readonly ImmutableArray<string> Certificates;
        public readonly string CreatedAt;
        public readonly string Description;
        public readonly string? FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string? Name;
        public readonly ImmutableArray<string> Passwords;
        public readonly string? RegistryId;

        [OutputConstructor]
        private GetIotCoreRegistryResult(
            ImmutableArray<string> certificates,

            string createdAt,

            string description,

            string? folderId,

            string id,

            ImmutableDictionary<string, string> labels,

            string? name,

            ImmutableArray<string> passwords,

            string? registryId)
        {
            Certificates = certificates;
            CreatedAt = createdAt;
            Description = description;
            FolderId = folderId;
            Id = id;
            Labels = labels;
            Name = name;
            Passwords = passwords;
            RegistryId = registryId;
        }
    }
}
