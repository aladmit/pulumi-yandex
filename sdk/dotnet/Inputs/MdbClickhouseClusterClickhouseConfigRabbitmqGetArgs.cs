// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterClickhouseConfigRabbitmqGetArgs : Pulumi.ResourceArgs
    {
        [Input("password")]
        public Input<string>? Password { get; set; }

        [Input("username")]
        public Input<string>? Username { get; set; }

        public MdbClickhouseClusterClickhouseConfigRabbitmqGetArgs()
        {
        }
    }
}
