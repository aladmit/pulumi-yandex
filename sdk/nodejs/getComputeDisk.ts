// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export function getComputeDisk(args?: GetComputeDiskArgs, opts?: pulumi.InvokeOptions): Promise<GetComputeDiskResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("yandex:index/getComputeDisk:getComputeDisk", {
        "diskId": args.diskId,
        "diskPlacementPolicy": args.diskPlacementPolicy,
        "folderId": args.folderId,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getComputeDisk.
 */
export interface GetComputeDiskArgs {
    readonly diskId?: string;
    readonly diskPlacementPolicy?: inputs.GetComputeDiskDiskPlacementPolicy;
    readonly folderId?: string;
    readonly name?: string;
}

/**
 * A collection of values returned by getComputeDisk.
 */
export interface GetComputeDiskResult {
    readonly createdAt: string;
    readonly description: string;
    readonly diskId: string;
    readonly diskPlacementPolicy?: outputs.GetComputeDiskDiskPlacementPolicy;
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly imageId: string;
    readonly instanceIds: string[];
    readonly labels: {[key: string]: string};
    readonly name: string;
    readonly productIds: string[];
    readonly size: number;
    readonly snapshotId: string;
    readonly status: string;
    readonly type: string;
    readonly zone: string;
}
