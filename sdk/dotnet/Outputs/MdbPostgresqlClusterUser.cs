// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class MdbPostgresqlClusterUser
    {
        public readonly int? ConnLimit;
        public readonly ImmutableArray<string> Grants;
        public readonly bool? Login;
        public readonly string Name;
        public readonly string Password;
        public readonly ImmutableArray<Outputs.MdbPostgresqlClusterUserPermission> Permissions;
        public readonly ImmutableDictionary<string, string>? Settings;

        [OutputConstructor]
        private MdbPostgresqlClusterUser(
            int? connLimit,

            ImmutableArray<string> grants,

            bool? login,

            string name,

            string password,

            ImmutableArray<Outputs.MdbPostgresqlClusterUserPermission> permissions,

            ImmutableDictionary<string, string>? settings)
        {
            ConnLimit = connLimit;
            Grants = grants;
            Login = login;
            Name = name;
            Password = password;
            Permissions = permissions;
            Settings = settings;
        }
    }
}
