// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type MdbRedisCluster struct {
	pulumi.CustomResourceState

	Config           MdbRedisClusterConfigOutput    `pulumi:"config"`
	CreatedAt        pulumi.StringOutput            `pulumi:"createdAt"`
	Description      pulumi.StringPtrOutput         `pulumi:"description"`
	Environment      pulumi.StringOutput            `pulumi:"environment"`
	FolderId         pulumi.StringOutput            `pulumi:"folderId"`
	Health           pulumi.StringOutput            `pulumi:"health"`
	Hosts            MdbRedisClusterHostArrayOutput `pulumi:"hosts"`
	Labels           pulumi.StringMapOutput         `pulumi:"labels"`
	Name             pulumi.StringOutput            `pulumi:"name"`
	NetworkId        pulumi.StringOutput            `pulumi:"networkId"`
	Resources        MdbRedisClusterResourcesOutput `pulumi:"resources"`
	SecurityGroupIds pulumi.StringArrayOutput       `pulumi:"securityGroupIds"`
	Sharded          pulumi.BoolPtrOutput           `pulumi:"sharded"`
	Status           pulumi.StringOutput            `pulumi:"status"`
}

// NewMdbRedisCluster registers a new resource with the given unique name, arguments, and options.
func NewMdbRedisCluster(ctx *pulumi.Context,
	name string, args *MdbRedisClusterArgs, opts ...pulumi.ResourceOption) (*MdbRedisCluster, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Config == nil {
		return nil, errors.New("invalid value for required argument 'Config'")
	}
	if args.Environment == nil {
		return nil, errors.New("invalid value for required argument 'Environment'")
	}
	if args.Hosts == nil {
		return nil, errors.New("invalid value for required argument 'Hosts'")
	}
	if args.NetworkId == nil {
		return nil, errors.New("invalid value for required argument 'NetworkId'")
	}
	if args.Resources == nil {
		return nil, errors.New("invalid value for required argument 'Resources'")
	}
	var resource MdbRedisCluster
	err := ctx.RegisterResource("yandex:index/mdbRedisCluster:MdbRedisCluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMdbRedisCluster gets an existing MdbRedisCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMdbRedisCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MdbRedisClusterState, opts ...pulumi.ResourceOption) (*MdbRedisCluster, error) {
	var resource MdbRedisCluster
	err := ctx.ReadResource("yandex:index/mdbRedisCluster:MdbRedisCluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MdbRedisCluster resources.
type mdbRedisClusterState struct {
	Config           *MdbRedisClusterConfig    `pulumi:"config"`
	CreatedAt        *string                   `pulumi:"createdAt"`
	Description      *string                   `pulumi:"description"`
	Environment      *string                   `pulumi:"environment"`
	FolderId         *string                   `pulumi:"folderId"`
	Health           *string                   `pulumi:"health"`
	Hosts            []MdbRedisClusterHost     `pulumi:"hosts"`
	Labels           map[string]string         `pulumi:"labels"`
	Name             *string                   `pulumi:"name"`
	NetworkId        *string                   `pulumi:"networkId"`
	Resources        *MdbRedisClusterResources `pulumi:"resources"`
	SecurityGroupIds []string                  `pulumi:"securityGroupIds"`
	Sharded          *bool                     `pulumi:"sharded"`
	Status           *string                   `pulumi:"status"`
}

type MdbRedisClusterState struct {
	Config           MdbRedisClusterConfigPtrInput
	CreatedAt        pulumi.StringPtrInput
	Description      pulumi.StringPtrInput
	Environment      pulumi.StringPtrInput
	FolderId         pulumi.StringPtrInput
	Health           pulumi.StringPtrInput
	Hosts            MdbRedisClusterHostArrayInput
	Labels           pulumi.StringMapInput
	Name             pulumi.StringPtrInput
	NetworkId        pulumi.StringPtrInput
	Resources        MdbRedisClusterResourcesPtrInput
	SecurityGroupIds pulumi.StringArrayInput
	Sharded          pulumi.BoolPtrInput
	Status           pulumi.StringPtrInput
}

func (MdbRedisClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*mdbRedisClusterState)(nil)).Elem()
}

type mdbRedisClusterArgs struct {
	Config           MdbRedisClusterConfig    `pulumi:"config"`
	Description      *string                  `pulumi:"description"`
	Environment      string                   `pulumi:"environment"`
	FolderId         *string                  `pulumi:"folderId"`
	Hosts            []MdbRedisClusterHost    `pulumi:"hosts"`
	Labels           map[string]string        `pulumi:"labels"`
	Name             *string                  `pulumi:"name"`
	NetworkId        string                   `pulumi:"networkId"`
	Resources        MdbRedisClusterResources `pulumi:"resources"`
	SecurityGroupIds []string                 `pulumi:"securityGroupIds"`
	Sharded          *bool                    `pulumi:"sharded"`
}

// The set of arguments for constructing a MdbRedisCluster resource.
type MdbRedisClusterArgs struct {
	Config           MdbRedisClusterConfigInput
	Description      pulumi.StringPtrInput
	Environment      pulumi.StringInput
	FolderId         pulumi.StringPtrInput
	Hosts            MdbRedisClusterHostArrayInput
	Labels           pulumi.StringMapInput
	Name             pulumi.StringPtrInput
	NetworkId        pulumi.StringInput
	Resources        MdbRedisClusterResourcesInput
	SecurityGroupIds pulumi.StringArrayInput
	Sharded          pulumi.BoolPtrInput
}

func (MdbRedisClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*mdbRedisClusterArgs)(nil)).Elem()
}

type MdbRedisClusterInput interface {
	pulumi.Input

	ToMdbRedisClusterOutput() MdbRedisClusterOutput
	ToMdbRedisClusterOutputWithContext(ctx context.Context) MdbRedisClusterOutput
}

func (*MdbRedisCluster) ElementType() reflect.Type {
	return reflect.TypeOf((*MdbRedisCluster)(nil))
}

func (i *MdbRedisCluster) ToMdbRedisClusterOutput() MdbRedisClusterOutput {
	return i.ToMdbRedisClusterOutputWithContext(context.Background())
}

func (i *MdbRedisCluster) ToMdbRedisClusterOutputWithContext(ctx context.Context) MdbRedisClusterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbRedisClusterOutput)
}

type MdbRedisClusterOutput struct {
	*pulumi.OutputState
}

func (MdbRedisClusterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*MdbRedisCluster)(nil))
}

func (o MdbRedisClusterOutput) ToMdbRedisClusterOutput() MdbRedisClusterOutput {
	return o
}

func (o MdbRedisClusterOutput) ToMdbRedisClusterOutputWithContext(ctx context.Context) MdbRedisClusterOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(MdbRedisClusterOutput{})
}