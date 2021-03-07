# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from . import _utilities, _tables
from . import outputs

__all__ = [
    'GetVpcSecurityGroupResult',
    'AwaitableGetVpcSecurityGroupResult',
    'get_vpc_security_group',
]

@pulumi.output_type
class GetVpcSecurityGroupResult:
    """
    A collection of values returned by getVpcSecurityGroup.
    """
    def __init__(__self__, created_at=None, description=None, egresses=None, folder_id=None, id=None, ingresses=None, labels=None, name=None, network_id=None, security_group_id=None, status=None):
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if egresses and not isinstance(egresses, list):
            raise TypeError("Expected argument 'egresses' to be a list")
        pulumi.set(__self__, "egresses", egresses)
        if folder_id and not isinstance(folder_id, str):
            raise TypeError("Expected argument 'folder_id' to be a str")
        pulumi.set(__self__, "folder_id", folder_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ingresses and not isinstance(ingresses, list):
            raise TypeError("Expected argument 'ingresses' to be a list")
        pulumi.set(__self__, "ingresses", ingresses)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if network_id and not isinstance(network_id, str):
            raise TypeError("Expected argument 'network_id' to be a str")
        pulumi.set(__self__, "network_id", network_id)
        if security_group_id and not isinstance(security_group_id, str):
            raise TypeError("Expected argument 'security_group_id' to be a str")
        pulumi.set(__self__, "security_group_id", security_group_id)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> str:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def egresses(self) -> Sequence['outputs.GetVpcSecurityGroupEgressResult']:
        return pulumi.get(self, "egresses")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> str:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def ingresses(self) -> Sequence['outputs.GetVpcSecurityGroupIngressResult']:
        return pulumi.get(self, "ingresses")

    @property
    @pulumi.getter
    def labels(self) -> Mapping[str, str]:
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> str:
        return pulumi.get(self, "network_id")

    @property
    @pulumi.getter(name="securityGroupId")
    def security_group_id(self) -> str:
        return pulumi.get(self, "security_group_id")

    @property
    @pulumi.getter
    def status(self) -> str:
        return pulumi.get(self, "status")


class AwaitableGetVpcSecurityGroupResult(GetVpcSecurityGroupResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetVpcSecurityGroupResult(
            created_at=self.created_at,
            description=self.description,
            egresses=self.egresses,
            folder_id=self.folder_id,
            id=self.id,
            ingresses=self.ingresses,
            labels=self.labels,
            name=self.name,
            network_id=self.network_id,
            security_group_id=self.security_group_id,
            status=self.status)


def get_vpc_security_group(folder_id: Optional[str] = None,
                           name: Optional[str] = None,
                           security_group_id: Optional[str] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetVpcSecurityGroupResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['folderId'] = folder_id
    __args__['name'] = name
    __args__['securityGroupId'] = security_group_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('yandex:index/getVpcSecurityGroup:getVpcSecurityGroup', __args__, opts=opts, typ=GetVpcSecurityGroupResult).value

    return AwaitableGetVpcSecurityGroupResult(
        created_at=__ret__.created_at,
        description=__ret__.description,
        egresses=__ret__.egresses,
        folder_id=__ret__.folder_id,
        id=__ret__.id,
        ingresses=__ret__.ingresses,
        labels=__ret__.labels,
        name=__ret__.name,
        network_id=__ret__.network_id,
        security_group_id=__ret__.security_group_id,
        status=__ret__.status)
