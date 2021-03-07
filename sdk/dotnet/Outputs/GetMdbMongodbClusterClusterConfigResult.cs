// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class GetMdbMongodbClusterClusterConfigResult
    {
        public readonly Outputs.GetMdbMongodbClusterClusterConfigAccessResult Access;
        public readonly Outputs.GetMdbMongodbClusterClusterConfigBackupWindowStartResult BackupWindowStart;
        public readonly string FeatureCompatibilityVersion;
        public readonly string Version;

        [OutputConstructor]
        private GetMdbMongodbClusterClusterConfigResult(
            Outputs.GetMdbMongodbClusterClusterConfigAccessResult access,

            Outputs.GetMdbMongodbClusterClusterConfigBackupWindowStartResult backupWindowStart,

            string featureCompatibilityVersion,

            string version)
        {
            Access = access;
            BackupWindowStart = backupWindowStart;
            FeatureCompatibilityVersion = featureCompatibilityVersion;
            Version = version;
        }
    }
}