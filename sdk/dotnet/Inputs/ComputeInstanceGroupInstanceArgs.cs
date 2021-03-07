// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupInstanceArgs : Pulumi.ResourceArgs
    {
        [Input("fqdn")]
        public Input<string>? Fqdn { get; set; }

        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("networkInterfaces")]
        private InputList<Inputs.ComputeInstanceGroupInstanceNetworkInterfaceArgs>? _networkInterfaces;
        public InputList<Inputs.ComputeInstanceGroupInstanceNetworkInterfaceArgs> NetworkInterfaces
        {
            get => _networkInterfaces ?? (_networkInterfaces = new InputList<Inputs.ComputeInstanceGroupInstanceNetworkInterfaceArgs>());
            set => _networkInterfaces = value;
        }

        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("statusChangedAt")]
        public Input<string>? StatusChangedAt { get; set; }

        [Input("statusMessage")]
        public Input<string>? StatusMessage { get; set; }

        [Input("zoneId")]
        public Input<string>? ZoneId { get; set; }

        public ComputeInstanceGroupInstanceArgs()
        {
        }
    }
}
