# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from . import _utilities, _tables

__all__ = ['StorageObjet']


class StorageObjet(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 access_key: Optional[pulumi.Input[str]] = None,
                 acl: Optional[pulumi.Input[str]] = None,
                 bucket: Optional[pulumi.Input[str]] = None,
                 content: Optional[pulumi.Input[str]] = None,
                 content_base64: Optional[pulumi.Input[str]] = None,
                 key: Optional[pulumi.Input[str]] = None,
                 secret_key: Optional[pulumi.Input[str]] = None,
                 source: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Create a StorageObjet resource with the given unique name, props, and options.
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

            __props__['access_key'] = access_key
            __props__['acl'] = acl
            if bucket is None and not opts.urn:
                raise TypeError("Missing required property 'bucket'")
            __props__['bucket'] = bucket
            __props__['content'] = content
            __props__['content_base64'] = content_base64
            if key is None and not opts.urn:
                raise TypeError("Missing required property 'key'")
            __props__['key'] = key
            __props__['secret_key'] = secret_key
            __props__['source'] = source
        super(StorageObjet, __self__).__init__(
            'yandex:index/storageObjet:StorageObjet',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            access_key: Optional[pulumi.Input[str]] = None,
            acl: Optional[pulumi.Input[str]] = None,
            bucket: Optional[pulumi.Input[str]] = None,
            content: Optional[pulumi.Input[str]] = None,
            content_base64: Optional[pulumi.Input[str]] = None,
            key: Optional[pulumi.Input[str]] = None,
            secret_key: Optional[pulumi.Input[str]] = None,
            source: Optional[pulumi.Input[str]] = None) -> 'StorageObjet':
        """
        Get an existing StorageObjet resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["access_key"] = access_key
        __props__["acl"] = acl
        __props__["bucket"] = bucket
        __props__["content"] = content
        __props__["content_base64"] = content_base64
        __props__["key"] = key
        __props__["secret_key"] = secret_key
        __props__["source"] = source
        return StorageObjet(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accessKey")
    def access_key(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "access_key")

    @property
    @pulumi.getter
    def acl(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "acl")

    @property
    @pulumi.getter
    def bucket(self) -> pulumi.Output[str]:
        return pulumi.get(self, "bucket")

    @property
    @pulumi.getter
    def content(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "content")

    @property
    @pulumi.getter(name="contentBase64")
    def content_base64(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "content_base64")

    @property
    @pulumi.getter
    def key(self) -> pulumi.Output[str]:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter(name="secretKey")
    def secret_key(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "secret_key")

    @property
    @pulumi.getter
    def source(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "source")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

