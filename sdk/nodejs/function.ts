// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export class Function extends pulumi.CustomResource {
    /**
     * Get an existing Function resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FunctionState, opts?: pulumi.CustomResourceOptions): Function {
        return new Function(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/function:Function';

    /**
     * Returns true if the given object is an instance of Function.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Function {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Function.__pulumiType;
    }

    public readonly content!: pulumi.Output<outputs.FunctionContent | undefined>;
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly entrypoint!: pulumi.Output<string>;
    public readonly environment!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly executionTimeout!: pulumi.Output<string | undefined>;
    public readonly folderId!: pulumi.Output<string>;
    public /*out*/ readonly imageSize!: pulumi.Output<number>;
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    public /*out*/ readonly loggroupId!: pulumi.Output<string>;
    public readonly memory!: pulumi.Output<number>;
    public readonly name!: pulumi.Output<string>;
    public readonly package!: pulumi.Output<outputs.FunctionPackage | undefined>;
    public readonly runtime!: pulumi.Output<string>;
    public readonly serviceAccountId!: pulumi.Output<string | undefined>;
    public readonly tags!: pulumi.Output<string[]>;
    public readonly userHash!: pulumi.Output<string>;
    public /*out*/ readonly version!: pulumi.Output<string>;

    /**
     * Create a Function resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FunctionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FunctionArgs | FunctionState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as FunctionState | undefined;
            inputs["content"] = state ? state.content : undefined;
            inputs["createdAt"] = state ? state.createdAt : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["entrypoint"] = state ? state.entrypoint : undefined;
            inputs["environment"] = state ? state.environment : undefined;
            inputs["executionTimeout"] = state ? state.executionTimeout : undefined;
            inputs["folderId"] = state ? state.folderId : undefined;
            inputs["imageSize"] = state ? state.imageSize : undefined;
            inputs["labels"] = state ? state.labels : undefined;
            inputs["loggroupId"] = state ? state.loggroupId : undefined;
            inputs["memory"] = state ? state.memory : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["package"] = state ? state.package : undefined;
            inputs["runtime"] = state ? state.runtime : undefined;
            inputs["serviceAccountId"] = state ? state.serviceAccountId : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["userHash"] = state ? state.userHash : undefined;
            inputs["version"] = state ? state.version : undefined;
        } else {
            const args = argsOrState as FunctionArgs | undefined;
            if ((!args || args.entrypoint === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'entrypoint'");
            }
            if ((!args || args.memory === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'memory'");
            }
            if ((!args || args.runtime === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'runtime'");
            }
            if ((!args || args.userHash === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'userHash'");
            }
            inputs["content"] = args ? args.content : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["entrypoint"] = args ? args.entrypoint : undefined;
            inputs["environment"] = args ? args.environment : undefined;
            inputs["executionTimeout"] = args ? args.executionTimeout : undefined;
            inputs["folderId"] = args ? args.folderId : undefined;
            inputs["labels"] = args ? args.labels : undefined;
            inputs["memory"] = args ? args.memory : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["package"] = args ? args.package : undefined;
            inputs["runtime"] = args ? args.runtime : undefined;
            inputs["serviceAccountId"] = args ? args.serviceAccountId : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["userHash"] = args ? args.userHash : undefined;
            inputs["createdAt"] = undefined /*out*/;
            inputs["imageSize"] = undefined /*out*/;
            inputs["loggroupId"] = undefined /*out*/;
            inputs["version"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Function.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Function resources.
 */
export interface FunctionState {
    readonly content?: pulumi.Input<inputs.FunctionContent>;
    readonly createdAt?: pulumi.Input<string>;
    readonly description?: pulumi.Input<string>;
    readonly entrypoint?: pulumi.Input<string>;
    readonly environment?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    readonly executionTimeout?: pulumi.Input<string>;
    readonly folderId?: pulumi.Input<string>;
    readonly imageSize?: pulumi.Input<number>;
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    readonly loggroupId?: pulumi.Input<string>;
    readonly memory?: pulumi.Input<number>;
    readonly name?: pulumi.Input<string>;
    readonly package?: pulumi.Input<inputs.FunctionPackage>;
    readonly runtime?: pulumi.Input<string>;
    readonly serviceAccountId?: pulumi.Input<string>;
    readonly tags?: pulumi.Input<pulumi.Input<string>[]>;
    readonly userHash?: pulumi.Input<string>;
    readonly version?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Function resource.
 */
export interface FunctionArgs {
    readonly content?: pulumi.Input<inputs.FunctionContent>;
    readonly description?: pulumi.Input<string>;
    readonly entrypoint: pulumi.Input<string>;
    readonly environment?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    readonly executionTimeout?: pulumi.Input<string>;
    readonly folderId?: pulumi.Input<string>;
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    readonly memory: pulumi.Input<number>;
    readonly name?: pulumi.Input<string>;
    readonly package?: pulumi.Input<inputs.FunctionPackage>;
    readonly runtime: pulumi.Input<string>;
    readonly serviceAccountId?: pulumi.Input<string>;
    readonly tags?: pulumi.Input<pulumi.Input<string>[]>;
    readonly userHash: pulumi.Input<string>;
}
