// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbKafkaClusterUserPermissionArgs : Pulumi.ResourceArgs
    {
        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        [Input("topicName", required: true)]
        public Input<string> TopicName { get; set; } = null!;

        public MdbKafkaClusterUserPermissionArgs()
        {
        }
    }
}
