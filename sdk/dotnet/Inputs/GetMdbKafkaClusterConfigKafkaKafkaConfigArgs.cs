// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbKafkaClusterConfigKafkaKafkaConfigArgs : Pulumi.InvokeArgs
    {
        [Input("compressionType")]
        public string? CompressionType { get; set; }

        [Input("logFlushIntervalMessages")]
        public int? LogFlushIntervalMessages { get; set; }

        [Input("logFlushIntervalMs")]
        public int? LogFlushIntervalMs { get; set; }

        [Input("logFlushSchedulerIntervalMs")]
        public int? LogFlushSchedulerIntervalMs { get; set; }

        [Input("logPreallocate")]
        public bool? LogPreallocate { get; set; }

        [Input("logRetentionBytes")]
        public int? LogRetentionBytes { get; set; }

        [Input("logRetentionHours")]
        public int? LogRetentionHours { get; set; }

        [Input("logRetentionMinutes")]
        public int? LogRetentionMinutes { get; set; }

        [Input("logRetentionMs")]
        public int? LogRetentionMs { get; set; }

        [Input("logSegmentBytes")]
        public int? LogSegmentBytes { get; set; }

        public GetMdbKafkaClusterConfigKafkaKafkaConfigArgs()
        {
        }
    }
}
