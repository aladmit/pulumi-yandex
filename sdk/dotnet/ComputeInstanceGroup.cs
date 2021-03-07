// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    [YandexResourceType("yandex:index/computeInstanceGroup:ComputeInstanceGroup")]
    public partial class ComputeInstanceGroup : Pulumi.CustomResource
    {
        [Output("allocationPolicy")]
        public Output<Outputs.ComputeInstanceGroupAllocationPolicy> AllocationPolicy { get; private set; } = null!;

        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        [Output("deletionProtection")]
        public Output<bool?> DeletionProtection { get; private set; } = null!;

        [Output("deployPolicy")]
        public Output<Outputs.ComputeInstanceGroupDeployPolicy> DeployPolicy { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        [Output("healthChecks")]
        public Output<ImmutableArray<Outputs.ComputeInstanceGroupHealthCheck>> HealthChecks { get; private set; } = null!;

        [Output("instanceTemplate")]
        public Output<Outputs.ComputeInstanceGroupInstanceTemplate> InstanceTemplate { get; private set; } = null!;

        [Output("instances")]
        public Output<ImmutableArray<Outputs.ComputeInstanceGroupInstance>> Instances { get; private set; } = null!;

        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        [Output("loadBalancer")]
        public Output<Outputs.ComputeInstanceGroupLoadBalancer?> LoadBalancer { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("scalePolicy")]
        public Output<Outputs.ComputeInstanceGroupScalePolicy> ScalePolicy { get; private set; } = null!;

        [Output("serviceAccountId")]
        public Output<string> ServiceAccountId { get; private set; } = null!;

        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        [Output("variables")]
        public Output<ImmutableDictionary<string, string>?> Variables { get; private set; } = null!;


        /// <summary>
        /// Create a ComputeInstanceGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ComputeInstanceGroup(string name, ComputeInstanceGroupArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/computeInstanceGroup:ComputeInstanceGroup", name, args ?? new ComputeInstanceGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ComputeInstanceGroup(string name, Input<string> id, ComputeInstanceGroupState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/computeInstanceGroup:ComputeInstanceGroup", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ComputeInstanceGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ComputeInstanceGroup Get(string name, Input<string> id, ComputeInstanceGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new ComputeInstanceGroup(name, id, state, options);
        }
    }

    public sealed class ComputeInstanceGroupArgs : Pulumi.ResourceArgs
    {
        [Input("allocationPolicy", required: true)]
        public Input<Inputs.ComputeInstanceGroupAllocationPolicyArgs> AllocationPolicy { get; set; } = null!;

        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        [Input("deployPolicy", required: true)]
        public Input<Inputs.ComputeInstanceGroupDeployPolicyArgs> DeployPolicy { get; set; } = null!;

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("healthChecks")]
        private InputList<Inputs.ComputeInstanceGroupHealthCheckArgs>? _healthChecks;
        public InputList<Inputs.ComputeInstanceGroupHealthCheckArgs> HealthChecks
        {
            get => _healthChecks ?? (_healthChecks = new InputList<Inputs.ComputeInstanceGroupHealthCheckArgs>());
            set => _healthChecks = value;
        }

        [Input("instanceTemplate", required: true)]
        public Input<Inputs.ComputeInstanceGroupInstanceTemplateArgs> InstanceTemplate { get; set; } = null!;

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("loadBalancer")]
        public Input<Inputs.ComputeInstanceGroupLoadBalancerArgs>? LoadBalancer { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("scalePolicy", required: true)]
        public Input<Inputs.ComputeInstanceGroupScalePolicyArgs> ScalePolicy { get; set; } = null!;

        [Input("serviceAccountId", required: true)]
        public Input<string> ServiceAccountId { get; set; } = null!;

        [Input("variables")]
        private InputMap<string>? _variables;
        public InputMap<string> Variables
        {
            get => _variables ?? (_variables = new InputMap<string>());
            set => _variables = value;
        }

        public ComputeInstanceGroupArgs()
        {
        }
    }

    public sealed class ComputeInstanceGroupState : Pulumi.ResourceArgs
    {
        [Input("allocationPolicy")]
        public Input<Inputs.ComputeInstanceGroupAllocationPolicyGetArgs>? AllocationPolicy { get; set; }

        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        [Input("deployPolicy")]
        public Input<Inputs.ComputeInstanceGroupDeployPolicyGetArgs>? DeployPolicy { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("healthChecks")]
        private InputList<Inputs.ComputeInstanceGroupHealthCheckGetArgs>? _healthChecks;
        public InputList<Inputs.ComputeInstanceGroupHealthCheckGetArgs> HealthChecks
        {
            get => _healthChecks ?? (_healthChecks = new InputList<Inputs.ComputeInstanceGroupHealthCheckGetArgs>());
            set => _healthChecks = value;
        }

        [Input("instanceTemplate")]
        public Input<Inputs.ComputeInstanceGroupInstanceTemplateGetArgs>? InstanceTemplate { get; set; }

        [Input("instances")]
        private InputList<Inputs.ComputeInstanceGroupInstanceGetArgs>? _instances;
        public InputList<Inputs.ComputeInstanceGroupInstanceGetArgs> Instances
        {
            get => _instances ?? (_instances = new InputList<Inputs.ComputeInstanceGroupInstanceGetArgs>());
            set => _instances = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("loadBalancer")]
        public Input<Inputs.ComputeInstanceGroupLoadBalancerGetArgs>? LoadBalancer { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("scalePolicy")]
        public Input<Inputs.ComputeInstanceGroupScalePolicyGetArgs>? ScalePolicy { get; set; }

        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("variables")]
        private InputMap<string>? _variables;
        public InputMap<string> Variables
        {
            get => _variables ?? (_variables = new InputMap<string>());
            set => _variables = value;
        }

        public ComputeInstanceGroupState()
        {
        }
    }
}
