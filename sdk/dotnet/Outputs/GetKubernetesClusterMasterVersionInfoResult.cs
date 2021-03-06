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
    public sealed class GetKubernetesClusterMasterVersionInfoResult
    {
        public readonly string CurrentVersion;
        public readonly bool NewRevisionAvailable;
        public readonly string NewRevisionSummary;
        public readonly bool VersionDeprecated;

        [OutputConstructor]
        private GetKubernetesClusterMasterVersionInfoResult(
            string currentVersion,

            bool newRevisionAvailable,

            string newRevisionSummary,

            bool versionDeprecated)
        {
            CurrentVersion = currentVersion;
            NewRevisionAvailable = newRevisionAvailable;
            NewRevisionSummary = newRevisionSummary;
            VersionDeprecated = versionDeprecated;
        }
    }
}
