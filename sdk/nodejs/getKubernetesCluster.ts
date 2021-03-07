// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export function getKubernetesCluster(args?: GetKubernetesClusterArgs, opts?: pulumi.InvokeOptions): Promise<GetKubernetesClusterResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("yandex:index/getKubernetesCluster:getKubernetesCluster", {
        "clusterId": args.clusterId,
        "folderId": args.folderId,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getKubernetesCluster.
 */
export interface GetKubernetesClusterArgs {
    readonly clusterId?: string;
    readonly folderId?: string;
    readonly name?: string;
}

/**
 * A collection of values returned by getKubernetesCluster.
 */
export interface GetKubernetesClusterResult {
    readonly clusterId: string;
    readonly clusterIpv4Range: string;
    readonly createdAt: string;
    readonly description: string;
    readonly folderId: string;
    readonly health: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly kmsProvider: outputs.GetKubernetesClusterKmsProvider;
    readonly labels: {[key: string]: string};
    readonly master: outputs.GetKubernetesClusterMaster;
    readonly name: string;
    readonly networkId: string;
    readonly networkPolicyProvider: string;
    readonly nodeIpv4CidrMaskSize: number;
    readonly nodeServiceAccountId: string;
    readonly releaseChannel: string;
    readonly serviceAccountId: string;
    readonly serviceIpv4Range: string;
    readonly status: string;
}
