// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export function getIotCoreDevice(args?: GetIotCoreDeviceArgs, opts?: pulumi.InvokeOptions): Promise<GetIotCoreDeviceResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("yandex:index/getIotCoreDevice:getIotCoreDevice", {
        "deviceId": args.deviceId,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getIotCoreDevice.
 */
export interface GetIotCoreDeviceArgs {
    readonly deviceId?: string;
    readonly name?: string;
}

/**
 * A collection of values returned by getIotCoreDevice.
 */
export interface GetIotCoreDeviceResult {
    readonly aliases: {[key: string]: string};
    readonly certificates: string[];
    readonly createdAt: string;
    readonly description: string;
    readonly deviceId?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name?: string;
    readonly passwords: string[];
    readonly registryId: string;
}
