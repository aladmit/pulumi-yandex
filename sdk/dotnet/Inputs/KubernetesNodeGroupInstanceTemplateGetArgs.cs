// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class KubernetesNodeGroupInstanceTemplateGetArgs : Pulumi.ResourceArgs
    {
        [Input("bootDisk")]
        public Input<Inputs.KubernetesNodeGroupInstanceTemplateBootDiskGetArgs>? BootDisk { get; set; }

        [Input("metadata")]
        private InputMap<string>? _metadata;
        public InputMap<string> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<string>());
            set => _metadata = value;
        }

        [Input("nat")]
        public Input<bool>? Nat { get; set; }

        [Input("platformId")]
        public Input<string>? PlatformId { get; set; }

        [Input("resources")]
        public Input<Inputs.KubernetesNodeGroupInstanceTemplateResourcesGetArgs>? Resources { get; set; }

        [Input("schedulingPolicy")]
        public Input<Inputs.KubernetesNodeGroupInstanceTemplateSchedulingPolicyGetArgs>? SchedulingPolicy { get; set; }

        public KubernetesNodeGroupInstanceTemplateGetArgs()
        {
        }
    }
}
