// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupInstanceTemplateBootDiskGetArgs : Pulumi.ResourceArgs
    {
        [Input("deviceName")]
        public Input<string>? DeviceName { get; set; }

        [Input("initializeParams", required: true)]
        public Input<Inputs.ComputeInstanceGroupInstanceTemplateBootDiskInitializeParamsGetArgs> InitializeParams { get; set; } = null!;

        [Input("mode")]
        public Input<string>? Mode { get; set; }

        public ComputeInstanceGroupInstanceTemplateBootDiskGetArgs()
        {
        }
    }
}