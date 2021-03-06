// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class KmsSymmetricKey extends pulumi.CustomResource {
    /**
     * Get an existing KmsSymmetricKey resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: KmsSymmetricKeyState, opts?: pulumi.CustomResourceOptions): KmsSymmetricKey {
        return new KmsSymmetricKey(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/kmsSymmetricKey:KmsSymmetricKey';

    /**
     * Returns true if the given object is an instance of KmsSymmetricKey.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is KmsSymmetricKey {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === KmsSymmetricKey.__pulumiType;
    }

    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    public readonly defaultAlgorithm!: pulumi.Output<string | undefined>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly folderId!: pulumi.Output<string>;
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly name!: pulumi.Output<string>;
    public /*out*/ readonly rotatedAt!: pulumi.Output<string>;
    public readonly rotationPeriod!: pulumi.Output<string | undefined>;
    public /*out*/ readonly status!: pulumi.Output<string>;

    /**
     * Create a KmsSymmetricKey resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: KmsSymmetricKeyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: KmsSymmetricKeyArgs | KmsSymmetricKeyState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as KmsSymmetricKeyState | undefined;
            inputs["createdAt"] = state ? state.createdAt : undefined;
            inputs["defaultAlgorithm"] = state ? state.defaultAlgorithm : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["folderId"] = state ? state.folderId : undefined;
            inputs["labels"] = state ? state.labels : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["rotatedAt"] = state ? state.rotatedAt : undefined;
            inputs["rotationPeriod"] = state ? state.rotationPeriod : undefined;
            inputs["status"] = state ? state.status : undefined;
        } else {
            const args = argsOrState as KmsSymmetricKeyArgs | undefined;
            inputs["defaultAlgorithm"] = args ? args.defaultAlgorithm : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["folderId"] = args ? args.folderId : undefined;
            inputs["labels"] = args ? args.labels : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["rotationPeriod"] = args ? args.rotationPeriod : undefined;
            inputs["createdAt"] = undefined /*out*/;
            inputs["rotatedAt"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(KmsSymmetricKey.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering KmsSymmetricKey resources.
 */
export interface KmsSymmetricKeyState {
    readonly createdAt?: pulumi.Input<string>;
    readonly defaultAlgorithm?: pulumi.Input<string>;
    readonly description?: pulumi.Input<string>;
    readonly folderId?: pulumi.Input<string>;
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    readonly name?: pulumi.Input<string>;
    readonly rotatedAt?: pulumi.Input<string>;
    readonly rotationPeriod?: pulumi.Input<string>;
    readonly status?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a KmsSymmetricKey resource.
 */
export interface KmsSymmetricKeyArgs {
    readonly defaultAlgorithm?: pulumi.Input<string>;
    readonly description?: pulumi.Input<string>;
    readonly folderId?: pulumi.Input<string>;
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    readonly name?: pulumi.Input<string>;
    readonly rotationPeriod?: pulumi.Input<string>;
}
