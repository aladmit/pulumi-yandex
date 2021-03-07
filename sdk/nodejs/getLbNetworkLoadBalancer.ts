// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export function getLbNetworkLoadBalancer(args?: GetLbNetworkLoadBalancerArgs, opts?: pulumi.InvokeOptions): Promise<GetLbNetworkLoadBalancerResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("yandex:index/getLbNetworkLoadBalancer:getLbNetworkLoadBalancer", {
        "folderId": args.folderId,
        "name": args.name,
        "networkLoadBalancerId": args.networkLoadBalancerId,
    }, opts);
}

/**
 * A collection of arguments for invoking getLbNetworkLoadBalancer.
 */
export interface GetLbNetworkLoadBalancerArgs {
    readonly folderId?: string;
    readonly name?: string;
    readonly networkLoadBalancerId?: string;
}

/**
 * A collection of values returned by getLbNetworkLoadBalancer.
 */
export interface GetLbNetworkLoadBalancerResult {
    readonly attachedTargetGroups: outputs.GetLbNetworkLoadBalancerAttachedTargetGroup[];
    readonly createdAt: string;
    readonly description: string;
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly listeners: outputs.GetLbNetworkLoadBalancerListener[];
    readonly name: string;
    readonly networkLoadBalancerId: string;
    readonly regionId: string;
    readonly type: string;
}