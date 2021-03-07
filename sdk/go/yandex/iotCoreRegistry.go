// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type IotCoreRegistry struct {
	pulumi.CustomResourceState

	Certificates pulumi.StringArrayOutput `pulumi:"certificates"`
	CreatedAt    pulumi.StringOutput      `pulumi:"createdAt"`
	Description  pulumi.StringPtrOutput   `pulumi:"description"`
	FolderId     pulumi.StringOutput      `pulumi:"folderId"`
	Labels       pulumi.StringMapOutput   `pulumi:"labels"`
	Name         pulumi.StringOutput      `pulumi:"name"`
	Passwords    pulumi.StringArrayOutput `pulumi:"passwords"`
}

// NewIotCoreRegistry registers a new resource with the given unique name, arguments, and options.
func NewIotCoreRegistry(ctx *pulumi.Context,
	name string, args *IotCoreRegistryArgs, opts ...pulumi.ResourceOption) (*IotCoreRegistry, error) {
	if args == nil {
		args = &IotCoreRegistryArgs{}
	}

	var resource IotCoreRegistry
	err := ctx.RegisterResource("yandex:index/iotCoreRegistry:IotCoreRegistry", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIotCoreRegistry gets an existing IotCoreRegistry resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIotCoreRegistry(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IotCoreRegistryState, opts ...pulumi.ResourceOption) (*IotCoreRegistry, error) {
	var resource IotCoreRegistry
	err := ctx.ReadResource("yandex:index/iotCoreRegistry:IotCoreRegistry", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IotCoreRegistry resources.
type iotCoreRegistryState struct {
	Certificates []string          `pulumi:"certificates"`
	CreatedAt    *string           `pulumi:"createdAt"`
	Description  *string           `pulumi:"description"`
	FolderId     *string           `pulumi:"folderId"`
	Labels       map[string]string `pulumi:"labels"`
	Name         *string           `pulumi:"name"`
	Passwords    []string          `pulumi:"passwords"`
}

type IotCoreRegistryState struct {
	Certificates pulumi.StringArrayInput
	CreatedAt    pulumi.StringPtrInput
	Description  pulumi.StringPtrInput
	FolderId     pulumi.StringPtrInput
	Labels       pulumi.StringMapInput
	Name         pulumi.StringPtrInput
	Passwords    pulumi.StringArrayInput
}

func (IotCoreRegistryState) ElementType() reflect.Type {
	return reflect.TypeOf((*iotCoreRegistryState)(nil)).Elem()
}

type iotCoreRegistryArgs struct {
	Certificates []string          `pulumi:"certificates"`
	Description  *string           `pulumi:"description"`
	FolderId     *string           `pulumi:"folderId"`
	Labels       map[string]string `pulumi:"labels"`
	Name         *string           `pulumi:"name"`
	Passwords    []string          `pulumi:"passwords"`
}

// The set of arguments for constructing a IotCoreRegistry resource.
type IotCoreRegistryArgs struct {
	Certificates pulumi.StringArrayInput
	Description  pulumi.StringPtrInput
	FolderId     pulumi.StringPtrInput
	Labels       pulumi.StringMapInput
	Name         pulumi.StringPtrInput
	Passwords    pulumi.StringArrayInput
}

func (IotCoreRegistryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*iotCoreRegistryArgs)(nil)).Elem()
}

type IotCoreRegistryInput interface {
	pulumi.Input

	ToIotCoreRegistryOutput() IotCoreRegistryOutput
	ToIotCoreRegistryOutputWithContext(ctx context.Context) IotCoreRegistryOutput
}

func (*IotCoreRegistry) ElementType() reflect.Type {
	return reflect.TypeOf((*IotCoreRegistry)(nil))
}

func (i *IotCoreRegistry) ToIotCoreRegistryOutput() IotCoreRegistryOutput {
	return i.ToIotCoreRegistryOutputWithContext(context.Background())
}

func (i *IotCoreRegistry) ToIotCoreRegistryOutputWithContext(ctx context.Context) IotCoreRegistryOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IotCoreRegistryOutput)
}

type IotCoreRegistryOutput struct {
	*pulumi.OutputState
}

func (IotCoreRegistryOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*IotCoreRegistry)(nil))
}

func (o IotCoreRegistryOutput) ToIotCoreRegistryOutput() IotCoreRegistryOutput {
	return o
}

func (o IotCoreRegistryOutput) ToIotCoreRegistryOutputWithContext(ctx context.Context) IotCoreRegistryOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(IotCoreRegistryOutput{})
}
