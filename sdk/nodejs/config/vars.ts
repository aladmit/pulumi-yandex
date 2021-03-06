// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

let __config = new pulumi.Config("yandex");

/**
 * ID of Yandex.Cloud tenant.
 */
export let cloudId: string | undefined = __config.get("cloudId");
/**
 * The API endpoint for Yandex.Cloud SDK client.
 */
export let endpoint: string | undefined = __config.get("endpoint");
/**
 * The default folder ID where resources will be placed.
 */
export let folderId: string | undefined = __config.get("folderId");
/**
 * Explicitly allow the provider to perform "insecure" SSL requests. If omitted,default value is `false`.
 */
export let insecure: boolean | undefined = __config.getObject<boolean>("insecure");
/**
 * The maximum number of times an API request is being executed. If the API request still fails, an error is thrown.
 */
export let maxRetries: number | undefined = __config.getObject<number>("maxRetries");
/**
 * Disable use of TLS. Default value is `false`.
 */
export let plaintext: boolean | undefined = __config.getObject<boolean>("plaintext");
/**
 * Either the path to or the contents of a Service Account key file in JSON format.
 */
export let serviceAccountKeyFile: string | undefined = __config.get("serviceAccountKeyFile");
/**
 * Yandex.Cloud storage service access key. Used when a storage data/resource doesn't have an access key explicitly
 * specified.
 */
export let storageAccessKey: string | undefined = __config.get("storageAccessKey");
/**
 * Yandex.Cloud storage service endpoint. Default is storage.yandexcloud.net
 */
export let storageEndpoint: string | undefined = __config.get("storageEndpoint");
/**
 * Yandex.Cloud storage service secret key. Used when a storage data/resource doesn't have a secret key explicitly
 * specified.
 */
export let storageSecretKey: string | undefined = __config.get("storageSecretKey");
/**
 * The access token for API operations.
 */
export let token: string | undefined = __config.get("token");
/**
 * Yandex.Cloud Message Queue service access key. Used when a message queue resource doesn't have an access key explicitly
 * specified.
 */
export let ymqAccessKey: string | undefined = __config.get("ymqAccessKey");
/**
 * Yandex.Cloud Message Queue service endpoint. Default is message-queue.api.cloud.yandex.net
 */
export let ymqEndpoint: string | undefined = __config.get("ymqEndpoint");
/**
 * Yandex.Cloud Message Queue service secret key. Used when a message queue resource doesn't have a secret key explicitly
 * specified.
 */
export let ymqSecretKey: string | undefined = __config.get("ymqSecretKey");
/**
 * The zone where operations will take place. Examples are ru-central1-a, ru-central2-c, etc.
 */
export let zone: string | undefined = __config.get("zone");
