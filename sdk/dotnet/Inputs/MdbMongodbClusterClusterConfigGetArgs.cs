// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbMongodbClusterClusterConfigGetArgs : Pulumi.ResourceArgs
    {
        [Input("access")]
        public Input<Inputs.MdbMongodbClusterClusterConfigAccessGetArgs>? Access { get; set; }

        [Input("backupWindowStart")]
        public Input<Inputs.MdbMongodbClusterClusterConfigBackupWindowStartGetArgs>? BackupWindowStart { get; set; }

        [Input("featureCompatibilityVersion")]
        public Input<string>? FeatureCompatibilityVersion { get; set; }

        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public MdbMongodbClusterClusterConfigGetArgs()
        {
        }
    }
}