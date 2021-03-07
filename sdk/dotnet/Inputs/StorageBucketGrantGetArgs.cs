// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class StorageBucketGrantGetArgs : Pulumi.ResourceArgs
    {
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("permissions", required: true)]
        private InputList<string>? _permissions;
        public InputList<string> Permissions
        {
            get => _permissions ?? (_permissions = new InputList<string>());
            set => _permissions = value;
        }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        [Input("uri")]
        public Input<string>? Uri { get; set; }

        public StorageBucketGrantGetArgs()
        {
        }
    }
}
