// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export class MdbPostgresqlCluster extends pulumi.CustomResource {
    /**
     * Get an existing MdbPostgresqlCluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MdbPostgresqlClusterState, opts?: pulumi.CustomResourceOptions): MdbPostgresqlCluster {
        return new MdbPostgresqlCluster(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/mdbPostgresqlCluster:MdbPostgresqlCluster';

    /**
     * Returns true if the given object is an instance of MdbPostgresqlCluster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MdbPostgresqlCluster {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MdbPostgresqlCluster.__pulumiType;
    }

    public readonly config!: pulumi.Output<outputs.MdbPostgresqlClusterConfig>;
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    public readonly databases!: pulumi.Output<outputs.MdbPostgresqlClusterDatabase[]>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly environment!: pulumi.Output<string>;
    public readonly folderId!: pulumi.Output<string>;
    public /*out*/ readonly health!: pulumi.Output<string>;
    public readonly hostMasterName!: pulumi.Output<string>;
    public readonly hosts!: pulumi.Output<outputs.MdbPostgresqlClusterHost[]>;
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly name!: pulumi.Output<string>;
    public readonly networkId!: pulumi.Output<string>;
    public readonly restore!: pulumi.Output<outputs.MdbPostgresqlClusterRestore | undefined>;
    public readonly securityGroupIds!: pulumi.Output<string[] | undefined>;
    public /*out*/ readonly status!: pulumi.Output<string>;
    public readonly users!: pulumi.Output<outputs.MdbPostgresqlClusterUser[]>;

    /**
     * Create a MdbPostgresqlCluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MdbPostgresqlClusterArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MdbPostgresqlClusterArgs | MdbPostgresqlClusterState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as MdbPostgresqlClusterState | undefined;
            inputs["config"] = state ? state.config : undefined;
            inputs["createdAt"] = state ? state.createdAt : undefined;
            inputs["databases"] = state ? state.databases : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["environment"] = state ? state.environment : undefined;
            inputs["folderId"] = state ? state.folderId : undefined;
            inputs["health"] = state ? state.health : undefined;
            inputs["hostMasterName"] = state ? state.hostMasterName : undefined;
            inputs["hosts"] = state ? state.hosts : undefined;
            inputs["labels"] = state ? state.labels : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["networkId"] = state ? state.networkId : undefined;
            inputs["restore"] = state ? state.restore : undefined;
            inputs["securityGroupIds"] = state ? state.securityGroupIds : undefined;
            inputs["status"] = state ? state.status : undefined;
            inputs["users"] = state ? state.users : undefined;
        } else {
            const args = argsOrState as MdbPostgresqlClusterArgs | undefined;
            if ((!args || args.config === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'config'");
            }
            if ((!args || args.databases === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'databases'");
            }
            if ((!args || args.environment === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'environment'");
            }
            if ((!args || args.hosts === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'hosts'");
            }
            if ((!args || args.networkId === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'networkId'");
            }
            if ((!args || args.users === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'users'");
            }
            inputs["config"] = args ? args.config : undefined;
            inputs["databases"] = args ? args.databases : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["environment"] = args ? args.environment : undefined;
            inputs["folderId"] = args ? args.folderId : undefined;
            inputs["hostMasterName"] = args ? args.hostMasterName : undefined;
            inputs["hosts"] = args ? args.hosts : undefined;
            inputs["labels"] = args ? args.labels : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["networkId"] = args ? args.networkId : undefined;
            inputs["restore"] = args ? args.restore : undefined;
            inputs["securityGroupIds"] = args ? args.securityGroupIds : undefined;
            inputs["users"] = args ? args.users : undefined;
            inputs["createdAt"] = undefined /*out*/;
            inputs["health"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(MdbPostgresqlCluster.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering MdbPostgresqlCluster resources.
 */
export interface MdbPostgresqlClusterState {
    readonly config?: pulumi.Input<inputs.MdbPostgresqlClusterConfig>;
    readonly createdAt?: pulumi.Input<string>;
    readonly databases?: pulumi.Input<pulumi.Input<inputs.MdbPostgresqlClusterDatabase>[]>;
    readonly description?: pulumi.Input<string>;
    readonly environment?: pulumi.Input<string>;
    readonly folderId?: pulumi.Input<string>;
    readonly health?: pulumi.Input<string>;
    readonly hostMasterName?: pulumi.Input<string>;
    readonly hosts?: pulumi.Input<pulumi.Input<inputs.MdbPostgresqlClusterHost>[]>;
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    readonly name?: pulumi.Input<string>;
    readonly networkId?: pulumi.Input<string>;
    readonly restore?: pulumi.Input<inputs.MdbPostgresqlClusterRestore>;
    readonly securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    readonly status?: pulumi.Input<string>;
    readonly users?: pulumi.Input<pulumi.Input<inputs.MdbPostgresqlClusterUser>[]>;
}

/**
 * The set of arguments for constructing a MdbPostgresqlCluster resource.
 */
export interface MdbPostgresqlClusterArgs {
    readonly config: pulumi.Input<inputs.MdbPostgresqlClusterConfig>;
    readonly databases: pulumi.Input<pulumi.Input<inputs.MdbPostgresqlClusterDatabase>[]>;
    readonly description?: pulumi.Input<string>;
    readonly environment: pulumi.Input<string>;
    readonly folderId?: pulumi.Input<string>;
    readonly hostMasterName?: pulumi.Input<string>;
    readonly hosts: pulumi.Input<pulumi.Input<inputs.MdbPostgresqlClusterHost>[]>;
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    readonly name?: pulumi.Input<string>;
    readonly networkId: pulumi.Input<string>;
    readonly restore?: pulumi.Input<inputs.MdbPostgresqlClusterRestore>;
    readonly securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    readonly users: pulumi.Input<pulumi.Input<inputs.MdbPostgresqlClusterUser>[]>;
}
