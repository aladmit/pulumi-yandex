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
    public sealed class ComputeInstanceGroupHealthCheck
    {
        public readonly int? HealthyThreshold;
        public readonly ImmutableArray<Outputs.ComputeInstanceGroupHealthCheckHttpOption> HttpOptions;
        public readonly int? Interval;
        public readonly ImmutableArray<Outputs.ComputeInstanceGroupHealthCheckTcpOption> TcpOptions;
        public readonly int? Timeout;
        public readonly int? UnhealthyThreshold;

        [OutputConstructor]
        private ComputeInstanceGroupHealthCheck(
            int? healthyThreshold,

            ImmutableArray<Outputs.ComputeInstanceGroupHealthCheckHttpOption> httpOptions,

            int? interval,

            ImmutableArray<Outputs.ComputeInstanceGroupHealthCheckTcpOption> tcpOptions,

            int? timeout,

            int? unhealthyThreshold)
        {
            HealthyThreshold = healthyThreshold;
            HttpOptions = httpOptions;
            Interval = interval;
            TcpOptions = tcpOptions;
            Timeout = timeout;
            UnhealthyThreshold = unhealthyThreshold;
        }
    }
}
