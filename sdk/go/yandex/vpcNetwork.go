// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type VpcNetwork struct {
	pulumi.CustomResourceState

	CreatedAt              pulumi.StringOutput      `pulumi:"createdAt"`
	DefaultSecurityGroupId pulumi.StringOutput      `pulumi:"defaultSecurityGroupId"`
	Description            pulumi.StringPtrOutput   `pulumi:"description"`
	FolderId               pulumi.StringOutput      `pulumi:"folderId"`
	Labels                 pulumi.StringMapOutput   `pulumi:"labels"`
	Name                   pulumi.StringOutput      `pulumi:"name"`
	SubnetIds              pulumi.StringArrayOutput `pulumi:"subnetIds"`
}

// NewVpcNetwork registers a new resource with the given unique name, arguments, and options.
func NewVpcNetwork(ctx *pulumi.Context,
	name string, args *VpcNetworkArgs, opts ...pulumi.ResourceOption) (*VpcNetwork, error) {
	if args == nil {
		args = &VpcNetworkArgs{}
	}

	var resource VpcNetwork
	err := ctx.RegisterResource("yandex:index/vpcNetwork:VpcNetwork", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVpcNetwork gets an existing VpcNetwork resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVpcNetwork(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VpcNetworkState, opts ...pulumi.ResourceOption) (*VpcNetwork, error) {
	var resource VpcNetwork
	err := ctx.ReadResource("yandex:index/vpcNetwork:VpcNetwork", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VpcNetwork resources.
type vpcNetworkState struct {
	CreatedAt              *string           `pulumi:"createdAt"`
	DefaultSecurityGroupId *string           `pulumi:"defaultSecurityGroupId"`
	Description            *string           `pulumi:"description"`
	FolderId               *string           `pulumi:"folderId"`
	Labels                 map[string]string `pulumi:"labels"`
	Name                   *string           `pulumi:"name"`
	SubnetIds              []string          `pulumi:"subnetIds"`
}

type VpcNetworkState struct {
	CreatedAt              pulumi.StringPtrInput
	DefaultSecurityGroupId pulumi.StringPtrInput
	Description            pulumi.StringPtrInput
	FolderId               pulumi.StringPtrInput
	Labels                 pulumi.StringMapInput
	Name                   pulumi.StringPtrInput
	SubnetIds              pulumi.StringArrayInput
}

func (VpcNetworkState) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcNetworkState)(nil)).Elem()
}

type vpcNetworkArgs struct {
	Description *string           `pulumi:"description"`
	FolderId    *string           `pulumi:"folderId"`
	Labels      map[string]string `pulumi:"labels"`
	Name        *string           `pulumi:"name"`
}

// The set of arguments for constructing a VpcNetwork resource.
type VpcNetworkArgs struct {
	Description pulumi.StringPtrInput
	FolderId    pulumi.StringPtrInput
	Labels      pulumi.StringMapInput
	Name        pulumi.StringPtrInput
}

func (VpcNetworkArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcNetworkArgs)(nil)).Elem()
}

type VpcNetworkInput interface {
	pulumi.Input

	ToVpcNetworkOutput() VpcNetworkOutput
	ToVpcNetworkOutputWithContext(ctx context.Context) VpcNetworkOutput
}

func (*VpcNetwork) ElementType() reflect.Type {
	return reflect.TypeOf((*VpcNetwork)(nil))
}

func (i *VpcNetwork) ToVpcNetworkOutput() VpcNetworkOutput {
	return i.ToVpcNetworkOutputWithContext(context.Background())
}

func (i *VpcNetwork) ToVpcNetworkOutputWithContext(ctx context.Context) VpcNetworkOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VpcNetworkOutput)
}

type VpcNetworkOutput struct {
	*pulumi.OutputState
}

func (VpcNetworkOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VpcNetwork)(nil))
}

func (o VpcNetworkOutput) ToVpcNetworkOutput() VpcNetworkOutput {
	return o
}

func (o VpcNetworkOutput) ToVpcNetworkOutputWithContext(ctx context.Context) VpcNetworkOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(VpcNetworkOutput{})
}
