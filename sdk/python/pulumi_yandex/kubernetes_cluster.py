# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from . import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['KubernetesCluster']


class KubernetesCluster(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_ipv4_range: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 kms_provider: Optional[pulumi.Input[pulumi.InputType['KubernetesClusterKmsProviderArgs']]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 master: Optional[pulumi.Input[pulumi.InputType['KubernetesClusterMasterArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 network_id: Optional[pulumi.Input[str]] = None,
                 network_policy_provider: Optional[pulumi.Input[str]] = None,
                 node_ipv4_cidr_mask_size: Optional[pulumi.Input[int]] = None,
                 node_service_account_id: Optional[pulumi.Input[str]] = None,
                 release_channel: Optional[pulumi.Input[str]] = None,
                 service_account_id: Optional[pulumi.Input[str]] = None,
                 service_ipv4_range: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Create a KubernetesCluster resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['cluster_ipv4_range'] = cluster_ipv4_range
            __props__['description'] = description
            __props__['folder_id'] = folder_id
            __props__['kms_provider'] = kms_provider
            __props__['labels'] = labels
            if master is None and not opts.urn:
                raise TypeError("Missing required property 'master'")
            __props__['master'] = master
            __props__['name'] = name
            if network_id is None and not opts.urn:
                raise TypeError("Missing required property 'network_id'")
            __props__['network_id'] = network_id
            __props__['network_policy_provider'] = network_policy_provider
            __props__['node_ipv4_cidr_mask_size'] = node_ipv4_cidr_mask_size
            if node_service_account_id is None and not opts.urn:
                raise TypeError("Missing required property 'node_service_account_id'")
            __props__['node_service_account_id'] = node_service_account_id
            __props__['release_channel'] = release_channel
            if service_account_id is None and not opts.urn:
                raise TypeError("Missing required property 'service_account_id'")
            __props__['service_account_id'] = service_account_id
            __props__['service_ipv4_range'] = service_ipv4_range
            __props__['created_at'] = None
            __props__['health'] = None
            __props__['status'] = None
        super(KubernetesCluster, __self__).__init__(
            'yandex:index/kubernetesCluster:KubernetesCluster',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            cluster_ipv4_range: Optional[pulumi.Input[str]] = None,
            created_at: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            folder_id: Optional[pulumi.Input[str]] = None,
            health: Optional[pulumi.Input[str]] = None,
            kms_provider: Optional[pulumi.Input[pulumi.InputType['KubernetesClusterKmsProviderArgs']]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            master: Optional[pulumi.Input[pulumi.InputType['KubernetesClusterMasterArgs']]] = None,
            name: Optional[pulumi.Input[str]] = None,
            network_id: Optional[pulumi.Input[str]] = None,
            network_policy_provider: Optional[pulumi.Input[str]] = None,
            node_ipv4_cidr_mask_size: Optional[pulumi.Input[int]] = None,
            node_service_account_id: Optional[pulumi.Input[str]] = None,
            release_channel: Optional[pulumi.Input[str]] = None,
            service_account_id: Optional[pulumi.Input[str]] = None,
            service_ipv4_range: Optional[pulumi.Input[str]] = None,
            status: Optional[pulumi.Input[str]] = None) -> 'KubernetesCluster':
        """
        Get an existing KubernetesCluster resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["cluster_ipv4_range"] = cluster_ipv4_range
        __props__["created_at"] = created_at
        __props__["description"] = description
        __props__["folder_id"] = folder_id
        __props__["health"] = health
        __props__["kms_provider"] = kms_provider
        __props__["labels"] = labels
        __props__["master"] = master
        __props__["name"] = name
        __props__["network_id"] = network_id
        __props__["network_policy_provider"] = network_policy_provider
        __props__["node_ipv4_cidr_mask_size"] = node_ipv4_cidr_mask_size
        __props__["node_service_account_id"] = node_service_account_id
        __props__["release_channel"] = release_channel
        __props__["service_account_id"] = service_account_id
        __props__["service_ipv4_range"] = service_ipv4_range
        __props__["status"] = status
        return KubernetesCluster(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="clusterIpv4Range")
    def cluster_ipv4_range(self) -> pulumi.Output[str]:
        return pulumi.get(self, "cluster_ipv4_range")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[str]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def health(self) -> pulumi.Output[str]:
        return pulumi.get(self, "health")

    @property
    @pulumi.getter(name="kmsProvider")
    def kms_provider(self) -> pulumi.Output[Optional['outputs.KubernetesClusterKmsProvider']]:
        return pulumi.get(self, "kms_provider")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Mapping[str, str]]:
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def master(self) -> pulumi.Output['outputs.KubernetesClusterMaster']:
        return pulumi.get(self, "master")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "network_id")

    @property
    @pulumi.getter(name="networkPolicyProvider")
    def network_policy_provider(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "network_policy_provider")

    @property
    @pulumi.getter(name="nodeIpv4CidrMaskSize")
    def node_ipv4_cidr_mask_size(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "node_ipv4_cidr_mask_size")

    @property
    @pulumi.getter(name="nodeServiceAccountId")
    def node_service_account_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "node_service_account_id")

    @property
    @pulumi.getter(name="releaseChannel")
    def release_channel(self) -> pulumi.Output[str]:
        return pulumi.get(self, "release_channel")

    @property
    @pulumi.getter(name="serviceAccountId")
    def service_account_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "service_account_id")

    @property
    @pulumi.getter(name="serviceIpv4Range")
    def service_ipv4_range(self) -> pulumi.Output[str]:
        return pulumi.get(self, "service_ipv4_range")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        return pulumi.get(self, "status")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

