// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export function getVpcNetwork(args?: GetVpcNetworkArgs, opts?: pulumi.InvokeOptions): Promise<GetVpcNetworkResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("yandex:index/getVpcNetwork:getVpcNetwork", {
        "folderId": args.folderId,
        "name": args.name,
        "networkId": args.networkId,
    }, opts);
}

/**
 * A collection of arguments for invoking getVpcNetwork.
 */
export interface GetVpcNetworkArgs {
    readonly folderId?: string;
    readonly name?: string;
    readonly networkId?: string;
}

/**
 * A collection of values returned by getVpcNetwork.
 */
export interface GetVpcNetworkResult {
    readonly createdAt: string;
    readonly defaultSecurityGroupId: string;
    readonly description: string;
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly name: string;
    readonly networkId: string;
    readonly subnetIds: string[];
}