// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbPostgresqlClusterConfigArgs : Pulumi.ResourceArgs
    {
        [Input("access")]
        public Input<Inputs.MdbPostgresqlClusterConfigAccessArgs>? Access { get; set; }

        [Input("autofailover")]
        public Input<bool>? Autofailover { get; set; }

        [Input("backupWindowStart")]
        public Input<Inputs.MdbPostgresqlClusterConfigBackupWindowStartArgs>? BackupWindowStart { get; set; }

        [Input("performanceDiagnostics")]
        public Input<Inputs.MdbPostgresqlClusterConfigPerformanceDiagnosticsArgs>? PerformanceDiagnostics { get; set; }

        [Input("poolerConfig")]
        public Input<Inputs.MdbPostgresqlClusterConfigPoolerConfigArgs>? PoolerConfig { get; set; }

        [Input("postgresqlConfig")]
        private InputMap<string>? _postgresqlConfig;
        public InputMap<string> PostgresqlConfig
        {
            get => _postgresqlConfig ?? (_postgresqlConfig = new InputMap<string>());
            set => _postgresqlConfig = value;
        }

        [Input("resources", required: true)]
        public Input<Inputs.MdbPostgresqlClusterConfigResourcesArgs> Resources { get; set; } = null!;

        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public MdbPostgresqlClusterConfigArgs()
        {
        }
    }
}
