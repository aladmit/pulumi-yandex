// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class StorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefaultGetArgs : Pulumi.ResourceArgs
    {
        [Input("kmsMasterKeyId", required: true)]
        public Input<string> KmsMasterKeyId { get; set; } = null!;

        [Input("sseAlgorithm", required: true)]
        public Input<string> SseAlgorithm { get; set; } = null!;

        public StorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefaultGetArgs()
        {
        }
    }
}
