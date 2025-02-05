// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MongoCluster.Models;

namespace Azure.ResourceManager.MongoCluster.Samples
{
    public partial class Sample_MongoClusterFirewallRuleResource
    {
        // Gets a firewall rule on a Mongo Cluster resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsAFirewallRuleOnAMongoClusterResource()
        {
            // Generated from example definition: 2024-07-01/MongoClusters_FirewallRuleGet.json
            // this example is just showing the usage of "FirewallRule_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoClusterFirewallRuleResource created on azure
            // for more information of creating MongoClusterFirewallRuleResource, please refer to the document of MongoClusterFirewallRuleResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string mongoClusterName = "myMongoCluster";
            string firewallRuleName = "rule1";
            ResourceIdentifier mongoClusterFirewallRuleResourceId = MongoClusterFirewallRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, mongoClusterName, firewallRuleName);
            MongoClusterFirewallRuleResource mongoClusterFirewallRule = client.GetMongoClusterFirewallRuleResource(mongoClusterFirewallRuleResourceId);

            // invoke the operation
            MongoClusterFirewallRuleResource result = await mongoClusterFirewallRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MongoClusterFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Creates a firewall rule on a Mongo Cluster resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreatesAFirewallRuleOnAMongoClusterResource()
        {
            // Generated from example definition: 2024-07-01/MongoClusters_FirewallRuleCreate.json
            // this example is just showing the usage of "FirewallRule_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoClusterFirewallRuleResource created on azure
            // for more information of creating MongoClusterFirewallRuleResource, please refer to the document of MongoClusterFirewallRuleResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string mongoClusterName = "myMongoCluster";
            string firewallRuleName = "rule1";
            ResourceIdentifier mongoClusterFirewallRuleResourceId = MongoClusterFirewallRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, mongoClusterName, firewallRuleName);
            MongoClusterFirewallRuleResource mongoClusterFirewallRule = client.GetMongoClusterFirewallRuleResource(mongoClusterFirewallRuleResourceId);

            // invoke the operation
            MongoClusterFirewallRuleData data = new MongoClusterFirewallRuleData()
            {
                Properties = new MongoClusterFirewallRuleProperties("0.0.0.0", "255.255.255.255"),
            };
            ArmOperation<MongoClusterFirewallRuleResource> lro = await mongoClusterFirewallRule.UpdateAsync(WaitUntil.Completed, data);
            MongoClusterFirewallRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MongoClusterFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Deletes a firewall rule on a Mongo Cluster resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletesAFirewallRuleOnAMongoClusterResource()
        {
            // Generated from example definition: 2024-07-01/MongoClusters_FirewallRuleDelete.json
            // this example is just showing the usage of "FirewallRule_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MongoClusterFirewallRuleResource created on azure
            // for more information of creating MongoClusterFirewallRuleResource, please refer to the document of MongoClusterFirewallRuleResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string mongoClusterName = "myMongoCluster";
            string firewallRuleName = "rule1";
            ResourceIdentifier mongoClusterFirewallRuleResourceId = MongoClusterFirewallRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, mongoClusterName, firewallRuleName);
            MongoClusterFirewallRuleResource mongoClusterFirewallRule = client.GetMongoClusterFirewallRuleResource(mongoClusterFirewallRuleResourceId);

            // invoke the operation
            await mongoClusterFirewallRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
