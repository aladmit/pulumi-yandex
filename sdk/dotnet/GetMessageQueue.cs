// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetMessageQueue
    {
        public static Task<GetMessageQueueResult> InvokeAsync(GetMessageQueueArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMessageQueueResult>("yandex:index/getMessageQueue:getMessageQueue", args ?? new GetMessageQueueArgs(), options.WithVersion());
    }


    public sealed class GetMessageQueueArgs : Pulumi.InvokeArgs
    {
        [Input("accessKey")]
        public string? AccessKey { get; set; }

        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("secretKey")]
        public string? SecretKey { get; set; }

        public GetMessageQueueArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetMessageQueueResult
    {
        public readonly string? AccessKey;
        public readonly string Arn;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        public readonly string? SecretKey;
        public readonly string Url;

        [OutputConstructor]
        private GetMessageQueueResult(
            string? accessKey,

            string arn,

            string id,

            string name,

            string? secretKey,

            string url)
        {
            AccessKey = accessKey;
            Arn = arn;
            Id = id;
            Name = name;
            SecretKey = secretKey;
            Url = url;
        }
    }
}