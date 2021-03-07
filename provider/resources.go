// Copyright 2016-2018, Pulumi Corporation.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

package yandex

import (
	"fmt"
	"path/filepath"
	"unicode"

	"github.com/aladmit/pulumi-yandex/provider/pkg/version"
	"github.com/hashicorp/terraform-plugin-sdk/helper/schema"
	"github.com/pulumi/pulumi-terraform-bridge/v2/pkg/tfbridge"
	shim "github.com/pulumi/pulumi-terraform-bridge/v2/pkg/tfshim"
	shimv1 "github.com/pulumi/pulumi-terraform-bridge/v2/pkg/tfshim/sdk-v1"
	"github.com/pulumi/pulumi/sdk/v2/go/common/resource"
	"github.com/pulumi/pulumi/sdk/v2/go/common/tokens"
	"github.com/yandex-cloud/terraform-provider-yandex/yandex"
)

// all of the token components used below.
const (
	// packages:
	mainPkg = "yandex"
	// modules:
	mainMod = "index" // the y module
)

// makeMember manufactures a type token for the package and the given module and type.
func makeMember(mod string, mem string) tokens.ModuleMember {
	return tokens.ModuleMember(mainPkg + ":" + mod + ":" + mem)
}

// makeType manufactures a type token for the package and the given module and type.
func makeType(mod string, typ string) tokens.Type {
	return tokens.Type(makeMember(mod, typ))
}

// makeDataSource manufactures a standard resource token given a module and resource name.  It
// automatically uses the main package and names the file by simply lower casing the data source's
// first character.
func makeDataSource(mod string, res string) tokens.ModuleMember {
	fn := string(unicode.ToLower(rune(res[0]))) + res[1:]
	return makeMember(mod+"/"+fn, res)
}

// makeResource manufactures a standard resource token given a module and resource name.  It
// automatically uses the main package and names the file by simply lower casing the resource's
// first character.
func makeResource(mod string, res string) tokens.Type {
	fn := string(unicode.ToLower(rune(res[0]))) + res[1:]
	return makeType(mod+"/"+fn, res)
}

// boolRef returns a reference to the bool argument.
func boolRef(b bool) *bool {
	return &b
}

// stringValue gets a string value from a property map if present, else ""
func stringValue(vars resource.PropertyMap, prop resource.PropertyKey) string {
	val, ok := vars[prop]
	if ok && val.IsString() {
		return val.StringValue()
	}
	return ""
}

// preConfigureCallback is called before the providerConfigure function of the underlying provider.
// It should validate that the provider can be configured, and provide actionable errors in the case
// it cannot be. Configuration variables can be read from `vars` using the `stringValue` function -
// for example `stringValue(vars, "accessKey")`.
func preConfigureCallback(vars resource.PropertyMap, c shim.ResourceConfig) error {
	return nil
}

// managedByPulumi is a default used for some managed resources, in the absence of something more meaningful.
var managedByPulumi = &tfbridge.DefaultInfo{Value: "Managed by Pulumi"}

// Provider returns additional overlaid schema and metadata associated with the provider..
func Provider() tfbridge.ProviderInfo {
	// Instantiate the Terraform provider
	p := shimv1.NewProvider(yandex.Provider().(*schema.Provider))

	// Create a Pulumi provider mapping
	prov := tfbridge.ProviderInfo{
		P:           p,
		Name:        "yandex",
		Description: "A Pulumi package for creating and managing yandex cloud resources.",
		Keywords:    []string{"pulumi", "yandex"},
		License:     "Apache-2.0",
		Homepage:    "https://pulumi.io",
		Repository:  "https://github.com/aladmit/pulumi-yandex",
		Config:      map[string]*tfbridge.SchemaInfo{
			// Add any required configuration here, or remove the example below if
			// no additional points are required.
			// "region": {
			// 	Type: makeType("region", "Region"),
			// 	Default: &tfbridge.DefaultInfo{
			// 		EnvVars: []string{"AWS_REGION", "AWS_DEFAULT_REGION"},
			// 	},
			// },
		},
		PreConfigureCallback: preConfigureCallback,
		Resources: map[string]*tfbridge.ResourceInfo{
			// Map each resource in the Terraform provider to a Pulumi type. Two examples
			// are below - the single line form is the common case. The multi-line form is
			// needed only if you wish to override types or other default options.
			//
			// "aws_iam_role": {Tok: makeResource(mainMod, "IamRole")}
			//
			// "aws_acm_certificate": {
			// 	Tok: makeResource(mainMod, "Certificate"),
			// 	Fields: map[string]*tfbridge.SchemaInfo{
			// 		"tags": {Type: makeType(mainPkg, "Tags")},
			// 	},
			// },

			"yandex_compute_disk":                          {Tok: makeResource(mainMod, "ComputeDisk")},
			"yandex_compute_disk_placement_group":          {Tok: makeResource(mainMod, "ComputeDiskPlacementGroup")},
			"yandex_compute_image":                         {Tok: makeResource(mainMod, "ComputeImage")},
			"yandex_compute_instance":                      {Tok: makeResource(mainMod, "ComputeInstance")},
			"yandex_compute_instance_group":                {Tok: makeResource(mainMod, "ComputeInstanceGroup")},
			"yandex_compute_placement_group":               {Tok: makeResource(mainMod, "ComputePlacementGroup")},
			"yandex_compute_snapshot":                      {Tok: makeResource(mainMod, "ComputeSnapshot")},
			"yandex_container_registry":                    {Tok: makeResource(mainMod, "ContainerRegistry")},
			"yandex_container_registry_iam_binding":        {Tok: makeResource(mainMod, "ContainerRegistryIamBinding")},
			"yandex_dataproc_cluster":                      {Tok: makeResource(mainMod, "DataprocCluster")},
			"yandex_function":                              {Tok: makeResource(mainMod, "Function")},
			"yandex_function_iam_binding":                  {Tok: makeResource(mainMod, "FunctionIamBinding")},
			"yandex_function_trigger":                      {Tok: makeResource(mainMod, "FunctionTrigger")},
			"yandex_iam_service_account":                   {Tok: makeResource(mainMod, "IamServiceCccount")},
			"yandex_iam_service_account_api_key":           {Tok: makeResource(mainMod, "IamServiceAccountApiKey")},
			"yandex_iam_service_account_iam_binding":       {Tok: makeResource(mainMod, "IamServiceAccountIamBinding")},
			"yandex_iam_service_account_iam_member":        {Tok: makeResource(mainMod, "IamServiceAccountIamMember")},
			"yandex_iam_service_account_iam_policy":        {Tok: makeResource(mainMod, "IamServiceAccountIamPolicy")},
			"yandex_iam_service_account_key":               {Tok: makeResource(mainMod, "IamServiceAccountKey")},
			"yandex_iam_service_account_static_access_key": {Tok: makeResource(mainMod, "IamServiceAccountStaticAccessKey")},
			"yandex_iot_core_device":                       {Tok: makeResource(mainMod, "IotCoreDevice")},
			"yandex_iot_core_registry":                     {Tok: makeResource(mainMod, "IotCoreRegistry")},
			"yandex_kms_secret_ciphertext":                 {Tok: makeResource(mainMod, "KmsSecretCiphertext")},
			"yandex_kms_symmetric_key":                     {Tok: makeResource(mainMod, "KmsSymmetricKey")},
			"yandex_kubernetes_cluster":                    {Tok: makeResource(mainMod, "KubernetesCluster")},
			"yandex_kubernetes_node_group":                 {Tok: makeResource(mainMod, "KubernetesNodeGroup")},
			"yandex_lb_network_load_balancer":              {Tok: makeResource(mainMod, "LbNetworkLoad_balancer")},
			"yandex_lb_target_group":                       {Tok: makeResource(mainMod, "LbTargetGroup")},
			"yandex_mdb_clickhouse_cluster":                {Tok: makeResource(mainMod, "MdbClickhouseCluster")},
			"yandex_mdb_kafka_cluster":                     {Tok: makeResource(mainMod, "MdbKafkaCluster")},
			"yandex_mdb_mongodb_cluster":                   {Tok: makeResource(mainMod, "MdbMongodbCluster")},
			"yandex_mdb_mysql_cluster":                     {Tok: makeResource(mainMod, "MdbMysqlCluster")},
			"yandex_mdb_postgresql_cluster":                {Tok: makeResource(mainMod, "MdbPostgresqlCluster")},
			"yandex_mdb_redis_cluster":                     {Tok: makeResource(mainMod, "MdbRedisCluster")},
			"yandex_message_queue":                         {Tok: makeResource(mainMod, "MessageQueue")},
			"yandex_resourcemanager_cloud_iam_binding":     {Tok: makeResource(mainMod, "ResourcemanagerCloudIamBinding")},
			"yandex_resourcemanager_cloud_iam_member":      {Tok: makeResource(mainMod, "ResourcemanagerCloudIamMember")},
			"yandex_resourcemanager_folder_iam_binding":    {Tok: makeResource(mainMod, "ResourcemanagerFolderIamBinding")},
			"yandex_resourcemanager_folder_iam_member":     {Tok: makeResource(mainMod, "ResourcemanagerFolderIamMember")},
			"yandex_resourcemanager_folder_iam_policy":     {Tok: makeResource(mainMod, "ResourcemanagerFolderIamPolicy")},
			"yandex_storage_bucket":                        {Tok: makeResource(mainMod, "StorageBucket")},
			"yandex_storage_object":                        {Tok: makeResource(mainMod, "StorageObjet")},
			"yandex_vpc_address":                           {Tok: makeResource(mainMod, "VpcAddress")},
			"yandex_vpc_network":                           {Tok: makeResource(mainMod, "VpcNetwork")},
			"yandex_vpc_route_table":                       {Tok: makeResource(mainMod, "VpcRouteTable")},
			"yandex_vpc_security_group":                    {Tok: makeResource(mainMod, "VpcSecurityGroup")},
			"yandex_vpc_subnet":                            {Tok: makeResource(mainMod, "VpcSubnet")},
		},
		DataSources: map[string]*tfbridge.DataSourceInfo{
			// Map each resource in the Terraform provider to a Pulumi function. An example
			// is below.
			// "aws_ami": {Tok: makeDataSource(mainMod, "getAmi")},

			"yandex_client_config":                {Tok: makeDataSource(mainMod, "getClientconfig")},
			"yandex_compute_disk":                 {Tok: makeDataSource(mainMod, "getComputeDisk")},
			"yandex_compute_disk_placement_group": {Tok: makeDataSource(mainMod, "getComputeDiskPlacementGroup")},
			"yandex_compute_image":                {Tok: makeDataSource(mainMod, "getComputeImage")},
			"yandex_compute_instance":             {Tok: makeDataSource(mainMod, "getComputeInstance")},
			"yandex_compute_instance_group":       {Tok: makeDataSource(mainMod, "getComputeInstanceGroup")},
			"yandex_compute_placement_group":      {Tok: makeDataSource(mainMod, "getComputePlacementGroup")},
			"yandex_compute_snapshot":             {Tok: makeDataSource(mainMod, "getComputeSnapshot")},
			"yandex_container_registry":           {Tok: makeDataSource(mainMod, "getContainerRegistry")},
			"yandex_dataproc_cluster":             {Tok: makeDataSource(mainMod, "getDataprocCluster")},
			"yandex_function":                     {Tok: makeDataSource(mainMod, "getFunction")},
			"yandex_function_trigger":             {Tok: makeDataSource(mainMod, "getFunctionTrigger")},
			"yandex_iam_policy":                   {Tok: makeDataSource(mainMod, "getIamPolicy")},
			"yandex_iam_role":                     {Tok: makeDataSource(mainMod, "getIamRole")},
			"yandex_iam_service_account":          {Tok: makeDataSource(mainMod, "getIamServiceAccount")},
			"yandex_iam_user":                     {Tok: makeDataSource(mainMod, "getIamUser")},
			"yandex_iot_core_device":              {Tok: makeDataSource(mainMod, "getIotCoreDevice")},
			"yandex_iot_core_registry":            {Tok: makeDataSource(mainMod, "getIotCoreRegistry")},
			"yandex_kubernetes_cluster":           {Tok: makeDataSource(mainMod, "getKubernetesCluster")},
			"yandex_kubernetes_node_group":        {Tok: makeDataSource(mainMod, "getKubernetesNodeGroup")},
			"yandex_lb_network_load_balancer":     {Tok: makeDataSource(mainMod, "getLbNetworkLoadBalancer")},
			"yandex_lb_target_group":              {Tok: makeDataSource(mainMod, "getLbTargetGroup")},
			"yandex_mdb_clickhouse_cluster":       {Tok: makeDataSource(mainMod, "getMdbClickhouseCluster")},
			"yandex_mdb_kafka_cluster":            {Tok: makeDataSource(mainMod, "getMdbKafkaCluster")},
			"yandex_mdb_mongodb_cluster":          {Tok: makeDataSource(mainMod, "getMdbMongodbCluster")},
			"yandex_mdb_mysql_cluster":            {Tok: makeDataSource(mainMod, "getMdbMysqlCluster")},
			"yandex_mdb_postgresql_cluster":       {Tok: makeDataSource(mainMod, "getMdbPostgresqlCluster")},
			"yandex_mdb_redis_cluster":            {Tok: makeDataSource(mainMod, "getMdbRedisCluster")},
			"yandex_message_queue":                {Tok: makeDataSource(mainMod, "getMessageQueue")},
			"yandex_resourcemanager_cloud":        {Tok: makeDataSource(mainMod, "getResourcemanagerCloud")},
			"yandex_resourcemanager_folder":       {Tok: makeDataSource(mainMod, "getResourcemanagerFolder")},
			"yandex_vpc_address":                  {Tok: makeDataSource(mainMod, "getVpcAddress")},
			"yandex_vpc_network":                  {Tok: makeDataSource(mainMod, "getVpcNetwork")},
			"yandex_vpc_route_table":              {Tok: makeDataSource(mainMod, "getVpcRouteTable")},
			"yandex_vpc_security_group":           {Tok: makeDataSource(mainMod, "getVpcSecurityGroup")},
			"yandex_vpc_subnet":                   {Tok: makeDataSource(mainMod, "getVpcSubnet")},
		},
		JavaScript: &tfbridge.JavaScriptInfo{
			// List any npm dependencies and their versions
			Dependencies: map[string]string{
				"@pulumi/pulumi": "^2.15.0",
			},
			DevDependencies: map[string]string{
				"@types/node": "^8.0.25", // so we can access strongly typed node definitions.
				"@types/mime": "^2.0.0",
			},
			// See the documentation for tfbridge.OverlayInfo for how to lay out this
			// section, or refer to the AWS provider. Delete this section if there are
			// no overlay files.
			//Overlay: &tfbridge.OverlayInfo{},
		},
		Python: &tfbridge.PythonInfo{
			// List any Python dependencies and their version ranges
			Requires: map[string]string{
				"pulumi": ">=2.15.0,<3.0.0",
			},
		},
		Golang: &tfbridge.GolangInfo{
			ImportBasePath: filepath.Join(
				fmt.Sprintf("github.com/aladmit/pulumi-%[1]s/sdk/", mainPkg),
				tfbridge.GetModuleMajorVersion(version.Version),
				"go",
				mainPkg,
			),
			GenerateResourceContainerTypes: true,
		},
		CSharp: &tfbridge.CSharpInfo{
			PackageReferences: map[string]string{
				"Pulumi":                       "2.*",
				"System.Collections.Immutable": "1.6.0",
			},
		},
	}

	prov.SetAutonaming(255, "-")

	return prov
}
