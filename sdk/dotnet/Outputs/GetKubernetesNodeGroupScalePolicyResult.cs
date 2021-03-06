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
    public sealed class GetKubernetesNodeGroupScalePolicyResult
    {
        public readonly Outputs.GetKubernetesNodeGroupScalePolicyAutoScaleResult AutoScale;
        public readonly Outputs.GetKubernetesNodeGroupScalePolicyFixedScaleResult FixedScale;

        [OutputConstructor]
        private GetKubernetesNodeGroupScalePolicyResult(
            Outputs.GetKubernetesNodeGroupScalePolicyAutoScaleResult autoScale,

            Outputs.GetKubernetesNodeGroupScalePolicyFixedScaleResult fixedScale)
        {
            AutoScale = autoScale;
            FixedScale = fixedScale;
        }
    }
}
