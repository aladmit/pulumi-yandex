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
    'GetMdbMongodbClusterResult',
    'AwaitableGetMdbMongodbClusterResult',
    'get_mdb_mongodb_cluster',
]

@pulumi.output_type
class GetMdbMongodbClusterResult:
    """
    A collection of values returned by getMdbMongodbCluster.
    """
    def __init__(__self__, cluster_config=None, cluster_id=None, created_at=None, databases=None, description=None, environment=None, folder_id=None, health=None, hosts=None, id=None, labels=None, name=None, network_id=None, resources=None, security_group_ids=None, sharded=None, status=None, users=None):
        if cluster_config and not isinstance(cluster_config, dict):
            raise TypeError("Expected argument 'cluster_config' to be a dict")
        pulumi.set(__self__, "cluster_config", cluster_config)
        if cluster_id and not isinstance(cluster_id, str):
            raise TypeError("Expected argument 'cluster_id' to be a str")
        pulumi.set(__self__, "cluster_id", cluster_id)
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if databases and not isinstance(databases, list):
            raise TypeError("Expected argument 'databases' to be a list")
        pulumi.set(__self__, "databases", databases)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if environment and not isinstance(environment, str):
            raise TypeError("Expected argument 'environment' to be a str")
        pulumi.set(__self__, "environment", environment)
        if folder_id and not isinstance(folder_id, str):
            raise TypeError("Expected argument 'folder_id' to be a str")
        pulumi.set(__self__, "folder_id", folder_id)
        if health and not isinstance(health, str):
            raise TypeError("Expected argument 'health' to be a str")
        pulumi.set(__self__, "health", health)
        if hosts and not isinstance(hosts, list):
            raise TypeError("Expected argument 'hosts' to be a list")
        pulumi.set(__self__, "hosts", hosts)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if network_id and not isinstance(network_id, str):
            raise TypeError("Expected argument 'network_id' to be a str")
        pulumi.set(__self__, "network_id", network_id)
        if resources and not isinstance(resources, dict):
            raise TypeError("Expected argument 'resources' to be a dict")
        pulumi.set(__self__, "resources", resources)
        if security_group_ids and not isinstance(security_group_ids, list):
            raise TypeError("Expected argument 'security_group_ids' to be a list")
        pulumi.set(__self__, "security_group_ids", security_group_ids)
        if sharded and not isinstance(sharded, bool):
            raise TypeError("Expected argument 'sharded' to be a bool")
        pulumi.set(__self__, "sharded", sharded)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
        if users and not isinstance(users, list):
            raise TypeError("Expected argument 'users' to be a list")
        pulumi.set(__self__, "users", users)

    @property
    @pulumi.getter(name="clusterConfig")
    def cluster_config(self) -> 'outputs.GetMdbMongodbClusterClusterConfigResult':
        return pulumi.get(self, "cluster_config")

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> str:
        return pulumi.get(self, "cluster_id")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def databases(self) -> Sequence['outputs.GetMdbMongodbClusterDatabaseResult']:
        return pulumi.get(self, "databases")

    @property
    @pulumi.getter
    def description(self) -> str:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def environment(self) -> str:
        return pulumi.get(self, "environment")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> str:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def health(self) -> str:
        return pulumi.get(self, "health")

    @property
    @pulumi.getter
    def hosts(self) -> Sequence['outputs.GetMdbMongodbClusterHostResult']:
        return pulumi.get(self, "hosts")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

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
    @pulumi.getter
    def resources(self) -> 'outputs.GetMdbMongodbClusterResourcesResult':
        return pulumi.get(self, "resources")

    @property
    @pulumi.getter(name="securityGroupIds")
    def security_group_ids(self) -> Sequence[str]:
        return pulumi.get(self, "security_group_ids")

    @property
    @pulumi.getter
    def sharded(self) -> bool:
        return pulumi.get(self, "sharded")

    @property
    @pulumi.getter
    def status(self) -> str:
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def users(self) -> Sequence['outputs.GetMdbMongodbClusterUserResult']:
        return pulumi.get(self, "users")


class AwaitableGetMdbMongodbClusterResult(GetMdbMongodbClusterResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetMdbMongodbClusterResult(
            cluster_config=self.cluster_config,
            cluster_id=self.cluster_id,
            created_at=self.created_at,
            databases=self.databases,
            description=self.description,
            environment=self.environment,
            folder_id=self.folder_id,
            health=self.health,
            hosts=self.hosts,
            id=self.id,
            labels=self.labels,
            name=self.name,
            network_id=self.network_id,
            resources=self.resources,
            security_group_ids=self.security_group_ids,
            sharded=self.sharded,
            status=self.status,
            users=self.users)


def get_mdb_mongodb_cluster(cluster_id: Optional[str] = None,
                            folder_id: Optional[str] = None,
                            name: Optional[str] = None,
                            opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetMdbMongodbClusterResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['clusterId'] = cluster_id
    __args__['folderId'] = folder_id
    __args__['name'] = name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('yandex:index/getMdbMongodbCluster:getMdbMongodbCluster', __args__, opts=opts, typ=GetMdbMongodbClusterResult).value

    return AwaitableGetMdbMongodbClusterResult(
        cluster_config=__ret__.cluster_config,
        cluster_id=__ret__.cluster_id,
        created_at=__ret__.created_at,
        databases=__ret__.databases,
        description=__ret__.description,
        environment=__ret__.environment,
        folder_id=__ret__.folder_id,
        health=__ret__.health,
        hosts=__ret__.hosts,
        id=__ret__.id,
        labels=__ret__.labels,
        name=__ret__.name,
        network_id=__ret__.network_id,
        resources=__ret__.resources,
        security_group_ids=__ret__.security_group_ids,
        sharded=__ret__.sharded,
        status=__ret__.status,
        users=__ret__.users)
