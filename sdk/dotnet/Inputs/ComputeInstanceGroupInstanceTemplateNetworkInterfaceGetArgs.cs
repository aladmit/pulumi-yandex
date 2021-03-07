// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupInstanceTemplateNetworkInterfaceGetArgs : Pulumi.ResourceArgs
    {
        [Input("ipv4")]
        public Input<bool>? Ipv4 { get; set; }

        [Input("ipv6")]
        public Input<bool>? Ipv6 { get; set; }

        [Input("nat")]
        public Input<bool>? Nat { get; set; }

        [Input("networkId")]
        public Input<string>? NetworkId { get; set; }

        [Input("securityGroupIds")]
        private InputList<string>? _securityGroupIds;
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        [Input("subnetIds")]
        private InputList<string>? _subnetIds;
        public InputList<string> SubnetIds
        {
            get => _subnetIds ?? (_subnetIds = new InputList<string>());
            set => _subnetIds = value;
        }

        public ComputeInstanceGroupInstanceTemplateNetworkInterfaceGetArgs()
        {
        }
    }
}
