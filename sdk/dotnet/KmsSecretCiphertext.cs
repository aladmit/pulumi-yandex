// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    [YandexResourceType("yandex:index/kmsSecretCiphertext:KmsSecretCiphertext")]
    public partial class KmsSecretCiphertext : Pulumi.CustomResource
    {
        [Output("aadContext")]
        public Output<string?> AadContext { get; private set; } = null!;

        [Output("ciphertext")]
        public Output<string> Ciphertext { get; private set; } = null!;

        [Output("keyId")]
        public Output<string> KeyId { get; private set; } = null!;

        [Output("plaintext")]
        public Output<string> Plaintext { get; private set; } = null!;


        /// <summary>
        /// Create a KmsSecretCiphertext resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public KmsSecretCiphertext(string name, KmsSecretCiphertextArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/kmsSecretCiphertext:KmsSecretCiphertext", name, args ?? new KmsSecretCiphertextArgs(), MakeResourceOptions(options, ""))
        {
        }

        private KmsSecretCiphertext(string name, Input<string> id, KmsSecretCiphertextState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/kmsSecretCiphertext:KmsSecretCiphertext", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing KmsSecretCiphertext resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static KmsSecretCiphertext Get(string name, Input<string> id, KmsSecretCiphertextState? state = null, CustomResourceOptions? options = null)
        {
            return new KmsSecretCiphertext(name, id, state, options);
        }
    }

    public sealed class KmsSecretCiphertextArgs : Pulumi.ResourceArgs
    {
        [Input("aadContext")]
        public Input<string>? AadContext { get; set; }

        [Input("keyId", required: true)]
        public Input<string> KeyId { get; set; } = null!;

        [Input("plaintext", required: true)]
        public Input<string> Plaintext { get; set; } = null!;

        public KmsSecretCiphertextArgs()
        {
        }
    }

    public sealed class KmsSecretCiphertextState : Pulumi.ResourceArgs
    {
        [Input("aadContext")]
        public Input<string>? AadContext { get; set; }

        [Input("ciphertext")]
        public Input<string>? Ciphertext { get; set; }

        [Input("keyId")]
        public Input<string>? KeyId { get; set; }

        [Input("plaintext")]
        public Input<string>? Plaintext { get; set; }

        public KmsSecretCiphertextState()
        {
        }
    }
}
