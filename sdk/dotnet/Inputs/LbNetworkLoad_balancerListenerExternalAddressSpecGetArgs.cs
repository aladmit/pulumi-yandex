// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class LbNetworkLoad_balancerListenerExternalAddressSpecGetArgs : Pulumi.ResourceArgs
    {
        [Input("address")]
        public Input<string>? Address { get; set; }

        [Input("ipVersion")]
        public Input<string>? IpVersion { get; set; }

        public LbNetworkLoad_balancerListenerExternalAddressSpecGetArgs()
        {
        }
    }
}
