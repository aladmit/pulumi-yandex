// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export function getMdbClickhouseCluster(args?: GetMdbClickhouseClusterArgs, opts?: pulumi.InvokeOptions): Promise<GetMdbClickhouseClusterResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("yandex:index/getMdbClickhouseCluster:getMdbClickhouseCluster", {
        "clusterId": args.clusterId,
        "folderId": args.folderId,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getMdbClickhouseCluster.
 */
export interface GetMdbClickhouseClusterArgs {
    readonly clusterId?: string;
    readonly folderId?: string;
    readonly name?: string;
}

/**
 * A collection of values returned by getMdbClickhouseCluster.
 */
export interface GetMdbClickhouseClusterResult {
    readonly access: outputs.GetMdbClickhouseClusterAccess;
    readonly backupWindowStart: outputs.GetMdbClickhouseClusterBackupWindowStart;
    readonly clickhouse: outputs.GetMdbClickhouseClusterClickhouse;
    readonly clusterId: string;
    readonly createdAt: string;
    readonly databases: outputs.GetMdbClickhouseClusterDatabase[];
    readonly description: string;
    readonly environment: string;
    readonly folderId: string;
    readonly formatSchemas: outputs.GetMdbClickhouseClusterFormatSchema[];
    readonly health: string;
    readonly hosts: outputs.GetMdbClickhouseClusterHost[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly mlModels: outputs.GetMdbClickhouseClusterMlModel[];
    readonly name: string;
    readonly networkId: string;
    readonly securityGroupIds: string[];
    readonly shardGroups: outputs.GetMdbClickhouseClusterShardGroup[];
    readonly sqlDatabaseManagement: boolean;
    readonly sqlUserManagement: boolean;
    readonly status: string;
    readonly users: outputs.GetMdbClickhouseClusterUser[];
    readonly version: string;
    readonly zookeeper: outputs.GetMdbClickhouseClusterZookeeper;
}