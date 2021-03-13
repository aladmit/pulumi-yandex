# Unofficial Pulumi Yandex.Cloud Resource Provider

This resource provider for Pulumi lets you create, deploy and manage resources in Yandex.Cloud. Provider does everything [official terraform provider](https://github.com/yandex-cloud/terraform-provider-yandex) does. 

I don't have resources at the moment to support full documentation for all resources, but you always can use [official terraform provider documentation](https://registry.terraform.io/providers/yandex-cloud/yandex/latest/docs), everything works the same.

> Its published only as javascript/typescript package. Packages for other languages will be published later.

## How to install provider

Add provider to your package.json

```
    $ npm install @aladmit/yandex

or `yarn`:

    $ yarn add @aladmit/yandex
```

## Configuration

```typescript
import * as pulumi from "@pulumi/pulumi";
import * as yandex from "@aladmit/yandex;

export const vpc = yandex.getVpcSubnet({
    name: "default-ru-central1-c"
});

// Its posibble to configure provider by keys or environment variables
const provider = new yandex.Provider("yandex", {
    token: "auth_token_here",
    cloudId: "cloud_id_here",
    folderId: "folder_id_here",
    zone: "ru-central1-a"
});


export const vpc = yandex.getVpcSubnet({
    name: "default-ru-central1-c"
}, { provider: provider });
```

The following configuration points are available for the `yandex` provider:

| Configuratino key              | Environment VAR               | Description                                                                                                                                                                                                       |
| -                              | -                             | -                                                                                                                                                                                                                 |
| `token`                        | `YC_TOKEN`                    | Security token or IAM token used for authentication in Yandex.Cloud                                                                                                                                               |
| `service_account_key_file`     | `YC_SERVICE_ACCOUNT_KEY_FILE` | Contains either a path to or the contents of the Service Account file in JSON format.                                                                                                                             |
| `cloud_id` (Required)          | `YC_CLOUD_ID`                 | The ID of the cloud to apply any resources to.                                                                                                                                                                    |
| `folder_id`(Required)          | `YC_FOLDER_ID`                | The ID of the folder to operate under, if not specified by a given resource.                                                                                                                                      |
| `zone` (Optional)              | `YC_ZONE`                     | The default availability zone to operate under, if not specified by a given resource.                                                                                                                             |
| `storage_access_key`(Optional) | `YC_STORAGE_ACCESS_KEY`       | Yandex.Cloud storage service access key, which is used when a storage data/resource doesn't have an access key explicitly specified.                                                                              |
| `storage_secret_key`(Optional) | `YC_STORAGE_SECRET_KEY`       | Yandex.Cloud storage service secret key, which is used when a storage data/resource doesn't have a secret key explicitly specified.                                                                               |
| `ymq_access_key` (Optional)    | `YC_MESSAGE_QUEUE_ACCESS_KEY` | Yandex.Cloud Message Queue service access key, which is used when a YMQ queue resource doesn't have an access key explicitly specified.                                                                           |
| `ymq_secret_key` (Optional)    | `YC_MESSAGE_QUEUE_SECRET_KEY` | Yandex.Cloud Message Queue service secret key, which is used when a YMQ queue resource doesn't have a secret key explicitly specified.                                                                            |
| `max_retries` (Optional)       |                               | This is the maximum number of times an API call is retried, in the case where requests are being throttled or experiencing transient failures. The delay between the subsequent API calls increases exponentially |
