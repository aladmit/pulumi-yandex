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
    public sealed class LbNetworkLoad_balancerAttachedTargetGroupHealthcheck
    {
        public readonly int? HealthyThreshold;
        public readonly Outputs.LbNetworkLoad_balancerAttachedTargetGroupHealthcheckHttpOptions? HttpOptions;
        public readonly int? Interval;
        public readonly string Name;
        public readonly Outputs.LbNetworkLoad_balancerAttachedTargetGroupHealthcheckTcpOptions? TcpOptions;
        public readonly int? Timeout;
        public readonly int? UnhealthyThreshold;

        [OutputConstructor]
        private LbNetworkLoad_balancerAttachedTargetGroupHealthcheck(
            int? healthyThreshold,

            Outputs.LbNetworkLoad_balancerAttachedTargetGroupHealthcheckHttpOptions? httpOptions,

            int? interval,

            string name,

            Outputs.LbNetworkLoad_balancerAttachedTargetGroupHealthcheckTcpOptions? tcpOptions,

            int? timeout,

            int? unhealthyThreshold)
        {
            HealthyThreshold = healthyThreshold;
            HttpOptions = httpOptions;
            Interval = interval;
            Name = name;
            TcpOptions = tcpOptions;
            Timeout = timeout;
            UnhealthyThreshold = unhealthyThreshold;
        }
    }
}