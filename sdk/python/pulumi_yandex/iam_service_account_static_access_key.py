# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from . import _utilities, _tables

__all__ = ['IamServiceAccountStaticAccessKey']


class IamServiceAccountStaticAccessKey(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 pgp_key: Optional[pulumi.Input[str]] = None,
                 service_account_id: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Create a IamServiceAccountStaticAccessKey resource with the given unique name, props, and options.
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

            __props__['description'] = description
            __props__['pgp_key'] = pgp_key
            if service_account_id is None and not opts.urn:
                raise TypeError("Missing required property 'service_account_id'")
            __props__['service_account_id'] = service_account_id
            __props__['access_key'] = None
            __props__['created_at'] = None
            __props__['encrypted_secret_key'] = None
            __props__['key_fingerprint'] = None
            __props__['secret_key'] = None
        super(IamServiceAccountStaticAccessKey, __self__).__init__(
            'yandex:index/iamServiceAccountStaticAccessKey:IamServiceAccountStaticAccessKey',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            access_key: Optional[pulumi.Input[str]] = None,
            created_at: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            encrypted_secret_key: Optional[pulumi.Input[str]] = None,
            key_fingerprint: Optional[pulumi.Input[str]] = None,
            pgp_key: Optional[pulumi.Input[str]] = None,
            secret_key: Optional[pulumi.Input[str]] = None,
            service_account_id: Optional[pulumi.Input[str]] = None) -> 'IamServiceAccountStaticAccessKey':
        """
        Get an existing IamServiceAccountStaticAccessKey resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["access_key"] = access_key
        __props__["created_at"] = created_at
        __props__["description"] = description
        __props__["encrypted_secret_key"] = encrypted_secret_key
        __props__["key_fingerprint"] = key_fingerprint
        __props__["pgp_key"] = pgp_key
        __props__["secret_key"] = secret_key
        __props__["service_account_id"] = service_account_id
        return IamServiceAccountStaticAccessKey(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accessKey")
    def access_key(self) -> pulumi.Output[str]:
        return pulumi.get(self, "access_key")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="encryptedSecretKey")
    def encrypted_secret_key(self) -> pulumi.Output[str]:
        return pulumi.get(self, "encrypted_secret_key")

    @property
    @pulumi.getter(name="keyFingerprint")
    def key_fingerprint(self) -> pulumi.Output[str]:
        return pulumi.get(self, "key_fingerprint")

    @property
    @pulumi.getter(name="pgpKey")
    def pgp_key(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "pgp_key")

    @property
    @pulumi.getter(name="secretKey")
    def secret_key(self) -> pulumi.Output[str]:
        return pulumi.get(self, "secret_key")

    @property
    @pulumi.getter(name="serviceAccountId")
    def service_account_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "service_account_id")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

