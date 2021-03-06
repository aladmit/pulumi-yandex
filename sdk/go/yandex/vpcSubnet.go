// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type VpcSubnet struct {
	pulumi.CustomResourceState

	CreatedAt    pulumi.StringOutput           `pulumi:"createdAt"`
	Description  pulumi.StringPtrOutput        `pulumi:"description"`
	DhcpOptions  VpcSubnetDhcpOptionsPtrOutput `pulumi:"dhcpOptions"`
	FolderId     pulumi.StringOutput           `pulumi:"folderId"`
	Labels       pulumi.StringMapOutput        `pulumi:"labels"`
	Name         pulumi.StringOutput           `pulumi:"name"`
	NetworkId    pulumi.StringOutput           `pulumi:"networkId"`
	RouteTableId pulumi.StringPtrOutput        `pulumi:"routeTableId"`
	V4CidrBlocks pulumi.StringArrayOutput      `pulumi:"v4CidrBlocks"`
	V6CidrBlocks pulumi.StringArrayOutput      `pulumi:"v6CidrBlocks"`
	Zone         pulumi.StringOutput           `pulumi:"zone"`
}

// NewVpcSubnet registers a new resource with the given unique name, arguments, and options.
func NewVpcSubnet(ctx *pulumi.Context,
	name string, args *VpcSubnetArgs, opts ...pulumi.ResourceOption) (*VpcSubnet, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.NetworkId == nil {
		return nil, errors.New("invalid value for required argument 'NetworkId'")
	}
	if args.V4CidrBlocks == nil {
		return nil, errors.New("invalid value for required argument 'V4CidrBlocks'")
	}
	var resource VpcSubnet
	err := ctx.RegisterResource("yandex:index/vpcSubnet:VpcSubnet", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVpcSubnet gets an existing VpcSubnet resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVpcSubnet(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VpcSubnetState, opts ...pulumi.ResourceOption) (*VpcSubnet, error) {
	var resource VpcSubnet
	err := ctx.ReadResource("yandex:index/vpcSubnet:VpcSubnet", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VpcSubnet resources.
type vpcSubnetState struct {
	CreatedAt    *string               `pulumi:"createdAt"`
	Description  *string               `pulumi:"description"`
	DhcpOptions  *VpcSubnetDhcpOptions `pulumi:"dhcpOptions"`
	FolderId     *string               `pulumi:"folderId"`
	Labels       map[string]string     `pulumi:"labels"`
	Name         *string               `pulumi:"name"`
	NetworkId    *string               `pulumi:"networkId"`
	RouteTableId *string               `pulumi:"routeTableId"`
	V4CidrBlocks []string              `pulumi:"v4CidrBlocks"`
	V6CidrBlocks []string              `pulumi:"v6CidrBlocks"`
	Zone         *string               `pulumi:"zone"`
}

type VpcSubnetState struct {
	CreatedAt    pulumi.StringPtrInput
	Description  pulumi.StringPtrInput
	DhcpOptions  VpcSubnetDhcpOptionsPtrInput
	FolderId     pulumi.StringPtrInput
	Labels       pulumi.StringMapInput
	Name         pulumi.StringPtrInput
	NetworkId    pulumi.StringPtrInput
	RouteTableId pulumi.StringPtrInput
	V4CidrBlocks pulumi.StringArrayInput
	V6CidrBlocks pulumi.StringArrayInput
	Zone         pulumi.StringPtrInput
}

func (VpcSubnetState) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcSubnetState)(nil)).Elem()
}

type vpcSubnetArgs struct {
	Description  *string               `pulumi:"description"`
	DhcpOptions  *VpcSubnetDhcpOptions `pulumi:"dhcpOptions"`
	FolderId     *string               `pulumi:"folderId"`
	Labels       map[string]string     `pulumi:"labels"`
	Name         *string               `pulumi:"name"`
	NetworkId    string                `pulumi:"networkId"`
	RouteTableId *string               `pulumi:"routeTableId"`
	V4CidrBlocks []string              `pulumi:"v4CidrBlocks"`
	Zone         *string               `pulumi:"zone"`
}

// The set of arguments for constructing a VpcSubnet resource.
type VpcSubnetArgs struct {
	Description  pulumi.StringPtrInput
	DhcpOptions  VpcSubnetDhcpOptionsPtrInput
	FolderId     pulumi.StringPtrInput
	Labels       pulumi.StringMapInput
	Name         pulumi.StringPtrInput
	NetworkId    pulumi.StringInput
	RouteTableId pulumi.StringPtrInput
	V4CidrBlocks pulumi.StringArrayInput
	Zone         pulumi.StringPtrInput
}

func (VpcSubnetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcSubnetArgs)(nil)).Elem()
}

type VpcSubnetInput interface {
	pulumi.Input

	ToVpcSubnetOutput() VpcSubnetOutput
	ToVpcSubnetOutputWithContext(ctx context.Context) VpcSubnetOutput
}

func (*VpcSubnet) ElementType() reflect.Type {
	return reflect.TypeOf((*VpcSubnet)(nil))
}

func (i *VpcSubnet) ToVpcSubnetOutput() VpcSubnetOutput {
	return i.ToVpcSubnetOutputWithContext(context.Background())
}

func (i *VpcSubnet) ToVpcSubnetOutputWithContext(ctx context.Context) VpcSubnetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VpcSubnetOutput)
}

type VpcSubnetOutput struct {
	*pulumi.OutputState
}

func (VpcSubnetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VpcSubnet)(nil))
}

func (o VpcSubnetOutput) ToVpcSubnetOutput() VpcSubnetOutput {
	return o
}

func (o VpcSubnetOutput) ToVpcSubnetOutputWithContext(ctx context.Context) VpcSubnetOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(VpcSubnetOutput{})
}
