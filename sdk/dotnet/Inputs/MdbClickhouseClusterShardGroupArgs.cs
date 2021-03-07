// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterShardGroupArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("shardNames", required: true)]
        private InputList<string>? _shardNames;
        public InputList<string> ShardNames
        {
            get => _shardNames ?? (_shardNames = new InputList<string>());
            set => _shardNames = value;
        }

        public MdbClickhouseClusterShardGroupArgs()
        {
        }
    }
}
