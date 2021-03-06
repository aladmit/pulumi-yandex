// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    [YandexResourceType("yandex:index/mdbClickhouseCluster:MdbClickhouseCluster")]
    public partial class MdbClickhouseCluster : Pulumi.CustomResource
    {
        [Output("access")]
        public Output<Outputs.MdbClickhouseClusterAccess> Access { get; private set; } = null!;

        [Output("adminPassword")]
        public Output<string?> AdminPassword { get; private set; } = null!;

        [Output("backupWindowStart")]
        public Output<Outputs.MdbClickhouseClusterBackupWindowStart> BackupWindowStart { get; private set; } = null!;

        [Output("clickhouse")]
        public Output<Outputs.MdbClickhouseClusterClickhouse> Clickhouse { get; private set; } = null!;

        [Output("copySchemaOnNewHosts")]
        public Output<bool?> CopySchemaOnNewHosts { get; private set; } = null!;

        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        [Output("databases")]
        public Output<ImmutableArray<Outputs.MdbClickhouseClusterDatabase>> Databases { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("environment")]
        public Output<string> Environment { get; private set; } = null!;

        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        [Output("formatSchemas")]
        public Output<ImmutableArray<Outputs.MdbClickhouseClusterFormatSchema>> FormatSchemas { get; private set; } = null!;

        [Output("health")]
        public Output<string> Health { get; private set; } = null!;

        [Output("hosts")]
        public Output<ImmutableArray<Outputs.MdbClickhouseClusterHost>> Hosts { get; private set; } = null!;

        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        [Output("mlModels")]
        public Output<ImmutableArray<Outputs.MdbClickhouseClusterMlModel>> MlModels { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("networkId")]
        public Output<string> NetworkId { get; private set; } = null!;

        [Output("securityGroupIds")]
        public Output<ImmutableArray<string>> SecurityGroupIds { get; private set; } = null!;

        [Output("shardGroups")]
        public Output<ImmutableArray<Outputs.MdbClickhouseClusterShardGroup>> ShardGroups { get; private set; } = null!;

        [Output("sqlDatabaseManagement")]
        public Output<bool> SqlDatabaseManagement { get; private set; } = null!;

        [Output("sqlUserManagement")]
        public Output<bool> SqlUserManagement { get; private set; } = null!;

        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        [Output("users")]
        public Output<ImmutableArray<Outputs.MdbClickhouseClusterUser>> Users { get; private set; } = null!;

        [Output("version")]
        public Output<string> Version { get; private set; } = null!;

        [Output("zookeeper")]
        public Output<Outputs.MdbClickhouseClusterZookeeper> Zookeeper { get; private set; } = null!;


        /// <summary>
        /// Create a MdbClickhouseCluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MdbClickhouseCluster(string name, MdbClickhouseClusterArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/mdbClickhouseCluster:MdbClickhouseCluster", name, args ?? new MdbClickhouseClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MdbClickhouseCluster(string name, Input<string> id, MdbClickhouseClusterState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/mdbClickhouseCluster:MdbClickhouseCluster", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing MdbClickhouseCluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MdbClickhouseCluster Get(string name, Input<string> id, MdbClickhouseClusterState? state = null, CustomResourceOptions? options = null)
        {
            return new MdbClickhouseCluster(name, id, state, options);
        }
    }

    public sealed class MdbClickhouseClusterArgs : Pulumi.ResourceArgs
    {
        [Input("access")]
        public Input<Inputs.MdbClickhouseClusterAccessArgs>? Access { get; set; }

        [Input("adminPassword")]
        public Input<string>? AdminPassword { get; set; }

        [Input("backupWindowStart")]
        public Input<Inputs.MdbClickhouseClusterBackupWindowStartArgs>? BackupWindowStart { get; set; }

        [Input("clickhouse", required: true)]
        public Input<Inputs.MdbClickhouseClusterClickhouseArgs> Clickhouse { get; set; } = null!;

        [Input("copySchemaOnNewHosts")]
        public Input<bool>? CopySchemaOnNewHosts { get; set; }

        [Input("databases")]
        private InputList<Inputs.MdbClickhouseClusterDatabaseArgs>? _databases;
        public InputList<Inputs.MdbClickhouseClusterDatabaseArgs> Databases
        {
            get => _databases ?? (_databases = new InputList<Inputs.MdbClickhouseClusterDatabaseArgs>());
            set => _databases = value;
        }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("environment", required: true)]
        public Input<string> Environment { get; set; } = null!;

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("formatSchemas")]
        private InputList<Inputs.MdbClickhouseClusterFormatSchemaArgs>? _formatSchemas;
        public InputList<Inputs.MdbClickhouseClusterFormatSchemaArgs> FormatSchemas
        {
            get => _formatSchemas ?? (_formatSchemas = new InputList<Inputs.MdbClickhouseClusterFormatSchemaArgs>());
            set => _formatSchemas = value;
        }

        [Input("hosts", required: true)]
        private InputList<Inputs.MdbClickhouseClusterHostArgs>? _hosts;
        public InputList<Inputs.MdbClickhouseClusterHostArgs> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<Inputs.MdbClickhouseClusterHostArgs>());
            set => _hosts = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("mlModels")]
        private InputList<Inputs.MdbClickhouseClusterMlModelArgs>? _mlModels;
        public InputList<Inputs.MdbClickhouseClusterMlModelArgs> MlModels
        {
            get => _mlModels ?? (_mlModels = new InputList<Inputs.MdbClickhouseClusterMlModelArgs>());
            set => _mlModels = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("networkId", required: true)]
        public Input<string> NetworkId { get; set; } = null!;

        [Input("securityGroupIds")]
        private InputList<string>? _securityGroupIds;
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        [Input("shardGroups")]
        private InputList<Inputs.MdbClickhouseClusterShardGroupArgs>? _shardGroups;
        public InputList<Inputs.MdbClickhouseClusterShardGroupArgs> ShardGroups
        {
            get => _shardGroups ?? (_shardGroups = new InputList<Inputs.MdbClickhouseClusterShardGroupArgs>());
            set => _shardGroups = value;
        }

        [Input("sqlDatabaseManagement")]
        public Input<bool>? SqlDatabaseManagement { get; set; }

        [Input("sqlUserManagement")]
        public Input<bool>? SqlUserManagement { get; set; }

        [Input("users")]
        private InputList<Inputs.MdbClickhouseClusterUserArgs>? _users;
        public InputList<Inputs.MdbClickhouseClusterUserArgs> Users
        {
            get => _users ?? (_users = new InputList<Inputs.MdbClickhouseClusterUserArgs>());
            set => _users = value;
        }

        [Input("version")]
        public Input<string>? Version { get; set; }

        [Input("zookeeper")]
        public Input<Inputs.MdbClickhouseClusterZookeeperArgs>? Zookeeper { get; set; }

        public MdbClickhouseClusterArgs()
        {
        }
    }

    public sealed class MdbClickhouseClusterState : Pulumi.ResourceArgs
    {
        [Input("access")]
        public Input<Inputs.MdbClickhouseClusterAccessGetArgs>? Access { get; set; }

        [Input("adminPassword")]
        public Input<string>? AdminPassword { get; set; }

        [Input("backupWindowStart")]
        public Input<Inputs.MdbClickhouseClusterBackupWindowStartGetArgs>? BackupWindowStart { get; set; }

        [Input("clickhouse")]
        public Input<Inputs.MdbClickhouseClusterClickhouseGetArgs>? Clickhouse { get; set; }

        [Input("copySchemaOnNewHosts")]
        public Input<bool>? CopySchemaOnNewHosts { get; set; }

        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("databases")]
        private InputList<Inputs.MdbClickhouseClusterDatabaseGetArgs>? _databases;
        public InputList<Inputs.MdbClickhouseClusterDatabaseGetArgs> Databases
        {
            get => _databases ?? (_databases = new InputList<Inputs.MdbClickhouseClusterDatabaseGetArgs>());
            set => _databases = value;
        }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("environment")]
        public Input<string>? Environment { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("formatSchemas")]
        private InputList<Inputs.MdbClickhouseClusterFormatSchemaGetArgs>? _formatSchemas;
        public InputList<Inputs.MdbClickhouseClusterFormatSchemaGetArgs> FormatSchemas
        {
            get => _formatSchemas ?? (_formatSchemas = new InputList<Inputs.MdbClickhouseClusterFormatSchemaGetArgs>());
            set => _formatSchemas = value;
        }

        [Input("health")]
        public Input<string>? Health { get; set; }

        [Input("hosts")]
        private InputList<Inputs.MdbClickhouseClusterHostGetArgs>? _hosts;
        public InputList<Inputs.MdbClickhouseClusterHostGetArgs> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<Inputs.MdbClickhouseClusterHostGetArgs>());
            set => _hosts = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("mlModels")]
        private InputList<Inputs.MdbClickhouseClusterMlModelGetArgs>? _mlModels;
        public InputList<Inputs.MdbClickhouseClusterMlModelGetArgs> MlModels
        {
            get => _mlModels ?? (_mlModels = new InputList<Inputs.MdbClickhouseClusterMlModelGetArgs>());
            set => _mlModels = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("networkId")]
        public Input<string>? NetworkId { get; set; }

        [Input("securityGroupIds")]
        private InputList<string>? _securityGroupIds;
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        [Input("shardGroups")]
        private InputList<Inputs.MdbClickhouseClusterShardGroupGetArgs>? _shardGroups;
        public InputList<Inputs.MdbClickhouseClusterShardGroupGetArgs> ShardGroups
        {
            get => _shardGroups ?? (_shardGroups = new InputList<Inputs.MdbClickhouseClusterShardGroupGetArgs>());
            set => _shardGroups = value;
        }

        [Input("sqlDatabaseManagement")]
        public Input<bool>? SqlDatabaseManagement { get; set; }

        [Input("sqlUserManagement")]
        public Input<bool>? SqlUserManagement { get; set; }

        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("users")]
        private InputList<Inputs.MdbClickhouseClusterUserGetArgs>? _users;
        public InputList<Inputs.MdbClickhouseClusterUserGetArgs> Users
        {
            get => _users ?? (_users = new InputList<Inputs.MdbClickhouseClusterUserGetArgs>());
            set => _users = value;
        }

        [Input("version")]
        public Input<string>? Version { get; set; }

        [Input("zookeeper")]
        public Input<Inputs.MdbClickhouseClusterZookeeperGetArgs>? Zookeeper { get; set; }

        public MdbClickhouseClusterState()
        {
        }
    }
}
