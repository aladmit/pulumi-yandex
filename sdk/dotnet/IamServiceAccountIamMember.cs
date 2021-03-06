// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    [YandexResourceType("yandex:index/iamServiceAccountIamMember:IamServiceAccountIamMember")]
    public partial class IamServiceAccountIamMember : Pulumi.CustomResource
    {
        [Output("member")]
        public Output<string> Member { get; private set; } = null!;

        [Output("role")]
        public Output<string> Role { get; private set; } = null!;

        [Output("serviceAccountId")]
        public Output<string> ServiceAccountId { get; private set; } = null!;

        [Output("sleepAfter")]
        public Output<int?> SleepAfter { get; private set; } = null!;


        /// <summary>
        /// Create a IamServiceAccountIamMember resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IamServiceAccountIamMember(string name, IamServiceAccountIamMemberArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/iamServiceAccountIamMember:IamServiceAccountIamMember", name, args ?? new IamServiceAccountIamMemberArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IamServiceAccountIamMember(string name, Input<string> id, IamServiceAccountIamMemberState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/iamServiceAccountIamMember:IamServiceAccountIamMember", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing IamServiceAccountIamMember resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IamServiceAccountIamMember Get(string name, Input<string> id, IamServiceAccountIamMemberState? state = null, CustomResourceOptions? options = null)
        {
            return new IamServiceAccountIamMember(name, id, state, options);
        }
    }

    public sealed class IamServiceAccountIamMemberArgs : Pulumi.ResourceArgs
    {
        [Input("member", required: true)]
        public Input<string> Member { get; set; } = null!;

        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        [Input("serviceAccountId", required: true)]
        public Input<string> ServiceAccountId { get; set; } = null!;

        [Input("sleepAfter")]
        public Input<int>? SleepAfter { get; set; }

        public IamServiceAccountIamMemberArgs()
        {
        }
    }

    public sealed class IamServiceAccountIamMemberState : Pulumi.ResourceArgs
    {
        [Input("member")]
        public Input<string>? Member { get; set; }

        [Input("role")]
        public Input<string>? Role { get; set; }

        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        [Input("sleepAfter")]
        public Input<int>? SleepAfter { get; set; }

        public IamServiceAccountIamMemberState()
        {
        }
    }
}
