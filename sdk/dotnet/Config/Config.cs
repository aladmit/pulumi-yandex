// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Yandex
{
    public static class Config
    {
        private static readonly Pulumi.Config __config = new Pulumi.Config("yandex");
        /// <summary>
        /// ID of Yandex.Cloud tenant.
        /// </summary>
        public static string? CloudId { get; set; } = __config.Get("cloudId");

        /// <summary>
        /// The API endpoint for Yandex.Cloud SDK client.
        /// </summary>
        public static string? Endpoint { get; set; } = __config.Get("endpoint");

        /// <summary>
        /// The default folder ID where resources will be placed.
        /// </summary>
        public static string? FolderId { get; set; } = __config.Get("folderId");

        /// <summary>
        /// Explicitly allow the provider to perform "insecure" SSL requests. If omitted,default value is `false`.
        /// </summary>
        public static bool? Insecure { get; set; } = __config.GetBoolean("insecure");

        /// <summary>
        /// The maximum number of times an API request is being executed. If the API request still fails, an error is thrown.
        /// </summary>
        public static int? MaxRetries { get; set; } = __config.GetInt32("maxRetries");

        /// <summary>
        /// Disable use of TLS. Default value is `false`.
        /// </summary>
        public static bool? Plaintext { get; set; } = __config.GetBoolean("plaintext");

        /// <summary>
        /// Either the path to or the contents of a Service Account key file in JSON format.
        /// </summary>
        public static string? ServiceAccountKeyFile { get; set; } = __config.Get("serviceAccountKeyFile");

        /// <summary>
        /// Yandex.Cloud storage service access key. Used when a storage data/resource doesn't have an access key explicitly
        /// specified.
        /// </summary>
        public static string? StorageAccessKey { get; set; } = __config.Get("storageAccessKey");

        /// <summary>
        /// Yandex.Cloud storage service endpoint. Default is storage.yandexcloud.net
        /// </summary>
        public static string? StorageEndpoint { get; set; } = __config.Get("storageEndpoint");

        /// <summary>
        /// Yandex.Cloud storage service secret key. Used when a storage data/resource doesn't have a secret key explicitly
        /// specified.
        /// </summary>
        public static string? StorageSecretKey { get; set; } = __config.Get("storageSecretKey");

        /// <summary>
        /// The access token for API operations.
        /// </summary>
        public static string? Token { get; set; } = __config.Get("token");

        /// <summary>
        /// Yandex.Cloud Message Queue service access key. Used when a message queue resource doesn't have an access key explicitly
        /// specified.
        /// </summary>
        public static string? YmqAccessKey { get; set; } = __config.Get("ymqAccessKey");

        /// <summary>
        /// Yandex.Cloud Message Queue service endpoint. Default is message-queue.api.cloud.yandex.net
        /// </summary>
        public static string? YmqEndpoint { get; set; } = __config.Get("ymqEndpoint");

        /// <summary>
        /// Yandex.Cloud Message Queue service secret key. Used when a message queue resource doesn't have a secret key explicitly
        /// specified.
        /// </summary>
        public static string? YmqSecretKey { get; set; } = __config.Get("ymqSecretKey");

        /// <summary>
        /// The zone where operations will take place. Examples are ru-central1-a, ru-central2-c, etc.
        /// </summary>
        public static string? Zone { get; set; } = __config.Get("zone");

    }
}
