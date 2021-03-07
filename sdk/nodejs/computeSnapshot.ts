// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class ComputeSnapshot extends pulumi.CustomResource {
    /**
     * Get an existing ComputeSnapshot resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ComputeSnapshotState, opts?: pulumi.CustomResourceOptions): ComputeSnapshot {
        return new ComputeSnapshot(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/computeSnapshot:ComputeSnapshot';

    /**
     * Returns true if the given object is an instance of ComputeSnapshot.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ComputeSnapshot {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ComputeSnapshot.__pulumiType;
    }

    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string | undefined>;
    public /*out*/ readonly diskSize!: pulumi.Output<number>;
    public readonly folderId!: pulumi.Output<string>;
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly name!: pulumi.Output<string>;
    public readonly sourceDiskId!: pulumi.Output<string>;
    public /*out*/ readonly storageSize!: pulumi.Output<number>;

    /**
     * Create a ComputeSnapshot resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ComputeSnapshotArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ComputeSnapshotArgs | ComputeSnapshotState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ComputeSnapshotState | undefined;
            inputs["createdAt"] = state ? state.createdAt : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["diskSize"] = state ? state.diskSize : undefined;
            inputs["folderId"] = state ? state.folderId : undefined;
            inputs["labels"] = state ? state.labels : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["sourceDiskId"] = state ? state.sourceDiskId : undefined;
            inputs["storageSize"] = state ? state.storageSize : undefined;
        } else {
            const args = argsOrState as ComputeSnapshotArgs | undefined;
            if ((!args || args.sourceDiskId === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'sourceDiskId'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["folderId"] = args ? args.folderId : undefined;
            inputs["labels"] = args ? args.labels : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["sourceDiskId"] = args ? args.sourceDiskId : undefined;
            inputs["createdAt"] = undefined /*out*/;
            inputs["diskSize"] = undefined /*out*/;
            inputs["storageSize"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(ComputeSnapshot.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ComputeSnapshot resources.
 */
export interface ComputeSnapshotState {
    readonly createdAt?: pulumi.Input<string>;
    readonly description?: pulumi.Input<string>;
    readonly diskSize?: pulumi.Input<number>;
    readonly folderId?: pulumi.Input<string>;
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    readonly name?: pulumi.Input<string>;
    readonly sourceDiskId?: pulumi.Input<string>;
    readonly storageSize?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a ComputeSnapshot resource.
 */
export interface ComputeSnapshotArgs {
    readonly description?: pulumi.Input<string>;
    readonly folderId?: pulumi.Input<string>;
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    readonly name?: pulumi.Input<string>;
    readonly sourceDiskId: pulumi.Input<string>;
}
