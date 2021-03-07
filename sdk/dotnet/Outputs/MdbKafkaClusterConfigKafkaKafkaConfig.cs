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
    public sealed class MdbKafkaClusterConfigKafkaKafkaConfig
    {
        public readonly string? CompressionType;
        public readonly int? LogFlushIntervalMessages;
        public readonly int? LogFlushIntervalMs;
        public readonly int? LogFlushSchedulerIntervalMs;
        public readonly bool? LogPreallocate;
        public readonly int? LogRetentionBytes;
        public readonly int? LogRetentionHours;
        public readonly int? LogRetentionMinutes;
        public readonly int? LogRetentionMs;
        public readonly int? LogSegmentBytes;

        [OutputConstructor]
        private MdbKafkaClusterConfigKafkaKafkaConfig(
            string? compressionType,

            int? logFlushIntervalMessages,

            int? logFlushIntervalMs,

            int? logFlushSchedulerIntervalMs,

            bool? logPreallocate,

            int? logRetentionBytes,

            int? logRetentionHours,

            int? logRetentionMinutes,

            int? logRetentionMs,

            int? logSegmentBytes)
        {
            CompressionType = compressionType;
            LogFlushIntervalMessages = logFlushIntervalMessages;
            LogFlushIntervalMs = logFlushIntervalMs;
            LogFlushSchedulerIntervalMs = logFlushSchedulerIntervalMs;
            LogPreallocate = logPreallocate;
            LogRetentionBytes = logRetentionBytes;
            LogRetentionHours = logRetentionHours;
            LogRetentionMinutes = logRetentionMinutes;
            LogRetentionMs = logRetentionMs;
            LogSegmentBytes = logSegmentBytes;
        }
    }
}
