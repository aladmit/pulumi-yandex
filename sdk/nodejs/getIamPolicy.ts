// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export function getIamPolicy(args: GetIamPolicyArgs, opts?: pulumi.InvokeOptions): Promise<GetIamPolicyResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("yandex:index/getIamPolicy:getIamPolicy", {
        "bindings": args.bindings,
    }, opts);
}

/**
 * A collection of arguments for invoking getIamPolicy.
 */
export interface GetIamPolicyArgs {
    readonly bindings: inputs.GetIamPolicyBinding[];
}

/**
 * A collection of values returned by getIamPolicy.
 */
export interface GetIamPolicyResult {
    readonly bindings: outputs.GetIamPolicyBinding[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly policyData: string;
}
