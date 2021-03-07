// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupLbTargetGroup(ctx *pulumi.Context, args *LookupLbTargetGroupArgs, opts ...pulumi.InvokeOption) (*LookupLbTargetGroupResult, error) {
	var rv LookupLbTargetGroupResult
	err := ctx.Invoke("yandex:index/getLbTargetGroup:getLbTargetGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getLbTargetGroup.
type LookupLbTargetGroupArgs struct {
	FolderId      *string `pulumi:"folderId"`
	Name          *string `pulumi:"name"`
	TargetGroupId *string `pulumi:"targetGroupId"`
}

// A collection of values returned by getLbTargetGroup.
type LookupLbTargetGroupResult struct {
	CreatedAt   string `pulumi:"createdAt"`
	Description string `pulumi:"description"`
	FolderId    string `pulumi:"folderId"`
	// The provider-assigned unique ID for this managed resource.
	Id            string                   `pulumi:"id"`
	Labels        map[string]string        `pulumi:"labels"`
	Name          string                   `pulumi:"name"`
	TargetGroupId string                   `pulumi:"targetGroupId"`
	Targets       []GetLbTargetGroupTarget `pulumi:"targets"`
}