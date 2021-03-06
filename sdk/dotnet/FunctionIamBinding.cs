// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    [YandexResourceType("yandex:index/functionIamBinding:FunctionIamBinding")]
    public partial class FunctionIamBinding : Pulumi.CustomResource
    {
        [Output("functionId")]
        public Output<string> FunctionId { get; private set; } = null!;

        [Output("members")]
        public Output<ImmutableArray<string>> Members { get; private set; } = null!;

        [Output("role")]
        public Output<string> Role { get; private set; } = null!;

        [Output("sleepAfter")]
        public Output<int?> SleepAfter { get; private set; } = null!;


        /// <summary>
        /// Create a FunctionIamBinding resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FunctionIamBinding(string name, FunctionIamBindingArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/functionIamBinding:FunctionIamBinding", name, args ?? new FunctionIamBindingArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FunctionIamBinding(string name, Input<string> id, FunctionIamBindingState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/functionIamBinding:FunctionIamBinding", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing FunctionIamBinding resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FunctionIamBinding Get(string name, Input<string> id, FunctionIamBindingState? state = null, CustomResourceOptions? options = null)
        {
            return new FunctionIamBinding(name, id, state, options);
        }
    }

    public sealed class FunctionIamBindingArgs : Pulumi.ResourceArgs
    {
        [Input("functionId", required: true)]
        public Input<string> FunctionId { get; set; } = null!;

        [Input("members", required: true)]
        private InputList<string>? _members;
        public InputList<string> Members
        {
            get => _members ?? (_members = new InputList<string>());
            set => _members = value;
        }

        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        [Input("sleepAfter")]
        public Input<int>? SleepAfter { get; set; }

        public FunctionIamBindingArgs()
        {
        }
    }

    public sealed class FunctionIamBindingState : Pulumi.ResourceArgs
    {
        [Input("functionId")]
        public Input<string>? FunctionId { get; set; }

        [Input("members")]
        private InputList<string>? _members;
        public InputList<string> Members
        {
            get => _members ?? (_members = new InputList<string>());
            set => _members = value;
        }

        [Input("role")]
        public Input<string>? Role { get; set; }

        [Input("sleepAfter")]
        public Input<int>? SleepAfter { get; set; }

        public FunctionIamBindingState()
        {
        }
    }
}
