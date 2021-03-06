# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from . import _utilities, _tables

__all__ = ['MessageQueue']


class MessageQueue(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 access_key: Optional[pulumi.Input[str]] = None,
                 content_based_deduplication: Optional[pulumi.Input[bool]] = None,
                 delay_seconds: Optional[pulumi.Input[int]] = None,
                 fifo_queue: Optional[pulumi.Input[bool]] = None,
                 max_message_size: Optional[pulumi.Input[int]] = None,
                 message_retention_seconds: Optional[pulumi.Input[int]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 name_prefix: Optional[pulumi.Input[str]] = None,
                 receive_wait_time_seconds: Optional[pulumi.Input[int]] = None,
                 redrive_policy: Optional[pulumi.Input[str]] = None,
                 secret_key: Optional[pulumi.Input[str]] = None,
                 visibility_timeout_seconds: Optional[pulumi.Input[int]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Create a MessageQueue resource with the given unique name, props, and options.
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
            __props__['content_based_deduplication'] = content_based_deduplication
            __props__['delay_seconds'] = delay_seconds
            __props__['fifo_queue'] = fifo_queue
            __props__['max_message_size'] = max_message_size
            __props__['message_retention_seconds'] = message_retention_seconds
            __props__['name'] = name
            __props__['name_prefix'] = name_prefix
            __props__['receive_wait_time_seconds'] = receive_wait_time_seconds
            __props__['redrive_policy'] = redrive_policy
            __props__['secret_key'] = secret_key
            __props__['visibility_timeout_seconds'] = visibility_timeout_seconds
            __props__['arn'] = None
        super(MessageQueue, __self__).__init__(
            'yandex:index/messageQueue:MessageQueue',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            access_key: Optional[pulumi.Input[str]] = None,
            arn: Optional[pulumi.Input[str]] = None,
            content_based_deduplication: Optional[pulumi.Input[bool]] = None,
            delay_seconds: Optional[pulumi.Input[int]] = None,
            fifo_queue: Optional[pulumi.Input[bool]] = None,
            max_message_size: Optional[pulumi.Input[int]] = None,
            message_retention_seconds: Optional[pulumi.Input[int]] = None,
            name: Optional[pulumi.Input[str]] = None,
            name_prefix: Optional[pulumi.Input[str]] = None,
            receive_wait_time_seconds: Optional[pulumi.Input[int]] = None,
            redrive_policy: Optional[pulumi.Input[str]] = None,
            secret_key: Optional[pulumi.Input[str]] = None,
            visibility_timeout_seconds: Optional[pulumi.Input[int]] = None) -> 'MessageQueue':
        """
        Get an existing MessageQueue resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["access_key"] = access_key
        __props__["arn"] = arn
        __props__["content_based_deduplication"] = content_based_deduplication
        __props__["delay_seconds"] = delay_seconds
        __props__["fifo_queue"] = fifo_queue
        __props__["max_message_size"] = max_message_size
        __props__["message_retention_seconds"] = message_retention_seconds
        __props__["name"] = name
        __props__["name_prefix"] = name_prefix
        __props__["receive_wait_time_seconds"] = receive_wait_time_seconds
        __props__["redrive_policy"] = redrive_policy
        __props__["secret_key"] = secret_key
        __props__["visibility_timeout_seconds"] = visibility_timeout_seconds
        return MessageQueue(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accessKey")
    def access_key(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "access_key")

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="contentBasedDeduplication")
    def content_based_deduplication(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "content_based_deduplication")

    @property
    @pulumi.getter(name="delaySeconds")
    def delay_seconds(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "delay_seconds")

    @property
    @pulumi.getter(name="fifoQueue")
    def fifo_queue(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "fifo_queue")

    @property
    @pulumi.getter(name="maxMessageSize")
    def max_message_size(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "max_message_size")

    @property
    @pulumi.getter(name="messageRetentionSeconds")
    def message_retention_seconds(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "message_retention_seconds")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="namePrefix")
    def name_prefix(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "name_prefix")

    @property
    @pulumi.getter(name="receiveWaitTimeSeconds")
    def receive_wait_time_seconds(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "receive_wait_time_seconds")

    @property
    @pulumi.getter(name="redrivePolicy")
    def redrive_policy(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "redrive_policy")

    @property
    @pulumi.getter(name="secretKey")
    def secret_key(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "secret_key")

    @property
    @pulumi.getter(name="visibilityTimeoutSeconds")
    def visibility_timeout_seconds(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "visibility_timeout_seconds")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

