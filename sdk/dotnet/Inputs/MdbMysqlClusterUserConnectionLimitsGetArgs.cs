// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbMysqlClusterUserConnectionLimitsGetArgs : Pulumi.ResourceArgs
    {
        [Input("maxConnectionsPerHour")]
        public Input<int>? MaxConnectionsPerHour { get; set; }

        [Input("maxQuestionsPerHour")]
        public Input<int>? MaxQuestionsPerHour { get; set; }

        [Input("maxUpdatesPerHour")]
        public Input<int>? MaxUpdatesPerHour { get; set; }

        [Input("maxUserConnections")]
        public Input<int>? MaxUserConnections { get; set; }

        public MdbMysqlClusterUserConnectionLimitsGetArgs()
        {
        }
    }
}
