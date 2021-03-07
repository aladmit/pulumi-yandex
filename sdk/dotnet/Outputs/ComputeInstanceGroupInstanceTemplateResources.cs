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
    public sealed class ComputeInstanceGroupInstanceTemplateResources
    {
        public readonly int? CoreFraction;
        public readonly int Cores;
        public readonly int? Gpus;
        public readonly double Memory;

        [OutputConstructor]
        private ComputeInstanceGroupInstanceTemplateResources(
            int? coreFraction,

            int cores,

            int? gpus,

            double memory)
        {
            CoreFraction = coreFraction;
            Cores = cores;
            Gpus = gpus;
            Memory = memory;
        }
    }
}
