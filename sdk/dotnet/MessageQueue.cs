// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    [YandexResourceType("yandex:index/messageQueue:MessageQueue")]
    public partial class MessageQueue : Pulumi.CustomResource
    {
        [Output("accessKey")]
        public Output<string?> AccessKey { get; private set; } = null!;

        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        [Output("contentBasedDeduplication")]
        public Output<bool?> ContentBasedDeduplication { get; private set; } = null!;

        [Output("delaySeconds")]
        public Output<int?> DelaySeconds { get; private set; } = null!;

        [Output("fifoQueue")]
        public Output<bool?> FifoQueue { get; private set; } = null!;

        [Output("maxMessageSize")]
        public Output<int?> MaxMessageSize { get; private set; } = null!;

        [Output("messageRetentionSeconds")]
        public Output<int?> MessageRetentionSeconds { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("namePrefix")]
        public Output<string?> NamePrefix { get; private set; } = null!;

        [Output("receiveWaitTimeSeconds")]
        public Output<int?> ReceiveWaitTimeSeconds { get; private set; } = null!;

        [Output("redrivePolicy")]
        public Output<string?> RedrivePolicy { get; private set; } = null!;

        [Output("secretKey")]
        public Output<string?> SecretKey { get; private set; } = null!;

        [Output("visibilityTimeoutSeconds")]
        public Output<int?> VisibilityTimeoutSeconds { get; private set; } = null!;


        /// <summary>
        /// Create a MessageQueue resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MessageQueue(string name, MessageQueueArgs? args = null, CustomResourceOptions? options = null)
            : base("yandex:index/messageQueue:MessageQueue", name, args ?? new MessageQueueArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MessageQueue(string name, Input<string> id, MessageQueueState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/messageQueue:MessageQueue", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing MessageQueue resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MessageQueue Get(string name, Input<string> id, MessageQueueState? state = null, CustomResourceOptions? options = null)
        {
            return new MessageQueue(name, id, state, options);
        }
    }

    public sealed class MessageQueueArgs : Pulumi.ResourceArgs
    {
        [Input("accessKey")]
        public Input<string>? AccessKey { get; set; }

        [Input("contentBasedDeduplication")]
        public Input<bool>? ContentBasedDeduplication { get; set; }

        [Input("delaySeconds")]
        public Input<int>? DelaySeconds { get; set; }

        [Input("fifoQueue")]
        public Input<bool>? FifoQueue { get; set; }

        [Input("maxMessageSize")]
        public Input<int>? MaxMessageSize { get; set; }

        [Input("messageRetentionSeconds")]
        public Input<int>? MessageRetentionSeconds { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("namePrefix")]
        public Input<string>? NamePrefix { get; set; }

        [Input("receiveWaitTimeSeconds")]
        public Input<int>? ReceiveWaitTimeSeconds { get; set; }

        [Input("redrivePolicy")]
        public Input<string>? RedrivePolicy { get; set; }

        [Input("secretKey")]
        public Input<string>? SecretKey { get; set; }

        [Input("visibilityTimeoutSeconds")]
        public Input<int>? VisibilityTimeoutSeconds { get; set; }

        public MessageQueueArgs()
        {
        }
    }

    public sealed class MessageQueueState : Pulumi.ResourceArgs
    {
        [Input("accessKey")]
        public Input<string>? AccessKey { get; set; }

        [Input("arn")]
        public Input<string>? Arn { get; set; }

        [Input("contentBasedDeduplication")]
        public Input<bool>? ContentBasedDeduplication { get; set; }

        [Input("delaySeconds")]
        public Input<int>? DelaySeconds { get; set; }

        [Input("fifoQueue")]
        public Input<bool>? FifoQueue { get; set; }

        [Input("maxMessageSize")]
        public Input<int>? MaxMessageSize { get; set; }

        [Input("messageRetentionSeconds")]
        public Input<int>? MessageRetentionSeconds { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("namePrefix")]
        public Input<string>? NamePrefix { get; set; }

        [Input("receiveWaitTimeSeconds")]
        public Input<int>? ReceiveWaitTimeSeconds { get; set; }

        [Input("redrivePolicy")]
        public Input<string>? RedrivePolicy { get; set; }

        [Input("secretKey")]
        public Input<string>? SecretKey { get; set; }

        [Input("visibilityTimeoutSeconds")]
        public Input<int>? VisibilityTimeoutSeconds { get; set; }

        public MessageQueueState()
        {
        }
    }
}
