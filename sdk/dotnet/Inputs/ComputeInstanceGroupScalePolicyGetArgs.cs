// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupScalePolicyGetArgs : Pulumi.ResourceArgs
    {
        [Input("autoScale")]
        public Input<Inputs.ComputeInstanceGroupScalePolicyAutoScaleGetArgs>? AutoScale { get; set; }

        [Input("fixedScale")]
        public Input<Inputs.ComputeInstanceGroupScalePolicyFixedScaleGetArgs>? FixedScale { get; set; }

        [Input("testAutoScale")]
        public Input<Inputs.ComputeInstanceGroupScalePolicyTestAutoScaleGetArgs>? TestAutoScale { get; set; }

        public ComputeInstanceGroupScalePolicyGetArgs()
        {
        }
    }
}
