// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableLogicResourceGroupResource : ArmResource
    {
        private ClientDiagnostics _logicWorkflowWorkflowsClientDiagnostics;
        private WorkflowsRestOperations _logicWorkflowWorkflowsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableLogicResourceGroupResource"/> class for mocking. </summary>
        protected MockableLogicResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableLogicResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableLogicResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics LogicWorkflowWorkflowsClientDiagnostics => _logicWorkflowWorkflowsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Logic", LogicWorkflowResource.ResourceType.Namespace, Diagnostics);
        private WorkflowsRestOperations LogicWorkflowWorkflowsRestClient => _logicWorkflowWorkflowsRestClient ??= new WorkflowsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(LogicWorkflowResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of LogicWorkflowResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of LogicWorkflowResources and their operations over a LogicWorkflowResource. </returns>
        public virtual LogicWorkflowCollection GetLogicWorkflows()
        {
            return GetCachedClient(client => new LogicWorkflowCollection(client, Id));
        }

        /// <summary>
        /// Gets a workflow.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflows_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workflowName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workflowName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<LogicWorkflowResource>> GetLogicWorkflowAsync(string workflowName, CancellationToken cancellationToken = default)
        {
            return await GetLogicWorkflows().GetAsync(workflowName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a workflow.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflows_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workflowName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workflowName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<LogicWorkflowResource> GetLogicWorkflow(string workflowName, CancellationToken cancellationToken = default)
        {
            return GetLogicWorkflows().Get(workflowName, cancellationToken);
        }

        /// <summary> Gets a collection of IntegrationAccountResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of IntegrationAccountResources and their operations over a IntegrationAccountResource. </returns>
        public virtual IntegrationAccountCollection GetIntegrationAccounts()
        {
            return GetCachedClient(client => new IntegrationAccountCollection(client, Id));
        }

        /// <summary>
        /// Gets an integration account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<IntegrationAccountResource>> GetIntegrationAccountAsync(string integrationAccountName, CancellationToken cancellationToken = default)
        {
            return await GetIntegrationAccounts().GetAsync(integrationAccountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an integration account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccounts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<IntegrationAccountResource> GetIntegrationAccount(string integrationAccountName, CancellationToken cancellationToken = default)
        {
            return GetIntegrationAccounts().Get(integrationAccountName, cancellationToken);
        }

        /// <summary> Gets a collection of IntegrationServiceEnvironmentResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of IntegrationServiceEnvironmentResources and their operations over a IntegrationServiceEnvironmentResource. </returns>
        public virtual IntegrationServiceEnvironmentCollection GetIntegrationServiceEnvironments()
        {
            return GetCachedClient(client => new IntegrationServiceEnvironmentCollection(client, Id));
        }

        /// <summary>
        /// Gets an integration service environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationServiceEnvironmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="integrationServiceEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<IntegrationServiceEnvironmentResource>> GetIntegrationServiceEnvironmentAsync(string integrationServiceEnvironmentName, CancellationToken cancellationToken = default)
        {
            return await GetIntegrationServiceEnvironments().GetAsync(integrationServiceEnvironmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an integration service environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationServiceEnvironmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="integrationServiceEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<IntegrationServiceEnvironmentResource> GetIntegrationServiceEnvironment(string integrationServiceEnvironmentName, CancellationToken cancellationToken = default)
        {
            return GetIntegrationServiceEnvironments().Get(integrationServiceEnvironmentName, cancellationToken);
        }

        /// <summary>
        /// Validates the workflow definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/locations/{location}/workflows/{workflowName}/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflows_ValidateByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The workflow location. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="data"> The workflow. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workflowName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workflowName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<Response> ValidateByLocationWorkflowAsync(AzureLocation location, string workflowName, LogicWorkflowData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = LogicWorkflowWorkflowsClientDiagnostics.CreateScope("MockableLogicResourceGroupResource.ValidateByLocationWorkflow");
            scope.Start();
            try
            {
                var response = await LogicWorkflowWorkflowsRestClient.ValidateByLocationAsync(Id.SubscriptionId, Id.ResourceGroupName, location, workflowName, data, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Validates the workflow definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/locations/{location}/workflows/{workflowName}/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflows_ValidateByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The workflow location. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="data"> The workflow. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workflowName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workflowName"/> or <paramref name="data"/> is null. </exception>
        public virtual Response ValidateByLocationWorkflow(AzureLocation location, string workflowName, LogicWorkflowData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = LogicWorkflowWorkflowsClientDiagnostics.CreateScope("MockableLogicResourceGroupResource.ValidateByLocationWorkflow");
            scope.Start();
            try
            {
                var response = LogicWorkflowWorkflowsRestClient.ValidateByLocation(Id.SubscriptionId, Id.ResourceGroupName, location, workflowName, data, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
