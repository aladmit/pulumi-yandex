// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterClickhouseGetArgs : Pulumi.ResourceArgs
    {
        [Input("config")]
        public Input<Inputs.MdbClickhouseClusterClickhouseConfigGetArgs>? Config { get; set; }

        [Input("resources", required: true)]
        public Input<Inputs.MdbClickhouseClusterClickhouseResourcesGetArgs> Resources { get; set; } = null!;

        public MdbClickhouseClusterClickhouseGetArgs()
        {
        }
    }
}
