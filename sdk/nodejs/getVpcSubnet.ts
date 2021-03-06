// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export function getVpcSubnet(args?: GetVpcSubnetArgs, opts?: pulumi.InvokeOptions): Promise<GetVpcSubnetResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("yandex:index/getVpcSubnet:getVpcSubnet", {
        "folderId": args.folderId,
        "name": args.name,
        "subnetId": args.subnetId,
    }, opts);
}

/**
 * A collection of arguments for invoking getVpcSubnet.
 */
export interface GetVpcSubnetArgs {
    readonly folderId?: string;
    readonly name?: string;
    readonly subnetId?: string;
}

/**
 * A collection of values returned by getVpcSubnet.
 */
export interface GetVpcSubnetResult {
    readonly createdAt: string;
    readonly description: string;
    readonly dhcpOptions: outputs.GetVpcSubnetDhcpOptions;
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly name: string;
    readonly networkId: string;
    readonly routeTableId: string;
    readonly subnetId: string;
    readonly v4CidrBlocks: string[];
    readonly v6CidrBlocks: string[];
    readonly zone: string;
}
