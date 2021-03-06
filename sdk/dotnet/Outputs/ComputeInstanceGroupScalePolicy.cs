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
    public sealed class ComputeInstanceGroupScalePolicy
    {
        public readonly Outputs.ComputeInstanceGroupScalePolicyAutoScale? AutoScale;
        public readonly Outputs.ComputeInstanceGroupScalePolicyFixedScale? FixedScale;
        public readonly Outputs.ComputeInstanceGroupScalePolicyTestAutoScale? TestAutoScale;

        [OutputConstructor]
        private ComputeInstanceGroupScalePolicy(
            Outputs.ComputeInstanceGroupScalePolicyAutoScale? autoScale,

            Outputs.ComputeInstanceGroupScalePolicyFixedScale? fixedScale,

            Outputs.ComputeInstanceGroupScalePolicyTestAutoScale? testAutoScale)
        {
            AutoScale = autoScale;
            FixedScale = fixedScale;
            TestAutoScale = testAutoScale;
        }
    }
}
