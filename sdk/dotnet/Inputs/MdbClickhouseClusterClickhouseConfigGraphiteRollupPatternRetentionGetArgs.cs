// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetentionGetArgs : Pulumi.ResourceArgs
    {
        [Input("age", required: true)]
        public Input<int> Age { get; set; } = null!;

        [Input("precision", required: true)]
        public Input<int> Precision { get; set; } = null!;

        public MdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetentionGetArgs()
        {
        }
    }
}
