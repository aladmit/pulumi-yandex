// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class LbNetworkLoad_balancerAttachedTargetGroupArgs : Pulumi.ResourceArgs
    {
        [Input("healthchecks", required: true)]
        private InputList<Inputs.LbNetworkLoad_balancerAttachedTargetGroupHealthcheckArgs>? _healthchecks;
        public InputList<Inputs.LbNetworkLoad_balancerAttachedTargetGroupHealthcheckArgs> Healthchecks
        {
            get => _healthchecks ?? (_healthchecks = new InputList<Inputs.LbNetworkLoad_balancerAttachedTargetGroupHealthcheckArgs>());
            set => _healthchecks = value;
        }

        [Input("targetGroupId", required: true)]
        public Input<string> TargetGroupId { get; set; } = null!;

        public LbNetworkLoad_balancerAttachedTargetGroupArgs()
        {
        }
    }
}
