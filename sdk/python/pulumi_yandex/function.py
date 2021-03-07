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

__all__ = ['Function']


class Function(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 content: Optional[pulumi.Input[pulumi.InputType['FunctionContentArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 entrypoint: Optional[pulumi.Input[str]] = None,
                 environment: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 execution_timeout: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 memory: Optional[pulumi.Input[int]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 package: Optional[pulumi.Input[pulumi.InputType['FunctionPackageArgs']]] = None,
                 runtime: Optional[pulumi.Input[str]] = None,
                 service_account_id: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 user_hash: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Create a Function resource with the given unique name, props, and options.
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

            __props__['content'] = content
            __props__['description'] = description
            if entrypoint is None and not opts.urn:
                raise TypeError("Missing required property 'entrypoint'")
            __props__['entrypoint'] = entrypoint
            __props__['environment'] = environment
            __props__['execution_timeout'] = execution_timeout
            __props__['folder_id'] = folder_id
            __props__['labels'] = labels
            if memory is None and not opts.urn:
                raise TypeError("Missing required property 'memory'")
            __props__['memory'] = memory
            __props__['name'] = name
            __props__['package'] = package
            if runtime is None and not opts.urn:
                raise TypeError("Missing required property 'runtime'")
            __props__['runtime'] = runtime
            __props__['service_account_id'] = service_account_id
            __props__['tags'] = tags
            if user_hash is None and not opts.urn:
                raise TypeError("Missing required property 'user_hash'")
            __props__['user_hash'] = user_hash
            __props__['created_at'] = None
            __props__['image_size'] = None
            __props__['loggroup_id'] = None
            __props__['version'] = None
        super(Function, __self__).__init__(
            'yandex:index/function:Function',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            content: Optional[pulumi.Input[pulumi.InputType['FunctionContentArgs']]] = None,
            created_at: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            entrypoint: Optional[pulumi.Input[str]] = None,
            environment: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            execution_timeout: Optional[pulumi.Input[str]] = None,
            folder_id: Optional[pulumi.Input[str]] = None,
            image_size: Optional[pulumi.Input[int]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            loggroup_id: Optional[pulumi.Input[str]] = None,
            memory: Optional[pulumi.Input[int]] = None,
            name: Optional[pulumi.Input[str]] = None,
            package: Optional[pulumi.Input[pulumi.InputType['FunctionPackageArgs']]] = None,
            runtime: Optional[pulumi.Input[str]] = None,
            service_account_id: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            user_hash: Optional[pulumi.Input[str]] = None,
            version: Optional[pulumi.Input[str]] = None) -> 'Function':
        """
        Get an existing Function resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["content"] = content
        __props__["created_at"] = created_at
        __props__["description"] = description
        __props__["entrypoint"] = entrypoint
        __props__["environment"] = environment
        __props__["execution_timeout"] = execution_timeout
        __props__["folder_id"] = folder_id
        __props__["image_size"] = image_size
        __props__["labels"] = labels
        __props__["loggroup_id"] = loggroup_id
        __props__["memory"] = memory
        __props__["name"] = name
        __props__["package"] = package
        __props__["runtime"] = runtime
        __props__["service_account_id"] = service_account_id
        __props__["tags"] = tags
        __props__["user_hash"] = user_hash
        __props__["version"] = version
        return Function(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def content(self) -> pulumi.Output[Optional['outputs.FunctionContent']]:
        return pulumi.get(self, "content")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def entrypoint(self) -> pulumi.Output[str]:
        return pulumi.get(self, "entrypoint")

    @property
    @pulumi.getter
    def environment(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        return pulumi.get(self, "environment")

    @property
    @pulumi.getter(name="executionTimeout")
    def execution_timeout(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "execution_timeout")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter(name="imageSize")
    def image_size(self) -> pulumi.Output[int]:
        return pulumi.get(self, "image_size")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter(name="loggroupId")
    def loggroup_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "loggroup_id")

    @property
    @pulumi.getter
    def memory(self) -> pulumi.Output[int]:
        return pulumi.get(self, "memory")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def package(self) -> pulumi.Output[Optional['outputs.FunctionPackage']]:
        return pulumi.get(self, "package")

    @property
    @pulumi.getter
    def runtime(self) -> pulumi.Output[str]:
        return pulumi.get(self, "runtime")

    @property
    @pulumi.getter(name="serviceAccountId")
    def service_account_id(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "service_account_id")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Sequence[str]]:
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="userHash")
    def user_hash(self) -> pulumi.Output[str]:
        return pulumi.get(self, "user_hash")

    @property
    @pulumi.getter
    def version(self) -> pulumi.Output[str]:
        return pulumi.get(self, "version")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
