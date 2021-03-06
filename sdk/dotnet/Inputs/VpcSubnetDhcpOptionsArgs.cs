// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class VpcSubnetDhcpOptionsArgs : Pulumi.ResourceArgs
    {
        [Input("domainName")]
        public Input<string>? DomainName { get; set; }

        [Input("domainNameServers")]
        private InputList<string>? _domainNameServers;
        public InputList<string> DomainNameServers
        {
            get => _domainNameServers ?? (_domainNameServers = new InputList<string>());
            set => _domainNameServers = value;
        }

        [Input("ntpServers")]
        private InputList<string>? _ntpServers;
        public InputList<string> NtpServers
        {
            get => _ntpServers ?? (_ntpServers = new InputList<string>());
            set => _ntpServers = value;
        }

        public VpcSubnetDhcpOptionsArgs()
        {
        }
    }
}
