// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export function getIamServiceAccount(args?: GetIamServiceAccountArgs, opts?: pulumi.InvokeOptions): Promise<GetIamServiceAccountResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("yandex:index/getIamServiceAccount:getIamServiceAccount", {
        "folderId": args.folderId,
        "name": args.name,
        "serviceAccountId": args.serviceAccountId,
    }, opts);
}

/**
 * A collection of arguments for invoking getIamServiceAccount.
 */
export interface GetIamServiceAccountArgs {
    readonly folderId?: string;
    readonly name?: string;
    readonly serviceAccountId?: string;
}

/**
 * A collection of values returned by getIamServiceAccount.
 */
export interface GetIamServiceAccountResult {
    readonly createdAt: string;
    readonly description: string;
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
    readonly serviceAccountId: string;
}
