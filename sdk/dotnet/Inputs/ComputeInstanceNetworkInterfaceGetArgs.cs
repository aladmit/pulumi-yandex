// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceNetworkInterfaceGetArgs : Pulumi.ResourceArgs
    {
        [Input("index")]
        public Input<int>? Index { get; set; }

        [Input("ipAddress")]
        public Input<string>? IpAddress { get; set; }

        [Input("ipv4")]
        public Input<bool>? Ipv4 { get; set; }

        [Input("ipv6")]
        public Input<bool>? Ipv6 { get; set; }

        [Input("ipv6Address")]
        public Input<string>? Ipv6Address { get; set; }

        [Input("macAddress")]
        public Input<string>? MacAddress { get; set; }

        [Input("nat")]
        public Input<bool>? Nat { get; set; }

        [Input("natIpAddress")]
        public Input<string>? NatIpAddress { get; set; }

        [Input("natIpVersion")]
        public Input<string>? NatIpVersion { get; set; }

        [Input("securityGroupIds")]
        private InputList<string>? _securityGroupIds;
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        public ComputeInstanceNetworkInterfaceGetArgs()
        {
        }
    }
}