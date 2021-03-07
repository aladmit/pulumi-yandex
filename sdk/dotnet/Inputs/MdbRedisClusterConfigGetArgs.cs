// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbRedisClusterConfigGetArgs : Pulumi.ResourceArgs
    {
        [Input("maxmemoryPolicy")]
        public Input<string>? MaxmemoryPolicy { get; set; }

        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        [Input("timeout")]
        public Input<int>? Timeout { get; set; }

        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public MdbRedisClusterConfigGetArgs()
        {
        }
    }
}
