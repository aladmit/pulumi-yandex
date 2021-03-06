// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetIamServiceAccount(ctx *pulumi.Context, args *GetIamServiceAccountArgs, opts ...pulumi.InvokeOption) (*GetIamServiceAccountResult, error) {
	var rv GetIamServiceAccountResult
	err := ctx.Invoke("yandex:index/getIamServiceAccount:getIamServiceAccount", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getIamServiceAccount.
type GetIamServiceAccountArgs struct {
	FolderId         *string `pulumi:"folderId"`
	Name             *string `pulumi:"name"`
	ServiceAccountId *string `pulumi:"serviceAccountId"`
}

// A collection of values returned by getIamServiceAccount.
type GetIamServiceAccountResult struct {
	CreatedAt   string `pulumi:"createdAt"`
	Description string `pulumi:"description"`
	FolderId    string `pulumi:"folderId"`
	// The provider-assigned unique ID for this managed resource.
	Id               string `pulumi:"id"`
	Name             string `pulumi:"name"`
	ServiceAccountId string `pulumi:"serviceAccountId"`
}
