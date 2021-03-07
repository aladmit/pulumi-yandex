// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export function getComputePlacementGroup(args?: GetComputePlacementGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetComputePlacementGroupResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("yandex:index/getComputePlacementGroup:getComputePlacementGroup", {
        "description": args.description,
        "folderId": args.folderId,
        "groupId": args.groupId,
        "labels": args.labels,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getComputePlacementGroup.
 */
export interface GetComputePlacementGroupArgs {
    readonly description?: string;
    readonly folderId?: string;
    readonly groupId?: string;
    readonly labels?: {[key: string]: string};
    readonly name?: string;
}

/**
 * A collection of values returned by getComputePlacementGroup.
 */
export interface GetComputePlacementGroupResult {
    readonly createdAt: string;
    readonly description?: string;
    readonly folderId: string;
    readonly groupId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels?: {[key: string]: string};
    readonly name?: string;
}