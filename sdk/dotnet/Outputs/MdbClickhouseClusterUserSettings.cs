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
    public sealed class MdbClickhouseClusterUserSettings
    {
        public readonly bool? AddHttpCorsHeader;
        public readonly bool? AllowDdl;
        public readonly bool? Compile;
        public readonly bool? CompileExpressions;
        public readonly int? ConnectTimeout;
        public readonly string? CountDistinctImplementation;
        public readonly string? DistinctOverflowMode;
        public readonly bool? DistributedAggregationMemoryEfficient;
        public readonly int? DistributedDdlTaskTimeout;
        public readonly string? DistributedProductMode;
        public readonly bool? EmptyResultForAggregationByEmptySet;
        public readonly bool? EnableHttpCompression;
        public readonly bool? FallbackToStaleReplicasForDistributedQueries;
        public readonly bool? ForceIndexByDate;
        public readonly bool? ForcePrimaryKey;
        public readonly string? GroupByOverflowMode;
        public readonly int? GroupByTwoLevelThreshold;
        public readonly int? GroupByTwoLevelThresholdBytes;
        public readonly int? HttpConnectionTimeout;
        public readonly int? HttpHeadersProgressInterval;
        public readonly int? HttpReceiveTimeout;
        public readonly int? HttpSendTimeout;
        public readonly bool? InputFormatDefaultsForOmittedFields;
        public readonly bool? InputFormatValuesInterpretExpressions;
        public readonly int? InsertQuorum;
        public readonly int? InsertQuorumTimeout;
        public readonly string? JoinOverflowMode;
        public readonly bool? JoinUseNulls;
        public readonly bool? JoinedSubqueryRequiresAlias;
        public readonly bool? LowCardinalityAllowInNativeFormat;
        public readonly int? MaxAstDepth;
        public readonly int? MaxAstElements;
        public readonly int? MaxBlockSize;
        public readonly int? MaxBytesBeforeExternalGroupBy;
        public readonly int? MaxBytesBeforeExternalSort;
        public readonly int? MaxBytesInDistinct;
        public readonly int? MaxBytesInJoin;
        public readonly int? MaxBytesInSet;
        public readonly int? MaxBytesToRead;
        public readonly int? MaxBytesToSort;
        public readonly int? MaxBytesToTransfer;
        public readonly int? MaxColumnsToRead;
        public readonly int? MaxExecutionTime;
        public readonly int? MaxExpandedAstElements;
        public readonly int? MaxInsertBlockSize;
        public readonly int? MaxMemoryUsage;
        public readonly int? MaxMemoryUsageForUser;
        public readonly int? MaxNetworkBandwidth;
        public readonly int? MaxNetworkBandwidthForUser;
        public readonly int? MaxQuerySize;
        public readonly int? MaxReplicaDelayForDistributedQueries;
        public readonly int? MaxResultBytes;
        public readonly int? MaxResultRows;
        public readonly int? MaxRowsInDistinct;
        public readonly int? MaxRowsInJoin;
        public readonly int? MaxRowsInSet;
        public readonly int? MaxRowsToGroupBy;
        public readonly int? MaxRowsToRead;
        public readonly int? MaxRowsToSort;
        public readonly int? MaxRowsToTransfer;
        public readonly int? MaxTemporaryColumns;
        public readonly int? MaxTemporaryNonConstColumns;
        public readonly int? MaxThreads;
        public readonly int? MergeTreeMaxBytesToUseCache;
        public readonly int? MergeTreeMaxRowsToUseCache;
        public readonly int? MergeTreeMinBytesForConcurrentRead;
        public readonly int? MergeTreeMinRowsForConcurrentRead;
        public readonly int? MinBytesToUseDirectIo;
        public readonly int? MinCountToCompile;
        public readonly int? MinCountToCompileExpression;
        public readonly int? MinExecutionSpeed;
        public readonly int? MinExecutionSpeedBytes;
        public readonly int? MinInsertBlockSizeBytes;
        public readonly int? MinInsertBlockSizeRows;
        public readonly bool? OutputFormatJsonQuote64bitIntegers;
        public readonly bool? OutputFormatJsonQuoteDenormals;
        public readonly int? Priority;
        public readonly string? QuotaMode;
        public readonly string? ReadOverflowMode;
        public readonly int? Readonly;
        public readonly int? ReceiveTimeout;
        public readonly int? ReplicationAlterPartitionsSync;
        public readonly string? ResultOverflowMode;
        public readonly bool? SelectSequentialConsistency;
        public readonly bool? SendProgressInHttpHeaders;
        public readonly int? SendTimeout;
        public readonly string? SetOverflowMode;
        public readonly bool? SkipUnavailableShards;
        public readonly string? SortOverflowMode;
        public readonly string? TimeoutOverflowMode;
        public readonly string? TransferOverflowMode;
        public readonly bool? TransformNullIn;
        public readonly bool? UseUncompressedCache;

        [OutputConstructor]
        private MdbClickhouseClusterUserSettings(
            bool? addHttpCorsHeader,

            bool? allowDdl,

            bool? compile,

            bool? compileExpressions,

            int? connectTimeout,

            string? countDistinctImplementation,

            string? distinctOverflowMode,

            bool? distributedAggregationMemoryEfficient,

            int? distributedDdlTaskTimeout,

            string? distributedProductMode,

            bool? emptyResultForAggregationByEmptySet,

            bool? enableHttpCompression,

            bool? fallbackToStaleReplicasForDistributedQueries,

            bool? forceIndexByDate,

            bool? forcePrimaryKey,

            string? groupByOverflowMode,

            int? groupByTwoLevelThreshold,

            int? groupByTwoLevelThresholdBytes,

            int? httpConnectionTimeout,

            int? httpHeadersProgressInterval,

            int? httpReceiveTimeout,

            int? httpSendTimeout,

            bool? inputFormatDefaultsForOmittedFields,

            bool? inputFormatValuesInterpretExpressions,

            int? insertQuorum,

            int? insertQuorumTimeout,

            string? joinOverflowMode,

            bool? joinUseNulls,

            bool? joinedSubqueryRequiresAlias,

            bool? lowCardinalityAllowInNativeFormat,

            int? maxAstDepth,

            int? maxAstElements,

            int? maxBlockSize,

            int? maxBytesBeforeExternalGroupBy,

            int? maxBytesBeforeExternalSort,

            int? maxBytesInDistinct,

            int? maxBytesInJoin,

            int? maxBytesInSet,

            int? maxBytesToRead,

            int? maxBytesToSort,

            int? maxBytesToTransfer,

            int? maxColumnsToRead,

            int? maxExecutionTime,

            int? maxExpandedAstElements,

            int? maxInsertBlockSize,

            int? maxMemoryUsage,

            int? maxMemoryUsageForUser,

            int? maxNetworkBandwidth,

            int? maxNetworkBandwidthForUser,

            int? maxQuerySize,

            int? maxReplicaDelayForDistributedQueries,

            int? maxResultBytes,

            int? maxResultRows,

            int? maxRowsInDistinct,

            int? maxRowsInJoin,

            int? maxRowsInSet,

            int? maxRowsToGroupBy,

            int? maxRowsToRead,

            int? maxRowsToSort,

            int? maxRowsToTransfer,

            int? maxTemporaryColumns,

            int? maxTemporaryNonConstColumns,

            int? maxThreads,

            int? mergeTreeMaxBytesToUseCache,

            int? mergeTreeMaxRowsToUseCache,

            int? mergeTreeMinBytesForConcurrentRead,

            int? mergeTreeMinRowsForConcurrentRead,

            int? minBytesToUseDirectIo,

            int? minCountToCompile,

            int? minCountToCompileExpression,

            int? minExecutionSpeed,

            int? minExecutionSpeedBytes,

            int? minInsertBlockSizeBytes,

            int? minInsertBlockSizeRows,

            bool? outputFormatJsonQuote64bitIntegers,

            bool? outputFormatJsonQuoteDenormals,

            int? priority,

            string? quotaMode,

            string? readOverflowMode,

            int? @readonly,

            int? receiveTimeout,

            int? replicationAlterPartitionsSync,

            string? resultOverflowMode,

            bool? selectSequentialConsistency,

            bool? sendProgressInHttpHeaders,

            int? sendTimeout,

            string? setOverflowMode,

            bool? skipUnavailableShards,

            string? sortOverflowMode,

            string? timeoutOverflowMode,

            string? transferOverflowMode,

            bool? transformNullIn,

            bool? useUncompressedCache)
        {
            AddHttpCorsHeader = addHttpCorsHeader;
            AllowDdl = allowDdl;
            Compile = compile;
            CompileExpressions = compileExpressions;
            ConnectTimeout = connectTimeout;
            CountDistinctImplementation = countDistinctImplementation;
            DistinctOverflowMode = distinctOverflowMode;
            DistributedAggregationMemoryEfficient = distributedAggregationMemoryEfficient;
            DistributedDdlTaskTimeout = distributedDdlTaskTimeout;
            DistributedProductMode = distributedProductMode;
            EmptyResultForAggregationByEmptySet = emptyResultForAggregationByEmptySet;
            EnableHttpCompression = enableHttpCompression;
            FallbackToStaleReplicasForDistributedQueries = fallbackToStaleReplicasForDistributedQueries;
            ForceIndexByDate = forceIndexByDate;
            ForcePrimaryKey = forcePrimaryKey;
            GroupByOverflowMode = groupByOverflowMode;
            GroupByTwoLevelThreshold = groupByTwoLevelThreshold;
            GroupByTwoLevelThresholdBytes = groupByTwoLevelThresholdBytes;
            HttpConnectionTimeout = httpConnectionTimeout;
            HttpHeadersProgressInterval = httpHeadersProgressInterval;
            HttpReceiveTimeout = httpReceiveTimeout;
            HttpSendTimeout = httpSendTimeout;
            InputFormatDefaultsForOmittedFields = inputFormatDefaultsForOmittedFields;
            InputFormatValuesInterpretExpressions = inputFormatValuesInterpretExpressions;
            InsertQuorum = insertQuorum;
            InsertQuorumTimeout = insertQuorumTimeout;
            JoinOverflowMode = joinOverflowMode;
            JoinUseNulls = joinUseNulls;
            JoinedSubqueryRequiresAlias = joinedSubqueryRequiresAlias;
            LowCardinalityAllowInNativeFormat = lowCardinalityAllowInNativeFormat;
            MaxAstDepth = maxAstDepth;
            MaxAstElements = maxAstElements;
            MaxBlockSize = maxBlockSize;
            MaxBytesBeforeExternalGroupBy = maxBytesBeforeExternalGroupBy;
            MaxBytesBeforeExternalSort = maxBytesBeforeExternalSort;
            MaxBytesInDistinct = maxBytesInDistinct;
            MaxBytesInJoin = maxBytesInJoin;
            MaxBytesInSet = maxBytesInSet;
            MaxBytesToRead = maxBytesToRead;
            MaxBytesToSort = maxBytesToSort;
            MaxBytesToTransfer = maxBytesToTransfer;
            MaxColumnsToRead = maxColumnsToRead;
            MaxExecutionTime = maxExecutionTime;
            MaxExpandedAstElements = maxExpandedAstElements;
            MaxInsertBlockSize = maxInsertBlockSize;
            MaxMemoryUsage = maxMemoryUsage;
            MaxMemoryUsageForUser = maxMemoryUsageForUser;
            MaxNetworkBandwidth = maxNetworkBandwidth;
            MaxNetworkBandwidthForUser = maxNetworkBandwidthForUser;
            MaxQuerySize = maxQuerySize;
            MaxReplicaDelayForDistributedQueries = maxReplicaDelayForDistributedQueries;
            MaxResultBytes = maxResultBytes;
            MaxResultRows = maxResultRows;
            MaxRowsInDistinct = maxRowsInDistinct;
            MaxRowsInJoin = maxRowsInJoin;
            MaxRowsInSet = maxRowsInSet;
            MaxRowsToGroupBy = maxRowsToGroupBy;
            MaxRowsToRead = maxRowsToRead;
            MaxRowsToSort = maxRowsToSort;
            MaxRowsToTransfer = maxRowsToTransfer;
            MaxTemporaryColumns = maxTemporaryColumns;
            MaxTemporaryNonConstColumns = maxTemporaryNonConstColumns;
            MaxThreads = maxThreads;
            MergeTreeMaxBytesToUseCache = mergeTreeMaxBytesToUseCache;
            MergeTreeMaxRowsToUseCache = mergeTreeMaxRowsToUseCache;
            MergeTreeMinBytesForConcurrentRead = mergeTreeMinBytesForConcurrentRead;
            MergeTreeMinRowsForConcurrentRead = mergeTreeMinRowsForConcurrentRead;
            MinBytesToUseDirectIo = minBytesToUseDirectIo;
            MinCountToCompile = minCountToCompile;
            MinCountToCompileExpression = minCountToCompileExpression;
            MinExecutionSpeed = minExecutionSpeed;
            MinExecutionSpeedBytes = minExecutionSpeedBytes;
            MinInsertBlockSizeBytes = minInsertBlockSizeBytes;
            MinInsertBlockSizeRows = minInsertBlockSizeRows;
            OutputFormatJsonQuote64bitIntegers = outputFormatJsonQuote64bitIntegers;
            OutputFormatJsonQuoteDenormals = outputFormatJsonQuoteDenormals;
            Priority = priority;
            QuotaMode = quotaMode;
            ReadOverflowMode = readOverflowMode;
            Readonly = @readonly;
            ReceiveTimeout = receiveTimeout;
            ReplicationAlterPartitionsSync = replicationAlterPartitionsSync;
            ResultOverflowMode = resultOverflowMode;
            SelectSequentialConsistency = selectSequentialConsistency;
            SendProgressInHttpHeaders = sendProgressInHttpHeaders;
            SendTimeout = sendTimeout;
            SetOverflowMode = setOverflowMode;
            SkipUnavailableShards = skipUnavailableShards;
            SortOverflowMode = sortOverflowMode;
            TimeoutOverflowMode = timeoutOverflowMode;
            TransferOverflowMode = transferOverflowMode;
            TransformNullIn = transformNullIn;
            UseUncompressedCache = useUncompressedCache;
        }
    }
}
