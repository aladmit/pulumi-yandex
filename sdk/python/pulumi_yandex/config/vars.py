# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables

__all__ = [
    'cloud_id',
    'endpoint',
    'folder_id',
    'insecure',
    'max_retries',
    'plaintext',
    'service_account_key_file',
    'storage_access_key',
    'storage_endpoint',
    'storage_secret_key',
    'token',
    'ymq_access_key',
    'ymq_endpoint',
    'ymq_secret_key',
    'zone',
]

__config__ = pulumi.Config('yandex')

cloud_id = __config__.get('cloudId')
"""
ID of Yandex.Cloud tenant.
"""

endpoint = __config__.get('endpoint')
"""
The API endpoint for Yandex.Cloud SDK client.
"""

folder_id = __config__.get('folderId')
"""
The default folder ID where resources will be placed.
"""

insecure = __config__.get('insecure')
"""
Explicitly allow the provider to perform "insecure" SSL requests. If omitted,default value is `false`.
"""

max_retries = __config__.get('maxRetries')
"""
The maximum number of times an API request is being executed. If the API request still fails, an error is thrown.
"""

plaintext = __config__.get('plaintext')
"""
Disable use of TLS. Default value is `false`.
"""

service_account_key_file = __config__.get('serviceAccountKeyFile')
"""
Either the path to or the contents of a Service Account key file in JSON format.
"""

storage_access_key = __config__.get('storageAccessKey')
"""
Yandex.Cloud storage service access key. Used when a storage data/resource doesn't have an access key explicitly
specified.
"""

storage_endpoint = __config__.get('storageEndpoint')
"""
Yandex.Cloud storage service endpoint. Default is storage.yandexcloud.net
"""

storage_secret_key = __config__.get('storageSecretKey')
"""
Yandex.Cloud storage service secret key. Used when a storage data/resource doesn't have a secret key explicitly
specified.
"""

token = __config__.get('token')
"""
The access token for API operations.
"""

ymq_access_key = __config__.get('ymqAccessKey')
"""
Yandex.Cloud Message Queue service access key. Used when a message queue resource doesn't have an access key explicitly
specified.
"""

ymq_endpoint = __config__.get('ymqEndpoint')
"""
Yandex.Cloud Message Queue service endpoint. Default is message-queue.api.cloud.yandex.net
"""

ymq_secret_key = __config__.get('ymqSecretKey')
"""
Yandex.Cloud Message Queue service secret key. Used when a message queue resource doesn't have a secret key explicitly
specified.
"""

zone = __config__.get('zone')
"""
The zone where operations will take place. Examples are ru-central1-a, ru-central2-c, etc.
"""

