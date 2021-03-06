// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type ComputeInstanceGroup struct {
	pulumi.CustomResourceState

	AllocationPolicy   ComputeInstanceGroupAllocationPolicyOutput `pulumi:"allocationPolicy"`
	CreatedAt          pulumi.StringOutput                        `pulumi:"createdAt"`
	DeletionProtection pulumi.BoolPtrOutput                       `pulumi:"deletionProtection"`
	DeployPolicy       ComputeInstanceGroupDeployPolicyOutput     `pulumi:"deployPolicy"`
	Description        pulumi.StringPtrOutput                     `pulumi:"description"`
	FolderId           pulumi.StringOutput                        `pulumi:"folderId"`
	HealthChecks       ComputeInstanceGroupHealthCheckArrayOutput `pulumi:"healthChecks"`
	InstanceTemplate   ComputeInstanceGroupInstanceTemplateOutput `pulumi:"instanceTemplate"`
	Instances          ComputeInstanceGroupInstanceArrayOutput    `pulumi:"instances"`
	Labels             pulumi.StringMapOutput                     `pulumi:"labels"`
	LoadBalancer       ComputeInstanceGroupLoadBalancerPtrOutput  `pulumi:"loadBalancer"`
	Name               pulumi.StringOutput                        `pulumi:"name"`
	ScalePolicy        ComputeInstanceGroupScalePolicyOutput      `pulumi:"scalePolicy"`
	ServiceAccountId   pulumi.StringOutput                        `pulumi:"serviceAccountId"`
	Status             pulumi.StringOutput                        `pulumi:"status"`
	Variables          pulumi.StringMapOutput                     `pulumi:"variables"`
}

// NewComputeInstanceGroup registers a new resource with the given unique name, arguments, and options.
func NewComputeInstanceGroup(ctx *pulumi.Context,
	name string, args *ComputeInstanceGroupArgs, opts ...pulumi.ResourceOption) (*ComputeInstanceGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AllocationPolicy == nil {
		return nil, errors.New("invalid value for required argument 'AllocationPolicy'")
	}
	if args.DeployPolicy == nil {
		return nil, errors.New("invalid value for required argument 'DeployPolicy'")
	}
	if args.InstanceTemplate == nil {
		return nil, errors.New("invalid value for required argument 'InstanceTemplate'")
	}
	if args.ScalePolicy == nil {
		return nil, errors.New("invalid value for required argument 'ScalePolicy'")
	}
	if args.ServiceAccountId == nil {
		return nil, errors.New("invalid value for required argument 'ServiceAccountId'")
	}
	var resource ComputeInstanceGroup
	err := ctx.RegisterResource("yandex:index/computeInstanceGroup:ComputeInstanceGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetComputeInstanceGroup gets an existing ComputeInstanceGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetComputeInstanceGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ComputeInstanceGroupState, opts ...pulumi.ResourceOption) (*ComputeInstanceGroup, error) {
	var resource ComputeInstanceGroup
	err := ctx.ReadResource("yandex:index/computeInstanceGroup:ComputeInstanceGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ComputeInstanceGroup resources.
type computeInstanceGroupState struct {
	AllocationPolicy   *ComputeInstanceGroupAllocationPolicy `pulumi:"allocationPolicy"`
	CreatedAt          *string                               `pulumi:"createdAt"`
	DeletionProtection *bool                                 `pulumi:"deletionProtection"`
	DeployPolicy       *ComputeInstanceGroupDeployPolicy     `pulumi:"deployPolicy"`
	Description        *string                               `pulumi:"description"`
	FolderId           *string                               `pulumi:"folderId"`
	HealthChecks       []ComputeInstanceGroupHealthCheck     `pulumi:"healthChecks"`
	InstanceTemplate   *ComputeInstanceGroupInstanceTemplate `pulumi:"instanceTemplate"`
	Instances          []ComputeInstanceGroupInstance        `pulumi:"instances"`
	Labels             map[string]string                     `pulumi:"labels"`
	LoadBalancer       *ComputeInstanceGroupLoadBalancer     `pulumi:"loadBalancer"`
	Name               *string                               `pulumi:"name"`
	ScalePolicy        *ComputeInstanceGroupScalePolicy      `pulumi:"scalePolicy"`
	ServiceAccountId   *string                               `pulumi:"serviceAccountId"`
	Status             *string                               `pulumi:"status"`
	Variables          map[string]string                     `pulumi:"variables"`
}

type ComputeInstanceGroupState struct {
	AllocationPolicy   ComputeInstanceGroupAllocationPolicyPtrInput
	CreatedAt          pulumi.StringPtrInput
	DeletionProtection pulumi.BoolPtrInput
	DeployPolicy       ComputeInstanceGroupDeployPolicyPtrInput
	Description        pulumi.StringPtrInput
	FolderId           pulumi.StringPtrInput
	HealthChecks       ComputeInstanceGroupHealthCheckArrayInput
	InstanceTemplate   ComputeInstanceGroupInstanceTemplatePtrInput
	Instances          ComputeInstanceGroupInstanceArrayInput
	Labels             pulumi.StringMapInput
	LoadBalancer       ComputeInstanceGroupLoadBalancerPtrInput
	Name               pulumi.StringPtrInput
	ScalePolicy        ComputeInstanceGroupScalePolicyPtrInput
	ServiceAccountId   pulumi.StringPtrInput
	Status             pulumi.StringPtrInput
	Variables          pulumi.StringMapInput
}

func (ComputeInstanceGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*computeInstanceGroupState)(nil)).Elem()
}

type computeInstanceGroupArgs struct {
	AllocationPolicy   ComputeInstanceGroupAllocationPolicy `pulumi:"allocationPolicy"`
	DeletionProtection *bool                                `pulumi:"deletionProtection"`
	DeployPolicy       ComputeInstanceGroupDeployPolicy     `pulumi:"deployPolicy"`
	Description        *string                              `pulumi:"description"`
	FolderId           *string                              `pulumi:"folderId"`
	HealthChecks       []ComputeInstanceGroupHealthCheck    `pulumi:"healthChecks"`
	InstanceTemplate   ComputeInstanceGroupInstanceTemplate `pulumi:"instanceTemplate"`
	Labels             map[string]string                    `pulumi:"labels"`
	LoadBalancer       *ComputeInstanceGroupLoadBalancer    `pulumi:"loadBalancer"`
	Name               *string                              `pulumi:"name"`
	ScalePolicy        ComputeInstanceGroupScalePolicy      `pulumi:"scalePolicy"`
	ServiceAccountId   string                               `pulumi:"serviceAccountId"`
	Variables          map[string]string                    `pulumi:"variables"`
}

// The set of arguments for constructing a ComputeInstanceGroup resource.
type ComputeInstanceGroupArgs struct {
	AllocationPolicy   ComputeInstanceGroupAllocationPolicyInput
	DeletionProtection pulumi.BoolPtrInput
	DeployPolicy       ComputeInstanceGroupDeployPolicyInput
	Description        pulumi.StringPtrInput
	FolderId           pulumi.StringPtrInput
	HealthChecks       ComputeInstanceGroupHealthCheckArrayInput
	InstanceTemplate   ComputeInstanceGroupInstanceTemplateInput
	Labels             pulumi.StringMapInput
	LoadBalancer       ComputeInstanceGroupLoadBalancerPtrInput
	Name               pulumi.StringPtrInput
	ScalePolicy        ComputeInstanceGroupScalePolicyInput
	ServiceAccountId   pulumi.StringInput
	Variables          pulumi.StringMapInput
}

func (ComputeInstanceGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*computeInstanceGroupArgs)(nil)).Elem()
}

type ComputeInstanceGroupInput interface {
	pulumi.Input

	ToComputeInstanceGroupOutput() ComputeInstanceGroupOutput
	ToComputeInstanceGroupOutputWithContext(ctx context.Context) ComputeInstanceGroupOutput
}

func (*ComputeInstanceGroup) ElementType() reflect.Type {
	return reflect.TypeOf((*ComputeInstanceGroup)(nil))
}

func (i *ComputeInstanceGroup) ToComputeInstanceGroupOutput() ComputeInstanceGroupOutput {
	return i.ToComputeInstanceGroupOutputWithContext(context.Background())
}

func (i *ComputeInstanceGroup) ToComputeInstanceGroupOutputWithContext(ctx context.Context) ComputeInstanceGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComputeInstanceGroupOutput)
}

type ComputeInstanceGroupOutput struct {
	*pulumi.OutputState
}

func (ComputeInstanceGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ComputeInstanceGroup)(nil))
}

func (o ComputeInstanceGroupOutput) ToComputeInstanceGroupOutput() ComputeInstanceGroupOutput {
	return o
}

func (o ComputeInstanceGroupOutput) ToComputeInstanceGroupOutputWithContext(ctx context.Context) ComputeInstanceGroupOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ComputeInstanceGroupOutput{})
}
