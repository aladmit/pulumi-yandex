// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class KubernetesClusterMasterMaintenancePolicyGetArgs : Pulumi.ResourceArgs
    {
        [Input("autoUpgrade", required: true)]
        public Input<bool> AutoUpgrade { get; set; } = null!;

        [Input("maintenanceWindows")]
        private InputList<Inputs.KubernetesClusterMasterMaintenancePolicyMaintenanceWindowGetArgs>? _maintenanceWindows;
        public InputList<Inputs.KubernetesClusterMasterMaintenancePolicyMaintenanceWindowGetArgs> MaintenanceWindows
        {
            get => _maintenanceWindows ?? (_maintenanceWindows = new InputList<Inputs.KubernetesClusterMasterMaintenancePolicyMaintenanceWindowGetArgs>());
            set => _maintenanceWindows = value;
        }

        public KubernetesClusterMasterMaintenancePolicyGetArgs()
        {
        }
    }
}