// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class StorageBucketLifecycleRuleGetArgs : Pulumi.ResourceArgs
    {
        [Input("abortIncompleteMultipartUploadDays")]
        public Input<int>? AbortIncompleteMultipartUploadDays { get; set; }

        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        [Input("expiration")]
        public Input<Inputs.StorageBucketLifecycleRuleExpirationGetArgs>? Expiration { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("noncurrentVersionExpiration")]
        public Input<Inputs.StorageBucketLifecycleRuleNoncurrentVersionExpirationGetArgs>? NoncurrentVersionExpiration { get; set; }

        [Input("noncurrentVersionTransitions")]
        private InputList<Inputs.StorageBucketLifecycleRuleNoncurrentVersionTransitionGetArgs>? _noncurrentVersionTransitions;
        public InputList<Inputs.StorageBucketLifecycleRuleNoncurrentVersionTransitionGetArgs> NoncurrentVersionTransitions
        {
            get => _noncurrentVersionTransitions ?? (_noncurrentVersionTransitions = new InputList<Inputs.StorageBucketLifecycleRuleNoncurrentVersionTransitionGetArgs>());
            set => _noncurrentVersionTransitions = value;
        }

        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        [Input("transitions")]
        private InputList<Inputs.StorageBucketLifecycleRuleTransitionGetArgs>? _transitions;
        public InputList<Inputs.StorageBucketLifecycleRuleTransitionGetArgs> Transitions
        {
            get => _transitions ?? (_transitions = new InputList<Inputs.StorageBucketLifecycleRuleTransitionGetArgs>());
            set => _transitions = value;
        }

        public StorageBucketLifecycleRuleGetArgs()
        {
        }
    }
}
