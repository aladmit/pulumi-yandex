// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbKafkaClusterConfigKafkaKafkaConfigArgs : Pulumi.ResourceArgs
    {
        [Input("compressionType")]
        public Input<string>? CompressionType { get; set; }

        [Input("logFlushIntervalMessages")]
        public Input<int>? LogFlushIntervalMessages { get; set; }

        [Input("logFlushIntervalMs")]
        public Input<int>? LogFlushIntervalMs { get; set; }

        [Input("logFlushSchedulerIntervalMs")]
        public Input<int>? LogFlushSchedulerIntervalMs { get; set; }

        [Input("logPreallocate")]
        public Input<bool>? LogPreallocate { get; set; }

        [Input("logRetentionBytes")]
        public Input<int>? LogRetentionBytes { get; set; }

        [Input("logRetentionHours")]
        public Input<int>? LogRetentionHours { get; set; }

        [Input("logRetentionMinutes")]
        public Input<int>? LogRetentionMinutes { get; set; }

        [Input("logRetentionMs")]
        public Input<int>? LogRetentionMs { get; set; }

        [Input("logSegmentBytes")]
        public Input<int>? LogSegmentBytes { get; set; }

        public MdbKafkaClusterConfigKafkaKafkaConfigArgs()
        {
        }
    }
}