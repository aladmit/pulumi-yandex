// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class GetComputeInstanceBootDiskInitializeParamResult
    {
        public readonly string Description;
        public readonly string ImageId;
        public readonly string Name;
        public readonly int Size;
        public readonly string SnapshotId;
        public readonly string Type;

        [OutputConstructor]
        private GetComputeInstanceBootDiskInitializeParamResult(
            string description,

            string imageId,

            string name,

            int size,

            string snapshotId,

            string type)
        {
            Description = description;
            ImageId = imageId;
            Name = name;
            Size = size;
            SnapshotId = snapshotId;
            Type = type;
        }
    }
}
