// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type ResourcemanagerCloudIamBinding struct {
	pulumi.CustomResourceState

	CloudId    pulumi.StringOutput      `pulumi:"cloudId"`
	Members    pulumi.StringArrayOutput `pulumi:"members"`
	Role       pulumi.StringOutput      `pulumi:"role"`
	SleepAfter pulumi.IntPtrOutput      `pulumi:"sleepAfter"`
}

// NewResourcemanagerCloudIamBinding registers a new resource with the given unique name, arguments, and options.
func NewResourcemanagerCloudIamBinding(ctx *pulumi.Context,
	name string, args *ResourcemanagerCloudIamBindingArgs, opts ...pulumi.ResourceOption) (*ResourcemanagerCloudIamBinding, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CloudId == nil {
		return nil, errors.New("invalid value for required argument 'CloudId'")
	}
	if args.Members == nil {
		return nil, errors.New("invalid value for required argument 'Members'")
	}
	if args.Role == nil {
		return nil, errors.New("invalid value for required argument 'Role'")
	}
	var resource ResourcemanagerCloudIamBinding
	err := ctx.RegisterResource("yandex:index/resourcemanagerCloudIamBinding:ResourcemanagerCloudIamBinding", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetResourcemanagerCloudIamBinding gets an existing ResourcemanagerCloudIamBinding resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetResourcemanagerCloudIamBinding(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ResourcemanagerCloudIamBindingState, opts ...pulumi.ResourceOption) (*ResourcemanagerCloudIamBinding, error) {
	var resource ResourcemanagerCloudIamBinding
	err := ctx.ReadResource("yandex:index/resourcemanagerCloudIamBinding:ResourcemanagerCloudIamBinding", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ResourcemanagerCloudIamBinding resources.
type resourcemanagerCloudIamBindingState struct {
	CloudId    *string  `pulumi:"cloudId"`
	Members    []string `pulumi:"members"`
	Role       *string  `pulumi:"role"`
	SleepAfter *int     `pulumi:"sleepAfter"`
}

type ResourcemanagerCloudIamBindingState struct {
	CloudId    pulumi.StringPtrInput
	Members    pulumi.StringArrayInput
	Role       pulumi.StringPtrInput
	SleepAfter pulumi.IntPtrInput
}

func (ResourcemanagerCloudIamBindingState) ElementType() reflect.Type {
	return reflect.TypeOf((*resourcemanagerCloudIamBindingState)(nil)).Elem()
}

type resourcemanagerCloudIamBindingArgs struct {
	CloudId    string   `pulumi:"cloudId"`
	Members    []string `pulumi:"members"`
	Role       string   `pulumi:"role"`
	SleepAfter *int     `pulumi:"sleepAfter"`
}

// The set of arguments for constructing a ResourcemanagerCloudIamBinding resource.
type ResourcemanagerCloudIamBindingArgs struct {
	CloudId    pulumi.StringInput
	Members    pulumi.StringArrayInput
	Role       pulumi.StringInput
	SleepAfter pulumi.IntPtrInput
}

func (ResourcemanagerCloudIamBindingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*resourcemanagerCloudIamBindingArgs)(nil)).Elem()
}

type ResourcemanagerCloudIamBindingInput interface {
	pulumi.Input

	ToResourcemanagerCloudIamBindingOutput() ResourcemanagerCloudIamBindingOutput
	ToResourcemanagerCloudIamBindingOutputWithContext(ctx context.Context) ResourcemanagerCloudIamBindingOutput
}

func (*ResourcemanagerCloudIamBinding) ElementType() reflect.Type {
	return reflect.TypeOf((*ResourcemanagerCloudIamBinding)(nil))
}

func (i *ResourcemanagerCloudIamBinding) ToResourcemanagerCloudIamBindingOutput() ResourcemanagerCloudIamBindingOutput {
	return i.ToResourcemanagerCloudIamBindingOutputWithContext(context.Background())
}

func (i *ResourcemanagerCloudIamBinding) ToResourcemanagerCloudIamBindingOutputWithContext(ctx context.Context) ResourcemanagerCloudIamBindingOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourcemanagerCloudIamBindingOutput)
}

type ResourcemanagerCloudIamBindingOutput struct {
	*pulumi.OutputState
}

func (ResourcemanagerCloudIamBindingOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ResourcemanagerCloudIamBinding)(nil))
}

func (o ResourcemanagerCloudIamBindingOutput) ToResourcemanagerCloudIamBindingOutput() ResourcemanagerCloudIamBindingOutput {
	return o
}

func (o ResourcemanagerCloudIamBindingOutput) ToResourcemanagerCloudIamBindingOutputWithContext(ctx context.Context) ResourcemanagerCloudIamBindingOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ResourcemanagerCloudIamBindingOutput{})
}
