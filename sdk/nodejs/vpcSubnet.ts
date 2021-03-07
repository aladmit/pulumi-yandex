// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export class VpcSubnet extends pulumi.CustomResource {
    /**
     * Get an existing VpcSubnet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: VpcSubnetState, opts?: pulumi.CustomResourceOptions): VpcSubnet {
        return new VpcSubnet(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/vpcSubnet:VpcSubnet';

    /**
     * Returns true if the given object is an instance of VpcSubnet.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VpcSubnet {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VpcSubnet.__pulumiType;
    }

    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly dhcpOptions!: pulumi.Output<outputs.VpcSubnetDhcpOptions | undefined>;
    public readonly folderId!: pulumi.Output<string>;
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly name!: pulumi.Output<string>;
    public readonly networkId!: pulumi.Output<string>;
    public readonly routeTableId!: pulumi.Output<string | undefined>;
    public readonly v4CidrBlocks!: pulumi.Output<string[]>;
    public /*out*/ readonly v6CidrBlocks!: pulumi.Output<string[]>;
    public readonly zone!: pulumi.Output<string>;

    /**
     * Create a VpcSubnet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VpcSubnetArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: VpcSubnetArgs | VpcSubnetState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as VpcSubnetState | undefined;
            inputs["createdAt"] = state ? state.createdAt : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["dhcpOptions"] = state ? state.dhcpOptions : undefined;
            inputs["folderId"] = state ? state.folderId : undefined;
            inputs["labels"] = state ? state.labels : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["networkId"] = state ? state.networkId : undefined;
            inputs["routeTableId"] = state ? state.routeTableId : undefined;
            inputs["v4CidrBlocks"] = state ? state.v4CidrBlocks : undefined;
            inputs["v6CidrBlocks"] = state ? state.v6CidrBlocks : undefined;
            inputs["zone"] = state ? state.zone : undefined;
        } else {
            const args = argsOrState as VpcSubnetArgs | undefined;
            if ((!args || args.networkId === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'networkId'");
            }
            if ((!args || args.v4CidrBlocks === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'v4CidrBlocks'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["dhcpOptions"] = args ? args.dhcpOptions : undefined;
            inputs["folderId"] = args ? args.folderId : undefined;
            inputs["labels"] = args ? args.labels : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["networkId"] = args ? args.networkId : undefined;
            inputs["routeTableId"] = args ? args.routeTableId : undefined;
            inputs["v4CidrBlocks"] = args ? args.v4CidrBlocks : undefined;
            inputs["zone"] = args ? args.zone : undefined;
            inputs["createdAt"] = undefined /*out*/;
            inputs["v6CidrBlocks"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(VpcSubnet.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering VpcSubnet resources.
 */
export interface VpcSubnetState {
    readonly createdAt?: pulumi.Input<string>;
    readonly description?: pulumi.Input<string>;
    readonly dhcpOptions?: pulumi.Input<inputs.VpcSubnetDhcpOptions>;
    readonly folderId?: pulumi.Input<string>;
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    readonly name?: pulumi.Input<string>;
    readonly networkId?: pulumi.Input<string>;
    readonly routeTableId?: pulumi.Input<string>;
    readonly v4CidrBlocks?: pulumi.Input<pulumi.Input<string>[]>;
    readonly v6CidrBlocks?: pulumi.Input<pulumi.Input<string>[]>;
    readonly zone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a VpcSubnet resource.
 */
export interface VpcSubnetArgs {
    readonly description?: pulumi.Input<string>;
    readonly dhcpOptions?: pulumi.Input<inputs.VpcSubnetDhcpOptions>;
    readonly folderId?: pulumi.Input<string>;
    readonly labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    readonly name?: pulumi.Input<string>;
    readonly networkId: pulumi.Input<string>;
    readonly routeTableId?: pulumi.Input<string>;
    readonly v4CidrBlocks: pulumi.Input<pulumi.Input<string>[]>;
    readonly zone?: pulumi.Input<string>;
}