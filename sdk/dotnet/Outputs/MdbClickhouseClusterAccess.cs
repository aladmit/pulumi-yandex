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
    public sealed class MdbClickhouseClusterAccess
    {
        public readonly bool? DataLens;
        public readonly bool? Metrika;
        public readonly bool? Serverless;
        public readonly bool? WebSql;

        [OutputConstructor]
        private MdbClickhouseClusterAccess(
            bool? dataLens,

            bool? metrika,

            bool? serverless,

            bool? webSql)
        {
            DataLens = dataLens;
            Metrika = metrika;
            Serverless = serverless;
            WebSql = webSql;
        }
    }
}
