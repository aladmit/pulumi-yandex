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
    public sealed class MdbKafkaClusterConfigKafka
    {
        public readonly Outputs.MdbKafkaClusterConfigKafkaKafkaConfig? KafkaConfig;
        public readonly Outputs.MdbKafkaClusterConfigKafkaResources Resources;

        [OutputConstructor]
        private MdbKafkaClusterConfigKafka(
            Outputs.MdbKafkaClusterConfigKafkaKafkaConfig? kafkaConfig,

            Outputs.MdbKafkaClusterConfigKafkaResources resources)
        {
            KafkaConfig = kafkaConfig;
            Resources = resources;
        }
    }
}
