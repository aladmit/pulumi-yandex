// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupFunction(ctx *pulumi.Context, args *LookupFunctionArgs, opts ...pulumi.InvokeOption) (*LookupFunctionResult, error) {
	var rv LookupFunctionResult
	err := ctx.Invoke("yandex:index/getFunction:getFunction", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getFunction.
type LookupFunctionArgs struct {
	FolderId   *string `pulumi:"folderId"`
	FunctionId *string `pulumi:"functionId"`
	Name       *string `pulumi:"name"`
}

// A collection of values returned by getFunction.
type LookupFunctionResult struct {
	CreatedAt        string            `pulumi:"createdAt"`
	Description      string            `pulumi:"description"`
	Entrypoint       string            `pulumi:"entrypoint"`
	Environment      map[string]string `pulumi:"environment"`
	ExecutionTimeout string            `pulumi:"executionTimeout"`
	FolderId         *string           `pulumi:"folderId"`
	FunctionId       *string           `pulumi:"functionId"`
	// The provider-assigned unique ID for this managed resource.
	Id               string            `pulumi:"id"`
	ImageSize        int               `pulumi:"imageSize"`
	Labels           map[string]string `pulumi:"labels"`
	LoggroupId       string            `pulumi:"loggroupId"`
	Memory           int               `pulumi:"memory"`
	Name             *string           `pulumi:"name"`
	Runtime          string            `pulumi:"runtime"`
	ServiceAccountId string            `pulumi:"serviceAccountId"`
	Tags             []string          `pulumi:"tags"`
	Version          string            `pulumi:"version"`
}
