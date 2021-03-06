// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type ComputeInstance struct {
	pulumi.CustomResourceState

	AllowStoppingForUpdate  pulumi.BoolPtrOutput                       `pulumi:"allowStoppingForUpdate"`
	BootDisk                ComputeInstanceBootDiskOutput              `pulumi:"bootDisk"`
	CreatedAt               pulumi.StringOutput                        `pulumi:"createdAt"`
	Description             pulumi.StringPtrOutput                     `pulumi:"description"`
	FolderId                pulumi.StringOutput                        `pulumi:"folderId"`
	Fqdn                    pulumi.StringOutput                        `pulumi:"fqdn"`
	Hostname                pulumi.StringOutput                        `pulumi:"hostname"`
	Labels                  pulumi.StringMapOutput                     `pulumi:"labels"`
	Metadata                pulumi.StringMapOutput                     `pulumi:"metadata"`
	Name                    pulumi.StringOutput                        `pulumi:"name"`
	NetworkAccelerationType pulumi.StringPtrOutput                     `pulumi:"networkAccelerationType"`
	NetworkInterfaces       ComputeInstanceNetworkInterfaceArrayOutput `pulumi:"networkInterfaces"`
	PlacementPolicy         ComputeInstancePlacementPolicyOutput       `pulumi:"placementPolicy"`
	PlatformId              pulumi.StringPtrOutput                     `pulumi:"platformId"`
	Resources               ComputeInstanceResourcesOutput             `pulumi:"resources"`
	SchedulingPolicy        ComputeInstanceSchedulingPolicyOutput      `pulumi:"schedulingPolicy"`
	SecondaryDisks          ComputeInstanceSecondaryDiskArrayOutput    `pulumi:"secondaryDisks"`
	ServiceAccountId        pulumi.StringOutput                        `pulumi:"serviceAccountId"`
	Status                  pulumi.StringOutput                        `pulumi:"status"`
	Zone                    pulumi.StringOutput                        `pulumi:"zone"`
}

// NewComputeInstance registers a new resource with the given unique name, arguments, and options.
func NewComputeInstance(ctx *pulumi.Context,
	name string, args *ComputeInstanceArgs, opts ...pulumi.ResourceOption) (*ComputeInstance, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.BootDisk == nil {
		return nil, errors.New("invalid value for required argument 'BootDisk'")
	}
	if args.NetworkInterfaces == nil {
		return nil, errors.New("invalid value for required argument 'NetworkInterfaces'")
	}
	if args.Resources == nil {
		return nil, errors.New("invalid value for required argument 'Resources'")
	}
	var resource ComputeInstance
	err := ctx.RegisterResource("yandex:index/computeInstance:ComputeInstance", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetComputeInstance gets an existing ComputeInstance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetComputeInstance(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ComputeInstanceState, opts ...pulumi.ResourceOption) (*ComputeInstance, error) {
	var resource ComputeInstance
	err := ctx.ReadResource("yandex:index/computeInstance:ComputeInstance", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ComputeInstance resources.
type computeInstanceState struct {
	AllowStoppingForUpdate  *bool                             `pulumi:"allowStoppingForUpdate"`
	BootDisk                *ComputeInstanceBootDisk          `pulumi:"bootDisk"`
	CreatedAt               *string                           `pulumi:"createdAt"`
	Description             *string                           `pulumi:"description"`
	FolderId                *string                           `pulumi:"folderId"`
	Fqdn                    *string                           `pulumi:"fqdn"`
	Hostname                *string                           `pulumi:"hostname"`
	Labels                  map[string]string                 `pulumi:"labels"`
	Metadata                map[string]string                 `pulumi:"metadata"`
	Name                    *string                           `pulumi:"name"`
	NetworkAccelerationType *string                           `pulumi:"networkAccelerationType"`
	NetworkInterfaces       []ComputeInstanceNetworkInterface `pulumi:"networkInterfaces"`
	PlacementPolicy         *ComputeInstancePlacementPolicy   `pulumi:"placementPolicy"`
	PlatformId              *string                           `pulumi:"platformId"`
	Resources               *ComputeInstanceResources         `pulumi:"resources"`
	SchedulingPolicy        *ComputeInstanceSchedulingPolicy  `pulumi:"schedulingPolicy"`
	SecondaryDisks          []ComputeInstanceSecondaryDisk    `pulumi:"secondaryDisks"`
	ServiceAccountId        *string                           `pulumi:"serviceAccountId"`
	Status                  *string                           `pulumi:"status"`
	Zone                    *string                           `pulumi:"zone"`
}

type ComputeInstanceState struct {
	AllowStoppingForUpdate  pulumi.BoolPtrInput
	BootDisk                ComputeInstanceBootDiskPtrInput
	CreatedAt               pulumi.StringPtrInput
	Description             pulumi.StringPtrInput
	FolderId                pulumi.StringPtrInput
	Fqdn                    pulumi.StringPtrInput
	Hostname                pulumi.StringPtrInput
	Labels                  pulumi.StringMapInput
	Metadata                pulumi.StringMapInput
	Name                    pulumi.StringPtrInput
	NetworkAccelerationType pulumi.StringPtrInput
	NetworkInterfaces       ComputeInstanceNetworkInterfaceArrayInput
	PlacementPolicy         ComputeInstancePlacementPolicyPtrInput
	PlatformId              pulumi.StringPtrInput
	Resources               ComputeInstanceResourcesPtrInput
	SchedulingPolicy        ComputeInstanceSchedulingPolicyPtrInput
	SecondaryDisks          ComputeInstanceSecondaryDiskArrayInput
	ServiceAccountId        pulumi.StringPtrInput
	Status                  pulumi.StringPtrInput
	Zone                    pulumi.StringPtrInput
}

func (ComputeInstanceState) ElementType() reflect.Type {
	return reflect.TypeOf((*computeInstanceState)(nil)).Elem()
}

type computeInstanceArgs struct {
	AllowStoppingForUpdate  *bool                             `pulumi:"allowStoppingForUpdate"`
	BootDisk                ComputeInstanceBootDisk           `pulumi:"bootDisk"`
	Description             *string                           `pulumi:"description"`
	FolderId                *string                           `pulumi:"folderId"`
	Hostname                *string                           `pulumi:"hostname"`
	Labels                  map[string]string                 `pulumi:"labels"`
	Metadata                map[string]string                 `pulumi:"metadata"`
	Name                    *string                           `pulumi:"name"`
	NetworkAccelerationType *string                           `pulumi:"networkAccelerationType"`
	NetworkInterfaces       []ComputeInstanceNetworkInterface `pulumi:"networkInterfaces"`
	PlacementPolicy         *ComputeInstancePlacementPolicy   `pulumi:"placementPolicy"`
	PlatformId              *string                           `pulumi:"platformId"`
	Resources               ComputeInstanceResources          `pulumi:"resources"`
	SchedulingPolicy        *ComputeInstanceSchedulingPolicy  `pulumi:"schedulingPolicy"`
	SecondaryDisks          []ComputeInstanceSecondaryDisk    `pulumi:"secondaryDisks"`
	ServiceAccountId        *string                           `pulumi:"serviceAccountId"`
	Zone                    *string                           `pulumi:"zone"`
}

// The set of arguments for constructing a ComputeInstance resource.
type ComputeInstanceArgs struct {
	AllowStoppingForUpdate  pulumi.BoolPtrInput
	BootDisk                ComputeInstanceBootDiskInput
	Description             pulumi.StringPtrInput
	FolderId                pulumi.StringPtrInput
	Hostname                pulumi.StringPtrInput
	Labels                  pulumi.StringMapInput
	Metadata                pulumi.StringMapInput
	Name                    pulumi.StringPtrInput
	NetworkAccelerationType pulumi.StringPtrInput
	NetworkInterfaces       ComputeInstanceNetworkInterfaceArrayInput
	PlacementPolicy         ComputeInstancePlacementPolicyPtrInput
	PlatformId              pulumi.StringPtrInput
	Resources               ComputeInstanceResourcesInput
	SchedulingPolicy        ComputeInstanceSchedulingPolicyPtrInput
	SecondaryDisks          ComputeInstanceSecondaryDiskArrayInput
	ServiceAccountId        pulumi.StringPtrInput
	Zone                    pulumi.StringPtrInput
}

func (ComputeInstanceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*computeInstanceArgs)(nil)).Elem()
}

type ComputeInstanceInput interface {
	pulumi.Input

	ToComputeInstanceOutput() ComputeInstanceOutput
	ToComputeInstanceOutputWithContext(ctx context.Context) ComputeInstanceOutput
}

func (*ComputeInstance) ElementType() reflect.Type {
	return reflect.TypeOf((*ComputeInstance)(nil))
}

func (i *ComputeInstance) ToComputeInstanceOutput() ComputeInstanceOutput {
	return i.ToComputeInstanceOutputWithContext(context.Background())
}

func (i *ComputeInstance) ToComputeInstanceOutputWithContext(ctx context.Context) ComputeInstanceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComputeInstanceOutput)
}

type ComputeInstanceOutput struct {
	*pulumi.OutputState
}

func (ComputeInstanceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ComputeInstance)(nil))
}

func (o ComputeInstanceOutput) ToComputeInstanceOutput() ComputeInstanceOutput {
	return o
}

func (o ComputeInstanceOutput) ToComputeInstanceOutputWithContext(ctx context.Context) ComputeInstanceOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ComputeInstanceOutput{})
}
