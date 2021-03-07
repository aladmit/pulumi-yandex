// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupMdbKafkaCluster(ctx *pulumi.Context, args *LookupMdbKafkaClusterArgs, opts ...pulumi.InvokeOption) (*LookupMdbKafkaClusterResult, error) {
	var rv LookupMdbKafkaClusterResult
	err := ctx.Invoke("yandex:index/getMdbKafkaCluster:getMdbKafkaCluster", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getMdbKafkaCluster.
type LookupMdbKafkaClusterArgs struct {
	ClusterId *string                   `pulumi:"clusterId"`
	Config    *GetMdbKafkaClusterConfig `pulumi:"config"`
	FolderId  *string                   `pulumi:"folderId"`
	Name      *string                   `pulumi:"name"`
	SubnetIds []string                  `pulumi:"subnetIds"`
	Topics    []GetMdbKafkaClusterTopic `pulumi:"topics"`
	Users     []GetMdbKafkaClusterUser  `pulumi:"users"`
}

// A collection of values returned by getMdbKafkaCluster.
type LookupMdbKafkaClusterResult struct {
	ClusterId   string                    `pulumi:"clusterId"`
	Config      *GetMdbKafkaClusterConfig `pulumi:"config"`
	CreatedAt   string                    `pulumi:"createdAt"`
	Description string                    `pulumi:"description"`
	Environment string                    `pulumi:"environment"`
	FolderId    string                    `pulumi:"folderId"`
	Health      string                    `pulumi:"health"`
	// The provider-assigned unique ID for this managed resource.
	Id               string                    `pulumi:"id"`
	Labels           map[string]string         `pulumi:"labels"`
	Name             string                    `pulumi:"name"`
	NetworkId        string                    `pulumi:"networkId"`
	SecurityGroupIds []string                  `pulumi:"securityGroupIds"`
	Status           string                    `pulumi:"status"`
	SubnetIds        []string                  `pulumi:"subnetIds"`
	Topics           []GetMdbKafkaClusterTopic `pulumi:"topics"`
	Users            []GetMdbKafkaClusterUser  `pulumi:"users"`
}
