// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class FunctionTriggerIotGetArgs : Pulumi.ResourceArgs
    {
        [Input("deviceId")]
        public Input<string>? DeviceId { get; set; }

        [Input("registryId", required: true)]
        public Input<string> RegistryId { get; set; } = null!;

        [Input("topic")]
        public Input<string>? Topic { get; set; }

        public FunctionTriggerIotGetArgs()
        {
        }
    }
}
