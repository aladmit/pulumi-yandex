// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    [YandexResourceType("yandex:index/iamServiceAccountKey:IamServiceAccountKey")]
    public partial class IamServiceAccountKey : Pulumi.CustomResource
    {
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("encryptedPrivateKey")]
        public Output<string> EncryptedPrivateKey { get; private set; } = null!;

        [Output("format")]
        public Output<string?> Format { get; private set; } = null!;

        [Output("keyAlgorithm")]
        public Output<string?> KeyAlgorithm { get; private set; } = null!;

        [Output("keyFingerprint")]
        public Output<string> KeyFingerprint { get; private set; } = null!;

        [Output("pgpKey")]
        public Output<string?> PgpKey { get; private set; } = null!;

        [Output("privateKey")]
        public Output<string> PrivateKey { get; private set; } = null!;

        [Output("publicKey")]
        public Output<string> PublicKey { get; private set; } = null!;

        [Output("serviceAccountId")]
        public Output<string> ServiceAccountId { get; private set; } = null!;


        /// <summary>
        /// Create a IamServiceAccountKey resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IamServiceAccountKey(string name, IamServiceAccountKeyArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/iamServiceAccountKey:IamServiceAccountKey", name, args ?? new IamServiceAccountKeyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IamServiceAccountKey(string name, Input<string> id, IamServiceAccountKeyState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/iamServiceAccountKey:IamServiceAccountKey", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing IamServiceAccountKey resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IamServiceAccountKey Get(string name, Input<string> id, IamServiceAccountKeyState? state = null, CustomResourceOptions? options = null)
        {
            return new IamServiceAccountKey(name, id, state, options);
        }
    }

    public sealed class IamServiceAccountKeyArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("format")]
        public Input<string>? Format { get; set; }

        [Input("keyAlgorithm")]
        public Input<string>? KeyAlgorithm { get; set; }

        [Input("pgpKey")]
        public Input<string>? PgpKey { get; set; }

        [Input("serviceAccountId", required: true)]
        public Input<string> ServiceAccountId { get; set; } = null!;

        public IamServiceAccountKeyArgs()
        {
        }
    }

    public sealed class IamServiceAccountKeyState : Pulumi.ResourceArgs
    {
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("encryptedPrivateKey")]
        public Input<string>? EncryptedPrivateKey { get; set; }

        [Input("format")]
        public Input<string>? Format { get; set; }

        [Input("keyAlgorithm")]
        public Input<string>? KeyAlgorithm { get; set; }

        [Input("keyFingerprint")]
        public Input<string>? KeyFingerprint { get; set; }

        [Input("pgpKey")]
        public Input<string>? PgpKey { get; set; }

        [Input("privateKey")]
        public Input<string>? PrivateKey { get; set; }

        [Input("publicKey")]
        public Input<string>? PublicKey { get; set; }

        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        public IamServiceAccountKeyState()
        {
        }
    }
}