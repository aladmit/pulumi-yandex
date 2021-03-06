// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "yandex:index/computeDisk:ComputeDisk":
		r, err = NewComputeDisk(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/computeDiskPlacementGroup:ComputeDiskPlacementGroup":
		r, err = NewComputeDiskPlacementGroup(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/computeImage:ComputeImage":
		r, err = NewComputeImage(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/computeInstance:ComputeInstance":
		r, err = NewComputeInstance(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/computeInstanceGroup:ComputeInstanceGroup":
		r, err = NewComputeInstanceGroup(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/computePlacementGroup:ComputePlacementGroup":
		r, err = NewComputePlacementGroup(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/computeSnapshot:ComputeSnapshot":
		r, err = NewComputeSnapshot(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/containerRegistry:ContainerRegistry":
		r, err = NewContainerRegistry(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/containerRegistryIamBinding:ContainerRegistryIamBinding":
		r, err = NewContainerRegistryIamBinding(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/dataprocCluster:DataprocCluster":
		r, err = NewDataprocCluster(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/function:Function":
		r, err = NewFunction(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/functionIamBinding:FunctionIamBinding":
		r, err = NewFunctionIamBinding(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/functionTrigger:FunctionTrigger":
		r, err = NewFunctionTrigger(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/iamServiceAccountApiKey:IamServiceAccountApiKey":
		r, err = NewIamServiceAccountApiKey(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/iamServiceAccountIamBinding:IamServiceAccountIamBinding":
		r, err = NewIamServiceAccountIamBinding(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/iamServiceAccountIamMember:IamServiceAccountIamMember":
		r, err = NewIamServiceAccountIamMember(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/iamServiceAccountIamPolicy:IamServiceAccountIamPolicy":
		r, err = NewIamServiceAccountIamPolicy(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/iamServiceAccountKey:IamServiceAccountKey":
		r, err = NewIamServiceAccountKey(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/iamServiceAccountStaticAccessKey:IamServiceAccountStaticAccessKey":
		r, err = NewIamServiceAccountStaticAccessKey(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/iamServiceCccount:IamServiceCccount":
		r, err = NewIamServiceCccount(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/iotCoreDevice:IotCoreDevice":
		r, err = NewIotCoreDevice(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/iotCoreRegistry:IotCoreRegistry":
		r, err = NewIotCoreRegistry(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/kmsSecretCiphertext:KmsSecretCiphertext":
		r, err = NewKmsSecretCiphertext(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/kmsSymmetricKey:KmsSymmetricKey":
		r, err = NewKmsSymmetricKey(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/kubernetesCluster:KubernetesCluster":
		r, err = NewKubernetesCluster(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/kubernetesNodeGroup:KubernetesNodeGroup":
		r, err = NewKubernetesNodeGroup(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/lbNetworkLoad_balancer:LbNetworkLoad_balancer":
		r, err = NewLbNetworkLoad_balancer(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/lbTargetGroup:LbTargetGroup":
		r, err = NewLbTargetGroup(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/mdbClickhouseCluster:MdbClickhouseCluster":
		r, err = NewMdbClickhouseCluster(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/mdbKafkaCluster:MdbKafkaCluster":
		r, err = NewMdbKafkaCluster(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/mdbMongodbCluster:MdbMongodbCluster":
		r, err = NewMdbMongodbCluster(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/mdbMysqlCluster:MdbMysqlCluster":
		r, err = NewMdbMysqlCluster(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/mdbPostgresqlCluster:MdbPostgresqlCluster":
		r, err = NewMdbPostgresqlCluster(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/mdbRedisCluster:MdbRedisCluster":
		r, err = NewMdbRedisCluster(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/messageQueue:MessageQueue":
		r, err = NewMessageQueue(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/resourcemanagerCloudIamBinding:ResourcemanagerCloudIamBinding":
		r, err = NewResourcemanagerCloudIamBinding(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/resourcemanagerCloudIamMember:ResourcemanagerCloudIamMember":
		r, err = NewResourcemanagerCloudIamMember(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/resourcemanagerFolderIamBinding:ResourcemanagerFolderIamBinding":
		r, err = NewResourcemanagerFolderIamBinding(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/resourcemanagerFolderIamMember:ResourcemanagerFolderIamMember":
		r, err = NewResourcemanagerFolderIamMember(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/resourcemanagerFolderIamPolicy:ResourcemanagerFolderIamPolicy":
		r, err = NewResourcemanagerFolderIamPolicy(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/storageBucket:StorageBucket":
		r, err = NewStorageBucket(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/storageObjet:StorageObjet":
		r, err = NewStorageObjet(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/vpcAddress:VpcAddress":
		r, err = NewVpcAddress(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/vpcNetwork:VpcNetwork":
		r, err = NewVpcNetwork(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/vpcRouteTable:VpcRouteTable":
		r, err = NewVpcRouteTable(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/vpcSecurityGroup:VpcSecurityGroup":
		r, err = NewVpcSecurityGroup(ctx, name, nil, pulumi.URN_(urn))
	case "yandex:index/vpcSubnet:VpcSubnet":
		r, err = NewVpcSubnet(ctx, name, nil, pulumi.URN_(urn))
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	return
}

type pkg struct {
	version semver.Version
}

func (p *pkg) Version() semver.Version {
	return p.version
}

func (p *pkg) ConstructProvider(ctx *pulumi.Context, name, typ, urn string) (pulumi.ProviderResource, error) {
	if typ != "pulumi:providers:yandex" {
		return nil, fmt.Errorf("unknown provider type: %s", typ)
	}

	return NewProvider(ctx, name, nil, pulumi.URN_(urn))
}

func init() {
	version, err := PkgVersion()
	if err != nil {
		fmt.Println("failed to determine package version. defaulting to v1: %v", err)
	}
	pulumi.RegisterResourceModule(
		"yandex",
		"index/computeDisk",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/computeDiskPlacementGroup",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/computeImage",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/computeInstance",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/computeInstanceGroup",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/computePlacementGroup",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/computeSnapshot",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/containerRegistry",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/containerRegistryIamBinding",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/dataprocCluster",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/function",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/functionIamBinding",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/functionTrigger",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/iamServiceAccountApiKey",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/iamServiceAccountIamBinding",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/iamServiceAccountIamMember",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/iamServiceAccountIamPolicy",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/iamServiceAccountKey",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/iamServiceAccountStaticAccessKey",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/iamServiceCccount",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/iotCoreDevice",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/iotCoreRegistry",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/kmsSecretCiphertext",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/kmsSymmetricKey",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/kubernetesCluster",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/kubernetesNodeGroup",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/lbNetworkLoad_balancer",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/lbTargetGroup",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/mdbClickhouseCluster",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/mdbKafkaCluster",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/mdbMongodbCluster",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/mdbMysqlCluster",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/mdbPostgresqlCluster",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/mdbRedisCluster",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/messageQueue",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/resourcemanagerCloudIamBinding",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/resourcemanagerCloudIamMember",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/resourcemanagerFolderIamBinding",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/resourcemanagerFolderIamMember",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/resourcemanagerFolderIamPolicy",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/storageBucket",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/storageObjet",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/vpcAddress",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/vpcNetwork",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/vpcRouteTable",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/vpcSecurityGroup",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"yandex",
		"index/vpcSubnet",
		&module{version},
	)
	pulumi.RegisterResourcePackage(
		"yandex",
		&pkg{version},
	)
}
