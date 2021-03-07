// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type ResourcemanagerFolderIamBinding struct {
	pulumi.CustomResourceState

	FolderId   pulumi.StringOutput      `pulumi:"folderId"`
	Members    pulumi.StringArrayOutput `pulumi:"members"`
	Role       pulumi.StringOutput      `pulumi:"role"`
	SleepAfter pulumi.IntPtrOutput      `pulumi:"sleepAfter"`
}

// NewResourcemanagerFolderIamBinding registers a new resource with the given unique name, arguments, and options.
func NewResourcemanagerFolderIamBinding(ctx *pulumi.Context,
	name string, args *ResourcemanagerFolderIamBindingArgs, opts ...pulumi.ResourceOption) (*ResourcemanagerFolderIamBinding, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.FolderId == nil {
		return nil, errors.New("invalid value for required argument 'FolderId'")
	}
	if args.Members == nil {
		return nil, errors.New("invalid value for required argument 'Members'")
	}
	if args.Role == nil {
		return nil, errors.New("invalid value for required argument 'Role'")
	}
	var resource ResourcemanagerFolderIamBinding
	err := ctx.RegisterResource("yandex:index/resourcemanagerFolderIamBinding:ResourcemanagerFolderIamBinding", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetResourcemanagerFolderIamBinding gets an existing ResourcemanagerFolderIamBinding resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetResourcemanagerFolderIamBinding(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ResourcemanagerFolderIamBindingState, opts ...pulumi.ResourceOption) (*ResourcemanagerFolderIamBinding, error) {
	var resource ResourcemanagerFolderIamBinding
	err := ctx.ReadResource("yandex:index/resourcemanagerFolderIamBinding:ResourcemanagerFolderIamBinding", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ResourcemanagerFolderIamBinding resources.
type resourcemanagerFolderIamBindingState struct {
	FolderId   *string  `pulumi:"folderId"`
	Members    []string `pulumi:"members"`
	Role       *string  `pulumi:"role"`
	SleepAfter *int     `pulumi:"sleepAfter"`
}

type ResourcemanagerFolderIamBindingState struct {
	FolderId   pulumi.StringPtrInput
	Members    pulumi.StringArrayInput
	Role       pulumi.StringPtrInput
	SleepAfter pulumi.IntPtrInput
}

func (ResourcemanagerFolderIamBindingState) ElementType() reflect.Type {
	return reflect.TypeOf((*resourcemanagerFolderIamBindingState)(nil)).Elem()
}

type resourcemanagerFolderIamBindingArgs struct {
	FolderId   string   `pulumi:"folderId"`
	Members    []string `pulumi:"members"`
	Role       string   `pulumi:"role"`
	SleepAfter *int     `pulumi:"sleepAfter"`
}

// The set of arguments for constructing a ResourcemanagerFolderIamBinding resource.
type ResourcemanagerFolderIamBindingArgs struct {
	FolderId   pulumi.StringInput
	Members    pulumi.StringArrayInput
	Role       pulumi.StringInput
	SleepAfter pulumi.IntPtrInput
}

func (ResourcemanagerFolderIamBindingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*resourcemanagerFolderIamBindingArgs)(nil)).Elem()
}

type ResourcemanagerFolderIamBindingInput interface {
	pulumi.Input

	ToResourcemanagerFolderIamBindingOutput() ResourcemanagerFolderIamBindingOutput
	ToResourcemanagerFolderIamBindingOutputWithContext(ctx context.Context) ResourcemanagerFolderIamBindingOutput
}

func (*ResourcemanagerFolderIamBinding) ElementType() reflect.Type {
	return reflect.TypeOf((*ResourcemanagerFolderIamBinding)(nil))
}

func (i *ResourcemanagerFolderIamBinding) ToResourcemanagerFolderIamBindingOutput() ResourcemanagerFolderIamBindingOutput {
	return i.ToResourcemanagerFolderIamBindingOutputWithContext(context.Background())
}

func (i *ResourcemanagerFolderIamBinding) ToResourcemanagerFolderIamBindingOutputWithContext(ctx context.Context) ResourcemanagerFolderIamBindingOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourcemanagerFolderIamBindingOutput)
}

type ResourcemanagerFolderIamBindingOutput struct {
	*pulumi.OutputState
}

func (ResourcemanagerFolderIamBindingOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ResourcemanagerFolderIamBinding)(nil))
}

func (o ResourcemanagerFolderIamBindingOutput) ToResourcemanagerFolderIamBindingOutput() ResourcemanagerFolderIamBindingOutput {
	return o
}

func (o ResourcemanagerFolderIamBindingOutput) ToResourcemanagerFolderIamBindingOutputWithContext(ctx context.Context) ResourcemanagerFolderIamBindingOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ResourcemanagerFolderIamBindingOutput{})
}
