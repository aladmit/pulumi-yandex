// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterClickhouseConfigKafkaTopicGetArgs : Pulumi.ResourceArgs
    {
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("settings")]
        public Input<Inputs.MdbClickhouseClusterClickhouseConfigKafkaTopicSettingsGetArgs>? Settings { get; set; }

        public MdbClickhouseClusterClickhouseConfigKafkaTopicGetArgs()
        {
        }
    }
}