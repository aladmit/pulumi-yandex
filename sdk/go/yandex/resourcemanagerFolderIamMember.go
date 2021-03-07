// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type ResourcemanagerFolderIamMember struct {
	pulumi.CustomResourceState

	FolderId   pulumi.StringOutput `pulumi:"folderId"`
	Member     pulumi.StringOutput `pulumi:"member"`
	Role       pulumi.StringOutput `pulumi:"role"`
	SleepAfter pulumi.IntPtrOutput `pulumi:"sleepAfter"`
}

// NewResourcemanagerFolderIamMember registers a new resource with the given unique name, arguments, and options.
func NewResourcemanagerFolderIamMember(ctx *pulumi.Context,
	name string, args *ResourcemanagerFolderIamMemberArgs, opts ...pulumi.ResourceOption) (*ResourcemanagerFolderIamMember, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.FolderId == nil {
		return nil, errors.New("invalid value for required argument 'FolderId'")
	}
	if args.Member == nil {
		return nil, errors.New("invalid value for required argument 'Member'")
	}
	if args.Role == nil {
		return nil, errors.New("invalid value for required argument 'Role'")
	}
	var resource ResourcemanagerFolderIamMember
	err := ctx.RegisterResource("yandex:index/resourcemanagerFolderIamMember:ResourcemanagerFolderIamMember", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetResourcemanagerFolderIamMember gets an existing ResourcemanagerFolderIamMember resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetResourcemanagerFolderIamMember(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ResourcemanagerFolderIamMemberState, opts ...pulumi.ResourceOption) (*ResourcemanagerFolderIamMember, error) {
	var resource ResourcemanagerFolderIamMember
	err := ctx.ReadResource("yandex:index/resourcemanagerFolderIamMember:ResourcemanagerFolderIamMember", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ResourcemanagerFolderIamMember resources.
type resourcemanagerFolderIamMemberState struct {
	FolderId   *string `pulumi:"folderId"`
	Member     *string `pulumi:"member"`
	Role       *string `pulumi:"role"`
	SleepAfter *int    `pulumi:"sleepAfter"`
}

type ResourcemanagerFolderIamMemberState struct {
	FolderId   pulumi.StringPtrInput
	Member     pulumi.StringPtrInput
	Role       pulumi.StringPtrInput
	SleepAfter pulumi.IntPtrInput
}

func (ResourcemanagerFolderIamMemberState) ElementType() reflect.Type {
	return reflect.TypeOf((*resourcemanagerFolderIamMemberState)(nil)).Elem()
}

type resourcemanagerFolderIamMemberArgs struct {
	FolderId   string `pulumi:"folderId"`
	Member     string `pulumi:"member"`
	Role       string `pulumi:"role"`
	SleepAfter *int   `pulumi:"sleepAfter"`
}

// The set of arguments for constructing a ResourcemanagerFolderIamMember resource.
type ResourcemanagerFolderIamMemberArgs struct {
	FolderId   pulumi.StringInput
	Member     pulumi.StringInput
	Role       pulumi.StringInput
	SleepAfter pulumi.IntPtrInput
}

func (ResourcemanagerFolderIamMemberArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*resourcemanagerFolderIamMemberArgs)(nil)).Elem()
}

type ResourcemanagerFolderIamMemberInput interface {
	pulumi.Input

	ToResourcemanagerFolderIamMemberOutput() ResourcemanagerFolderIamMemberOutput
	ToResourcemanagerFolderIamMemberOutputWithContext(ctx context.Context) ResourcemanagerFolderIamMemberOutput
}

func (*ResourcemanagerFolderIamMember) ElementType() reflect.Type {
	return reflect.TypeOf((*ResourcemanagerFolderIamMember)(nil))
}

func (i *ResourcemanagerFolderIamMember) ToResourcemanagerFolderIamMemberOutput() ResourcemanagerFolderIamMemberOutput {
	return i.ToResourcemanagerFolderIamMemberOutputWithContext(context.Background())
}

func (i *ResourcemanagerFolderIamMember) ToResourcemanagerFolderIamMemberOutputWithContext(ctx context.Context) ResourcemanagerFolderIamMemberOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourcemanagerFolderIamMemberOutput)
}

type ResourcemanagerFolderIamMemberOutput struct {
	*pulumi.OutputState
}

func (ResourcemanagerFolderIamMemberOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ResourcemanagerFolderIamMember)(nil))
}

func (o ResourcemanagerFolderIamMemberOutput) ToResourcemanagerFolderIamMemberOutput() ResourcemanagerFolderIamMemberOutput {
	return o
}

func (o ResourcemanagerFolderIamMemberOutput) ToResourcemanagerFolderIamMemberOutputWithContext(ctx context.Context) ResourcemanagerFolderIamMemberOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ResourcemanagerFolderIamMemberOutput{})
}
