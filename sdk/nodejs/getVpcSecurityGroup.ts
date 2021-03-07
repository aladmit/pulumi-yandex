// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export function getVpcSecurityGroup(args?: GetVpcSecurityGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetVpcSecurityGroupResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("yandex:index/getVpcSecurityGroup:getVpcSecurityGroup", {
        "folderId": args.folderId,
        "name": args.name,
        "securityGroupId": args.securityGroupId,
    }, opts);
}

/**
 * A collection of arguments for invoking getVpcSecurityGroup.
 */
export interface GetVpcSecurityGroupArgs {
    readonly folderId?: string;
    readonly name?: string;
    readonly securityGroupId?: string;
}

/**
 * A collection of values returned by getVpcSecurityGroup.
 */
export interface GetVpcSecurityGroupResult {
    readonly createdAt: string;
    readonly description: string;
    readonly egresses: outputs.GetVpcSecurityGroupEgress[];
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly ingresses: outputs.GetVpcSecurityGroupIngress[];
    readonly labels: {[key: string]: string};
    readonly name: string;
    readonly networkId: string;
    readonly securityGroupId: string;
    readonly status: string;
}